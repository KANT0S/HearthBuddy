namespace Triton.Game.Mapping
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct Rect
    {
        public float m_XMin;
        public float m_YMin;
        public float m_Width;
        public float m_Height;
    }
}

