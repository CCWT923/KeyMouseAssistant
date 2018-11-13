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
    }
}
