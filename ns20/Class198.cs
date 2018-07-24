namespace ns20
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;

    internal static class Class198
    {
        public const char char_0 = '\r';
        public const char char_1 = '\n';
        public const char char_2 = '\t';
        public const string string_0 = "\r\n";
        public const string string_1 = "";

        public static string smethod_0(this string string_2, IFormatProvider iformatProvider_0, object object_0)
        {
            return string_2.smethod_3(iformatProvider_0, new object[] { object_0 });
        }

        public static string smethod_1(this string string_2, IFormatProvider iformatProvider_0, object object_0, object object_1)
        {
            return string_2.smethod_3(iformatProvider_0, new object[] { object_0, object_1 });
        }

        public static string smethod_10(string string_2)
        {
            if (string.IsNullOrEmpty(string_2))
            {
                return string_2;
            }
            if (!char.IsUpper(string_2[0]))
            {
                return string_2;
            }
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < string_2.Length; i++)
            {
                bool flag = (i + 1) < string_2.Length;
                if (((i != 0) && flag) && !char.IsUpper(string_2[i + 1]))
                {
                    builder.Append(string_2.Substring(i));
                    break;
                }
                char ch = char.ToLower(string_2[i], CultureInfo.InvariantCulture);
                builder.Append(ch);
            }
            return builder.ToString();
        }

        public static bool smethod_11(char char_3)
        {
            return char.IsHighSurrogate(char_3);
        }

        public static bool smethod_12(char char_3)
        {
            return char.IsLowSurrogate(char_3);
        }

        public static string smethod_2(this string string_2, IFormatProvider iformatProvider_0, object object_0, object object_1, object object_2)
        {
            return string_2.smethod_3(iformatProvider_0, new object[] { object_0, object_1, object_2 });
        }

        public static string smethod_3(this string string_2, IFormatProvider iformatProvider_0, params object[] object_0)
        {
            Class203.smethod_2(string_2, "format");
            return string.Format(iformatProvider_0, string_2, object_0);
        }

        public static bool smethod_4(string string_2)
        {
            if (string_2 == null)
            {
                throw new ArgumentNullException("s");
            }
            if (string_2.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < string_2.Length; i++)
            {
                if (!char.IsWhiteSpace(string_2[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static string smethod_5(string string_2)
        {
            if (!string.IsNullOrEmpty(string_2))
            {
                return string_2;
            }
            return null;
        }

        public static StringWriter smethod_6(int int_0)
        {
            return new StringWriter(new StringBuilder(int_0), CultureInfo.InvariantCulture);
        }

        public static int? smethod_7(string string_2)
        {
            if (string_2 == null)
            {
                return null;
            }
            return new int?(string_2.Length);
        }

        public static void smethod_8(char char_3, char[] char_4)
        {
            char_4[0] = '\\';
            char_4[1] = 'u';
            char_4[2] = Class192.smethod_1((char_3 >> 12) & '\x000f');
            char_4[3] = Class192.smethod_1((char_3 >> 8) & '\x000f');
            char_4[4] = Class192.smethod_1((char_3 >> 4) & '\x000f');
            char_4[5] = Class192.smethod_1(char_3 & '\x000f');
        }

        public static T smethod_9<T>(this IEnumerable<T> ienumerable_0, Func<T, string> func_0, string string_2)
        {
            Func<T, bool> predicate = null;
            Class199<T> class2 = new Class199<T> {
                func_0 = func_0,
                string_0 = string_2
            };
            if (ienumerable_0 == null)
            {
                throw new ArgumentNullException("source");
            }
            if (class2.func_0 == null)
            {
                throw new ArgumentNullException("valueSelector");
            }
            IEnumerable<T> source = ienumerable_0.Where<T>(new Func<T, bool>(class2.method_0));
            if (source.Count<T>() <= 1)
            {
                return source.SingleOrDefault<T>();
            }
            if (predicate == null)
            {
                predicate = new Func<T, bool>(class2.method_1);
            }
            return ienumerable_0.Where<T>(predicate).SingleOrDefault<T>();
        }

        [CompilerGenerated]
        private sealed class Class199<T>
        {
            public Func<T, string> func_0;
            public string string_0;

            public bool method_0(T gparam_0)
            {
                return string.Equals(this.func_0(gparam_0), this.string_0, StringComparison.OrdinalIgnoreCase);
            }

            public bool method_1(T gparam_0)
            {
                return string.Equals(this.func_0(gparam_0), this.string_0, StringComparison.Ordinal);
            }
        }
    }
}

