namespace Newtonsoft.Json
{
    using ns18;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class JsonException : Exception
    {
        public JsonException()
        {
        }

        public JsonException(string message) : base(message)
        {
        }

        public JsonException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public JsonException(string message, Exception innerException) : base(message, innerException)
        {
        }

        internal static JsonException smethod_0(IJsonLineInfo ijsonLineInfo_0, string string_0, string string_1)
        {
            string_1 = Struct25.smethod_2(ijsonLineInfo_0, string_0, string_1);
            return new JsonException(string_1);
        }
    }
}

