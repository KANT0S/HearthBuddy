namespace ns20
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    internal static class Class186
    {
        [CompilerGenerated]
        private static Func<FieldInfo, bool> func_0;
        [CompilerGenerated]
        private static Func<FieldInfo, bool> func_1;

        public static IList<T> smethod_0<T>(T gparam_0) where T: struct
        {
            Type type = typeof(T);
            if (!type.IsDefined(typeof(FlagsAttribute), false))
            {
                throw new ArgumentException("Enum type {0} is not a set of flags.".smethod_0(CultureInfo.InvariantCulture, type));
            }
            Type underlyingType = Enum.GetUnderlyingType(gparam_0.GetType());
            ulong num = Convert.ToUInt64(gparam_0, CultureInfo.InvariantCulture);
            Class188<ulong> source = smethod_1<T>();
            IList<T> list = new List<T>();
            foreach (Class187<ulong> class3 in source)
            {
                if (((num & class3.Prop_0) == class3.Prop_0) && (class3.Prop_0 != 0L))
                {
                    list.Add((T) Convert.ChangeType(class3.Prop_0, underlyingType, CultureInfo.CurrentCulture));
                }
            }
            if ((list.Count == 0) && (source.SingleOrDefault<Class187<ulong>>(new Func<Class187<ulong>, bool>(Class186.smethod_5<T>)) != null))
            {
                list.Add(default(T));
            }
            return list;
        }

        public static Class188<ulong> smethod_1<T>() where T: struct
        {
            return smethod_2<ulong>(typeof(T));
        }

        public static Class188<T> smethod_2<T>(Type type_0) where T: struct
        {
            if (type_0 == null)
            {
                throw new ArgumentNullException("enumType");
            }
            Class203.smethod_1(type_0, "enumType");
            IList<object> list = smethod_3(type_0);
            IList<string> list2 = smethod_4(type_0);
            Class188<T> class2 = new Class188<T>();
            for (int i = 0; i < list.Count; i++)
            {
                try
                {
                    class2.Add(new Class187<T>(list2[i], (T) Convert.ChangeType(list[i], typeof(T), CultureInfo.CurrentCulture)));
                }
                catch (OverflowException exception)
                {
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Value from enum with the underlying type of {0} cannot be added to dictionary with a value type of {1}. Value was too large: {2}", new object[] { Enum.GetUnderlyingType(type_0), typeof(T), Convert.ToUInt64(list[i], CultureInfo.InvariantCulture) }), exception);
                }
            }
            return class2;
        }

        public static IList<object> smethod_3(Type type_0)
        {
            if (!type_0.smethod_7())
            {
                throw new ArgumentException("Type '" + type_0.Name + "' is not an enum.");
            }
            List<object> list = new List<object>();
            if (func_0 == null)
            {
                func_0 = new Func<FieldInfo, bool>(Class186.smethod_6);
            }
            foreach (FieldInfo info in type_0.GetFields().Where<FieldInfo>(func_0))
            {
                object item = info.GetValue(type_0);
                list.Add(item);
            }
            return list;
        }

        public static IList<string> smethod_4(Type type_0)
        {
            if (!type_0.smethod_7())
            {
                throw new ArgumentException("Type '" + type_0.Name + "' is not an enum.");
            }
            List<string> list = new List<string>();
            if (func_1 == null)
            {
                func_1 = new Func<FieldInfo, bool>(Class186.smethod_7);
            }
            foreach (FieldInfo info in type_0.GetFields().Where<FieldInfo>(func_1))
            {
                list.Add(info.Name);
            }
            return list;
        }

        [CompilerGenerated]
        private static bool smethod_5<T>(Class187<ulong> class187_0) where T: struct
        {
            return (class187_0.Prop_0 == 0L);
        }

        [CompilerGenerated]
        private static bool smethod_6(FieldInfo fieldInfo_0)
        {
            return fieldInfo_0.IsLiteral;
        }

        [CompilerGenerated]
        private static bool smethod_7(FieldInfo fieldInfo_0)
        {
            return fieldInfo_0.IsLiteral;
        }
    }
}

