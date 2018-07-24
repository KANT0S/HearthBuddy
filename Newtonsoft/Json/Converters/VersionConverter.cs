namespace Newtonsoft.Json.Converters
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Globalization;

    public class VersionConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Version));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.JsonToken_0 == JsonToken.Null)
            {
                return null;
            }
            if (reader.JsonToken_0 == JsonToken.String)
            {
                try
                {
                    return new Version((string) reader.Object_0);
                }
                catch (Exception exception)
                {
                    throw JsonSerializationException.smethod_2(reader, "Error parsing version string: {0}".smethod_0(CultureInfo.InvariantCulture, reader.Object_0), exception);
                }
            }
            throw JsonSerializationException.smethod_1(reader, "Unexpected token or value when parsing version. Token: {0}, Value: {1}".smethod_1(CultureInfo.InvariantCulture, reader.JsonToken_0, reader.Object_0));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                if (!(value is Version))
                {
                    throw new JsonSerializationException("Expected Version object value");
                }
                writer.WriteValue(value.ToString());
            }
        }
    }
}

