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
        [DllImport("user32.dll")]
        public static extern void mouse_event(int flags, int dX, int dY, int button, int extraInfo);

        const int MOUSEEVENTF_MOVE = 0x1; //鼠标移动
        const int MOUSEEVENTF_LEFTDOWN = 0x2; //左键按下
        const int MOUSEEVENTF_WHEEL = 0x800; //鼠标滚动
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
