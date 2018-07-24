namespace Newtonsoft.Json.Serialization
{
    using ns16;
    using System;

    public class JsonStringContract : JsonPrimitiveContract
    {
        public JsonStringContract(Type underlyingType) : base(underlyingType)
        {
            base.enum15_0 = Enum15.String;
        }
    }
}

