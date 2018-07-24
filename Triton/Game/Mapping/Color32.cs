namespace Triton.Game.Mapping
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct Color32
    {
        public byte r;
        public byte g;
        public byte b;
        public byte a;
    }
}

