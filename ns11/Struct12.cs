namespace ns11
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal struct Struct12
    {
        public const uint uint_0 = 0x800;
        public const int int_0 = 11;
        private const int int_1 = 5;
        private uint uint_1;
        public void method_0(int int_2, uint uint_2)
        {
            if (uint_2 == 0)
            {
                this.uint_1 += (uint) ((0x800 - this.uint_1) >> (int_2 & 0x1f));
            }
            else
            {
                this.uint_1 -= this.uint_1 >> int_2;
            }
        }

        public void method_1()
        {
            this.uint_1 = 0x400;
        }

        public uint method_2(Class62 class62_0)
        {
            uint num = (class62_0.uint_2 >> 11) * this.uint_1;
            if (class62_0.uint_1 < num)
            {
                class62_0.uint_2 = num;
                this.uint_1 += (uint) ((0x800 - this.uint_1) >> 5);
                if (class62_0.uint_2 < 0x1000000)
                {
                    class62_0.uint_1 = (class62_0.uint_1 << 8) | ((byte) class62_0.stream_0.ReadByte());
                    class62_0.uint_2 = class62_0.uint_2 << 8;
                }
                return 0;
            }
            class62_0.uint_2 -= num;
            class62_0.uint_1 -= num;
            this.uint_1 -= this.uint_1 >> 5;
            if (class62_0.uint_2 < 0x1000000)
            {
                class62_0.uint_1 = (class62_0.uint_1 << 8) | ((byte) class62_0.stream_0.ReadByte());
                class62_0.uint_2 = class62_0.uint_2 << 8;
            }
            return 1;
        }
    }
}

