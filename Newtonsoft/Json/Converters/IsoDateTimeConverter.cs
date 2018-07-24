namespace Newtonsoft.Json.Converters
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Globalization;

    public class IsoDateTimeConverter : DateTimeConverterBase
    {
        private CultureInfo cultureInfo_0;
        private System.Globalization.DateTimeStyles dateTimeStyles_0 = System.Globalization.DateTimeStyles.RoundtripKind;
        private const string string_0 = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
        private string string_1;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            bool flag;
            Type type = (flag = Class194.smethod_10(objectType)) ? Nullable.GetUnderlyingType(objectType) : objectType;
            if (reader.JsonToken_0 == JsonToken.Null)
            {
                if (!Class194.smethod_10(objectType))
                {
                    throw JsonSerializationException.smethod_1(reader, "Cannot convert null value to {0}.".smethod_0(CultureInfo.InvariantCulture, objectType));
                }
                return null;
            }
            if (reader.JsonToken_0 == JsonToken.Date)
            {
                if (type == typeof(DateTimeOffset))
                {
                    return new DateTimeOffset((DateTime) reader.Object_0);
                }
                return reader.Object_0;
            }
            if (reader.JsonToken_0 != JsonToken.String)
            {
                throw JsonSerializationException.smethod_1(reader, "Unexpected token parsing date. Expected String, got {0}.".smethod_0(CultureInfo.InvariantCulture, reader.JsonToken_0));
            }
            string str = reader.Object_0.ToString();
            if (string.IsNullOrEmpty(str) && flag)
            {
                return null;
            }
            if (type == typeof(DateTimeOffset))
            {
                if (!string.IsNullOrEmpty(this.string_1))
                {
                    return DateTimeOffset.ParseExact(str, this.string_1, this.Culture, this.dateTimeStyles_0);
                }
                return DateTimeOffset.Parse(str, this.Culture, this.dateTimeStyles_0);
            }
            if (!string.IsNullOrEmpty(this.string_1))
            {
                return DateTime.ParseExact(str, this.string_1, this.Culture, this.dateTimeStyles_0);
            }
            return DateTime.Parse(str, this.Culture, this.dateTimeStyles_0);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            string str;
            if (value is DateTime)
            {
                DateTime time = (DateTime) value;
                if (((this.dateTimeStyles_0 & System.Globalization.DateTimeStyles.AdjustToUniversal) == System.Globalization.DateTimeStyles.AdjustToUniversal) || ((this.dateTimeStyles_0 & System.Globalization.DateTimeStyles.AssumeUniversal) == System.Globalization.DateTimeStyles.AssumeUniversal))
                {
                    time = time.ToUniversalTime();
                }
                str = time.ToString(this.string_1 ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", this.Culture);
            }
            else
            {
                if (!(value is DateTimeOffset))
                {
                    throw new JsonSerializationException("Unexpected value when converting date. Expected DateTime or DateTimeOffset, got {0}.".smethod_0(CultureInfo.InvariantCulture, Class194.smethod_3(value)));
                }
                DateTimeOffset offset = (DateTimeOffset) value;
                if (((this.dateTimeStyles_0 & System.Globalization.DateTimeStyles.AdjustToUniversal) == System.Globalization.DateTimeStyles.AdjustToUniversal) || ((this.dateTimeStyles_0 & System.Globalization.DateTimeStyles.AssumeUniversal) == System.Globalization.DateTimeStyles.AssumeUniversal))
                {
                    offset = offset.ToUniversalTime();
                }
                str = offset.ToString(this.string_1 ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", this.Culture);
            }
            writer.WriteValue(str);
        }

        public CultureInfo Culture
        {
            get
            {
                return (this.cultureInfo_0 ?? CultureInfo.CurrentCulture);
            }
            set
            {
                this.cultureInfo_0 = value;
            }
        }

        public string DateTimeFormat
        {
            get
            {
                return (this.string_1 ?? string.Empty);
            }
            set
            {
                this.string_1 = Class198.smethod_5(value);
            }
        }

        public System.Globalization.DateTimeStyles DateTimeStyles
        {
            get
            {
                return this.dateTimeStyles_0;
            }
            set
            {
                this.dateTimeStyles_0 = value;
            }
        }
    }
}

