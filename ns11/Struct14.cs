namespace ns11
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal struct Struct14
    {
        private readonly Struct12[] struct12_0;
        private readonly int int_0;
        public Struct14(int numBitLevels)
        {
            this.int_0 = numBitLevels;
            this.struct12_0 = new Struct12[((int) 1) << numBitLevels];
        }

        public void method_0()
        {
            for (uint i = 1; i < (((int) 1) << this.int_0); i++)
            {
                this.struct12_0[i].method_1();
            }
        }

        public uint method_1(Class62 class62_0)
        {
            uint index = 1;
            for (int i = this.int_0; i > 0; i--)
            {
                index = (index << 1) + this.struct12_0[index].method_2(class62_0);
            }
            return (index - (((uint) 1) << this.int_0));
        }

        public uint method_2(Class62 class62_0)
        {
            uint index = 1;
            uint num2 = 0;
            for (int i = 0; i < this.int_0; i++)
            {
                uint num4 = this.struct12_0[index].method_2(class62_0);
                index = index << 1;
                index += num4;
                num2 |= num4 << i;
            }
            return num2;
        }

        public static uint smethod_0(Struct12[] struct12_1, uint uint_0, Class62 class62_0, int int_1)
        {
            uint num = 1;
            uint num2 = 0;
            for (int i = 0; i < int_1; i++)
            {
                uint num4 = struct12_1[uint_0 + num].method_2(class62_0);
                num = num << 1;
                num += num4;
                num2 |= num4 << i;
            }
            return num2;
        }
    }
}

