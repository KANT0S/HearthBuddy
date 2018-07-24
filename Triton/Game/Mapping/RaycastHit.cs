namespace Triton.Game.Mapping
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct RaycastHit
    {
        public Vector3 Point;
        public Vector3 Normal;
        public int FaceID;
        public float Distance;
        public Vector2 UV;
        public IntPtr Collider;
    }
}

