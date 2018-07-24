namespace Newtonsoft.Json.Serialization
{
    using Newtonsoft.Json;
    using ns16;
    using ns20;
    using System;
    using System.Runtime.CompilerServices;

    public class JsonContainerContract : JsonContract
    {
        private JsonContract jsonContract_0;
        private JsonContract jsonContract_1;
        [CompilerGenerated]
        private JsonConverter jsonConverter_2;
        [CompilerGenerated]
        private bool? nullable_1;
        [CompilerGenerated]
        private ReferenceLoopHandling? nullable_2;
        [CompilerGenerated]
        private TypeNameHandling? nullable_3;

        internal JsonContainerContract(Type underlyingType) : base(underlyingType)
        {
            JsonContainerAttribute attribute = Class139.smethod_0(underlyingType);
            if (attribute != null)
            {
                if (attribute.ItemConverterType != null)
                {
                    this.ItemConverter = JsonConverterAttribute.smethod_0(attribute.ItemConverterType);
                }
                this.ItemIsReference = attribute.nullable_1;
                this.ItemReferenceLoopHandling = attribute.nullable_2;
                this.ItemTypeNameHandling = attribute.nullable_3;
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
                return this.nullable_1;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_1 = value;
            }
        }

        public ReferenceLoopHandling? ItemReferenceLoopHandling
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

        public TypeNameHandling? ItemTypeNameHandling
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

        internal JsonContract JsonContract_0
        {
            get
            {
                return this.jsonContract_0;
            }
            set
            {
                this.jsonContract_0 = value;
                if (this.jsonContract_0 != null)
                {
                    this.jsonContract_1 = this.jsonContract_0.UnderlyingType.smethod_9() ? this.jsonContract_0 : null;
                }
                else
                {
                    this.jsonContract_1 = null;
                }
            }
        }

        internal JsonContract JsonContract_1
        {
            get
            {
                return this.jsonContract_1;
            }
        }
    }
}

