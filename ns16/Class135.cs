namespace ns16
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using ns18;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    internal abstract class Class135
    {
        private bool bool_0;
        private Class179<string, object> class179_0;
        private ErrorContext errorContext_0;
        internal readonly ITraceWriter itraceWriter_0;
        internal readonly JsonSerializer jsonSerializer_0;

        protected Class135(JsonSerializer serializer)
        {
            Class203.smethod_2(serializer, "serializer");
            this.jsonSerializer_0 = serializer;
            this.itraceWriter_0 = serializer.ITraceWriter_0;
            this.bool_0 = base.GetType() == typeof(Class137);
        }

        private ErrorContext method_0(object object_0, object object_1, string string_0, Exception exception_0)
        {
            if (this.errorContext_0 == null)
            {
                this.errorContext_0 = new ErrorContext(object_0, object_1, string_0, exception_0);
            }
            if (this.errorContext_0.Error != exception_0)
            {
                throw new InvalidOperationException("Current error context error is different to requested error.");
            }
            return this.errorContext_0;
        }

        protected void method_1()
        {
            if (this.errorContext_0 == null)
            {
                throw new InvalidOperationException("Could not clear error context. Error context is already null.");
            }
            this.errorContext_0 = null;
        }

        protected bool method_2(object object_0, JsonContract jsonContract_0, object object_1, IJsonLineInfo ijsonLineInfo_0, string string_0, Exception exception_0)
        {
            ErrorContext context = this.method_0(object_0, object_1, string_0, exception_0);
            if (((this.itraceWriter_0 != null) && (this.itraceWriter_0.LevelFilter >= TraceLevel.Error)) && !context.Boolean_0)
            {
                context.Boolean_0 = true;
                string str = this.bool_0 ? "Error serializing" : "Error deserializing";
                if (jsonContract_0 != null)
                {
                    str = str + " " + jsonContract_0.UnderlyingType;
                }
                str = str + ". " + exception_0.Message;
                if (!(exception_0 is JsonException))
                {
                    str = Struct25.smethod_2(ijsonLineInfo_0, string_0, str);
                }
                this.itraceWriter_0.Trace(TraceLevel.Error, str, exception_0);
            }
            if (jsonContract_0 != null)
            {
                jsonContract_0.method_4(object_0, this.jsonSerializer_0.StreamingContext_0, context);
            }
            if (!context.Handled)
            {
                this.jsonSerializer_0.method_3(new ErrorEventArgs(object_0, context));
            }
            return context.Handled;
        }

        internal Class179<string, object> Class179_0
        {
            get
            {
                if (this.class179_0 == null)
                {
                    this.class179_0 = new Class179<string, object>(EqualityComparer<string>.Default, new Class138(), "A different value already has the Id '{0}'.", "A different Id has already been assigned for value '{0}'.");
                }
                return this.class179_0;
            }
        }

        private class Class138 : IEqualityComparer<object>
        {
            bool IEqualityComparer<object>.Equals(object x, object y)
            {
                return object.ReferenceEquals(x, y);
            }

            int IEqualityComparer<object>.GetHashCode(object obj)
            {
                return RuntimeHelpers.GetHashCode(obj);
            }
        }
    }
}

