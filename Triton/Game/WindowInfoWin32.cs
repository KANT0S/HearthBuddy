namespace Triton.Game
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct WindowInfoWin32
    {
        public uint Size;
        public RectWin32 Window;
        public RectWin32 Client;
        public uint Style;
        public uint ExStyle;
        public uint WindowStatus;
        public uint WindowBordersX;
        public uint WindowBordersY;
        public ushort WindowType;
        public ushort CreatorVersion;
    }
}

