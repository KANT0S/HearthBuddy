namespace Newtonsoft.Json.Bson
{
    using Newtonsoft.Json;
    using ns15;
    using ns20;
    using System;
    using System.Globalization;
    using System.IO;
    using System.Numerics;

    public class BsonWriter : JsonWriter
    {
        private readonly Class67 class67_0;
        private Class70 class70_0;
        private Class70 class70_1;
        private string string_1;

        public BsonWriter(BinaryWriter writer)
        {
            Class203.smethod_2(writer, "writer");
            this.class67_0 = new Class67(writer);
        }

        public BsonWriter(Stream stream)
        {
            Class203.smethod_2(stream, "stream");
            this.class67_0 = new Class67(new BinaryWriter(stream));
        }

        public override void Close()
        {
            base.Close();
            if (base.CloseOutput && (this.class67_0 != null))
            {
                this.class67_0.method_1();
            }
        }

        public override void Flush()
        {
            this.class67_0.method_0();
        }

        private void method_20(Class70 class70_2)
        {
            this.method_23(class70_2);
            this.class70_1 = class70_2;
        }

        private void method_21()
        {
            this.class70_1 = this.class70_1.Class70_0;
        }

        private void method_22(object object_0, Enum11 enum11_0)
        {
            this.method_23(new Class73(object_0, enum11_0));
        }

        internal void method_23(Class70 class70_2)
        {
            if (this.class70_1 != null)
            {
                if (this.class70_1 is Class71)
                {
                    ((Class71) this.class70_1).method_0(this.string_1, class70_2);
                    this.string_1 = null;
                }
                else
                {
                    ((Class72) this.class70_1).method_0(class70_2);
                }
            }
            else
            {
                if ((class70_2.Enum11_0 != Enum11.Object) && (class70_2.Enum11_0 != Enum11.Array))
                {
                    throw JsonWriterException.smethod_1(this, "Error writing {0} value. BSON must start with an Object or Array.".smethod_0(CultureInfo.InvariantCulture, class70_2.Enum11_0), null);
                }
                this.class70_1 = class70_2;
                this.class70_0 = class70_2;
            }
        }

        public override void WriteComment(string text)
        {
            throw JsonWriterException.smethod_1(this, "Cannot write JSON comment as BSON.", null);
        }

        protected override void WriteEnd(JsonToken token)
        {
            base.WriteEnd(token);
            this.method_21();
            if (base.Top == 0)
            {
                this.class67_0.method_2(this.class70_0);
            }
        }

        public override void WriteNull()
        {
            base.WriteNull();
            this.method_22(null, Enum11.Null);
        }

        public void WriteObjectId(byte[] value)
        {
            Class203.smethod_2(value, "value");
            if (value.Length != 12)
            {
                throw JsonWriterException.smethod_1(this, "An object id must be 12 bytes", null);
            }
            base.method_0();
            base.method_11(JsonToken.Undefined);
            this.method_22(value, Enum11.Oid);
        }

        public override void WritePropertyName(string name)
        {
            base.WritePropertyName(name);
            this.string_1 = name;
        }

        public override void WriteRaw(string json)
        {
            throw JsonWriterException.smethod_1(this, "Cannot write raw JSON as BSON.", null);
        }

        public override void WriteRawValue(string json)
        {
            throw JsonWriterException.smethod_1(this, "Cannot write raw JSON as BSON.", null);
        }

        public void WriteRegex(string pattern, string options)
        {
            Class203.smethod_2(pattern, "pattern");
            base.method_0();
            base.method_11(JsonToken.Undefined);
            this.method_23(new Class76(pattern, options));
        }

        public override void WriteStartArray()
        {
            base.WriteStartArray();
            this.method_20(new Class72());
        }

        public override void WriteStartConstructor(string name)
        {
            throw JsonWriterException.smethod_1(this, "Cannot write JSON constructor as BSON.", null);
        }

        public override void WriteStartObject()
        {
            base.WriteStartObject();
            this.method_20(new Class71());
        }

        public override void WriteUndefined()
        {
            base.WriteUndefined();
            this.method_22(null, Enum11.Undefined);
        }

        public override void WriteValue(bool value)
        {
            base.WriteValue(value);
            this.method_22(value, Enum11.Boolean);
        }

        public override void WriteValue(byte value)
        {
            base.WriteValue(value);
            this.method_22(value, Enum11.Integer);
        }

        public override void WriteValue(char value)
        {
            base.WriteValue(value);
            string str = null;
            str = value.ToString(CultureInfo.InvariantCulture);
            this.method_23(new Class74(str, true));
        }

        public override void WriteValue(DateTime value)
        {
            base.WriteValue(value);
            value = Class184.smethod_2(value, base.DateTimeZoneHandling);
            this.method_22(value, Enum11.Date);
        }

        public override void WriteValue(DateTimeOffset value)
        {
            base.WriteValue(value);
            this.method_22(value, Enum11.Date);
        }

        public override void WriteValue(decimal value)
        {
            base.WriteValue(value);
            this.method_22(value, Enum11.Number);
        }

        public override void WriteValue(double value)
        {
            base.WriteValue(value);
            this.method_22(value, Enum11.Number);
        }

        public override void WriteValue(Guid value)
        {
            base.WriteValue(value);
            this.method_23(new Class75(value.ToByteArray(), Enum9.Uuid));
        }

        public override void WriteValue(short value)
        {
            base.WriteValue(value);
            this.method_22(value, Enum11.Integer);
        }

        public override void WriteValue(int value)
        {
            base.WriteValue(value);
            this.method_22(value, Enum11.Integer);
        }

        public override void WriteValue(long value)
        {
            base.WriteValue(value);
            this.method_22(value, Enum11.Long);
        }

        public override void WriteValue(object value)
        {
            if (value is BigInteger)
            {
                base.method_17(JsonToken.Integer);
                BigInteger integer = (BigInteger) value;
                this.method_23(new Class75(integer.ToByteArray(), Enum9.Binary));
            }
            else
            {
                base.WriteValue(value);
            }
        }

        [CLSCompliant(false)]
        public override void WriteValue(sbyte value)
        {
            base.WriteValue(value);
            this.method_22(value, Enum11.Integer);
        }

        public override void WriteValue(float value)
        {
            base.WriteValue(value);
            this.method_22(value, Enum11.Number);
        }

        public override void WriteValue(string value)
        {
            base.WriteValue(value);
            if (value == null)
            {
                this.method_22(null, Enum11.Null);
            }
            else
            {
                this.method_23(new Class74(value, true));
            }
        }

        public override void WriteValue(TimeSpan value)
        {
            base.WriteValue(value);
            this.method_23(new Class74(value.ToString(), true));
        }

        [CLSCompliant(false)]
        public override void WriteValue(ushort value)
        {
            base.WriteValue(value);
            this.method_22(value, Enum11.Integer);
        }

        [CLSCompliant(false)]
        public override void WriteValue(uint value)
        {
            if (value > 0x7fffffff)
            {
                throw JsonWriterException.smethod_1(this, "Value is too large to fit in a signed 32 bit integer. BSON does not support unsigned values.", null);
            }
            base.WriteValue(value);
            this.method_22(value, Enum11.Integer);
        }

        [CLSCompliant(false)]
        public override void WriteValue(ulong value)
        {
            if (value > 0x7fffffffffffffffL)
            {
                throw JsonWriterException.smethod_1(this, "Value is too large to fit in a signed 64 bit integer. BSON does not support unsigned values.", null);
            }
            base.WriteValue(value);
            this.method_22(value, Enum11.Long);
        }

        public override void WriteValue(byte[] value)
        {
            base.WriteValue(value);
            this.method_23(new Class75(value, Enum9.Binary));
        }

        public override void WriteValue(Uri value)
        {
            base.WriteValue(value);
            this.method_23(new Class74(value.ToString(), true));
        }

        public DateTimeKind DateTimeKindHandling
        {
            get
            {
                return this.class67_0.DateTimeKind_0;
            }
            set
            {
                this.class67_0.DateTimeKind_0 = value;
            }
        }
    }
}

