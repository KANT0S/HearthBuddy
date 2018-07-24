namespace Triton.Common
{
    using System;

    [Flags]
    public enum ModifierKeys
    {
        Alt = 1,
        Control = 2,
        NoRepeat = 0x4000,
        Shift = 4,
        Win = 8
    }
}

