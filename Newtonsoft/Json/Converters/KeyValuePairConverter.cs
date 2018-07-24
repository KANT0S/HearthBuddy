namespace Newtonsoft.Json.Converters
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class KeyValuePairConverter : JsonConverter
    {
        private const string string_0 = "Key";
        private const string string_1 = "Value";

        public override bool CanConvert(Type objectType)
        {
            Type type = Class194.smethod_10(objectType) ? Nullable.GetUnderlyingType(objectType) : objectType;
            return ((type.smethod_12() && type.smethod_4()) && (type.GetGenericTypeDefinition() == typeof(KeyValuePair<,>)));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            bool flag = Class194.smethod_10(objectType);
            if (reader.JsonToken_0 == JsonToken.Null)
            {
                if (!flag)
                {
                    throw JsonSerializationException.smethod_1(reader, "Cannot convert null value to KeyValuePair.");
                }
                return null;
            }
            Type type = flag ? Nullable.GetUnderlyingType(objectType) : objectType;
            IList<Type> genericArguments = type.GetGenericArguments();
            Type type2 = genericArguments[0];
            Type type3 = genericArguments[1];
            object obj2 = null;
            object obj3 = null;
            reader.Read();
            while (reader.JsonToken_0 == JsonToken.PropertyName)
            {
                string a = reader.Object_0.ToString();
                if (string.Equals(a, "Key", StringComparison.OrdinalIgnoreCase))
                {
                    reader.Read();
                    obj2 = serializer.Deserialize(reader, type2);
                }
                else if (string.Equals(a, "Value", StringComparison.OrdinalIgnoreCase))
                {
                    reader.Read();
                    obj3 = serializer.Deserialize(reader, type3);
                }
                else
                {
                    reader.Skip();
                }
                reader.Read();
            }
            return Activator.CreateInstance(type, new object[] { obj2, obj3 });
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Type type = value.GetType();
            PropertyInfo property = type.GetProperty("Key");
            PropertyInfo info2 = type.GetProperty("Value");
            DefaultContractResolver resolver = serializer.IContractResolver_0 as DefaultContractResolver;
            writer.WriteStartObject();
            writer.WritePropertyName((resolver != null) ? resolver.GetResolvedPropertyName("Key") : "Key");
            serializer.Serialize(writer, Class194.smethod_23(property, value));
            writer.WritePropertyName((resolver != null) ? resolver.GetResolvedPropertyName("Value") : "Value");
            serializer.Serialize(writer, Class194.smethod_23(info2, value));
            writer.WriteEndObject();
        }
    }
}

