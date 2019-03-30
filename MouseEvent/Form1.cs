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
        private IntPtr _SelectedHwnd = IntPtr.Zero; //当前选择的窗口句柄
        private const char _split = ';';
        
        /// <summary>
        /// 验证每个TabControl的内容
        /// </summary>
        /// <returns></returns>
        private bool ValidTabData(ref TabControl tab)
        {
            if(tab.SelectedIndex == 0)
            {
                if (textBox1.Text.Trim() == "" || TextBox_MinValue.Text == "" 
                    || TextBox_MaxValue.Text == "" || comboBox1.SelectedItem == null)
                {
                    return false;
                }
            }
            if(tab.SelectedIndex == 1)
            {
                if(TextBox_NumStart.Text == string.Empty || TextBox_NumEnd.Text == string.Empty 
                    || TextBox_NumStep.Text == string.Empty || comboBox1.SelectedItem == null 
                    || (double.Parse(TextBox_NumStart.Text) >= double.Parse(TextBox_NumEnd.Text)))
                {
                    return false;
                }
                else
                {
                    numStarted = false;
                }
               
            }
            if(tab.SelectedIndex == 2)
            {
                if (comboBox1.SelectedItem == null || (CheckBox_Letter.Checked == false && CheckBox_Number.Checked == false && CheckBox_ChineseChar.Checked == false))
                {
                    return false;
                }
            }

            return true ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!ValidTabData(ref tabControl1))
            {
                return;
            }

            GetTimeIntervalRandom();
            generator = new CharGenerator();

            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "开始";
                ShowInfo("停止。");
            }
            else
            {
                timer1.Enabled = true;
                timer1.Interval = _TimerInterval;
                button1.Text = "停止";
                ShowInfo("启动，周期：" + GetValueOfTime(_TimerInterval) + " 秒。");
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
            _TimerIntervalMinValue = (int)(double.Parse(TextBox_MinValue.Text) * 1000);
            _TimerIntervalMaxValue = (int)(double.Parse(TextBox_MaxValue.Text) * 1000);
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

        int totalCount = 0;
        double numStart = 0.0;
        double numEnd = 0.0;
        bool numStarted = false;
        string toSendStr = "";
        double numStep = 0.0;
        CharGenerator generator;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if( _SelectedHwnd == GetForegroundWindow())
            {
                //滚动鼠标
                //Win32API.mouse_event(0x800, 500, 500, int.Parse(textBox1.Text), 0);
                if (tabControl1.SelectedIndex == 0)
                {
                    sentences = GetSentence(textBox1.Text);
                    _Random_Choice = new Random(DateTime.Now.Millisecond);
                    _Choice = _Random_Choice.Next(0, sentences.Length);

                    //随机选择一个句子
                    toSendStr = sentences[_Choice];

                    if (toSendStr == string.Empty)
                    {
                        return;
                    }
                }
                //TODO: 发送数字
                if(tabControl1.SelectedIndex == 1)
                {
                    if(!numStarted)
                    {
                        numStart = double.Parse(TextBox_NumStart.Text);
                        numStarted = true;
                    }

                    numEnd = double.Parse(TextBox_NumEnd.Text);
                    numStep = double.Parse(TextBox_NumStep.Text);
                    numStart += numStep;
                    if (numStart < numEnd)
                    {
                        toSendStr = numStart.ToString();
                    }
                    else
                    {
                        SwitchTimerStatus(false);
                        timer1.Enabled = false;
                    }

                }
                if(tabControl1.SelectedIndex == 2)
                {
                    toSendStr = generator.GetChar(CharGenerator.CharType.ChineseCharacters);
                }

                //发送
                SendKeys.Send(toSendStr);

                _SendCount++;

                ShowInfo("发送 " + _SendCount + " 次；周期：" + (_TimerInterval >= 1000 ? GetValueOfTime(_TimerInterval) + "秒。" : _TimerInterval + "毫秒。"));

                ////发送回车键
                if (ChkBox_SendEnter.Checked)
                {
                    SendKeys.Send("{Enter}");
                }

                if (ChkBox_AutoStop.Checked == true)
                {
                    if(RadBtn_Count.Checked)
                    {
                        totalCount = int.Parse(TextBox_SendCount.Text);
                        if(_SendCount >= totalCount)
                        {
                            SwitchTimerStatus(false);
                            timer1.Enabled = false;
                        }
                    }
                    if(RadBtn_Time.Checked)
                    {
                        timer2.Interval = 1000;
                        timer2.Enabled = true;
                    }
                }
                //DebugOut("获取下一次的时间周期开始。");
                GetTimeIntervalRandom();
                DebugOut("获取下一次的时间周期结束。");
                timer1.Interval = _TimerInterval;

            }
            else
            {
                ShowInfo("非指定窗口，停止发送");
            }
        }

        private string[] GetSentence(string s)
        {
            //因为Windows系统使用的“\r\n”作为换行符，为了通用性，使用Environment
            //string[] sentence = s.Split(Environment.NewLine.ToCharArray());
            string[] sentence = s.Split(new string[] { Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
            //TODO:获取的里面，有很多空字符串
            return sentence;
        }
#if DEBUG
        private void DebugOut(string message)
        {
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff") + "\t" + message);
        }
#endif

        private void ShowInfo(string s)
        {
            Lbl_Status.Text = s;
        }
        //TODO：Convert.ToInt32('一')
        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime desTime = dateTimePicker1.Value;
            if(DateTime.Now.Year >= desTime.Year && DateTime.Now.Month >= desTime.Month && DateTime.Now.Day >= desTime.Day 
                && DateTime.Now.Hour >= desTime.Hour && DateTime.Now.Minute >= desTime.Minute)
            {
                timer1.Enabled = false;
                SwitchTimerStatus(false);
                timer2.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetWindowsList();
            ChkBox_AutoStop.Checked = false;
            panel1.Enabled = false;
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
                        comboBox1.Items.Add(wndPtr + _split.ToString() + sb.ToString());
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

        private void SwitchTimerStatus(bool enable)
        {
            if(enable == true)
            {
                ShowInfo("计时器启动。");
                button1.Text = "停止";

            }
            else
            {
                ShowInfo("计时器停止。");
                button1.Text = "开始";
                _SendCount = 0;
            }
        }

        /// <summary>
        /// 获取当前活动窗口的句柄
        /// </summary>
        /// <returns></returns>
        private IntPtr GetForegroundWindow()
        {
            return Win32API.GetForegroundWindow();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedHwnd = GetIntptrFromSelectedItem(comboBox1.SelectedItem.ToString(), _split);
        }
        /// <summary>
        /// 获取选中项目所代表的窗口句柄
        /// </summary>
        /// <param name="str"></param>
        /// <param name="split"></param>
        /// <returns></returns>
        private IntPtr GetIntptrFromSelectedItem(string str, char split)
        {
            IntPtr ptr;
            ptr = new IntPtr(int.Parse(str.Substring(0, str.IndexOf(split))));
            return ptr;
        }

        private void ChkBox_AutoStop_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkBox_AutoStop.Checked)
            {
                panel1.Enabled = true;
                RadBtn_Count.Checked = true;
            }
            else
            {
                panel1.Enabled = false;

            }
        }

        private void RadBtn_Count_CheckedChanged(object sender, EventArgs e)
        {
            if(RadBtn_Count.Checked)
            {
                dateTimePicker1.Enabled = false;
                TextBox_SendCount.Enabled = true;
            }
        }

        private void RadBtn_Time_CheckedChanged(object sender, EventArgs e)
        {
            if(RadBtn_Time.Checked)
            {
                TextBox_SendCount.Enabled = false;
                dateTimePicker1.Enabled = true;
            }
            
        }
    }
}
