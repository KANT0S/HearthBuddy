namespace ns9
{
    using ns10;
    using ns11;
    using System;
    using System.IO;
    using System.Runtime.InteropServices;

    internal class Class54 : Interface2, Interface3, Interface4
    {
        private bool bool_0;
        private bool bool_1;
        private bool bool_2;
        private bool bool_3;
        private static readonly byte[] byte_0 = new byte[0x800];
        private readonly byte[] byte_1 = new byte[5];
        private byte byte_2;
        private readonly Class56 class56_0 = new Class56();
        private readonly Class56 class56_1 = new Class56();
        private readonly Class57 class57_0 = new Class57();
        private readonly Class58[] class58_0 = new Class58[0x1000];
        private readonly Class61 class61_0 = new Class61();
        private Enum6 enum6_0 = Enum6.const_1;
        private const int int_0 = 0x16;
        private const int int_1 = 5;
        private int int_2 = 3;
        private int int_3;
        private int int_4 = 2;
        private Interface7 interface7_0;
        private long long_0;
        private Stream stream_0;
        private static readonly string[] string_0 = new string[] { "BT2", "BT4" };
        private readonly Struct11[] struct11_0 = new Struct11[0xc0];
        private readonly Struct11[] struct11_1 = new Struct11[12];
        private readonly Struct11[] struct11_2 = new Struct11[0xc0];
        private readonly Struct11[] struct11_3 = new Struct11[12];
        private readonly Struct11[] struct11_4 = new Struct11[12];
        private readonly Struct11[] struct11_5 = new Struct11[12];
        private readonly Struct11[] struct11_6 = new Struct11[0x72];
        private readonly Struct13[] struct13_0 = new Struct13[4];
        private Struct13 struct13_1 = new Struct13(4);
        private Class50.Struct8 struct8_0;
        private const uint uint_0 = 0xfffffff;
        private const uint uint_1 = 0x20;
        private readonly uint[] uint_10 = new uint[4];
        private readonly uint[] uint_11 = new uint[0x80];
        private uint uint_12;
        private uint uint_13;
        private uint uint_14 = 0x400000;
        private uint uint_15 = uint.MaxValue;
        private uint uint_16 = 0x2c;
        private uint uint_17;
        private uint uint_18;
        private uint uint_19;
        private const uint uint_2 = 0x10;
        private uint uint_20 = 0x20;
        private uint uint_21 = uint.MaxValue;
        private uint uint_22;
        private uint uint_23;
        private uint uint_24 = 3;
        private const uint uint_3 = 0x1000;
        private readonly uint[] uint_4 = new uint[0x10];
        private readonly uint[] uint_5 = new uint[0x200];
        private readonly uint[] uint_6 = new uint[0x224];
        private readonly uint[] uint_7 = new uint[0x100];
        private readonly uint[] uint_8 = new uint[4];
        private readonly uint[] uint_9 = new uint[4];

        static Class54()
        {
            int index = 2;
            byte_0[0] = 0;
            byte_0[1] = 1;
            for (byte i = 2; i < 0x16; i = (byte) (i + 1))
            {
                uint num3 = ((uint) 1) << ((i >> 1) - 1);
                uint num4 = 0;
                while (num4 < num3)
                {
                    byte_0[index] = i;
                    num4++;
                    index++;
                }
            }
        }

        public Class54()
        {
            for (int i = 0; i < 0x1000L; i++)
            {
                this.class58_0[i] = new Class58();
            }
            for (int j = 0; j < 4L; j++)
            {
                this.struct13_0[j] = new Struct13(6);
            }
        }

        public void imethod_0(Stream stream_1, Stream stream_2, long long_1, long long_2, Interface1 interface1_0)
        {
            this.bool_2 = false;
            try
            {
                long num;
                long num2;
                bool flag;
                this.method_20(stream_1, stream_2, long_1, long_2);
                goto Label_0021;
            Label_0014:
                if (interface1_0 != null)
                {
                    interface1_0.imethod_0(num, num2);
                }
            Label_0021:
                this.method_15(out num, out num2, out flag);
                if (!flag)
                {
                    goto Label_0014;
                }
            }
            finally
            {
                this.method_19();
            }
        }

        public void imethod_1(Enum5[] enum5_0, object[] object_0)
        {
            for (uint i = 0; i < object_0.Length; i++)
            {
                int num4;
                int num5;
                object obj2 = object_0[i];
                switch (enum5_0[i])
                {
                    case Enum5.const_1:
                        if (!(obj2 is int))
                        {
                            throw new Exception1();
                        }
                        num4 = (int) obj2;
                        if ((num4 < 1L) || (num4 > 0x40000000L))
                        {
                            throw new Exception1();
                        }
                        this.uint_14 = (uint) num4;
                        num5 = 0;
                        goto Label_00A9;

                    case Enum5.const_5:
                    {
                        if (!(obj2 is int))
                        {
                            throw new Exception1();
                        }
                        int num6 = (int) obj2;
                        if ((num6 < 0) || (num6 > 4L))
                        {
                            throw new Exception1();
                        }
                        this.int_4 = num6;
                        this.uint_24 = (uint) ((((int) 1) << this.int_4) - 1);
                        continue;
                    }
                    case Enum5.const_6:
                    {
                        if (!(obj2 is int))
                        {
                            throw new Exception1();
                        }
                        int num8 = (int) obj2;
                        if ((num8 < 0) || (num8 > 8L))
                        {
                            throw new Exception1();
                        }
                        this.int_2 = num8;
                        continue;
                    }
                    case Enum5.const_7:
                    {
                        if (!(obj2 is int))
                        {
                            throw new Exception1();
                        }
                        int num7 = (int) obj2;
                        if ((num7 < 0) || (num7 > 4L))
                        {
                            throw new Exception1();
                        }
                        this.int_3 = num7;
                        continue;
                    }
                    case Enum5.const_8:
                    {
                        if (!(obj2 is int))
                        {
                            throw new Exception1();
                        }
                        int num2 = (int) obj2;
                        if ((num2 < 5) || (num2 > 0x111L))
                        {
                            throw new Exception1();
                        }
                        this.uint_20 = (uint) num2;
                        continue;
                    }
                    case Enum5.const_9:
                    {
                        if (!(obj2 is string))
                        {
                            throw new Exception1();
                        }
                        Enum6 enum3 = this.enum6_0;
                        int num3 = smethod_2(((string) obj2).ToUpper());
                        if (num3 < 0)
                        {
                            throw new Exception1();
                        }
                        this.enum6_0 = (Enum6) num3;
                        if ((this.interface7_0 != null) && (enum3 != this.enum6_0))
                        {
                            this.uint_15 = uint.MaxValue;
                            this.interface7_0 = null;
                        }
                        continue;
                    }
                    case Enum5.const_12:
                    {
                        continue;
                    }
                    case Enum5.const_14:
                    {
                        if (!(obj2 is bool))
                        {
                            throw new Exception1();
                        }
                        this.method_2((bool) obj2);
                        continue;
                    }
                    default:
                        throw new Exception1();
                }
            Label_0096:
                if (num4 <= (((uint) 1) << num5))
                {
                    goto Label_00B7;
                }
                num5++;
            Label_00A9:
                if (num5 < 30L)
                {
                    goto Label_0096;
                }
            Label_00B7:
                this.uint_16 = (uint) (num5 * 2);
            }
        }

        public void imethod_2(Stream stream_1)
        {
            this.byte_1[0] = (byte) ((((this.int_4 * 5) + this.int_3) * 9) + this.int_2);
            for (int i = 0; i < 4; i++)
            {
                this.byte_1[1 + i] = (byte) (this.uint_14 >> (8 * i));
            }
            stream_1.Write(this.byte_1, 0, 5);
        }

        private void method_0()
        {
            this.struct8_0.method_0();
            this.byte_2 = 0;
            for (uint i = 0; i < 4; i++)
            {
                this.uint_8[i] = 0;
            }
        }

        private void method_1()
        {
            if (this.interface7_0 == null)
            {
                Class49 class2 = new Class49();
                int num = 4;
                if (this.enum6_0 == Enum6.const_0)
                {
                    num = 2;
                }
                class2.method_11(num);
                this.interface7_0 = class2;
            }
            this.class57_0.method_0(this.int_3, this.int_2);
            if ((this.uint_14 != this.uint_15) || (this.uint_21 != this.uint_20))
            {
                this.interface7_0.imethod_6(this.uint_14, 0x1000, this.uint_20, 0x112);
                this.uint_15 = this.uint_14;
                this.uint_21 = this.uint_20;
            }
        }

        private uint method_10(out uint uint_25, uint uint_26)
        {
            this.uint_23 = uint_26;
            uint index = this.class58_0[uint_26].uint_6;
            uint num2 = this.class58_0[uint_26].uint_0;
            while (true)
            {
                if (this.class58_0[uint_26].bool_0)
                {
                    this.class58_0[index].method_0();
                    this.class58_0[index].uint_6 = index - 1;
                    if (this.class58_0[uint_26].bool_1)
                    {
                        this.class58_0[((int) index) - 1].bool_0 = false;
                        this.class58_0[((int) index) - 1].uint_6 = this.class58_0[uint_26].uint_7;
                        this.class58_0[((int) index) - 1].uint_0 = this.class58_0[uint_26].uint_1;
                    }
                }
                uint num3 = index;
                uint num4 = num2;
                num2 = this.class58_0[num3].uint_0;
                index = this.class58_0[num3].uint_6;
                this.class58_0[num3].uint_0 = num4;
                this.class58_0[num3].uint_6 = uint_26;
                uint_26 = num3;
                if (uint_26 <= 0)
                {
                    uint_25 = this.class58_0[0].uint_0;
                    this.uint_22 = this.class58_0[0].uint_6;
                    return this.uint_22;
                }
            }
        }

        private uint method_11(uint uint_25, out uint uint_26)
        {
            uint num;
            uint num2;
            uint num5;
            if (this.uint_23 != this.uint_22)
            {
                uint_26 = this.class58_0[this.uint_22].uint_0;
                this.uint_22 = this.class58_0[this.uint_22].uint_6;
                return (this.class58_0[this.uint_22].uint_6 - this.uint_22);
            }
            this.uint_23 = 0;
            this.uint_22 = 0;
            if (!this.bool_1)
            {
                this.method_4(out num, out num2);
            }
            else
            {
                num = this.uint_17;
                num2 = this.uint_19;
                this.bool_1 = false;
            }
            uint num3 = this.interface7_0.imethod_5() + 1;
            if (num3 < 2)
            {
                uint_26 = uint.MaxValue;
                return 1;
            }
            if (num3 > 0x111)
            {
                num3 = 0x111;
            }
            uint index = 0;
            for (num5 = 0; num5 < 4; num5++)
            {
                this.uint_10[num5] = this.uint_8[num5];
                this.uint_9[num5] = this.interface7_0.imethod_4(-1, this.uint_10[num5], 0x111);
                if (this.uint_9[num5] > this.uint_9[index])
                {
                    index = num5;
                }
            }
            if (this.uint_9[index] >= this.uint_20)
            {
                uint_26 = index;
                uint num6 = this.uint_9[index];
                this.method_5(num6 - 1);
                return num6;
            }
            if (num >= this.uint_20)
            {
                uint_26 = this.uint_6[((int) num2) - 1] + 4;
                this.method_5(num - 1);
                return num;
            }
            byte num7 = this.interface7_0.imethod_3(-1);
            byte num8 = this.interface7_0.imethod_3(((0 - ((int) this.uint_8[0])) - 1) - 1);
            if (((num < 2) && (num7 != num8)) && (this.uint_9[index] < 2))
            {
                uint_26 = uint.MaxValue;
                return 1;
            }
            this.class58_0[0].struct8_0 = this.struct8_0;
            uint num9 = uint_25 & this.uint_24;
            this.class58_0[1].uint_8 = this.struct11_0[(this.struct8_0.uint_0 << 4) + num9].method_4() + this.class57_0.method_2(uint_25, this.byte_2).method_4(!this.struct8_0.method_5(), num8, num7);
            this.class58_0[1].method_0();
            uint num10 = this.struct11_0[(this.struct8_0.uint_0 << 4) + num9].method_5();
            uint num11 = num10 + this.struct11_1[this.struct8_0.uint_0].method_5();
            if (num8 == num7)
            {
                uint num12 = num11 + this.method_6(this.struct8_0, num9);
                if (num12 < this.class58_0[1].uint_8)
                {
                    this.class58_0[1].uint_8 = num12;
                    this.class58_0[1].method_1();
                }
            }
            uint num13 = (num >= this.uint_9[index]) ? num : this.uint_9[index];
            if (num13 < 2)
            {
                uint_26 = this.class58_0[1].uint_0;
                return 1;
            }
            this.class58_0[1].uint_6 = 0;
            this.class58_0[0].uint_2 = this.uint_10[0];
            this.class58_0[0].uint_3 = this.uint_10[1];
            this.class58_0[0].uint_4 = this.uint_10[2];
            this.class58_0[0].uint_5 = this.uint_10[3];
            uint num14 = num13;
            do
            {
                this.class58_0[num14--].uint_8 = 0xfffffff;
            }
            while (num14 >= 2);
            for (num5 = 0; num5 < 4; num5++)
            {
                uint num17;
                Class58 class2;
                uint num15 = this.uint_9[num5];
                if (num15 < 2)
                {
                    continue;
                }
                uint num16 = num11 + this.method_7(num5, this.struct8_0, num9);
                goto Label_03B9;
            Label_0389:
                if (--num15 >= 2)
                {
                    goto Label_03B9;
                }
                continue;
            Label_0395:
                class2.uint_8 = num17;
                class2.uint_6 = 0;
                class2.uint_0 = num5;
                class2.bool_0 = false;
                goto Label_0389;
            Label_03B9:
                num17 = num16 + this.class56_1.method_4(num15 - 2, num9);
                class2 = this.class58_0[num15];
                if (num17 >= class2.uint_8)
                {
                    goto Label_0389;
                }
                goto Label_0395;
            }
            uint num18 = num10 + this.struct11_1[this.struct8_0.uint_0].method_4();
            num14 = (this.uint_9[0] >= 2) ? (this.uint_9[0] + 1) : 2;
            if (num14 <= num)
            {
                uint num19 = 0;
                while (num14 > this.uint_6[num19])
                {
                    num19 += 2;
                }
                while (true)
                {
                    uint num20 = this.uint_6[((int) num19) + 1];
                    uint num21 = num18 + this.method_9(num20, num14, num9);
                    Class58 class3 = this.class58_0[num14];
                    if (num21 < class3.uint_8)
                    {
                        class3.uint_8 = num21;
                        class3.uint_6 = 0;
                        class3.uint_0 = num20 + 4;
                        class3.bool_0 = false;
                    }
                    if (num14 == this.uint_6[num19])
                    {
                        num19 += 2;
                        if (num19 == num2)
                        {
                            break;
                        }
                    }
                    num14++;
                }
            }
            uint num22 = 0;
        Label_0FD3:
            num22++;
            if (num22 != num13)
            {
                uint num23;
                Class50.Struct8 struct3;
                uint num46;
                this.method_4(out num23, out num2);
                if (num23 >= this.uint_20)
                {
                    this.uint_19 = num2;
                    this.uint_17 = num23;
                    this.bool_1 = true;
                    return this.method_10(out uint_26, num22);
                }
                uint_25++;
                uint num24 = this.class58_0[num22].uint_6;
                if (this.class58_0[num22].bool_0)
                {
                    num24--;
                    if (this.class58_0[num22].bool_1)
                    {
                        struct3 = this.class58_0[this.class58_0[num22].uint_7].struct8_0;
                        if (this.class58_0[num22].uint_1 < 4)
                        {
                            struct3.method_3();
                        }
                        else
                        {
                            struct3.method_2();
                        }
                    }
                    else
                    {
                        struct3 = this.class58_0[num24].struct8_0;
                    }
                    struct3.method_1();
                }
                else
                {
                    struct3 = this.class58_0[num24].struct8_0;
                }
                if (num24 == (num22 - 1))
                {
                    if (this.class58_0[num22].method_2())
                    {
                        struct3.method_4();
                    }
                    else
                    {
                        struct3.method_1();
                    }
                }
                else
                {
                    uint num25;
                    if (this.class58_0[num22].bool_0 && this.class58_0[num22].bool_1)
                    {
                        num24 = this.class58_0[num22].uint_7;
                        num25 = this.class58_0[num22].uint_1;
                        struct3.method_3();
                    }
                    else
                    {
                        num25 = this.class58_0[num22].uint_0;
                        if (num25 < 4)
                        {
                            struct3.method_3();
                        }
                        else
                        {
                            struct3.method_2();
                        }
                    }
                    Class58 class4 = this.class58_0[num24];
                    if (num25 < 4)
                    {
                        if (num25 == 0)
                        {
                            this.uint_10[0] = class4.uint_2;
                            this.uint_10[1] = class4.uint_3;
                            this.uint_10[2] = class4.uint_4;
                            this.uint_10[3] = class4.uint_5;
                        }
                        else if (num25 == 1)
                        {
                            this.uint_10[0] = class4.uint_3;
                            this.uint_10[1] = class4.uint_2;
                            this.uint_10[2] = class4.uint_4;
                            this.uint_10[3] = class4.uint_5;
                        }
                        else if (num25 == 2)
                        {
                            this.uint_10[0] = class4.uint_4;
                            this.uint_10[1] = class4.uint_2;
                            this.uint_10[2] = class4.uint_3;
                            this.uint_10[3] = class4.uint_5;
                        }
                        else
                        {
                            this.uint_10[0] = class4.uint_5;
                            this.uint_10[1] = class4.uint_2;
                            this.uint_10[2] = class4.uint_3;
                            this.uint_10[3] = class4.uint_4;
                        }
                    }
                    else
                    {
                        this.uint_10[0] = num25 - 4;
                        this.uint_10[1] = class4.uint_2;
                        this.uint_10[2] = class4.uint_3;
                        this.uint_10[3] = class4.uint_4;
                    }
                }
                this.class58_0[num22].struct8_0 = struct3;
                this.class58_0[num22].uint_2 = this.uint_10[0];
                this.class58_0[num22].uint_3 = this.uint_10[1];
                this.class58_0[num22].uint_4 = this.uint_10[2];
                this.class58_0[num22].uint_5 = this.uint_10[3];
                num7 = this.interface7_0.imethod_3(-1);
                num8 = this.interface7_0.imethod_3(((0 - ((int) this.uint_10[0])) - 1) - 1);
                num9 = uint_25 & this.uint_24;
                uint num26 = (this.class58_0[num22].uint_8 + this.struct11_0[(struct3.uint_0 << 4) + num9].method_4()) + this.class57_0.method_2(uint_25, this.interface7_0.imethod_3(-2)).method_4(!struct3.method_5(), num8, num7);
                Class58 class5 = this.class58_0[((int) num22) + 1];
                bool flag = false;
                if (num26 < class5.uint_8)
                {
                    class5.uint_8 = num26;
                    class5.uint_6 = num22;
                    class5.method_0();
                    flag = true;
                }
                num10 = this.class58_0[num22].uint_8 + this.struct11_0[(struct3.uint_0 << 4) + num9].method_5();
                num11 = num10 + this.struct11_1[struct3.uint_0].method_5();
                if ((num8 == num7) && ((class5.uint_6 >= num22) || (class5.uint_0 != 0)))
                {
                    uint num27 = num11 + this.method_6(struct3, num9);
                    if (num27 <= class5.uint_8)
                    {
                        class5.uint_8 = num27;
                        class5.uint_6 = num22;
                        class5.method_1();
                        flag = true;
                    }
                }
                uint num28 = this.interface7_0.imethod_5() + 1;
                num28 = Math.Min(0xfff - num22, num28);
                num3 = num28;
                if (num3 < 2)
                {
                    goto Label_0FD3;
                }
                if (num3 > this.uint_20)
                {
                    num3 = this.uint_20;
                }
                if (!flag && (num8 != num7))
                {
                    uint num29 = Math.Min(num28 - 1, this.uint_20);
                    uint num30 = this.interface7_0.imethod_4(0, this.uint_10[0], num29);
                    if (num30 >= 2)
                    {
                        Class50.Struct8 struct4 = struct3;
                        struct4.method_1();
                        uint num31 = (uint_25 + 1) & this.uint_24;
                        uint num32 = (num26 + this.struct11_0[(struct4.uint_0 << 4) + num31].method_5()) + this.struct11_1[struct4.uint_0].method_5();
                        uint num33 = (num22 + 1) + num30;
                        while (num13 < num33)
                        {
                            this.class58_0[++num13].uint_8 = 0xfffffff;
                        }
                        uint num34 = num32 + this.method_8(0, num30, struct4, num31);
                        Class58 class6 = this.class58_0[num33];
                        if (num34 < class6.uint_8)
                        {
                            class6.uint_8 = num34;
                            class6.uint_6 = num22 + 1;
                            class6.uint_0 = 0;
                            class6.bool_0 = true;
                            class6.bool_1 = false;
                        }
                    }
                }
                uint num35 = 2;
                for (uint i = 0; i < 4; i++)
                {
                    uint num37 = this.interface7_0.imethod_4(-1, this.uint_10[i], num3);
                    if (num37 < 2)
                    {
                        continue;
                    }
                    uint num38 = num37;
                    while (num13 < (num22 + num37))
                    {
                        uint num39;
                        this.class58_0[++num13].uint_8 = 0xfffffff;
                        continue;
                    Label_0AD4:
                        num39 = num11 + this.method_8(i, num37, struct3, num9);
                        Class58 class7 = this.class58_0[num22 + num37];
                        if (num39 < class7.uint_8)
                        {
                            class7.uint_8 = num39;
                            class7.uint_6 = num22;
                            class7.uint_0 = i;
                            class7.bool_0 = false;
                        }
                        if (--num37 < 2)
                        {
                            goto Label_0B38;
                        }
                    }
                    goto Label_0AD4;
                Label_0B38:
                    num37 = num38;
                    if (i == 0)
                    {
                        num35 = num37 + 1;
                    }
                    if (num37 < num28)
                    {
                        uint num40 = Math.Min((num28 - 1) - num37, this.uint_20);
                        uint num41 = this.interface7_0.imethod_4((int) num37, this.uint_10[i], num40);
                        if (num41 >= 2)
                        {
                            Class50.Struct8 struct5 = struct3;
                            struct5.method_3();
                            uint num42 = (uint_25 + num37) & this.uint_24;
                            struct5.method_1();
                            num42 = ((uint_25 + num37) + 1) & this.uint_24;
                            uint num43 = ((((num11 + this.method_8(i, num37, struct3, num9)) + this.struct11_0[(struct5.uint_0 << 4) + num42].method_4()) + this.class57_0.method_2(uint_25 + num37, this.interface7_0.imethod_3((((int) num37) - 1) - 1)).method_4(true, this.interface7_0.imethod_3((int) ((num37 - 1) - (this.uint_10[i] + 1))), this.interface7_0.imethod_3(((int) num37) - 1))) + this.struct11_0[(struct5.uint_0 << 4) + num42].method_5()) + this.struct11_1[struct5.uint_0].method_5();
                            uint num44 = (num37 + 1) + num41;
                            while (num13 < (num22 + num44))
                            {
                                this.class58_0[++num13].uint_8 = 0xfffffff;
                            }
                            uint num45 = num43 + this.method_8(0, num41, struct5, num42);
                            Class58 class8 = this.class58_0[num22 + num44];
                            if (num45 < class8.uint_8)
                            {
                                class8.uint_8 = num45;
                                class8.uint_6 = (num22 + num37) + 1;
                                class8.uint_0 = 0;
                                class8.bool_0 = true;
                                class8.bool_1 = true;
                                class8.uint_7 = num22;
                                class8.uint_1 = i;
                            }
                        }
                    }
                }
                if (num23 > num3)
                {
                    num23 = num3;
                    num2 = 0;
                    while (num23 > this.uint_6[num2])
                    {
                        num2 += 2;
                    }
                    this.uint_6[num2] = num23;
                    num2 += 2;
                }
                if (num23 < num35)
                {
                    goto Label_0FD3;
                }
                num18 = num10 + this.struct11_1[struct3.uint_0].method_4();
                while (num13 < (num22 + num23))
                {
                    this.class58_0[++num13].uint_8 = 0xfffffff;
                }
                for (num46 = 0; num35 > this.uint_6[num46]; num46 += 2)
                {
                }
                uint num47 = num35;
                while (true)
                {
                    uint num48 = this.uint_6[((int) num46) + 1];
                    uint num49 = num18 + this.method_9(num48, num47, num9);
                    Class58 class9 = this.class58_0[num22 + num47];
                    if (num49 < class9.uint_8)
                    {
                        class9.uint_8 = num49;
                        class9.uint_6 = num22;
                        class9.uint_0 = num48 + 4;
                        class9.bool_0 = false;
                    }
                    if (num47 == this.uint_6[num46])
                    {
                        if (num47 < num28)
                        {
                            uint num50 = Math.Min((num28 - 1) - num47, this.uint_20);
                            uint num51 = this.interface7_0.imethod_4((int) num47, num48, num50);
                            if (num51 >= 2)
                            {
                                Class50.Struct8 struct6 = struct3;
                                struct6.method_2();
                                uint num52 = (uint_25 + num47) & this.uint_24;
                                struct6.method_1();
                                num52 = ((uint_25 + num47) + 1) & this.uint_24;
                                uint num53 = (((num49 + this.struct11_0[(struct6.uint_0 << 4) + num52].method_4()) + this.class57_0.method_2(uint_25 + num47, this.interface7_0.imethod_3((((int) num47) - 1) - 1)).method_4(true, this.interface7_0.imethod_3(((int) (num47 - (num48 + 1))) - 1), this.interface7_0.imethod_3(((int) num47) - 1))) + this.struct11_0[(struct6.uint_0 << 4) + num52].method_5()) + this.struct11_1[struct6.uint_0].method_5();
                                uint num54 = (num47 + 1) + num51;
                                while (num13 < (num22 + num54))
                                {
                                    this.class58_0[++num13].uint_8 = 0xfffffff;
                                }
                                num49 = num53 + this.method_8(0, num51, struct6, num52);
                                class9 = this.class58_0[num22 + num54];
                                if (num49 < class9.uint_8)
                                {
                                    class9.uint_8 = num49;
                                    class9.uint_6 = (num22 + num47) + 1;
                                    class9.uint_0 = 0;
                                    class9.bool_0 = true;
                                    class9.bool_1 = true;
                                    class9.uint_7 = num22;
                                    class9.uint_1 = num48 + 4;
                                }
                            }
                        }
                        num46 += 2;
                        if (num46 == num2)
                        {
                            goto Label_0FD3;
                        }
                    }
                    num47++;
                }
            }
            return this.method_10(out uint_26, num22);
        }

        private bool method_12(uint uint_25, uint uint_26)
        {
            return ((uint_25 < 0x2000000) && (uint_26 >= (uint_25 << 7)));
        }

        private void method_13(uint uint_25)
        {
            if (this.bool_3)
            {
                this.struct11_0[(this.struct8_0.uint_0 << 4) + uint_25].method_2(this.class61_0, 1);
                this.struct11_1[this.struct8_0.uint_0].method_2(this.class61_0, 0);
                this.struct8_0.method_2();
                this.class56_0.method_7(this.class61_0, 0, uint_25);
                uint index = Class50.smethod_0(2);
                this.struct13_0[index].method_1(this.class61_0, 0x3f);
                this.class61_0.method_8(0x3ffffff, 0x1a);
                this.struct13_1.method_2(this.class61_0, 15);
            }
        }

        private void method_14(uint uint_25)
        {
            this.method_16();
            this.method_13(uint_25 & this.uint_24);
            this.class61_0.method_3();
            this.class61_0.method_4();
        }

        public void method_15(out long long_1, out long long_2, out bool bool_4)
        {
            long num;
            uint num6;
            uint num7;
            long_1 = 0L;
            long_2 = 0L;
            bool_4 = true;
            if (this.stream_0 != null)
            {
                this.interface7_0.imethod_0(this.stream_0);
                this.interface7_0.imethod_1();
                this.bool_2 = true;
                this.stream_0 = null;
            }
            if (!this.bool_0)
            {
                this.bool_0 = true;
                num = this.long_0;
                if (this.long_0 == 0)
                {
                    uint num2;
                    uint num3;
                    if (this.interface7_0.imethod_5() == 0)
                    {
                        this.method_14((uint) this.long_0);
                        return;
                    }
                    this.method_4(out num2, out num3);
                    uint num4 = ((uint) this.long_0) & this.uint_24;
                    this.struct11_0[(this.struct8_0.uint_0 << 4) + num4].method_2(this.class61_0, 0);
                    this.struct8_0.method_1();
                    byte num5 = this.interface7_0.imethod_3(0 - ((int) this.uint_12));
                    this.class57_0.method_2((uint) this.long_0, this.byte_2).method_2(this.class61_0, num5);
                    this.byte_2 = num5;
                    this.uint_12--;
                    this.long_0 += 1L;
                }
                if (this.interface7_0.imethod_5() != 0)
                {
                    goto Label_05A3;
                }
                this.method_14((uint) this.long_0);
            }
            return;
        Label_05A3:
            num7 = this.method_11((uint) this.long_0, out num6);
            uint num8 = ((uint) this.long_0) & this.uint_24;
            uint index = (this.struct8_0.uint_0 << 4) + num8;
            if ((num7 != 1) || (num6 != uint.MaxValue))
            {
                this.struct11_0[index].method_2(this.class61_0, 1);
                if (num6 < 4)
                {
                    this.struct11_1[this.struct8_0.uint_0].method_2(this.class61_0, 1);
                    if (num6 == 0)
                    {
                        this.struct11_3[this.struct8_0.uint_0].method_2(this.class61_0, 0);
                        if (num7 == 1)
                        {
                            this.struct11_2[index].method_2(this.class61_0, 0);
                        }
                        else
                        {
                            this.struct11_2[index].method_2(this.class61_0, 1);
                        }
                    }
                    else
                    {
                        this.struct11_3[this.struct8_0.uint_0].method_2(this.class61_0, 1);
                        if (num6 == 1)
                        {
                            this.struct11_4[this.struct8_0.uint_0].method_2(this.class61_0, 0);
                        }
                        else
                        {
                            this.struct11_4[this.struct8_0.uint_0].method_2(this.class61_0, 1);
                            this.struct11_5[this.struct8_0.uint_0].method_2(this.class61_0, num6 - 2);
                        }
                    }
                    if (num7 == 1)
                    {
                        this.struct8_0.method_4();
                    }
                    else
                    {
                        this.class56_1.method_7(this.class61_0, num7 - 2, num8);
                        this.struct8_0.method_3();
                    }
                    uint num12 = this.uint_8[num6];
                    if (num6 != 0)
                    {
                        for (uint i = num6; i >= 1; i--)
                        {
                            this.uint_8[i] = this.uint_8[((int) i) - 1];
                        }
                        this.uint_8[0] = num12;
                    }
                }
                else
                {
                    this.struct11_1[this.struct8_0.uint_0].method_2(this.class61_0, 0);
                    this.struct8_0.method_2();
                    this.class56_0.method_7(this.class61_0, num7 - 2, num8);
                    num6 -= 4;
                    uint num14 = smethod_0(num6);
                    uint num15 = Class50.smethod_0(num7);
                    this.struct13_0[num15].method_1(this.class61_0, num14);
                    if (num14 >= 4)
                    {
                        int num17 = ((int) (num14 >> 1)) - 1;
                        uint num18 = (uint) ((2 | (num14 & 1)) << (num17 & 0x1f));
                        uint num19 = num6 - num18;
                        if (num14 < 14)
                        {
                            Struct13.smethod_1(this.struct11_6, (num18 - num14) - 1, this.class61_0, num17, num19);
                        }
                        else
                        {
                            this.class61_0.method_8(num19 >> 4, num17 - 4);
                            this.struct13_1.method_2(this.class61_0, num19 & 15);
                            this.uint_13++;
                        }
                    }
                    uint num16 = num6;
                    for (uint j = 3; j >= 1; j--)
                    {
                        this.uint_8[j] = this.uint_8[((int) j) - 1];
                    }
                    this.uint_8[0] = num16;
                    this.uint_18++;
                }
                this.byte_2 = this.interface7_0.imethod_3((int) ((num7 - 1) - this.uint_12));
            }
            else
            {
                this.struct11_0[index].method_2(this.class61_0, 0);
                byte num10 = this.interface7_0.imethod_3(0 - ((int) this.uint_12));
                Class57.Struct10 struct3 = this.class57_0.method_2((uint) this.long_0, this.byte_2);
                if (!this.struct8_0.method_5())
                {
                    byte num11 = this.interface7_0.imethod_3((int) (((0 - this.uint_8[0]) - 1) - this.uint_12));
                    struct3.method_3(this.class61_0, num11, num10);
                }
                else
                {
                    struct3.method_2(this.class61_0, num10);
                }
                this.byte_2 = num10;
                this.struct8_0.method_1();
            }
            this.uint_12 -= num7;
            this.long_0 += num7;
            if (this.uint_12 == 0)
            {
                if (this.uint_18 >= 0x80)
                {
                    this.method_21();
                }
                if (this.uint_13 >= 0x10)
                {
                    this.method_22();
                }
                long_1 = this.long_0;
                long_2 = this.class61_0.method_10();
                if (this.interface7_0.imethod_5() == 0)
                {
                    this.method_14((uint) this.long_0);
                    return;
                }
                if ((this.long_0 - num) >= 0x1000L)
                {
                    this.bool_0 = false;
                    bool_4 = false;
                    return;
                }
            }
            goto Label_05A3;
        }

        private void method_16()
        {
            if ((this.interface7_0 != null) && this.bool_2)
            {
                this.interface7_0.imethod_2();
                this.bool_2 = false;
            }
        }

        private void method_17(Stream stream_1)
        {
            this.class61_0.method_0(stream_1);
        }

        private void method_18()
        {
            this.class61_0.method_1();
        }

        private void method_19()
        {
            this.method_16();
            this.method_18();
        }

        private void method_2(bool bool_4)
        {
            this.bool_3 = bool_4;
        }

        private void method_20(Stream stream_1, Stream stream_2, long long_1, long long_2)
        {
            this.stream_0 = stream_1;
            this.bool_0 = false;
            this.method_1();
            this.method_17(stream_2);
            this.method_3();
            this.method_21();
            this.method_22();
            this.class56_0.method_3((this.uint_20 + 1) - 2);
            this.class56_0.method_6(((uint) 1) << this.int_4);
            this.class56_1.method_3((this.uint_20 + 1) - 2);
            this.class56_1.method_6(((uint) 1) << this.int_4);
            this.long_0 = 0L;
        }

        private void method_21()
        {
            for (uint i = 4; i < 0x80; i++)
            {
                uint num2 = smethod_0(i);
                int num3 = ((int) (num2 >> 1)) - 1;
                uint num4 = (uint) ((2 | (num2 & 1)) << (num3 & 0x1f));
                this.uint_11[i] = Struct13.smethod_0(this.struct11_6, (num4 - num2) - 1, num3, i - num4);
            }
            for (uint j = 0; j < 4; j++)
            {
                Struct13 struct2 = this.struct13_0[j];
                uint num7 = j << 6;
                uint num6 = 0;
                while (num6 < this.uint_16)
                {
                    this.uint_7[num7 + num6] = struct2.method_3(num6);
                    num6++;
                }
                for (num6 = 14; num6 < this.uint_16; num6++)
                {
                    this.uint_7[num7 + num6] += (uint) ((((num6 >> 1) - 1) - 4) << 6);
                }
                uint num8 = j * 0x80;
                uint num9 = 0;
                while (num9 < 4)
                {
                    this.uint_5[num8 + num9] = this.uint_7[num7 + num9];
                    num9++;
                }
                while (num9 < 0x80)
                {
                    this.uint_5[num8 + num9] = this.uint_7[num7 + smethod_0(num9)] + this.uint_11[num9];
                    num9++;
                }
            }
            this.uint_18 = 0;
        }

        private void method_22()
        {
            for (uint i = 0; i < 0x10; i++)
            {
                this.uint_4[i] = this.struct13_1.method_4(i);
            }
            this.uint_13 = 0;
        }

        private void method_3()
        {
            uint num;
            this.method_0();
            this.class61_0.method_2();
            for (num = 0; num < 12; num++)
            {
                for (uint i = 0; i <= this.uint_24; i++)
                {
                    uint index = (num << 4) + i;
                    this.struct11_0[index].method_0();
                    this.struct11_2[index].method_0();
                }
                this.struct11_1[num].method_0();
                this.struct11_3[num].method_0();
                this.struct11_4[num].method_0();
                this.struct11_5[num].method_0();
            }
            this.class57_0.method_1();
            for (num = 0; num < 4; num++)
            {
                this.struct13_0[num].method_0();
            }
            for (num = 0; num < 0x72; num++)
            {
                this.struct11_6[num].method_0();
            }
            this.class56_0.method_0(((uint) 1) << this.int_4);
            this.class56_1.method_0(((uint) 1) << this.int_4);
            this.struct13_1.method_0();
            this.bool_1 = false;
            this.uint_23 = 0;
            this.uint_22 = 0;
            this.uint_12 = 0;
        }

        private void method_4(out uint uint_25, out uint uint_26)
        {
            uint_25 = 0;
            uint_26 = this.interface7_0.imethod_7(this.uint_6);
            if (uint_26 > 0)
            {
                uint_25 = this.uint_6[uint_26 - 2];
                if (uint_25 == this.uint_20)
                {
                    uint_25 += this.interface7_0.imethod_4(((int) uint_25) - 1, this.uint_6[uint_26 - 1], 0x111 - uint_25);
                }
            }
            this.uint_12++;
        }

        private void method_5(uint uint_25)
        {
            if (uint_25 > 0)
            {
                this.interface7_0.imethod_8(uint_25);
                this.uint_12 += uint_25;
            }
        }

        private uint method_6(Class50.Struct8 struct8_1, uint uint_25)
        {
            return (this.struct11_3[struct8_1.uint_0].method_4() + this.struct11_2[(struct8_1.uint_0 << 4) + uint_25].method_4());
        }

        private uint method_7(uint uint_25, Class50.Struct8 struct8_1, uint uint_26)
        {
            if (uint_25 == 0)
            {
                return (this.struct11_3[struct8_1.uint_0].method_4() + this.struct11_2[(struct8_1.uint_0 << 4) + uint_26].method_5());
            }
            uint num = this.struct11_3[struct8_1.uint_0].method_5();
            if (uint_25 == 1)
            {
                return (num + this.struct11_4[struct8_1.uint_0].method_4());
            }
            num += this.struct11_4[struct8_1.uint_0].method_5();
            return (num + this.struct11_5[struct8_1.uint_0].method_3(uint_25 - 2));
        }

        private uint method_8(uint uint_25, uint uint_26, Class50.Struct8 struct8_1, uint uint_27)
        {
            return (this.class56_1.method_4(uint_26 - 2, uint_27) + this.method_7(uint_25, struct8_1, uint_27));
        }

        private uint method_9(uint uint_25, uint uint_26, uint uint_27)
        {
            uint num;
            uint num2 = Class50.smethod_0(uint_26);
            if (uint_25 < 0x80)
            {
                num = this.uint_5[(num2 * 0x80) + uint_25];
            }
            else
            {
                num = this.uint_7[(num2 << 6) + smethod_1(uint_25)] + this.uint_4[((int) uint_25) & 15];
            }
            return (num + this.class56_0.method_4(uint_26 - 2, uint_27));
        }

        private static uint smethod_0(uint uint_25)
        {
            if (uint_25 < 0x800)
            {
                return byte_0[uint_25];
            }
            if (uint_25 < 0x200000)
            {
                return (uint) (byte_0[uint_25 >> 10] + 20);
            }
            return (uint) (byte_0[uint_25 >> 20] + 40);
        }

        private static uint smethod_1(uint uint_25)
        {
            if (uint_25 < 0x20000)
            {
                return (uint) (byte_0[uint_25 >> 6] + 12);
            }
            if (uint_25 < 0x8000000)
            {
                return (uint) (byte_0[uint_25 >> 0x10] + 0x20);
            }
            return (uint) (byte_0[uint_25 >> 0x1a] + 0x34);
        }

        private static int smethod_2(string string_1)
        {
            for (int i = 0; i < string_0.Length; i++)
            {
                if (string_1 == string_0[i])
                {
                    return i;
                }
            }
            return -1;
        }

        internal class Class55
        {
            private Struct11 struct11_0;
            private Struct11 struct11_1;
            private readonly Struct13[] struct13_0 = new Struct13[0x10];
            private readonly Struct13[] struct13_1 = new Struct13[0x10];
            private Struct13 struct13_2 = new Struct13(8);

            public Class55()
            {
                for (uint i = 0; i < 0x10; i++)
                {
                    this.struct13_0[i] = new Struct13(3);
                    this.struct13_1[i] = new Struct13(3);
                }
            }

            public void method_0(uint uint_0)
            {
                this.struct11_0.method_0();
                this.struct11_1.method_0();
                for (uint i = 0; i < uint_0; i++)
                {
                    this.struct13_0[i].method_0();
                    this.struct13_1[i].method_0();
                }
                this.struct13_2.method_0();
            }

            public void method_1(Class61 class61_0, uint uint_0, uint uint_1)
            {
                if (uint_0 < 8)
                {
                    this.struct11_0.method_2(class61_0, 0);
                    this.struct13_0[uint_1].method_1(class61_0, uint_0);
                }
                else
                {
                    uint_0 -= 8;
                    this.struct11_0.method_2(class61_0, 1);
                    if (uint_0 < 8)
                    {
                        this.struct11_1.method_2(class61_0, 0);
                        this.struct13_1[uint_1].method_1(class61_0, uint_0);
                    }
                    else
                    {
                        this.struct11_1.method_2(class61_0, 1);
                        this.struct13_2.method_1(class61_0, uint_0 - 8);
                    }
                }
            }

            public void method_2(uint uint_0, uint uint_1, uint[] uint_2, uint uint_3)
            {
                uint num = this.struct11_0.method_4();
                uint num1 = this.struct11_0.method_5();
                uint num2 = num1 + this.struct11_1.method_4();
                uint num3 = num1 + this.struct11_1.method_5();
                uint num4 = 0;
                num4 = 0;
                while (num4 < 8)
                {
                    if (num4 >= uint_1)
                    {
                        return;
                    }
                    uint_2[uint_3 + num4] = num + this.struct13_0[uint_0].method_3(num4);
                    num4++;
                }
                while (num4 < 0x10)
                {
                    if (num4 >= uint_1)
                    {
                        return;
                    }
                    uint_2[uint_3 + num4] = num2 + this.struct13_1[uint_0].method_3(num4 - 8);
                    num4++;
                }
                while (num4 < uint_1)
                {
                    uint_2[uint_3 + num4] = num3 + this.struct13_2.method_3((num4 - 8) - 8);
                    num4++;
                }
            }
        }

        internal class Class56 : Class54.Class55
        {
            private readonly uint[] uint_0 = new uint[0x10];
            private readonly uint[] uint_1 = new uint[0x1100];
            private uint uint_2;

            public void method_3(uint uint_3)
            {
                this.uint_2 = uint_3;
            }

            public uint method_4(uint uint_3, uint uint_4)
            {
                return this.uint_1[(uint_4 * 0x110) + uint_3];
            }

            private void method_5(uint uint_3)
            {
                base.method_2(uint_3, this.uint_2, this.uint_1, uint_3 * 0x110);
                this.uint_0[uint_3] = this.uint_2;
            }

            public void method_6(uint uint_3)
            {
                for (uint i = 0; i < uint_3; i++)
                {
                    this.method_5(i);
                }
            }

            public void method_7(Class61 class61_0, uint uint_3, uint uint_4)
            {
                base.method_1(class61_0, uint_3, uint_4);
                uint num = this.uint_0[uint_4] - 1;
                this.uint_0[uint_4] = num;
                if (num == 0)
                {
                    this.method_5(uint_4);
                }
            }
        }

        internal class Class57
        {
            private int int_0;
            private int int_1;
            private Struct10[] struct10_0;
            private uint uint_0;

            public void method_0(int int_2, int int_3)
            {
                if (((this.struct10_0 == null) || (this.int_1 != int_3)) || (this.int_0 != int_2))
                {
                    this.int_0 = int_2;
                    this.uint_0 = (uint) ((((int) 1) << int_2) - 1);
                    this.int_1 = int_3;
                    uint num = ((uint) 1) << (this.int_1 + this.int_0);
                    this.struct10_0 = new Struct10[num];
                    for (uint i = 0; i < num; i++)
                    {
                        this.struct10_0[i].method_0();
                    }
                }
            }

            public void method_1()
            {
                uint num = ((uint) 1) << (this.int_1 + this.int_0);
                for (uint i = 0; i < num; i++)
                {
                    this.struct10_0[i].method_1();
                }
            }

            public Struct10 method_2(uint uint_1, byte byte_0)
            {
                return this.struct10_0[((int) ((uint_1 & this.uint_0) << this.int_1)) + (byte_0 >> (8 - this.int_1))];
            }

            [StructLayout(LayoutKind.Sequential)]
            public struct Struct10
            {
                private Struct11[] struct11_0;
                public void method_0()
                {
                    this.struct11_0 = new Struct11[0x300];
                }

                public void method_1()
                {
                    for (int i = 0; i < 0x300; i++)
                    {
                        this.struct11_0[i].method_0();
                    }
                }

                public void method_2(Class61 class61_0, byte byte_0)
                {
                    uint index = 1;
                    for (int i = 7; i >= 0; i--)
                    {
                        uint num3 = (uint) ((byte_0 >> i) & 1);
                        this.struct11_0[index].method_2(class61_0, num3);
                        index = (index << 1) | num3;
                    }
                }

                public void method_3(Class61 class61_0, byte byte_0, byte byte_1)
                {
                    uint num = 1;
                    bool flag = true;
                    for (int i = 7; i >= 0; i--)
                    {
                        uint num3 = (uint) ((byte_1 >> i) & 1);
                        uint index = num;
                        if (flag)
                        {
                            uint num5 = (uint) ((byte_0 >> i) & 1);
                            index += (uint) ((1 + num5) << 8);
                            flag = num5 == num3;
                        }
                        this.struct11_0[index].method_2(class61_0, num3);
                        num = (num << 1) | num3;
                    }
                }

                public uint method_4(bool bool_0, byte byte_0, byte byte_1)
                {
                    uint num = 0;
                    uint index = 1;
                    int num3 = 7;
                    if (bool_0)
                    {
                        while (num3 >= 0)
                        {
                            uint num4 = (uint) ((byte_0 >> num3) & 1);
                            uint num5 = (uint) ((byte_1 >> num3) & 1);
                            num += this.struct11_0[(int) (((1 + num4) << 8) + index)].method_3(num5);
                            index = (index << 1) | num5;
                            if (num4 != num5)
                            {
                                num3--;
                                break;
                            }
                            num3--;
                        }
                    }
                    while (num3 >= 0)
                    {
                        uint num6 = (uint) ((byte_1 >> num3) & 1);
                        num += this.struct11_0[index].method_3(num6);
                        index = (index << 1) | num6;
                        num3--;
                    }
                    return num;
                }
            }
        }

        internal class Class58
        {
            public bool bool_0;
            public bool bool_1;
            public Class50.Struct8 struct8_0;
            public uint uint_0;
            public uint uint_1;
            public uint uint_2;
            public uint uint_3;
            public uint uint_4;
            public uint uint_5;
            public uint uint_6;
            public uint uint_7;
            public uint uint_8;

            public void method_0()
            {
                this.uint_0 = uint.MaxValue;
                this.bool_0 = false;
            }

            public void method_1()
            {
                this.uint_0 = 0;
                this.bool_0 = false;
            }

            public bool method_2()
            {
                return (this.uint_0 == 0);
            }
        }

        private enum Enum6
        {
            const_0,
            const_1
        }
    }
}

