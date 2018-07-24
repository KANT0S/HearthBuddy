namespace Triton.Game.Mapping
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct WorldDimensionIndex
    {
        public float Dimension;
        public int Index;
    }
}

