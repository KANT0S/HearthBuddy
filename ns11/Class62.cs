namespace ns11
{
    using System;
    using System.IO;

    internal class Class62
    {
        public Stream stream_0;
        public const uint uint_0 = 0x1000000;
        public uint uint_1;
        public uint uint_2;

        public void method_0(Stream stream_1)
        {
            this.stream_0 = stream_1;
            this.uint_1 = 0;
            this.uint_2 = uint.MaxValue;
            for (int i = 0; i < 5; i++)
            {
                this.uint_1 = (this.uint_1 << 8) | ((byte) this.stream_0.ReadByte());
            }
        }

        public void method_1()
        {
            this.stream_0 = null;
        }

        public void method_2()
        {
            this.stream_0.Close();
        }

        public void method_3()
        {
            while (this.uint_2 < 0x1000000)
            {
                this.uint_1 = (this.uint_1 << 8) | ((byte) this.stream_0.ReadByte());
                this.uint_2 = this.uint_2 << 8;
            }
        }

        public void method_4()
        {
            if (this.uint_2 < 0x1000000)
            {
                this.uint_1 = (this.uint_1 << 8) | ((byte) this.stream_0.ReadByte());
                this.uint_2 = this.uint_2 << 8;
            }
        }

        public uint method_5(uint uint_3)
        {
            return (this.uint_1 / (this.uint_2 /= uint_3));
        }

        public void method_6(uint uint_3, uint uint_4, uint uint_5)
        {
            this.uint_1 -= uint_3 * this.uint_2;
            this.uint_2 *= uint_4;
            this.method_3();
        }

        public uint method_7(int int_0)
        {
            uint num = this.uint_2;
            uint num2 = this.uint_1;
            uint num3 = 0;
            for (int i = int_0; i > 0; i--)
            {
                num = num >> 1;
                uint num5 = (num2 - num) >> 0x1f;
                num2 -= num & (num5 - 1);
                num3 = (num3 << 1) | (1 - num5);
                if (num < 0x1000000)
                {
                    num2 = (num2 << 8) | ((byte) this.stream_0.ReadByte());
                    num = num << 8;
                }
            }
            this.uint_2 = num;
            this.uint_1 = num2;
            return num3;
        }

        public uint method_8(uint uint_3, int int_0)
        {
            uint num2;
            uint num = (this.uint_2 >> int_0) * uint_3;
            if (this.uint_1 < num)
            {
                num2 = 0;
                this.uint_2 = num;
            }
            else
            {
                num2 = 1;
                this.uint_1 -= num;
                this.uint_2 -= num;
            }
            this.method_3();
            return num2;
        }
    }
}

