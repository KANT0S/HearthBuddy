namespace Newtonsoft.Json
{
    using System;

    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Struct | AttributeTargets.Class, AllowMultiple=false)]
    public sealed class JsonObjectAttribute : JsonContainerAttribute
    {
        private Newtonsoft.Json.MemberSerialization memberSerialization_0;
        internal Required? nullable_4;

        public JsonObjectAttribute()
        {
        }

        public JsonObjectAttribute(Newtonsoft.Json.MemberSerialization memberSerialization)
        {
            this.MemberSerialization = memberSerialization;
        }

        public JsonObjectAttribute(string id) : base(id)
        {
        }

        public Required ItemRequired
        {
            get
            {
                Required? nullable = this.nullable_4;
                if (!nullable.HasValue)
                {
                    return Required.Default;
                }
                return nullable.GetValueOrDefault();
            }
            set
            {
                this.nullable_4 = new Required?(value);
            }
        }

        public Newtonsoft.Json.MemberSerialization MemberSerialization
        {
            get
            {
                return this.memberSerialization_0;
            }
            set
            {
                this.memberSerialization_0 = value;
            }
        }
    }
}

