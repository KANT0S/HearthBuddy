namespace Newtonsoft.Json.Bson
{
    using Newtonsoft.Json;
    using ns15;
    using ns18;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Text;

    public class BsonReader : JsonReader
    {
        private readonly BinaryReader binaryReader_0;
        private bool bool_2;
        private bool bool_3;
        private static readonly byte[] byte_0;
        private static readonly byte[] byte_1;
        private static readonly byte[] byte_2;
        private static readonly byte[] byte_3;
        private byte[] byte_4;
        private char[] char_1;
        private Class69 class69_0;
        private DateTimeKind dateTimeKind_0;
        private Enum10 enum10_0;
        private Enum11 enum11_0;
        private const int int_0 = 0x80;
        private readonly List<Class69> list_1;

        static BsonReader()
        {
            byte[] buffer = new byte[2];
            buffer[1] = 0x7f;
            byte_0 = buffer;
            byte_1 = new byte[] { 0xc2, 0xdf };
            byte_2 = new byte[] { 0xe0, 0xef };
            byte_3 = new byte[] { 240, 0xf4 };
        }

        public BsonReader(BinaryReader reader) : this(reader, false, DateTimeKind.Local)
        {
        }

        public BsonReader(Stream stream) : this(stream, false, DateTimeKind.Local)
        {
        }

        public BsonReader(BinaryReader reader, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
        {
            Class203.smethod_2(reader, "reader");
            this.binaryReader_0 = reader;
            this.list_1 = new List<Class69>();
            this.bool_2 = readRootValueAsArray;
            this.dateTimeKind_0 = dateTimeKindHandling;
        }

        public BsonReader(Stream stream, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
        {
            Class203.smethod_2(stream, "stream");
            this.binaryReader_0 = new BinaryReader(stream);
            this.list_1 = new List<Class69>();
            this.bool_2 = readRootValueAsArray;
            this.dateTimeKind_0 = dateTimeKindHandling;
        }

        public override void Close()
        {
            base.Close();
            if (base.CloseInput && (this.binaryReader_0 != null))
            {
                this.binaryReader_0.Close();
            }
        }

        private string method_14()
        {
            this.enum11_0 = this.method_32();
            return this.method_23();
        }

        private bool method_15()
        {
            switch (this.enum10_0)
            {
                case Enum10.CodeWScopeStart:
                    base.SetToken(JsonToken.PropertyName, "$code");
                    this.enum10_0 = Enum10.CodeWScopeCode;
                    return true;

                case Enum10.CodeWScopeCode:
                    this.method_30();
                    base.SetToken(JsonToken.String, this.method_24());
                    this.enum10_0 = Enum10.CodeWScopeScope;
                    return true;

                case Enum10.CodeWScopeScope:
                    if (base.CurrentState != JsonReader.State.PostValue)
                    {
                        base.SetToken(JsonToken.StartObject);
                        this.enum10_0 = Enum10.CodeWScopeScopeObject;
                        Class69 class2 = new Class69(Enum11.Object);
                        this.method_19(class2);
                        class2.int_0 = this.method_30();
                        return true;
                    }
                    base.SetToken(JsonToken.PropertyName, "$scope");
                    return true;

                case Enum10.CodeWScopeScopeObject:
                    bool flag;
                    if ((flag = this.method_17()) && (this.JsonToken_0 == JsonToken.EndObject))
                    {
                        this.enum10_0 = Enum10.CodeWScopeScopeEnd;
                    }
                    return flag;

                case Enum10.CodeWScopeScopeEnd:
                    base.SetToken(JsonToken.EndObject);
                    this.enum10_0 = Enum10.Normal;
                    return true;
            }
            throw new ArgumentOutOfRangeException();
        }

        private bool method_16()
        {
            switch (base.CurrentState)
            {
                case JsonReader.State.Property:
                    if (this.enum10_0 != Enum10.ReferenceRef)
                    {
                        if (this.enum10_0 != Enum10.ReferenceId)
                        {
                            throw JsonReaderException.smethod_1(this, "Unexpected state when reading BSON reference: " + this.enum10_0);
                        }
                        base.SetToken(JsonToken.Bytes, this.method_34(12));
                        return true;
                    }
                    base.SetToken(JsonToken.String, this.method_24());
                    return true;

                case JsonReader.State.ObjectStart:
                    base.SetToken(JsonToken.PropertyName, "$ref");
                    this.enum10_0 = Enum10.ReferenceRef;
                    return true;

                case JsonReader.State.PostValue:
                    if (this.enum10_0 == Enum10.ReferenceRef)
                    {
                        base.SetToken(JsonToken.PropertyName, "$id");
                        this.enum10_0 = Enum10.ReferenceId;
                        return true;
                    }
                    if (this.enum10_0 != Enum10.ReferenceId)
                    {
                        throw JsonReaderException.smethod_1(this, "Unexpected state when reading BSON reference: " + this.enum10_0);
                    }
                    base.SetToken(JsonToken.EndObject);
                    this.enum10_0 = Enum10.Normal;
                    return true;
            }
            throw JsonReaderException.smethod_1(this, "Unexpected state when reading BSON reference: " + base.CurrentState);
        }

        private bool method_17()
        {
            switch (base.CurrentState)
            {
                case JsonReader.State.Start:
                {
                    JsonToken newToken = !this.bool_2 ? JsonToken.StartObject : JsonToken.StartArray;
                    Enum11 type = !this.bool_2 ? Enum11.Object : Enum11.Array;
                    base.SetToken(newToken);
                    Class69 class2 = new Class69(type);
                    this.method_19(class2);
                    class2.int_0 = this.method_30();
                    return true;
                }
                case JsonReader.State.Complete:
                case JsonReader.State.Closed:
                    return false;

                case JsonReader.State.Property:
                    this.method_21(this.enum11_0);
                    return true;

                case JsonReader.State.ObjectStart:
                case JsonReader.State.ArrayStart:
                case JsonReader.State.PostValue:
                {
                    Class69 class3 = this.class69_0;
                    if (class3 != null)
                    {
                        int num = class3.int_0 - 1;
                        if (class3.int_1 < num)
                        {
                            if (class3.enum11_0 == Enum11.Array)
                            {
                                this.method_14();
                                this.method_21(this.enum11_0);
                                return true;
                            }
                            base.SetToken(JsonToken.PropertyName, this.method_14());
                            return true;
                        }
                        if (class3.int_1 != num)
                        {
                            throw JsonReaderException.smethod_1(this, "Read past end of current container context.");
                        }
                        if (this.method_20() != 0)
                        {
                            throw JsonReaderException.smethod_1(this, "Unexpected end of object byte value.");
                        }
                        this.method_18();
                        if (this.class69_0 != null)
                        {
                            this.method_33(class3.int_0);
                        }
                        JsonToken token2 = (class3.enum11_0 == Enum11.Object) ? JsonToken.EndObject : JsonToken.EndArray;
                        base.SetToken(token2);
                        return true;
                    }
                    return false;
                }
                case JsonReader.State.ConstructorStart:
                case JsonReader.State.Constructor:
                case JsonReader.State.Error:
                case JsonReader.State.Finished:
                    return false;
            }
            throw new ArgumentOutOfRangeException();
        }

        private void method_18()
        {
            this.list_1.RemoveAt(this.list_1.Count - 1);
            if (this.list_1.Count == 0)
            {
                this.class69_0 = null;
            }
            else
            {
                this.class69_0 = this.list_1[this.list_1.Count - 1];
            }
        }

        private void method_19(Class69 class69_1)
        {
            this.list_1.Add(class69_1);
            this.class69_0 = class69_1;
        }

        private byte method_20()
        {
            this.method_33(1);
            return this.binaryReader_0.ReadByte();
        }

        private void method_21(Enum11 enum11_1)
        {
            DateTime time;
            DateTime time2;
            switch (enum11_1)
            {
                case Enum11.Number:
                {
                    double num = this.method_29();
                    if (base.floatParseHandling_0 != FloatParseHandling.Decimal)
                    {
                        base.SetToken(JsonToken.Float, num);
                        return;
                    }
                    base.SetToken(JsonToken.Float, Convert.ToDecimal(num, CultureInfo.InvariantCulture));
                    return;
                }
                case Enum11.String:
                case Enum11.Symbol:
                    base.SetToken(JsonToken.String, this.method_24());
                    return;

                case Enum11.Object:
                {
                    base.SetToken(JsonToken.StartObject);
                    Class69 class2 = new Class69(Enum11.Object);
                    this.method_19(class2);
                    class2.int_0 = this.method_30();
                    return;
                }
                case Enum11.Array:
                {
                    base.SetToken(JsonToken.StartArray);
                    Class69 class3 = new Class69(Enum11.Array);
                    this.method_19(class3);
                    class3.int_0 = this.method_30();
                    return;
                }
                case Enum11.Binary:
                    base.SetToken(JsonToken.Bytes, this.method_22());
                    return;

                case Enum11.Undefined:
                    base.SetToken(JsonToken.Undefined);
                    return;

                case Enum11.Oid:
                {
                    byte[] buffer = this.method_34(12);
                    base.SetToken(JsonToken.Bytes, buffer);
                    return;
                }
                case Enum11.Boolean:
                {
                    bool flag = Convert.ToBoolean(this.method_20());
                    base.SetToken(JsonToken.Boolean, flag);
                    return;
                }
                case Enum11.Date:
                    time = Class184.smethod_11(this.method_31());
                    switch (this.DateTimeKindHandling)
                    {
                        case DateTimeKind.Unspecified:
                            time2 = DateTime.SpecifyKind(time, DateTimeKind.Unspecified);
                            goto Label_017F;

                        case DateTimeKind.Local:
                            time2 = time.ToLocalTime();
                            goto Label_017F;
                    }
                    break;

                case Enum11.Null:
                    base.SetToken(JsonToken.Null);
                    return;

                case Enum11.Regex:
                {
                    string str = this.method_23();
                    string str2 = this.method_23();
                    string str3 = "/" + str + "/" + str2;
                    base.SetToken(JsonToken.String, str3);
                    return;
                }
                case Enum11.Reference:
                    base.SetToken(JsonToken.StartObject);
                    this.enum10_0 = Enum10.ReferenceStart;
                    return;

                case Enum11.Code:
                    base.SetToken(JsonToken.String, this.method_24());
                    return;

                case Enum11.CodeWScope:
                    base.SetToken(JsonToken.StartObject);
                    this.enum10_0 = Enum10.CodeWScopeStart;
                    return;

                case Enum11.Integer:
                    base.SetToken(JsonToken.Integer, (long) this.method_30());
                    return;

                case Enum11.TimeStamp:
                case Enum11.Long:
                    base.SetToken(JsonToken.Integer, this.method_31());
                    return;

                default:
                    throw new ArgumentOutOfRangeException("type", "Unexpected BsonType value: " + enum11_1);
            }
            time2 = time;
        Label_017F:
            base.SetToken(JsonToken.Date, time2);
        }

        private byte[] method_22()
        {
            int num = this.method_30();
            if ((this.method_20() == 2) && !this.bool_3)
            {
                num = this.method_30();
            }
            return this.method_34(num);
        }

        private string method_23()
        {
            this.method_28();
            StringBuilder builder = null;
            int num = 0;
            int length = 0;
            while (true)
            {
                int num3 = length;
                while (num3 < 0x80)
                {
                    byte num4 = this.binaryReader_0.ReadByte();
                    if (num4 <= 0)
                    {
                        break;
                    }
                    this.byte_4[num3++] = num4;
                }
                int byteCount = num3 - length;
                num += byteCount;
                if ((num3 < 0x80) && (builder == null))
                {
                    int num6 = Encoding.UTF8.GetChars(this.byte_4, 0, byteCount, this.char_1, 0);
                    this.method_33(num + 1);
                    return new string(this.char_1, 0, num6);
                }
                int num7 = this.method_26(num3 - 1);
                int charCount = Encoding.UTF8.GetChars(this.byte_4, 0, num7 + 1, this.char_1, 0);
                if (builder == null)
                {
                    builder = new StringBuilder(0x100);
                }
                builder.Append(this.char_1, 0, charCount);
                if (num7 < (byteCount - 1))
                {
                    length = (byteCount - num7) - 1;
                    Array.Copy(this.byte_4, num7 + 1, this.byte_4, 0, length);
                }
                else
                {
                    if (num3 < 0x80)
                    {
                        this.method_33(num + 1);
                        return builder.ToString();
                    }
                    length = 0;
                }
            }
        }

        private string method_24()
        {
            int num = this.method_30();
            this.method_33(num);
            string str = this.method_25(num - 1);
            this.binaryReader_0.ReadByte();
            return str;
        }

        private string method_25(int int_1)
        {
            // This item is obfuscated and can not be translated.
            if (int_1 == 0)
            {
                return string.Empty;
            }
            this.method_28();
            StringBuilder builder = null;
            int num = 0;
            int index = 0;
            while ((int_1 - num) > (0x80 - index))
            {
                int num3;
            Label_0021:
                num3 = 0x80 - index;
                int byteCount = this.binaryReader_0.Read(this.byte_4, index, num3);
                if (byteCount == 0)
                {
                    throw new EndOfStreamException("Unable to read beyond the end of the stream.");
                }
                num += byteCount;
                byteCount += index;
                if (byteCount == int_1)
                {
                    return new string(this.char_1, 0, Encoding.UTF8.GetChars(this.byte_4, 0, byteCount, this.char_1, 0));
                }
                int num6 = this.method_26(byteCount - 1);
                if (builder == null)
                {
                    builder = new StringBuilder(int_1);
                }
                int charCount = Encoding.UTF8.GetChars(this.byte_4, 0, num6 + 1, this.char_1, 0);
                builder.Append(this.char_1, 0, charCount);
                if (num6 < (byteCount - 1))
                {
                    index = (byteCount - num6) - 1;
                    Array.Copy(this.byte_4, num6 + 1, this.byte_4, 0, index);
                }
                else
                {
                    index = 0;
                }
                if (num >= int_1)
                {
                    return builder.ToString();
                }
            }
            goto Label_0021;
        }

        private int method_26(int int_1)
        {
            int index = int_1;
            int num2 = 0;
            while (index >= 0)
            {
                num2 = this.method_27(this.byte_4[index]);
                if (num2 != 0)
                {
                    if (num2 != 1)
                    {
                        index--;
                    }
                    break;
                }
                index--;
            }
            if (num2 == (int_1 - index))
            {
                return int_1;
            }
            return index;
        }

        private int method_27(byte byte_5)
        {
            if (byte_5 <= byte_0[1])
            {
                return 1;
            }
            if ((byte_5 >= byte_1[0]) && (byte_5 <= byte_1[1]))
            {
                return 2;
            }
            if ((byte_5 >= byte_2[0]) && (byte_5 <= byte_2[1]))
            {
                return 3;
            }
            if ((byte_5 >= byte_3[0]) && (byte_5 <= byte_3[1]))
            {
                return 4;
            }
            return 0;
        }

        private void method_28()
        {
            if (this.byte_4 == null)
            {
                this.byte_4 = new byte[0x80];
            }
            if (this.char_1 == null)
            {
                int maxCharCount = Encoding.UTF8.GetMaxCharCount(0x80);
                this.char_1 = new char[maxCharCount];
            }
        }

        private double method_29()
        {
            this.method_33(8);
            return this.binaryReader_0.ReadDouble();
        }

        private int method_30()
        {
            this.method_33(4);
            return this.binaryReader_0.ReadInt32();
        }

        private long method_31()
        {
            this.method_33(8);
            return this.binaryReader_0.ReadInt64();
        }

        private Enum11 method_32()
        {
            this.method_33(1);
            return (Enum11) this.binaryReader_0.ReadSByte();
        }

        private void method_33(int int_1)
        {
            this.class69_0.int_1 += int_1;
        }

        private byte[] method_34(int int_1)
        {
            this.method_33(int_1);
            return this.binaryReader_0.ReadBytes(int_1);
        }

        bool JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮()
        {
            try
            {
                bool flag;
                switch (this.enum10_0)
                {
                    case Enum10.Normal:
                        flag = this.method_17();
                        break;

                    case Enum10.ReferenceStart:
                    case Enum10.ReferenceRef:
                    case Enum10.ReferenceId:
                        flag = this.method_16();
                        break;

                    case Enum10.CodeWScopeStart:
                    case Enum10.CodeWScopeCode:
                    case Enum10.CodeWScopeScope:
                    case Enum10.CodeWScopeScopeObject:
                    case Enum10.CodeWScopeScopeEnd:
                        flag = this.method_15();
                        break;

                    default:
                        throw JsonReaderException.smethod_1(this, "Unexpected state: {0}".smethod_0(CultureInfo.InvariantCulture, this.enum10_0));
                }
                if (!flag)
                {
                    base.SetToken(JsonToken.None);
                    return false;
                }
                return true;
            }
            catch (EndOfStreamException)
            {
                base.SetToken(JsonToken.None);
                return false;
            }
        }

        public override bool Read()
        {
            base.enum14_0 = Enum14.Read;
            return this.Newtonsoft.Json.JsonReader.‪​⁬‮⁬⁮‫​​​‏‪⁬​‭‎⁬‫​⁪‌‏⁭‫⁭‪‫‭⁬⁭‮‬‬‭​‏‭‫‎‍‮();
        }

        public override byte[] ReadAsBytes()
        {
            return base.method_5();
        }

        public override DateTime? ReadAsDateTime()
        {
            return base.method_9();
        }

        public override DateTimeOffset? ReadAsDateTimeOffset()
        {
            return base.method_4();
        }

        public override decimal? ReadAsDecimal()
        {
            return base.method_6();
        }

        public override int? ReadAsInt32()
        {
            return base.method_7();
        }

        public override string ReadAsString()
        {
            return base.method_8();
        }

        public DateTimeKind DateTimeKindHandling
        {
            get
            {
                return this.dateTimeKind_0;
            }
            set
            {
                this.dateTimeKind_0 = value;
            }
        }

        [Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
        public bool JsonNet35BinaryCompatibility
        {
            get
            {
                return this.bool_3;
            }
            set
            {
                this.bool_3 = value;
            }
        }

        public bool ReadRootValueAsArray
        {
            get
            {
                return this.bool_2;
            }
            set
            {
                this.bool_2 = value;
            }
        }

        private class Class69
        {
            public readonly Enum11 enum11_0;
            public int int_0;
            public int int_1;

            public Class69(Enum11 type)
            {
                this.enum11_0 = type;
            }
        }

        private enum Enum10
        {
            Normal,
            ReferenceStart,
            ReferenceRef,
            ReferenceId,
            CodeWScopeStart,
            CodeWScopeCode,
            CodeWScopeScope,
            CodeWScopeScopeObject,
            CodeWScopeScopeEnd
        }
    }
}

