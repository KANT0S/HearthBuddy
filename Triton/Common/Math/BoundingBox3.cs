namespace Triton.Common.Math
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct BoundingBox3
    {
        public Vector3 Min;
        public Vector3 Max;
        public BoundingBox3(Vector3 min, Vector3 max)
        {
            this.Min = min;
            this.Max = max;
        }

        public bool Contains(Vector3 v)
        {
            return (((((v.X >= this.Min.X) && (v.X <= this.Max.X)) && ((v.Y >= this.Min.Y) && (v.Y <= this.Max.Y))) && (v.Z >= this.Min.Z)) && (v.Z <= this.Max.Z));
        }

        public ContainmentType Contains(BoundingBox3 box)
        {
            return Contains(ref this, ref box);
        }

        public static ContainmentType Contains(ref BoundingBox3 box1, ref BoundingBox3 box2)
        {
            if ((box1.Max.X < box2.Min.X) || (box1.Min.X > box2.Max.X))
            {
                return ContainmentType.Disjoint;
            }
            if ((box1.Max.Y < box2.Min.Y) || (box1.Min.Y > box2.Max.Y))
            {
                return ContainmentType.Disjoint;
            }
            if ((box1.Max.Z < box2.Min.Z) || (box1.Min.Z > box2.Max.Z))
            {
                return ContainmentType.Disjoint;
            }
            if ((((box1.Min.X <= box2.Min.X) && (box2.Max.X <= box1.Max.X)) && ((box1.Min.Y <= box2.Min.Y) && (box2.Max.Y <= box1.Max.Y))) && ((box1.Min.Z <= box2.Min.Z) && (box2.Max.Z <= box1.Max.Z)))
            {
                return ContainmentType.Contains;
            }
            return ContainmentType.Intersects;
        }

        public static BoundingBox3 CreateFromPoints(IEnumerable<Vector3> points)
        {
            BoundingBox3 box = new BoundingBox3(new Vector3(float.MaxValue, float.MaxValue, float.MaxValue), new Vector3(float.MinValue, float.MinValue, float.MinValue));
            bool flag = false;
            foreach (Vector3 vector in points)
            {
                flag = true;
                Vector3.Min(ref box.Min, ref vector, out box.Min);
                Vector3.Max(ref box.Max, ref vector, out box.Max);
            }
            if (!flag)
            {
                return new BoundingBox3();
            }
            return box;
        }
    }
}

