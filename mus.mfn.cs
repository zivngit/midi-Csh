using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midi轉換器Csh
{
    public partial class mus
    {
        /// <summary>擷取陣列</summary>
        /// <param name="a">起始位置</param>
        /// <param name="b">長度</param>
        string Dasu(int a, int b) =>
            new string(data.Where((x, i) =>
            a <= i &&
            i < a + b).
            Select(x => (char)x).ToArray());
        #region midi事件
        /// <summary>讀取資料型別</summary>
        /// <param name="tr">音軌區塊編號</param>
        void TreckCheck()
        {
            if (data[di] >= 0x80)
            {
                trecktype = data[di];
                di++;
            }
            if (0x80 <= trecktype && trecktype <= 0x8f)
            {
                int tty = trecktype - 0x80;

                int mm = data[di];
                di++;
                int mt = data[di];
                di++;
                type80(mm,mt,tty);
            }
            else if (0x90 <= trecktype && trecktype <= 0x9f)
            {
                int tty = trecktype - 0x90;

                int mm = data[di];
                di++;
                int mt = data[di];
                di++;
                type90(mm, mt,tty);
            }
            else if (0xA0 <= trecktype && trecktype <= 0xAf) { di += 2; }
            else if (0xB0 <= trecktype && trecktype <= 0xBf) { di += 2; }
            else if (0xC0 <= trecktype && trecktype <= 0xCf) { di++; }
            else if (0xD0 <= trecktype && trecktype <= 0xDf) { di++; }
            else if (0xE0 <= trecktype && trecktype <= 0xEf) { di += 2; }
            else if (trecktype == 0xff) { typeFF(); }
        }

        /// <summary>Mata事件</summary>
        private void typeFF()
        {
            if (data[di] == 0x51)
            {
                di += 2;
                int BPM16 =
                data[di + 0] * (int)Math.Pow(16, 2 * 2) +
                data[di + 1] * (int)Math.Pow(16, 2 * 1) +
                data[di + 2] * (int)Math.Pow(16, 2 * 0);
                if (BPMmm.Length==0) {BPM = 60000000 / BPM16;}
                Array.Resize(ref BPMmm, BPMmm.Length + 1);
                BPMmm[BPMmm.Length - 1] = new BPMmx();
                BPMmm[BPMmm.Length - 1].BPM16 = BPM16;
                BPMmm[BPMmm.Length - 1].BPMSc = rhythmnall;
                di += 3;
            }
            else
            {
                di++;
                di += data[di] + 1;
            }
        }

        /// <summary>音符開</summary>
        /// <param name="mm">音符代號</param>
        /// <param name="mt">音符開始時間</param>
        /// <param name="tty">音軌0x80~0x8f,0x90~0x9f,0~f</param>
        private void type90(int mm, int mt,int tty)
        {
            if (mt > 0)
            {
                int i;
                for (i = 0; i < tempqx_x.Length; i++)
                {
                    if (tempqx_x[i] == null)
                    {
                        break;
                    }
                }
                if (i >= tempqx_x.Length)
                {
                    Array.Resize(ref tempqx_x, tempqx_x.Length + 1);
                    tempqx_x[tempqx_x.Length - 1] = new q__x();
                    Array.Resize(ref qx_x[tr], qx_x[tr].Length + 1);
                    qx_x[tr][qx_x[tr].Length - 1] = new q__x[0];
                }
                tempqx_x[i]= new q__x(mm,rhythmnall,tty);
            }
            else { type80(mm,mt,tty); }
        }

        /// <summary>音符關</summary>
        /// <param name="mm">音符代號</param>
        /// <param name="mt">音符開始時間(未使用)</param>
        /// <param name="tty">音軌0x80~0x8f,0x90~0x9f,0~f</param>
        private void type80(int mm, int mt, int tty)
        {
            try
            {
                int tone_Index = q__x.find_tone_Index(tempqx_x, mm, tty);
                double sttime = tempqx_x[tone_Index].rhythm;
                tempqx_x[tone_Index] = null;
                //將資料放入q__x的索引值
                int qxindex;
                var sumlower = qx_x[tr].
                    Select((x, i) => new { Value = x, Index = i }).
                    Where(x => q__x.rhythm_Sum(x.Value) <= sttime).
                    Select(x => new
                    {
                        Value = x.Value,
                        Index = x.Index,
                        rhythm_Sum = q__x.rhythm_Sum(x.Value)
                    });
                var sumlower_max = sumlower.
                    Where(x => x.rhythm_Sum ==
                    sumlower.Max(y => y.rhythm_Sum)).
                    Select(x => x.Index);
                #region 未使用
                //var in_tone = sumlower.
                //    Where(x => q__x.in_tone_range(x.Value, mm)).
                //    Select(x => new
                //    {
                //        Value = x.Value,
                //        Index = x.Index,
                //        rhythm_Sum = q__x.rhythm_Sum(x.Value)
                //    }).ToArray();
                //var in_tone_max = in_tone.
                //    Where(x => x.rhythm_Sum ==
                //    in_tone.Max(y => y.rhythm_Sum)).
                //    Select(x => x.Index);

                //var end_tone_time = in_tone.
                //    Select(x => new
                //    {
                //        Value = x.Value,
                //        Index = x.Index,
                //        EndIndex = q__x.find_tone_LastIndex(x.Value, mm)
                //    }).
                //    Where(x => x.EndIndex != -1).
                //    Select(x => new
                //    {
                //        Value = x.Value,
                //        Index = x.Index,
                //        rhythm_Sum = q__x.rhythm_Sum(x.Value, x.EndIndex)
                //    });
                //var end_tone_time_max = end_tone_time.
                //    Where(x => x.rhythm_Sum ==
                //    end_tone_time.Max(y => y.rhythm_Sum)).
                //    Select(x => x.Index);

                //if (in_tone_max.Count() > 0) { qxindex = in_tone_max.ToArray()[0]; }
                //if (end_tone_time_max.Count() > 0) { qxindex = end_tone_time_max.ToArray()[0]; }
                //qxindex = tone_Index;
                #endregion
                qxindex = sumlower_max.ToArray()[0];
                if (q__x.rhythm_Sum(qx_x[tr][qxindex]) < sttime)
                {
                    double r0 = sttime - q__x.rhythm_Sum(qx_x[tr][qxindex]);
                    q__x.Endadd(ref qx_x[tr][qxindex], -1, r0);
                }
                double r = rhythmnall - sttime;
                q__x.Endadd(ref qx_x[tr][qxindex], mm, r);
            }
            catch{}         
        }
        #endregion
    }
}
