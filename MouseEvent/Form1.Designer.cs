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
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.RadBtn_SendKeys = new System.Windows.Forms.RadioButton();
            this.BtnRad_MouseEvent = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 179);
            this.textBox1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // RadBtn_SendKeys
            // 
            this.RadBtn_SendKeys.AutoSize = true;
            this.RadBtn_SendKeys.Location = new System.Drawing.Point(38, 25);
            this.RadBtn_SendKeys.Name = "RadBtn_SendKeys";
            this.RadBtn_SendKeys.Size = new System.Drawing.Size(71, 16);
            this.RadBtn_SendKeys.TabIndex = 3;
            this.RadBtn_SendKeys.TabStop = true;
            this.RadBtn_SendKeys.Text = "发送文本";
            this.RadBtn_SendKeys.UseVisualStyleBackColor = true;
            // 
            // BtnRad_MouseEvent
            // 
            this.BtnRad_MouseEvent.AutoSize = true;
            this.BtnRad_MouseEvent.Location = new System.Drawing.Point(171, 25);
            this.BtnRad_MouseEvent.Name = "BtnRad_MouseEvent";
            this.BtnRad_MouseEvent.Size = new System.Drawing.Size(71, 16);
            this.BtnRad_MouseEvent.TabIndex = 3;
            this.BtnRad_MouseEvent.TabStop = true;
            this.BtnRad_MouseEvent.Text = "鼠标事件";
            this.BtnRad_MouseEvent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 377);
            this.Controls.Add(this.BtnRad_MouseEvent);
            this.Controls.Add(this.RadBtn_SendKeys);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RadioButton RadBtn_SendKeys;
        private System.Windows.Forms.RadioButton BtnRad_MouseEvent;
    }
}

