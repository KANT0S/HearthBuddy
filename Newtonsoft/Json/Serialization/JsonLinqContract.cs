namespace Newtonsoft.Json.Serialization
{
    using ns16;
    using System;

    public class JsonLinqContract : JsonContract
    {
        public JsonLinqContract(Type underlyingType) : base(underlyingType)
        {
            base.enum15_0 = Enum15.Linq;
        }
    }
}

