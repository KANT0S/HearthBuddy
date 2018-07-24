namespace Newtonsoft.Json
{
    using ns18;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;

    [Serializable]
    public class JsonReaderException : JsonException
    {
        public JsonReaderException()
        {
        }

        public JsonReaderException(string message) : base(message)
        {
        }

        public JsonReaderException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public JsonReaderException(string message, Exception innerException) : base(message, innerException)
        {
        }

        internal JsonReaderException(string message, Exception innerException, string path, int lineNumber, int linePosition) : base(message, innerException)
        {
            this.Path = path;
            this.LineNumber = lineNumber;
            this.LinePosition = linePosition;
        }

        internal static JsonReaderException smethod_1(JsonReader jsonReader_0, string string_0)
        {
            return smethod_2(jsonReader_0, string_0, null);
        }

        internal static JsonReaderException smethod_2(JsonReader jsonReader_0, string string_0, Exception exception_0)
        {
            return smethod_3(jsonReader_0 as IJsonLineInfo, jsonReader_0.String_0, string_0, exception_0);
        }

        internal static JsonReaderException smethod_3(IJsonLineInfo ijsonLineInfo_0, string string_0, string string_1, Exception exception_0)
        {
            int lineNumber;
            int linePosition;
            string_1 = Struct25.smethod_2(ijsonLineInfo_0, string_0, string_1);
            if ((ijsonLineInfo_0 != null) && ijsonLineInfo_0.HasLineInfo())
            {
                lineNumber = ijsonLineInfo_0.LineNumber;
                linePosition = ijsonLineInfo_0.LinePosition;
            }
            else
            {
                lineNumber = 0;
                linePosition = 0;
            }
            return new JsonReaderException(string_1, exception_0, string_0, lineNumber, linePosition);
        }

        public int LineNumber { get; private set; }

        public int LinePosition { get; private set; }

        public string Path { get; private set; }
    }
}

