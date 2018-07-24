namespace Newtonsoft.Json
{
    using ns20;
    using System;
    using System.Globalization;

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Interface | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Class, AllowMultiple=false)]
    public sealed class JsonConverterAttribute : Attribute
    {
        private readonly Type type_0;

        public JsonConverterAttribute(Type converterType)
        {
            if (converterType == null)
            {
                throw new ArgumentNullException("converterType");
            }
            this.type_0 = converterType;
        }

        internal static JsonConverter smethod_0(Type type_1)
        {
            JsonConverter converter;
            try
            {
                converter = (JsonConverter) Activator.CreateInstance(type_1);
            }
            catch (Exception exception)
            {
                throw new JsonException("Error creating {0}".smethod_0(CultureInfo.InvariantCulture, type_1), exception);
            }
            return converter;
        }

        public Type ConverterType
        {
            get
            {
                return this.type_0;
            }
        }
    }
}

