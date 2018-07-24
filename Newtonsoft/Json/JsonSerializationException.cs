namespace Newtonsoft.Json
{
    using ns18;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class JsonSerializationException : JsonException
    {
        public JsonSerializationException()
        {
        }

        public JsonSerializationException(string message) : base(message)
        {
        }

        public JsonSerializationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public JsonSerializationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        internal static JsonSerializationException smethod_1(JsonReader jsonReader_0, string string_0)
        {
            return smethod_2(jsonReader_0, string_0, null);
        }

        internal static JsonSerializationException smethod_2(JsonReader jsonReader_0, string string_0, Exception exception_0)
        {
            return smethod_3(jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, string_0, exception_0);
        }

        internal static JsonSerializationException smethod_3(IJsonLineInfo ijsonLineInfo_0, string string_0, string string_1, Exception exception_0)
        {
            string_1 = Struct25.smethod_2(ijsonLineInfo_0, string_0, string_1);
            return new JsonSerializationException(string_1, exception_0);
        }
    }
}

