namespace Triton.Game.Mapping
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct Plane
    {
        public Vector3 m_Normal;
        public float m_Distance;
    }
}

