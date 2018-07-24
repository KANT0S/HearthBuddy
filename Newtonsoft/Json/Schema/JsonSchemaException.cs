namespace Newtonsoft.Json.Schema
{
    using Newtonsoft.Json;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;

    [Serializable]
    public class JsonSchemaException : JsonException
    {
        public JsonSchemaException()
        {
        }

        public JsonSchemaException(string message) : base(message)
        {
        }

        public JsonSchemaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public JsonSchemaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        internal JsonSchemaException(string message, Exception innerException, string path, int lineNumber, int linePosition) : base(message, innerException)
        {
            this.Path = path;
            this.LineNumber = lineNumber;
            this.LinePosition = linePosition;
        }

        public int LineNumber { get; private set; }

        public int LinePosition { get; private set; }

        public string Path { get; private set; }
    }
}

