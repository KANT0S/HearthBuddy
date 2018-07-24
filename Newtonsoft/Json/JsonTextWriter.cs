namespace Newtonsoft.Json
{
    using ns18;
    using ns20;
    using System;
    using System.Globalization;
    using System.IO;
    using System.Numerics;

    public class JsonTextWriter : JsonWriter
    {
        private bool bool_1;
        private bool[] bool_2;
        private char char_0;
        private char char_1;
        private char[] char_2;
        private Class142 class142_0;
        private int int_0;
        private readonly TextWriter textWriter_0;

        public JsonTextWriter(TextWriter textWriter)
        {
            if (textWriter == null)
            {
                throw new ArgumentNullException("textWriter");
            }
            this.textWriter_0 = textWriter;
            this.char_1 = '"';
            this.bool_1 = true;
            this.char_0 = ' ';
            this.int_0 = 2;
            this.method_20();
        }

        public override void Close()
        {
            base.Close();
            if (base.CloseOutput && (this.textWriter_0 != null))
            {
                this.textWriter_0.Close();
            }
        }

        public override void Flush()
        {
            this.textWriter_0.Flush();
        }

        private void method_20()
        {
            if (base.StringEscapeHandling == StringEscapeHandling.EscapeHtml)
            {
                this.bool_2 = Class189.bool_2;
            }
            else if (this.char_1 == '"')
            {
                this.bool_2 = Class189.bool_1;
            }
            else
            {
                this.bool_2 = Class189.bool_0;
            }
        }

        private void method_21(string string_1, JsonToken jsonToken_0)
        {
            this.textWriter_0.Write(string_1);
        }

        private void method_22(string string_1)
        {
            this.method_23();
            Class189.smethod_0(this.textWriter_0, string_1, this.char_1, true, this.bool_2, base.StringEscapeHandling, ref this.char_2);
        }

        private void method_23()
        {
            if (this.char_2 == null)
            {
                this.char_2 = new char[0x40];
            }
        }

        private void method_24(long long_0)
        {
            this.method_23();
            if ((long_0 >= 0L) && (long_0 <= 9L))
            {
                this.textWriter_0.Write((char) ((ushort) (0x30L + long_0)));
            }
            else
            {
                ulong num = (long_0 < 0L) ? ((ulong) -long_0) : ((ulong) long_0);
                if (long_0 < 0L)
                {
                    this.textWriter_0.Write('-');
                }
                this.method_25(num);
            }
        }

        private void method_25(ulong ulong_0)
        {
            this.method_23();
            if (ulong_0 <= 9L)
            {
                this.textWriter_0.Write((char) (((ulong) 0x30L) + ulong_0));
            }
            else
            {
                int num = Class192.smethod_0(ulong_0);
                int count = 0;
                do
                {
                    this.char_2[num - ++count] = (char) (((ulong) 0x30L) + (ulong_0 % ((ulong) 10L)));
                    ulong_0 /= (ulong) 10L;
                }
                while (ulong_0 != 0L);
                this.textWriter_0.Write(this.char_2, 0, count);
            }
        }

        void JsonWriter.⁪‮‏‏‮‭⁭​​‎‍‮⁪‮‏⁫‪⁯‭‫⁭⁪‬‬⁮⁫‮⁮‏⁮‪⁯⁭​​‭⁫⁬‍⁮‮()
        {
            this.method_20();
        }

        public override void WriteComment(string text)
        {
            base.method_19();
            this.textWriter_0.Write("/*");
            this.textWriter_0.Write(text);
            this.textWriter_0.Write("*/");
        }

        protected override void WriteEnd(JsonToken token)
        {
            switch (token)
            {
                case JsonToken.EndObject:
                    this.textWriter_0.Write("}");
                    return;

                case JsonToken.EndArray:
                    this.textWriter_0.Write("]");
                    return;

                case JsonToken.EndConstructor:
                    this.textWriter_0.Write(")");
                    return;
            }
            throw JsonWriterException.smethod_1(this, "Invalid JsonToken: " + token, null);
        }

        protected override void WriteIndent()
        {
            int num2;
            this.textWriter_0.Write(Environment.NewLine);
            for (int i = base.Top * this.int_0; i > 0; i -= num2)
            {
                num2 = Math.Min(i, 10);
                this.textWriter_0.Write(new string(this.char_0, num2));
            }
        }

        protected override void WriteIndentSpace()
        {
            this.textWriter_0.Write(' ');
        }

        public override void WriteNull()
        {
            base.method_17(JsonToken.Null);
            this.method_21(JsonConvert.Null, JsonToken.Null);
        }

        public override void WritePropertyName(string name)
        {
            base.method_14(name);
            this.method_22(name);
            this.textWriter_0.Write(':');
        }

        public override void WritePropertyName(string name, bool escape)
        {
            base.method_14(name);
            if (escape)
            {
                this.method_22(name);
            }
            else
            {
                if (this.bool_1)
                {
                    this.textWriter_0.Write(this.char_1);
                }
                this.textWriter_0.Write(name);
                if (this.bool_1)
                {
                    this.textWriter_0.Write(this.char_1);
                }
            }
            this.textWriter_0.Write(':');
        }

        public override void WriteRaw(string json)
        {
            base.method_15();
            this.textWriter_0.Write(json);
        }

        public override void WriteStartArray()
        {
            base.method_16(JsonToken.StartArray, Enum12.Array);
            this.textWriter_0.Write("[");
        }

        public override void WriteStartConstructor(string name)
        {
            base.method_16(JsonToken.StartConstructor, Enum12.Constructor);
            this.textWriter_0.Write("new ");
            this.textWriter_0.Write(name);
            this.textWriter_0.Write("(");
        }

        public override void WriteStartObject()
        {
            base.method_16(JsonToken.StartObject, Enum12.Object);
            this.textWriter_0.Write("{");
        }

        public override void WriteUndefined()
        {
            base.method_17(JsonToken.Undefined);
            this.method_21(JsonConvert.Undefined, JsonToken.Undefined);
        }

        public override void WriteValue(bool value)
        {
            base.method_17(JsonToken.Boolean);
            this.method_21(JsonConvert.ToString(value), JsonToken.Boolean);
        }

        public override void WriteValue(byte value)
        {
            base.method_17(JsonToken.Integer);
            this.method_24((long) value);
        }

        public override void WriteValue(char value)
        {
            base.method_17(JsonToken.String);
            this.method_21(JsonConvert.ToString(value), JsonToken.String);
        }

        public override void WriteValue(DateTime value)
        {
            base.method_17(JsonToken.Date);
            value = Class184.smethod_2(value, base.DateTimeZoneHandling);
            if (string.IsNullOrEmpty(base.DateFormatString))
            {
                this.method_23();
                int count = 0;
                count = 1;
                this.char_2[0] = this.char_1;
                count = Class184.smethod_17(this.char_2, 1, value, null, value.Kind, base.DateFormatHandling);
                this.char_2[count++] = this.char_1;
                this.textWriter_0.Write(this.char_2, 0, count);
            }
            else
            {
                this.textWriter_0.Write(this.char_1);
                this.textWriter_0.Write(value.ToString(base.DateFormatString, base.Culture));
                this.textWriter_0.Write(this.char_1);
            }
        }

        public override void WriteValue(DateTimeOffset value)
        {
            base.method_17(JsonToken.Date);
            if (string.IsNullOrEmpty(base.DateFormatString))
            {
                this.method_23();
                int count = 0;
                count = 1;
                this.char_2[0] = this.char_1;
                count = Class184.smethod_17(this.char_2, 1, (base.DateFormatHandling == DateFormatHandling.IsoDateFormat) ? value.DateTime : value.UtcDateTime, new TimeSpan?(value.Offset), DateTimeKind.Local, base.DateFormatHandling);
                this.char_2[count++] = this.char_1;
                this.textWriter_0.Write(this.char_2, 0, count);
            }
            else
            {
                this.textWriter_0.Write(this.char_1);
                this.textWriter_0.Write(value.ToString(base.DateFormatString, base.Culture));
                this.textWriter_0.Write(this.char_1);
            }
        }

        public override void WriteValue(decimal value)
        {
            base.method_17(JsonToken.Float);
            this.method_21(JsonConvert.ToString(value), JsonToken.Float);
        }

        public override void WriteValue(double value)
        {
            base.method_17(JsonToken.Float);
            this.method_21(JsonConvert.smethod_3(value, base.FloatFormatHandling, this.QuoteChar, false), JsonToken.Float);
        }

        public override void WriteValue(Guid value)
        {
            base.method_17(JsonToken.String);
            this.method_21(JsonConvert.smethod_6(value, this.char_1), JsonToken.String);
        }

        public override void WriteValue(short value)
        {
            base.method_17(JsonToken.Integer);
            this.method_24((long) value);
        }

        public override void WriteValue(int value)
        {
            base.method_17(JsonToken.Integer);
            this.method_24((long) value);
        }

        public override void WriteValue(long value)
        {
            base.method_17(JsonToken.Integer);
            this.method_24(value);
        }

        public override void WriteValue(double? value)
        {
            if (!value.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                base.method_17(JsonToken.Float);
                this.method_21(JsonConvert.smethod_3(value.Value, base.FloatFormatHandling, this.QuoteChar, true), JsonToken.Float);
            }
        }

        public override void WriteValue(float? value)
        {
            if (!value.HasValue)
            {
                this.WriteNull();
            }
            else
            {
                base.method_17(JsonToken.Float);
                this.method_21(JsonConvert.smethod_1(value.Value, base.FloatFormatHandling, this.QuoteChar, true), JsonToken.Float);
            }
        }

        public override void WriteValue(object value)
        {
            if (value is BigInteger)
            {
                base.method_17(JsonToken.Integer);
                this.method_21(((BigInteger) value).ToString(CultureInfo.InvariantCulture), JsonToken.String);
            }
            else
            {
                base.WriteValue(value);
            }
        }

        [CLSCompliant(false)]
        public override void WriteValue(sbyte value)
        {
            base.method_17(JsonToken.Integer);
            this.method_24((long) value);
        }

        public override void WriteValue(float value)
        {
            base.method_17(JsonToken.Float);
            this.method_21(JsonConvert.smethod_1(value, base.FloatFormatHandling, this.QuoteChar, false), JsonToken.Float);
        }

        public override void WriteValue(string value)
        {
            base.method_17(JsonToken.String);
            if (value == null)
            {
                this.method_21(JsonConvert.Null, JsonToken.Null);
            }
            else
            {
                this.method_22(value);
            }
        }

        [CLSCompliant(false)]
        public override void WriteValue(ushort value)
        {
            base.method_17(JsonToken.Integer);
            this.method_24((long) value);
        }

        [CLSCompliant(false)]
        public override void WriteValue(uint value)
        {
            base.method_17(JsonToken.Integer);
            this.method_24((long) value);
        }

        [CLSCompliant(false)]
        public override void WriteValue(ulong value)
        {
            base.method_17(JsonToken.Integer);
            this.method_25(value);
        }

        public override void WriteValue(byte[] value)
        {
            if (value == null)
            {
                this.WriteNull();
            }
            else
            {
                base.method_17(JsonToken.Bytes);
                this.textWriter_0.Write(this.char_1);
                this.Class142_0.method_0(value, 0, value.Length);
                this.Class142_0.method_1();
                this.textWriter_0.Write(this.char_1);
            }
        }

        public override void WriteValue(TimeSpan value)
        {
            base.method_17(JsonToken.String);
            this.method_21(JsonConvert.smethod_7(value, this.char_1), JsonToken.String);
        }

        public override void WriteValue(Uri value)
        {
            if (value == null)
            {
                this.WriteNull();
            }
            else
            {
                base.method_17(JsonToken.String);
                this.method_21(JsonConvert.smethod_8(value, this.char_1), JsonToken.String);
            }
        }

        protected override void WriteValueDelimiter()
        {
            this.textWriter_0.Write(',');
        }

        public override void WriteWhitespace(string ws)
        {
            base.method_18(ws);
            this.textWriter_0.Write(ws);
        }

        private Class142 Class142_0
        {
            get
            {
                if (this.class142_0 == null)
                {
                    this.class142_0 = new Class142(this.textWriter_0);
                }
                return this.class142_0;
            }
        }

        public int Indentation
        {
            get
            {
                return this.int_0;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Indentation value must be greater than 0.");
                }
                this.int_0 = value;
            }
        }

        public char IndentChar
        {
            get
            {
                return this.char_0;
            }
            set
            {
                this.char_0 = value;
            }
        }

        public char QuoteChar
        {
            get
            {
                return this.char_1;
            }
            set
            {
                if ((value != '"') && (value != '\''))
                {
                    throw new ArgumentException("Invalid JavaScript string quote character. Valid quote characters are ' and \".");
                }
                this.char_1 = value;
                this.method_20();
            }
        }

        public bool QuoteName
        {
            get
            {
                return this.bool_1;
            }
            set
            {
                this.bool_1 = value;
            }
        }
    }
}

