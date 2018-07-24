namespace ns9
{
    using ns11;
    using System;
    using System.IO;
    using System.Runtime.InteropServices;

    internal class Class51 : Interface2, Interface5
    {
        private Class52 class52_0 = new Class52();
        private Class52 class52_1 = new Class52();
        private Class53 class53_0 = new Class53();
        private Class60 class60_0 = new Class60();
        private Class62 class62_0 = new Class62();
        private Struct12[] struct12_0 = new Struct12[0xc0];
        private Struct12[] struct12_1 = new Struct12[12];
        private Struct12[] struct12_2 = new Struct12[12];
        private Struct12[] struct12_3 = new Struct12[12];
        private Struct12[] struct12_4 = new Struct12[12];
        private Struct12[] struct12_5 = new Struct12[0xc0];
        private Struct12[] struct12_6 = new Struct12[0x72];
        private Struct14[] struct14_0 = new Struct14[4];
        private Struct14 struct14_1 = new Struct14(4);
        private uint uint_0 = uint.MaxValue;
        private uint uint_1;
        private uint uint_2;

        public Class51()
        {
            for (int i = 0; i < 4L; i++)
            {
                this.struct14_0[i] = new Struct14(6);
            }
        }

        public void imethod_0(Stream stream_0, Stream stream_1, long long_0, long long_1, Interface1 interface1_0)
        {
            this.method_3(stream_0, stream_1);
            Class50.Struct8 struct2 = new Class50.Struct8();
            struct2.method_0();
            uint num = 0;
            uint num2 = 0;
            uint num3 = 0;
            uint num4 = 0;
            ulong num5 = 0L;
            ulong num6 = (ulong) long_1;
            if (0L < num6)
            {
                if (this.struct12_0[struct2.uint_0 << 4].method_2(this.class62_0) != 0)
                {
                    throw new Exception0();
                }
                struct2.method_1();
                byte num7 = this.class53_0.method_3(this.class62_0, 0, 0);
                this.class60_0.method_6(num7);
                num5 += (ulong) 1L;
            }
            while (num5 < num6)
            {
                uint num11;
                uint num12;
                uint num8 = ((uint) num5) & this.uint_2;
                if (this.struct12_0[(struct2.uint_0 << 4) + num8].method_2(this.class62_0) == 0)
                {
                    byte num9;
                    byte num10 = this.class60_0.method_7(0);
                    if (!struct2.method_5())
                    {
                        num9 = this.class53_0.method_4(this.class62_0, (uint) num5, num10, this.class60_0.method_7(num));
                    }
                    else
                    {
                        num9 = this.class53_0.method_3(this.class62_0, (uint) num5, num10);
                    }
                    this.class60_0.method_6(num9);
                    struct2.method_1();
                    num5 += (ulong) 1L;
                    continue;
                }
                if (this.struct12_1[struct2.uint_0].method_2(this.class62_0) != 1)
                {
                    goto Label_025A;
                }
                if (this.struct12_2[struct2.uint_0].method_2(this.class62_0) == 0)
                {
                    if (this.struct12_5[(struct2.uint_0 << 4) + num8].method_2(this.class62_0) != 0)
                    {
                        goto Label_0237;
                    }
                    struct2.method_4();
                    this.class60_0.method_6(this.class60_0.method_7(num));
                    num5 += (ulong) 1L;
                    continue;
                }
                if (this.struct12_3[struct2.uint_0].method_2(this.class62_0) == 0)
                {
                    num12 = num2;
                }
                else
                {
                    if (this.struct12_4[struct2.uint_0].method_2(this.class62_0) == 0)
                    {
                        num12 = num3;
                    }
                    else
                    {
                        num12 = num4;
                        num4 = num3;
                    }
                    num3 = num2;
                }
                num2 = num;
                num = num12;
            Label_0237:
                num11 = this.class52_1.method_2(this.class62_0, num8) + 2;
                struct2.method_3();
                goto Label_0309;
            Label_025A:
                num4 = num3;
                num3 = num2;
                num2 = num;
                num11 = 2 + this.class52_0.method_2(this.class62_0, num8);
                struct2.method_2();
                uint num13 = this.struct14_0[Class50.smethod_0(num11)].method_1(this.class62_0);
                if (num13 >= 4)
                {
                    int num14 = ((int) (num13 >> 1)) - 1;
                    num = (uint) ((2 | (num13 & 1)) << (num14 & 0x1f));
                    if (num13 < 14)
                    {
                        num += Struct14.smethod_0(this.struct12_6, (num - num13) - 1, this.class62_0, num14);
                    }
                    else
                    {
                        num += this.class62_0.method_7(num14 - 4) << 4;
                        num += this.struct14_1.method_2(this.class62_0);
                    }
                }
                else
                {
                    num = num13;
                }
            Label_0309:
                if ((num >= num5) || (num >= this.uint_1))
                {
                    if (num != uint.MaxValue)
                    {
                        throw new Exception0();
                    }
                    break;
                }
                this.class60_0.method_5(num, num11);
                num5 += num11;
            }
            this.class60_0.method_4();
            this.class60_0.method_3();
            this.class62_0.method_1();
        }

        public void imethod_1(byte[] byte_0)
        {
            if (byte_0.Length < 5)
            {
                throw new Exception1();
            }
            int num = byte_0[0] % 9;
            int num1 = byte_0[0] / 9;
            int num2 = num1 % 5;
            int num3 = num1 / 5;
            if (num3 > 4)
            {
                throw new Exception1();
            }
            uint num4 = 0;
            for (int i = 0; i < 4; i++)
            {
                num4 += (uint) (byte_0[1 + i] << (i * 8));
            }
            this.method_0(num4);
            this.method_1(num2, num);
            this.method_2(num3);
        }

        private void method_0(uint uint_3)
        {
            if (this.uint_0 != uint_3)
            {
                this.uint_0 = uint_3;
                this.uint_1 = Math.Max(this.uint_0, 1);
                uint num = Math.Max(this.uint_1, 0x1000);
                this.class60_0.method_0(num);
            }
        }

        private void method_1(int int_0, int int_1)
        {
            if (int_0 > 8)
            {
                throw new Exception1();
            }
            if (int_1 > 8)
            {
                throw new Exception1();
            }
            this.class53_0.method_0(int_0, int_1);
        }

        private void method_2(int int_0)
        {
            if (int_0 > 4)
            {
                throw new Exception1();
            }
            uint num = ((uint) 1) << int_0;
            this.class52_0.method_0(num);
            this.class52_1.method_0(num);
            this.uint_2 = num - 1;
        }

        private void method_3(Stream stream_0, Stream stream_1)
        {
            uint num;
            this.class62_0.method_0(stream_0);
            this.class60_0.method_2(stream_1);
            for (num = 0; num < 12; num++)
            {
                for (uint i = 0; i <= this.uint_2; i++)
                {
                    uint index = (num << 4) + i;
                    this.struct12_0[index].method_1();
                    this.struct12_5[index].method_1();
                }
                this.struct12_1[num].method_1();
                this.struct12_2[num].method_1();
                this.struct12_3[num].method_1();
                this.struct12_4[num].method_1();
            }
            this.class53_0.method_1();
            for (num = 0; num < 4; num++)
            {
                this.struct14_0[num].method_0();
            }
            for (num = 0; num < 0x72; num++)
            {
                this.struct12_6[num].method_1();
            }
            this.class52_0.method_1();
            this.class52_1.method_1();
            this.struct14_1.method_0();
        }

        private class Class52
        {
            private Struct12 struct12_0;
            private Struct12 struct12_1;
            private Struct14[] struct14_0 = new Struct14[0x10];
            private Struct14[] struct14_1 = new Struct14[0x10];
            private Struct14 struct14_2 = new Struct14(8);
            private uint uint_0;

            public void method_0(uint uint_1)
            {
                for (uint i = this.uint_0; i < uint_1; i++)
                {
                    this.struct14_0[i] = new Struct14(3);
                    this.struct14_1[i] = new Struct14(3);
                }
                this.uint_0 = uint_1;
            }

            public void method_1()
            {
                this.struct12_0.method_1();
                for (uint i = 0; i < this.uint_0; i++)
                {
                    this.struct14_0[i].method_0();
                    this.struct14_1[i].method_0();
                }
                this.struct12_1.method_1();
                this.struct14_2.method_0();
            }

            public uint method_2(Class62 class62_0, uint uint_1)
            {
                if (this.struct12_0.method_2(class62_0) == 0)
                {
                    return this.struct14_0[uint_1].method_1(class62_0);
                }
                uint num = 8;
                if (this.struct12_1.method_2(class62_0) == 0)
                {
                    return (num + this.struct14_1[uint_1].method_1(class62_0));
                }
                num += 8;
                return (num + this.struct14_2.method_1(class62_0));
            }
        }

        internal class Class53
        {
            private int int_0;
            private int int_1;
            private Struct9[] struct9_0;
            private uint uint_0;

            public void method_0(int int_2, int int_3)
            {
                if (((this.struct9_0 == null) || (this.int_0 != int_3)) || (this.int_1 != int_2))
                {
                    this.int_1 = int_2;
                    this.uint_0 = (uint) ((((int) 1) << int_2) - 1);
                    this.int_0 = int_3;
                    uint num = ((uint) 1) << (this.int_0 + this.int_1);
                    this.struct9_0 = new Struct9[num];
                    for (uint i = 0; i < num; i++)
                    {
                        this.struct9_0[i].method_0();
                    }
                }
            }

            public void method_1()
            {
                uint num = ((uint) 1) << (this.int_0 + this.int_1);
                for (uint i = 0; i < num; i++)
                {
                    this.struct9_0[i].method_1();
                }
            }

            private uint method_2(uint uint_1, byte byte_0)
            {
                return (((uint_1 & this.uint_0) << this.int_0) + ((uint) (byte_0 >> (8 - this.int_0))));
            }

            public byte method_3(Class62 class62_0, uint uint_1, byte byte_0)
            {
                return this.struct9_0[this.method_2(uint_1, byte_0)].method_2(class62_0);
            }

            public byte method_4(Class62 class62_0, uint uint_1, byte byte_0, byte byte_1)
            {
                return this.struct9_0[this.method_2(uint_1, byte_0)].method_3(class62_0, byte_1);
            }

            [StructLayout(LayoutKind.Sequential)]
            private struct Struct9
            {
                private Struct12[] struct12_0;
                public void method_0()
                {
                    this.struct12_0 = new Struct12[0x300];
                }

                public void method_1()
                {
                    for (int i = 0; i < 0x300; i++)
                    {
                        this.struct12_0[i].method_1();
                    }
                }

                public byte method_2(Class62 class62_0)
                {
                    uint index = 1;
                    do
                    {
                        index = (index << 1) | this.struct12_0[index].method_2(class62_0);
                    }
                    while (index < 0x100);
                    return (byte) index;
                }

                public byte method_3(Class62 class62_0, byte byte_0)
                {
                    uint num2;
                    uint index = 1;
                Label_000C:
                    num2 = (uint) ((byte_0 >> 7) & 1);
                    byte_0 = (byte) (byte_0 << 1);
                    uint num3 = this.struct12_0[(int) (((1 + num2) << 8) + index)].method_2(class62_0);
                    index = (index << 1) | num3;
                    if (num2 == num3)
                    {
                        if (index >= 0x100)
                        {
                            goto Label_005C;
                        }
                        goto Label_000C;
                    }
                    while (index < 0x100)
                    {
                        index = (index << 1) | this.struct12_0[index].method_2(class62_0);
                    }
                Label_005C:
                    return (byte) index;
                }
            }
        }
    }
}

