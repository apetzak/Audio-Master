using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

class InterceptKeys
{
    //private const int WH_KEYBOARD_LL = 13;
    //private const int WM_KEYDOWN = 0x0100;
    //private LowLevelKeyboardProc _proc = HookCallback;
    //private static IntPtr _hookID = IntPtr.Zero;

    //public InterceptKeys()
    //{
    //    _hookID = SetHook(_proc);
    //    //Application.Run();
    //    UnhookWindowsHookEx(_hookID);
    //}

    //public IntPtr SetHook(LowLevelKeyboardProc proc)
    //{
    //    using (Process curProcess = Process.GetCurrentProcess())
    //    using (ProcessModule curModule = curProcess.MainModule)
    //    {
    //        return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
    //            GetModuleHandle(curModule.ModuleName), 0);
    //    }
    //}

    //public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

    //public static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
    //{
    //    if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
    //    {
    //        int vkCode = Marshal.ReadInt32(lParam);
    //        Console.WriteLine((Keys)vkCode);
    //    }

    //    return CallNextHookEx(_hookID, nCode, wParam, lParam);
    //}

    //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    //public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

    //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    //[return: MarshalAs(UnmanagedType.Bool)]
    //public static extern bool UnhookWindowsHookEx(IntPtr hhk);

    //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    //public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    //[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    //public static extern IntPtr GetModuleHandle(string lpModuleName);
}