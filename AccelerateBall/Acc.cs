using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AccelerateBall
{
    class Acc
    {
        [DllImport("kernel32.dll")]
        private static extern int SetProcessWorkingSetSize(IntPtr hProcess, int dwMinimumWorkingSetSize, int dwMaximumWorkingSetSize);

        [DllImport("psapi.dll")]
        static extern int EmptyWorkingSet(IntPtr hwProc);
        public void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                //以下系统进程没有权限，所以跳过，防止出错影响效率。  
                if ((process.ProcessName == "System") && (process.ProcessName == "Idle"))
                    continue;
                try
                {
                    if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                    {
                        SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
                    }
                    EmptyWorkingSet(process.Handle);
                }
                catch
                {
                }
            }
        }
    }
}
