namespace Triton.Common.Math
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct LineSegment
    {
        public Vector3 Start;
        public Vector3 End;
        public LineSegment(Vector3 start, Vector3 end)
        {
            this.Start = start;
            this.End = end;
        }

        public float DistanceSqr
        {
            get
            {
                return Vector3.DistanceSqr(ref this.Start, ref this.End);
            }
        }
        public float Distance
        {
            get
            {
                return Vector3.Distance(ref this.Start, ref this.End);
            }
        }
        public Vector3 Direction
        {
            get
            {
                return (this.End - this.Start);
            }
        }
        public Vector3 UnitDirection
        {
            get
            {
                Vector3 vector = this.End - this.Start;
                vector.Normalize();
                return vector;
            }
        }
        public float ClosestT(Vector3 point)
        {
            return MathEx.Clamp(0f, 1f, Vector3.Dot(point - this.Start, this.Direction) / this.DistanceSqr);
        }

        public Vector3 ClosestPoint(Vector3 point)
        {
            return (this.Start + ((Vector3) (this.ClosestT(point) * this.Direction)));
        }
    }
}

