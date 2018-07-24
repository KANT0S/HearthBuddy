namespace Newtonsoft.Json.Serialization
{
    using System;
    using System.Diagnostics;

    public interface ITraceWriter
    {
        void Trace(TraceLevel level, string message, Exception ex);

        TraceLevel LevelFilter { get; }
    }
}

