using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace midi轉換器Csh
{
    public partial class mus
    {
        /// <summary>載入資料</summary>
        byte[] data;
        #region 常數
        const string head = "MThd";
        const string track = "MTrk";
        /// <summary>輸出音調1</summary>
        const string toneName1 = "1a2b34d5e6f70";
        /// <summary>輸出音調2</summary>
        const string toneName2 = "0vwxyzabcdef";
        #endregion
        class q__x
        {
            /// <summary>音符代號</summary>       
            public int tone = -1;
            /// <summary>節奏(xx時間)</summary>
            public double rhythm = 0;
            /// <summary>音軌0x80~0x8f,0x90~0x9f,0~f</summary>
            public int trecktype;
            public q__x() { }
            public q__x(int tone, double rhythm)
            {
                this.tone = tone;
                this.rhythm = rhythm;
            }
            public q__x(int tone, double rhythm, int trecktype)
            {
                this.tone = tone;
                this.rhythm = rhythm;
                this.trecktype = trecktype;
            }
            /// <summary>將資料加入到陣列最後加入</summary>
            public static void Endadd(ref q__x[] q__x, int tone, double rhythm)
            {
                Array.Resize(ref q__x, q__x.Length + 1);
                q__x[q__x.Length - 1] = new q__x(tone, rhythm);
            }
            /// <summary>尋找音符代號相同的第一個索引植</summary>
            /// <param name="tone">要尋找的音符代號</param>
            public static int find_tone_Index(q__x[] q__x, int tone,int tty)
            {
                return Array.IndexOf(q__x.Select(x => x != null ?
                new { atone = x.tone, atty = x.trecktype } :
                new { atone = -1, atty = -1 }
                ).ToArray(),
                 new { atone = tone, atty = tty });
                //return Array.IndexOf(q__x.Select(x => x != null ? x.tone : -1).ToArray(), tone);
            }
            /// <summary>節奏(xx時間)總和</summary>
            public static double rhythm_Sum(q__x[] q__x) =>
                q__x.Select(x => x.rhythm).Sum();
            #region 未使用
            /// <summary>尋找音符代號相同的最後一個索引植</summary>
            /// <param name="tone">要尋找的音符代號</param>
            public static int find_tone_LastIndex(q__x[] q__x, int tone)
            {
                return Array.LastIndexOf(q__x.Select(x => x != null ? x.tone : -1).ToArray(), tone);
            }
            /// <summary>節奏(xx時間)總和</summary>
            /// <param name="EndIndex">結束索引值</param>
            public static double rhythm_Sum(q__x[] q__x, int EndIndex) =>
                q__x.Where((x, i) => i <= EndIndex).Select(x => x.rhythm).Sum();
            /// <summary>音符代號是否在範圍內</summary>
            /// <param name="tone">音符代號</param>
            public static bool in_tone_range(q__x[] q__x, int tone)
            {
                if (q__x.Length == 0) { return false; }
                int max = q__x.Select((x) => x.tone).Max();
                var min = q__x.Select((x) => x.tone).Where(x => x != -1).Min();
                if (min <= tone && tone <= max) { return true; }
                else { return false; }
            }
            #endregion
        }
        #region 標頭資料
        /// <summary>格式類型0~2</summary>
        int MIDIFormat;
        /// <summary>讀取音軌數量</summary>
        int Tracknum;
        /// <summary>時間類型0~1</summary>
        int Timetype;
        /// <summary>四分音符的tick數</summary>
        int Tick;
        /// <summary>每秒偵數</summary>
        int Frame;
        /// <summary>每偵的Tick數</summary>
        int FrameTick;
        #endregion
        #region 轉換資料
        /// <summary>讀取是否成功</summary>
        public bool readOK { get; private set; }
        /// <summary>歌曲速度</summary>
        public int BPM { get; private set; }
        public class midt
        {
            /// <summary>音調</summary>       
            public string a1="";
            /// <summary>音高</summary>
            public string a2="";
            /// <summary>將資料轉換後加入到陣列最後加入</summary>
            /// <param name="tone">音符代號</param>
            public void Endadd(int tone)
            {
                var a = tone != -1 ? toneName1[tone % 12].ToString() : "0";
                var b = tone != -1 ? toneName2[tone / 12 + 1].ToString() : "0";
                a1 += a;
                a2 += b;
            }
        }
        /// <summary>音符代號</summary>   
        public midt[][] note { get; private set; }
        /// <summary>節奏(BPM時間)</summary>
        public double[] BPMrhythm { get; private set; }
        /// <summary>節奏(微秒時間)</summary>
        public double[] Sec6rhythm { get; private set; }
        /// <summary>節奏(微秒時間)(結束時間總和)</summary>
        public double[] Sec6rhythmSUM { get; private set; }
        #endregion
        #region 暫時資料
        /// <summary>讀取進度位置</summary>
        int di;
        /// <summary>讀取區塊位置</summary>
        int tr;
        /// <summary>音軌區塊大小</summary>
        int tck;
        /// <summary>以經過的時間</summary>
        int rhythmnall;
        /// <summary>與上一個 Event 的相距時間長度</summary>
        int evetuime = 0;
        /// <summary>音軌類型</summary>
        int trecktype;
        #endregion
        #region read()資料
        /// <summary>歌曲中途變為的速度</summary>
        private BPMmx[] BPMmm;
        class BPMmx
        {
            /// <summary>BPM=60000000 / BPM16</summary>  
            public int BPM16;
            /// <summary>變更位置</summary> 
            public int BPMSc;
        }
        /// <summary>讀取音符資料，節奏(持序時間)，[音軌數量][同時彈奏音符個數][依照時間排列]</summary>
        q__x[][][] qx_x;
        /// <summary>音符未關閉資料，節奏(開使時間)</summary>
        q__x[] tempqx_x;
        #endregion
        #region 時間通一timeone()資料
        /// <summary>通一音符時間，[音軌數量][同時彈奏音符個數][依照時間排列]</summary>
        public int[][][] qx_x_timeone;
        /// <summary>通一音符時間，[音軌數量][同時彈奏音符個數][依照時間排列]</summary>
        public int[][][] qx_x_timeoneCOPY2;
        /// <summary>節奏(通一時間)</summary>
        double[] rhythm_timeone;
        /// <summary>通一音符當前資料，節奏(剩餘時間)</summary>
        q__x[][] tempqx_x__timeone;
        #endregion
    }
}
