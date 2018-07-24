namespace ns15
{
    using ns20;
    using System;
    using System.Globalization;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Text;

    internal class Class67
    {
        private readonly BinaryWriter binaryWriter_0;
        private byte[] byte_0;
        [CompilerGenerated]
        private DateTimeKind dateTimeKind_0;
        private static readonly Encoding encoding_0 = new UTF8Encoding(false);

        public Class67(BinaryWriter writer)
        {
            this.DateTimeKind_0 = DateTimeKind.Utc;
            this.binaryWriter_0 = writer;
        }

        public void method_0()
        {
            this.binaryWriter_0.Flush();
        }

        public void method_1()
        {
            this.binaryWriter_0.Close();
        }

        public void method_2(Class70 class70_0)
        {
            this.method_8(class70_0);
            this.method_3(class70_0);
        }

        private void method_3(Class70 class70_0)
        {
            long num2;
            DateTime time;
            switch (class70_0.Enum11_0)
            {
                case Enum11.Number:
                {
                    Class73 class8 = (Class73) class70_0;
                    this.binaryWriter_0.Write(Convert.ToDouble(class8.Object_0, CultureInfo.InvariantCulture));
                    return;
                }
                case Enum11.String:
                {
                    Class74 class9 = (Class74) class70_0;
                    this.method_4((string) class9.Object_0, class9.Int32_1, new int?(class9.Int32_0 - 4));
                    return;
                }
                case Enum11.Object:
                {
                    Class71 class2 = (Class71) class70_0;
                    this.binaryWriter_0.Write(class2.Int32_0);
                    foreach (Class77 class3 in class2)
                    {
                        this.binaryWriter_0.Write((sbyte) class3.Class70_0.Enum11_0);
                        int? nullable = null;
                        this.method_4((string) class3.Name.Object_0, class3.Name.Int32_1, nullable);
                        this.method_3(class3.Class70_0);
                    }
                    this.binaryWriter_0.Write((byte) 0);
                    return;
                }
                case Enum11.Array:
                {
                    Class72 class4 = (Class72) class70_0;
                    this.binaryWriter_0.Write(class4.Int32_0);
                    ulong num = 0L;
                    foreach (Class70 class5 in class4)
                    {
                        this.binaryWriter_0.Write((sbyte) class5.Enum11_0);
                        int? nullable2 = null;
                        this.method_4(num.ToString(CultureInfo.InvariantCulture), Class192.smethod_0(num), nullable2);
                        this.method_3(class5);
                        num += (ulong) 1L;
                    }
                    this.binaryWriter_0.Write((byte) 0);
                    return;
                }
                case Enum11.Binary:
                {
                    Class75 class12 = (Class75) class70_0;
                    byte[] buffer = (byte[]) class12.Object_0;
                    this.binaryWriter_0.Write(buffer.Length);
                    this.binaryWriter_0.Write((byte) class12.Enum9_0);
                    this.binaryWriter_0.Write(buffer);
                    return;
                }
                case Enum11.Undefined:
                case Enum11.Null:
                    return;

                case Enum11.Oid:
                {
                    Class73 class13 = (Class73) class70_0;
                    byte[] buffer2 = (byte[]) class13.Object_0;
                    this.binaryWriter_0.Write(buffer2);
                    return;
                }
                case Enum11.Boolean:
                {
                    Class73 class10 = (Class73) class70_0;
                    this.binaryWriter_0.Write((bool) class10.Object_0);
                    return;
                }
                case Enum11.Date:
                {
                    Class73 class11 = (Class73) class70_0;
                    num2 = 0L;
                    if (!(class11.Object_0 is DateTime))
                    {
                        DateTimeOffset offset = (DateTimeOffset) class11.Object_0;
                        num2 = Class184.smethod_7(offset.UtcDateTime, offset.Offset);
                        goto Label_02FE;
                    }
                    time = (DateTime) class11.Object_0;
                    if (this.DateTimeKind_0 != DateTimeKind.Utc)
                    {
                        if (this.DateTimeKind_0 == DateTimeKind.Local)
                        {
                            time = time.ToLocalTime();
                        }
                        break;
                    }
                    time = time.ToUniversalTime();
                    break;
                }
                case Enum11.Regex:
                {
                    Class76 class14 = (Class76) class70_0;
                    this.method_4((string) class14.Class74_0.Object_0, class14.Class74_0.Int32_1, null);
                    this.method_4((string) class14.Class74_1.Object_0, class14.Class74_1.Int32_1, null);
                    return;
                }
                case Enum11.Integer:
                {
                    Class73 class6 = (Class73) class70_0;
                    this.binaryWriter_0.Write(Convert.ToInt32(class6.Object_0, CultureInfo.InvariantCulture));
                    return;
                }
                case Enum11.Long:
                {
                    Class73 class7 = (Class73) class70_0;
                    this.binaryWriter_0.Write(Convert.ToInt64(class7.Object_0, CultureInfo.InvariantCulture));
                    return;
                }
                default:
                    throw new ArgumentOutOfRangeException("t", "Unexpected token when writing BSON: {0}".smethod_0(CultureInfo.InvariantCulture, class70_0.Enum11_0));
            }
            num2 = Class184.smethod_9(time, false);
        Label_02FE:
            this.binaryWriter_0.Write(num2);
        }

        private void method_4(string string_0, int int_0, int? nullable_0)
        {
            if (nullable_0.HasValue)
            {
                this.binaryWriter_0.Write(nullable_0.Value);
            }
            this.method_5(string_0, int_0);
            this.binaryWriter_0.Write((byte) 0);
        }

        public void method_5(string string_0, int int_0)
        {
            if (string_0 != null)
            {
                if (this.byte_0 == null)
                {
                    this.byte_0 = new byte[0x100];
                }
                if (int_0 <= 0x100)
                {
                    encoding_0.GetBytes(string_0, 0, string_0.Length, this.byte_0, 0);
                    this.binaryWriter_0.Write(this.byte_0, 0, int_0);
                }
                else
                {
                    byte[] bytes = encoding_0.GetBytes(string_0);
                    this.binaryWriter_0.Write(bytes);
                }
            }
        }

        private int method_6(int int_0)
        {
            return (int_0 + 1);
        }

        private int method_7(int int_0, bool bool_0)
        {
            int num = bool_0 ? 5 : 1;
            return (num + int_0);
        }

        private int method_8(Class70 class70_0)
        {
            switch (class70_0.Enum11_0)
            {
                case Enum11.Number:
                    return 8;

                case Enum11.String:
                {
                    Class74 class6 = (Class74) class70_0;
                    string s = (string) class6.Object_0;
                    class6.Int32_1 = (s != null) ? encoding_0.GetByteCount(s) : 0;
                    class6.Int32_0 = this.method_7(class6.Int32_1, class6.Boolean_0);
                    return class6.Int32_0;
                }
                case Enum11.Object:
                {
                    Class71 class2 = (Class71) class70_0;
                    int num = 4;
                    foreach (Class77 class3 in class2)
                    {
                        int num2 = 1;
                        num2 = 1 + this.method_8(class3.Name);
                        num2 += this.method_8(class3.Class70_0);
                        num += num2;
                    }
                    num++;
                    class2.Int32_0 = num;
                    return num;
                }
                case Enum11.Array:
                {
                    Class72 class4 = (Class72) class70_0;
                    int num3 = 4;
                    ulong num4 = 0L;
                    foreach (Class70 class5 in class4)
                    {
                        num3++;
                        num3 += this.method_6(Class192.smethod_0(num4));
                        num3 += this.method_8(class5);
                        num4 += (ulong) 1L;
                    }
                    num3++;
                    class4.Int32_0 = num3;
                    return class4.Int32_0;
                }
                case Enum11.Binary:
                {
                    Class75 class7 = (Class75) class70_0;
                    byte[] buffer = (byte[]) class7.Object_0;
                    class7.Int32_0 = 5 + buffer.Length;
                    return class7.Int32_0;
                }
                case Enum11.Undefined:
                case Enum11.Null:
                    return 0;

                case Enum11.Oid:
                    return 12;

                case Enum11.Boolean:
                    return 1;

                case Enum11.Date:
                    return 8;

                case Enum11.Regex:
                {
                    Class76 class8 = (Class76) class70_0;
                    int num5 = 0;
                    num5 = 0 + this.method_8(class8.Class74_0);
                    num5 += this.method_8(class8.Class74_1);
                    class8.Int32_0 = num5;
                    return class8.Int32_0;
                }
                case Enum11.Integer:
                    return 4;

                case Enum11.Long:
                    return 8;
            }
            throw new ArgumentOutOfRangeException("t", "Unexpected token when writing BSON: {0}".smethod_0(CultureInfo.InvariantCulture, class70_0.Enum11_0));
        }

        public DateTimeKind DateTimeKind_0
        {
            [CompilerGenerated]
            get
            {
                return this.dateTimeKind_0;
            }
            [CompilerGenerated]
            set
            {
                this.dateTimeKind_0 = value;
            }
        }
    }
}

