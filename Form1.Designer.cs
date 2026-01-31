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
            this.btnLoadmidi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.textMidiPath = new System.Windows.Forms.ToolStripTextBox();
            this.openMidiDialog = new System.Windows.Forms.OpenFileDialog();
            this.Panel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tr0 = new System.Windows.Forms.Label();
            this.tr1 = new System.Windows.Forms.Label();
            this.tr2 = new System.Windows.Forms.Label();
            this.tr3 = new System.Windows.Forms.Label();
            this.tr4 = new System.Windows.Forms.Label();
            this.tr5 = new System.Windows.Forms.Label();
            this.btnPrevMinute = new System.Windows.Forms.Button();
            this.nudMinuteIndex = new System.Windows.Forms.NumericUpDown();
            this.btnNextMinute = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTimeIInfo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.cbTarget = new System.Windows.Forms.ComboBox();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCursorInfo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPython = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnArduino = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Panel8 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tblSpk = new System.Windows.Forms.TableLayoutPanel();
            this.cbSpk1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnRemoveSpk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddSpk = new System.Windows.Forms.Button();
            this.saveForArduino = new System.Windows.Forms.SaveFileDialog();
            this.saveForPython = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteIndex)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.Panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tblSpk.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadmidi,
            this.toolStripSeparator1,
            this.textMidiPath});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1534, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLoadmidi
            // 
            this.btnLoadmidi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLoadmidi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadmidi.Name = "btnLoadmidi";
            this.btnLoadmidi.Size = new System.Drawing.Size(60, 22);
            this.btnLoadmidi.Text = "載入midi";
            this.btnLoadmidi.Click += new System.EventHandler(this.onmidi_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // textMidiPath
            // 
            this.textMidiPath.BackColor = System.Drawing.Color.White;
            this.textMidiPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMidiPath.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.textMidiPath.Name = "textMidiPath";
            this.textMidiPath.ReadOnly = true;
            this.textMidiPath.Size = new System.Drawing.Size(500, 25);
            // 
            // openMidiDialog
            // 
            this.openMidiDialog.DefaultExt = "mid";
            this.openMidiDialog.Filter = "所有檔案 (*.*)|*.*|MIDI檔案|*.mid;*midi;*kar";
            this.openMidiDialog.InitialDirectory = "/";
            this.openMidiDialog.Title = "開啟midi檔";
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
            this.Panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.Panel1.Controls.Add(this.tr0, 0, 0);
            this.Panel1.Controls.Add(this.tr1, 1, 0);
            this.Panel1.Controls.Add(this.tr2, 2, 0);
            this.Panel1.Controls.Add(this.tr3, 3, 0);
            this.Panel1.Controls.Add(this.tr4, 4, 0);
            this.Panel1.Controls.Add(this.tr5, 5, 0);
            this.Panel1.Location = new System.Drawing.Point(0, 25);
            this.Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.Panel1.Name = "Panel1";
            this.Panel1.RowCount = 1;
            this.Panel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Panel1.Size = new System.Drawing.Size(1066, 26);
            this.Panel1.TabIndex = 4;
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
            this.tr5.Size = new System.Drawing.Size(75, 20);
            this.tr5.TabIndex = 10;
            this.tr5.Text = "使用率";
            this.tr5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrevMinute
            // 
            this.btnPrevMinute.AutoSize = true;
            this.btnPrevMinute.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevMinute.Location = new System.Drawing.Point(80, 27);
            this.btnPrevMinute.Name = "btnPrevMinute";
            this.btnPrevMinute.Size = new System.Drawing.Size(33, 25);
            this.btnPrevMinute.TabIndex = 5;
            this.btnPrevMinute.Text = "<";
            this.btnPrevMinute.UseVisualStyleBackColor = true;
            this.btnPrevMinute.Click += new System.EventHandler(this.btnPrevMinute_Click);
            // 
            // nudMinuteIndex
            // 
            this.nudMinuteIndex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinuteIndex.Location = new System.Drawing.Point(3, 26);
            this.nudMinuteIndex.Name = "nudMinuteIndex";
            this.nudMinuteIndex.Size = new System.Drawing.Size(71, 26);
            this.nudMinuteIndex.TabIndex = 7;
            this.nudMinuteIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMinuteIndex.ValueChanged += new System.EventHandler(this.nudMinuteIndex_ValueChanged);
            // 
            // btnNextMinute
            // 
            this.btnNextMinute.AutoSize = true;
            this.btnNextMinute.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextMinute.Location = new System.Drawing.Point(186, 26);
            this.btnNextMinute.Name = "btnNextMinute";
            this.btnNextMinute.Size = new System.Drawing.Size(33, 25);
            this.btnNextMinute.TabIndex = 8;
            this.btnNextMinute.Text = ">";
            this.btnNextMinute.UseVisualStyleBackColor = true;
            this.btnNextMinute.Click += new System.EventHandler(this.btnNextMinute_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInfo.Location = new System.Drawing.Point(1069, 25);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(3);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(224, 82);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "BPM：\r\n時間：\r\n最低音：\r\n最高音：\r\n";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTimeIInfo);
            this.panel2.Controls.Add(this.nudMinuteIndex);
            this.panel2.Controls.Add(this.btnPrevMinute);
            this.panel2.Controls.Add(this.btnNextMinute);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(1069, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 58);
            this.panel2.TabIndex = 12;
            // 
            // lblTimeIInfo
            // 
            this.lblTimeIInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeIInfo.AutoSize = true;
            this.lblTimeIInfo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTimeIInfo.Location = new System.Drawing.Point(0, 3);
            this.lblTimeIInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTimeIInfo.Name = "lblTimeIInfo";
            this.lblTimeIInfo.Size = new System.Drawing.Size(73, 20);
            this.lblTimeIInfo.TabIndex = 2;
            this.lblTimeIInfo.Text = "時間軸：";
            this.lblTimeIInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnMove);
            this.panel3.Controls.Add(this.cbTarget);
            this.panel3.Controls.Add(this.cbSource);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(1069, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 117);
            this.panel3.TabIndex = 13;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(149, 77);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 29);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMove
            // 
            this.btnMove.AutoSize = true;
            this.btnMove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.Location = new System.Drawing.Point(4, 77);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(70, 29);
            this.btnMove.TabIndex = 15;
            this.btnMove.Text = "移動";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // cbTarget
            // 
            this.cbTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTarget.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbTarget.FormattingEnabled = true;
            this.cbTarget.Location = new System.Drawing.Point(149, 43);
            this.cbTarget.Name = "cbTarget";
            this.cbTarget.Size = new System.Drawing.Size(70, 28);
            this.cbTarget.TabIndex = 15;
            // 
            // cbSource
            // 
            this.cbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSource.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Location = new System.Drawing.Point(4, 43);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(70, 28);
            this.cbSource.TabIndex = 14;
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
            // lblCursorInfo
            // 
            this.lblCursorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCursorInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCursorInfo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCursorInfo.Location = new System.Drawing.Point(1069, 113);
            this.lblCursorInfo.Margin = new System.Windows.Forms.Padding(3);
            this.lblCursorInfo.Name = "lblCursorInfo";
            this.lblCursorInfo.Size = new System.Drawing.Size(224, 85);
            this.lblCursorInfo.TabIndex = 14;
            this.lblCursorInfo.Text = "滑鼠所在位置\r\n音軌：\r\n時間：\r\n音符：\r\n";
            this.lblCursorInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnPython);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnArduino);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(1299, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 82);
            this.panel4.TabIndex = 16;
            // 
            // btnPython
            // 
            this.btnPython.AutoSize = true;
            this.btnPython.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPython.Location = new System.Drawing.Point(147, 37);
            this.btnPython.Name = "btnPython";
            this.btnPython.Size = new System.Drawing.Size(72, 29);
            this.btnPython.TabIndex = 6;
            this.btnPython.Text = "python ";
            this.btnPython.UseVisualStyleBackColor = true;
            this.btnPython.Click += new System.EventHandler(this.button6_Click);
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
            // btnArduino
            // 
            this.btnArduino.AutoSize = true;
            this.btnArduino.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArduino.Location = new System.Drawing.Point(4, 37);
            this.btnArduino.Name = "btnArduino";
            this.btnArduino.Size = new System.Drawing.Size(72, 29);
            this.btnArduino.TabIndex = 5;
            this.btnArduino.Text = "Arduino ";
            this.btnArduino.UseVisualStyleBackColor = true;
            this.btnArduino.Click += new System.EventHandler(this.btnArduino_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Panel8);
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(1299, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(224, 272);
            this.panel5.TabIndex = 17;
            // 
            // Panel8
            // 
            this.Panel8.AutoSize = true;
            this.Panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel8.ColumnCount = 1;
            this.Panel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.Panel8.Controls.Add(this.panel7, 0, 1);
            this.Panel8.Controls.Add(this.panel6, 0, 0);
            this.Panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel8.Location = new System.Drawing.Point(0, 0);
            this.Panel8.Margin = new System.Windows.Forms.Padding(0);
            this.Panel8.Name = "Panel8";
            this.Panel8.RowCount = 2;
            this.Panel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Panel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel8.Size = new System.Drawing.Size(222, 270);
            this.Panel8.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.tblSpk);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 48);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(216, 219);
            this.panel7.TabIndex = 20;
            // 
            // tblSpk
            // 
            this.tblSpk.AutoSize = true;
            this.tblSpk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblSpk.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblSpk.ColumnCount = 2;
            this.tblSpk.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tblSpk.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblSpk.Controls.Add(this.cbSpk1, 1, 0);
            this.tblSpk.Controls.Add(this.label4, 0, 0);
            this.tblSpk.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblSpk.Location = new System.Drawing.Point(1, 0);
            this.tblSpk.Margin = new System.Windows.Forms.Padding(0);
            this.tblSpk.Name = "tblSpk";
            this.tblSpk.RowCount = 1;
            this.tblSpk.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblSpk.Size = new System.Drawing.Size(200, 39);
            this.tblSpk.TabIndex = 15;
            // 
            // cbSpk1
            // 
            this.cbSpk1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpk1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpk1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbSpk1.FormattingEnabled = true;
            this.cbSpk1.Location = new System.Drawing.Point(80, 4);
            this.cbSpk1.Name = "cbSpk1";
            this.cbSpk1.Size = new System.Drawing.Size(116, 28);
            this.cbSpk1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label4.Location = new System.Drawing.Point(1, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "喇叭1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnRemoveSpk);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.btnAddSpk);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(216, 39);
            this.panel6.TabIndex = 18;
            // 
            // btnRemoveSpk
            // 
            this.btnRemoveSpk.AutoSize = true;
            this.btnRemoveSpk.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSpk.Location = new System.Drawing.Point(139, 3);
            this.btnRemoveSpk.Name = "btnRemoveSpk";
            this.btnRemoveSpk.Size = new System.Drawing.Size(72, 29);
            this.btnRemoveSpk.TabIndex = 6;
            this.btnRemoveSpk.Text = "移除";
            this.btnRemoveSpk.UseVisualStyleBackColor = true;
            this.btnRemoveSpk.Click += new System.EventHandler(this.btnRemoveSpk_Click);
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
            // btnAddSpk
            // 
            this.btnAddSpk.AutoSize = true;
            this.btnAddSpk.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSpk.Location = new System.Drawing.Point(61, 3);
            this.btnAddSpk.Name = "btnAddSpk";
            this.btnAddSpk.Size = new System.Drawing.Size(72, 29);
            this.btnAddSpk.TabIndex = 5;
            this.btnAddSpk.Text = "增加";
            this.btnAddSpk.UseVisualStyleBackColor = true;
            this.btnAddSpk.Click += new System.EventHandler(this.btnAddSpk_Click);
            // 
            // saveForArduino
            // 
            this.saveForArduino.DefaultExt = "ino";
            this.saveForArduino.FileName = "intone";
            this.saveForArduino.Filter = "C 標頭檔|*.h";
            // 
            // saveForPython
            // 
            this.saveForPython.DefaultExt = "ino";
            this.saveForPython.FileName = "intone";
            this.saveForPython.Filter = "py檔|*.py";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 391);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblCursorInfo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(1550, 430);
            this.Name = "Form1";
            this.Text = "midi轉換器";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteIndex)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.Panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tblSpk.ResumeLayout(false);
            this.tblSpk.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tr0;
        private System.Windows.Forms.Label tr1;
        private System.Windows.Forms.Label tr2;
        private System.Windows.Forms.Label tr3;
        private System.Windows.Forms.Label tr4;
        private System.Windows.Forms.Label tr5;
        private System.Windows.Forms.TableLayoutPanel Panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel Panel8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox textMidiPath;       
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnLoadmidi;
        private System.Windows.Forms.Button btnArduino;
        private System.Windows.Forms.Button btnPython;
        private System.Windows.Forms.OpenFileDialog openMidiDialog;
        private System.Windows.Forms.SaveFileDialog saveForArduino;
        private System.Windows.Forms.SaveFileDialog saveForPython;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblCursorInfo;
        private System.Windows.Forms.Label lblTimeIInfo;
        private System.Windows.Forms.NumericUpDown nudMinuteIndex;
        private System.Windows.Forms.Button btnPrevMinute;
        private System.Windows.Forms.Button btnNextMinute;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.ComboBox cbTarget;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddSpk;
        private System.Windows.Forms.Button btnRemoveSpk;

        private System.Windows.Forms.TableLayoutPanel tblSpk;
        private System.Windows.Forms.ComboBox cbSpk1;
    }
}

