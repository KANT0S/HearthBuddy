namespace Newtonsoft.Json.Serialization
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Runtime.CompilerServices;

    public class JsonProperty
    {
        [CompilerGenerated]
        private Action<object, object> action_0;
        internal bool bool_0;
        private bool bool_1;
        [CompilerGenerated]
        private bool bool_2;
        [CompilerGenerated]
        private bool bool_3;
        [CompilerGenerated]
        private bool bool_4;
        [CompilerGenerated]
        private bool bool_5;
        [CompilerGenerated]
        private IValueProvider ivalueProvider_0;
        [CompilerGenerated]
        private JsonContract jsonContract_0;
        [CompilerGenerated]
        private JsonConverter jsonConverter_0;
        [CompilerGenerated]
        private JsonConverter jsonConverter_1;
        [CompilerGenerated]
        private JsonConverter jsonConverter_2;
        internal Newtonsoft.Json.Required? nullable_0;
        [CompilerGenerated]
        private int? nullable_1;
        [CompilerGenerated]
        private Newtonsoft.Json.ReferenceLoopHandling? nullable_10;
        [CompilerGenerated]
        private bool? nullable_2;
        [CompilerGenerated]
        private Newtonsoft.Json.NullValueHandling? nullable_3;
        [CompilerGenerated]
        private Newtonsoft.Json.DefaultValueHandling? nullable_4;
        [CompilerGenerated]
        private Newtonsoft.Json.ReferenceLoopHandling? nullable_5;
        [CompilerGenerated]
        private Newtonsoft.Json.ObjectCreationHandling? nullable_6;
        [CompilerGenerated]
        private Newtonsoft.Json.TypeNameHandling? nullable_7;
        [CompilerGenerated]
        private bool? nullable_8;
        [CompilerGenerated]
        private Newtonsoft.Json.TypeNameHandling? nullable_9;
        internal object object_0;
        [CompilerGenerated]
        private Predicate<object> predicate_0;
        [CompilerGenerated]
        private Predicate<object> predicate_1;
        private string string_0;
        [CompilerGenerated]
        private string string_1;
        [CompilerGenerated]
        private Type type_0;
        [CompilerGenerated]
        private Type type_1;

        private void method_0()
        {
            if (this.string_0 == null)
            {
                this.bool_1 = false;
            }
            else
            {
                this.bool_1 = true;
                foreach (char ch in this.string_0)
                {
                    if ((!char.IsLetterOrDigit(ch) && (ch != '_')) && (ch != '@'))
                    {
                        this.bool_1 = false;
                        return;
                    }
                }
            }
        }

        internal object method_1()
        {
            if (!this.bool_0 && (this.PropertyType != null))
            {
                return Class194.smethod_41(this.PropertyType);
            }
            return this.object_0;
        }

        internal void method_2(JsonWriter jsonWriter_0)
        {
            if (this.bool_1)
            {
                jsonWriter_0.WritePropertyName(this.PropertyName, false);
            }
            else
            {
                jsonWriter_0.WritePropertyName(this.PropertyName);
            }
        }

        public override string ToString()
        {
            return this.PropertyName;
        }

        public JsonConverter Converter
        {
            [CompilerGenerated]
            get
            {
                return this.jsonConverter_0;
            }
            [CompilerGenerated]
            set
            {
                this.jsonConverter_0 = value;
            }
        }

        public Type DeclaringType
        {
            [CompilerGenerated]
            get
            {
                return this.type_0;
            }
            [CompilerGenerated]
            set
            {
                this.type_0 = value;
            }
        }

        public object DefaultValue
        {
            get
            {
                return this.object_0;
            }
            set
            {
                this.bool_0 = true;
                this.object_0 = value;
            }
        }

        public Newtonsoft.Json.DefaultValueHandling? DefaultValueHandling
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_4;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_4 = value;
            }
        }

        public Predicate<object> GetIsSpecified
        {
            [CompilerGenerated]
            get
            {
                return this.predicate_1;
            }
            [CompilerGenerated]
            set
            {
                this.predicate_1 = value;
            }
        }

        public bool HasMemberAttribute
        {
            [CompilerGenerated]
            get
            {
                return this.bool_5;
            }
            [CompilerGenerated]
            set
            {
                this.bool_5 = value;
            }
        }

        public bool Ignored
        {
            [CompilerGenerated]
            get
            {
                return this.bool_2;
            }
            [CompilerGenerated]
            set
            {
                this.bool_2 = value;
            }
        }

        public bool? IsReference
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_2;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_2 = value;
            }
        }

        public JsonConverter ItemConverter
        {
            [CompilerGenerated]
            get
            {
                return this.jsonConverter_2;
            }
            [CompilerGenerated]
            set
            {
                this.jsonConverter_2 = value;
            }
        }

        public bool? ItemIsReference
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_8;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_8 = value;
            }
        }

        public Newtonsoft.Json.ReferenceLoopHandling? ItemReferenceLoopHandling
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_10;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_10 = value;
            }
        }

        public Newtonsoft.Json.TypeNameHandling? ItemTypeNameHandling
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_9;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_9 = value;
            }
        }

        internal JsonContract JsonContract_0
        {
            [CompilerGenerated]
            get
            {
                return this.jsonContract_0;
            }
            [CompilerGenerated]
            set
            {
                this.jsonContract_0 = value;
            }
        }

        public JsonConverter MemberConverter
        {
            [CompilerGenerated]
            get
            {
                return this.jsonConverter_1;
            }
            [CompilerGenerated]
            set
            {
                this.jsonConverter_1 = value;
            }
        }

        public Newtonsoft.Json.NullValueHandling? NullValueHandling
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_3;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_3 = value;
            }
        }

        public Newtonsoft.Json.ObjectCreationHandling? ObjectCreationHandling
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_6;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_6 = value;
            }
        }

        public int? Order
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_1;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_1 = value;
            }
        }

        public string PropertyName
        {
            get
            {
                return this.string_0;
            }
            set
            {
                this.string_0 = value;
                this.method_0();
            }
        }

        public Type PropertyType
        {
            [CompilerGenerated]
            get
            {
                return this.type_1;
            }
            [CompilerGenerated]
            set
            {
                this.type_1 = value;
            }
        }

        public bool Readable
        {
            [CompilerGenerated]
            get
            {
                return this.bool_3;
            }
            [CompilerGenerated]
            set
            {
                this.bool_3 = value;
            }
        }

        public Newtonsoft.Json.ReferenceLoopHandling? ReferenceLoopHandling
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_5;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_5 = value;
            }
        }

        public Newtonsoft.Json.Required Required
        {
            get
            {
                Newtonsoft.Json.Required? nullable = this.nullable_0;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.Required.Default;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_0 = new Newtonsoft.Json.Required?(value);
            }
        }

        public Action<object, object> SetIsSpecified
        {
            [CompilerGenerated]
            get
            {
                return this.action_0;
            }
            [CompilerGenerated]
            set
            {
                this.action_0 = value;
            }
        }

        public Predicate<object> ShouldSerialize
        {
            [CompilerGenerated]
            get
            {
                return this.predicate_0;
            }
            [CompilerGenerated]
            set
            {
                this.predicate_0 = value;
            }
        }

        public Newtonsoft.Json.TypeNameHandling? TypeNameHandling
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_7;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_7 = value;
            }
        }

        public string UnderlyingName
        {
            [CompilerGenerated]
            get
            {
                return this.string_1;
            }
            [CompilerGenerated]
            set
            {
                this.string_1 = value;
            }
        }

        public IValueProvider ValueProvider
        {
            [CompilerGenerated]
            get
            {
                return this.ivalueProvider_0;
            }
            [CompilerGenerated]
            set
            {
                this.ivalueProvider_0 = value;
            }
        }

        public bool Writable
        {
            [CompilerGenerated]
            get
            {
                return this.bool_4;
            }
            [CompilerGenerated]
            set
            {
                this.bool_4 = value;
            }
        }
    }
}

