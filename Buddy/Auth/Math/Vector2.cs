namespace Buddy.Auth.Math
{
    using System;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct Vector2 : IEquatable<Vector2>
    {
        public float X;
        public float Y;
        [CompilerGenerated]
        private static Vector2 vector2_0;
        [CompilerGenerated]
        private static Vector2 vector2_1;
        static Vector2()
        {
            Zero = new Vector2(0f, 0f);
            One = new Vector2(1f, 1f);
        }

        public Vector2(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public float Length()
        {
            return (float) Math.Sqrt((double) this.LengthSqr());
        }

        public float LengthSqr()
        {
            return ((this.X * this.X) + (this.Y * this.Y));
        }

        public void Normalize()
        {
            float divisor = this.Length();
            Divide(ref this, divisor, out this);
        }

        public float Distance(Vector2 v)
        {
            return Distance(ref this, ref v);
        }

        public float Distance(ref Vector2 v)
        {
            return Distance(ref this, ref v);
        }

        public float DistanceSqr(Vector2 v)
        {
            return DistanceSqr(ref this, ref v);
        }

        public float DistanceSqr(ref Vector2 v)
        {
            return DistanceSqr(ref this, ref v);
        }

        public Vector3 ToVector3()
        {
            return new Vector3(this.X, this.Y, 0f);
        }

        public bool Equals(Vector2 other)
        {
            return Equals(ref this, ref other);
        }

        public bool Equals(ref Vector2 other)
        {
            return Equals(ref this, ref other);
        }

        public static bool Equals(ref Vector2 v1, ref Vector2 v2)
        {
            return ((v1.X == v2.X) && (v1.Y == v2.Y));
        }

        public static bool operator ==(Vector2 ls, Vector2 rs)
        {
            return Equals(ref ls, ref rs);
        }

        public static bool operator !=(Vector2 ls, Vector2 rs)
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
                return this.Equals((Vector2) obj);
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

        public static Vector2 operator +(Vector2 ls, Vector2 rs)
        {
            Vector2 vector;
            Add(ref ls, ref rs, out vector);
            return vector;
        }

        public static Vector2 operator -(Vector2 ls, Vector2 rs)
        {
            Vector2 vector;
            Subtract(ref ls, ref rs, out vector);
            return vector;
        }

        public static Vector2 operator -(Vector2 v)
        {
            v.X = -v.X;
            v.Y = -v.Y;
            return v;
        }

        public static Vector2 operator *(Vector2 ls, Vector2 rs)
        {
            Vector2 vector;
            Multiply(ref ls, ref rs, out vector);
            return vector;
        }

        public static Vector2 operator *(Vector2 ls, float rs)
        {
            Vector2 vector;
            Multiply(ref ls, rs, out vector);
            return vector;
        }

        public static Vector2 operator /(Vector2 ls, Vector2 rs)
        {
            Vector2 vector;
            Multiply(ref ls, ref rs, out vector);
            return vector;
        }

        public static Vector2 operator /(Vector2 ls, float rs)
        {
            Vector2 vector;
            Divide(ref ls, rs, out vector);
            return vector;
        }

        public static void Add(ref Vector2 v1, ref Vector2 v2, out Vector2 result)
        {
            result.X = v1.X + v2.X;
            result.Y = v1.Y + v2.Y;
        }

        public static void Subtract(ref Vector2 v1, ref Vector2 v2, out Vector2 result)
        {
            result.X = v1.X - v2.X;
            result.Y = v1.Y - v2.Y;
        }

        public static void Multiply(ref Vector2 v1, ref Vector2 v2, out Vector2 result)
        {
            result.X = v1.X * v2.X;
            result.Y = v1.Y * v2.Y;
        }

        public static void Multiply(ref Vector2 v1, float scalar, out Vector2 result)
        {
            result.X = v1.X * scalar;
            result.Y = v1.Y * scalar;
        }

        public static void Divide(ref Vector2 v1, ref Vector2 v2, out Vector2 result)
        {
            result.X = v1.X / v2.X;
            result.Y = v1.Y / v2.Y;
        }

        public static void Divide(ref Vector2 v1, float divisor, out Vector2 result)
        {
            float scalar = 1f / divisor;
            Multiply(ref v1, scalar, out result);
        }

        public static float Distance(ref Vector2 v1, ref Vector2 v2)
        {
            return (float) Math.Sqrt((double) DistanceSqr(ref v1, ref v2));
        }

        public static float DistanceSqr(ref Vector2 v1, ref Vector2 v2)
        {
            float num = v1.Y - v2.Y;
            float single1 = v1.X - v2.X;
            return ((single1 * single1) + (num * num));
        }

        public static void GetDirection(ref Vector2 from, ref Vector2 to, out Vector2 dir)
        {
            Subtract(ref to, ref from, out dir);
            dir.Normalize();
        }

        public static Vector2 Min(Vector2 v1, Vector2 v2)
        {
            Vector2 vector;
            Min(ref v1, ref v2, out vector);
            return vector;
        }

        public static void Min(ref Vector2 v1, ref Vector2 v2, out Vector2 result)
        {
            result.X = Math.Min(v1.X, v2.X);
            result.Y = Math.Min(v1.Y, v2.Y);
        }

        public static Vector2 Max(Vector2 v1, Vector2 v2)
        {
            Vector2 vector;
            Max(ref v1, ref v2, out vector);
            return vector;
        }

        public static void Max(ref Vector2 v1, ref Vector2 v2, out Vector2 result)
        {
            result.X = Math.Max(v1.X, v2.X);
            result.Y = Math.Max(v1.Y, v2.Y);
        }

        public static Vector2 Zero
        {
            [CompilerGenerated]
            get
            {
                return vector2_0;
            }
            [CompilerGenerated]
            private set
            {
                vector2_0 = value;
            }
        }
        public static Vector2 One
        {
            [CompilerGenerated]
            get
            {
                return vector2_1;
            }
            [CompilerGenerated]
            private set
            {
                vector2_1 = value;
            }
        }
        public static float Dot(Vector2 v1, Vector2 v2)
        {
            return ((v1.X * v2.X) + (v1.Y * v2.Y));
        }
    }
}

