namespace Newtonsoft.Json.Converters
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;

    public class StringEnumConverter : JsonConverter
    {
        [CompilerGenerated]
        private bool bool_0;
        private readonly Dictionary<Type, Class179<string, string>> dictionary_0 = new Dictionary<Type, Class179<string, string>>();
        [CompilerGenerated]
        private static Func<EnumMemberAttribute, string> func_0;

        public override bool CanConvert(Type objectType)
        {
            Type type = Class194.smethod_10(objectType) ? Nullable.GetUnderlyingType(objectType) : objectType;
            return type.smethod_7();
        }

        private Class179<string, string> method_0(Type type_0)
        {
            Class179<string, string> class2;
            Class179<string, string> class3;
            if (this.dictionary_0.TryGetValue(type_0, out class2))
            {
                return class2;
            }
            lock (this.dictionary_0)
            {
                if (!this.dictionary_0.TryGetValue(type_0, out class2))
                {
                    class2 = new Class179<string, string>(StringComparer.OrdinalIgnoreCase, StringComparer.OrdinalIgnoreCase);
                    foreach (FieldInfo info in type_0.GetFields())
                    {
                        string str3;
                        string name = info.Name;
                        if (func_0 == null)
                        {
                            func_0 = new Func<EnumMemberAttribute, string>(StringEnumConverter.smethod_1);
                        }
                        string str2 = info.GetCustomAttributes(typeof(EnumMemberAttribute), true).Cast<EnumMemberAttribute>().Select<EnumMemberAttribute, string>(func_0).SingleOrDefault<string>() ?? info.Name;
                        if (class2.method_2(str2, out str3))
                        {
                            throw new InvalidOperationException("Enum name '{0}' already exists on enum '{1}'.".smethod_1(CultureInfo.InvariantCulture, str2, type_0.Name));
                        }
                        class2.method_0(name, str2);
                    }
                    this.dictionary_0[type_0] = class2;
                }
                return class2;
            }
            return class3;
        }

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
            try
            {
                if (reader.JsonToken_0 == JsonToken.String)
                {
                    string str2;
                    string str = reader.Object_0.ToString();
                    if ((str == string.Empty) && flag)
                    {
                        return null;
                    }
                    Class179<string, string> class2 = this.method_0(type);
                    if (str.IndexOf(',') != -1)
                    {
                        string[] strArray = str.Split(new char[] { ',' });
                        for (int i = 0; i < strArray.Length; i++)
                        {
                            string str3 = strArray[i].Trim();
                            strArray[i] = smethod_0(class2, str3);
                        }
                        str2 = string.Join(", ", strArray);
                    }
                    else
                    {
                        str2 = smethod_0(class2, str);
                    }
                    return Enum.Parse(type, str2, true);
                }
                if (reader.JsonToken_0 == JsonToken.Integer)
                {
                    return Class181.smethod_10(reader.Object_0, CultureInfo.InvariantCulture, type);
                }
            }
            catch (Exception exception)
            {
                throw JsonSerializationException.smethod_2(reader, "Error converting value {0} to type '{1}'.".smethod_1(CultureInfo.InvariantCulture, Class193.smethod_7(reader.Object_0), objectType), exception);
            }
            throw JsonSerializationException.smethod_1(reader, "Unexpected token when parsing enum. Expected String or Integer, got {0}.".smethod_0(CultureInfo.InvariantCulture, reader.JsonToken_0));
        }

        private static string smethod_0(Class179<string, string> class179_0, string string_0)
        {
            string str;
            class179_0.method_2(string_0, out str);
            return (str ?? string_0);
        }

        [CompilerGenerated]
        private static string smethod_1(EnumMemberAttribute enumMemberAttribute_0)
        {
            return enumMemberAttribute_0.Value;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                Enum enum2 = (Enum) value;
                string str = enum2.ToString("G");
                if (!char.IsNumber(str[0]) && (str[0] != '-'))
                {
                    Class179<string, string> class2 = this.method_0(enum2.GetType());
                    string[] strArray = str.Split(new char[] { ',' });
                    for (int i = 0; i < strArray.Length; i++)
                    {
                        string str3;
                        string str2 = strArray[i].Trim();
                        class2.method_1(str2, out str3);
                        str3 = str3 ?? str2;
                        if (this.CamelCaseText)
                        {
                            str3 = Class198.smethod_10(str3);
                        }
                        strArray[i] = str3;
                    }
                    string str4 = string.Join(", ", strArray);
                    writer.WriteValue(str4);
                }
                else
                {
                    writer.WriteValue(value);
                }
            }
        }

        public bool CamelCaseText
        {
            [CompilerGenerated]
            get
            {
                return this.bool_0;
            }
            [CompilerGenerated]
            set
            {
                this.bool_0 = value;
            }
        }
    }
}

