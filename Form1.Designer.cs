namespace midi轉換器Csh
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.onmidi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CoBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.oF1 = new System.Windows.Forms.OpenFileDialog();
            this.Panel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tr3 = new System.Windows.Forms.Label();
            this.tr2 = new System.Windows.Forms.Label();
            this.tr1 = new System.Windows.Forms.Label();
            this.tr0 = new System.Windows.Forms.Label();
            this.tr5 = new System.Windows.Forms.Label();
            this.tr4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.much = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tla3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sem2 = new System.Windows.Forms.Label();
            this.spkm = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.save2 = new System.Windows.Forms.SaveFileDialog();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.spkm.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onmidi,
            this.toolStripSeparator1,
            this.CoBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1551, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // onmidi
            // 
            this.onmidi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.onmidi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.onmidi.Name = "onmidi";
            this.onmidi.Size = new System.Drawing.Size(60, 22);
            this.onmidi.Text = "載入midi";
            this.onmidi.Click += new System.EventHandler(this.onmidi_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // CoBox1
            // 
            this.CoBox1.BackColor = System.Drawing.Color.White;
            this.CoBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.CoBox1.Name = "CoBox1";
            this.CoBox1.ReadOnly = true;
            this.CoBox1.Size = new System.Drawing.Size(500, 25);
            // 
            // oF1
            // 
            this.oF1.DefaultExt = "mid";
            this.oF1.Filter = "所有檔案 (*.*)|*.*|MIDI檔案|*.mid;*midi;*kar";
            this.oF1.InitialDirectory = "/";
            this.oF1.Title = "開啟midi檔";
            // 
            // Panel1
            // 
            this.Panel1.AutoSize = true;
            this.Panel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.Panel1.ColumnCount = 6;
            this.Panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.Panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.Panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.Panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.Panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.Panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.Panel1.Controls.Add(this.tr3, 3, 0);
            this.Panel1.Controls.Add(this.tr2, 2, 0);
            this.Panel1.Controls.Add(this.tr1, 1, 0);
            this.Panel1.Controls.Add(this.tr0, 0, 0);
            this.Panel1.Controls.Add(this.tr5, 5, 0);
            this.Panel1.Controls.Add(this.tr4, 4, 0);
            this.Panel1.Location = new System.Drawing.Point(0, 25);
            this.Panel1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.RowCount = 1;
            this.Panel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Panel1.Size = new System.Drawing.Size(1090, 26);
            this.Panel1.TabIndex = 4;
            // 
            // tr3
            // 
            this.tr3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tr3.AutoSize = true;
            this.tr3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.tr3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tr3.Location = new System.Drawing.Point(797, 3);
            this.tr3.Margin = new System.Windows.Forms.Padding(0);
            this.tr3.Name = "tr3";
            this.tr3.Size = new System.Drawing.Size(110, 20);
            this.tr3.TabIndex = 12;
            this.tr3.Text = "最高音";
            this.tr3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tr2
            // 
            this.tr2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tr2.AutoSize = true;
            this.tr2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.tr2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tr2.Location = new System.Drawing.Point(684, 3);
            this.tr2.Margin = new System.Windows.Forms.Padding(0);
            this.tr2.Name = "tr2";
            this.tr2.Size = new System.Drawing.Size(110, 20);
            this.tr2.TabIndex = 11;
            this.tr2.Text = "最低音";
            this.tr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tr1
            // 
            this.tr1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tr1.AutoSize = true;
            this.tr1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(154)))), ((int)(((byte)(203)))));
            this.tr1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tr1.Location = new System.Drawing.Point(81, 3);
            this.tr1.Margin = new System.Windows.Forms.Padding(0);
            this.tr1.Name = "tr1";
            this.tr1.Size = new System.Drawing.Size(600, 20);
            this.tr1.TabIndex = 1;
            this.tr1.Text = "時間軸";
            this.tr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tr0
            // 
            this.tr0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tr0.AutoSize = true;
            this.tr0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.tr0.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tr0.Location = new System.Drawing.Point(3, 3);
            this.tr0.Margin = new System.Windows.Forms.Padding(0);
            this.tr0.Name = "tr0";
            this.tr0.Size = new System.Drawing.Size(75, 20);
            this.tr0.TabIndex = 0;
            this.tr0.Text = "音軌";
            this.tr0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tr5
            // 
            this.tr5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tr5.AutoSize = true;
            this.tr5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.tr5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tr5.Location = new System.Drawing.Point(988, 3);
            this.tr5.Margin = new System.Windows.Forms.Padding(0);
            this.tr5.Name = "tr5";
            this.tr5.Size = new System.Drawing.Size(99, 20);
            this.tr5.TabIndex = 10;
            this.tr5.Text = "使用率";
            this.tr5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tr4
            // 
            this.tr4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tr4.AutoSize = true;
            this.tr4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.tr4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tr4.Location = new System.Drawing.Point(910, 3);
            this.tr4.Margin = new System.Windows.Forms.Padding(0);
            this.tr4.Name = "tr4";
            this.tr4.Size = new System.Drawing.Size(75, 20);
            this.tr4.TabIndex = 2;
            this.tr4.Text = "時間長度";
            this.tr4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(80, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(3, 26);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(71, 26);
            this.num1.TabIndex = 7;
            this.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num1.ValueChanged += new System.EventHandler(this.num1_ValueChanged);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(186, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // much
            // 
            this.much.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.much.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.much.Location = new System.Drawing.Point(1079, 25);
            this.much.Margin = new System.Windows.Forms.Padding(3);
            this.much.Name = "much";
            this.much.Size = new System.Drawing.Size(224, 82);
            this.much.TabIndex = 1;
            this.much.Text = "BPM：\r\n時間：\r\n最低音：\r\n最高音：\r\n";
            this.much.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tla3);
            this.panel2.Controls.Add(this.num1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(1079, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 58);
            this.panel2.TabIndex = 12;
            // 
            // tla3
            // 
            this.tla3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tla3.AutoSize = true;
            this.tla3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tla3.Location = new System.Drawing.Point(0, 3);
            this.tla3.Margin = new System.Windows.Forms.Padding(0);
            this.tla3.Name = "tla3";
            this.tla3.Size = new System.Drawing.Size(73, 20);
            this.tla3.TabIndex = 2;
            this.tla3.Text = "時間軸：";
            this.tla3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(1079, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 117);
            this.panel3.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(149, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 29);
            this.button4.TabIndex = 16;
            this.button4.Text = "重置";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(4, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 29);
            this.button3.TabIndex = 15;
            this.button3.Text = "移動";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(149, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(70, 28);
            this.comboBox2.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 28);
            this.comboBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "將音軌A盡可能的移置音軌B中\r\n    音軌A    ------->    音軌B\r\n                   ------->    \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sem2
            // 
            this.sem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sem2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sem2.Location = new System.Drawing.Point(1079, 113);
            this.sem2.Margin = new System.Windows.Forms.Padding(3);
            this.sem2.Name = "sem2";
            this.sem2.Size = new System.Drawing.Size(224, 85);
            this.sem2.TabIndex = 14;
            this.sem2.Text = "滑鼠所在位置\r\n音軌：\r\n時間：\r\n音符：\r\n";
            this.sem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spkm
            // 
            this.spkm.AutoSize = true;
            this.spkm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.spkm.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.spkm.ColumnCount = 2;
            this.spkm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.spkm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.spkm.Controls.Add(this.comboBox3, 1, 0);
            this.spkm.Controls.Add(this.label5, 0, 0);
            this.spkm.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.spkm.Location = new System.Drawing.Point(1, 0);
            this.spkm.Margin = new System.Windows.Forms.Padding(0);
            this.spkm.Name = "spkm";
            this.spkm.RowCount = 1;
            this.spkm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.spkm.Size = new System.Drawing.Size(198, 42);
            this.spkm.TabIndex = 15;
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(100, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(94, 28);
            this.comboBox3.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label5.Location = new System.Drawing.Point(1, 1);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "喇叭1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(1309, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 82);
            this.panel4.TabIndex = 16;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(147, 37);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 29);
            this.button6.TabIndex = 6;
            this.button6.Text = "python ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "輸出：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(4, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "Arduino ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(1309, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(224, 272);
            this.panel5.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(222, 270);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.button8);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(216, 39);
            this.panel6.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(139, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 29);
            this.button7.TabIndex = 6;
            this.button7.Text = "移除";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(10, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "喇叭";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(61, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 29);
            this.button8.TabIndex = 5;
            this.button8.Text = "增加";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.spkm);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 48);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(216, 219);
            this.panel7.TabIndex = 19;
            // 
            // save2
            // 
            this.save2.DefaultExt = "ino";
            this.save2.FileName = "intone";
            this.save2.Filter = "py檔|*.py";
            // 
            // save
            // 
            this.save.DefaultExt = "ino";
            this.save.FileName = "intone";
            this.save.Filter = "C 標頭檔|*.h";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 464);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.sem2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.much);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.spkm.ResumeLayout(false);
            this.spkm.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton onmidi;
        private System.Windows.Forms.OpenFileDialog oF1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TableLayoutPanel Panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label tr0;
        private System.Windows.Forms.Label tr1;
        private System.Windows.Forms.Label tr5;
        private System.Windows.Forms.Label tr4;
        private System.Windows.Forms.Label tr2;
        private System.Windows.Forms.Label tr3;
        private System.Windows.Forms.Label much;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label tla3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label sem2;
        private System.Windows.Forms.ToolStripTextBox CoBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel spkm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.SaveFileDialog save2;
        private System.Windows.Forms.SaveFileDialog save;
    }
}

