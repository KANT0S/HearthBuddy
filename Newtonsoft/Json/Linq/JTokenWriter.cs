namespace Newtonsoft.Json.Linq
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Globalization;
    using System.Numerics;

    public class JTokenWriter : JsonWriter
    {
        private JContainer jcontainer_0;
        private JContainer jcontainer_1;
        private JValue jvalue_0;

        public JTokenWriter()
        {
        }

        public JTokenWriter(JContainer container)
        {
            Class203.smethod_2(container, "container");
            this.jcontainer_0 = container;
            this.jcontainer_1 = container;
        }

        public override void Close()
        {
            base.Close();
        }

        public override void Flush()
        {
        }

        private void method_20(JContainer jcontainer_2)
        {
            if (this.jcontainer_1 == null)
            {
                this.jcontainer_0 = jcontainer_2;
            }
            else
            {
                this.jcontainer_1.method_7(jcontainer_2);
            }
            this.jcontainer_1 = jcontainer_2;
        }

        private void method_21()
        {
            this.jcontainer_1 = this.jcontainer_1.Parent;
            if ((this.jcontainer_1 != null) && (this.jcontainer_1.Type == JTokenType.Property))
            {
                this.jcontainer_1 = this.jcontainer_1.Parent;
            }
        }

        private void method_22(object object_0, JsonToken jsonToken_0)
        {
            this.method_23(new JValue(object_0), jsonToken_0);
        }

        internal void method_23(JValue jvalue_1, JsonToken jsonToken_0)
        {
            if (this.jcontainer_1 != null)
            {
                this.jcontainer_1.Add(jvalue_1);
                if (this.jcontainer_1.Type == JTokenType.Property)
                {
                    this.jcontainer_1 = this.jcontainer_1.Parent;
                }
            }
            else
            {
                this.jvalue_0 = jvalue_1 ?? new JValue(null);
            }
        }

        public override void WriteComment(string text)
        {
            base.WriteComment(text);
            this.method_23(JValue.CreateComment(text), JsonToken.Comment);
        }

        protected override void WriteEnd(JsonToken token)
        {
            this.method_21();
        }

        public override void WriteNull()
        {
            base.WriteNull();
            this.method_23(null, JsonToken.Null);
        }

        public override void WritePropertyName(string name)
        {
            base.WritePropertyName(name);
            this.method_20(new JProperty(name));
        }

        public override void WriteRaw(string json)
        {
            base.WriteRaw(json);
            this.method_23(new JRaw(json), JsonToken.Raw);
        }

        public override void WriteStartArray()
        {
            base.WriteStartArray();
            this.method_20(new JArray());
        }

        public override void WriteStartConstructor(string name)
        {
            base.WriteStartConstructor(name);
            this.method_20(new JConstructor(name));
        }

        public override void WriteStartObject()
        {
            base.WriteStartObject();
            this.method_20(new JObject());
        }

        public override void WriteUndefined()
        {
            base.WriteUndefined();
            this.method_23(null, JsonToken.Undefined);
        }

        public override void WriteValue(bool value)
        {
            base.WriteValue(value);
            this.method_22(value, JsonToken.Boolean);
        }

        public override void WriteValue(byte value)
        {
            base.WriteValue(value);
            this.method_22(value, JsonToken.Integer);
        }

        public override void WriteValue(char value)
        {
            base.WriteValue(value);
            string str = null;
            str = value.ToString(CultureInfo.InvariantCulture);
            this.method_22(str, JsonToken.String);
        }

        public override void WriteValue(DateTime value)
        {
            base.WriteValue(value);
            value = Class184.smethod_2(value, base.DateTimeZoneHandling);
            this.method_22(value, JsonToken.Date);
        }

        public override void WriteValue(DateTimeOffset value)
        {
            base.WriteValue(value);
            this.method_22(value, JsonToken.Date);
        }

        public override void WriteValue(decimal value)
        {
            base.WriteValue(value);
            this.method_22(value, JsonToken.Float);
        }

        public override void WriteValue(double value)
        {
            base.WriteValue(value);
            this.method_22(value, JsonToken.Float);
        }

        public override void WriteValue(Guid value)
        {
            base.WriteValue(value);
            this.method_22(value, JsonToken.String);
        }

        public override void WriteValue(short value)
        {
            base.WriteValue(value);
            this.method_22(value, JsonToken.Integer);
        }

        public override void WriteValue(int value)
        {
            base.WriteValue(value);
            this.method_22(value, JsonToken.Integer);
        }

        public override void WriteValue(long value)
        {
            base.WriteValue(value);
            this.method_22(value, JsonToken.Integer);
        }

        public override void WriteValue(object value)
        {
            if (value is BigInteger)
            {
                base.method_17(JsonToken.Integer);
                this.method_22(value, JsonToken.Integer);
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
            this.method_22(value, JsonToken.Integer);
        }

        public override void WriteValue(float value)
        {
            base.WriteValue(value);
            this.method_22(value, JsonToken.Float);
        }

        public override void WriteValue(string value)
        {
            base.WriteValue(value);
            this.method_22(value ?? string.Empty, JsonToken.String);
        }

        [CLSCompliant(false)]
        public override void WriteValue(ushort value)
        {
            base.WriteValue(value);
            this.method_22(value, JsonToken.Integer);
        }

        [CLSCompliant(false)]
        public override void WriteValue(uint value)
        {
            base.WriteValue(value);
            this.method_22(value, JsonToken.Integer);
        }

        [CLSCompliant(false)]
        public override void WriteValue(ulong value)
        {
            base.WriteValue(value);
            this.method_22(value, JsonToken.Integer);
        }

        public override void WriteValue(byte[] value)
        {
            base.WriteValue(value);
            this.method_22(value, JsonToken.Bytes);
        }

        public override void WriteValue(TimeSpan value)
        {
            base.WriteValue(value);
            this.method_22(value, JsonToken.String);
        }

        public override void WriteValue(Uri value)
        {
            base.WriteValue(value);
            this.method_22(value, JsonToken.String);
        }

        public JToken Token
        {
            get
            {
                if (this.jcontainer_0 != null)
                {
                    return this.jcontainer_0;
                }
                return this.jvalue_0;
            }
        }
    }
}

