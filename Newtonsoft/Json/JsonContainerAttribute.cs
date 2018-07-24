namespace Newtonsoft.Json
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class, AllowMultiple=false)]
    public abstract class JsonContainerAttribute : Attribute
    {
        internal bool? nullable_0;
        internal bool? nullable_1;
        internal ReferenceLoopHandling? nullable_2;
        internal TypeNameHandling? nullable_3;
        [CompilerGenerated]
        private string string_0;
        [CompilerGenerated]
        private string string_1;
        [CompilerGenerated]
        private string string_2;
        [CompilerGenerated]
        private Type type_0;

        protected JsonContainerAttribute()
        {
        }

        protected JsonContainerAttribute(string id)
        {
            this.Id = id;
        }

        public string Description
        {
            [CompilerGenerated]
            get
            {
                return this.string_2;
            }
            [CompilerGenerated]
            set
            {
                this.string_2 = value;
            }
        }

        public string Id
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

        public bool IsReference
        {
            get
            {
                bool? nullable = this.nullable_0;
                if (!nullable.HasValue)
                {
                    return false;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_0 = new bool?(value);
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
                bool? nullable = this.nullable_1;
                if (!nullable.HasValue)
                {
                    return false;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_1 = new bool?(value);
            }
        }

        public ReferenceLoopHandling ItemReferenceLoopHandling
        {
            get
            {
                ReferenceLoopHandling? nullable = this.nullable_2;
                if (!nullable.HasValue)
                {
                    return ReferenceLoopHandling.Error;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_2 = new ReferenceLoopHandling?(value);
            }
        }

        public TypeNameHandling ItemTypeNameHandling
        {
            get
            {
                TypeNameHandling? nullable = this.nullable_3;
                if (!nullable.HasValue)
                {
                    return TypeNameHandling.None;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_3 = new TypeNameHandling?(value);
            }
        }

        public string Title
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
    }
}

