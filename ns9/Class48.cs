namespace ns9
{
    using System;
    using System.IO;

    internal class Class48
    {
        private bool bool_0;
        public byte[] byte_0;
        private Stream stream_0;
        public uint uint_0;
        public uint uint_1;
        private uint uint_2;
        private uint uint_3;
        private uint uint_4;
        public uint uint_5;
        private uint uint_6;
        public uint uint_7;

        public void method_0()
        {
            uint num = (this.uint_1 + this.uint_5) - this.uint_3;
            if (num > 0)
            {
                num--;
            }
            uint num2 = (this.uint_1 + this.uint_7) - num;
            for (uint i = 0; i < num2; i++)
            {
                this.byte_0[i] = this.byte_0[num + i];
            }
            this.uint_1 -= num;
        }

        private void method_1()
        {
            this.byte_0 = null;
        }

        public void method_10(int int_0)
        {
            this.uint_1 += (uint) int_0;
            this.uint_6 -= (uint) int_0;
            this.uint_5 -= (uint) int_0;
            this.uint_7 -= (uint) int_0;
        }

        public void method_2(uint uint_8, uint uint_9, uint uint_10)
        {
            this.uint_3 = uint_8;
            this.uint_2 = uint_9;
            uint num = (uint_8 + uint_9) + uint_10;
            if ((this.byte_0 == null) || (this.uint_0 != num))
            {
                this.method_1();
                this.uint_0 = num;
                this.byte_0 = new byte[this.uint_0];
            }
            this.uint_4 = this.uint_0 - uint_9;
        }

        public void method_3(Stream stream_1)
        {
            this.stream_0 = stream_1;
        }

        public void method_4()
        {
            this.stream_0 = null;
        }

        public void method_5()
        {
            this.uint_1 = 0;
            this.uint_5 = 0;
            this.uint_7 = 0;
            this.bool_0 = false;
            this.vmethod_0();
        }

        public void method_6()
        {
            this.uint_5++;
            if (this.uint_5 > this.uint_6)
            {
                if ((this.uint_1 + this.uint_5) > this.uint_4)
                {
                    this.method_0();
                }
                this.vmethod_0();
            }
        }

        public byte method_7(int int_0)
        {
            return this.byte_0[(int) ((IntPtr) ((this.uint_1 + this.uint_5) + int_0))];
        }

        public uint method_8(int int_0, uint uint_8, uint uint_9)
        {
            if (this.bool_0 && (((this.uint_5 + int_0) + uint_9) > this.uint_7))
            {
                uint_9 = this.uint_7 - (this.uint_5 + ((uint) int_0));
            }
            uint_8++;
            uint num = (this.uint_1 + this.uint_5) + ((uint) int_0);
            uint num2 = 0;
            while (num2 < uint_9)
            {
                if (this.byte_0[num + num2] != this.byte_0[(num + num2) - uint_8])
                {
                    return num2;
                }
                num2++;
            }
            return num2;
        }

        public uint method_9()
        {
            return (this.uint_7 - this.uint_5);
        }

        public virtual void vmethod_0()
        {
            if (!this.bool_0)
            {
                int num;
            Label_0062:
                num = (int) (((0 - this.uint_1) + this.uint_0) - this.uint_7);
                if (num != 0)
                {
                    int num2 = this.stream_0.Read(this.byte_0, (int) (this.uint_1 + this.uint_7), num);
                    if (num2 == 0)
                    {
                        this.uint_6 = this.uint_7;
                        if ((this.uint_1 + this.uint_6) > this.uint_4)
                        {
                            this.uint_6 = this.uint_4 - this.uint_1;
                        }
                        this.bool_0 = true;
                    }
                    else
                    {
                        this.uint_7 += (uint) num2;
                        if (this.uint_7 >= (this.uint_5 + this.uint_2))
                        {
                            this.uint_6 = this.uint_7 - this.uint_2;
                        }
                        goto Label_0062;
                    }
                }
            }
        }
    }
}

