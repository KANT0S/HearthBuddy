namespace Hardcodet.Wpf.TaskbarNotification.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct NotifyIconData
    {
        public uint cbSize;
        public IntPtr WindowHandle;
        public uint TaskbarIconId;
        public IconDataMembers ValidMembers;
        public uint CallbackMessageId;
        public IntPtr IconHandle;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x80)]
        public string ToolTipText;
        public Hardcodet.Wpf.TaskbarNotification.Interop.IconState IconState;
        public Hardcodet.Wpf.TaskbarNotification.Interop.IconState StateMask;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x100)]
        public string BalloonText;
        public uint VersionOrTimeout;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x40)]
        public string BalloonTitle;
        public Hardcodet.Wpf.TaskbarNotification.Interop.BalloonFlags BalloonFlags;
        public Guid TaskbarIconGuid;
        public IntPtr CustomBalloonIconHandle;
        public static NotifyIconData CreateDefault(IntPtr handle)
        {
            NotifyIconData structure = new NotifyIconData();
            if (Environment.OSVersion.Version.Major >= 6)
            {
                structure.cbSize = (uint) Marshal.SizeOf<NotifyIconData>(structure);
            }
            else
            {
                structure.cbSize = 0x1f8;
                structure.VersionOrTimeout = 10;
            }
            structure.WindowHandle = handle;
            structure.TaskbarIconId = 0;
            structure.CallbackMessageId = 0x400;
            structure.VersionOrTimeout = 0;
            structure.IconHandle = IntPtr.Zero;
            structure.IconState = Hardcodet.Wpf.TaskbarNotification.Interop.IconState.Hidden;
            structure.StateMask = Hardcodet.Wpf.TaskbarNotification.Interop.IconState.Hidden;
            structure.ValidMembers = IconDataMembers.Tip | IconDataMembers.Icon | IconDataMembers.Message;
            structure.ToolTipText = structure.BalloonText = structure.BalloonTitle = string.Empty;
            return structure;
        }
    }
}

