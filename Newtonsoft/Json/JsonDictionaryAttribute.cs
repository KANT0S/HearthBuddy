namespace Newtonsoft.Json
{
    using System;

    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class, AllowMultiple=false)]
    public sealed class JsonDictionaryAttribute : JsonContainerAttribute
    {
        public JsonDictionaryAttribute()
        {
        }

        public JsonDictionaryAttribute(string id) : base(id)
        {
        }
    }
}

