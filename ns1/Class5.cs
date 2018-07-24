namespace ns1
{
    using Hardcodet.Wpf.TaskbarNotification.Interop;
    using System;
    using System.Runtime.InteropServices;

    internal static class Class5
    {
        [DllImport("USER32.DLL", SetLastError=true)]
        public static extern IntPtr CreateWindowExW(int int_0, [MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.LPWStr)] string string_1, int int_1, int int_2, int int_3, int int_4, int int_5, uint uint_0, int int_6, int int_7, int int_8);
        [DllImport("USER32.DLL")]
        public static extern long DefWindowProc(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2);
        [DllImport("USER32.DLL", SetLastError=true)]
        public static extern bool DestroyWindow(IntPtr intptr_0);
        [DllImport("USER32.DLL", SetLastError=true)]
        public static extern bool GetCursorPos(ref Point point_0);
        [DllImport("user32.dll", CharSet=CharSet.Auto, ExactSpelling=true)]
        public static extern int GetDoubleClickTime();
        [DllImport("USER32.DLL", SetLastError=true)]
        public static extern short RegisterClassW(ref WindowClass windowClass_0);
        [DllImport("User32.Dll")]
        public static extern uint RegisterWindowMessageW([MarshalAs(UnmanagedType.LPWStr)] string string_0);
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr intptr_0);
        [DllImport("shell32.Dll")]
        public static extern bool Shell_NotifyIcon(NotifyCommand notifyCommand_0, [In] ref NotifyIconData notifyIconData_0);
    }
}

