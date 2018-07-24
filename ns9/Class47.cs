namespace ns9
{
    using System;

    internal class Class47
    {
        public static readonly uint[] uint_0 = new uint[0x100];
        private uint uint_1 = uint.MaxValue;

        static Class47()
        {
            for (uint i = 0; i < 0x100; i++)
            {
                uint num2 = i;
                for (int j = 0; j < 8; j++)
                {
                    if ((num2 & 1) != 0)
                    {
                        num2 = (num2 >> 1) ^ 0xedb88320;
                    }
                    else
                    {
                        num2 = num2 >> 1;
                    }
                }
                uint_0[i] = num2;
            }
        }

        public void method_0()
        {
            this.uint_1 = uint.MaxValue;
        }

        public void method_1(byte byte_0)
        {
            this.uint_1 = uint_0[((byte) this.uint_1) ^ byte_0] ^ (this.uint_1 >> 8);
        }

        public void method_2(byte[] byte_0, uint uint_2, uint uint_3)
        {
            for (uint i = 0; i < uint_3; i++)
            {
                this.uint_1 = uint_0[((byte) this.uint_1) ^ byte_0[uint_2 + i]] ^ (this.uint_1 >> 8);
            }
        }

        public uint method_3()
        {
            return (this.uint_1 ^ uint.MaxValue);
        }

        private static uint smethod_0(byte[] byte_0, uint uint_2, uint uint_3)
        {
            Class47 class1 = new Class47();
            class1.method_2(byte_0, uint_2, uint_3);
            return class1.method_3();
        }

        private static bool smethod_1(uint uint_2, byte[] byte_0, uint uint_3, uint uint_4)
        {
            return (smethod_0(byte_0, uint_3, uint_4) == uint_2);
        }
    }
}

