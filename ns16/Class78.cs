namespace ns16
{
    using Newtonsoft.Json;
    using System;
    using System.Globalization;
    using System.IO;
    using System.Numerics;

    internal class Class78 : JsonWriter
    {
        private readonly JsonTextWriter jsonTextWriter_0;
        private readonly JsonWriter jsonWriter_0;
        private readonly StringWriter stringWriter_0;

        public Class78(JsonWriter innerWriter)
        {
            this.jsonWriter_0 = innerWriter;
            this.stringWriter_0 = new StringWriter(CultureInfo.InvariantCulture);
            this.jsonTextWriter_0 = new JsonTextWriter(this.stringWriter_0);
            this.jsonTextWriter_0.Formatting = Formatting.Indented;
            this.jsonTextWriter_0.Culture = innerWriter.Culture;
            this.jsonTextWriter_0.DateFormatHandling = innerWriter.DateFormatHandling;
            this.jsonTextWriter_0.DateFormatString = innerWriter.DateFormatString;
            this.jsonTextWriter_0.DateTimeZoneHandling = innerWriter.DateTimeZoneHandling;
            this.jsonTextWriter_0.FloatFormatHandling = innerWriter.FloatFormatHandling;
        }

        public string method_20()
        {
            return this.stringWriter_0.ToString();
        }

        void JsonWriter.Close()
        {
            this.jsonTextWriter_0.Close();
            this.jsonWriter_0.Close();
            base.Close();
        }

        void JsonWriter.Flush()
        {
            this.jsonTextWriter_0.Flush();
            this.jsonWriter_0.Flush();
        }

        void JsonWriter.WriteComment(string text)
        {
            this.jsonTextWriter_0.WriteComment(text);
            this.jsonWriter_0.WriteComment(text);
            base.WriteComment(text);
        }

        void JsonWriter.WriteEndArray()
        {
            this.jsonTextWriter_0.WriteEndArray();
            this.jsonWriter_0.WriteEndArray();
            base.WriteEndArray();
        }

        void JsonWriter.WriteEndConstructor()
        {
            this.jsonTextWriter_0.WriteEndConstructor();
            this.jsonWriter_0.WriteEndConstructor();
            base.WriteEndConstructor();
        }

        void JsonWriter.WriteEndObject()
        {
            this.jsonTextWriter_0.WriteEndObject();
            this.jsonWriter_0.WriteEndObject();
            base.WriteEndObject();
        }

        void JsonWriter.WriteNull()
        {
            this.jsonTextWriter_0.WriteNull();
            this.jsonWriter_0.WriteNull();
            base.WriteUndefined();
        }

        void JsonWriter.WritePropertyName(string name)
        {
            this.jsonTextWriter_0.WritePropertyName(name);
            this.jsonWriter_0.WritePropertyName(name);
            base.WritePropertyName(name);
        }

        void JsonWriter.WritePropertyName(string name, bool escape)
        {
            this.jsonTextWriter_0.WritePropertyName(name, escape);
            this.jsonWriter_0.WritePropertyName(name, escape);
            base.WritePropertyName(name);
        }

        void JsonWriter.WriteRaw(string json)
        {
            this.jsonTextWriter_0.WriteRaw(json);
            this.jsonWriter_0.WriteRaw(json);
            base.WriteRaw(json);
        }

        void JsonWriter.WriteRawValue(string json)
        {
            this.jsonTextWriter_0.WriteRawValue(json);
            this.jsonWriter_0.WriteRawValue(json);
            base.WriteRawValue(json);
        }

        void JsonWriter.WriteStartArray()
        {
            this.jsonTextWriter_0.WriteStartArray();
            this.jsonWriter_0.WriteStartArray();
            base.WriteStartArray();
        }

        void JsonWriter.WriteStartConstructor(string name)
        {
            this.jsonTextWriter_0.WriteStartConstructor(name);
            this.jsonWriter_0.WriteStartConstructor(name);
            base.WriteStartConstructor(name);
        }

        void JsonWriter.WriteStartObject()
        {
            this.jsonTextWriter_0.WriteStartObject();
            this.jsonWriter_0.WriteStartObject();
            base.WriteStartObject();
        }

        void JsonWriter.WriteUndefined()
        {
            this.jsonTextWriter_0.WriteUndefined();
            this.jsonWriter_0.WriteUndefined();
            base.WriteUndefined();
        }

        void JsonWriter.WriteValue(bool value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(byte value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(char value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(byte[] value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(DateTime value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(DateTimeOffset value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(decimal value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(double value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(Guid value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(short value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(int value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(long value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(byte? value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(object value)
        {
            if (value is BigInteger)
            {
                this.jsonTextWriter_0.WriteValue(value);
                this.jsonWriter_0.WriteValue(value);
                base.method_17(JsonToken.Integer);
            }
            else
            {
                this.jsonTextWriter_0.WriteValue(value);
                this.jsonWriter_0.WriteValue(value);
                base.WriteValue(value);
            }
        }

        void JsonWriter.WriteValue(sbyte value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(float value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(string value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(TimeSpan value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(ushort value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(uint value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(ulong value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteValue(Uri value)
        {
            this.jsonTextWriter_0.WriteValue(value);
            this.jsonWriter_0.WriteValue(value);
            base.WriteValue(value);
        }

        void JsonWriter.WriteWhitespace(string ws)
        {
            this.jsonTextWriter_0.WriteWhitespace(ws);
            this.jsonWriter_0.WriteWhitespace(ws);
            base.WriteWhitespace(ws);
        }
    }
}

