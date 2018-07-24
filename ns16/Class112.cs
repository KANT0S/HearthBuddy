namespace ns16
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using ns20;
    using System;
    using System.Globalization;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters;

    internal class Class112 : JsonSerializer
    {
        private readonly Class136 class136_0;
        private readonly Class137 class137_0;
        private readonly JsonSerializer jsonSerializer_0;

        public event EventHandler<ErrorEventArgs> Event_0
        {
            add
            {
                this.jsonSerializer_0.Event_0 += value;
            }
            remove
            {
                this.jsonSerializer_0.Event_0 -= value;
            }
        }

        public Class112(Class136 serializerReader)
        {
            Class203.smethod_2(serializerReader, "serializerReader");
            this.class136_0 = serializerReader;
            this.jsonSerializer_0 = serializerReader.jsonSerializer_0;
        }

        public Class112(Class137 serializerWriter)
        {
            Class203.smethod_2(serializerWriter, "serializerWriter");
            this.class137_0 = serializerWriter;
            this.jsonSerializer_0 = serializerWriter.jsonSerializer_0;
        }

        internal Class135 method_4()
        {
            if (this.class136_0 != null)
            {
                return this.class136_0;
            }
            return this.class137_0;
        }

        object JsonSerializer.‍⁬⁪⁮⁫‪‬‫‮‮‍⁬‌⁪‫‌⁫‫‏‌⁬⁯‭‬‌‬⁭⁪⁮⁬⁬⁬‭⁫‏⁬‬‏​‎‮(JsonReader jsonReader_0, Type type_0)
        {
            if (this.class136_0 != null)
            {
                return this.class136_0.method_5(jsonReader_0, type_0, false);
            }
            return this.jsonSerializer_0.Deserialize(jsonReader_0, type_0);
        }

        void JsonSerializer.⁯‫‭‭‫⁪‭‎⁭‭‎⁭⁮​⁯​‬‌‏‫‌⁮⁮‫‬‌‪⁫⁬⁫‎‮⁭‏‪‭‭‫‎⁫‮(JsonWriter jsonWriter_0, object object_0, Type type_0)
        {
            if (this.class137_0 != null)
            {
                this.class137_0.method_3(jsonWriter_0, object_0, type_0);
            }
            else
            {
                this.jsonSerializer_0.Serialize(jsonWriter_0, object_0);
            }
        }

        void JsonSerializer.⁬⁬‍⁯⁫​⁯⁭⁮⁪‍​⁭‪‍‎⁭‪‏⁫⁬‍‭‬⁮‬⁪‬​⁯⁯⁪‏‎⁪‌‎‌‬⁯‮(JsonReader jsonReader_0, object object_0)
        {
            if (this.class136_0 != null)
            {
                this.class136_0.method_3(jsonReader_0, object_0);
            }
            else
            {
                this.jsonSerializer_0.Populate(jsonReader_0, object_0);
            }
        }

        public override bool Boolean_0
        {
            get
            {
                return this.jsonSerializer_0.Boolean_0;
            }
            set
            {
                this.jsonSerializer_0.Boolean_0 = value;
            }
        }

        public override ConstructorHandling ConstructorHandling_0
        {
            get
            {
                return this.jsonSerializer_0.ConstructorHandling_0;
            }
            set
            {
                this.jsonSerializer_0.ConstructorHandling_0 = value;
            }
        }

        public override CultureInfo CultureInfo_0
        {
            get
            {
                return this.jsonSerializer_0.CultureInfo_0;
            }
            set
            {
                this.jsonSerializer_0.CultureInfo_0 = value;
            }
        }

        public override DateFormatHandling DateFormatHandling_0
        {
            get
            {
                return this.jsonSerializer_0.DateFormatHandling_0;
            }
            set
            {
                this.jsonSerializer_0.DateFormatHandling_0 = value;
            }
        }

        public override DateParseHandling DateParseHandling_0
        {
            get
            {
                return this.jsonSerializer_0.DateParseHandling_0;
            }
            set
            {
                this.jsonSerializer_0.DateParseHandling_0 = value;
            }
        }

        public override DateTimeZoneHandling DateTimeZoneHandling_0
        {
            get
            {
                return this.jsonSerializer_0.DateTimeZoneHandling_0;
            }
            set
            {
                this.jsonSerializer_0.DateTimeZoneHandling_0 = value;
            }
        }

        public override DefaultValueHandling DefaultValueHandling_0
        {
            get
            {
                return this.jsonSerializer_0.DefaultValueHandling_0;
            }
            set
            {
                this.jsonSerializer_0.DefaultValueHandling_0 = value;
            }
        }

        public override FloatFormatHandling FloatFormatHandling_0
        {
            get
            {
                return this.jsonSerializer_0.FloatFormatHandling_0;
            }
            set
            {
                this.jsonSerializer_0.FloatFormatHandling_0 = value;
            }
        }

        public override FloatParseHandling FloatParseHandling_0
        {
            get
            {
                return this.jsonSerializer_0.FloatParseHandling_0;
            }
            set
            {
                this.jsonSerializer_0.FloatParseHandling_0 = value;
            }
        }

        public override FormatterAssemblyStyle FormatterAssemblyStyle_0
        {
            get
            {
                return this.jsonSerializer_0.FormatterAssemblyStyle_0;
            }
            set
            {
                this.jsonSerializer_0.FormatterAssemblyStyle_0 = value;
            }
        }

        public override Formatting Formatting_0
        {
            get
            {
                return this.jsonSerializer_0.Formatting_0;
            }
            set
            {
                this.jsonSerializer_0.Formatting_0 = value;
            }
        }

        public override IContractResolver IContractResolver_0
        {
            get
            {
                return this.jsonSerializer_0.IContractResolver_0;
            }
            set
            {
                this.jsonSerializer_0.IContractResolver_0 = value;
            }
        }

        public override IReferenceResolver IReferenceResolver_0
        {
            get
            {
                return this.jsonSerializer_0.IReferenceResolver_0;
            }
            set
            {
                this.jsonSerializer_0.IReferenceResolver_0 = value;
            }
        }

        public override ITraceWriter ITraceWriter_0
        {
            get
            {
                return this.jsonSerializer_0.ITraceWriter_0;
            }
            set
            {
                this.jsonSerializer_0.ITraceWriter_0 = value;
            }
        }

        public override JsonConverterCollection JsonConverterCollection_0
        {
            get
            {
                return this.jsonSerializer_0.JsonConverterCollection_0;
            }
        }

        public override MissingMemberHandling MissingMemberHandling_0
        {
            get
            {
                return this.jsonSerializer_0.MissingMemberHandling_0;
            }
            set
            {
                this.jsonSerializer_0.MissingMemberHandling_0 = value;
            }
        }

        public override NullValueHandling NullValueHandling_0
        {
            get
            {
                return this.jsonSerializer_0.NullValueHandling_0;
            }
            set
            {
                this.jsonSerializer_0.NullValueHandling_0 = value;
            }
        }

        public override ObjectCreationHandling ObjectCreationHandling_0
        {
            get
            {
                return this.jsonSerializer_0.ObjectCreationHandling_0;
            }
            set
            {
                this.jsonSerializer_0.ObjectCreationHandling_0 = value;
            }
        }

        public override PreserveReferencesHandling PreserveReferencesHandling_0
        {
            get
            {
                return this.jsonSerializer_0.PreserveReferencesHandling_0;
            }
            set
            {
                this.jsonSerializer_0.PreserveReferencesHandling_0 = value;
            }
        }

        public override int? Prop_0
        {
            get
            {
                return this.jsonSerializer_0.Prop_0;
            }
            set
            {
                this.jsonSerializer_0.Prop_0 = value;
            }
        }

        public override ReferenceLoopHandling ReferenceLoopHandling_0
        {
            get
            {
                return this.jsonSerializer_0.ReferenceLoopHandling_0;
            }
            set
            {
                this.jsonSerializer_0.ReferenceLoopHandling_0 = value;
            }
        }

        public override SerializationBinder SerializationBinder_0
        {
            get
            {
                return this.jsonSerializer_0.SerializationBinder_0;
            }
            set
            {
                this.jsonSerializer_0.SerializationBinder_0 = value;
            }
        }

        public override StreamingContext StreamingContext_0
        {
            get
            {
                return this.jsonSerializer_0.StreamingContext_0;
            }
            set
            {
                this.jsonSerializer_0.StreamingContext_0 = value;
            }
        }

        public override string String_0
        {
            get
            {
                return this.jsonSerializer_0.String_0;
            }
            set
            {
                this.jsonSerializer_0.String_0 = value;
            }
        }

        public override StringEscapeHandling StringEscapeHandling_0
        {
            get
            {
                return this.jsonSerializer_0.StringEscapeHandling_0;
            }
            set
            {
                this.jsonSerializer_0.StringEscapeHandling_0 = value;
            }
        }

        public override TypeNameHandling TypeNameHandling_0
        {
            get
            {
                return this.jsonSerializer_0.TypeNameHandling_0;
            }
            set
            {
                this.jsonSerializer_0.TypeNameHandling_0 = value;
            }
        }
    }
}

