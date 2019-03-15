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
        private int _TimerIntervalMaxValue;
        private int _TimerIntervalMinValue;
        private int _SendCount = 0;
        string[] sentences;


        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == "")
            {
                ShowInfo("文本框内容不能为空！");
                return;
            }

            if(TextBox_MinValue.Text == "" || TextBox_MaxValue.Text == "")
            {
                ShowInfo("时间间隔不正确！");
                return;
            }

            GetTimeIntervalRandom();

            if (timer1.Enabled)
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
                ShowInfo("计时器启动，周期：" + GetValueOfTime(_TimerInterval) + " 秒。");
            }
        }

        private int GetValueOfTime(int t)
        {
            return t / 1000;
        }

        /// <summary>
        /// 获取时间间隔随机数
        /// </summary>
        private void GetTimeIntervalRandom()
        {
            //最小时间和最大时间
            _TimerIntervalMinValue = (int)double.Parse(TextBox_MinValue.Text) * 1000;
            _TimerIntervalMaxValue = (int)double.Parse(TextBox_MaxValue.Text) * 1000;
            //最小值大于最大值，则交换两个值
            if (_TimerIntervalMinValue > _TimerIntervalMaxValue)
            {
                int t = _TimerIntervalMinValue;
                _TimerIntervalMinValue = _TimerIntervalMaxValue;
                _TimerIntervalMaxValue = t;
            }

            //生成随机数
            _Random_TimerInterval = new Random(DateTime.Now.Millisecond);
            _TimerInterval = _Random_TimerInterval.Next(_TimerIntervalMinValue, _TimerIntervalMaxValue);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //滚动鼠标
            //Win32API.mouse_event(0x800, 500, 500, int.Parse(textBox1.Text), 0);
            sentences = GetSentence(textBox1.Text);

            _Random_Choice = new Random(DateTime.Now.Millisecond);
            _Choice = _Random_Choice.Next(0, sentences.Length);

            //随机选择一个句子
            string s = sentences[_Choice];
            if(s == string.Empty)
            {
                return;
            }
            //发送
            SendKeys.Send(s);
            //发送回车键
            //SendKeys.Send("{Enter}");
            _SendCount++;
            ShowInfo("发送 " + _SendCount.ToString() + " 次内容。");

            GetTimeIntervalRandom();

            timer1.Interval = _TimerInterval;
            ShowInfo("当前时钟周期为："  + (_TimerInterval >= 1000 ? GetValueOfTime(_TimerInterval) + "秒。" : _TimerInterval + "毫秒。"));
        }

        private string[] GetSentence(string s)
        {
            //TODO：（记录）因为Windows系统使用的“\r\n”作为换行符，为了通用性，使用Environment
            string[] sentence = s.Split(Environment.NewLine.ToCharArray());
            return sentence;
        }

        private void ShowInfo(string s)
        {
            Lbl_Status.Text = s;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(DateTime.Now.Hour >= 6 && DateTime.Now.Minute >= 40)
            {
                timer1.Enabled = false;
                ShowInfo(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + " 停止运行。");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetWindowsList();
        }

        private void GetWindowsList()
        {
            comboBox1.Items.Clear();
            IntPtr desktop = Win32API.GetDesktopWindow(); //获取桌面的句柄
            if (desktop != IntPtr.Zero)
            {
                Win32API.RECT rect = new Win32API.RECT();
                int count = 0;
                int maxLen = 1024;
                StringBuilder sb = new StringBuilder(maxLen);

                //获取所有的窗体
                IntPtr wndPtr = Win32API.GetWindow(desktop, Win32API.WINDOWRELATION.GW_CHILD);
                while (wndPtr != IntPtr.Zero)
                {
                    //获取窗口的相关信息
                    Win32API.GetWindowRect(wndPtr, ref rect);
                    count = Win32API.GetWindowText(wndPtr, sb, maxLen);
                    if (rect.bottom - rect.top > 20 && rect.right - rect.left > 20 && count > 0)
                    {
                        comboBox1.Items.Add(sb.ToString() + ", " + wndPtr);
                    }

                    wndPtr = Win32API.GetWindow(wndPtr, Win32API.WINDOWRELATION.GW_HWNDNEXT);
                }
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            GetWindowsList();
        }
        /// <summary>
        /// TODO：（记录）只允许输入数字、小数点和退格键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JustAllowNumberInput(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
