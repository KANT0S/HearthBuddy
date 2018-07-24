namespace Newtonsoft.Json.Converters
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;

    public class ExpandoObjectConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(ExpandoObject));
        }

        private object method_0(JsonReader jsonReader_0)
        {
        Label_000B:
            switch (jsonReader_0.JsonToken_0)
            {
                case JsonToken.StartObject:
                    return this.method_2(jsonReader_0);

                case JsonToken.StartArray:
                    return this.method_1(jsonReader_0);

                case JsonToken.Comment:
                    if (!jsonReader_0.Read())
                    {
                        throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected end when reading ExpandoObject.");
                    }
                    goto Label_000B;
            }
            if (!JsonReader.smethod_0(jsonReader_0.JsonToken_0))
            {
                throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected token when converting ExpandoObject: {0}".smethod_0(CultureInfo.InvariantCulture, jsonReader_0.JsonToken_0));
            }
            return jsonReader_0.Object_0;
        }

        private object method_1(JsonReader jsonReader_0)
        {
            IList<object> list = new List<object>();
            while (jsonReader_0.Read())
            {
                JsonToken token = jsonReader_0.JsonToken_0;
                if (token != JsonToken.Comment)
                {
                    if (token == JsonToken.EndArray)
                    {
                        return list;
                    }
                    object item = this.method_0(jsonReader_0);
                    list.Add(item);
                }
            }
            throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected end when reading ExpandoObject.");
        }

        private object method_2(JsonReader jsonReader_0)
        {
            IDictionary<string, object> dictionary = new ExpandoObject();
            while (jsonReader_0.Read())
            {
                switch (jsonReader_0.JsonToken_0)
                {
                    case JsonToken.PropertyName:
                    {
                        string str = jsonReader_0.Object_0.ToString();
                        if (!jsonReader_0.Read())
                        {
                            throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected end when reading ExpandoObject.");
                        }
                        object obj2 = this.method_0(jsonReader_0);
                        dictionary[str] = obj2;
                        break;
                    }
                    case JsonToken.EndObject:
                        return dictionary;
                }
            }
            throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected end when reading ExpandoObject.");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return this.method_0(reader);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }

        public override bool CanWrite
        {
            get
            {
                return false;
            }
        }
    }
}

