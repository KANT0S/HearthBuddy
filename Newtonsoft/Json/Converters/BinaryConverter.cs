namespace Newtonsoft.Json.Converters
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Data.SqlTypes;
    using System.Globalization;

    public class BinaryConverter : JsonConverter
    {
        private const string string_0 = "System.Data.Linq.Binary";

        public override bool CanConvert(Type objectType)
        {
            if (!objectType.smethod_14("System.Data.Linq.Binary") && (!(objectType == typeof(SqlBinary)) && !(objectType == typeof(SqlBinary?))))
            {
                return false;
            }
            return true;
        }

        private byte[] method_0(object object_0)
        {
            if (object_0.GetType().smethod_14("System.Data.Linq.Binary"))
            {
                return Class163.smethod_5<Interface8>(object_0).imethod_0();
            }
            if (!(object_0 is SqlBinary))
            {
                throw new JsonSerializationException("Unexpected value type when writing binary: {0}".smethod_0(CultureInfo.InvariantCulture, object_0.GetType()));
            }
            SqlBinary binary = (SqlBinary) object_0;
            return binary.Value;
        }

        private byte[] method_1(JsonReader jsonReader_0)
        {
            List<byte> list = new List<byte>();
            while (jsonReader_0.Read())
            {
                switch (jsonReader_0.JsonToken_0)
                {
                    case JsonToken.Comment:
                    {
                        continue;
                    }
                    case JsonToken.Integer:
                    {
                        list.Add(Convert.ToByte(jsonReader_0.Object_0, CultureInfo.InvariantCulture));
                        continue;
                    }
                    case JsonToken.EndArray:
                        return list.ToArray();
                }
                throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected token when reading bytes: {0}".smethod_0(CultureInfo.InvariantCulture, jsonReader_0.JsonToken_0));
            }
            throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected end when reading bytes.");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            byte[] buffer;
            Type type = Class194.smethod_10(objectType) ? Nullable.GetUnderlyingType(objectType) : objectType;
            if (reader.JsonToken_0 == JsonToken.Null)
            {
                if (!Class194.smethod_9(objectType))
                {
                    throw JsonSerializationException.smethod_1(reader, "Cannot convert null value to {0}.".smethod_0(CultureInfo.InvariantCulture, objectType));
                }
                return null;
            }
            if (reader.JsonToken_0 == JsonToken.StartArray)
            {
                buffer = this.method_1(reader);
            }
            else
            {
                if (reader.JsonToken_0 != JsonToken.String)
                {
                    throw JsonSerializationException.smethod_1(reader, "Unexpected token parsing binary. Expected String or StartArray, got {0}.".smethod_0(CultureInfo.InvariantCulture, reader.JsonToken_0));
                }
                buffer = Convert.FromBase64String(reader.Object_0.ToString());
            }
            if (type.smethod_14("System.Data.Linq.Binary"))
            {
                return Activator.CreateInstance(type, new object[] { buffer });
            }
            if (type != typeof(SqlBinary))
            {
                throw JsonSerializationException.smethod_1(reader, "Unexpected object type when writing binary: {0}".smethod_0(CultureInfo.InvariantCulture, objectType));
            }
            return new SqlBinary(buffer);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                byte[] buffer = this.method_0(value);
                writer.WriteValue(buffer);
            }
        }
    }
}

