namespace Triton.Common.Math
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Runtime.InteropServices;

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct BoundingBox : IEquatable<BoundingBox>
    {
        public const int CornerCount = 8;
        public Vector3 Min;
        public Vector3 Max;
        public Vector3[] GetCorners()
        {
            return new Vector3[] { new Vector3(this.Min.X, this.Max.Y, this.Max.Z), new Vector3(this.Max.X, this.Max.Y, this.Max.Z), new Vector3(this.Max.X, this.Min.Y, this.Max.Z), new Vector3(this.Min.X, this.Min.Y, this.Max.Z), new Vector3(this.Min.X, this.Max.Y, this.Min.Z), new Vector3(this.Max.X, this.Max.Y, this.Min.Z), new Vector3(this.Max.X, this.Min.Y, this.Min.Z), new Vector3(this.Min.X, this.Min.Y, this.Min.Z) };
        }

        public void GetCorners(Vector3[] corners)
        {
            if (corners == null)
            {
                throw new ArgumentNullException("corners");
            }
            if (corners.Length < 8)
            {
                throw new ArgumentOutOfRangeException("corners");
            }
            corners[0].X = this.Min.X;
            corners[0].Y = this.Max.Y;
            corners[0].Z = this.Max.Z;
            corners[1].X = this.Max.X;
            corners[1].Y = this.Max.Y;
            corners[1].Z = this.Max.Z;
            corners[2].X = this.Max.X;
            corners[2].Y = this.Min.Y;
            corners[2].Z = this.Max.Z;
            corners[3].X = this.Min.X;
            corners[3].Y = this.Min.Y;
            corners[3].Z = this.Max.Z;
            corners[4].X = this.Min.X;
            corners[4].Y = this.Max.Y;
            corners[4].Z = this.Min.Z;
            corners[5].X = this.Max.X;
            corners[5].Y = this.Max.Y;
            corners[5].Z = this.Min.Z;
            corners[6].X = this.Max.X;
            corners[6].Y = this.Min.Y;
            corners[6].Z = this.Min.Z;
            corners[7].X = this.Min.X;
            corners[7].Y = this.Min.Y;
            corners[7].Z = this.Min.Z;
        }

        public BoundingBox(Vector3 min, Vector3 max)
        {
            this.Min = min;
            this.Max = max;
        }

        public bool Equals(BoundingBox other)
        {
            return ((this.Min == other.Min) && (this.Max == other.Max));
        }

        public override bool Equals(object obj)
        {
            bool flag = false;
            if (obj is BoundingBox)
            {
                flag = this.Equals((BoundingBox) obj);
            }
            return flag;
        }

        public override int GetHashCode()
        {
            return (this.Min.GetHashCode() + this.Max.GetHashCode());
        }

        public override string ToString()
        {
            object[] args = new object[] { this.Min.ToString(), this.Max.ToString() };
            return string.Format(CultureInfo.CurrentCulture, "{{Min:{0} Max:{1}}}", args);
        }

        public static BoundingBox CreateMerged(BoundingBox original, BoundingBox additional)
        {
            BoundingBox box;
            Vector3.Min(ref original.Min, ref additional.Min, out box.Min);
            Vector3.Max(ref original.Max, ref additional.Max, out box.Max);
            return box;
        }

        public static void CreateMerged(ref BoundingBox original, ref BoundingBox additional, out BoundingBox result)
        {
            Vector3 vector;
            Vector3 vector2;
            Vector3.Min(ref original.Min, ref additional.Min, out vector2);
            Vector3.Max(ref original.Max, ref additional.Max, out vector);
            result.Min = vector2;
            result.Max = vector;
        }

        public static BoundingBox CreateFromPoints(IEnumerable<Vector3> points)
        {
            if (points == null)
            {
                throw new ArgumentNullException();
            }
            bool flag = false;
            Vector3 vector = new Vector3(float.MaxValue);
            Vector3 vector2 = new Vector3(float.MinValue);
            foreach (Vector3 vector3 in points)
            {
                Vector3.Min(ref vector, ref vector3, out vector);
                Vector3.Max(ref vector2, ref vector3, out vector2);
                flag = true;
            }
            if (!flag)
            {
                throw new ArgumentException();
            }
            return new BoundingBox(vector, vector2);
        }

        public bool Intersects(BoundingBox box)
        {
            if ((this.Max.X < box.Min.X) || (this.Min.X > box.Max.X))
            {
                return false;
            }
            if ((this.Max.Y < box.Min.Y) || (this.Min.Y > box.Max.Y))
            {
                return false;
            }
            return ((this.Max.Z >= box.Min.Z) && (this.Min.Z <= box.Max.Z));
        }

        public void Intersects(ref BoundingBox box, out bool result)
        {
            result = false;
            if ((((this.Max.X >= box.Min.X) && (this.Min.X <= box.Max.X)) && ((this.Max.Y >= box.Min.Y) && (this.Min.Y <= box.Max.Y))) && ((this.Max.Z >= box.Min.Z) && (this.Min.Z <= box.Max.Z)))
            {
                result = true;
            }
        }

        public ContainmentType Contains(BoundingBox box)
        {
            if ((this.Max.X < box.Min.X) || (this.Min.X > box.Max.X))
            {
                return ContainmentType.Disjoint;
            }
            if ((this.Max.Y < box.Min.Y) || (this.Min.Y > box.Max.Y))
            {
                return ContainmentType.Disjoint;
            }
            if ((this.Max.Z < box.Min.Z) || (this.Min.Z > box.Max.Z))
            {
                return ContainmentType.Disjoint;
            }
            if ((((this.Min.X <= box.Min.X) && (box.Max.X <= this.Max.X)) && ((this.Min.Y <= box.Min.Y) && (box.Max.Y <= this.Max.Y))) && ((this.Min.Z <= box.Min.Z) && (box.Max.Z <= this.Max.Z)))
            {
                return ContainmentType.Contains;
            }
            return ContainmentType.Intersects;
        }

        public void Contains(ref BoundingBox box, out ContainmentType result)
        {
            result = ContainmentType.Disjoint;
            if ((((this.Max.X >= box.Min.X) && (this.Min.X <= box.Max.X)) && ((this.Max.Y >= box.Min.Y) && (this.Min.Y <= box.Max.Y))) && ((this.Max.Z >= box.Min.Z) && (this.Min.Z <= box.Max.Z)))
            {
                result = ((((this.Min.X > box.Min.X) || (box.Max.X > this.Max.X)) || ((this.Min.Y > box.Min.Y) || (box.Max.Y > this.Max.Y))) || ((this.Min.Z > box.Min.Z) || (box.Max.Z > this.Max.Z))) ? ContainmentType.Intersects : ContainmentType.Contains;
            }
        }

        public ContainmentType Contains(Vector3 point)
        {
            if ((((this.Min.X <= point.X) && (point.X <= this.Max.X)) && ((this.Min.Y <= point.Y) && (point.Y <= this.Max.Y))) && ((this.Min.Z <= point.Z) && (point.Z <= this.Max.Z)))
            {
                return ContainmentType.Contains;
            }
            return ContainmentType.Disjoint;
        }

        public void Contains(ref Vector3 point, out ContainmentType result)
        {
            result = ((((this.Min.X > point.X) || (point.X > this.Max.X)) || ((this.Min.Y > point.Y) || (point.Y > this.Max.Y))) || ((this.Min.Z > point.Z) || (point.Z > this.Max.Z))) ? ContainmentType.Disjoint : ContainmentType.Contains;
        }

        internal void method_0(ref Vector3 vector3_0, out Vector3 vector3_1)
        {
            vector3_1.X = (vector3_0.X >= 0f) ? this.Max.X : this.Min.X;
            vector3_1.Y = (vector3_0.Y >= 0f) ? this.Max.Y : this.Min.Y;
            vector3_1.Z = (vector3_0.Z >= 0f) ? this.Max.Z : this.Min.Z;
        }

        public static bool operator ==(BoundingBox a, BoundingBox b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(BoundingBox a, BoundingBox b)
        {
            if (!(a.Min != b.Min))
            {
                return (a.Max != b.Max);
            }
            return true;
        }
    }
}

