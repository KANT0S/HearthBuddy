namespace Newtonsoft.Json
{
    using System;

    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class, AllowMultiple=false)]
    public sealed class JsonArrayAttribute : JsonContainerAttribute
    {
        private bool bool_0;

        public JsonArrayAttribute()
        {
        }

        public JsonArrayAttribute(bool allowNullItems)
        {
            this.bool_0 = allowNullItems;
        }

        public JsonArrayAttribute(string id) : base(id)
        {
        }

        public bool AllowNullItems
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                this.bool_0 = value;
            }
        }
    }
}

