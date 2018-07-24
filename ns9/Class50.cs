namespace ns9
{
    using System;
    using System.Runtime.InteropServices;

    internal abstract class Class50
    {
        public const int int_0 = 0;
        public const int int_1 = 4;
        public const int int_2 = 8;
        public const int int_3 = 2;
        public const int int_4 = 3;
        public const int int_5 = 3;
        public const int int_6 = 6;
        public const int int_7 = 4;
        public const int int_8 = 4;
        public const uint uint_0 = 15;
        public const uint uint_1 = 0x10;
        public const uint uint_10 = 8;
        public const uint uint_11 = 8;
        public const uint uint_12 = 10;
        public const uint uint_13 = 0x10;
        public const uint uint_14 = 0x10;
        public const uint uint_15 = 4;
        public const uint uint_16 = 12;
        public const uint uint_17 = 4;
        public const uint uint_2 = 14;
        public const uint uint_3 = 0x111;
        public const uint uint_4 = 2;
        public const uint uint_5 = 0x80;
        public const uint uint_6 = 0x110;
        public const uint uint_7 = 4;
        public const uint uint_8 = 8;
        public const uint uint_9 = 4;

        protected Class50()
        {
        }

        public static uint smethod_0(uint uint_18)
        {
            uint_18 -= 2;
            if (uint_18 < 4)
            {
                return uint_18;
            }
            return 3;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct Struct8
        {
            public uint uint_0;
            public void method_0()
            {
                this.uint_0 = 0;
            }

            public void method_1()
            {
                if (this.uint_0 < 4)
                {
                    this.uint_0 = 0;
                }
                else if (this.uint_0 < 10)
                {
                    this.uint_0 -= 3;
                }
                else
                {
                    this.uint_0 -= 6;
                }
            }

            public void method_2()
            {
                this.uint_0 = (this.uint_0 < 7) ? 7 : 10;
            }

            public void method_3()
            {
                this.uint_0 = (this.uint_0 < 7) ? 8 : 11;
            }

            public void method_4()
            {
                this.uint_0 = (this.uint_0 < 7) ? 9 : 11;
            }

            public bool method_5()
            {
                return (this.uint_0 < 7);
            }
        }
    }
}

