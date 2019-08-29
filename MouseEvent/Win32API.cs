using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MouseEvent
{
    static class Win32API
    {
        /// <summary>
        /// 鼠标事件
        /// </summary>
        /// <param name="flags">
        /// 指定单击按钮和鼠标动作的多种情况。参数可以是下列值的任何合理组合：
        /// ABSOLUTE：表名参数dX、dY含有规范化的绝对坐标。如果不设置此位，参数则是相对数据：相对于上次位置
        ///          的改动位置。
        /// MOVE：表示发生移动。
        /// LEFTDOWN：按下鼠标左键。
        /// LEFTUP：左键松开。
        /// RIGHTDOWN：右键按下。
        /// RIGHTUP：右键松开。
        /// MIDDLEDOWN：中键按下。
        /// MIDDLEUP：中键松开。
        /// WHEEL：滚轮滚动，滚动的数据由dwData指定。
        /// </param>
        /// <param name="dX">鼠标沿x轴的绝对位置或者从上次鼠标事件以来的移动数量。依赖于MOUSEEVENTF_ABSOLUTE的设置。</param>
        /// <param name="dY">鼠标沿y轴的绝对位置或者从上次鼠标事件以来移动的数量。依赖于MOUSEEVENTF_ABSOLUTE的设置。</param>
        /// <param name="dwData">如果flags为MOUSEEVENTF_WHEEL，则dwData指定鼠标滚轮移动的数量。
        /// 正数表示滚轮向前转动，即远离用户；负数表示滚轮向后滚动，即朝向用户。一个轮击定义为WHEEL_DELTA，
        /// 即120。如果flags不是WHEEL，则dwData应为零。
        /// </param>
        /// <param name="extraInfo">指定与鼠标事件相关的32位值。应用程序调用GetMessageExtraInfo来获取此信息</param>
        [DllImport("user32.dll")]
        public static extern void mouse_event(MouseFlags flags, int dX, int dY, int dwData, int extraInfo);

        public enum MouseFlags:int
        {
            MOUSEEVENTF_MOVE = 0x0001, //鼠标移动
            MOUSEEVENTF_LEFTDOWN = 0x0002, //左键按下
            MOUSEEVENTF_LEFTUP = 0x0004, //左键抬起
            MOUSEEVENTF_RIGHTDOWN = 0x0008, //右键按下
            MOUSEEVENTF_RIGHTUP = 0x0010, //右键抬起
            MOUSEEVENTF_MIDDLEDOWN = 0x0020, //中键按下
            MOUSEEVENTF_MIDDLEUP = 0x0040, //中键抬起
            MOUSEEVENTF_WHEEL = 0x800, //鼠标滚动
            MOUSEEVENT_ABSOLUTE = 0x8000 //是否采用绝对坐标
        };

        /// <summary>
        /// 获取与指定窗口有特定关系的窗口
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="cmdShow"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindow(IntPtr hwnd, WINDOWRELATION cmdShow);
        /// <summary>
        /// 获取桌面的窗口句柄
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();
        /// <summary>
        /// 窗口之间关系的常量值
        /// </summary>
        public enum WINDOWRELATION : uint
        {
            GW_HWNDFIRST = 0,
            GW_HWNDLAST = 1,
            GW_HWNDNEXT = 2,
            GW_HWNDPREV = 3,
            GW_OWNER = 4,
            GW_CHILD = 5,
            GW_ENABLEDPOPUP = 6
        };
        /// <summary>
        /// 获取活动窗口的句柄
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        /// <summary>
        /// 通过类名或者窗口标题查找窗口句柄
        /// </summary>
        /// <param name="className">类名，不指定则使用null</param>
        /// <param name="captionText">窗口标题，不指定则使用null</param>
        /// <returns>返回查找到的窗口句柄，如果返回值为0，则查找失败</returns>
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string className, string captionText);

        /// <summary>
        /// 获取指定句柄的窗口标题
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="s"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr hwnd, StringBuilder s, int maxLength);

        /// <summary>
        /// 激活指定的窗口
        /// </summary>
        /// <param name="hwnd"></param>
        /// <returns>如果成功设置窗口为前台窗口，返回非零值，否则返回零</returns>
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hwnd);

        /// <summary>
        /// 包含窗体位置及尺寸的结构体
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        };
        /// <summary>
        /// 获取窗口的位置及尺寸信息
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="rect"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref RECT rect);

        /// <summary>
        /// 判断该窗口的可视状态，显示或者隐藏的状态
        /// </summary>
        /// <param name="hwnd"></param>
        /// <returns>如果窗口为非隐藏状态，返回为非零值；否则返回零</returns>
        [DllImport("user32.dll")]
        public static extern bool IsWindowVisible(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern bool IsZoomed(IntPtr hwnd); 
    }
}
