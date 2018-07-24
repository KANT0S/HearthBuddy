namespace Newtonsoft.Json.Serialization
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;

    public delegate void SerializationErrorCallback(object o, StreamingContext context, ErrorContext errorContext);
}

