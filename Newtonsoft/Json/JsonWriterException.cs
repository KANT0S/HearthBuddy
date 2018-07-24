namespace Newtonsoft.Json
{
    using ns18;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;

    [Serializable]
    public class JsonWriterException : JsonException
    {
        public JsonWriterException()
        {
        }

        public JsonWriterException(string message) : base(message)
        {
        }

        public JsonWriterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public JsonWriterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        internal JsonWriterException(string message, Exception innerException, string path) : base(message, innerException)
        {
            this.Path = path;
        }

        internal static JsonWriterException smethod_1(JsonWriter jsonWriter_0, string string_0, Exception exception_0)
        {
            return smethod_2(jsonWriter_0.String_0, string_0, exception_0);
        }

        internal static JsonWriterException smethod_2(string string_0, string string_1, Exception exception_0)
        {
            string_1 = Struct25.smethod_2(null, string_0, string_1);
            return new JsonWriterException(string_1, exception_0, string_0);
        }

        public string Path { get; private set; }
    }
}

