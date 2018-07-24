namespace Triton.Common.Math
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct Sphere
    {
        public Vector3 Center;
        public float Radius;
        public Sphere(Vector3 center, float radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        public override string ToString()
        {
            return string.Format("Center:{0} Radius:{1}", this.Center, this.Radius);
        }
    }
}

