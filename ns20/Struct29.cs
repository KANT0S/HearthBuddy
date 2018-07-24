namespace ns20
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal struct Struct29
    {
        private readonly char[] char_0;
        private readonly int int_0;
        private readonly int int_1;
        public char[] Char_0
        {
            get
            {
                return this.char_0;
            }
        }
        public int Int32_0
        {
            get
            {
                return this.int_0;
            }
        }
        public int Int32_1
        {
            get
            {
                return this.int_1;
            }
        }
        public Struct29(char[] chars, int startIndex, int length)
        {
            this.char_0 = chars;
            this.int_0 = startIndex;
            this.int_1 = length;
        }

        string ValueType.ToString()
        {
            return new string(this.char_0, this.int_0, this.int_1);
        }
    }
}

