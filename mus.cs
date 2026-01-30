using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midi轉換器Csh
{
    public partial class mus
    {
        public mus(byte[] data)
        {
            this.data = data;
            di = 0;
            BPM = 120;
            readOK = read();
            if (readOK) { readOK = timeone(); }
            if (readOK) { con(); }
        }
        /// <summary>讀取</summary>
        bool read()
        {
            #region Head Chunk
            if (!(Dasu(0, 4) == head) || !(data[7] == 0x06)) { return false; }
            MIDIFormat = data[9];
            Tracknum = (data[10] * (int)Math.Pow(16, 2 * 1)) + data[11];
            Timetype = data[12] >> 7;
            if (Timetype == 0) { Tick = (data[12] * (int)Math.Pow(16, 2 * 1)) + data[13]; }
            else
            {
                if (0xff + 1 - data[12] == 29) { Frame = 30; }
                else { Frame = 0xff - data[12]; }
                FrameTick = data[13];
            }
            qx_x = new q__x[Tracknum][][];
            BPMmm = new BPMmx[0];
            for (int i = 0; i < Tracknum; i++)
            {
                qx_x[i] = new q__x[0][];
            }
            #endregion
            di = 14;
            for (tr = 0; tr < Tracknum; tr++)
            {
                if (!(Dasu(di, 4) == track)) { return false; }
                di += 4;
                tck = data[di + 0] * (int)Math.Pow(16, 2 * 3) +
                      data[di + 1] * (int)Math.Pow(16, 2 * 2) +
                      data[di + 2] * (int)Math.Pow(16, 2 * 1) +
                      data[di + 3] * (int)Math.Pow(16, 2 * 0) +
                      di + 4;
                di += 4;
                rhythmnall = 0;
                Array.Resize(ref tempqx_x, 0);
                while (di < tck)
                {
                    int[] ti = new int[0];
                    while (data[di] >= 0x80)
                    {
                        Array.Resize(ref ti, ti.Length + 1);
                        ti[ti.Length - 1] = data[di] - 0x80;
                        ti = ti.Select(x => x * 0x80).ToArray();
                        di++;
                    }
                    evetuime = ti.Sum() + data[di];
                    rhythmnall += evetuime;
                    di++;
                    //TreckCheck();
                    try { TreckCheck(); }
                   catch { return false; }
                }
            }
            qx_x = qx_x.Where(x => x.Length > 0).ToArray();
            //
            qx_x = qx_x.Select(x => 
                                x.Where(y=>
                                        !y.All(z=>z.tone==-1))
            .ToArray()).ToArray();
            //
            Tracknum = qx_x.Length;
            return true;
        }
        bool qx_xallnull()
        {
            var a = qx_x.SelectMany(x => x).All(x => x.Length == 0);
            var b = tempqx_x__timeone.SelectMany(x => x).All(x => x == null);
            if (a && b) { return true; }
            else { return false; }
        }
        /// <summary>時間通一</summary>
        bool timeone()
        {
            qx_x_timeone = new int[qx_x.Length][][];
            rhythm_timeone = new double[0];
            tempqx_x__timeone = new q__x[qx_x.Length][];
            for (int i = 0; i < qx_x.Length; i++)
            {
                qx_x_timeone[i] = new int[qx_x[i].Length][];
                tempqx_x__timeone[i] = new q__x[qx_x[i].Length];
                for (int j = 0; j < qx_x[i].Length; j++)
                {
                    qx_x_timeone[i][j] = new int[0];
                    Array.Reverse(qx_x[i][j]);
                }
            }
            while (!qx_xallnull())
            {
                //放入暫存
                for (int i = 0; i < qx_x.Length; i++)
                {
                    for (int j = 0; j < qx_x[i].Length; j++)
                    {
                        if (qx_x[i][j].Length > 0)
                        {
                            if (tempqx_x__timeone[i][j] == null)
                            {
                                tempqx_x__timeone[i][j] = qx_x[i][j][qx_x[i][j].Length - 1];
                                Array.Resize(ref qx_x[i][j], qx_x[i][j].Length - 1);
                            }
                        }
                    }
                }
                double mintime;
                mintime = tempqx_x__timeone.
                        SelectMany(x => x).
                        Where(x => x != null).
                        Min(x => x.rhythm);
                for (int i = 0; i < qx_x_timeone.Length; i++)
                {
                    for (int j = 0; j < qx_x_timeone[i].Length; j++)
                    {
                        Array.Resize(ref qx_x_timeone[i][j], qx_x_timeone[i][j].Length + 1);
                        var a = tempqx_x__timeone[i][j] != null ? tempqx_x__timeone[i][j].tone : -1;
                        qx_x_timeone[i][j][qx_x_timeone[i][j].Length - 1] = a;
                    }
                }
                Array.Resize(ref rhythm_timeone, rhythm_timeone.Length + 1);
                rhythm_timeone[rhythm_timeone.Length - 1] = mintime;
                tempqx_x__timeone = tempqx_x__timeone.
                    Select(x => x.
                    Select(y => (y != null && y.rhythm - mintime > 0) ?
                    new q__x(y.tone, y.rhythm - mintime) : null
                    ).ToArray()).ToArray();
            }

            qx_x_timeoneCOPY2 = new int[qx_x_timeone.Length][][];
            for (int i = 0; i < qx_x_timeone.Length; i++)
            {
                qx_x_timeoneCOPY2[i] = new int[qx_x_timeone[i].Length][];
                for (int j = 0; j < qx_x_timeone[i].Length; j++)
                {
                    qx_x_timeoneCOPY2[i][j] = new int[qx_x_timeone[i][j].Length];
                    for (int k = 0; k < qx_x_timeone[i][j].Length; k++)
                    {
                        qx_x_timeoneCOPY2[i][j][k] = qx_x_timeone[i][j][k];
                    }
                }
            }         
            return true;
        }
        /// <summary>轉換</summary>
        void con() 
        {
            note = new midt[qx_x_timeone.Length][];
            BPMrhythm = new double[rhythm_timeone.Length];
            Sec6rhythm = new double[rhythm_timeone.Length];
            Sec6rhythmSUM = new double[rhythm_timeone.Length];
            for (int i = 0; i < qx_x_timeone.Length; i++) {
                note[i] = new midt[qx_x_timeone[i].Length];
                for (int j = 0; j < qx_x_timeone[i].Length; j++)
                {
                    note[i][j] = new midt();
                    for (int k = 0; k < qx_x_timeone[i][j].Length; k++)
                    {
                        note[i][j].Endadd(qx_x_timeone[i][j][k]);
                    }
                }
            }
            var bb = BPMmm.Select(x => x).ToArray();
            Array.Reverse(bb);
            for (int i = 0; i < rhythm_timeone.Length; i++)
            {
                if (Timetype == 0)
                {
                    var rsum= rhythm_timeone.Where((x,index)=>index<=i).Sum();
                    if (bb.Length>=2 && rsum > bb[bb.Length - 2].BPMSc)
                    {
                        Array.Resize(ref bb,bb.Length - 1);
                    }
                    var b16 = bb[bb.Length-1].BPM16;                 
                    Sec6rhythm[i] = rhythm_timeone[i] * b16 / Tick;
                    BPMrhythm[i] = rhythm_timeone[i] * b16 / Tick / BPMmm[0].BPM16;
                    Sec6rhythmSUM[i] = Sec6rhythm.Sum();
                }
            }   
               
        }
    }
}
