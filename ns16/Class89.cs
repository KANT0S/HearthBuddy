namespace ns16
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using ns20;
    using System;
    using System.Globalization;
    using System.Runtime.Serialization;

    internal class Class89 : IFormatterConverter
    {
        private readonly JsonSerializer jsonSerializer_0;

        public Class89(JsonSerializer serializer)
        {
            Class203.smethod_2(serializer, "serializer");
            this.jsonSerializer_0 = serializer;
        }

        public object Convert(object value, Type type)
        {
            Class203.smethod_2(value, "value");
            JToken token = value as JToken;
            if (token == null)
            {
                throw new ArgumentException("Value is not a JToken.", "value");
            }
            return this.jsonSerializer_0.Deserialize(token.CreateReader(), type);
        }

        public object Convert(object value, TypeCode typeCode)
        {
            Class203.smethod_2(value, "value");
            if (value is JValue)
            {
                value = ((JValue) value).Value;
            }
            return System.Convert.ChangeType(value, typeCode, CultureInfo.InvariantCulture);
        }

        private T method_0<T>(object object_0)
        {
            Class203.smethod_2(object_0, "value");
            JValue value2 = (JValue) object_0;
            return (T) System.Convert.ChangeType(value2.Value, typeof(T), CultureInfo.InvariantCulture);
        }

        public bool ToBoolean(object value)
        {
            return this.method_0<bool>(value);
        }

        public byte ToByte(object value)
        {
            return this.method_0<byte>(value);
        }

        public char ToChar(object value)
        {
            return this.method_0<char>(value);
        }

        public DateTime ToDateTime(object value)
        {
            return this.method_0<DateTime>(value);
        }

        public decimal ToDecimal(object value)
        {
            return this.method_0<decimal>(value);
        }

        public double ToDouble(object value)
        {
            return this.method_0<double>(value);
        }

        public short ToInt16(object value)
        {
            return this.method_0<short>(value);
        }

        public int ToInt32(object value)
        {
            return this.method_0<int>(value);
        }

        public long ToInt64(object value)
        {
            return this.method_0<long>(value);
        }

        public sbyte ToSByte(object value)
        {
            return this.method_0<sbyte>(value);
        }

        public float ToSingle(object value)
        {
            return this.method_0<float>(value);
        }

        public string ToString(object value)
        {
            return this.method_0<string>(value);
        }

        public ushort ToUInt16(object value)
        {
            return this.method_0<ushort>(value);
        }

        public uint ToUInt32(object value)
        {
            return this.method_0<uint>(value);
        }

        public ulong ToUInt64(object value)
        {
            return this.method_0<ulong>(value);
        }
    }
}

