namespace ns20
{
    using System;

    internal class Class190
    {
        private char[] char_0;
        private static readonly char[] char_1 = new char[0];
        private int int_0;

        public Class190()
        {
            this.char_0 = char_1;
        }

        public Class190(int initalSize)
        {
            this.char_0 = new char[initalSize];
        }

        public void method_0(char char_2)
        {
            if (this.int_0 == this.char_0.Length)
            {
                this.method_3(1);
            }
            this.char_0[this.int_0++] = char_2;
        }

        public void method_1(char[] char_2, int int_1, int int_2)
        {
            if ((this.int_0 + int_2) >= this.char_0.Length)
            {
                this.method_3(int_2);
            }
            Array.Copy(char_2, int_1, this.char_0, this.int_0, int_2);
            this.int_0 += int_2;
        }

        public void method_2()
        {
            this.char_0 = char_1;
            this.int_0 = 0;
        }

        private void method_3(int int_1)
        {
            char[] destinationArray = new char[(this.int_0 + int_1) * 2];
            Array.Copy(this.char_0, destinationArray, this.int_0);
            this.char_0 = destinationArray;
        }

        public string method_4(int int_1, int int_2)
        {
            return new string(this.char_0, int_1, int_2);
        }

        public char[] method_5()
        {
            return this.char_0;
        }

        string object.ToString()
        {
            return this.method_4(0, this.int_0);
        }

        public int Int32_0
        {
            get
            {
                return this.int_0;
            }
            set
            {
                this.int_0 = value;
            }
        }
    }
}

