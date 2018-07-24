namespace Triton.Common.Math
{
    using System;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct Vector2i : IEquatable<Vector2i>
    {
        public int X;
        public int Y;
        [CompilerGenerated]
        private static Vector2i vector2i_0;
        [CompilerGenerated]
        private static Vector2i vector2i_1;
        static Vector2i()
        {
            Zero = new Vector2i(0, 0);
            One = new Vector2i(1, 1);
        }

        public Vector2i(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int Length()
        {
            return (int) Math.Sqrt((double) this.LengthSqr());
        }

        public int LengthSqr()
        {
            return ((this.X * this.X) + (this.Y * this.Y));
        }

        public void Normalize()
        {
            int divisor = this.Length();
            Divide(ref this, divisor, out this);
        }

        public int Distance(Vector2i v)
        {
            return Distance(ref this, ref v);
        }

        public float DistanceF(Vector2i v)
        {
            return DistanceF(ref this, ref v);
        }

        public int Distance(ref Vector2i v)
        {
            return Distance(ref this, ref v);
        }

        public int DistanceSqr(Vector2i v)
        {
            return DistanceSqr(ref this, ref v);
        }

        public int DistanceSqr(ref Vector2i v)
        {
            return DistanceSqr(ref this, ref v);
        }

        public Vector3 ToVector3()
        {
            return new Vector3((float) this.X, (float) this.Y, 0f);
        }

        public Vector2 ToVector2()
        {
            return new Vector2((float) this.X, (float) this.Y);
        }

        public bool Equals(Vector2i other)
        {
            return Equals(ref this, ref other);
        }

        public bool Equals(ref Vector2i other)
        {
            return Equals(ref this, ref other);
        }

        public static bool Equals(ref Vector2i v1, ref Vector2i v2)
        {
            return ((v1.X == v2.X) && (v1.Y == v2.Y));
        }

        public static bool operator ==(Vector2i ls, Vector2i rs)
        {
            return Equals(ref ls, ref rs);
        }

        public static bool operator !=(Vector2i ls, Vector2i rs)
        {
            return !Equals(ref ls, ref rs);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            try
            {
                return this.Equals((Vector2i) obj);
            }
            catch (InvalidCastException)
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return ((this.X.GetHashCode() * 0x18d) ^ this.Y.GetHashCode());
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{{{0}, {1}}}", this.X, this.Y);
        }

        public static Vector2i operator +(Vector2i ls, Vector2i rs)
        {
            Vector2i vectori;
            Add(ref ls, ref rs, out vectori);
            return vectori;
        }

        public static Vector2i operator -(Vector2i ls, Vector2i rs)
        {
            Vector2i vectori;
            Subtract(ref ls, ref rs, out vectori);
            return vectori;
        }

        public static Vector2i operator -(Vector2i v)
        {
            v.X = -v.X;
            v.Y = -v.Y;
            return v;
        }

        public static Vector2i operator *(Vector2i ls, Vector2i rs)
        {
            Vector2i vectori;
            Multiply(ref ls, ref rs, out vectori);
            return vectori;
        }

        public static Vector2i operator *(Vector2i ls, int rs)
        {
            Vector2i vectori;
            Multiply(ref ls, rs, out vectori);
            return vectori;
        }

        public static Vector2i operator *(Vector2i ls, float rs)
        {
            return new Vector2i((int) (ls.X * rs), (int) (ls.Y * rs));
        }

        public static Vector2i operator /(Vector2i ls, Vector2i rs)
        {
            Vector2i vectori;
            Multiply(ref ls, ref rs, out vectori);
            return vectori;
        }

        public static Vector2i operator /(Vector2i ls, int rs)
        {
            Vector2i vectori;
            Divide(ref ls, rs, out vectori);
            return vectori;
        }

        public static void Add(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
        {
            result.X = v1.X + v2.X;
            result.Y = v1.Y + v2.Y;
        }

        public static void Subtract(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
        {
            result.X = v1.X - v2.X;
            result.Y = v1.Y - v2.Y;
        }

        public static void Multiply(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
        {
            result.X = v1.X * v2.X;
            result.Y = v1.Y * v2.Y;
        }

        public static void Multiply(ref Vector2i v1, int scalar, out Vector2i result)
        {
            result.X = v1.X * scalar;
            result.Y = v1.Y * scalar;
        }

        public static void Divide(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
        {
            result.X = v1.X / v2.X;
            result.Y = v1.Y / v2.Y;
        }

        public static void Divide(ref Vector2i v1, int divisor, out Vector2i result)
        {
            int scalar = 1 / divisor;
            Multiply(ref v1, scalar, out result);
        }

        public static int Distance(ref Vector2i v1, ref Vector2i v2)
        {
            return (int) Math.Sqrt((double) DistanceSqr(ref v1, ref v2));
        }

        public static float DistanceF(ref Vector2i v1, ref Vector2i v2)
        {
            return (float) Math.Sqrt((double) DistanceSqr(ref v1, ref v2));
        }

        public static int DistanceSqr(ref Vector2i v1, ref Vector2i v2)
        {
            int num = v1.Y - v2.Y;
            int num1 = v1.X - v2.X;
            return ((num1 * num1) + (num * num));
        }

        public static void GetDirection(ref Vector2i from, ref Vector2i to, out Vector2i dir)
        {
            Subtract(ref to, ref from, out dir);
            dir.Normalize();
        }

        public static Vector2i Min(Vector2i v1, Vector2i v2)
        {
            Vector2i vectori;
            Min(ref v1, ref v2, out vectori);
            return vectori;
        }

        public static void Min(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
        {
            result.X = Math.Min(v1.X, v2.X);
            result.Y = Math.Min(v1.Y, v2.Y);
        }

        public static Vector2i Max(Vector2i v1, Vector2i v2)
        {
            Vector2i vectori;
            Max(ref v1, ref v2, out vectori);
            return vectori;
        }

        public static void Max(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
        {
            result.X = Math.Max(v1.X, v2.X);
            result.Y = Math.Max(v1.Y, v2.Y);
        }

        public static Vector2i Zero
        {
            [CompilerGenerated]
            get
            {
                return vector2i_0;
            }
            [CompilerGenerated]
            private set
            {
                vector2i_0 = value;
            }
        }
        public static Vector2i One
        {
            [CompilerGenerated]
            get
            {
                return vector2i_1;
            }
            [CompilerGenerated]
            private set
            {
                vector2i_1 = value;
            }
        }
        public static int Dot(Vector2i v1, Vector2i v2)
        {
            return ((v1.X * v2.X) + (v1.Y * v2.Y));
        }
    }
}

