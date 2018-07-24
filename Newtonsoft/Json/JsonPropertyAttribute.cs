namespace Newtonsoft.Json
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple=false)]
    public sealed class JsonPropertyAttribute : Attribute
    {
        internal Newtonsoft.Json.NullValueHandling? nullable_0;
        internal Newtonsoft.Json.DefaultValueHandling? nullable_1;
        internal Newtonsoft.Json.TypeNameHandling? nullable_10;
        internal Newtonsoft.Json.ReferenceLoopHandling? nullable_2;
        internal Newtonsoft.Json.ObjectCreationHandling? nullable_3;
        internal Newtonsoft.Json.TypeNameHandling? nullable_4;
        internal bool? nullable_5;
        internal int? nullable_6;
        internal Newtonsoft.Json.Required? nullable_7;
        internal bool? nullable_8;
        internal Newtonsoft.Json.ReferenceLoopHandling? nullable_9;
        [CompilerGenerated]
        private string string_0;
        [CompilerGenerated]
        private Type type_0;

        public JsonPropertyAttribute()
        {
        }

        public JsonPropertyAttribute(string propertyName)
        {
            this.PropertyName = propertyName;
        }

        public Newtonsoft.Json.DefaultValueHandling DefaultValueHandling
        {
            get
            {
                Newtonsoft.Json.DefaultValueHandling? nullable = this.nullable_1;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.DefaultValueHandling.Include;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_1 = new Newtonsoft.Json.DefaultValueHandling?(value);
            }
        }

        public bool IsReference
        {
            get
            {
                bool? nullable = this.nullable_5;
                if (!nullable.HasValue)
                {
                    return false;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_5 = new bool?(value);
            }
        }

        public Type ItemConverterType
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

        public bool ItemIsReference
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

        public Newtonsoft.Json.ReferenceLoopHandling ItemReferenceLoopHandling
        {
            get
            {
                Newtonsoft.Json.ReferenceLoopHandling? nullable = this.nullable_9;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.ReferenceLoopHandling.Error;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_9 = new Newtonsoft.Json.ReferenceLoopHandling?(value);
            }
        }

        public Newtonsoft.Json.TypeNameHandling ItemTypeNameHandling
        {
            get
            {
                Newtonsoft.Json.TypeNameHandling? nullable = this.nullable_10;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.TypeNameHandling.None;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_10 = new Newtonsoft.Json.TypeNameHandling?(value);
            }
        }

        public Newtonsoft.Json.NullValueHandling NullValueHandling
        {
            get
            {
                Newtonsoft.Json.NullValueHandling? nullable = this.nullable_0;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.NullValueHandling.Include;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_0 = new Newtonsoft.Json.NullValueHandling?(value);
            }
        }

        public Newtonsoft.Json.ObjectCreationHandling ObjectCreationHandling
        {
            get
            {
                Newtonsoft.Json.ObjectCreationHandling? nullable = this.nullable_3;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.ObjectCreationHandling.Auto;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_3 = new Newtonsoft.Json.ObjectCreationHandling?(value);
            }
        }

        public int Order
        {
            get
            {
                int? nullable = this.nullable_6;
                if (!nullable.HasValue)
                {
                    return 0;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_6 = new int?(value);
            }
        }

        public string PropertyName
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
            [CompilerGenerated]
            set
            {
                this.string_0 = value;
            }
        }

        public Newtonsoft.Json.ReferenceLoopHandling ReferenceLoopHandling
        {
            get
            {
                Newtonsoft.Json.ReferenceLoopHandling? nullable = this.nullable_2;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.ReferenceLoopHandling.Error;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_2 = new Newtonsoft.Json.ReferenceLoopHandling?(value);
            }
        }

        public Newtonsoft.Json.Required Required
        {
            get
            {
                Newtonsoft.Json.Required? nullable = this.nullable_7;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.Required.Default;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_7 = new Newtonsoft.Json.Required?(value);
            }
        }

        public Newtonsoft.Json.TypeNameHandling TypeNameHandling
        {
            get
            {
                Newtonsoft.Json.TypeNameHandling? nullable = this.nullable_4;
                if (!nullable.HasValue)
                {
                    return Newtonsoft.Json.TypeNameHandling.None;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_4 = new Newtonsoft.Json.TypeNameHandling?(value);
            }
        }
    }
}

