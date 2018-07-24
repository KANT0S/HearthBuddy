namespace Newtonsoft.Json.Converters
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Bson;
    using Newtonsoft.Json.Serialization;
    using System;
    using System.Text.RegularExpressions;

    public class RegexConverter : JsonConverter
    {
        private const string string_0 = "Pattern";
        private const string string_1 = "Options";

        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Regex));
        }

        private bool method_0(RegexOptions regexOptions_0, RegexOptions regexOptions_1)
        {
            return ((regexOptions_0 & regexOptions_1) == regexOptions_1);
        }

        private void method_1(BsonWriter bsonWriter_0, Regex regex_0)
        {
            string options = null;
            if (this.method_0(regex_0.Options, RegexOptions.IgnoreCase))
            {
                options = options + "i";
            }
            if (this.method_0(regex_0.Options, RegexOptions.Multiline))
            {
                options = options + "m";
            }
            if (this.method_0(regex_0.Options, RegexOptions.Singleline))
            {
                options = options + "s";
            }
            options = options + "u";
            if (this.method_0(regex_0.Options, RegexOptions.ExplicitCapture))
            {
                options = options + "x";
            }
            bsonWriter_0.WriteRegex(regex_0.ToString(), options);
        }

        private void method_2(JsonWriter jsonWriter_0, Regex regex_0, JsonSerializer jsonSerializer_0)
        {
            DefaultContractResolver resolver = jsonSerializer_0.IContractResolver_0 as DefaultContractResolver;
            jsonWriter_0.WriteStartObject();
            jsonWriter_0.WritePropertyName((resolver != null) ? resolver.GetResolvedPropertyName("Pattern") : "Pattern");
            jsonWriter_0.WriteValue(regex_0.ToString());
            jsonWriter_0.WritePropertyName((resolver != null) ? resolver.GetResolvedPropertyName("Options") : "Options");
            jsonSerializer_0.Serialize(jsonWriter_0, regex_0.Options);
            jsonWriter_0.WriteEndObject();
        }

        private object method_3(JsonReader jsonReader_0)
        {
            string str = (string) jsonReader_0.Object_0;
            int num = str.LastIndexOf('/');
            string pattern = str.Substring(1, num - 1);
            string str3 = str.Substring(num + 1);
            RegexOptions none = RegexOptions.None;
            foreach (char ch in str3)
            {
                switch (ch)
                {
                    case 'i':
                        none |= RegexOptions.IgnoreCase;
                        break;

                    case 'm':
                        none |= RegexOptions.Multiline;
                        break;

                    case 's':
                        none |= RegexOptions.Singleline;
                        break;

                    case 'x':
                        none |= RegexOptions.ExplicitCapture;
                        break;
                }
            }
            return new Regex(pattern, none);
        }

        private Regex method_4(JsonReader jsonReader_0, JsonSerializer jsonSerializer_0)
        {
            string pattern = null;
            RegexOptions? nullable = null;
            while (jsonReader_0.Read())
            {
                string str2;
                switch (jsonReader_0.JsonToken_0)
                {
                    case JsonToken.PropertyName:
                    {
                        str2 = jsonReader_0.Object_0.ToString();
                        if (!jsonReader_0.Read())
                        {
                            throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected end when reading Regex.");
                        }
                        if (!string.Equals(str2, "Pattern", StringComparison.OrdinalIgnoreCase))
                        {
                            break;
                        }
                        pattern = (string) jsonReader_0.Object_0;
                        continue;
                    }
                    case JsonToken.Comment:
                    {
                        continue;
                    }
                    case JsonToken.EndObject:
                    {
                        if (pattern == null)
                        {
                            throw JsonSerializationException.smethod_1(jsonReader_0, "Error deserializing Regex. No pattern found.");
                        }
                        RegexOptions? nullable2 = nullable;
                        return new Regex(pattern, nullable2.HasValue ? nullable2.GetValueOrDefault() : RegexOptions.None);
                    }
                    default:
                    {
                        continue;
                    }
                }
                if (string.Equals(str2, "Options", StringComparison.OrdinalIgnoreCase))
                {
                    nullable = new RegexOptions?(jsonSerializer_0.Deserialize<RegexOptions>(jsonReader_0));
                }
                else
                {
                    jsonReader_0.Skip();
                }
            }
            throw JsonSerializationException.smethod_1(jsonReader_0, "Unexpected end when reading Regex.");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.JsonToken_0 == JsonToken.StartObject)
            {
                return this.method_4(reader, serializer);
            }
            if (reader.JsonToken_0 != JsonToken.String)
            {
                throw JsonSerializationException.smethod_1(reader, "Unexpected token when reading Regex.");
            }
            return this.method_3(reader);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Regex regex = (Regex) value;
            BsonWriter writer2 = writer as BsonWriter;
            if (writer2 != null)
            {
                this.method_1(writer2, regex);
            }
            else
            {
                this.method_2(writer, regex, serializer);
            }
        }
    }
}

