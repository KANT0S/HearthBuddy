namespace Newtonsoft.Json.Converters
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Globalization;

    public class JavaScriptDateTimeConverter : DateTimeConverterBase
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            Type type = Class194.smethod_10(objectType) ? Nullable.GetUnderlyingType(objectType) : objectType;
            if (reader.JsonToken_0 == JsonToken.Null)
            {
                if (!Class194.smethod_9(objectType))
                {
                    throw JsonSerializationException.smethod_1(reader, "Cannot convert null value to {0}.".smethod_0(CultureInfo.InvariantCulture, objectType));
                }
                return null;
            }
            if ((reader.JsonToken_0 != JsonToken.StartConstructor) || !string.Equals(reader.Object_0.ToString(), "Date", StringComparison.Ordinal))
            {
                throw JsonSerializationException.smethod_1(reader, "Unexpected token or value when parsing date. Token: {0}, Value: {1}".smethod_1(CultureInfo.InvariantCulture, reader.JsonToken_0, reader.Object_0));
            }
            reader.Read();
            if (reader.JsonToken_0 != JsonToken.Integer)
            {
                throw JsonSerializationException.smethod_1(reader, "Unexpected token parsing date. Expected Integer, got {0}.".smethod_0(CultureInfo.InvariantCulture, reader.JsonToken_0));
            }
            long num = (long) reader.Object_0;
            DateTime dateTime = Class184.smethod_11(num);
            reader.Read();
            if (reader.JsonToken_0 != JsonToken.EndConstructor)
            {
                throw JsonSerializationException.smethod_1(reader, "Unexpected token parsing date. Expected EndConstructor, got {0}.".smethod_0(CultureInfo.InvariantCulture, reader.JsonToken_0));
            }
            if (!(type == typeof(DateTimeOffset)))
            {
                return dateTime;
            }
            return new DateTimeOffset(dateTime);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            long num;
            if (value is DateTime)
            {
                num = Class184.smethod_8(((DateTime) value).ToUniversalTime());
            }
            else
            {
                if (!(value is DateTimeOffset))
                {
                    throw new JsonSerializationException("Expected date object value.");
                }
                DateTimeOffset offset = (DateTimeOffset) value;
                num = Class184.smethod_8(offset.ToUniversalTime().UtcDateTime);
            }
            writer.WriteStartConstructor("Date");
            writer.WriteValue(num);
            writer.WriteEndConstructor();
        }
    }
}

