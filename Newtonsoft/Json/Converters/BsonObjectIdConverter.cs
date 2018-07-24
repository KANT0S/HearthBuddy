namespace Newtonsoft.Json.Converters
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Bson;
    using ns20;
    using System;
    using System.Globalization;

    public class BsonObjectIdConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(BsonObjectId));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.JsonToken_0 != JsonToken.Bytes)
            {
                throw new JsonSerializationException("Expected Bytes but got {0}.".smethod_0(CultureInfo.InvariantCulture, reader.JsonToken_0));
            }
            return new BsonObjectId((byte[]) reader.Object_0);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            BsonObjectId id = (BsonObjectId) value;
            BsonWriter writer2 = writer as BsonWriter;
            if (writer2 != null)
            {
                writer2.WriteObjectId(id.Value);
            }
            else
            {
                writer.WriteValue(id.Value);
            }
        }
    }
}

