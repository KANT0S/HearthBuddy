namespace Triton.Common
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct WpfVector2i : IEquatable<WpfVector2i>
    {
        [CompilerGenerated]
        private int int_0;
        [CompilerGenerated]
        private int int_1;
        public int X
        {
            [CompilerGenerated]
            get
            {
                return this.int_0;
            }
            [CompilerGenerated]
            set
            {
                this.int_0 = value;
            }
        }
        public int Y
        {
            [CompilerGenerated]
            get
            {
                return this.int_1;
            }
            [CompilerGenerated]
            set
            {
                this.int_1 = value;
            }
        }
        public bool Equals(WpfVector2i other)
        {
            return Equals(ref this, ref other);
        }

        public bool Equals(ref WpfVector2i other)
        {
            return Equals(ref this, ref other);
        }

        public static bool Equals(ref WpfVector2i v1, ref WpfVector2i v2)
        {
            return ((v1.X == v2.X) && (v1.Y == v2.Y));
        }

        public static bool operator ==(WpfVector2i ls, WpfVector2i rs)
        {
            return Equals(ref ls, ref rs);
        }

        public static bool operator !=(WpfVector2i ls, WpfVector2i rs)
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
                return this.Equals((WpfVector2i) obj);
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
    }
}

