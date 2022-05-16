using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.custom_form
{
    public static class WinMethods
    {

        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        public static void pressLeftMouse()
        {
            mouse_event((uint)MouseEventFlags.LEFTDOWN, 0, 0, 0, 0);
            mouse_event((uint)MouseEventFlags.LEFTUP, 0, 0, 0, 0);
        }
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int x, int y);
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }
        public static void SetCursorPosition(int x, int y)
        {
            SetCursorPos(x, y);
        }

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "BlockInput")]
        [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
        public static extern bool BlockInput([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool fBlockIt);

        public static void BlockMouse(TimeSpan span)
        {
            try
            {
                BlockInput(true);
                Thread.Sleep(span);
            }
            finally
            {
                BlockInput(false);
            }
        }

        public static Point GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);
            return lpPoint;
        }

        public static void OpenSkype(string phone)
        {
            System.Diagnostics.Process.Start("https://web.skype.com");
            BlockMouse(new TimeSpan(69999990));
            SetCursorPos(330, 147);
            pressLeftMouse();
            Thread.Sleep(300);
            for(int i=0;i<phone.Length;i++)
            {
                SendKeys.Send(phone[i].ToString());
                Thread.Sleep(10);
            }
        }
    }
}