namespace Newtonsoft.Json.Serialization
{
    using ns16;
    using ns20;
    using System;
    using System.Runtime.CompilerServices;

    public class JsonPrimitiveContract : JsonContract
    {
        [CompilerGenerated]
        private Enum17 enum17_0;

        public JsonPrimitiveContract(Type underlyingType) : base(underlyingType)
        {
            base.enum15_0 = Enum15.Primitive;
            this.Enum17_0 = Class181.smethod_0(underlyingType);
            base.bool_4 = true;
        }

        internal Enum17 Enum17_0
        {
            [CompilerGenerated]
            get
            {
                return this.enum17_0;
            }
            [CompilerGenerated]
            set
            {
                this.enum17_0 = value;
            }
        }
    }
}

