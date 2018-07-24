namespace Newtonsoft.Json.Converters
{
    using Newtonsoft.Json;
    using ns16;
    using ns17;
    using ns20;
    using System;
    using System.Globalization;

    public class EntityKeyMemberConverter : JsonConverter
    {
        private const string string_0 = "System.Data.EntityKeyMember";

        public override bool CanConvert(Type objectType)
        {
            return objectType.smethod_14("System.Data.EntityKeyMember");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            Interface9 interface2 = Class163.smethod_5<Interface9>(Activator.CreateInstance(objectType));
            smethod_0(reader, "Key");
            smethod_1(reader);
            interface2.String_0 = reader.Object_0.ToString();
            smethod_0(reader, "Type");
            smethod_1(reader);
            Type type = Type.GetType(reader.Object_0.ToString());
            smethod_0(reader, "Value");
            smethod_1(reader);
            interface2.Object_0 = serializer.Deserialize(reader, type);
            smethod_1(reader);
            return Class163.smethod_3(interface2);
        }

        private static void smethod_0(JsonReader jsonReader_0, string string_1)
        {
            smethod_1(jsonReader_0);
            if ((jsonReader_0.JsonToken_0 != JsonToken.PropertyName) || (jsonReader_0.Object_0.ToString() != string_1))
            {
                throw new JsonSerializationException("Expected JSON property '{0}'.".smethod_0(CultureInfo.InvariantCulture, string_1));
            }
        }

        private static void smethod_1(JsonReader jsonReader_0)
        {
            if (!jsonReader_0.Read())
            {
                throw new JsonSerializationException("Unexpected end.");
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Interface9 interface2 = Class163.smethod_5<Interface9>(value);
            Type type = (interface2.Object_0 != null) ? interface2.Object_0.GetType() : null;
            writer.WriteStartObject();
            writer.WritePropertyName("Key");
            writer.WriteValue(interface2.String_0);
            writer.WritePropertyName("Type");
            writer.WriteValue((type != null) ? type.FullName : null);
            writer.WritePropertyName("Value");
            if (type != null)
            {
                string str;
                if (Class137.smethod_0(interface2.Object_0, type, out str))
                {
                    writer.WriteValue(str);
                }
                else
                {
                    writer.WriteValue(interface2.Object_0);
                }
            }
            else
            {
                writer.WriteNull();
            }
            writer.WriteEndObject();
        }
    }
}

