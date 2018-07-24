namespace ns20
{
    using System;
    using System.IO;

    internal class Class142
    {
        private byte[] byte_0;
        private readonly char[] char_0 = new char[0x4c];
        private const int int_0 = 0x4c;
        private const int int_1 = 0x39;
        private int int_2;
        private readonly TextWriter textWriter_0;

        public Class142(TextWriter writer)
        {
            Class203.smethod_2(writer, "writer");
            this.textWriter_0 = writer;
        }

        public void method_0(byte[] byte_1, int int_3, int int_4)
        {
            if (byte_1 == null)
            {
                throw new ArgumentNullException("buffer");
            }
            if (int_3 < 0)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            if (int_4 < 0)
            {
                throw new ArgumentOutOfRangeException("count");
            }
            if (int_4 > (byte_1.Length - int_3))
            {
                throw new ArgumentOutOfRangeException("count");
            }
            if (this.int_2 > 0)
            {
                int num = this.int_2;
                while (num < 3)
                {
                    if (int_4 <= 0)
                    {
                        break;
                    }
                    this.byte_0[num++] = byte_1[int_3++];
                    int_4--;
                }
                if ((int_4 == 0) && (num < 3))
                {
                    this.int_2 = num;
                    return;
                }
                int num2 = Convert.ToBase64CharArray(this.byte_0, 0, 3, this.char_0, 0);
                this.method_2(this.char_0, 0, num2);
            }
            this.int_2 = int_4 % 3;
            if (this.int_2 > 0)
            {
                int_4 -= this.int_2;
                if (this.byte_0 == null)
                {
                    this.byte_0 = new byte[3];
                }
                for (int i = 0; i < this.int_2; i++)
                {
                    this.byte_0[i] = byte_1[(int_3 + int_4) + i];
                }
            }
            int num4 = int_3 + int_4;
            int length = 0x39;
            while (int_3 < num4)
            {
                if ((int_3 + length) > num4)
                {
                    length = num4 - int_3;
                }
                int num6 = Convert.ToBase64CharArray(byte_1, int_3, length, this.char_0, 0);
                this.method_2(this.char_0, 0, num6);
                int_3 += length;
            }
        }

        public void method_1()
        {
            if (this.int_2 > 0)
            {
                int num = Convert.ToBase64CharArray(this.byte_0, 0, this.int_2, this.char_0, 0);
                this.method_2(this.char_0, 0, num);
                this.int_2 = 0;
            }
        }

        private void method_2(char[] char_1, int int_3, int int_4)
        {
            this.textWriter_0.Write(char_1, int_3, int_4);
        }
    }
}

