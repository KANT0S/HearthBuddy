namespace Triton.Game.Mapping
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct LayerMask
    {
        public int Mask;
    }
}

