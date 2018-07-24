namespace Infralution.Localization.Wpf
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Globalization;
    using System.Resources;
    using System.Windows.Data;

    public class ResourceEnumConverter : EnumConverter, IValueConverter
    {
        private Array array_0;
        private bool bool_0;
        private Dictionary<CultureInfo, Class224> dictionary_0;
        private ResourceManager resourceManager_0;

        public ResourceEnumConverter(Type type, ResourceManager resourceManager) : base(type)
        {
            this.dictionary_0 = new Dictionary<CultureInfo, Class224>();
            this.resourceManager_0 = resourceManager;
            object[] customAttributes = type.GetCustomAttributes(typeof(FlagsAttribute), true);
            this.bool_0 = customAttributes.Length > 0;
            if (this.bool_0)
            {
                this.array_0 = Enum.GetValues(type);
            }
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (culture == null)
            {
                culture = CultureInfo.CurrentCulture;
            }
            if (!(value is string))
            {
                return base.ConvertFrom(context, culture, value);
            }
            object obj2 = this.bool_0 ? this.method_5(culture, (string) value) : this.method_4(culture, (string) value);
            if (obj2 == null)
            {
                obj2 = base.ConvertFrom(context, culture, value);
            }
            return obj2;
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (culture == null)
            {
                culture = CultureInfo.CurrentCulture;
            }
            if ((value == null) || !(destinationType == typeof(string)))
            {
                return base.ConvertTo(context, culture, value, destinationType);
            }
            if (!this.bool_0)
            {
                return this.method_1(culture, value);
            }
            return this.method_3(culture, value);
        }

        public static string ConvertToString(Enum value)
        {
            return TypeDescriptor.GetConverter(value.GetType()).ConvertToString(value);
        }

        protected virtual string GetResourceName(object value)
        {
            Type type = value.GetType();
            return string.Format("{0}_{1}", type.Name, value.ToString());
        }

        public static List<KeyValuePair<Enum, string>> GetValues(Type enumType)
        {
            return GetValues(enumType, CultureInfo.CurrentUICulture);
        }

        public static List<KeyValuePair<Enum, string>> GetValues(Type enumType, CultureInfo culture)
        {
            List<KeyValuePair<Enum, string>> list = new List<KeyValuePair<Enum, string>>();
            TypeConverter converter = TypeDescriptor.GetConverter(enumType);
            foreach (Enum enum2 in Enum.GetValues(enumType))
            {
                KeyValuePair<Enum, string> item = new KeyValuePair<Enum, string>(enum2, converter.ConvertToString(null, culture, enum2));
                list.Add(item);
            }
            return list;
        }

        private Class224 method_0(CultureInfo cultureInfo_0)
        {
            Class224 class2 = null;
            if (cultureInfo_0 == null)
            {
                cultureInfo_0 = CultureInfo.CurrentCulture;
            }
            if (!this.dictionary_0.TryGetValue(cultureInfo_0, out class2))
            {
                class2 = new Class224();
                foreach (object obj2 in base.GetStandardValues())
                {
                    string key = this.method_1(cultureInfo_0, obj2);
                    if (key != null)
                    {
                        class2.Add(key, obj2);
                    }
                }
                this.dictionary_0.Add(cultureInfo_0, class2);
            }
            return class2;
        }

        private string method_1(CultureInfo cultureInfo_0, object object_0)
        {
            string resourceName = this.GetResourceName(object_0);
            string str2 = this.resourceManager_0.GetString(resourceName, cultureInfo_0);
            if (str2 == null)
            {
                str2 = resourceName;
            }
            return str2;
        }

        private bool method_2(ulong ulong_0)
        {
            if (ulong_0 == 0)
            {
                return false;
            }
            if (ulong_0 != 1L)
            {
                return ((ulong_0 & (ulong_0 - ((ulong) 1L))) == 0L);
            }
            return true;
        }

        private string method_3(CultureInfo cultureInfo_0, object object_0)
        {
            if (Enum.IsDefined(object_0.GetType(), object_0))
            {
                return this.method_1(cultureInfo_0, object_0);
            }
            ulong num = Convert.ToUInt32(object_0);
            string str = null;
            foreach (object obj2 in this.array_0)
            {
                ulong num2 = Convert.ToUInt32(obj2);
                if (this.method_2(num2) && ((num2 & num) == num2))
                {
                    string str2 = this.method_1(cultureInfo_0, obj2);
                    if (str == null)
                    {
                        str = str2;
                    }
                    else
                    {
                        str = string.Format("{0}, {1}", str, str2);
                    }
                }
            }
            return str;
        }

        private object method_4(CultureInfo cultureInfo_0, string string_0)
        {
            object obj2 = null;
            this.method_0(cultureInfo_0).TryGetValue(string_0, out obj2);
            return obj2;
        }

        private object method_5(CultureInfo cultureInfo_0, string string_0)
        {
            Class224 class2 = this.method_0(cultureInfo_0);
            char[] separator = new char[] { ',' };
            ulong num = 0L;
            string[] strArray = string_0.Split(separator);
            for (int i = 0; i < strArray.Length; i++)
            {
                object obj2 = null;
                string key = strArray[i].Trim();
                if (!class2.TryGetValue(key, out obj2))
                {
                    return null;
                }
                num |= Convert.ToUInt32(obj2);
            }
            return Enum.ToObject(base.EnumType, num);
        }

        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return this.ConvertTo(null, culture, value, targetType);
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return this.ConvertFrom(null, culture, value);
        }

        private class Class224 : Dictionary<string, object>
        {
        }
    }
}

