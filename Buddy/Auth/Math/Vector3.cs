namespace Buddy.Auth.Math
{
    using System;
    using System.Globalization;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;

    [StructLayout(LayoutKind.Sequential, Pack=1), DataContract(Name="Vector3", Namespace="Buddy.Auth.Math")]
    public struct Vector3
    {
        [DataMember]
        public float X;
        [DataMember]
        public float Y;
        [DataMember]
        public float Z;
        public static readonly Vector3 Zero;
        public Vector3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "<{0}, {1}, {2}>", this.X, this.Y, this.Z);
        }

        public float MagnitudeSqr
        {
            get
            {
                return (((this.X * this.X) + (this.Y * this.Y)) + (this.Z * this.Z));
            }
        }
        public float Magnitude
        {
            get
            {
                return (float) Math.Sqrt((double) this.MagnitudeSqr);
            }
        }
        public void Normalize()
        {
            float magnitude = this.Magnitude;
            this.X /= magnitude;
            this.Y /= magnitude;
            this.Z /= magnitude;
        }

        public Vector2 ToVector2()
        {
            return new Vector2(this.X, this.Y);
        }

        public static float Distance(ref Vector3 v1, ref Vector3 v2)
        {
            float num = v1.Y - v2.Y;
            float num2 = v1.Z - v2.Z;
            float single1 = v1.X - v2.X;
            return (float) Math.Sqrt((double) (((single1 * single1) + (num * num)) + (num2 * num2)));
        }

        public float Distance(Vector3 to)
        {
            return Distance(ref this, ref to);
        }

        public float DistanceSqr(Vector3 to)
        {
            return DistanceSqr(ref this, ref to);
        }

        public static float Distance(Vector3 v1, Vector3 v2)
        {
            return Distance(ref v1, ref v2);
        }

        public static float DistanceSqr(ref Vector3 v1, ref Vector3 v2)
        {
            float num = v1.Y - v2.Y;
            float num2 = v1.Z - v2.Z;
            float single1 = v1.X - v2.X;
            return (((single1 * single1) + (num * num)) + (num2 * num2));
        }

        public static float DistanceSqr(Vector3 v1, Vector3 v2)
        {
            return DistanceSqr(ref v1, ref v2);
        }

        public static float Distance2D(ref Vector3 v1, ref Vector3 v2)
        {
            float num = v1.Y - v2.Y;
            float single1 = v1.X - v2.X;
            return (float) Math.Sqrt((double) ((single1 * single1) + (num * num)));
        }

        public static float Distance2DSqr(ref Vector3 v1, ref Vector3 v2)
        {
            float num = v1.Y - v2.Y;
            float single1 = v1.X - v2.X;
            return ((single1 * single1) + (num * num));
        }

        public float Distance2D(Vector3 to)
        {
            return Distance2D(ref this, ref to);
        }

        public float Distance2DSqr(Vector3 to)
        {
            return Distance2DSqr(ref this, ref to);
        }

        public static float Dot(ref Vector3 v1, ref Vector3 v2)
        {
            return (((v1.X * v2.X) + (v1.Y * v2.Y)) + (v1.Z * v2.Z));
        }

        public static float Dot(Vector3 v1, Vector3 v2)
        {
            return Dot(ref v1, ref v2);
        }

        public static void Cross(ref Vector3 v1, ref Vector3 v2, out Vector3 result)
        {
            result.X = (v1.Y * v2.Z) - (v1.Z * v2.Y);
            result.Y = (v1.Z * v2.X) - (v1.X * v2.Z);
            result.Z = (v1.X * v2.Y) - (v1.Y * v2.X);
        }

        public static Vector3 Cross(Vector3 v1, Vector3 v2)
        {
            Vector3 vector;
            Cross(ref v1, ref v2, out vector);
            return vector;
        }

        public static Vector3 NormalizedDirection(Vector3 start, Vector3 end)
        {
            Vector3 vector = end - start;
            vector.Normalize();
            return vector;
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

        public static Vector3 Hermite(Vector3 value1, Vector3 tangent1, Vector3 value2, Vector3 tangent2, float amount)
        {
            Vector3 vector;
            Hermite(ref value1, ref tangent1, ref value2, ref tangent2, amount, out vector);
            return vector;
        }

        public static Vector3 operator -(Vector3 v)
        {
            return new Vector3(-v.X, -v.Y, -v.Z);
        }

        public static Vector3 operator +(Vector3 left, Vector3 right)
        {
            return new Vector3(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        public static Vector3 operator -(Vector3 left, Vector3 right)
        {
            return new Vector3(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        public static Vector3 operator *(Vector3 left, float right)
        {
            left.X *= right;
            left.Y *= right;
            left.Z *= right;
            return left;
        }

        public static Vector3 operator *(float left, Vector3 right)
        {
            right.X *= left;
            right.Y *= left;
            right.Z *= left;
            return right;
        }

        public static Vector3 operator /(Vector3 left, float right)
        {
            left.X /= right;
            left.Y /= right;
            left.Z /= right;
            return left;
        }

        public bool Equals(Vector3 other)
        {
            return (((this.X == other.X) && (this.Y == other.Y)) && (this.Z == other.Z));
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != typeof(Vector3))
            {
                return false;
            }
            return this.Equals((Vector3) obj);
        }

        public override int GetHashCode()
        {
            return ((((this.X.GetHashCode() * 0x18d) ^ this.Y.GetHashCode()) * 0x18d) ^ this.Z.GetHashCode());
        }

        public static bool operator ==(Vector3 left, Vector3 right)
        {
            return (((left.X == right.X) && (left.Y == right.Y)) && (left.Z == right.Z));
        }

        public static bool operator !=(Vector3 left, Vector3 right)
        {
            if ((left.X == right.X) && (left.Y == right.Y))
            {
                return !(left.Z == right.Z);
            }
            return true;
        }

        static Vector3()
        {
            Zero = new Vector3(0f, 0f, 0f);
        }
    }
}

