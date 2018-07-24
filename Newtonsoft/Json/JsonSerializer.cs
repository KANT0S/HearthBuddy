namespace Newtonsoft.Json
{
    using Newtonsoft.Json.Serialization;
    using ns16;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters;
    using System.Threading;

    public class JsonSerializer
    {
        private bool bool_0;
        private bool bool_1;
        internal ConstructorHandling constructorHandling_0 = ConstructorHandling.Default;
        private CultureInfo cultureInfo_0 = JsonSerializerSettings.cultureInfo_0;
        internal DefaultValueHandling defaultValueHandling_0 = DefaultValueHandling.Include;
        internal FormatterAssemblyStyle formatterAssemblyStyle_0;
        internal IContractResolver icontractResolver_0 = DefaultContractResolver.IContractResolver_0;
        private IReferenceResolver ireferenceResolver_0;
        internal ITraceWriter itraceWriter_0;
        internal JsonConverterCollection jsonConverterCollection_0;
        internal MissingMemberHandling missingMemberHandling_0 = MissingMemberHandling.Ignore;
        private Formatting? nullable_0;
        private DateFormatHandling? nullable_1;
        private DateTimeZoneHandling? nullable_2;
        private DateParseHandling? nullable_3;
        private FloatFormatHandling? nullable_4;
        private FloatParseHandling? nullable_5;
        private StringEscapeHandling? nullable_6;
        private int? nullable_7;
        private bool? nullable_8;
        internal NullValueHandling nullValueHandling_0 = NullValueHandling.Include;
        internal ObjectCreationHandling objectCreationHandling_0 = ObjectCreationHandling.Auto;
        internal PreserveReferencesHandling preserveReferencesHandling_0 = PreserveReferencesHandling.None;
        internal ReferenceLoopHandling referenceLoopHandling_0 = ReferenceLoopHandling.Error;
        internal SerializationBinder serializationBinder_0 = DefaultSerializationBinder.defaultSerializationBinder_0;
        internal StreamingContext streamingContext_0 = JsonSerializerSettings.streamingContext_0;
        private string string_0;
        internal TypeNameHandling typeNameHandling_0 = TypeNameHandling.None;

        public event EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Event_0;

        public static JsonSerializer Create()
        {
            return new JsonSerializer();
        }

        public static JsonSerializer Create(JsonSerializerSettings settings)
        {
            JsonSerializer serializer = Create();
            if (settings != null)
            {
                smethod_0(serializer, settings);
            }
            return serializer;
        }

        public static JsonSerializer CreateDefault()
        {
            Func<JsonSerializerSettings> defaultSettings = JsonConvert.DefaultSettings;
            JsonSerializerSettings settings = (defaultSettings != null) ? defaultSettings() : null;
            return Create(settings);
        }

        public static JsonSerializer CreateDefault(JsonSerializerSettings settings)
        {
            JsonSerializer serializer = CreateDefault();
            if (settings != null)
            {
                smethod_0(serializer, settings);
            }
            return serializer;
        }

        public object Deserialize(JsonReader reader)
        {
            return this.Deserialize(reader, null);
        }

        public T Deserialize<T>(JsonReader reader)
        {
            return (T) this.Deserialize(reader, typeof(T));
        }

        public object Deserialize(JsonReader reader, Type objectType)
        {
            return this.Newtonsoft.Json.JsonSerializer.‍⁬⁪⁮⁫‪‬‫‮‮‍⁬‌⁪‫‌⁫‫‏‌⁬⁯‭‬‌‬⁭⁪⁮⁬⁬⁬‭⁫‏⁬‬‏​‎‮(reader, objectType);
        }

        public object Deserialize(TextReader reader, Type objectType)
        {
            return this.Deserialize(new JsonTextReader(reader), objectType);
        }

        internal bool method_0()
        {
            return this.nullable_8.HasValue;
        }

        internal IReferenceResolver method_1()
        {
            if (this.ireferenceResolver_0 == null)
            {
                this.ireferenceResolver_0 = new Class90();
            }
            return this.ireferenceResolver_0;
        }

        internal JsonConverter method_2(Type type_0)
        {
            return smethod_1(this.jsonConverterCollection_0, type_0);
        }

        internal void method_3(Newtonsoft.Json.Serialization.ErrorEventArgs errorEventArgs_0)
        {
            EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> handler = this.eventHandler_0;
            if (handler != null)
            {
                handler(this, errorEventArgs_0);
            }
        }

        internal virtual object Newtonsoft.Json.JsonSerializer.‍⁬⁪⁮⁫‪‬‫‮‮‍⁬‌⁪‫‌⁫‫‏‌⁬⁯‭‬‌‬⁭⁪⁮⁬⁬⁬‭⁫‏⁬‬‏​‎‮(JsonReader jsonReader_0, Type type_0)
        {
            Class203.smethod_2(jsonReader_0, "reader");
            CultureInfo culture = null;
            if ((this.cultureInfo_0 != null) && !this.cultureInfo_0.Equals(jsonReader_0.Culture))
            {
                culture = jsonReader_0.Culture;
                jsonReader_0.Culture = this.cultureInfo_0;
            }
            DateTimeZoneHandling? nullable = null;
            if (this.nullable_2.HasValue)
            {
                if (jsonReader_0.DateTimeZoneHandling != ((DateTimeZoneHandling) this.nullable_2))
                {
                    nullable = new DateTimeZoneHandling?(jsonReader_0.DateTimeZoneHandling);
                    jsonReader_0.DateTimeZoneHandling = this.nullable_2.Value;
                }
            }
            DateParseHandling? nullable2 = null;
            if (this.nullable_3.HasValue)
            {
                if (jsonReader_0.DateParseHandling != ((DateParseHandling) this.nullable_3))
                {
                    nullable2 = new DateParseHandling?(jsonReader_0.DateParseHandling);
                    jsonReader_0.DateParseHandling = this.nullable_3.Value;
                }
            }
            FloatParseHandling? nullable3 = null;
            if (this.nullable_5.HasValue)
            {
                if (jsonReader_0.FloatParseHandling != ((FloatParseHandling) this.nullable_5))
                {
                    nullable3 = new FloatParseHandling?(jsonReader_0.FloatParseHandling);
                    jsonReader_0.FloatParseHandling = this.nullable_5.Value;
                }
            }
            int? maxDepth = null;
            if (this.bool_0 && (jsonReader_0.MaxDepth != this.nullable_7))
            {
                maxDepth = jsonReader_0.MaxDepth;
                jsonReader_0.MaxDepth = this.nullable_7;
            }
            Class68 class2 = ((this.ITraceWriter_0 == null) || (this.ITraceWriter_0.LevelFilter < TraceLevel.Verbose)) ? null : new Class68(jsonReader_0);
            object obj2 = new Class136(this).method_5(class2 ?? jsonReader_0, type_0, this.Boolean_0);
            if (class2 != null)
            {
                this.ITraceWriter_0.Trace(TraceLevel.Verbose, "Deserialized JSON: " + Environment.NewLine + class2.method_14(), null);
            }
            if (culture != null)
            {
                jsonReader_0.Culture = culture;
            }
            if (nullable.HasValue)
            {
                jsonReader_0.DateTimeZoneHandling = nullable.Value;
            }
            if (nullable2.HasValue)
            {
                jsonReader_0.DateParseHandling = nullable2.Value;
            }
            if (nullable3.HasValue)
            {
                jsonReader_0.FloatParseHandling = nullable3.Value;
            }
            if (this.bool_0)
            {
                jsonReader_0.MaxDepth = maxDepth;
            }
            return obj2;
        }

        internal virtual void Newtonsoft.Json.JsonSerializer.⁯‫‭‭‫⁪‭‎⁭‭‎⁭⁮​⁯​‬‌‏‫‌⁮⁮‫‬‌‪⁫⁬⁫‎‮⁭‏‪‭‭‫‎⁫‮(JsonWriter jsonWriter_0, object object_0, Type type_0)
        {
            Class203.smethod_2(jsonWriter_0, "jsonWriter");
            Formatting? nullable = null;
            if (this.nullable_0.HasValue)
            {
                if (jsonWriter_0.Formatting != ((Formatting) this.nullable_0))
                {
                    nullable = new Formatting?(jsonWriter_0.Formatting);
                    jsonWriter_0.Formatting = this.nullable_0.Value;
                }
            }
            DateFormatHandling? nullable2 = null;
            if (this.nullable_1.HasValue)
            {
                if (jsonWriter_0.DateFormatHandling != ((DateFormatHandling) this.nullable_1))
                {
                    nullable2 = new DateFormatHandling?(jsonWriter_0.DateFormatHandling);
                    jsonWriter_0.DateFormatHandling = this.nullable_1.Value;
                }
            }
            DateTimeZoneHandling? nullable3 = null;
            if (this.nullable_2.HasValue)
            {
                if (jsonWriter_0.DateTimeZoneHandling != ((DateTimeZoneHandling) this.nullable_2))
                {
                    nullable3 = new DateTimeZoneHandling?(jsonWriter_0.DateTimeZoneHandling);
                    jsonWriter_0.DateTimeZoneHandling = this.nullable_2.Value;
                }
            }
            FloatFormatHandling? nullable4 = null;
            if (this.nullable_4.HasValue)
            {
                if (jsonWriter_0.FloatFormatHandling != ((FloatFormatHandling) this.nullable_4))
                {
                    nullable4 = new FloatFormatHandling?(jsonWriter_0.FloatFormatHandling);
                    jsonWriter_0.FloatFormatHandling = this.nullable_4.Value;
                }
            }
            StringEscapeHandling? nullable5 = null;
            if (this.nullable_6.HasValue)
            {
                if (jsonWriter_0.StringEscapeHandling != ((StringEscapeHandling) this.nullable_6))
                {
                    nullable5 = new StringEscapeHandling?(jsonWriter_0.StringEscapeHandling);
                    jsonWriter_0.StringEscapeHandling = this.nullable_6.Value;
                }
            }
            CultureInfo culture = null;
            if ((this.cultureInfo_0 != null) && !this.cultureInfo_0.Equals(jsonWriter_0.Culture))
            {
                culture = jsonWriter_0.Culture;
                jsonWriter_0.Culture = this.cultureInfo_0;
            }
            string dateFormatString = null;
            if (this.bool_1 && (jsonWriter_0.DateFormatString != this.string_0))
            {
                dateFormatString = jsonWriter_0.DateFormatString;
                jsonWriter_0.DateFormatString = this.string_0;
            }
            Class78 class2 = ((this.ITraceWriter_0 == null) || (this.ITraceWriter_0.LevelFilter < TraceLevel.Verbose)) ? null : new Class78(jsonWriter_0);
            new Class137(this).method_3(class2 ?? jsonWriter_0, object_0, type_0);
            if (class2 != null)
            {
                this.ITraceWriter_0.Trace(TraceLevel.Verbose, "Serialized JSON: " + Environment.NewLine + class2.method_20(), null);
            }
            if (nullable.HasValue)
            {
                jsonWriter_0.Formatting = nullable.Value;
            }
            if (nullable2.HasValue)
            {
                jsonWriter_0.DateFormatHandling = nullable2.Value;
            }
            if (nullable3.HasValue)
            {
                jsonWriter_0.DateTimeZoneHandling = nullable3.Value;
            }
            if (nullable4.HasValue)
            {
                jsonWriter_0.FloatFormatHandling = nullable4.Value;
            }
            if (nullable5.HasValue)
            {
                jsonWriter_0.StringEscapeHandling = nullable5.Value;
            }
            if (this.bool_1)
            {
                jsonWriter_0.DateFormatString = dateFormatString;
            }
            if (culture != null)
            {
                jsonWriter_0.Culture = culture;
            }
        }

        internal virtual void Newtonsoft.Json.JsonSerializer.⁬⁬‍⁯⁫​⁯⁭⁮⁪‍​⁭‪‍‎⁭‪‏⁫⁬‍‭‬⁮‬⁪‬​⁯⁯⁪‏‎⁪‌‎‌‬⁯‮(JsonReader jsonReader_0, object object_0)
        {
            Class203.smethod_2(jsonReader_0, "reader");
            Class203.smethod_2(object_0, "target");
            new Class136(this).method_3(jsonReader_0, object_0);
        }

        public void Populate(JsonReader reader, object target)
        {
            this.Newtonsoft.Json.JsonSerializer.⁬⁬‍⁯⁫​⁯⁭⁮⁪‍​⁭‪‍‎⁭‪‏⁫⁬‍‭‬⁮‬⁪‬​⁯⁯⁪‏‎⁪‌‎‌‬⁯‮(reader, target);
        }

        public void Populate(TextReader reader, object target)
        {
            this.Populate(new JsonTextReader(reader), target);
        }

        public void Serialize(JsonWriter jsonWriter, object value)
        {
            this.Newtonsoft.Json.JsonSerializer.⁯‫‭‭‫⁪‭‎⁭‭‎⁭⁮​⁯​‬‌‏‫‌⁮⁮‫‬‌‪⁫⁬⁫‎‮⁭‏‪‭‭‫‎⁫‮(jsonWriter, value, null);
        }

        public void Serialize(TextWriter textWriter, object value)
        {
            this.Serialize(new JsonTextWriter(textWriter), value);
        }

        public void Serialize(JsonWriter jsonWriter, object value, Type objectType)
        {
            this.Newtonsoft.Json.JsonSerializer.⁯‫‭‭‫⁪‭‎⁭‭‎⁭⁮​⁯​‬‌‏‫‌⁮⁮‫‬‌‪⁫⁬⁫‎‮⁭‏‪‭‭‫‎⁫‮(jsonWriter, value, objectType);
        }

        public void Serialize(TextWriter textWriter, object value, Type objectType)
        {
            this.Serialize(new JsonTextWriter(textWriter), value, objectType);
        }

        private static void smethod_0(JsonSerializer jsonSerializer_0, JsonSerializerSettings jsonSerializerSettings_0)
        {
            if (!Class191.smethod_0<JsonConverter>(jsonSerializerSettings_0.Converters))
            {
                for (int i = 0; i < jsonSerializerSettings_0.Converters.Count; i++)
                {
                    jsonSerializer_0.JsonConverterCollection_0.Insert(i, jsonSerializerSettings_0.Converters[i]);
                }
            }
            if (jsonSerializerSettings_0.nullable_18.HasValue)
            {
                jsonSerializer_0.TypeNameHandling_0 = jsonSerializerSettings_0.TypeNameHandling;
            }
            if (jsonSerializerSettings_0.nullable_9.HasValue)
            {
                jsonSerializer_0.FormatterAssemblyStyle_0 = jsonSerializerSettings_0.TypeNameAssemblyFormat;
            }
            if (jsonSerializerSettings_0.nullable_11.HasValue)
            {
                jsonSerializer_0.PreserveReferencesHandling_0 = jsonSerializerSettings_0.PreserveReferencesHandling;
            }
            if (jsonSerializerSettings_0.nullable_15.HasValue)
            {
                jsonSerializer_0.ReferenceLoopHandling_0 = jsonSerializerSettings_0.ReferenceLoopHandling;
            }
            if (jsonSerializerSettings_0.nullable_14.HasValue)
            {
                jsonSerializer_0.MissingMemberHandling_0 = jsonSerializerSettings_0.MissingMemberHandling;
            }
            if (jsonSerializerSettings_0.nullable_13.HasValue)
            {
                jsonSerializer_0.ObjectCreationHandling_0 = jsonSerializerSettings_0.ObjectCreationHandling;
            }
            if (jsonSerializerSettings_0.nullable_12.HasValue)
            {
                jsonSerializer_0.NullValueHandling_0 = jsonSerializerSettings_0.NullValueHandling;
            }
            if (jsonSerializerSettings_0.nullable_10.HasValue)
            {
                jsonSerializer_0.DefaultValueHandling_0 = jsonSerializerSettings_0.DefaultValueHandling;
            }
            if (jsonSerializerSettings_0.nullable_17.HasValue)
            {
                jsonSerializer_0.ConstructorHandling_0 = jsonSerializerSettings_0.ConstructorHandling;
            }
            if (jsonSerializerSettings_0.nullable_16.HasValue)
            {
                jsonSerializer_0.StreamingContext_0 = jsonSerializerSettings_0.Context;
            }
            if (jsonSerializerSettings_0.nullable_7.HasValue)
            {
                jsonSerializer_0.nullable_8 = jsonSerializerSettings_0.nullable_7;
            }
            if (jsonSerializerSettings_0.Error != null)
            {
                jsonSerializer_0.Event_0 += jsonSerializerSettings_0.Error;
            }
            if (jsonSerializerSettings_0.ContractResolver != null)
            {
                jsonSerializer_0.IContractResolver_0 = jsonSerializerSettings_0.ContractResolver;
            }
            if (jsonSerializerSettings_0.ReferenceResolver != null)
            {
                jsonSerializer_0.IReferenceResolver_0 = jsonSerializerSettings_0.ReferenceResolver;
            }
            if (jsonSerializerSettings_0.TraceWriter != null)
            {
                jsonSerializer_0.ITraceWriter_0 = jsonSerializerSettings_0.TraceWriter;
            }
            if (jsonSerializerSettings_0.Binder != null)
            {
                jsonSerializer_0.SerializationBinder_0 = jsonSerializerSettings_0.Binder;
            }
            if (jsonSerializerSettings_0.nullable_0.HasValue)
            {
                jsonSerializer_0.nullable_0 = jsonSerializerSettings_0.nullable_0;
            }
            if (jsonSerializerSettings_0.nullable_1.HasValue)
            {
                jsonSerializer_0.nullable_1 = jsonSerializerSettings_0.nullable_1;
            }
            if (jsonSerializerSettings_0.nullable_2.HasValue)
            {
                jsonSerializer_0.nullable_2 = jsonSerializerSettings_0.nullable_2;
            }
            if (jsonSerializerSettings_0.nullable_3.HasValue)
            {
                jsonSerializer_0.nullable_3 = jsonSerializerSettings_0.nullable_3;
            }
            if (jsonSerializerSettings_0.bool_2)
            {
                jsonSerializer_0.string_0 = jsonSerializerSettings_0.string_1;
                jsonSerializer_0.bool_1 = jsonSerializerSettings_0.bool_2;
            }
            if (jsonSerializerSettings_0.nullable_4.HasValue)
            {
                jsonSerializer_0.nullable_4 = jsonSerializerSettings_0.nullable_4;
            }
            if (jsonSerializerSettings_0.nullable_5.HasValue)
            {
                jsonSerializer_0.nullable_5 = jsonSerializerSettings_0.nullable_5;
            }
            if (jsonSerializerSettings_0.nullable_6.HasValue)
            {
                jsonSerializer_0.nullable_6 = jsonSerializerSettings_0.nullable_6;
            }
            if (jsonSerializerSettings_0.cultureInfo_1 != null)
            {
                jsonSerializer_0.cultureInfo_0 = jsonSerializerSettings_0.cultureInfo_1;
            }
            if (jsonSerializerSettings_0.bool_1)
            {
                jsonSerializer_0.nullable_7 = jsonSerializerSettings_0.nullable_8;
                jsonSerializer_0.bool_0 = jsonSerializerSettings_0.bool_1;
            }
        }

        internal static JsonConverter smethod_1(IList<JsonConverter> ilist_0, Type type_0)
        {
            if (ilist_0 != null)
            {
                for (int i = 0; i < ilist_0.Count; i++)
                {
                    JsonConverter converter = ilist_0[i];
                    if (converter.CanConvert(type_0))
                    {
                        return converter;
                    }
                }
            }
            return null;
        }

        public virtual bool Boolean_0
        {
            get
            {
                bool? nullable = this.nullable_8;
                if (!nullable.HasValue)
                {
                    return false;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_8 = new bool?(value);
            }
        }

        public virtual ConstructorHandling ConstructorHandling_0
        {
            get
            {
                return this.constructorHandling_0;
            }
            set
            {
                if ((value < ConstructorHandling.Default) || (value > ConstructorHandling.AllowNonPublicDefaultConstructor))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                this.constructorHandling_0 = value;
            }
        }

        public virtual CultureInfo CultureInfo_0
        {
            get
            {
                return (this.cultureInfo_0 ?? JsonSerializerSettings.cultureInfo_0);
            }
            set
            {
                this.cultureInfo_0 = value;
            }
        }

        public virtual DateFormatHandling DateFormatHandling_0
        {
            get
            {
                DateFormatHandling? nullable = this.nullable_1;
                if (!nullable.HasValue)
                {
                    return DateFormatHandling.IsoDateFormat;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_1 = new DateFormatHandling?(value);
            }
        }

        public virtual DateParseHandling DateParseHandling_0
        {
            get
            {
                DateParseHandling? nullable = this.nullable_3;
                if (!nullable.HasValue)
                {
                    return DateParseHandling.DateTime;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_3 = new DateParseHandling?(value);
            }
        }

        public virtual DateTimeZoneHandling DateTimeZoneHandling_0
        {
            get
            {
                DateTimeZoneHandling? nullable = this.nullable_2;
                if (!nullable.HasValue)
                {
                    return DateTimeZoneHandling.RoundtripKind;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_2 = new DateTimeZoneHandling?(value);
            }
        }

        public virtual DefaultValueHandling DefaultValueHandling_0
        {
            get
            {
                return this.defaultValueHandling_0;
            }
            set
            {
                if ((value < DefaultValueHandling.Include) || (value > DefaultValueHandling.IgnoreAndPopulate))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                this.defaultValueHandling_0 = value;
            }
        }

        public virtual FloatFormatHandling FloatFormatHandling_0
        {
            get
            {
                FloatFormatHandling? nullable = this.nullable_4;
                if (!nullable.HasValue)
                {
                    return FloatFormatHandling.String;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_4 = new FloatFormatHandling?(value);
            }
        }

        public virtual FloatParseHandling FloatParseHandling_0
        {
            get
            {
                FloatParseHandling? nullable = this.nullable_5;
                if (!nullable.HasValue)
                {
                    return FloatParseHandling.Double;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_5 = new FloatParseHandling?(value);
            }
        }

        public virtual FormatterAssemblyStyle FormatterAssemblyStyle_0
        {
            get
            {
                return this.formatterAssemblyStyle_0;
            }
            set
            {
                if ((value < FormatterAssemblyStyle.Simple) || (value > FormatterAssemblyStyle.Full))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                this.formatterAssemblyStyle_0 = value;
            }
        }

        public virtual Formatting Formatting_0
        {
            get
            {
                Formatting? nullable = this.nullable_0;
                if (!nullable.HasValue)
                {
                    return Formatting.None;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_0 = new Formatting?(value);
            }
        }

        public virtual IContractResolver IContractResolver_0
        {
            get
            {
                return this.icontractResolver_0;
            }
            set
            {
                this.icontractResolver_0 = value ?? DefaultContractResolver.IContractResolver_0;
            }
        }

        public virtual IReferenceResolver IReferenceResolver_0
        {
            get
            {
                return this.method_1();
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "Reference resolver cannot be null.");
                }
                this.ireferenceResolver_0 = value;
            }
        }

        public virtual ITraceWriter ITraceWriter_0
        {
            get
            {
                return this.itraceWriter_0;
            }
            set
            {
                this.itraceWriter_0 = value;
            }
        }

        public virtual JsonConverterCollection JsonConverterCollection_0
        {
            get
            {
                if (this.jsonConverterCollection_0 == null)
                {
                    this.jsonConverterCollection_0 = new JsonConverterCollection();
                }
                return this.jsonConverterCollection_0;
            }
        }

        public virtual MissingMemberHandling MissingMemberHandling_0
        {
            get
            {
                return this.missingMemberHandling_0;
            }
            set
            {
                if ((value < MissingMemberHandling.Ignore) || (value > MissingMemberHandling.Error))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                this.missingMemberHandling_0 = value;
            }
        }

        public virtual NullValueHandling NullValueHandling_0
        {
            get
            {
                return this.nullValueHandling_0;
            }
            set
            {
                if ((value < NullValueHandling.Include) || (value > NullValueHandling.Ignore))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                this.nullValueHandling_0 = value;
            }
        }

        public virtual ObjectCreationHandling ObjectCreationHandling_0
        {
            get
            {
                return this.objectCreationHandling_0;
            }
            set
            {
                if ((value < ObjectCreationHandling.Auto) || (value > ObjectCreationHandling.Replace))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                this.objectCreationHandling_0 = value;
            }
        }

        public virtual PreserveReferencesHandling PreserveReferencesHandling_0
        {
            get
            {
                return this.preserveReferencesHandling_0;
            }
            set
            {
                if ((value < PreserveReferencesHandling.None) || (value > PreserveReferencesHandling.All))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                this.preserveReferencesHandling_0 = value;
            }
        }

        public virtual int? Prop_0
        {
            get
            {
                return this.nullable_7;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value must be positive.", "value");
                }
                this.nullable_7 = value;
                this.bool_0 = true;
            }
        }

        public virtual ReferenceLoopHandling ReferenceLoopHandling_0
        {
            get
            {
                return this.referenceLoopHandling_0;
            }
            set
            {
                if ((value < ReferenceLoopHandling.Error) || (value > ReferenceLoopHandling.Serialize))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                this.referenceLoopHandling_0 = value;
            }
        }

        public virtual SerializationBinder SerializationBinder_0
        {
            get
            {
                return this.serializationBinder_0;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "Serialization binder cannot be null.");
                }
                this.serializationBinder_0 = value;
            }
        }

        public virtual StreamingContext StreamingContext_0
        {
            get
            {
                return this.streamingContext_0;
            }
            set
            {
                this.streamingContext_0 = value;
            }
        }

        public virtual string String_0
        {
            get
            {
                return (this.string_0 ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK");
            }
            set
            {
                this.string_0 = value;
                this.bool_1 = true;
            }
        }

        public virtual StringEscapeHandling StringEscapeHandling_0
        {
            get
            {
                StringEscapeHandling? nullable = this.nullable_6;
                if (!nullable.HasValue)
                {
                    return StringEscapeHandling.Default;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_6 = new StringEscapeHandling?(value);
            }
        }

        public virtual TypeNameHandling TypeNameHandling_0
        {
            get
            {
                return this.typeNameHandling_0;
            }
            set
            {
                if ((value < TypeNameHandling.None) || (value > TypeNameHandling.Auto))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                this.typeNameHandling_0 = value;
            }
        }
    }
}

