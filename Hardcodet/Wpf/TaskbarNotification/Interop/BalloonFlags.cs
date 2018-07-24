namespace Hardcodet.Wpf.TaskbarNotification.Interop
{
    using System;

    public enum BalloonFlags
    {
        Error = 3,
        Info = 1,
        LargeIcon = 0x20,
        None = 0,
        NoSound = 0x10,
        RespectQuietTime = 0x80,
        User = 4,
        Warning = 2
    }
}

