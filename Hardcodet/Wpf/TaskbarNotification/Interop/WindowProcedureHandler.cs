namespace Hardcodet.Wpf.TaskbarNotification.Interop
{
    using System;
    using System.Runtime.CompilerServices;

    public delegate long WindowProcedureHandler(IntPtr hwnd, uint uMsg, uint wparam, uint lparam);
}

