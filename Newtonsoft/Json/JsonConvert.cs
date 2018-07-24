namespace Newtonsoft.Json
{
    using Newtonsoft.Json.Converters;
    using ns20;
    using System;
    using System.Globalization;
    using System.IO;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Linq;

    public static class JsonConvert
    {
        public static readonly string False = "false";
        [CompilerGenerated]
        private static Func<JsonSerializerSettings> func_0;
        public static readonly string NaN = "NaN";
        public static readonly string NegativeInfinity = "-Infinity";
        public static readonly string Null = "null";
        public static readonly string PositiveInfinity = "Infinity";
        public static readonly string True = "true";
        public static readonly string Undefined = "undefined";

        public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject)
        {
            return DeserializeObject<T>(value);
        }

        public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject, JsonSerializerSettings settings)
        {
            return DeserializeObject<T>(value, settings);
        }

        public static object DeserializeObject(string value)
        {
            return DeserializeObject(value, null, (JsonSerializerSettings) null);
        }

        public static T DeserializeObject<T>(string value)
        {
            return DeserializeObject<T>(value, (JsonSerializerSettings) null);
        }

        public static object DeserializeObject(string value, JsonSerializerSettings settings)
        {
            return DeserializeObject(value, null, settings);
        }

        public static T DeserializeObject<T>(string value, JsonSerializerSettings settings)
        {
            return (T) DeserializeObject(value, typeof(T), settings);
        }

        public static object DeserializeObject(string value, Type type)
        {
            return DeserializeObject(value, type, (JsonSerializerSettings) null);
        }

        public static T DeserializeObject<T>(string value, params JsonConverter[] converters)
        {
            return (T) DeserializeObject(value, typeof(T), converters);
        }

        public static object DeserializeObject(string value, Type type, params JsonConverter[] converters)
        {
            JsonSerializerSettings settings = ((converters == null) || (converters.Length <= 0)) ? null : new JsonSerializerSettings();
            return DeserializeObject(value, type, settings);
        }

        public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings)
        {
            Class203.smethod_2(value, "value");
            StringReader reader = new StringReader(value);
            JsonSerializer serializer = JsonSerializer.CreateDefault(settings);
            if (!serializer.method_0())
            {
                serializer.Boolean_0 = true;
            }
            return serializer.Deserialize(new JsonTextReader(reader), type);
        }

        public static Task<object> DeserializeObjectAsync(string value)
        {
            return DeserializeObjectAsync(value, null, null);
        }

        public static Task<T> DeserializeObjectAsync<T>(string value)
        {
            return DeserializeObjectAsync<T>(value, null);
        }

        public static Task<T> DeserializeObjectAsync<T>(string value, JsonSerializerSettings settings)
        {
            Class109<T> class2 = new Class109<T> {
                string_0 = value,
                jsonSerializerSettings_0 = settings
            };
            return Task.Factory.StartNew<T>(new Func<T>(class2.method_0));
        }

        public static Task<object> DeserializeObjectAsync(string value, Type type, JsonSerializerSettings settings)
        {
            Class110 class2 = new Class110 {
                string_0 = value,
                type_0 = type,
                jsonSerializerSettings_0 = settings
            };
            return Task.Factory.StartNew<object>(new Func<object>(class2.method_0));
        }

        public static XmlDocument DeserializeXmlNode(string value)
        {
            return DeserializeXmlNode(value, null);
        }

        public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName)
        {
            return DeserializeXmlNode(value, deserializeRootElementName, false);
        }

        public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute)
        {
            XmlNodeConverter converter = new XmlNodeConverter {
                DeserializeRootElementName = deserializeRootElementName,
                WriteArrayAttribute = writeArrayAttribute
            };
            return (XmlDocument) DeserializeObject(value, typeof(XmlDocument), new JsonConverter[] { converter });
        }

        public static XDocument DeserializeXNode(string value)
        {
            return DeserializeXNode(value, null);
        }

        public static XDocument DeserializeXNode(string value, string deserializeRootElementName)
        {
            return DeserializeXNode(value, deserializeRootElementName, false);
        }

        public static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute)
        {
            XmlNodeConverter converter = new XmlNodeConverter {
                DeserializeRootElementName = deserializeRootElementName,
                WriteArrayAttribute = writeArrayAttribute
            };
            return (XDocument) DeserializeObject(value, typeof(XDocument), new JsonConverter[] { converter });
        }

        public static void PopulateObject(string value, object target)
        {
            PopulateObject(value, target, null);
        }

        public static void PopulateObject(string value, object target, JsonSerializerSettings settings)
        {
            StringReader reader = new StringReader(value);
            JsonSerializer serializer = JsonSerializer.CreateDefault(settings);
            using (JsonReader reader2 = new JsonTextReader(reader))
            {
                serializer.Populate(reader2, target);
                if (reader2.Read() && (reader2.JsonToken_0 != JsonToken.Comment))
                {
                    throw new JsonSerializationException("Additional text found in JSON string after finishing deserializing object.");
                }
            }
        }

        public static Task PopulateObjectAsync(string value, object target, JsonSerializerSettings settings)
        {
            Class111 class2 = new Class111 {
                string_0 = value,
                object_0 = target,
                jsonSerializerSettings_0 = settings
            };
            return Task.Factory.StartNew(new Action(class2.method_0));
        }

        public static string SerializeObject(object value)
        {
            return SerializeObject(value, Newtonsoft.Json.Formatting.None, (JsonSerializerSettings) null);
        }

        public static string SerializeObject(object value, Newtonsoft.Json.Formatting formatting)
        {
            return SerializeObject(value, formatting, (JsonSerializerSettings) null);
        }

        public static string SerializeObject(object value, params JsonConverter[] converters)
        {
            return SerializeObject(value, Newtonsoft.Json.Formatting.None, converters);
        }

        public static string SerializeObject(object value, JsonSerializerSettings settings)
        {
            return SerializeObject(value, Newtonsoft.Json.Formatting.None, settings);
        }

        public static string SerializeObject(object value, Newtonsoft.Json.Formatting formatting, params JsonConverter[] converters)
        {
            JsonSerializerSettings settings = ((converters == null) || (converters.Length <= 0)) ? null : new JsonSerializerSettings();
            return SerializeObject(value, formatting, settings);
        }

        public static string SerializeObject(object value, Newtonsoft.Json.Formatting formatting, JsonSerializerSettings settings)
        {
            return SerializeObject(value, null, formatting, settings);
        }

        public static string SerializeObject(object value, Type type, Newtonsoft.Json.Formatting formatting, JsonSerializerSettings settings)
        {
            JsonSerializer serializer = JsonSerializer.CreateDefault(settings);
            StringBuilder sb = new StringBuilder(0x100);
            StringWriter textWriter = new StringWriter(sb, CultureInfo.InvariantCulture);
            using (JsonTextWriter writer2 = new JsonTextWriter(textWriter))
            {
                writer2.Formatting = formatting;
                serializer.Serialize(writer2, value, type);
            }
            return textWriter.ToString();
        }

        public static Task<string> SerializeObjectAsync(object value)
        {
            return SerializeObjectAsync(value, Newtonsoft.Json.Formatting.None, null);
        }

        public static Task<string> SerializeObjectAsync(object value, Newtonsoft.Json.Formatting formatting)
        {
            return SerializeObjectAsync(value, formatting, null);
        }

        public static Task<string> SerializeObjectAsync(object value, Newtonsoft.Json.Formatting formatting, JsonSerializerSettings settings)
        {
            Class108 class2 = new Class108 {
                object_0 = value,
                formatting_0 = formatting,
                jsonSerializerSettings_0 = settings
            };
            return Task.Factory.StartNew<string>(new Func<string>(class2.method_0));
        }

        public static string SerializeXmlNode(System.Xml.XmlNode node)
        {
            return SerializeXmlNode(node, Newtonsoft.Json.Formatting.None);
        }

        public static string SerializeXmlNode(System.Xml.XmlNode node, Newtonsoft.Json.Formatting formatting)
        {
            XmlNodeConverter converter = new XmlNodeConverter();
            return SerializeObject(node, formatting, new JsonConverter[] { converter });
        }

        public static string SerializeXmlNode(System.Xml.XmlNode node, Newtonsoft.Json.Formatting formatting, bool omitRootObject)
        {
            XmlNodeConverter converter = new XmlNodeConverter {
                OmitRootObject = omitRootObject
            };
            return SerializeObject(node, formatting, new JsonConverter[] { converter });
        }

        public static string SerializeXNode(XObject node)
        {
            return SerializeXNode(node, Newtonsoft.Json.Formatting.None);
        }

        public static string SerializeXNode(XObject node, Newtonsoft.Json.Formatting formatting)
        {
            return SerializeXNode(node, formatting, false);
        }

        public static string SerializeXNode(XObject node, Newtonsoft.Json.Formatting formatting, bool omitRootObject)
        {
            XmlNodeConverter converter = new XmlNodeConverter {
                OmitRootObject = omitRootObject
            };
            return SerializeObject(node, formatting, new JsonConverter[] { converter });
        }

        private static string smethod_0(BigInteger bigInteger_0)
        {
            return bigInteger_0.ToString(null, CultureInfo.InvariantCulture);
        }

        internal static string smethod_1(float float_0, FloatFormatHandling floatFormatHandling_0, char char_0, bool bool_0)
        {
            return smethod_2((double) float_0, smethod_4((double) float_0, float_0.ToString("R", CultureInfo.InvariantCulture)), floatFormatHandling_0, char_0, bool_0);
        }

        private static string smethod_2(double double_0, string string_0, FloatFormatHandling floatFormatHandling_0, char char_0, bool bool_0)
        {
            if ((floatFormatHandling_0 == FloatFormatHandling.Symbol) || (!double.IsInfinity(double_0) && !double.IsNaN(double_0)))
            {
                return string_0;
            }
            if (floatFormatHandling_0 != FloatFormatHandling.DefaultValue)
            {
                return (char_0 + string_0 + char_0);
            }
            if (bool_0)
            {
                return Null;
            }
            return "0.0";
        }

        internal static string smethod_3(double double_0, FloatFormatHandling floatFormatHandling_0, char char_0, bool bool_0)
        {
            return smethod_2(double_0, smethod_4(double_0, double_0.ToString("R", CultureInfo.InvariantCulture)), floatFormatHandling_0, char_0, bool_0);
        }

        private static string smethod_4(double double_0, string string_0)
        {
            if (((!double.IsNaN(double_0) && !double.IsInfinity(double_0)) && ((string_0.IndexOf('.') == -1) && (string_0.IndexOf('E') == -1))) && (string_0.IndexOf('e') == -1))
            {
                return (string_0 + ".0");
            }
            return string_0;
        }

        private static string smethod_5(string string_0)
        {
            if (string_0.IndexOf('.') != -1)
            {
                return string_0;
            }
            return (string_0 + ".0");
        }

        internal static string smethod_6(Guid guid_0, char char_0)
        {
            string str = null;
            str = guid_0.ToString("D", CultureInfo.InvariantCulture);
            return (char_0 + str + char_0);
        }

        internal static string smethod_7(TimeSpan timeSpan_0, char char_0)
        {
            return ToString(timeSpan_0.ToString(), char_0);
        }

        internal static string smethod_8(Uri uri_0, char char_0)
        {
            return ToString(uri_0.ToString(), char_0);
        }

        public static string ToString(bool value)
        {
            if (!value)
            {
                return False;
            }
            return True;
        }

        public static string ToString(byte value)
        {
            return value.ToString(null, CultureInfo.InvariantCulture);
        }

        public static string ToString(char value)
        {
            return ToString(char.ToString(value));
        }

        public static string ToString(DateTime value)
        {
            return ToString(value, DateFormatHandling.IsoDateFormat, DateTimeZoneHandling.RoundtripKind);
        }

        public static string ToString(DateTimeOffset value)
        {
            return ToString(value, DateFormatHandling.IsoDateFormat);
        }

        public static string ToString(decimal value)
        {
            return smethod_5(value.ToString(null, CultureInfo.InvariantCulture));
        }

        public static string ToString(double value)
        {
            return smethod_4(value, value.ToString("R", CultureInfo.InvariantCulture));
        }

        public static string ToString(Enum value)
        {
            return value.ToString("D");
        }

        public static string ToString(Guid value)
        {
            return smethod_6(value, '"');
        }

        public static string ToString(short value)
        {
            return value.ToString(null, CultureInfo.InvariantCulture);
        }

        public static string ToString(int value)
        {
            return value.ToString(null, CultureInfo.InvariantCulture);
        }

        public static string ToString(long value)
        {
            return value.ToString(null, CultureInfo.InvariantCulture);
        }

        public static string ToString(object value)
        {
            if (value == null)
            {
                return Null;
            }
            switch (Class181.smethod_1(value))
            {
                case Enum17.Char:
                    return ToString((char) value);

                case Enum17.Boolean:
                    return ToString((bool) value);

                case Enum17.SByte:
                    return ToString((sbyte) value);

                case Enum17.Int16:
                    return ToString((short) value);

                case Enum17.UInt16:
                    return ToString((ushort) value);

                case Enum17.Int32:
                    return ToString((int) value);

                case Enum17.Byte:
                    return ToString((byte) value);

                case Enum17.UInt32:
                    return ToString((uint) value);

                case Enum17.Int64:
                    return ToString((long) value);

                case Enum17.UInt64:
                    return ToString((ulong) value);

                case Enum17.Single:
                    return ToString((float) value);

                case Enum17.Double:
                    return ToString((double) value);

                case Enum17.DateTime:
                    return ToString((DateTime) value);

                case Enum17.DateTimeOffset:
                    return ToString((DateTimeOffset) value);

                case Enum17.Decimal:
                    return ToString((decimal) value);

                case Enum17.Guid:
                    return ToString((Guid) value);

                case Enum17.TimeSpan:
                    return ToString((TimeSpan) value);

                case Enum17.BigInteger:
                    return smethod_0((BigInteger) value);

                case Enum17.Uri:
                    return ToString((Uri) value);

                case Enum17.String:
                    return ToString((string) value);

                case Enum17.DBNull:
                    return Null;
            }
            throw new ArgumentException("Unsupported type: {0}. Use the JsonSerializer class to get the object's JSON representation.".smethod_0(CultureInfo.InvariantCulture, value.GetType()));
        }

        [CLSCompliant(false)]
        public static string ToString(sbyte value)
        {
            return value.ToString(null, CultureInfo.InvariantCulture);
        }

        public static string ToString(float value)
        {
            return smethod_4((double) value, value.ToString("R", CultureInfo.InvariantCulture));
        }

        public static string ToString(string value)
        {
            return ToString(value, '"');
        }

        public static string ToString(TimeSpan value)
        {
            return smethod_7(value, '"');
        }

        [CLSCompliant(false)]
        public static string ToString(ushort value)
        {
            return value.ToString(null, CultureInfo.InvariantCulture);
        }

        [CLSCompliant(false)]
        public static string ToString(uint value)
        {
            return value.ToString(null, CultureInfo.InvariantCulture);
        }

        [CLSCompliant(false)]
        public static string ToString(ulong value)
        {
            return value.ToString(null, CultureInfo.InvariantCulture);
        }

        public static string ToString(Uri value)
        {
            if (value == null)
            {
                return Null;
            }
            return smethod_8(value, '"');
        }

        public static string ToString(DateTimeOffset value, DateFormatHandling format)
        {
            using (StringWriter writer = Class198.smethod_6(0x40))
            {
                writer.Write('"');
                Class184.smethod_21(writer, value, format, null, CultureInfo.InvariantCulture);
                writer.Write('"');
                return writer.ToString();
            }
        }

        public static string ToString(string value, char delimiter)
        {
            if ((delimiter != '"') && (delimiter != '\''))
            {
                throw new ArgumentException("Delimiter must be a single or double quote.", "delimiter");
            }
            return Class189.smethod_1(value, delimiter, true);
        }

        public static string ToString(DateTime value, DateFormatHandling format, DateTimeZoneHandling timeZoneHandling)
        {
            DateTime time = Class184.smethod_2(value, timeZoneHandling);
            using (StringWriter writer = Class198.smethod_6(0x40))
            {
                writer.Write('"');
                Class184.smethod_16(writer, time, format, null, CultureInfo.InvariantCulture);
                writer.Write('"');
                return writer.ToString();
            }
        }

        public static Func<JsonSerializerSettings> DefaultSettings
        {
            [CompilerGenerated]
            get
            {
                return func_0;
            }
            [CompilerGenerated]
            set
            {
                func_0 = value;
            }
        }

        [CompilerGenerated]
        private sealed class Class108
        {
            public Newtonsoft.Json.Formatting formatting_0;
            public JsonSerializerSettings jsonSerializerSettings_0;
            public object object_0;

            public string method_0()
            {
                return JsonConvert.SerializeObject(this.object_0, this.formatting_0, this.jsonSerializerSettings_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class109<T>
        {
            public JsonSerializerSettings jsonSerializerSettings_0;
            public string string_0;

            public T method_0()
            {
                return JsonConvert.DeserializeObject<T>(this.string_0, this.jsonSerializerSettings_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class110
        {
            public JsonSerializerSettings jsonSerializerSettings_0;
            public string string_0;
            public Type type_0;

            public object method_0()
            {
                return JsonConvert.DeserializeObject(this.string_0, this.type_0, this.jsonSerializerSettings_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class111
        {
            public JsonSerializerSettings jsonSerializerSettings_0;
            public object object_0;
            public string string_0;

            public void method_0()
            {
                JsonConvert.PopulateObject(this.string_0, this.object_0, this.jsonSerializerSettings_0);
            }
        }
    }
}

