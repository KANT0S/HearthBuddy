namespace ns9
{
    using System;
    using System.IO;

    internal class Class49 : Class48, Interface6, Interface7
    {
        private bool bool_1 = true;
        private const uint uint_10 = 0x400;
        private const uint uint_11 = 0x400;
        private const uint uint_12 = 0x10000;
        private const uint uint_13 = 0x7fffffff;
        private const uint uint_14 = 1;
        private uint uint_15 = 0xff;
        private uint uint_16;
        private uint uint_17;
        private uint[] uint_18;
        private uint uint_19;
        private uint uint_20;
        private uint uint_21;
        private uint[] uint_22;
        private uint uint_23 = 0x10400;
        private uint uint_24 = 4;
        private uint uint_25;
        private const uint uint_8 = 0x10000;
        private const uint uint_9 = 0;

        public void imethod_0(Stream stream_1)
        {
            base.method_3(stream_1);
        }

        public void imethod_1()
        {
            base.method_5();
            for (uint i = 0; i < this.uint_20; i++)
            {
                this.uint_18[i] = 0;
            }
            this.uint_16 = 0;
            base.method_10(-1);
        }

        public void imethod_2()
        {
            base.method_4();
        }

        public byte imethod_3(int int_0)
        {
            return base.method_7(int_0);
        }

        public uint imethod_4(int int_0, uint uint_26, uint uint_27)
        {
            return base.method_8(int_0, uint_26, uint_27);
        }

        public uint imethod_5()
        {
            return base.method_9();
        }

        public void imethod_6(uint uint_26, uint uint_27, uint uint_28, uint uint_29)
        {
            if (uint_26 > 0x7ffffeff)
            {
                throw new Exception();
            }
            this.uint_15 = 0x10 + (uint_28 >> 1);
            uint num = ((((uint_26 + uint_27) + uint_28) + uint_29) / 2) + 0x100;
            base.method_2(uint_26 + uint_27, uint_28 + uint_29, num);
            this.uint_21 = uint_28;
            uint num2 = uint_26 + 1;
            if (this.uint_17 != num2)
            {
                this.uint_22 = new uint[(this.uint_17 = num2) * 2];
            }
            uint num3 = 0x10000;
            if (this.bool_1)
            {
                num3 = uint_26 - 1;
                num3 |= num3 >> 1;
                num3 |= num3 >> 2;
                num3 |= num3 >> 4;
                num3 |= num3 >> 8;
                num3 = num3 >> 1;
                num3 |= 0xffff;
                if (num3 > 0x1000000)
                {
                    num3 = num3 >> 1;
                }
                this.uint_19 = num3;
                num3++;
                num3 += this.uint_23;
            }
            if (num3 != this.uint_20)
            {
                this.uint_18 = new uint[this.uint_20 = num3];
            }
        }

        public uint imethod_7(uint[] uint_26)
        {
            uint num;
            uint num8;
            uint num14;
            if ((base.uint_5 + this.uint_21) <= base.uint_7)
            {
                num = this.uint_21;
            }
            else
            {
                num = base.uint_7 - base.uint_5;
                if (num < this.uint_24)
                {
                    this.method_12();
                    return 0;
                }
            }
            uint num2 = 0;
            uint num3 = (base.uint_5 > this.uint_17) ? (base.uint_5 - this.uint_17) : 0;
            uint index = base.uint_1 + base.uint_5;
            uint num5 = 1;
            uint num6 = 0;
            uint num7 = 0;
            if (this.bool_1)
            {
                uint num1 = Class47.uint_0[base.byte_0[index]] ^ base.byte_0[((int) index) + 1];
                num6 = num1 & 0x3ff;
                long num21 = num1 ^ (base.byte_0[(int) (index + 2)] << 8);
                num7 = (uint) (num21 & 0xffff);
                num8 = (((uint) num21) ^ (Class47.uint_0[base.byte_0[(int) (index + 3)]] << 5)) & this.uint_19;
            }
            else
            {
                num8 = (uint) (base.byte_0[index] ^ (base.byte_0[(int) (index + 1)] << 8));
            }
            uint num9 = this.uint_18[this.uint_23 + num8];
            if (this.bool_1)
            {
                uint num10 = this.uint_18[num6];
                uint num11 = this.uint_18[0x400 + ((int) num7)];
                this.uint_18[num6] = base.uint_5;
                this.uint_18[0x400 + ((int) num7)] = base.uint_5;
                if ((num10 > num3) && (base.byte_0[base.uint_1 + num10] == base.byte_0[index]))
                {
                    num5 = 2;
                    uint_26[num2++] = 2;
                    uint_26[num2++] = (base.uint_5 - num10) - 1;
                }
                if ((num11 > num3) && (base.byte_0[base.uint_1 + num11] == base.byte_0[index]))
                {
                    if (num11 == num10)
                    {
                        num2 -= 2;
                    }
                    num5 = 3;
                    uint_26[num2++] = 3;
                    uint_26[num2++] = (base.uint_5 - num11) - 1;
                    num10 = num11;
                }
                if ((num2 != 0) && (num10 == num9))
                {
                    num2 -= 2;
                    num5 = 1;
                }
            }
            this.uint_18[this.uint_23 + num8] = base.uint_5;
            uint num12 = (this.uint_16 << 1) + 1;
            uint num13 = this.uint_16 << 1;
            uint num15 = num14 = this.uint_25;
            if (((this.uint_25 != 0) && (num9 > num3)) && (base.byte_0[(base.uint_1 + num9) + this.uint_25] != base.byte_0[index + this.uint_25]))
            {
                uint_26[num2++] = num5 = this.uint_25;
                uint_26[num2++] = (base.uint_5 - num9) - 1;
            }
            uint num16 = this.uint_15;
            while ((num9 > num3) && (num16-- != 0))
            {
                uint num17 = base.uint_5 - num9;
                uint num18 = ((num17 <= this.uint_16) ? (this.uint_16 - num17) : ((this.uint_16 - num17) + this.uint_17)) << 1;
                uint num19 = base.uint_1 + num9;
                uint num20 = Math.Min(num15, num14);
                if (base.byte_0[num19 + num20] == base.byte_0[index + num20])
                {
                    while (++num20 != num)
                    {
                        if (base.byte_0[num19 + num20] != base.byte_0[index + num20])
                        {
                            break;
                        }
                    }
                    if (num5 < num20)
                    {
                        uint_26[num2++] = num5 = num20;
                        uint_26[num2++] = num17 - 1;
                        if (num20 == num)
                        {
                            this.uint_22[num13] = this.uint_22[num18];
                            this.uint_22[num12] = this.uint_22[((int) num18) + 1];
                            goto Label_03CF;
                        }
                    }
                }
                if (base.byte_0[num19 + num20] < base.byte_0[index + num20])
                {
                    this.uint_22[num13] = num9;
                    num13 = num18 + 1;
                    num9 = this.uint_22[num13];
                    num14 = num20;
                }
                else
                {
                    this.uint_22[num12] = num9;
                    num12 = num18;
                    num9 = this.uint_22[num12];
                    num15 = num20;
                }
            }
            this.uint_22[num13] = 0;
            this.uint_22[num12] = 0;
        Label_03CF:
            this.method_12();
            return num2;
        }

        public void imethod_8(uint uint_26)
        {
            uint num;
            uint num6;
            uint num10;
        Label_0000:
            if ((base.uint_5 + this.uint_21) <= base.uint_7)
            {
                num = this.uint_21;
            }
            else
            {
                num = base.uint_7 - base.uint_5;
                if (num < this.uint_24)
                {
                    this.method_12();
                    goto Label_0294;
                }
            }
            uint num2 = (base.uint_5 > this.uint_17) ? (base.uint_5 - this.uint_17) : 0;
            uint index = base.uint_1 + base.uint_5;
            if (this.bool_1)
            {
                uint num1 = Class47.uint_0[base.byte_0[index]] ^ base.byte_0[((int) index) + 1];
                uint num4 = num1 & 0x3ff;
                this.uint_18[num4] = base.uint_5;
                long num17 = num1 ^ (base.byte_0[(int) (index + 2)] << 8);
                uint num5 = (uint) (num17 & 0xffff);
                this.uint_18[0x400 + ((int) num5)] = base.uint_5;
                num6 = (((uint) num17) ^ (Class47.uint_0[base.byte_0[(int) (index + 3)]] << 5)) & this.uint_19;
            }
            else
            {
                num6 = (uint) (base.byte_0[index] ^ (base.byte_0[(int) (index + 1)] << 8));
            }
            uint num7 = this.uint_18[this.uint_23 + num6];
            this.uint_18[this.uint_23 + num6] = base.uint_5;
            uint num8 = (this.uint_16 << 1) + 1;
            uint num9 = this.uint_16 << 1;
            uint num11 = num10 = this.uint_25;
            uint num12 = this.uint_15;
            while ((num7 > num2) && (num12-- != 0))
            {
                uint num13 = base.uint_5 - num7;
                uint num14 = ((num13 <= this.uint_16) ? (this.uint_16 - num13) : ((this.uint_16 - num13) + this.uint_17)) << 1;
                uint num15 = base.uint_1 + num7;
                uint num16 = Math.Min(num11, num10);
                if (base.byte_0[num15 + num16] == base.byte_0[index + num16])
                {
                    while (++num16 != num)
                    {
                        if (base.byte_0[num15 + num16] != base.byte_0[index + num16])
                        {
                            break;
                        }
                    }
                    if (num16 == num)
                    {
                        this.uint_22[num9] = this.uint_22[num14];
                        this.uint_22[num8] = this.uint_22[((int) num14) + 1];
                        goto Label_028E;
                    }
                }
                if (base.byte_0[num15 + num16] < base.byte_0[index + num16])
                {
                    this.uint_22[num9] = num7;
                    num9 = num14 + 1;
                    num7 = this.uint_22[num9];
                    num10 = num16;
                }
                else
                {
                    this.uint_22[num8] = num7;
                    num8 = num14;
                    num7 = this.uint_22[num8];
                    num11 = num16;
                }
            }
            this.uint_22[num9] = 0;
            this.uint_22[num8] = 0;
        Label_028E:
            this.method_12();
        Label_0294:
            if (--uint_26 != 0)
            {
                goto Label_0000;
            }
        }

        public void method_11(int int_0)
        {
            this.bool_1 = int_0 > 2;
            if (this.bool_1)
            {
                this.uint_25 = 0;
                this.uint_24 = 4;
                this.uint_23 = 0x10400;
            }
            else
            {
                this.uint_25 = 2;
                this.uint_24 = 3;
                this.uint_23 = 0;
            }
        }

        public void method_12()
        {
            uint num = this.uint_16 + 1;
            this.uint_16 = num;
            if (num >= this.uint_17)
            {
                this.uint_16 = 0;
            }
            base.method_6();
            if (base.uint_5 == 0x7fffffff)
            {
                this.method_14();
            }
        }

        private void method_13(uint[] uint_26, uint uint_27, uint uint_28)
        {
            for (uint i = 0; i < uint_27; i++)
            {
                uint num2 = uint_26[i];
                if (num2 <= uint_28)
                {
                    num2 = 0;
                }
                else
                {
                    num2 -= uint_28;
                }
                uint_26[i] = num2;
            }
        }

        private void method_14()
        {
            uint num = base.uint_5 - this.uint_17;
            this.method_13(this.uint_22, this.uint_17 * 2, num);
            this.method_13(this.uint_18, this.uint_20, num);
            base.method_10((int) num);
        }

        public void method_15(uint uint_26)
        {
            this.uint_15 = uint_26;
        }
    }
}

