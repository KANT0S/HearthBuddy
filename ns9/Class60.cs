namespace ns9
{
    using System;
    using System.IO;

    internal class Class60
    {
        private byte[] byte_0;
        private Stream stream_0;
        private uint uint_0;
        private uint uint_1;
        private uint uint_2;

        public void method_0(uint uint_3)
        {
            if (this.uint_2 != uint_3)
            {
                this.byte_0 = new byte[uint_3];
            }
            this.uint_2 = uint_3;
            this.uint_0 = 0;
            this.uint_1 = 0;
        }

        public void method_1(Stream stream_1, bool bool_0)
        {
            this.method_3();
            this.stream_0 = stream_1;
            if (!bool_0)
            {
                this.uint_1 = 0;
                this.uint_0 = 0;
            }
        }

        public void method_2(Stream stream_1)
        {
            this.method_1(stream_1, false);
        }

        public void method_3()
        {
            this.method_4();
            this.stream_0 = null;
        }

        public void method_4()
        {
            uint num = this.uint_0 - this.uint_1;
            if (num != 0)
            {
                this.stream_0.Write(this.byte_0, (int) this.uint_1, (int) num);
                if (this.uint_0 >= this.uint_2)
                {
                    this.uint_0 = 0;
                }
                this.uint_1 = this.uint_0;
            }
        }

        public void method_5(uint uint_3, uint uint_4)
        {
            uint num = (this.uint_0 - uint_3) - 1;
            if (num >= this.uint_2)
            {
                num += this.uint_2;
            }
            while (uint_4 > 0)
            {
                if (num >= this.uint_2)
                {
                    num = 0;
                }
                uint index = this.uint_0;
                this.uint_0 = index + 1;
                this.byte_0[index] = this.byte_0[num++];
                if (this.uint_0 >= this.uint_2)
                {
                    this.method_4();
                }
                uint_4--;
            }
        }

        public void method_6(byte byte_1)
        {
            uint index = this.uint_0;
            this.uint_0 = index + 1;
            this.byte_0[index] = byte_1;
            if (this.uint_0 >= this.uint_2)
            {
                this.method_4();
            }
        }

        public byte method_7(uint uint_3)
        {
            uint index = (this.uint_0 - uint_3) - 1;
            if (index >= this.uint_2)
            {
                index += this.uint_2;
            }
            return this.byte_0[index];
        }
    }
}

