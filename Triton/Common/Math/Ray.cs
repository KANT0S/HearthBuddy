namespace Triton.Common.Math
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct Ray
    {
        public Vector3 Position;
        public Vector3 Direction;
        public Ray(Vector3 position, Vector3 direction)
        {
            this.Position = position;
            this.Direction = direction;
        }

        public float? Intersects(Sphere sphere)
        {
            float num = sphere.Center.X - this.Position.X;
            float num2 = sphere.Center.Y - this.Position.Y;
            float num3 = sphere.Center.Z - this.Position.Z;
            float num4 = ((num * num) + (num2 * num2)) + (num3 * num3);
            float num5 = sphere.Radius * sphere.Radius;
            if (num4 <= num5)
            {
                return 0f;
            }
            float num6 = ((num * this.Direction.X) + (num2 * this.Direction.Y)) + (num3 * this.Direction.Z);
            if (num6 < 0f)
            {
                return null;
            }
            float num7 = num4 - (num6 * num6);
            if (num7 > num5)
            {
                return null;
            }
            float num8 = (float) Math.Sqrt((double) (num5 - num7));
            return new float?(num6 - num8);
        }
    }
}

