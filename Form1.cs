using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midi轉換器Csh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 畫圖工具
        SolidBrush brush;
        Graphics g;
        #endregion
        #region 顯示的物件
        /// <summary>畫布[音軌數量][同時彈奏音符個數][X分鐘]</summary>
        Bitmap[][][] bmp;
        /// <summary>展示框[音軌數量][同時彈奏音符個數][0時間軸,1最低音,2最高音,3時間長度.4使用率]</summary>
        Label[][][] limg;
        ComboBox[] coBo = { };
        mus m;
        #endregion
        #region 音符對照表
        int[] col = new int[] {
            0xFFDEDE,0xFFB5B5,0xFFF3DE,0xFFE5B5,0xFFFFDE,0xDEFFDE,0xB5FFB5,0xDEFFFF,0xB5FFFF,0xD6D6FF,0xADADFF,0xF1DEFF,
            0xFFD4D4,0xFFABAB,0xFFF0D4,0xFFE1AB,0xFFFFD4,0xD4FFD4,0xABFFAB,0xD4FFFF,0xABFFFF,0xCCCCFF,0xA3A3FF,0xEDD4FF,
            0xFF8C8C,0xFF6363,0xFFD78C,0xFFC863,0xFFFF8C,0x8CFF8C,0x63FF63,0x8CFFFF,0x63FFFF,0x8282FF,0x5959FF,0xCE8CFF,
            0xFF8282,0xFF5959,0xFFD382,0xFFC559,0xFFFF82,0x82FF82,0x59FF59,0x82FFFF,0x59FFFF,0x7878FF,0x4F4FFF,0xCA82FF,
            0xFF3B3B,0xFF1212,0xFFBA3B,0xFFAC12,0xFFFF3B,0x3BFF3B,0x0DFF0D,0x3DFFFF,0x12FFFF,0x3030FF,0x0808FF,0xAC3BFF,
            0xFF3030,0xFF0000,0xFFB630,0xFFA600,0xFFFF30,0x30FF30,0x00FF00,0x30FFFF,0x00FFFF,0x2626FF,0x0000FF,0xA830FF,
            0xEB0000,0xD60000,0xEB9900,0xD68B00,0xEBEB00,0x00EB00,0x00D600,0x00EBEB,0x00D6D6,0x0000EB,0x0000D6,0x8700EB,
            0xE60000,0xD10000,0xE69500,0xD18800,0xE6E600,0x00E600,0x00D100,0x00E6E6,0x00D1D1,0x0000E6,0x0000D1,0x8400E6,
            0xC20000,0xAD0000,0xC27E00,0xAD7100,0xC2C200,0x00C200,0x00AD00,0x00C2C2,0x00ADAD,0x0000C2,0x0000AD,0x7000C2,
            0xBD0000,0xA80000,0xBD7B00,0xA86E00,0xBDBD00,0x00BD00,0x00A800,0x00BDBD,0x00A8A8,0x0000BD,0x0000A8,0x6D00BD,
            0x990000,0x850000,0x996400,0x855600,0x999900,0x009900,0x008500,0x009999,0x008585,0x000099,0x000085,0x580099
        };
        string[] mukk = new string[]
        {
            "C-1",  "C#-1/Db-1", "D-1",  "D#-1/Eb-1", "E-1",  "F-1",  "F#-1/Gb-1", "G-1",  "G-#1/Ab-1", "A-1",  "A#-1/Bb-1", "B-1",
            "C0",   "C#0/Db0",  "D0",   "D#0/Eb0",  "E0",   "F0",   "F#0/Gb0",  "G0",   "G#0/Ab0",  "A0",   "A#0/Bb0",  "B0",
            "C1",   "C#1/Db1",  "D1",   "D#1/Eb1",  "E1",   "F1",   "F#1/Gb1",  "G1",   "G#1/Ab1",  "A1",   "A#1/Bb1",  "B1",
            "C2",   "C#2/Db2",  "D2",   "D#2/Eb2",  "E2",   "F2",   "F#2/Gb2",  "G2",   "G#2/Ab2",  "A2",   "A#2/Bb2",  "B2",
            "C3",   "C#3/Db3",  "D3",   "D#3/Eb3",  "E3",   "F3",   "F#3/Gb3",  "G3",   "G#3/Ab3",  "A3",   "A#3/Bb3",  "B3",
            "C4",   "C#4/Db4",  "D4",   "D#4/Eb4",  "E4",   "F4",   "F#4/Gb4",  "G4",   "G#4/Ab4",  "A4",   "A#4/Bb4",  "B4",
            "C5",   "C#5/Db5",  "D5",   "D#5/Eb5",  "E5",   "F5",   "F#5/Gb5",  "G5",   "G#5/Ab5",  "A5",   "A#5/Bb5",  "B5",
            "C6",   "C#6/Db6",  "D6",   "D#6/Eb6",  "E6",   "F6",   "F#6/Gb6",  "G6",   "G#6/Ab6",  "A6",   "A#6/Bb6",  "B6",
            "C7",   "C#7/Db7",  "D7",   "D#7/Eb7",  "E7",   "F7",   "F#7/Gb7",  "G7",   "G#7/Ab7",  "A7",   "A#7/Bb7",  "B7",
            "C8",   "C#8/Db8",  "D8",   "D#8/Eb8",  "E8",   "F8",   "F#8/Gb8",  "G8",   "G#8/Ab8",  "A8",   "A#8/Bb8",  "B8",
            "C9",   "C#9/Db9",  "D9",   "D#9/Eb9",  "E9",   "F9",   "F#9/Gb9",  "G9",   "G#9/Ab9",  "A9",   "A#9/Bb9",  "B9",
        };
        #endregion
        #region 載入
        private void onmidi_Click(object sender, EventArgs e)
        {
            oF1.InitialDirectory = Application.StartupPath;
            if (oF1.ShowDialog() == DialogResult.OK)
            {
                using (BinaryReader read = new BinaryReader(File.Open(oF1.FileName, FileMode.Open), Encoding.UTF8))
                {
                    FileInfo info1 = new FileInfo(oF1.FileName);
                    byte[] data = read.ReadBytes((int)info1.Length);
                    m = new mus(data);
                    if (m.readOK)
                    {
                        CoBox1.Text = oF1.FileName;
                        panel2.Enabled = true;
                        panel3.Enabled = true;
                        panel4.Enabled = true;
                        panel5.Enabled = true;
                        clp();
                        dat(m);
                        penPanel(m);
                        daMm(m, limg);
                        penBP(m, limg);
                    }
                }
            }
        }
        #region 繪製
        void clp()
        {
            Panel1.RowCount = 1;
            if (limg != null)
            {
                foreach (var it1 in limg)
                {
                    foreach (var it2 in it1)
                    {
                        foreach (var item in it2)
                        {
                            item.Dispose();
                        }
                    }
                }
            }
            if (bmp != null)
            {
                foreach (var i3 in bmp)
                {
                    foreach (var i2 in i3)
                    {
                        foreach (var item in i2)
                        {
                            item.Dispose();
                        }
                    }
                }
            }
            int ot = 6;
            while (Panel1.Controls.Count > ot)
            { Panel1.Controls[ot].Dispose(); }
            comboBox1.Items.Clear();
        }
        void dat(mus m)
        {

            var ti = m.Sec6rhythmSUM[m.Sec6rhythmSUM.Length - 1];
            ti = ti / 1000000;
            var tim = (int)(ti / 60);
            var tis = (int)(ti % 60);
            var mmus = m.qx_x_timeoneCOPY2.SelectMany(x => x).SelectMany(x => x).Where(x => x != -1).Min();
            var Mmus = m.qx_x_timeoneCOPY2.SelectMany(x => x).SelectMany(x => x).Max();
            much.Text =
                $"BPM：{m.BPM}\r\n" +
                $"時間：{tim}：{tis:0}\r\n" +
                $"最低音：({mmus}){mukk[mmus]}\r\n" +
                $"最高音：({Mmus}){mukk[Mmus]}\r\n";
            for (int i = 0; i < m.qx_x_timeoneCOPY2.Length; i++)
            {
                for (int j = 0; j < m.qx_x_timeoneCOPY2[i].Length; j++)
                {
                    comboBox1.Items.Add($"{i + 1}_{j + 1}");
                }
            }
            coup();
        }
        void coadd(ref System.Windows.Forms.ComboBox box)
        {
            Array.Resize(ref coBo, coBo.Length + 1);
            coBo[coBo.Length - 1] = box;
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                box.Items.Add(comboBox1.Items[i]);
            }
            box.Text = box.Items[0].ToString();
        }
        void coup()
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                comboBox2.Items.Add(comboBox1.Items[i]);
                comboBox3.Items.Add(comboBox1.Items[i]);
            }
            comboBox1.Text = comboBox1.Items[0].ToString();
            comboBox2.Text = comboBox2.Items[0].ToString();
            comboBox3.Text = comboBox3.Items[0].ToString();
            foreach (var item in coBo)
            {
                item.Items.Clear();
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    item.Items.Add(comboBox1.Items[i]);
                }
                item.Text = item.Items[0].ToString();
            }
        }

        void penPanel(mus m)
        {

            limg = new Label[m.qx_x_timeoneCOPY2.Length][][];
            int con = 1;
            for (int i = 0; i < m.qx_x_timeoneCOPY2.Length; i++)
            {
                var lab = new Label
                {
                    AutoSize = true,
                    Dock = DockStyle.Fill,
                    Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Margin = new Padding(0),
                    BackColor = Color.FromArgb(240, 183, 113),
                    Text = $"音軌{i + 1}"
                };
                Panel1.Controls.Add(lab, 0, con);
                con++;
                limg[i] = new Label[m.qx_x_timeoneCOPY2[i].Length][];
                for (int j = 0; j < m.qx_x_timeoneCOPY2[i].Length; j++)
                {
                    limg[i][j] = new Label[5];
                    var lt = new Label
                    {
                        AutoSize = true,
                        Dock = DockStyle.Fill,
                        Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        Margin = new Padding(0),
                        BackColor = Color.White,
                        Text = $"{i + 1}_{j + 1}"
                    };
                    Panel1.Controls.Add(lt, 0, con);
                    var lj0 = new Label
                    {
                        AutoSize = true,
                        Dock = DockStyle.Fill,
                        Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        Margin = new Padding(0),
                        BackColor = Color.White,
                        Tag = $"{i},{j}"
                    };
                    lj0.MouseMove += new MouseEventHandler(getttt);
                    lj0.MouseLeave += new EventHandler(lttt);
                    Panel1.Controls.Add(lj0, 1, con);
                    limg[i][j][0] = lj0;
                    for (int jii = 0; jii < 4; jii++)
                    {
                        var lj1 = new Label
                        {
                            AutoSize = true,
                            Dock = DockStyle.Fill,
                            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                            Margin = new Padding(0),
                            TextAlign = ContentAlignment.MiddleCenter,
                            BackColor = Color.White,
                        };
                        Panel1.Controls.Add(lj1, 2 + jii, con);
                        limg[i][j][jii + 1] = lj1;
                    }
                    con++;
                }
            }
        }
        void daMm(mus m, Label[][][] lab)
        {
            for (int i = 0; i < m.qx_x_timeoneCOPY2.Length; i++)
            {
                for (int j = 0; j < m.qx_x_timeoneCOPY2[i].Length; j++)
                {
                    var mmus = m.qx_x_timeoneCOPY2[i][j].Where(x => x != -1).Min();
                    var Mmus = m.qx_x_timeoneCOPY2[i][j].Max();
                    lab[i][j][1].Text = $"({mmus}){mukk[mmus]}";
                    lab[i][j][2].Text = $"({Mmus}){mukk[Mmus]}";

                    double ti = 0;
                    for (int k = 0; k < m.qx_x_timeoneCOPY2[i][j].Length; k++)
                    {
                        if (m.qx_x_timeoneCOPY2[i][j][k] != -1)
                        {
                            ti += m.Sec6rhythm[k];
                        }
                    }
                    var tmmm = ti / m.Sec6rhythmSUM[m.Sec6rhythmSUM.Length - 1] * 100;
                    lab[i][j][4].Text = $"{tmmm:0.00}";

                    ti = ti / 1000000;
                    var tim = (int)ti / 60;
                    var tis = (int)ti % 60;
                    lab[i][j][3].Text = $"{tim}：{tis}";
                }
            }

        }
        void penBP(mus m, Label[][][] lab)
        {

            bmp = new Bitmap[m.qx_x_timeoneCOPY2.Length][][];
            for (int i = 0; i < m.qx_x_timeoneCOPY2.Length; i++)
            {
                bmp[i] = new Bitmap[m.qx_x_timeoneCOPY2[i].Length][];
                for (int j = 0; j < m.qx_x_timeoneCOPY2[i].Length; j++)
                {
                    bmp[i][j] = new Bitmap[1];
                    bmp[i][j][0] = new Bitmap(lab[i][j][0].Width, lab[i][j][0].Height);
                    double timest = 0;
                    double timeend = 0;
                    for (int k = 0, k2 = 0; k < m.qx_x_timeoneCOPY2[i][j].Length; k++)
                    {
                        if (m.qx_x_timeoneCOPY2[i][j][k] != -1)
                        {
                            brush = new SolidBrush(Color.FromArgb(255, Color.FromArgb(col[m.qx_x_timeoneCOPY2[i][j][k]])));
                        }
                        else
                        {
                            brush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
                        }
                        timeend = m.Sec6rhythmSUM[k];
                        timeend = timeend - (60000000 * k2);
                        timeend = timeend / 1000000;
                        timeend = timeend * (lab[i][j][0].Width / 60);
                        g = Graphics.FromImage(bmp[i][j][k2]);
                        g.FillRectangle(brush, (float)timest, 0, (float)timeend, lab[i][j][0].Height);
                        timest = timeend;
                        if (timeend > lab[i][j][0].Width)
                        {
                            Array.Resize(ref bmp[i][j], bmp[i][j].Length + 1);
                            bmp[i][j][bmp[i][j].Length - 1] = new Bitmap(lab[i][j][0].Width, lab[i][j][0].Height);
                            k2++;
                            timest = 0;
                            timeend = timeend - lab[i][j][0].Width;
                            g = Graphics.FromImage(bmp[i][j][k2]);
                            g.FillRectangle(brush, (float)timest, 0, (float)timeend, lab[i][j][0].Height);
                            timest = timeend;
                        }
                    }
                    brush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
                    g.FillRectangle(brush, (float)timest, 0, lab[i][j][0].Width, lab[i][j][0].Height);
                }
            }
            GC.Collect();
            num1.Value = 0;
            num1.Maximum = bmp[0][0].Length - 1;
            for (int i = 0; i < limg.Length; i++)
            {
                for (int j = 0; j < limg[i].Length; j++)
                {
                    limg[i][j][0].Image = bmp[i][j][0];
                }
            }
        }

        #endregion
        #endregion
        #region 
        private void button1_Click(object sender, EventArgs e)
        {
            if (num1.Minimum < num1.Value) { num1.Value -= 1; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (num1.Value < num1.Maximum) { num1.Value += 1; }
        }
        private void num1_ValueChanged(object sender, EventArgs e)
        {
            tla3.Text = $"時間軸：{num1.Value}分鐘~{num1.Value + 1}分鐘";
            for (int i = 0; i < limg.Length; i++)
            {
                for (int j = 0; j < limg[i].Length; j++)
                {
                    limg[i][j][0].Image = bmp[i][j][(int)num1.Value];
                }
            }
        }
        #endregion
        #region 
        private void getttt(object sender, MouseEventArgs e)
        {
            var ts = ((Label)sender).Tag.ToString().Split(',');
            var ti = Convert.ToInt32(ts[0]);
            var tj = Convert.ToInt32(ts[1]);
            var tt = 60 * e.X / ((Label)sender).Width;


            if (0 <= e.X && e.X < ((Label)sender).Width &&
                0 <= e.Y && e.Y < ((Label)sender).Height)
            {
                var to = new Bitmap(((Label)sender).Image);
                var to0 = to.GetPixel(e.X, e.Y).ToArgb() - 0xff000000;
                to.Dispose();
                var to1 = Array.IndexOf(col, (int)to0);
                string to2 = "";
                if (to1 != -1) { to2 = mukk[to1]; }
                sem2.Text =
                    $"滑鼠所在位置\r\n" +
                    $"音軌：{ti + 1}_{tj + 1}\r\n" +
                    $"時間：{num1.Value}：{tt}\r\n" +
                    $"音符：({to1}){to2}\r\n";
            }
            else
            {
                sem2.Text = "滑鼠所在位置\r\n音軌：\r\n時間：\r\n音符：\r\n";
            }
        }
        private void lttt(object sender, EventArgs e)
        {
            sem2.Text = "滑鼠所在位置\r\n音軌：\r\n時間：\r\n音符：\r\n";
        }
        #endregion
        #region 
        private void button3_Click(object sender, EventArgs e)
        {
            int ini = Convert.ToInt32(comboBox1.Text.Split('_')[0]) - 1;
            int inj = Convert.ToInt32(comboBox1.Text.Split('_')[1]) - 1;
            int oui = Convert.ToInt32(comboBox2.Text.Split('_')[0]) - 1;
            int ouj = Convert.ToInt32(comboBox2.Text.Split('_')[1]) - 1;
            for (int i = 0; i < m.Sec6rhythm.Length; i++)
            {
                var a = m.qx_x_timeoneCOPY2[ini][inj][i];
                var b = m.qx_x_timeoneCOPY2[oui][ouj][i];
                if (a != -1 &&
                    b == -1)
                {
                    var z = m.qx_x_timeoneCOPY2[ini][inj][i];
                    m.qx_x_timeoneCOPY2[oui][ouj][i] = z;
                    m.qx_x_timeoneCOPY2[ini][inj][i] = -1;
                }
            }
            pcc(m, limg, ini, inj);
            pcc(m, limg, oui, ouj);
            num1.Value = 0;
            num1.Maximum = bmp[0][0].Length - 1;
            for (int i = 0; i < limg.Length; i++)
            {
                for (int j = 0; j < limg[i].Length; j++)
                {
                    limg[i][j][0].Image = bmp[i][j][0];
                }
            }
        }
        void pcc(mus m, Label[][][] lab, int i, int j)
        {
            var mm = m.qx_x_timeoneCOPY2[i][j].Where(x => x != -1).ToArray();
            int mmus = mm.Length != 0 ? mm.Min() : -1;
            var Mmus = mm.Length != 0 ? mm.Max() : -1;
            lab[i][j][1].Text = mmus != -1 ? $"({mmus}){mukk[mmus]}" : $"({mmus})";
            lab[i][j][2].Text = Mmus != -1 ? $"({Mmus}){mukk[Mmus]}" : $"({Mmus})";
            double ti = 0;
            for (int k = 0; k < m.qx_x_timeoneCOPY2[i][j].Length; k++)
            {
                if (m.qx_x_timeoneCOPY2[i][j][k] != -1)
                {
                    ti += m.Sec6rhythm[k];
                }
            }
            var tmmm = ti / m.Sec6rhythmSUM[m.Sec6rhythmSUM.Length - 1] * 100;
            lab[i][j][4].Text = $"{tmmm:0.00}";

            ti = ti / 1000000;
            var tim = (int)ti / 60;
            var tis = (int)ti % 60;
            lab[i][j][3].Text = $"{tim}：{tis}";

            foreach (var item in bmp[i][j]) { item.Dispose(); }
            bmp[i][j] = new Bitmap[1];
            bmp[i][j][0] = new Bitmap(lab[i][j][0].Width, lab[i][j][0].Height);
            double timest = 0;
            double timeend = 0;
            for (int k = 0, k2 = 0; k < m.qx_x_timeoneCOPY2[i][j].Length; k++)
            {
                if (m.qx_x_timeoneCOPY2[i][j][k] != -1)
                {
                    brush = new SolidBrush(Color.FromArgb(255, Color.FromArgb(col[m.qx_x_timeoneCOPY2[i][j][k]])));
                }
                else
                {
                    brush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
                }
                timeend = m.Sec6rhythmSUM[k];
                timeend = timeend - (60000000 * k2);
                timeend = timeend / 1000000;
                timeend = timeend * (lab[i][j][0].Width / 60);
                g = Graphics.FromImage(bmp[i][j][k2]);
                g.FillRectangle(brush, (float)timest, 0, (float)timeend, lab[i][j][0].Height);
                timest = timeend;
                if (timeend > lab[i][j][0].Width)
                {
                    Array.Resize(ref bmp[i][j], bmp[i][j].Length + 1);
                    bmp[i][j][bmp[i][j].Length - 1] = new Bitmap(lab[i][j][0].Width, lab[i][j][0].Height);
                    k2++;
                    timest = 0;
                    timeend = timeend - lab[i][j][0].Width;
                    g = Graphics.FromImage(bmp[i][j][k2]);
                    g.FillRectangle(brush, (float)timest, 0, (float)timeend, lab[i][j][0].Height);
                    timest = timeend;
                }
            }
            brush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
            g.FillRectangle(brush, (float)timest, 0, lab[i][j][0].Width, lab[i][j][0].Height);
            GC.Collect();
        }
        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            m.qx_x_timeoneCOPY2 = new int[m.qx_x_timeone.Length][][];
            for (int i = 0; i < m.qx_x_timeone.Length; i++)
            {
                m.qx_x_timeoneCOPY2[i] = new int[m.qx_x_timeone[i].Length][];
                for (int j = 0; j < m.qx_x_timeone[i].Length; j++)
                {
                    m.qx_x_timeoneCOPY2[i][j] = new int[m.qx_x_timeone[i][j].Length];
                    for (int k = 0; k < m.qx_x_timeone[i][j].Length; k++)
                    {
                        m.qx_x_timeoneCOPY2[i][j][k] = m.qx_x_timeone[i][j][k];
                    }
                }
            }
            daMm(m, limg);
            penBP(m, limg);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            var lab = new Label
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                Font = new Font("Microsoft JhengHei UI", 12F),
                Margin = new Padding(0),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = $"喇叭{spkm.RowCount + 1}"
            };
            var boxx = new System.Windows.Forms.ComboBox();
            boxx.Dock = DockStyle.Fill;
            boxx.DropDownStyle = ComboBoxStyle.DropDownList;
            boxx.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);

            coadd(ref boxx);
            spkm.RowCount += 1;
            spkm.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            spkm.Controls.Add(lab, 0, spkm.RowCount - 1);
            spkm.Controls.Add(boxx, 1, spkm.RowCount - 1);



        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (spkm.RowCount > 1)
            {
                Array.Resize(ref coBo, coBo.Length - 1);
                for (int i = 0; i < spkm.ColumnCount; i++)
                {
                    spkm.GetControlFromPosition(i, spkm.RowCount - 1).Dispose();
                }
                spkm.RowStyles.RemoveAt(spkm.ColumnCount - 1);
                spkm.RowCount -= 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            save2.InitialDirectory = Application.StartupPath;
            if (save2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter stram = new StreamWriter(save2.FileName))
                    {
                        string outstr = "";
                        outstr += "BPM = " + m.BPM + ".0\r\n\r\n";

                        var ii3 = Convert.ToInt32(comboBox3.Text.Split('_')[0]) - 1;
                        var jj3 = Convert.ToInt32(comboBox3.Text.Split('_')[1]) - 1;
                        outstr += $"spk1=[";
                        for (int j = 0; j < m.qx_x_timeoneCOPY2[ii3][jj3].Length; j++)
                        {
                            outstr += $"{m.qx_x_timeoneCOPY2[ii3][jj3][j]}";
                            if (j < m.qx_x_timeoneCOPY2[ii3][jj3].Length - 1)
                            {
                                outstr += ",";
                            }
                        }
                        outstr += "]\r\n";
                        for (int i = 0; i < coBo.Length; i++)
                        {
                            var ii = Convert.ToInt32(coBo[i].Text.Split('_')[0]) - 1;
                            var jj = Convert.ToInt32(coBo[i].Text.Split('_')[1]) - 1;
                            outstr += $"spk{i + 2}=[";
                            for (int j = 0; j < m.qx_x_timeoneCOPY2[ii][jj].Length; j++)
                            {
                                outstr += $"{m.qx_x_timeoneCOPY2[ii][jj][j]}";
                                if (j < m.qx_x_timeoneCOPY2[ii][jj].Length - 1)
                                {
                                    outstr += ",";
                                }
                            }
                            outstr += "]\r\n";
                        }
                        outstr += "\r\nrhythm=[";
                        for (int j = 0; j < m.BPMrhythm.Length; j++)
                        {
                            outstr += $"{m.BPMrhythm[j]:0.0000}";
                            if (j < m.BPMrhythm.Length - 1)
                            {
                                outstr += ",";
                            }
                        }
                        outstr += "]\r\n";
                        outstr += "spk = [spk1";
                        for (int i = 0; i < coBo.Length; i++)
                        {
                            outstr += $",spk{i + 2}";
                        }
                        outstr += "]\r\n";
                        stram.Write(outstr);
                        stram.Flush();
                        stram.Close();
                        MessageBox.Show("成功");
                    }
                }
                catch { }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            save.InitialDirectory = Application.StartupPath;
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter stram = new StreamWriter(save.FileName))
                    {
                        string outstr = "";
                        outstr += "double BPM = " + m.BPM + ".0;\r\n\r\n";

                        var ii3 = Convert.ToInt32(comboBox3.Text.Split('_')[0]) - 1;
                        var jj3 = Convert.ToInt32(comboBox3.Text.Split('_')[1]) - 1;
                        outstr += $"const static PROGMEM int spk1[]= {{";
                        for (int j = 0; j < m.qx_x_timeoneCOPY2[ii3][jj3].Length; j++)
                        {
                            outstr += $"{m.qx_x_timeoneCOPY2[ii3][jj3][j]}";
                            if (j < m.qx_x_timeoneCOPY2[ii3][jj3].Length - 1)
                            {
                                outstr += ",";
                            }
                        }
                        outstr += "};\r\n";
                        for (int i = 0; i < coBo.Length; i++)
                        {
                            var ii = Convert.ToInt32(coBo[i].Text.Split('_')[0]) - 1;
                            var jj = Convert.ToInt32(coBo[i].Text.Split('_')[1]) - 1;
                            outstr += $"const static PROGMEM int spk{i + 2}[]= {{";
                            for (int j = 0; j < m.qx_x_timeoneCOPY2[ii][jj].Length; j++)
                            {
                                outstr += $"{m.qx_x_timeoneCOPY2[ii][jj][j]}";
                                if (j < m.qx_x_timeoneCOPY2[ii][jj].Length - 1)
                                {
                                    outstr += ",";
                                }
                            }
                            outstr += "};\r\n";
                        }
                        outstr += "\r\nconst static PROGMEM double rhythm[] = {";
                        for (int j = 0; j < m.BPMrhythm.Length; j++)
                        {
                            outstr += $"{m.BPMrhythm[j]:0.0000}";
                            if (j < m.BPMrhythm.Length - 1)
                            {
                                outstr += ",";
                            }
                        }
                        outstr += "};\r\n";
                        outstr += "const static int* const PROGMEM spk[] = { spk1";
                        for (int i = 0; i < coBo.Length; i++)
                        {
                            outstr += $",spk{i + 2}";
                        }
                        outstr += "};\r\n";
                        stram.Write(outstr);
                        stram.Flush();
                        stram.Close();
                        MessageBox.Show("成功");
                    }
                }
                catch { }
            }
        }
    }
}
