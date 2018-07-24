namespace Triton.Common.Math
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct Quaternion
    {
        public float X;
        public float Y;
        public float Z;
        public float W;
        public static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Quaternion result)
        {
            float single1 = roll * 0.5f;
            float num = (float) Math.Sin((double) single1);
            float num2 = (float) Math.Cos((double) single1);
            float single2 = pitch * 0.5f;
            float num3 = (float) Math.Sin((double) single2);
            float num4 = (float) Math.Cos((double) single2);
            float single3 = yaw * 0.5f;
            float num5 = (float) Math.Sin((double) single3);
            float num6 = (float) Math.Cos((double) single3);
            result.X = ((num6 * num3) * num2) + ((num5 * num4) * num);
            result.Y = ((num5 * num4) * num2) - ((num6 * num3) * num);
            result.Z = ((num6 * num4) * num) - ((num5 * num3) * num2);
            result.W = ((num6 * num4) * num2) + ((num5 * num3) * num);
        }
    }
}

