namespace Triton.Common.Math
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct Matrix
    {
        public float M11;
        public float M12;
        public float M13;
        public float M14;
        public float M21;
        public float M22;
        public float M23;
        public float M24;
        public float M31;
        public float M32;
        public float M33;
        public float M34;
        public float M41;
        public float M42;
        public float M43;
        public float M44;
        [CompilerGenerated]
        private static Matrix matrix_0;
        public Matrix(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
        {
            this.M11 = m11;
            this.M12 = m12;
            this.M13 = m13;
            this.M14 = m14;
            this.M21 = m21;
            this.M22 = m22;
            this.M23 = m23;
            this.M24 = m24;
            this.M31 = m31;
            this.M32 = m32;
            this.M33 = m33;
            this.M34 = m34;
            this.M41 = m41;
            this.M42 = m42;
            this.M43 = m43;
            this.M44 = m44;
        }

        public void GetUp(out Vector3 up)
        {
            up.X = this.M21;
            up.Y = this.M22;
            up.Z = this.M23;
        }

        public void GetDown(out Vector3 down)
        {
            this.GetUp(out down);
            Vector3.Negate(ref down, out down);
        }

        public void GetRight(out Vector3 right)
        {
            right.X = this.M11;
            right.Y = this.M12;
            right.Z = this.M13;
        }

        public void GetLeft(out Vector3 left)
        {
            this.GetRight(out left);
            Vector3.Negate(ref left, out left);
        }

        public void GetBackwards(out Vector3 backwards)
        {
            backwards.X = this.M31;
            backwards.Y = this.M32;
            backwards.Z = this.M33;
        }

        public void GetForward(out Vector3 forward)
        {
            this.GetBackwards(out forward);
            Vector3.Negate(ref forward, out forward);
        }

        public void GetTranslation(out Vector3 translation)
        {
            translation.X = this.M41;
            translation.Y = this.M42;
            translation.Z = this.M43;
        }

        public static void Multiply(ref Matrix m1, ref Matrix m2, out Matrix result)
        {
            float num = (((m1.M11 * m2.M11) + (m1.M12 * m2.M21)) + (m1.M13 * m2.M31)) + (m1.M14 * m2.M41);
            float num2 = (((m1.M11 * m2.M12) + (m1.M12 * m2.M22)) + (m1.M13 * m2.M32)) + (m1.M14 * m2.M42);
            float num3 = (((m1.M11 * m2.M13) + (m1.M12 * m2.M23)) + (m1.M13 * m2.M33)) + (m1.M14 * m2.M43);
            float num4 = (((m1.M11 * m2.M14) + (m1.M12 * m2.M24)) + (m1.M13 * m2.M34)) + (m1.M14 * m2.M44);
            float num5 = (((m1.M21 * m2.M11) + (m1.M22 * m2.M21)) + (m1.M23 * m2.M31)) + (m1.M24 * m2.M41);
            float num6 = (((m1.M21 * m2.M12) + (m1.M22 * m2.M22)) + (m1.M23 * m2.M32)) + (m1.M24 * m2.M42);
            float num7 = (((m1.M21 * m2.M13) + (m1.M22 * m2.M23)) + (m1.M23 * m2.M33)) + (m1.M24 * m2.M43);
            float num8 = (((m1.M21 * m2.M14) + (m1.M22 * m2.M24)) + (m1.M23 * m2.M34)) + (m1.M24 * m2.M44);
            float num9 = (((m1.M31 * m2.M11) + (m1.M32 * m2.M21)) + (m1.M33 * m2.M31)) + (m1.M34 * m2.M41);
            float num10 = (((m1.M31 * m2.M12) + (m1.M32 * m2.M22)) + (m1.M33 * m2.M32)) + (m1.M34 * m2.M42);
            float num11 = (((m1.M31 * m2.M13) + (m1.M32 * m2.M23)) + (m1.M33 * m2.M33)) + (m1.M34 * m2.M43);
            float num12 = (((m1.M31 * m2.M14) + (m1.M32 * m2.M24)) + (m1.M33 * m2.M34)) + (m1.M34 * m2.M44);
            float num13 = (((m1.M41 * m2.M11) + (m1.M42 * m2.M21)) + (m1.M43 * m2.M31)) + (m1.M44 * m2.M41);
            float num14 = (((m1.M41 * m2.M12) + (m1.M42 * m2.M22)) + (m1.M43 * m2.M32)) + (m1.M44 * m2.M42);
            float num15 = (((m1.M41 * m2.M13) + (m1.M42 * m2.M23)) + (m1.M43 * m2.M33)) + (m1.M44 * m2.M43);
            float num16 = (((m1.M41 * m2.M14) + (m1.M42 * m2.M24)) + (m1.M43 * m2.M34)) + (m1.M44 * m2.M44);
            result.M11 = num;
            result.M12 = num2;
            result.M13 = num3;
            result.M14 = num4;
            result.M21 = num5;
            result.M22 = num6;
            result.M23 = num7;
            result.M24 = num8;
            result.M31 = num9;
            result.M32 = num10;
            result.M33 = num11;
            result.M34 = num12;
            result.M41 = num13;
            result.M42 = num14;
            result.M43 = num15;
            result.M44 = num16;
        }

        public static void CreateTranslation(ref Vector3 position, out Matrix result)
        {
            result.M11 = 1f;
            result.M12 = 0f;
            result.M13 = 0f;
            result.M14 = 0f;
            result.M21 = 0f;
            result.M22 = 1f;
            result.M23 = 0f;
            result.M24 = 0f;
            result.M31 = 0f;
            result.M32 = 0f;
            result.M33 = 1f;
            result.M34 = 0f;
            result.M41 = position.X;
            result.M42 = position.Y;
            result.M43 = position.Z;
            result.M44 = 1f;
        }

        public static Matrix CreateTranslation(Vector3 position)
        {
            Matrix matrix;
            CreateTranslation(ref position, out matrix);
            return matrix;
        }

        public static void CreateScale(float xScale, float yScale, float zScale, out Matrix result)
        {
            result.M11 = xScale;
            result.M12 = 0f;
            result.M13 = 0f;
            result.M14 = 0f;
            result.M21 = 0f;
            result.M22 = yScale;
            result.M23 = 0f;
            result.M24 = 0f;
            result.M31 = 0f;
            result.M32 = 0f;
            result.M33 = zScale;
            result.M34 = 0f;
            result.M41 = 0f;
            result.M42 = 0f;
            result.M43 = 0f;
            result.M44 = 1f;
        }

        public static Matrix CreateScale(float xScale, float yScale, float zScale)
        {
            Matrix matrix;
            CreateScale(xScale, yScale, zScale, out matrix);
            return matrix;
        }

        public static void CreateScale(float scale, out Matrix result)
        {
            result.M11 = scale;
            result.M12 = 0f;
            result.M13 = 0f;
            result.M14 = 0f;
            result.M21 = 0f;
            result.M22 = scale;
            result.M23 = 0f;
            result.M24 = 0f;
            result.M31 = 0f;
            result.M32 = 0f;
            result.M33 = scale;
            result.M34 = 0f;
            result.M41 = 0f;
            result.M42 = 0f;
            result.M43 = 0f;
            result.M44 = 1f;
        }

        public static Matrix CreateScale(float scale)
        {
            Matrix matrix;
            CreateScale(scale, out matrix);
            return matrix;
        }

        public static void CreateRotationX(float radians, out Matrix result)
        {
            float num = (float) Math.Cos((double) radians);
            float num2 = (float) Math.Sin((double) radians);
            result.M11 = 1f;
            result.M12 = 0f;
            result.M13 = 0f;
            result.M14 = 0f;
            result.M21 = 0f;
            result.M22 = num;
            result.M23 = num2;
            result.M24 = 0f;
            result.M31 = 0f;
            result.M32 = -num2;
            result.M33 = num;
            result.M34 = 0f;
            result.M41 = 0f;
            result.M42 = 0f;
            result.M43 = 0f;
            result.M44 = 1f;
        }

        public static Matrix CreateRotationX(float radians)
        {
            Matrix matrix;
            CreateRotationX(radians, out matrix);
            return matrix;
        }

        public static void CreateRotationY(float radians, out Matrix result)
        {
            float num = (float) Math.Cos((double) radians);
            float num2 = (float) Math.Sin((double) radians);
            result.M11 = num;
            result.M12 = 0f;
            result.M13 = -num2;
            result.M14 = 0f;
            result.M21 = 0f;
            result.M22 = 1f;
            result.M23 = 0f;
            result.M24 = 0f;
            result.M31 = num2;
            result.M32 = 0f;
            result.M33 = num;
            result.M34 = 0f;
            result.M41 = 0f;
            result.M42 = 0f;
            result.M43 = 0f;
            result.M44 = 1f;
        }

        public static Matrix CreateRotationY(float radians)
        {
            Matrix matrix;
            CreateRotationY(radians, out matrix);
            return matrix;
        }

        public static void CreateRotationZ(float radians, out Matrix result)
        {
            float num = (float) Math.Cos((double) radians);
            float num2 = (float) Math.Sin((double) radians);
            result.M11 = num;
            result.M12 = num2;
            result.M13 = 0f;
            result.M14 = 0f;
            result.M21 = -num2;
            result.M22 = num;
            result.M23 = 0f;
            result.M24 = 0f;
            result.M31 = 0f;
            result.M32 = 0f;
            result.M33 = 1f;
            result.M34 = 0f;
            result.M41 = 0f;
            result.M42 = 0f;
            result.M43 = 0f;
            result.M44 = 1f;
        }

        public static Matrix CreateRotationZ(float radians)
        {
            Matrix matrix;
            CreateRotationZ(radians, out matrix);
            return matrix;
        }

        public static void CreateFromQuaternion(ref Quaternion quaternion, out Matrix result)
        {
            float num = quaternion.X * quaternion.X;
            float num2 = quaternion.Y * quaternion.Y;
            float num3 = quaternion.Z * quaternion.Z;
            float num4 = quaternion.X * quaternion.Y;
            float num5 = quaternion.Z * quaternion.W;
            float num6 = quaternion.Z * quaternion.X;
            float num7 = quaternion.Y * quaternion.W;
            float num8 = quaternion.Y * quaternion.Z;
            float num9 = quaternion.X * quaternion.W;
            result.M11 = 1f - (2f * (num2 + num3));
            result.M12 = 2f * (num4 + num5);
            result.M13 = 2f * (num6 - num7);
            result.M14 = 0f;
            result.M21 = 2f * (num4 - num5);
            result.M22 = 1f - (2f * (num3 + num));
            result.M23 = 2f * (num8 + num9);
            result.M24 = 0f;
            result.M31 = 2f * (num6 + num7);
            result.M32 = 2f * (num8 - num9);
            result.M33 = 1f - (2f * (num2 + num));
            result.M34 = 0f;
            result.M41 = 0f;
            result.M42 = 0f;
            result.M43 = 0f;
            result.M44 = 1f;
        }

        public static Matrix CreateFromQuaternion(Quaternion quaternion)
        {
            Matrix matrix;
            CreateFromQuaternion(ref quaternion, out matrix);
            return matrix;
        }

        public static Matrix CreateFromYawPitchRoll(float yaw, float pitch, float roll)
        {
            Matrix matrix;
            Quaternion quaternion;
            Quaternion.CreateFromYawPitchRoll(yaw, pitch, roll, out quaternion);
            CreateFromQuaternion(ref quaternion, out matrix);
            return matrix;
        }

        public static Matrix operator *(Matrix ls, Matrix rs)
        {
            Matrix matrix;
            Multiply(ref ls, ref rs, out matrix);
            return matrix;
        }

        static Matrix()
        {
            Identity = new Matrix(1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f);
        }

        public static Matrix Identity
        {
            [CompilerGenerated]
            get
            {
                return matrix_0;
            }
            [CompilerGenerated]
            private set
            {
                matrix_0 = value;
            }
        }
    }
}

