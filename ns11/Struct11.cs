namespace ns11
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal struct Struct11
    {
        public const uint uint_0 = 0x800;
        public const int int_0 = 11;
        public const int int_1 = 6;
        private const int int_2 = 5;
        private const int int_3 = 2;
        private static readonly uint[] uint_1;
        private uint uint_2;
        static Struct11()
        {
            uint_1 = new uint[0x200];
            for (int i = 8; i >= 0; i--)
            {
                uint num2 = ((uint) 1) << (9 - i);
                for (uint j = ((uint) 1) << ((9 - i) - 1); j < num2; j++)
                {
                    uint_1[j] = ((uint) (i << 6)) + (((num2 - j) << 6) >> ((9 - i) - 1));
                }
            }
        }

        public void method_0()
        {
            this.uint_2 = 0x400;
        }

        public void method_1(uint uint_3)
        {
            if (uint_3 == 0)
            {
                this.uint_2 += (uint) ((0x800 - this.uint_2) >> 5);
            }
            else
            {
                this.uint_2 -= this.uint_2 >> 5;
            }
        }

        public void method_2(Class61 class61_0, uint uint_3)
        {
            uint num = (class61_0.uint_2 >> 11) * this.uint_2;
            if (uint_3 == 0)
            {
                class61_0.uint_2 = num;
                this.uint_2 += (uint) ((0x800 - this.uint_2) >> 5);
            }
            else
            {
                class61_0.ulong_0 += num;
                class61_0.uint_2 -= num;
                this.uint_2 -= this.uint_2 >> 5;
            }
            if (class61_0.uint_2 < 0x1000000)
            {
                class61_0.uint_2 = class61_0.uint_2 << 8;
                class61_0.method_7();
            }
        }

        public uint method_3(uint uint_3)
        {
            return uint_1[(int) ((IntPtr) ((((this.uint_2 - uint_3) ^ -uint_3) & 0x7ffL) >> 2))];
        }

        public uint method_4()
        {
            return uint_1[this.uint_2 >> 2];
        }

        public uint method_5()
        {
            return uint_1[(int) ((0x800 - this.uint_2) >> 2)];
        }
    }
}

