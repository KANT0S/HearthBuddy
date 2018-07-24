namespace Newtonsoft.Json.Serialization
{
    using ns16;
    using System;
    using System.Runtime.CompilerServices;

    public class JsonISerializableContract : JsonContainerContract
    {
        [CompilerGenerated]
        private ObjectConstructor<object> objectConstructor_0;

        public JsonISerializableContract(Type underlyingType) : base(underlyingType)
        {
            base.enum15_0 = Enum15.Serializable;
        }

        public ObjectConstructor<object> ISerializableCreator
        {
            [CompilerGenerated]
            get
            {
                return this.objectConstructor_0;
            }
            [CompilerGenerated]
            set
            {
                this.objectConstructor_0 = value;
            }
        }
    }
}

