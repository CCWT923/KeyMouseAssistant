using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MouseEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random _Random_TimerInterval;
        private Random _Random_Choice;
        private int _TimerInterval = 1000;
        private int _Choice = 0;
        private int _TimerIntervalMaxValue = 2100000;
        private int _TimerIntervalMinValue = 600000;
        private int _SendCount = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == "")
            {
                ShowInfo("文本框内容不能为空！");
                return;
            }

            _Random_TimerInterval = new Random(DateTime.Now.Millisecond);
            _TimerInterval = _Random_TimerInterval.Next(_TimerIntervalMinValue, _TimerIntervalMaxValue);
            
            if(timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "Start";
                ShowInfo("计时器停止。");
            }
            else
            {
                timer1.Enabled = true;
                timer1.Interval = _TimerInterval;
                button1.Text = "Stop";
                ShowInfo("计时器启动，周期： " + GetValueOfTime(_TimerInterval) + " 分钟。");
            }
        }
        private int GetValueOfTime(int t)
        {
            return t / 1000 / 60;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //滚动鼠标
            //Win32API.mouse_event(0x800, 500, 500, int.Parse(textBox1.Text), 0);
            string[] sentences = GetSentence(textBox1.Text);
            //随机选择一个句子
            string s = sentences[_Choice];
            //发送
            SendKeys.Send(s);
            _SendCount++;
            ShowInfo("发送 " + _SendCount.ToString() + " 次内容。");

            //随机选择定时器周期和句子索引
            _Random_TimerInterval = new Random(DateTime.Now.Millisecond);
            _Random_Choice = new Random(DateTime.Now.Millisecond);
            _TimerInterval = _Random_TimerInterval.Next(_TimerIntervalMinValue, _TimerIntervalMaxValue);
            _Choice = _Random_Choice.Next(0, sentences.Length - 1);
            timer1.Interval = _TimerInterval;
            ShowInfo("当前时钟周期为："  + GetValueOfTime(_TimerInterval) + "分钟。");
            
        }

        private string[] GetSentence(string s)
        {
            string[] sentence = s.Split('\n');
            return sentence;
        }

        private void ShowInfo(string s)
        {
            label1.Text = s;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(DateTime.Now.Hour >= 6 && DateTime.Now.Minute >= 40)
            {
                timer1.Enabled = false;
                ShowInfo(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + " 停止运行。");
            }
        }
    }
}
