namespace Newtonsoft.Json
{
    using Newtonsoft.Json.Serialization;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters;

    public class JsonSerializerSettings
    {
        internal const bool bool_0 = false;
        internal bool bool_1;
        internal bool bool_2;
        internal const Newtonsoft.Json.ConstructorHandling constructorHandling_0 = Newtonsoft.Json.ConstructorHandling.Default;
        internal static readonly CultureInfo cultureInfo_0 = CultureInfo.InvariantCulture;
        internal CultureInfo cultureInfo_1;
        internal const Newtonsoft.Json.DateFormatHandling dateFormatHandling_0 = Newtonsoft.Json.DateFormatHandling.IsoDateFormat;
        internal const Newtonsoft.Json.DateParseHandling dateParseHandling_0 = Newtonsoft.Json.DateParseHandling.DateTime;
        internal const Newtonsoft.Json.DateTimeZoneHandling dateTimeZoneHandling_0 = Newtonsoft.Json.DateTimeZoneHandling.RoundtripKind;
        internal const Newtonsoft.Json.DefaultValueHandling defaultValueHandling_0 = Newtonsoft.Json.DefaultValueHandling.Include;
        [CompilerGenerated]
        private EventHandler<ErrorEventArgs> eventHandler_0;
        internal const Newtonsoft.Json.FloatFormatHandling floatFormatHandling_0 = Newtonsoft.Json.FloatFormatHandling.String;
        internal const Newtonsoft.Json.FloatParseHandling floatParseHandling_0 = Newtonsoft.Json.FloatParseHandling.Double;
        internal const FormatterAssemblyStyle formatterAssemblyStyle_0 = FormatterAssemblyStyle.Simple;
        internal const FormatterAssemblyStyle formatterAssemblyStyle_1 = FormatterAssemblyStyle.Simple;
        internal const Newtonsoft.Json.Formatting formatting_0 = Newtonsoft.Json.Formatting.None;
        [CompilerGenerated]
        private IContractResolver icontractResolver_0;
        [CompilerGenerated]
        private IList<JsonConverter> ilist_0;
        [CompilerGenerated]
        private IReferenceResolver ireferenceResolver_0;
        [CompilerGenerated]
        private ITraceWriter itraceWriter_0;
        internal const Newtonsoft.Json.MissingMemberHandling missingMemberHandling_0 = Newtonsoft.Json.MissingMemberHandling.Ignore;
        internal Newtonsoft.Json.Formatting? nullable_0;
        internal Newtonsoft.Json.DateFormatHandling? nullable_1;
        internal Newtonsoft.Json.DefaultValueHandling? nullable_10;
        internal Newtonsoft.Json.PreserveReferencesHandling? nullable_11;
        internal Newtonsoft.Json.NullValueHandling? nullable_12;
        internal Newtonsoft.Json.ObjectCreationHandling? nullable_13;
        internal Newtonsoft.Json.MissingMemberHandling? nullable_14;
        internal Newtonsoft.Json.ReferenceLoopHandling? nullable_15;
        internal StreamingContext? nullable_16;
        internal Newtonsoft.Json.ConstructorHandling? nullable_17;
        internal Newtonsoft.Json.TypeNameHandling? nullable_18;
        internal Newtonsoft.Json.DateTimeZoneHandling? nullable_2;
        internal Newtonsoft.Json.DateParseHandling? nullable_3;
        internal Newtonsoft.Json.FloatFormatHandling? nullable_4;
        internal Newtonsoft.Json.FloatParseHandling? nullable_5;
        internal Newtonsoft.Json.StringEscapeHandling? nullable_6;
        internal bool? nullable_7;
        internal int? nullable_8;
        internal FormatterAssemblyStyle? nullable_9;
        internal const Newtonsoft.Json.NullValueHandling nullValueHandling_0 = Newtonsoft.Json.NullValueHandling.Include;
        internal const Newtonsoft.Json.ObjectCreationHandling objectCreationHandling_0 = Newtonsoft.Json.ObjectCreationHandling.Auto;
        internal const Newtonsoft.Json.PreserveReferencesHandling preserveReferencesHandling_0 = Newtonsoft.Json.PreserveReferencesHandling.None;
        internal const Newtonsoft.Json.ReferenceLoopHandling referenceLoopHandling_0 = Newtonsoft.Json.ReferenceLoopHandling.Error;
        [CompilerGenerated]
        private SerializationBinder serializationBinder_0;
        internal static readonly StreamingContext streamingContext_0 = new StreamingContext();
        internal const string string_0 = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
        internal string string_1;
        internal const Newtonsoft.Json.StringEscapeHandling stringEscapeHandling_0 = Newtonsoft.Json.StringEscapeHandling.Default;
        internal const Newtonsoft.Json.TypeNameHandling typeNameHandling_0 = Newtonsoft.Json.TypeNameHandling.None;

