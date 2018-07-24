namespace Newtonsoft.Json.Converters
{
    using Newtonsoft.Json;
    using System;

    public abstract class DateTimeConverterBase : JsonConverter
    {
        protected DateTimeConverterBase()
        {
        }

        public override bool CanConvert(Type objectType)
        {
            if (((objectType != typeof(DateTime)) && (objectType != typeof(DateTime?))) && (!(objectType == typeof(DateTimeOffset)) && !(objectType == typeof(DateTimeOffset?))))
            {
                return false;
            }
            return true;
        }
    }
}

