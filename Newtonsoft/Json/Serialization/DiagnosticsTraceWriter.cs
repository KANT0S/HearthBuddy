namespace Newtonsoft.Json.Serialization
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    public class DiagnosticsTraceWriter : ITraceWriter
    {
        [CompilerGenerated]
        private TraceLevel traceLevel_0;

        private TraceEventType method_0(TraceLevel traceLevel_1)
        {
            switch (traceLevel_1)
            {
                case TraceLevel.Error:
                    return TraceEventType.Error;

                case TraceLevel.Warning:
                    return TraceEventType.Warning;

                case TraceLevel.Info:
                    return TraceEventType.Information;

                case TraceLevel.Verbose:
                    return TraceEventType.Verbose;
            }
            throw new ArgumentOutOfRangeException("level");
        }

        public void Trace(TraceLevel level, string message, Exception ex)
        {
            if (level != TraceLevel.Off)
            {
                TraceEventCache eventCache = new TraceEventCache();
                TraceEventType eventType = this.method_0(level);
                foreach (TraceListener listener in System.Diagnostics.Trace.Listeners)
                {
                    if (!listener.IsThreadSafe)
                    {
                        lock (listener)
                        {
                            listener.TraceEvent(eventCache, "Newtonsoft.Json", eventType, 0, message);
                            goto Label_006E;
                        }
                    }
                    listener.TraceEvent(eventCache, "Newtonsoft.Json", eventType, 0, message);
                Label_006E:
                    if (System.Diagnostics.Trace.AutoFlush)
                    {
                        listener.Flush();
                    }
                }
            }
        }

        public TraceLevel LevelFilter
        {
            [CompilerGenerated]
            get
            {
                return this.traceLevel_0;
            }
            [CompilerGenerated]
            set
            {
                this.traceLevel_0 = value;
            }
        }
    }
}

