using Microsoft.Win32;
using System;
using System.Diagnostics;

namespace AccelerateBall.Util
{
    class StartupSetting
    {
        public static void autoRun()
        {
            RegistryKey runItem = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            try
            {
                if (runItem != null)
                {
                    runItem.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName, Process.GetCurrentProcess().MainModule.FileName);
                }
            }
            catch (Exception) { }
        }

        public static void deleteAutoRun()
        {
            RegistryKey runItem = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            try
            {
                if (runItem != null)
                {
                    //runItem.DeleteSubKey("AccelerateBall");
                    runItem.DeleteValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
                }
            }
            catch (Exception) { }
        }
    }
}
