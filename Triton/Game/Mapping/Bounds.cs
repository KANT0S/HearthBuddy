namespace Triton.Game.Mapping
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct Bounds
    {
        public Vector3 m_Center;
        public Vector3 m_Extents;
    }
}

