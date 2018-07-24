namespace ns20
{
    using System;
    using System.Globalization;

    internal static class Class203
    {
        public static void smethod_0(string string_0, string string_1)
        {
            if (string_0 == null)
            {
                throw new ArgumentNullException(string_1);
            }
            if (string_0.Length == 0)
            {
                throw new ArgumentException("'{0}' cannot be empty.".smethod_0(CultureInfo.InvariantCulture, string_1), string_1);
            }
        }

        public static void smethod_1(Type type_0, string string_0)
        {
            smethod_2(type_0, "enumType");
            if (!type_0.smethod_7())
            {
                throw new ArgumentException("Type {0} is not an Enum.".smethod_0(CultureInfo.InvariantCulture, type_0), string_0);
            }
        }

        public static void smethod_2(object object_0, string string_0)
        {
            if (object_0 == null)
            {
                throw new ArgumentNullException(string_0);
            }
        }
    }
}

