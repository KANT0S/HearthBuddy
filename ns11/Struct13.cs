namespace ns11
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal struct Struct13
    {
        private readonly Struct11[] struct11_0;
        private readonly int int_0;
        public Struct13(int numBitLevels)
        {
            this.int_0 = numBitLevels;
            this.struct11_0 = new Struct11[((int) 1) << numBitLevels];
        }

        public void method_0()
        {
            for (uint i = 1; i < (((int) 1) << this.int_0); i++)
            {
                this.struct11_0[i].method_0();
            }
        }

        public void method_1(Class61 class61_0, uint uint_0)
        {
            uint index = 1;
            int num2 = this.int_0;
            while (num2 > 0)
            {
                num2--;
                uint num3 = (uint_0 >> num2) & 1;
                this.struct11_0[index].method_2(class61_0, num3);
                index = (index << 1) | num3;
            }
        }

        public void method_2(Class61 class61_0, uint uint_0)
        {
            uint index = 1;
            for (uint i = 0; i < this.int_0; i++)
            {
                uint num3 = uint_0 & 1;
                this.struct11_0[index].method_2(class61_0, num3);
                index = (index << 1) | num3;
                uint_0 = uint_0 >> 1;
            }
        }

        public uint method_3(uint uint_0)
        {
            uint num = 0;
            uint index = 1;
            int num3 = this.int_0;
            while (num3 > 0)
            {
                num3--;
                uint num4 = (uint_0 >> num3) & 1;
                num += this.struct11_0[index].method_3(num4);
                index = (index << 1) + num4;
            }
            return num;
        }

        public uint method_4(uint uint_0)
        {
            uint num = 0;
            uint index = 1;
            for (int i = this.int_0; i > 0; i--)
            {
                uint num4 = uint_0 & 1;
                uint_0 = uint_0 >> 1;
                num += this.struct11_0[index].method_3(num4);
                index = (index << 1) | num4;
            }
            return num;
        }

        public static uint smethod_0(Struct11[] struct11_1, uint uint_0, int int_1, uint uint_1)
        {
            uint num = 0;
            uint num2 = 1;
            for (int i = int_1; i > 0; i--)
            {
                uint num4 = uint_1 & 1;
                uint_1 = uint_1 >> 1;
                num += struct11_1[uint_0 + num2].method_3(num4);
                num2 = (num2 << 1) | num4;
            }
            return num;
        }

        public static void smethod_1(Struct11[] struct11_1, uint uint_0, Class61 class61_0, int int_1, uint uint_1)
        {
            uint num = 1;
            for (int i = 0; i < int_1; i++)
            {
                uint num3 = uint_1 & 1;
                struct11_1[uint_0 + num].method_2(class61_0, num3);
                num = (num << 1) | num3;
                uint_1 = uint_1 >> 1;
            }
        }
    }
}

