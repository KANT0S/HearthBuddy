namespace ns11
{
    using System;
    using System.IO;

    internal class Class61
    {
        private byte byte_0;
        private long long_0;
        private Stream stream_0;
        public const uint uint_0 = 0x1000000;
        private uint uint_1;
        public uint uint_2;
        public ulong ulong_0;

        public void method_0(Stream stream_1)
        {
            this.stream_0 = stream_1;
        }

        public void method_1()
        {
            this.stream_0 = null;
        }

        public long method_10()
        {
            return (((this.uint_1 + this.stream_0.Position) - this.long_0) + 4L);
        }

        public void method_2()
        {
            this.long_0 = this.stream_0.Position;
            this.ulong_0 = 0L;
            this.uint_2 = uint.MaxValue;
            this.uint_1 = 1;
            this.byte_0 = 0;
        }

        public void method_3()
        {
            for (int i = 0; i < 5; i++)
            {
                this.method_7();
            }
        }

        public void method_4()
        {
            this.stream_0.Flush();
        }

        public void method_5()
        {
            this.stream_0.Close();
        }

        public void method_6(uint uint_3, uint uint_4, uint uint_5)
        {
            this.ulong_0 += uint_3 * (this.uint_2 /= uint_5);
            this.uint_2 *= uint_4;
            while (this.uint_2 < 0x1000000)
            {
                this.uint_2 = this.uint_2 << 8;
                this.method_7();
            }
        }

        public void method_7()
        {
            if ((((uint) this.ulong_0) < 0xff000000) || (((uint) (this.ulong_0 >> 0x20)) == 1))
            {
                uint num2;
                byte num = this.byte_0;
                do
                {
                    this.stream_0.WriteByte((byte) (num + (this.ulong_0 >> 0x20)));
                    num = 0xff;
                    num2 = this.uint_1 - 1;
                    this.uint_1 = num2;
                }
                while (num2 != 0);
                this.byte_0 = (byte) (((uint) this.ulong_0) >> 0x18);
            }
            this.uint_1++;
            this.ulong_0 = ((uint) this.ulong_0) << 8;
        }

        public void method_8(uint uint_3, int int_0)
        {
            for (int i = int_0 - 1; i >= 0; i--)
            {
                this.uint_2 = this.uint_2 >> 1;
                if (((uint_3 >> i) & 1) == 1)
                {
                    this.ulong_0 += this.uint_2;
                }
                if (this.uint_2 < 0x1000000)
                {
                    this.uint_2 = this.uint_2 << 8;
                    this.method_7();
                }
            }
        }

        public void method_9(uint uint_3, int int_0, uint uint_4)
        {
            uint num = (this.uint_2 >> int_0) * uint_3;
            if (uint_4 == 0)
            {
                this.uint_2 = num;
            }
            else
            {
                this.ulong_0 += num;
                this.uint_2 -= num;
            }
            while (this.uint_2 < 0x1000000)
            {
                this.uint_2 = this.uint_2 << 8;
                this.method_7();
            }
        }
    }
}