        public JsonSerializerSettings()
        {
            this.Converters = new List<JsonConverter>();
        }

        public SerializationBinder Binder
        {
            [CompilerGenerated]
            get
            {
                return this.serializationBinder_0;
            }
            [CompilerGenerated]
            set
            {
                this.serializationBinder_0 = value;
            }
        }

        public bool CheckAdditionalContent
        {
            get
            {
                bool? nullable = this.nullable_7;
                if (!nullable.HasValue)
                {
                    return false;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_7 = new bool?(value);
            }
        }

        public Newtonsoft.Json.ConstructorHandling ConstructorHandling
        {
            get
            {
                Newtonsoft.Json.ConstructorHandling? nullable = this.nullable_17;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.ConstructorHandling.Default;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_17 = new Newtonsoft.Json.ConstructorHandling?(value);
            }
        }

        public StreamingContext Context
        {
            get
            {
                StreamingContext? nullable = this.nullable_16;
                if (!nullable.HasValue)
                {
                    return streamingContext_0;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_16 = new StreamingContext?(value);
            }
        }

        public IContractResolver ContractResolver
        {
            [CompilerGenerated]
            get
            {
                return this.icontractResolver_0;
            }
            [CompilerGenerated]
            set
            {
                this.icontractResolver_0 = value;
            }
        }

        public IList<JsonConverter> Converters
        {
            [CompilerGenerated]
            get
            {
                return this.ilist_0;
            }
            [CompilerGenerated]
            set
            {
                this.ilist_0 = value;
            }
        }

        public CultureInfo Culture
        {
            get
            {
                return (this.cultureInfo_1 ?? cultureInfo_0);
            }
            set
            {
                this.cultureInfo_1 = value;
            }
        }

        public Newtonsoft.Json.DateFormatHandling DateFormatHandling
        {
            get
            {
                Newtonsoft.Json.DateFormatHandling? nullable = this.nullable_1;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.DateFormatHandling.IsoDateFormat;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_1 = new Newtonsoft.Json.DateFormatHandling?(value);
            }
        }

        public string DateFormatString
        {
            get
            {
                return (this.string_1 ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK");
            }
            set
            {
                this.string_1 = value;
                this.bool_2 = true;
            }
        }

        public Newtonsoft.Json.DateParseHandling DateParseHandling
        {
            get
            {
                Newtonsoft.Json.DateParseHandling? nullable = this.nullable_3;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.DateParseHandling.DateTime;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_3 = new Newtonsoft.Json.DateParseHandling?(value);
            }
        }

        public Newtonsoft.Json.DateTimeZoneHandling DateTimeZoneHandling
        {
            get
            {
                Newtonsoft.Json.DateTimeZoneHandling? nullable = this.nullable_2;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.DateTimeZoneHandling.RoundtripKind;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_2 = new Newtonsoft.Json.DateTimeZoneHandling?(value);
            }
        }

        public Newtonsoft.Json.DefaultValueHandling DefaultValueHandling
        {
            get
            {
                Newtonsoft.Json.DefaultValueHandling? nullable = this.nullable_10;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.DefaultValueHandling.Include;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_10 = new Newtonsoft.Json.DefaultValueHandling?(value);
            }
        }

        public EventHandler<ErrorEventArgs> Error
        {
            [CompilerGenerated]
            get
            {
                return this.eventHandler_0;
            }
            [CompilerGenerated]
            set
            {
                this.eventHandler_0 = value;
            }
        }

        public Newtonsoft.Json.FloatFormatHandling FloatFormatHandling
        {
            get
            {
                Newtonsoft.Json.FloatFormatHandling? nullable = this.nullable_4;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.FloatFormatHandling.String;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_4 = new Newtonsoft.Json.FloatFormatHandling?(value);
            }
        }

        public Newtonsoft.Json.FloatParseHandling FloatParseHandling
        {
            get
            {
                Newtonsoft.Json.FloatParseHandling? nullable = this.nullable_5;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.FloatParseHandling.Double;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_5 = new Newtonsoft.Json.FloatParseHandling?(value);
            }
        }

        public Newtonsoft.Json.Formatting Formatting
        {
            get
            {
                Newtonsoft.Json.Formatting? nullable = this.nullable_0;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.Formatting.None;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_0 = new Newtonsoft.Json.Formatting?(value);
            }
        }

        public int? MaxDepth
        {
            get
            {
                return this.nullable_8;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value must be positive.", "value");
                }
                this.nullable_8 = value;
                this.bool_1 = true;
            }
        }

        public Newtonsoft.Json.MissingMemberHandling MissingMemberHandling
        {
            get
            {
                Newtonsoft.Json.MissingMemberHandling? nullable = this.nullable_14;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.MissingMemberHandling.Ignore;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_14 = new Newtonsoft.Json.MissingMemberHandling?(value);
            }
        }

        public Newtonsoft.Json.NullValueHandling NullValueHandling
        {
            get
            {
                Newtonsoft.Json.NullValueHandling? nullable = this.nullable_12;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.NullValueHandling.Include;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_12 = new Newtonsoft.Json.NullValueHandling?(value);
            }
        }

        public Newtonsoft.Json.ObjectCreationHandling ObjectCreationHandling
        {
            get
            {
                Newtonsoft.Json.ObjectCreationHandling? nullable = this.nullable_13;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.ObjectCreationHandling.Auto;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_13 = new Newtonsoft.Json.ObjectCreationHandling?(value);
            }
        }

        public Newtonsoft.Json.PreserveReferencesHandling PreserveReferencesHandling
        {
            get
            {
                Newtonsoft.Json.PreserveReferencesHandling? nullable = this.nullable_11;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.PreserveReferencesHandling.None;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_11 = new Newtonsoft.Json.PreserveReferencesHandling?(value);
            }
        }

        public Newtonsoft.Json.ReferenceLoopHandling ReferenceLoopHandling
        {
            get
            {
                Newtonsoft.Json.ReferenceLoopHandling? nullable = this.nullable_15;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.ReferenceLoopHandling.Error;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_15 = new Newtonsoft.Json.ReferenceLoopHandling?(value);
            }
        }

        public IReferenceResolver ReferenceResolver
        {
            [CompilerGenerated]
            get
            {
                return this.ireferenceResolver_0;
            }
            [CompilerGenerated]
            set
            {
                this.ireferenceResolver_0 = value;
            }
        }

        public Newtonsoft.Json.StringEscapeHandling StringEscapeHandling
        {
            get
            {
                Newtonsoft.Json.StringEscapeHandling? nullable = this.nullable_6;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.StringEscapeHandling.Default;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_6 = new Newtonsoft.Json.StringEscapeHandling?(value);
            }
        }

        public ITraceWriter TraceWriter
        {
            [CompilerGenerated]
            get
            {
                return this.itraceWriter_0;
            }
            [CompilerGenerated]
            set
            {
                this.itraceWriter_0 = value;
            }
        }

        public FormatterAssemblyStyle TypeNameAssemblyFormat
        {
            get
            {
                FormatterAssemblyStyle? nullable = this.nullable_9;
                if (!nullable.HasValue)
                {
                    return FormatterAssemblyStyle.Simple;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_9 = new FormatterAssemblyStyle?(value);
            }
        }

        public Newtonsoft.Json.TypeNameHandling TypeNameHandling
        {
            get
            {
                Newtonsoft.Json.TypeNameHandling? nullable = this.nullable_18;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.TypeNameHandling.None;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_18 = new Newtonsoft.Json.TypeNameHandling?(value);
            }
        }
    }
}

