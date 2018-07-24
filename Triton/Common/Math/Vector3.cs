namespace Triton.Common.Math
{
    using System;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct Vector3 : IEquatable<Vector3>
    {
        public float X;
        public float Y;
        public float Z;
        [CompilerGenerated]
        private static Vector3 vector3_0;
        [CompilerGenerated]
        private static Vector3 vector3_1;
        static Vector3()
        {
            Zero = new Vector3(0f, 0f, 0f);
            One = new Vector3(1f, 1f, 1f);
        }

        public Vector3(Vector2 v, float z) : this(v.X, v.Y, z)
        {
        }

        public Vector3(float v) : this(v, v, v)
        {
        }

        public Vector3(Vector2i v, float z) : this((float) v.X, (float) v.Y, z)
        {
        }

        public Vector3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Vector2 ToVector2()
        {
            return new Vector2(this.X, this.Y);
        }

        public float Length()
        {
            return (float) Math.Sqrt((double) this.LengthSqr());
        }

        public float LengthSqr()
        {
            return (((this.X * this.X) + (this.Y * this.Y)) + (this.Z * this.Z));
        }

        public void Normalize()
        {
            float divisor = this.Length();
            Divide(ref this, divisor, out this);
        }

        public float Distance(Vector3 v)
        {
            return Distance(ref this, ref v);
        }

        public float Distance(ref Vector3 v)
        {
            return Distance(ref this, ref v);
        }

        public float DistanceSqr(Vector3 v)
        {
            return DistanceSqr(ref this, ref v);
        }

        public float DistanceSqr(ref Vector3 v)
        {
            return DistanceSqr(ref this, ref v);
        }

        public unsafe void CopyTo(float* arr)
        {
            arr[0] = this.X;
            arr[4] = this.Y;
            arr[2 * 4] = this.Z;
        }

        public bool Equals(Vector3 other)
        {
            return Equals(ref this, ref other);
        }

        public bool Equals(ref Vector3 other)
        {
            return Equals(ref this, ref other);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            try
            {
                return this.Equals((Vector3) obj);
            }
            catch (InvalidCastException)
            {
                return false;
            }
        }

        public static bool operator ==(Vector3 ls, Vector3 rs)
        {
            return Equals(ref ls, ref rs);
        }

        public static bool operator !=(Vector3 ls, Vector3 rs)
        {
            return Equals(ref ls, ref rs);
        }

        public static bool Equals(Vector3 v1, Vector3 v2)
        {
            return Equals(ref v1, ref v2);
        }

        public static bool Equals(ref Vector3 v1, ref Vector3 v2)
        {
            return (((v1.X == v2.X) && (v1.Y == v2.Y)) && (v1.Z == v2.Z));
        }

        public override int GetHashCode()
        {
            return ((((this.X.GetHashCode() * 0x18d) ^ this.Y.GetHashCode()) * 0x18d) ^ this.Z.GetHashCode());
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{{{0}, {1}, {2}}}", this.X, this.Y, this.Z);
        }

        public static Vector3 operator *(float left, Vector3 right)
        {
            right.X *= left;
            right.Y *= left;
            right.Z *= left;
            return right;
        }

        public static Vector3 operator +(Vector3 ls, Vector3 rs)
        {
            Vector3 vector;
            Add(ref ls, ref rs, out vector);
            return vector;
        }

        public static Vector3 operator -(Vector3 ls, Vector3 rs)
        {
            Vector3 vector;
            Subtract(ref ls, ref rs, out vector);
            return vector;
        }

        public static Vector3 operator *(Vector3 ls, Vector3 rs)
        {
            Vector3 vector;
            Multiply(ref ls, ref rs, out vector);
            return vector;
        }

        public static Vector3 operator *(Vector3 ls, float rs)
        {
            Vector3 vector;
            Multiply(ref ls, rs, out vector);
            return vector;
        }

        public static Vector3 operator /(Vector3 ls, Vector3 rs)
        {
            Vector3 vector;
            Multiply(ref ls, ref rs, out vector);
            return vector;
        }

        public static Vector3 operator /(Vector3 ls, float rs)
        {
            Vector3 vector;
            Divide(ref ls, rs, out vector);
            return vector;
        }

        public static void Add(ref Vector3 v1, ref Vector3 v2, out Vector3 result)
        {
            result.X = v1.X + v2.X;
            result.Y = v1.Y + v2.Y;
            result.Z = v1.Z + v2.Z;
        }

        public static void Subtract(ref Vector3 v1, ref Vector3 v2, out Vector3 result)
        {
            result.X = v1.X - v2.X;
            result.Y = v1.Y - v2.Y;
            result.Z = v1.Z - v2.Z;
        }

        public static void Multiply(ref Vector3 v1, ref Vector3 v2, out Vector3 result)
        {
            result.X = v1.X * v2.X;
            result.Y = v1.Y * v2.Y;
            result.Z = v1.Z * v2.Z;
        }

        public static void Multiply(ref Vector3 v1, float scalar, out Vector3 result)
        {
            result.X = v1.X * scalar;
            result.Y = v1.Y * scalar;
            result.Z = v1.Z * scalar;
        }

        public static void Divide(ref Vector3 v1, ref Vector3 v2, out Vector3 result)
        {
            result.X = v1.X / v2.X;
            result.Y = v1.Y / v2.Y;
            result.Z = v1.Z / v2.Z;
        }

        public static void Divide(ref Vector3 v1, float divisor, out Vector3 result)
        {
            result.X = v1.X / divisor;
            result.Y = v1.Y / divisor;
            result.Z = v1.Z / divisor;
        }

        public static void Negate(ref Vector3 v, out Vector3 result)
        {
            result.X = -v.X;
            result.Y = -v.Y;
            result.Z = -v.Z;
        }

        public static float Distance(Vector3 v1, Vector3 v2)
        {
            return (float) Math.Sqrt((double) DistanceSqr(ref v1, ref v2));
        }

        public static float Distance(ref Vector3 v1, ref Vector3 v2)
        {
            return (float) Math.Sqrt((double) DistanceSqr(ref v1, ref v2));
        }

        public static float DistanceSqr(Vector3 v1, Vector3 v2)
        {
            return DistanceSqr(ref v1, ref v2);
        }

        public static float DistanceSqr(ref Vector3 v1, ref Vector3 v2)
        {
            float num = v1.Y - v2.Y;
            float num2 = v1.Z - v2.Z;
            float single1 = v1.X - v2.X;
            return (((single1 * single1) + (num * num)) + (num2 * num2));
        }

        public float Distance2D(Vector3 to)
        {
            return Distance2D(ref this, ref to);
        }

        public float Distance2DSqr(Vector3 to)
        {
            return Distance2DSqr(ref this, ref to);
        }

        public static float Distance2D(ref Vector3 v1, ref Vector3 v2)
        {
            float num = v1.Z - v2.Z;
            float single1 = v1.X - v2.X;
            return (float) Math.Sqrt((double) ((single1 * single1) + (num * num)));
        }

        public static float Distance2DSqr(ref Vector3 v1, ref Vector3 v2)
        {
            float num = v1.Z - v2.Z;
            float single1 = v1.X - v2.X;
            return ((single1 * single1) + (num * num));
        }

        public static Vector3 GetDirection(Vector3 from, Vector3 to)
        {
            Vector3 vector;
            GetDirection(ref from, ref to, out vector);
            return vector;
        }

        public static void GetDirection(ref Vector3 from, ref Vector3 to, out Vector3 dir)
        {
            Subtract(ref to, ref from, out dir);
            dir.Normalize();
        }

        public static Vector3 NormalizedDirection(Vector3 start, Vector3 end)
        {
            Vector3 vector = end - start;
            vector.Normalize();
            return vector;
        }

        public static float Dot(Vector3 v1, Vector3 v2)
        {
            return (((v1.X * v2.X) + (v1.Y * v2.Y)) + (v1.Z * v2.Z));
        }

        public static Vector3 Cross(Vector3 v1, Vector3 v2)
        {
            Vector3 vector;
            Cross(ref v1, ref v2, out vector);
            return vector;
        }

        public static void Cross(ref Vector3 v1, ref Vector3 v2, out Vector3 crossProduct)
        {
            crossProduct.X = (v1.Y * v2.Z) - (v1.Z * v2.Y);
            crossProduct.Y = (v1.Z * v2.X) - (v1.X * v2.Z);
            crossProduct.Z = (v1.X * v2.Y) - (v1.Y * v2.X);
        }

        public static void Transform(ref Vector3 v, ref Matrix m, out Vector3 result)
        {
            float num = (((v.X * m.M11) + (v.Y * m.M21)) + (v.Z * m.M31)) + m.M41;
            float num2 = (((v.X * m.M12) + (v.Y * m.M22)) + (v.Z * m.M32)) + m.M42;
            float num3 = (((v.X * m.M13) + (v.Y * m.M23)) + (v.Z * m.M33)) + m.M43;
            result.X = num;
            result.Y = num2;
            result.Z = num3;
        }

        public static Vector3 Transform(Vector3 v, ref Matrix m)
        {
            Transform(ref v, ref m, out v);
            return v;
        }

        public static void Min(ref Vector3 v1, ref Vector3 v2, out Vector3 result)
        {
            result.X = Math.Min(v1.X, v2.X);
            result.Y = Math.Min(v1.Y, v2.Y);
            result.Z = Math.Min(v1.Z, v2.Z);
        }

        public static Vector3 Min(Vector3 v1, Vector3 v2)
        {
            Vector3 vector;
            Min(ref v1, ref v2, out vector);
            return vector;
        }

        public static void Max(ref Vector3 v1, ref Vector3 v2, out Vector3 result)
        {
            result.X = Math.Max(v1.X, v2.X);
            result.Y = Math.Max(v1.Y, v2.Y);
            result.Z = Math.Max(v1.Z, v2.Z);
        }

        public static Vector3 Max(Vector3 v1, Vector3 v2)
        {
            Vector3 vector;
            Max(ref v1, ref v2, out vector);
            return vector;
        }

        public static bool CalculateBarycentric(ref Vector3 p1, ref Vector3 p2, ref Vector3 p3, ref Vector3 point, out Vector3 barycentric)
        {
            float num = (((((p1.X * p2.Y) - (p1.X * p3.Y)) - (p2.X * p1.Y)) + (p2.X * p3.Y)) + (p3.X * p1.Y)) - (p3.X * p2.Y);
            if (num == 0f)
            {
                barycentric = Zero;
                return false;
            }
            float num2 = (((((point.X * p2.Y) - (point.X * p3.Y)) - (p2.X * point.Y)) + (p2.X * p3.Y)) + (p3.X * point.Y)) - (p3.X * p2.Y);
            barycentric.X = num2 / num;
            float num3 = (((((p1.X * point.Y) - (p1.X * p3.Y)) - (point.X * p1.Y)) + (point.X * p3.Y)) + (p3.X * p1.Y)) - (p3.X * point.Y);
            barycentric.Y = num3 / num;
            float num4 = (((((p1.X * p2.Y) - (p1.X * point.Y)) - (p2.X * p1.Y)) + (p2.X * point.Y)) + (point.X * p1.Y)) - (point.X * p2.Y);
            barycentric.Z = num4 / num;
            return true;
        }

        public static void CatmullRom(ref Vector3 beforeStart, ref Vector3 start, ref Vector3 end, ref Vector3 afterEnd, float amount, out Vector3 result)
        {
            Cardinal(ref beforeStart, ref start, ref end, ref afterEnd, 0.5f, 0.5f, amount, out result);
        }

        public static Vector3 CatmullRom(Vector3 beforeStart, Vector3 start, Vector3 end, Vector3 afterEnd, float amount)
        {
            Vector3 vector;
            Cardinal(ref beforeStart, ref start, ref end, ref afterEnd, 0.5f, 0.5f, amount, out vector);
            return vector;
        }

        public static void Cardinal(ref Vector3 beforeStart, ref Vector3 start, ref Vector3 end, ref Vector3 afterEnd, float aStart, float aEnd, float amount, out Vector3 result)
        {
            Vector3 vector = (Vector3) (aStart * (end - beforeStart));
            Vector3 vector2 = (Vector3) (aEnd * (afterEnd - start));
            Hermite(ref start, ref vector, ref end, ref vector2, amount, out result);
        }

        public static Vector3 Cardinal(Vector3 beforeStart, Vector3 start, Vector3 end, Vector3 afterEnd, float aStart, float aEnd, float amount)
        {
            Vector3 vector;
            Cardinal(ref beforeStart, ref start, ref end, ref afterEnd, aStart, aEnd, amount, out vector);
            return vector;
        }

        public static void Hermite(ref Vector3 value1, ref Vector3 tangent1, ref Vector3 value2, ref Vector3 tangent2, float amount, out Vector3 result)
        {
            float num = amount * amount;
            float num2 = num * amount;
            float num3 = ((2f * num2) - (3f * num)) + 1f;
            float num4 = (-2f * num2) + (3f * num);
            float num5 = (num2 - (2f * num)) + amount;
            float num6 = num2 - num;
            result = (Vector3) ((((value1 * num3) + (value2 * num4)) + (tangent1 * num5)) + (tangent2 * num6));
        }

        public static Vector3 CubiceHermiteCurve(Vector3 start, Vector3 end, Vector3 u, Vector3 v, float t)
        {
            if ((t > 1f) || (t < 0f))
            {
                throw new ArgumentOutOfRangeException("t", "t needs to be between 0.0f and 1.0f.");
            }
            float num = 1f - t;
            float num2 = t * t;
            float num3 = num * num;
            return (Vector3) (((((num3 * (1f + (2f * t))) * start) + ((num2 * (1f + (2f * num))) * end)) + ((num3 * t) * u)) - ((num2 * num) * v));
        }

        public static Vector3 Blend(Vector3 firstPoint, Vector3 secondPoint, float t)
        {
            if ((t > 1f) || (t < 0f))
            {
                throw new ArgumentOutOfRangeException("t", "t needs to be between 0.0f and 1.0f.");
            }
            float num = 1f - t;
            return (Vector3) ((firstPoint * num) + (secondPoint * t));
        }

        public static Vector3 Hermite(Vector3 value1, Vector3 tangent1, Vector3 value2, Vector3 tangent2, float amount)
        {
            Vector3 vector;
            Hermite(ref value1, ref tangent1, ref value2, ref tangent2, amount, out vector);
            return vector;
        }

        public static Vector3 Zero
        {
            [CompilerGenerated]
            get
            {
                return vector3_0;
            }
            [CompilerGenerated]
            private set
            {
                vector3_0 = value;
            }
        }
        public static Vector3 One
        {
            [CompilerGenerated]
            get
            {
                return vector3_1;
            }
            [CompilerGenerated]
            private set
            {
                vector3_1 = value;
            }
        }
    }
}

