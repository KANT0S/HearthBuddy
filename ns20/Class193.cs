namespace ns20
{
    using System;
    using System.Globalization;
    using System.Runtime.InteropServices;

    internal static class Class193
    {
        public static bool smethod_0(object object_0, object object_1)
        {
            if ((object_0 == null) && (object_1 == null))
            {
                return true;
            }
            if ((object_0 != null) && (object_1 == null))
            {
                return false;
            }
            if ((object_0 == null) && (object_1 != null))
            {
                return false;
            }
            if (!(object_0.GetType() != object_1.GetType()))
            {
                return object_0.Equals(object_1);
            }
            if (Class181.smethod_14(object_0) && Class181.smethod_14(object_1))
            {
                return Convert.ToDecimal(object_0, CultureInfo.CurrentCulture).Equals(Convert.ToDecimal(object_1, CultureInfo.CurrentCulture));
            }
            return (((((object_0 is double) || (object_0 is float)) || (object_0 is decimal)) && (((object_1 is double) || (object_1 is float)) || (object_1 is decimal))) && Class192.smethod_5(Convert.ToDouble(object_0, CultureInfo.CurrentCulture), Convert.ToDouble(object_1, CultureInfo.CurrentCulture)));
        }

        public static ArgumentOutOfRangeException smethod_1(string string_0, object object_0, string string_1)
        {
            return new ArgumentOutOfRangeException(string_0, string_1 + Environment.NewLine + "Actual value was {0}.".smethod_0(CultureInfo.InvariantCulture, object_0));
        }

        public static string smethod_2(object object_0)
        {
            if (object_0 == null)
            {
                return "{null}";
            }
            if (object_0 is string)
            {
                return ("\"" + object_0.ToString() + "\"");
            }
            return object_0.ToString();
        }

        public static int smethod_3(byte[] byte_0, byte[] byte_1)
        {
            int num = byte_0.Length.CompareTo(byte_1.Length);
            if (num != 0)
            {
                return num;
            }
            for (int i = 0; i < byte_0.Length; i++)
            {
                int num3 = byte_0[i].CompareTo(byte_1[i]);
                if (num3 != 0)
                {
                    return num3;
                }
            }
            return 0;
        }

        public static string smethod_4(string string_0)
        {
            string str;
            string str2;
            smethod_6(string_0, out str, out str2);
            return str;
        }

        public static string smethod_5(string string_0)
        {
            string str;
            string str2;
            smethod_6(string_0, out str, out str2);
            return str2;
        }

        public static void smethod_6(string string_0, out string string_1, out string string_2)
        {
            int index = string_0.IndexOf(':');
            if (((index != -1) && (index != 0)) && ((string_0.Length - 1) != index))
            {
                string_1 = string_0.Substring(0, index);
                string_2 = string_0.Substring(index + 1);
            }
            else
            {
                string_1 = null;
                string_2 = string_0;
            }
        }

        internal static string smethod_7(object object_0)
        {
            if (object_0 == null)
            {
                return "{null}";
            }
            if (object_0 is string)
            {
                return ("\"" + object_0 + "\"");
            }
            return object_0.ToString();
        }
    }
}

