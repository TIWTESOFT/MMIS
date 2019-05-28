using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace MMIS.Helper
{
    public partial class XMemoryTool
    {
        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);

        /// <summary> 
        /// 释放内存 
        /// </summary> 
        public static void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }

        private void tmClearMemory_Tick(object sender, EventArgs e)
        {
            ClearMemory();
        }
    }
}
