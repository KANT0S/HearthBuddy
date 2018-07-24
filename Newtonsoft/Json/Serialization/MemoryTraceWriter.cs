namespace Newtonsoft.Json.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Text;

    public class MemoryTraceWriter : ITraceWriter
    {
        private readonly Queue<string> queue_0;
        [CompilerGenerated]
        private TraceLevel traceLevel_0;

        public MemoryTraceWriter()
        {
            this.LevelFilter = TraceLevel.Verbose;
            this.queue_0 = new Queue<string>();
        }

        public IEnumerable<string> GetTraceMessages()
        {
            return this.queue_0;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string str in this.queue_0)
            {
                if (builder.Length > 0)
                {
                    builder.AppendLine();
                }
                builder.Append(str);
            }
            return builder.ToString();
        }

        public void Trace(TraceLevel level, string message, Exception ex)
        {
            string item = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff", CultureInfo.InvariantCulture) + " " + level.ToString("g") + " " + message;
            if (this.queue_0.Count >= 0x3e8)
            {
                this.queue_0.Dequeue();
            }
            this.queue_0.Enqueue(item);
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

