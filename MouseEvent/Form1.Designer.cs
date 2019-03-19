namespace MouseEvent
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
            this.label2 = new System.Windows.Forms.Label();
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
            this.TextBox_SendCount = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RadBtn_Count = new System.Windows.Forms.RadioButton();
            this.RadBtn_Time = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(442, 364);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(16, 118);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(498, 165);
            this.textBox1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AutoSize = true;
            this.Lbl_Status.Location = new System.Drawing.Point(19, 430);
            this.Lbl_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(0, 15);
            this.Lbl_Status.TabIndex = 2;
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "待发送的句子列表（每个单独一行）：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "选择的窗口：";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 49);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(395, 23);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Refresh.Location = new System.Drawing.Point(426, 45);
            this.Btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(95, 29);
            this.Btn_Refresh.TabIndex = 6;
            this.Btn_Refresh.Text = "刷新";
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "时间间隔(秒)：";
            // 
            // TextBox_MinValue
            // 
            this.TextBox_MinValue.Location = new System.Drawing.Point(145, 299);
            this.TextBox_MinValue.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_MinValue.Name = "TextBox_MinValue";
            this.TextBox_MinValue.Size = new System.Drawing.Size(78, 25);
            this.TextBox_MinValue.TabIndex = 8;
            this.TextBox_MinValue.Text = "1";
            this.TextBox_MinValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustAllowNumberInput);
            // 
            // TextBox_MaxValue
            // 
            this.TextBox_MaxValue.Location = new System.Drawing.Point(253, 300);
            this.TextBox_MaxValue.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_MaxValue.Name = "TextBox_MaxValue";
            this.TextBox_MaxValue.Size = new System.Drawing.Size(80, 25);
            this.TextBox_MaxValue.TabIndex = 8;
            this.TextBox_MaxValue.Text = "100";
            this.TextBox_MaxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustAllowNumberInput);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "-";
            // 
            // ChkBox_SendEnter
            // 
            this.ChkBox_SendEnter.AutoSize = true;
            this.ChkBox_SendEnter.Location = new System.Drawing.Point(370, 304);
            this.ChkBox_SendEnter.Name = "ChkBox_SendEnter";
            this.ChkBox_SendEnter.Size = new System.Drawing.Size(89, 19);
            this.ChkBox_SendEnter.TabIndex = 9;
            this.ChkBox_SendEnter.Text = "发送回车";
            this.ChkBox_SendEnter.UseVisualStyleBackColor = true;
            // 
            // ChkBox_AutoStop
            // 
            this.ChkBox_AutoStop.AutoSize = true;
            this.ChkBox_AutoStop.Location = new System.Drawing.Point(21, 336);
            this.ChkBox_AutoStop.Name = "ChkBox_AutoStop";
            this.ChkBox_AutoStop.Size = new System.Drawing.Size(89, 19);
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
            this.panel1.Location = new System.Drawing.Point(21, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 63);
            this.panel1.TabIndex = 11;
            // 
            // TextBox_SendCount
            // 
            this.TextBox_SendCount.Location = new System.Drawing.Point(29, 30);
            this.TextBox_SendCount.Name = "TextBox_SendCount";
            this.TextBox_SendCount.Size = new System.Drawing.Size(105, 25);
            this.TextBox_SendCount.TabIndex = 1;
            this.TextBox_SendCount.Text = "5";
            this.TextBox_SendCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustAllowNumberInput);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(194, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 25);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // RadBtn_Count
            // 
            this.RadBtn_Count.AutoSize = true;
            this.RadBtn_Count.Location = new System.Drawing.Point(6, 4);
            this.RadBtn_Count.Name = "RadBtn_Count";
            this.RadBtn_Count.Size = new System.Drawing.Size(133, 19);
            this.RadBtn_Count.TabIndex = 4;
            this.RadBtn_Count.TabStop = true;
            this.RadBtn_Count.Text = "达到指定次数：";
            this.RadBtn_Count.UseVisualStyleBackColor = true;
            this.RadBtn_Count.CheckedChanged += new System.EventHandler(this.RadBtn_Count_CheckedChanged);
            // 
            // RadBtn_Time
            // 
            this.RadBtn_Time.AutoSize = true;
            this.RadBtn_Time.Location = new System.Drawing.Point(174, 3);
            this.RadBtn_Time.Name = "RadBtn_Time";
            this.RadBtn_Time.Size = new System.Drawing.Size(133, 19);
            this.RadBtn_Time.TabIndex = 4;
            this.RadBtn_Time.TabStop = true;
            this.RadBtn_Time.Text = "到达指定时间：";
            this.RadBtn_Time.UseVisualStyleBackColor = true;
            this.RadBtn_Time.CheckedChanged += new System.EventHandler(this.RadBtn_Time_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChkBox_AutoStop);
            this.Controls.Add(this.ChkBox_SendEnter);
            this.Controls.Add(this.TextBox_MaxValue);
            this.Controls.Add(this.TextBox_MinValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_Status);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lbl_Status;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
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
    }
}

