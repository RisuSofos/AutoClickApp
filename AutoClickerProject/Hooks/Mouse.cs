using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoClickerProject.Hooks
{
    public class Mouse
    {
        [Flags]
        public enum MouseEvents
        {
            Move = 1,
            LeftDown = 2,
            LeftUp = 4,
            RightDown = 8,
            RightUp = 16,
            MiddleDown = 32,
            MiddleUp = 64,
            Absolute = 32768
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MousePoint
        {
            public int X;
            public int Y;

            public MousePoint(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        // set
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);
        public static void SetCursorPosition(int x, int y) => SetCursorPos(x, y);
        public static void SetCursorPosition(MousePoint point) => SetCursorPos(point.X, point.Y);

        // get
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out MousePoint point);
        public static MousePoint GetCursorPosition()
        {
            MousePoint currentMousePoint;
            var gotPoint = GetCursorPos(out currentMousePoint);
            if (!gotPoint) { currentMousePoint = new MousePoint(0, 0); }
            return currentMousePoint;
        }

        // event
        [DllImport("user32.dll")]
        private static extern bool mouse_event(int Flags, int x, int y, int data, int tag);
        public static void MouseEvent(MouseEvents value)
        {
            MousePoint position = GetCursorPosition();

            mouse_event
                (
                (int)value, position.X, position.Y, 0, 0);
        }

    }
}
