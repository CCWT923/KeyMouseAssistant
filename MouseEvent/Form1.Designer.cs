﻿namespace MouseEvent
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lbl_Status = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_MinValue = new System.Windows.Forms.TextBox();
            this.TextBox_MaxValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkBox_SendEnter = new System.Windows.Forms.CheckBox();
            this.ChkBox_AutoStop = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RadBtn_Time = new System.Windows.Forms.RadioButton();
            this.RadBtn_Count = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TextBox_SendCount = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage_Sentence = new System.Windows.Forms.TabPage();
            this.RadBtn_Sentence = new System.Windows.Forms.RadioButton();
            this.RadBtn_SingleChar = new System.Windows.Forms.RadioButton();
            this.TabPage_Number = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBox_NumAppendStr = new System.Windows.Forms.TextBox();
            this.TextBox_NumStep = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBox_NumEnd = new System.Windows.Forms.TextBox();
            this.TextBox_NumStart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TabPage_Random = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBox_MaxCharNumber = new System.Windows.Forms.TextBox();
            this.TextBox_MinCharNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckBox_Number = new System.Windows.Forms.CheckBox();
            this.CheckBox_Letter = new System.Windows.Forms.CheckBox();
            this.CheckBox_ChineseChar = new System.Windows.Forms.CheckBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage_SendChar = new System.Windows.Forms.TabPage();
            this.TabPage_Mouse = new System.Windows.Forms.TabPage();
            this.RadButton_MouseDrag = new System.Windows.Forms.RadioButton();
            this.RadioButton_MouseClick = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabPage_Sentence.SuspendLayout();
            this.TabPage_Number.SuspendLayout();
            this.TabPage_Random.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.TabPage_SendChar.SuspendLayout();
            this.TabPage_Mouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(336, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-2, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(369, 163);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AutoSize = true;
            this.Lbl_Status.Location = new System.Drawing.Point(18, 442);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(0, 12);
            this.Lbl_Status.TabIndex = 2;
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "选择的窗口：";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(310, 25);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Refresh.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Refresh.Location = new System.Drawing.Point(333, 38);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(71, 23);
            this.Btn_Refresh.TabIndex = 6;
            this.Btn_Refresh.Text = "刷新";
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "时间间隔(秒)：";
            // 
            // TextBox_MinValue
            // 
            this.TextBox_MinValue.Location = new System.Drawing.Point(112, 327);
            this.TextBox_MinValue.Name = "TextBox_MinValue";
            this.TextBox_MinValue.Size = new System.Drawing.Size(60, 21);
            this.TextBox_MinValue.TabIndex = 8;
            this.TextBox_MinValue.Text = "1";
            this.TextBox_MinValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustAllowNumberInput);
            // 
            // TextBox_MaxValue
            // 
            this.TextBox_MaxValue.Location = new System.Drawing.Point(193, 328);
            this.TextBox_MaxValue.Name = "TextBox_MaxValue";
            this.TextBox_MaxValue.Size = new System.Drawing.Size(61, 21);
            this.TextBox_MaxValue.TabIndex = 8;
            this.TextBox_MaxValue.Text = "100";
            this.TextBox_MaxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustAllowNumberInput);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "-";
            // 
            // ChkBox_SendEnter
            // 
            this.ChkBox_SendEnter.AutoSize = true;
            this.ChkBox_SendEnter.Location = new System.Drawing.Point(299, 12);
            this.ChkBox_SendEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChkBox_SendEnter.Name = "ChkBox_SendEnter";
            this.ChkBox_SendEnter.Size = new System.Drawing.Size(72, 16);
            this.ChkBox_SendEnter.TabIndex = 9;
            this.ChkBox_SendEnter.Text = "发送回车";
            this.ChkBox_SendEnter.UseVisualStyleBackColor = true;
            // 
            // ChkBox_AutoStop
            // 
            this.ChkBox_AutoStop.AutoSize = true;
            this.ChkBox_AutoStop.Location = new System.Drawing.Point(20, 353);
            this.ChkBox_AutoStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChkBox_AutoStop.Name = "ChkBox_AutoStop";
            this.ChkBox_AutoStop.Size = new System.Drawing.Size(72, 16);
            this.ChkBox_AutoStop.TabIndex = 10;
            this.ChkBox_AutoStop.Text = "自动停止";
            this.ChkBox_AutoStop.UseVisualStyleBackColor = true;
            this.ChkBox_AutoStop.CheckedChanged += new System.EventHandler(this.ChkBox_AutoStop_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadBtn_Time);
            this.panel1.Controls.Add(this.RadBtn_Count);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.TextBox_SendCount);
            this.panel1.Location = new System.Drawing.Point(20, 372);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 56);
            this.panel1.TabIndex = 11;
            // 
            // RadBtn_Time
            // 
            this.RadBtn_Time.AutoSize = true;
            this.RadBtn_Time.Location = new System.Drawing.Point(130, 2);
            this.RadBtn_Time.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadBtn_Time.Name = "RadBtn_Time";
            this.RadBtn_Time.Size = new System.Drawing.Size(107, 16);
            this.RadBtn_Time.TabIndex = 4;
            this.RadBtn_Time.TabStop = true;
            this.RadBtn_Time.Text = "到达指定时间：";
            this.RadBtn_Time.UseVisualStyleBackColor = true;
            this.RadBtn_Time.CheckedChanged += new System.EventHandler(this.RadBtn_Time_CheckedChanged);
            // 
            // RadBtn_Count
            // 
            this.RadBtn_Count.AutoSize = true;
            this.RadBtn_Count.Location = new System.Drawing.Point(4, 3);
            this.RadBtn_Count.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadBtn_Count.Name = "RadBtn_Count";
            this.RadBtn_Count.Size = new System.Drawing.Size(107, 16);
            this.RadBtn_Count.TabIndex = 4;
            this.RadBtn_Count.TabStop = true;
            this.RadBtn_Count.Text = "达到指定次数：";
            this.RadBtn_Count.UseVisualStyleBackColor = true;
            this.RadBtn_Count.CheckedChanged += new System.EventHandler(this.RadBtn_Count_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 24);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 21);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // TextBox_SendCount
            // 
            this.TextBox_SendCount.Location = new System.Drawing.Point(22, 24);
            this.TextBox_SendCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox_SendCount.Name = "TextBox_SendCount";
            this.TextBox_SendCount.Size = new System.Drawing.Size(80, 21);
            this.TextBox_SendCount.TabIndex = 1;
            this.TextBox_SendCount.Text = "5";
            this.TextBox_SendCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustAllowNumberInput);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPage_Sentence);
            this.tabControl1.Controls.Add(this.TabPage_Number);
            this.tabControl1.Controls.Add(this.TabPage_Random);
            this.tabControl1.Location = new System.Drawing.Point(-3, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(385, 221);
            this.tabControl1.TabIndex = 12;
            // 
            // TabPage_Sentence
            // 
            this.TabPage_Sentence.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_Sentence.Controls.Add(this.RadBtn_Sentence);
            this.TabPage_Sentence.Controls.Add(this.RadBtn_SingleChar);
            this.TabPage_Sentence.Controls.Add(this.textBox1);
            this.TabPage_Sentence.Controls.Add(this.ChkBox_SendEnter);
            this.TabPage_Sentence.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Sentence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPage_Sentence.Name = "TabPage_Sentence";
            this.TabPage_Sentence.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPage_Sentence.Size = new System.Drawing.Size(377, 195);
            this.TabPage_Sentence.TabIndex = 0;
            this.TabPage_Sentence.Text = "发送语句";
            // 
            // RadBtn_Sentence
            // 
            this.RadBtn_Sentence.AutoSize = true;
            this.RadBtn_Sentence.Checked = true;
            this.RadBtn_Sentence.Location = new System.Drawing.Point(102, 12);
            this.RadBtn_Sentence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadBtn_Sentence.Name = "RadBtn_Sentence";
            this.RadBtn_Sentence.Size = new System.Drawing.Size(71, 16);
            this.RadBtn_Sentence.TabIndex = 3;
            this.RadBtn_Sentence.TabStop = true;
            this.RadBtn_Sentence.Text = "整句发送";
            this.RadBtn_Sentence.UseVisualStyleBackColor = true;
            // 
            // RadBtn_SingleChar
            // 
            this.RadBtn_SingleChar.AutoSize = true;
            this.RadBtn_SingleChar.Location = new System.Drawing.Point(5, 12);
            this.RadBtn_SingleChar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadBtn_SingleChar.Name = "RadBtn_SingleChar";
            this.RadBtn_SingleChar.Size = new System.Drawing.Size(83, 16);
            this.RadBtn_SingleChar.TabIndex = 3;
            this.RadBtn_SingleChar.Text = "逐字符发送";
            this.RadBtn_SingleChar.UseVisualStyleBackColor = true;
            // 
            // TabPage_Number
            // 
            this.TabPage_Number.Controls.Add(this.label9);
            this.TabPage_Number.Controls.Add(this.TextBox_NumAppendStr);
            this.TabPage_Number.Controls.Add(this.TextBox_NumStep);
            this.TabPage_Number.Controls.Add(this.label8);
            this.TabPage_Number.Controls.Add(this.label7);
            this.TabPage_Number.Controls.Add(this.TextBox_NumEnd);
            this.TabPage_Number.Controls.Add(this.TextBox_NumStart);
            this.TabPage_Number.Controls.Add(this.label6);
            this.TabPage_Number.Controls.Add(this.label5);
            this.TabPage_Number.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Number.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPage_Number.Name = "TabPage_Number";
            this.TabPage_Number.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPage_Number.Size = new System.Drawing.Size(377, 195);
            this.TabPage_Number.TabIndex = 1;
            this.TabPage_Number.Text = "发送数字";
            this.TabPage_Number.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 74);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "附加内容（多行内容则随机附加）：";
            // 
            // TextBox_NumAppendStr
            // 
            this.TextBox_NumAppendStr.Location = new System.Drawing.Point(12, 90);
            this.TextBox_NumAppendStr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox_NumAppendStr.Multiline = true;
            this.TextBox_NumAppendStr.Name = "TextBox_NumAppendStr";
            this.TextBox_NumAppendStr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_NumAppendStr.Size = new System.Drawing.Size(355, 92);
            this.TextBox_NumAppendStr.TabIndex = 5;
            // 
            // TextBox_NumStep
            // 
            this.TextBox_NumStep.Location = new System.Drawing.Point(73, 42);
            this.TextBox_NumStep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox_NumStep.Name = "TextBox_NumStep";
            this.TextBox_NumStep.Size = new System.Drawing.Size(68, 21);
            this.TextBox_NumStep.TabIndex = 5;
            this.TextBox_NumStep.Text = "1";
            this.TextBox_NumStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustAllowNumberInput);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "递增量：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "-";
            // 
            // TextBox_NumEnd
            // 
            this.TextBox_NumEnd.Location = new System.Drawing.Point(164, 10);
            this.TextBox_NumEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox_NumEnd.Name = "TextBox_NumEnd";
            this.TextBox_NumEnd.Size = new System.Drawing.Size(68, 21);
            this.TextBox_NumEnd.TabIndex = 2;
            this.TextBox_NumEnd.Text = "100";
            this.TextBox_NumEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustAllowNumberInput);
            // 
            // TextBox_NumStart
            // 
            this.TextBox_NumStart.Location = new System.Drawing.Point(73, 10);
            this.TextBox_NumStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox_NumStart.Name = "TextBox_NumStart";
            this.TextBox_NumStart.Size = new System.Drawing.Size(68, 21);
            this.TextBox_NumStart.TabIndex = 2;
            this.TextBox_NumStart.Text = "1";
            this.TextBox_NumStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustAllowNumberInput);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "数字范围：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 0;
            // 
            // TabPage_Random
            // 
            this.TabPage_Random.Controls.Add(this.label11);
            this.TabPage_Random.Controls.Add(this.TextBox_MaxCharNumber);
            this.TabPage_Random.Controls.Add(this.TextBox_MinCharNumber);
            this.TabPage_Random.Controls.Add(this.label10);
            this.TabPage_Random.Controls.Add(this.label2);
            this.TabPage_Random.Controls.Add(this.CheckBox_Number);
            this.TabPage_Random.Controls.Add(this.CheckBox_Letter);
            this.TabPage_Random.Controls.Add(this.CheckBox_ChineseChar);
            this.TabPage_Random.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Random.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPage_Random.Name = "TabPage_Random";
            this.TabPage_Random.Size = new System.Drawing.Size(377, 195);
            this.TabPage_Random.TabIndex = 2;
            this.TabPage_Random.Text = "随机字符";
            this.TabPage_Random.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 65);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "-";
            // 
            // TextBox_MaxCharNumber
            // 
            this.TextBox_MaxCharNumber.Location = new System.Drawing.Point(200, 62);
            this.TextBox_MaxCharNumber.Name = "TextBox_MaxCharNumber";
            this.TextBox_MaxCharNumber.Size = new System.Drawing.Size(46, 21);
            this.TextBox_MaxCharNumber.TabIndex = 5;
            this.TextBox_MaxCharNumber.Text = "5";
            // 
            // TextBox_MinCharNumber
            // 
            this.TextBox_MinCharNumber.Location = new System.Drawing.Point(133, 62);
            this.TextBox_MinCharNumber.Name = "TextBox_MinCharNumber";
            this.TextBox_MinCharNumber.Size = new System.Drawing.Size(46, 21);
            this.TextBox_MinCharNumber.TabIndex = 5;
            this.TextBox_MinCharNumber.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "生成的字符数区间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "包含如下字符：";
            // 
            // CheckBox_Number
            // 
            this.CheckBox_Number.AutoSize = true;
            this.CheckBox_Number.Location = new System.Drawing.Point(171, 33);
            this.CheckBox_Number.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckBox_Number.Name = "CheckBox_Number";
            this.CheckBox_Number.Size = new System.Drawing.Size(48, 16);
            this.CheckBox_Number.TabIndex = 1;
            this.CheckBox_Number.Text = "数字";
            this.CheckBox_Number.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Letter
            // 
            this.CheckBox_Letter.AutoSize = true;
            this.CheckBox_Letter.Location = new System.Drawing.Point(90, 33);
            this.CheckBox_Letter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckBox_Letter.Name = "CheckBox_Letter";
            this.CheckBox_Letter.Size = new System.Drawing.Size(48, 16);
            this.CheckBox_Letter.TabIndex = 1;
            this.CheckBox_Letter.Text = "字母";
            this.CheckBox_Letter.UseVisualStyleBackColor = true;
            // 
            // CheckBox_ChineseChar
            // 
            this.CheckBox_ChineseChar.AutoSize = true;
            this.CheckBox_ChineseChar.Checked = true;
            this.CheckBox_ChineseChar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_ChineseChar.Location = new System.Drawing.Point(12, 33);
            this.CheckBox_ChineseChar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckBox_ChineseChar.Name = "CheckBox_ChineseChar";
            this.CheckBox_ChineseChar.Size = new System.Drawing.Size(48, 16);
            this.CheckBox_ChineseChar.TabIndex = 0;
            this.CheckBox_ChineseChar.Text = "中文";
            this.CheckBox_ChineseChar.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.TabPage_SendChar);
            this.tabControl2.Controls.Add(this.TabPage_Mouse);
            this.tabControl2.Location = new System.Drawing.Point(16, 67);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(388, 250);
            this.tabControl2.TabIndex = 13;
            // 
            // TabPage_SendChar
            // 
            this.TabPage_SendChar.Controls.Add(this.tabControl1);
            this.TabPage_SendChar.Location = new System.Drawing.Point(4, 22);
            this.TabPage_SendChar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPage_SendChar.Name = "TabPage_SendChar";
            this.TabPage_SendChar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPage_SendChar.Size = new System.Drawing.Size(380, 224);
            this.TabPage_SendChar.TabIndex = 0;
            this.TabPage_SendChar.Text = "字符输入";
            this.TabPage_SendChar.UseVisualStyleBackColor = true;
            // 
            // TabPage_Mouse
            // 
            this.TabPage_Mouse.Controls.Add(this.RadioButton_MouseClick);
            this.TabPage_Mouse.Controls.Add(this.RadButton_MouseDrag);
            this.TabPage_Mouse.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Mouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPage_Mouse.Name = "TabPage_Mouse";
            this.TabPage_Mouse.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPage_Mouse.Size = new System.Drawing.Size(380, 224);
            this.TabPage_Mouse.TabIndex = 1;
            this.TabPage_Mouse.Text = "鼠标操作";
            this.TabPage_Mouse.UseVisualStyleBackColor = true;
            // 
            // RadButton_MouseDrag
            // 
            this.RadButton_MouseDrag.AutoSize = true;
            this.RadButton_MouseDrag.Location = new System.Drawing.Point(22, 18);
            this.RadButton_MouseDrag.Name = "RadButton_MouseDrag";
            this.RadButton_MouseDrag.Size = new System.Drawing.Size(47, 16);
            this.RadButton_MouseDrag.TabIndex = 0;
            this.RadButton_MouseDrag.TabStop = true;
            this.RadButton_MouseDrag.Text = "拖动";
            this.RadButton_MouseDrag.UseVisualStyleBackColor = true;
            // 
            // RadioButton_MouseClick
            // 
            this.RadioButton_MouseClick.AutoSize = true;
            this.RadioButton_MouseClick.Location = new System.Drawing.Point(22, 40);
            this.RadioButton_MouseClick.Name = "RadioButton_MouseClick";
            this.RadioButton_MouseClick.Size = new System.Drawing.Size(47, 16);
            this.RadioButton_MouseClick.TabIndex = 0;
            this.RadioButton_MouseClick.TabStop = true;
            this.RadioButton_MouseClick.Text = "单击";
            this.RadioButton_MouseClick.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(415, 470);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChkBox_AutoStop);
            this.Controls.Add(this.TextBox_MaxValue);
            this.Controls.Add(this.TextBox_MinValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_Status);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auto Message Sender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabPage_Sentence.ResumeLayout(false);
            this.TabPage_Sentence.PerformLayout();
            this.TabPage_Number.ResumeLayout(false);
            this.TabPage_Number.PerformLayout();
            this.TabPage_Random.ResumeLayout(false);
            this.TabPage_Random.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.TabPage_SendChar.ResumeLayout(false);
            this.TabPage_Mouse.ResumeLayout(false);
            this.TabPage_Mouse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lbl_Status;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_MinValue;
        private System.Windows.Forms.TextBox TextBox_MaxValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChkBox_SendEnter;
        private System.Windows.Forms.CheckBox ChkBox_AutoStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadBtn_Time;
        private System.Windows.Forms.RadioButton RadBtn_Count;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TextBox_SendCount;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPage_Sentence;
        private System.Windows.Forms.TabPage TabPage_Number;
        private System.Windows.Forms.TabPage TabPage_Random;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckBox_Number;
        private System.Windows.Forms.CheckBox CheckBox_Letter;
        private System.Windows.Forms.CheckBox CheckBox_ChineseChar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox_NumEnd;
        private System.Windows.Forms.TextBox TextBox_NumStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBox_NumAppendStr;
        private System.Windows.Forms.TextBox TextBox_NumStep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBox_MinCharNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextBox_MaxCharNumber;
        private System.Windows.Forms.RadioButton RadBtn_Sentence;
        private System.Windows.Forms.RadioButton RadBtn_SingleChar;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage TabPage_SendChar;
        private System.Windows.Forms.TabPage TabPage_Mouse;
        private System.Windows.Forms.RadioButton RadioButton_MouseClick;
        private System.Windows.Forms.RadioButton RadButton_MouseDrag;
    }
}

