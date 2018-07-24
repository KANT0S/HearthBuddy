namespace Hardcodet.Wpf.TaskbarNotification.Interop
{
    using System;

    [Flags]
    public enum IconDataMembers
    {
        Icon = 2,
        Info = 0x10,
        Message = 1,
        Realtime = 0x40,
        State = 8,
        Tip = 4,
        UseLegacyToolTips = 0x80
    }
}

