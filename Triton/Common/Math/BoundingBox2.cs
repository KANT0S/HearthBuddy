namespace Triton.Common.Math
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct BoundingBox2
    {
        public Vector2 Min;
        public Vector2 Max;
        public BoundingBox2(Vector2 min, Vector2 max)
        {
            this.Min = min;
            this.Max = max;
        }

        public bool Contains(Vector2 v)
        {
            return ((((v.X >= this.Min.X) && (v.X <= this.Max.X)) && (v.Y >= this.Min.Y)) && (v.Y <= this.Max.Y));
        }

        public static BoundingBox2 CreateFromPoints(IEnumerable<Vector2> points)
        {
            BoundingBox2 box = new BoundingBox2(new Vector2(float.MaxValue, float.MaxValue), new Vector2(float.MinValue, float.MinValue));
            bool flag = false;
            foreach (Vector2 vector in points)
            {
                flag = true;
                Vector2.Min(ref box.Min, ref vector, out box.Min);
                Vector2.Max(ref box.Max, ref vector, out box.Max);
            }
            if (!flag)
            {
                return new BoundingBox2();
            }
            return box;
        }
    }
}

