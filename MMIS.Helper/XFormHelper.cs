using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace MMIS.Helper
{
    public class XFormHelper
    {
        [DllImport("User32.DLL")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        [DllImport("User32.DLL")]
        public static extern bool ReleaseCapture();
        public const uint WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 61456;
        public const int HTCAPTION = 2;

        public static void MoveWindow(IntPtr handle)
        {
            ReleaseCapture();
            SendMessage(handle, WM_SYSCOMMAND, SC_MOVE | HTCAPTION, 0);
        }
    }
}
