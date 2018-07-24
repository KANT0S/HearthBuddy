namespace Newtonsoft.Json.Serialization
{
    using ns20;
    using System;

    public class CamelCasePropertyNamesContractResolver : DefaultContractResolver
    {
        public CamelCasePropertyNamesContractResolver() : base(true)
        {
        }

        protected internal override string ResolvePropertyName(string propertyName)
        {
            return Class198.smethod_10(propertyName);
        }
    }
}

