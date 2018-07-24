namespace ns20
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal struct Struct26
    {
        private const short short_0 = 7;
        public int int_0;
        public int int_1;
        public int int_2;
        public int int_3;
        public int int_4;
        public int int_5;
        public int int_6;
        public int int_7;
        public int int_8;
        public Enum13 enum13_0;
        private string string_0;
        private int int_9;
        private static readonly int[] int_10;
        private static readonly int int_11;
        private static readonly int int_12;
        private static readonly int int_13;
        private static readonly int int_14;
        private static readonly int int_15;
        private static readonly int int_16;
        private static readonly int int_17;
        private static readonly int int_18;
        private static readonly int int_19;
        private static readonly int int_20;
        private static readonly int int_21;
        private static readonly int int_22;
        private static readonly int int_23;
        private static readonly int int_24;
        private static readonly int int_25;
        static Struct26()
        {
            int_10 = new int[] { -1, 10, 100, 0x3e8, 0x2710, 0x186a0, 0xf4240 };
            int_11 = "yyyy".Length;
            int_12 = "yyyy-".Length;
            int_13 = "yyyy-MM".Length;
            int_14 = "yyyy-MM-".Length;
            int_15 = "yyyy-MM-dd".Length;
            int_16 = "yyyy-MM-ddT".Length;
            int_17 = "HH".Length;
            int_18 = "HH:".Length;
            int_19 = "HH:mm".Length;
            int_20 = "HH:mm:".Length;
            int_21 = "HH:mm:ss".Length;
            int_22 = "-".Length;
            int_23 = "-zz".Length;
            int_24 = "-zz:".Length;
            int_25 = "-zz:zz".Length;
        }

        public bool method_0(string string_1)
        {
            this.string_0 = string_1;
            this.int_9 = string_1.Length;
            return ((this.method_1(0) && this.method_7(int_15, 'T')) && this.method_2(int_16));
        }

        private bool method_1(int int_26)
        {
            return (((((this.method_5(int_26, out this.int_0) && (1 <= this.int_0)) && (this.method_7(int_26 + int_11, '-') && this.method_6(int_26 + int_12, out this.int_1))) && (((1 <= this.int_1) && (this.int_1 <= 12)) && (this.method_7(int_26 + int_13, '-') && this.method_6(int_26 + int_14, out this.int_2)))) && (1 <= this.int_2)) && (this.int_2 <= DateTime.DaysInMonth(this.int_0, this.int_1)));
        }

        private bool method_2(int int_26)
        {
            return (this.method_3(ref int_26) && this.method_4(int_26));
        }

        private bool method_3(ref int int_26)
        {
            if (((!this.method_6(int_26, out this.int_3) || (this.int_3 >= 0x18)) || (!this.method_7(int_26 + int_17, ':') || !this.method_6(int_26 + int_18, out this.int_4))) || (((this.int_4 >= 60) || !this.method_7(int_26 + int_19, ':')) || (!this.method_6(int_26 + int_20, out this.int_5) || (this.int_5 >= 60))))
            {
                return false;
            }
            int_26 += int_21;
            if (this.method_7(int_26, '.'))
            {
                this.int_6 = 0;
                int num = 0;
                while (++int_26 < this.int_9)
                {
                    if (num >= 7)
                    {
                        break;
                    }
                    int num2 = this.string_0[int_26] - '0';
                    if ((num2 < 0) || (num2 > 9))
                    {
                        break;
                    }
                    this.int_6 = (this.int_6 * 10) + num2;
                    num++;
                }
                if (num < 7)
                {
                    if (num == 0)
                    {
                        return false;
                    }
                    this.int_6 *= int_10[7 - num];
                }
            }
            return true;
        }

        private bool method_4(int int_26)
        {
            if (int_26 < this.int_9)
            {
                char ch = this.string_0[int_26];
                switch (ch)
                {
                    case 'Z':
                    case 'z':
                        this.enum13_0 = Enum13.Utc;
                        int_26++;
                        goto Label_00D4;
                }
                if (((((int_26 + 5) < this.int_9) && this.method_6(int_26 + int_22, out this.int_7)) && ((this.int_7 <= 0x63) && this.method_7(int_26 + int_23, ':'))) && (this.method_6(int_26 + int_24, out this.int_8) && (this.int_8 <= 0x63)))
                {
                    switch (ch)
                    {
                        case '+':
                            this.enum13_0 = Enum13.LocalEastOfUtc;
                            int_26 += int_25;
                            break;

                        case '-':
                            this.enum13_0 = Enum13.LocalWestOfUtc;
                            int_26 += int_25;
                            break;
                    }
                }
            }
        Label_00D4:
            return (int_26 == this.int_9);
        }

        private bool method_5(int int_26, out int int_27)
        {
            if ((int_26 + 3) < this.int_9)
            {
                int num = this.string_0[int_26] - '0';
                int num2 = this.string_0[int_26 + 1] - '0';
                int num3 = this.string_0[int_26 + 2] - '0';
                int num4 = this.string_0[int_26 + 3] - '0';
                if ((((0 <= num) && (num < 10)) && ((0 <= num2) && (num2 < 10))) && (((0 <= num3) && (num3 < 10)) && ((0 <= num4) && (num4 < 10))))
                {
                    int_27 = (((((num * 10) + num2) * 10) + num3) * 10) + num4;
                    return true;
                }
            }
            int_27 = 0;
            return false;
        }

        private bool method_6(int int_26, out int int_27)
        {
            if ((int_26 + 1) < this.int_9)
            {
                int num = this.string_0[int_26] - '0';
                int num2 = this.string_0[int_26 + 1] - '0';
                if (((0 <= num) && (num < 10)) && ((0 <= num2) && (num2 < 10)))
                {
                    int_27 = (num * 10) + num2;
                    return true;
                }
            }
            int_27 = 0;
            return false;
        }

        private bool method_7(int int_26, char char_0)
        {
            return ((int_26 < this.int_9) && (this.string_0[int_26] == char_0));
        }
    }
}

