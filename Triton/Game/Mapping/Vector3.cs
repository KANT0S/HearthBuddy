namespace Triton.Game.Mapping
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct Vector3
    {
        public float X;
        public float Y;
        public float Z;
        public override string ToString()
        {
            return string.Format("{0},{1},{2}", this.X, this.Y, this.Z);
        }

        public Vector3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override bool Equals(object obj)
        {
            return ((obj is Vector3) && (this == ((Vector3) obj)));
        }

        public override int GetHashCode()
        {
            return ((this.X.GetHashCode() ^ this.Y.GetHashCode()) ^ this.Z.GetHashCode());
        }

        public static bool operator ==(Vector3 lhs, Vector3 rhs)
        {
            return ((lhs.X.Equals(rhs.X) && lhs.Y.Equals(rhs.Y)) && lhs.Z.Equals(rhs.Z));
        }

        public static bool operator !=(Vector3 x, Vector3 y)
        {
            return !(x == y);
        }
    }
}

