namespace ns20
{
    using ns16;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data.SqlTypes;
    using System.Globalization;
    using System.Numerics;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    internal static class Class181
    {
        private static readonly Class178<Struct30, Func<object, object>> class178_0;
        private static readonly Dictionary<Type, Enum17> dictionary_0;
        private static readonly List<Class180> list_0;

        static Class181()
        {
            Dictionary<Type, Enum17> dictionary = new Dictionary<Type, Enum17>();
            dictionary.Add(typeof(char), Enum17.Char);
            dictionary.Add(typeof(char?), Enum17.CharNullable);
            dictionary.Add(typeof(bool), Enum17.Boolean);
            dictionary.Add(typeof(bool?), Enum17.BooleanNullable);
            dictionary.Add(typeof(sbyte), Enum17.SByte);
            dictionary.Add(typeof(sbyte?), Enum17.SByteNullable);
            dictionary.Add(typeof(short), Enum17.Int16);
            dictionary.Add(typeof(short?), Enum17.Int16Nullable);
            dictionary.Add(typeof(ushort), Enum17.UInt16);
            dictionary.Add(typeof(ushort?), Enum17.UInt16Nullable);
            dictionary.Add(typeof(int), Enum17.Int32);
            dictionary.Add(typeof(int?), Enum17.Int32Nullable);
            dictionary.Add(typeof(byte), Enum17.Byte);
            dictionary.Add(typeof(byte?), Enum17.ByteNullable);
            dictionary.Add(typeof(uint), Enum17.UInt32);
            dictionary.Add(typeof(uint?), Enum17.UInt32Nullable);
            dictionary.Add(typeof(long), Enum17.Int64);
            dictionary.Add(typeof(long?), Enum17.Int64Nullable);
            dictionary.Add(typeof(ulong), Enum17.UInt64);
            dictionary.Add(typeof(ulong?), Enum17.UInt64Nullable);
            dictionary.Add(typeof(float), Enum17.Single);
            dictionary.Add(typeof(float?), Enum17.SingleNullable);
            dictionary.Add(typeof(double), Enum17.Double);
            dictionary.Add(typeof(double?), Enum17.DoubleNullable);
            dictionary.Add(typeof(DateTime), Enum17.DateTime);
            dictionary.Add(typeof(DateTime?), Enum17.DateTimeNullable);
            dictionary.Add(typeof(DateTimeOffset), Enum17.DateTimeOffset);
            dictionary.Add(typeof(DateTimeOffset?), Enum17.DateTimeOffsetNullable);
            dictionary.Add(typeof(decimal), Enum17.Decimal);
            dictionary.Add(typeof(decimal?), Enum17.DecimalNullable);
            dictionary.Add(typeof(Guid), Enum17.Guid);
            dictionary.Add(typeof(Guid?), Enum17.GuidNullable);
            dictionary.Add(typeof(TimeSpan), Enum17.TimeSpan);
            dictionary.Add(typeof(TimeSpan?), Enum17.TimeSpanNullable);
            dictionary.Add(typeof(BigInteger), Enum17.BigInteger);
            dictionary.Add(typeof(BigInteger?), Enum17.BigIntegerNullable);
            dictionary.Add(typeof(Uri), Enum17.Uri);
            dictionary.Add(typeof(string), Enum17.String);
            dictionary.Add(typeof(byte[]), Enum17.Bytes);
            dictionary.Add(typeof(DBNull), Enum17.DBNull);
            dictionary_0 = dictionary;
            List<Class180> list = new List<Class180>();
            Class180 item = new Class180 {
                Type_0 = typeof(object),
                Enum17_0 = Enum17.Empty
            };
            list.Add(item);
            Class180 class3 = new Class180 {
                Type_0 = typeof(object),
                Enum17_0 = Enum17.Object
            };
            list.Add(class3);
            Class180 class4 = new Class180 {
                Type_0 = typeof(object),
                Enum17_0 = Enum17.DBNull
            };
            list.Add(class4);
            Class180 class5 = new Class180 {
                Type_0 = typeof(bool),
                Enum17_0 = Enum17.Boolean
            };
            list.Add(class5);
            Class180 class6 = new Class180 {
                Type_0 = typeof(char),
                Enum17_0 = Enum17.Char
            };
            list.Add(class6);
            Class180 class7 = new Class180 {
                Type_0 = typeof(sbyte),
                Enum17_0 = Enum17.SByte
            };
            list.Add(class7);
            Class180 class8 = new Class180 {
                Type_0 = typeof(byte),
                Enum17_0 = Enum17.Byte
            };
            list.Add(class8);
            Class180 class9 = new Class180 {
                Type_0 = typeof(short),
                Enum17_0 = Enum17.Int16
            };
            list.Add(class9);
            Class180 class10 = new Class180 {
                Type_0 = typeof(ushort),
                Enum17_0 = Enum17.UInt16
            };
            list.Add(class10);
            Class180 class11 = new Class180 {
                Type_0 = typeof(int),
                Enum17_0 = Enum17.Int32
            };
            list.Add(class11);
            Class180 class12 = new Class180 {
                Type_0 = typeof(uint),
                Enum17_0 = Enum17.UInt32
            };
            list.Add(class12);
            Class180 class13 = new Class180 {
                Type_0 = typeof(long),
                Enum17_0 = Enum17.Int64
            };
            list.Add(class13);
            Class180 class14 = new Class180 {
                Type_0 = typeof(ulong),
                Enum17_0 = Enum17.UInt64
            };
            list.Add(class14);
            Class180 class15 = new Class180 {
                Type_0 = typeof(float),
                Enum17_0 = Enum17.Single
            };
            list.Add(class15);
            Class180 class16 = new Class180 {
                Type_0 = typeof(double),
                Enum17_0 = Enum17.Double
            };
            list.Add(class16);
            Class180 class17 = new Class180 {
                Type_0 = typeof(decimal),
                Enum17_0 = Enum17.Decimal
            };
            list.Add(class17);
            Class180 class18 = new Class180 {
                Type_0 = typeof(DateTime),
                Enum17_0 = Enum17.DateTime
            };
            list.Add(class18);
            Class180 class19 = new Class180 {
                Type_0 = typeof(object),
                Enum17_0 = Enum17.Empty
            };
            list.Add(class19);
            Class180 class20 = new Class180 {
                Type_0 = typeof(string),
                Enum17_0 = Enum17.String
            };
            list.Add(class20);
            list_0 = list;
            class178_0 = new Class178<Struct30, Func<object, object>>(new Func<Struct30, Func<object, object>>(Class181.smethod_5));
        }

        public static Enum17 smethod_0(Type type_0)
        {
            Enum17 enum2;
            if (dictionary_0.TryGetValue(type_0, out enum2))
            {
                return enum2;
            }
            if (type_0.smethod_7())
            {
                return smethod_0(Enum.GetUnderlyingType(type_0));
            }
            if (Class194.smethod_10(type_0))
            {
                Type underlyingType = Nullable.GetUnderlyingType(type_0);
                if (underlyingType.smethod_7())
                {
                    return smethod_0(typeof(Nullable<>).MakeGenericType(new Type[] { Enum.GetUnderlyingType(underlyingType) }));
                }
            }
            return Enum17.Object;
        }

        public static Enum17 smethod_1(object object_0)
        {
            return smethod_0(object_0.GetType());
        }

        public static object smethod_10(object object_0, CultureInfo cultureInfo_0, Type type_0)
        {
            object obj2;
            if (type_0 == typeof(object))
            {
                return object_0;
            }
            if ((object_0 == null) && Class194.smethod_9(type_0))
            {
                return null;
            }
            if (smethod_9(object_0, cultureInfo_0, type_0, out obj2))
            {
                return obj2;
            }
            return smethod_11(object_0, Class194.smethod_3(object_0), type_0);
        }

        private static object smethod_11(object object_0, Type type_0, Type type_1)
        {
            Type c = (object_0 != null) ? object_0.GetType() : null;
            if (object_0 != null)
            {
                if (type_1.IsAssignableFrom(c))
                {
                    return object_0;
                }
                Func<object, object> func = class178_0.method_0(new Struct30(c, type_1));
                if (func != null)
                {
                    return func(object_0);
                }
            }
            else if (Class194.smethod_9(type_1))
            {
                return null;
            }
            throw new ArgumentException("Could not cast or convert from {0} to {1}.".smethod_1(CultureInfo.InvariantCulture, (type_0 != null) ? type_0.ToString() : "{null}", type_1));
        }

        public static object smethod_12(INullable inullable_0)
        {
            if (inullable_0 == null)
            {
                return null;
            }
            if (inullable_0 is SqlInt32)
            {
                return smethod_12((SqlInt32) inullable_0);
            }
            if (inullable_0 is SqlInt64)
            {
                return smethod_12((SqlInt64) inullable_0);
            }
            if (inullable_0 is SqlBoolean)
            {
                return smethod_12((SqlBoolean) inullable_0);
            }
            if (inullable_0 is SqlString)
            {
                return smethod_12((SqlString) inullable_0);
            }
            if (!(inullable_0 is SqlDateTime))
            {
                throw new ArgumentException("Unsupported INullable type: {0}".smethod_0(CultureInfo.InvariantCulture, inullable_0.GetType()));
            }
            return smethod_12((SqlDateTime) inullable_0);
        }

        internal static TypeConverter smethod_13(Type type_0)
        {
            return Class139.smethod_11(type_0);
        }

        public static bool smethod_14(object object_0)
        {
            switch (smethod_1(object_0))
            {
                case Enum17.SByte:
                case Enum17.Int16:
                case Enum17.UInt16:
                case Enum17.Int32:
                case Enum17.Byte:
                case Enum17.UInt32:
                case Enum17.Int64:
                case Enum17.UInt64:
                    return true;
            }
            return false;
        }

        public static int smethod_15(char[] char_0, int int_0, int int_1)
        {
            bool flag;
            if (int_1 == 0)
            {
                throw new FormatException("Input string was not in a correct format.");
            }
            if (flag = char_0[int_0] == '-')
            {
                if (int_1 == 1)
                {
                    throw new FormatException("Input string was not in a correct format.");
                }
                int_0++;
                int_1--;
            }
            int num = 0;
            int num2 = int_0 + int_1;
            for (int i = int_0; i < num2; i++)
            {
                int num4 = char_0[i] - '0';
                if ((num4 < 0) || (num4 > 9))
                {
                    throw new FormatException("Input string was not in a correct format.");
                }
                int num5 = (10 * num) - num4;
                if (num5 > num)
                {
                    throw new OverflowException();
                }
                num = num5;
            }
            if (flag)
            {
                return num;
            }
            if (num == -2147483648)
            {
                throw new OverflowException();
            }
            return -num;
        }

        public static Enum18 smethod_16(char[] char_0, int int_0, int int_1, out long long_0)
        {
            bool flag;
            long_0 = 0L;
            if (int_1 == 0)
            {
                return Enum18.Invalid;
            }
            if (flag = char_0[int_0] == '-')
            {
                if (int_1 == 1)
                {
                    return Enum18.Invalid;
                }
                int_0++;
                int_1--;
            }
            int num = int_0 + int_1;
            for (int i = int_0; i < num; i++)
            {
                int num3 = char_0[i] - '0';
                if ((num3 < 0) || (num3 > 9))
                {
                    return Enum18.Invalid;
                }
                long num4 = (10L * long_0) - num3;
                if (num4 > long_0)
                {
                    return Enum18.Overflow;
                }
                long_0 = num4;
            }
            if (!flag)
            {
                if (long_0 == -9223372036854775808L)
                {
                    return Enum18.Overflow;
                }
                long_0 = -long_0;
            }
            return Enum18.Success;
        }

        public static Class180 smethod_2(IConvertible iconvertible_0)
        {
            return list_0[(int) iconvertible_0.GetTypeCode()];
        }

        public static bool smethod_3(Type type_0)
        {
            return typeof(IConvertible).IsAssignableFrom(type_0);
        }

        public static TimeSpan smethod_4(string string_0)
        {
            return TimeSpan.Parse(string_0, CultureInfo.InvariantCulture);
        }

        private static Func<object, object> smethod_5(Struct30 struct30_0)
        {
            Class182 class2 = new Class182();
            MethodInfo method = struct30_0.Type_1.GetMethod("op_Implicit", new Type[] { struct30_0.Type_0 });
            if (method == null)
            {
                method = struct30_0.Type_1.GetMethod("op_Explicit", new Type[] { struct30_0.Type_0 });
            }
            if (method == null)
            {
                return null;
            }
            class2.delegate3_0 = Class139.Class166_0.ns20.Class166.‫‌‪⁪⁪‭⁬⁪‭‪‌‎‮‬​‌⁫‌⁫‬‎⁪‮‌⁮‏⁪‌‎‪‌⁭⁪⁯‏‬‫‭⁫⁬‮<object>(method);
            return new Func<object, object>(class2.method_0);
        }

        internal static BigInteger smethod_6(object object_0)
        {
            if (object_0 is BigInteger)
            {
                return (BigInteger) object_0;
            }
            if (object_0 is string)
            {
                return BigInteger.Parse((string) object_0, CultureInfo.InvariantCulture);
            }
            if (object_0 is float)
            {
                return new BigInteger((float) object_0);
            }
            if (object_0 is double)
            {
                return new BigInteger((double) object_0);
            }
            if (object_0 is decimal)
            {
                return new BigInteger((decimal) object_0);
            }
            if (object_0 is int)
            {
                return new BigInteger((int) object_0);
            }
            if (object_0 is long)
            {
                return new BigInteger((long) object_0);
            }
            if (object_0 is uint)
            {
                return new BigInteger((uint) object_0);
            }
            if (object_0 is ulong)
            {
                return new BigInteger((ulong) object_0);
            }
            if (!(object_0 is byte[]))
            {
                throw new InvalidCastException("Cannot convert {0} to BigInteger.".smethod_0(CultureInfo.InvariantCulture, object_0.GetType()));
            }
            return new BigInteger((byte[]) object_0);
        }

        public static object smethod_7(BigInteger bigInteger_0, Type type_0)
        {
            object obj2;
            if (type_0 == typeof(decimal))
            {
                return (decimal) bigInteger_0;
            }
            if (type_0 == typeof(double))
            {
                return (double) bigInteger_0;
            }
            if (type_0 == typeof(float))
            {
                return (float) bigInteger_0;
            }
            if (type_0 == typeof(ulong))
            {
                return (ulong) bigInteger_0;
            }
            try
            {
                obj2 = Convert.ChangeType((long) bigInteger_0, type_0, CultureInfo.InvariantCulture);
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException("Can not convert from BigInteger to {0}.".smethod_0(CultureInfo.InvariantCulture, type_0), exception);
            }
            return obj2;
        }

        public static object smethod_8(object object_0, CultureInfo cultureInfo_0, Type type_0)
        {
            if (object_0 == null)
            {
                throw new ArgumentNullException("initialValue");
            }
            if (Class194.smethod_10(type_0))
            {
                type_0 = Nullable.GetUnderlyingType(type_0);
            }
            Type type = object_0.GetType();
            if (type_0 == type)
            {
                return object_0;
            }
            if (smethod_3(object_0.GetType()) && smethod_3(type_0))
            {
                if (type_0.smethod_7())
                {
                    if (object_0 is string)
                    {
                        return Enum.Parse(type_0, object_0.ToString(), true);
                    }
                    if (smethod_14(object_0))
                    {
                        return Enum.ToObject(type_0, object_0);
                    }
                }
                return Convert.ChangeType(object_0, type_0, cultureInfo_0);
            }
            if ((object_0 is DateTime) && (type_0 == typeof(DateTimeOffset)))
            {
                return new DateTimeOffset((DateTime) object_0);
            }
            if ((object_0 is byte[]) && (type_0 == typeof(Guid)))
            {
                return new Guid((byte[]) object_0);
            }
            if (object_0 is string)
            {
                if (type_0 == typeof(Guid))
                {
                    return new Guid((string) object_0);
                }
                if (type_0 == typeof(Uri))
                {
                    return new Uri((string) object_0, UriKind.RelativeOrAbsolute);
                }
                if (type_0 == typeof(TimeSpan))
                {
                    return smethod_4((string) object_0);
                }
                if (typeof(Type).IsAssignableFrom(type_0))
                {
                    return Type.GetType((string) object_0, true);
                }
            }
            if (type_0 == typeof(BigInteger))
            {
                return smethod_6(object_0);
            }
            if (object_0 is BigInteger)
            {
                return smethod_7((BigInteger) object_0, type_0);
            }
            TypeConverter converter = smethod_13(type);
            if ((converter != null) && converter.CanConvertTo(type_0))
            {
                return converter.ConvertTo(null, cultureInfo_0, object_0, type_0);
            }
            TypeConverter converter2 = smethod_13(type_0);
            if ((converter2 != null) && converter2.CanConvertFrom(type))
            {
                return converter2.ConvertFrom(null, cultureInfo_0, object_0);
            }
            if (object_0 == DBNull.Value)
            {
                if (!Class194.smethod_9(type_0))
                {
                    throw new Exception("Can not convert null {0} into non-nullable {1}.".smethod_1(CultureInfo.InvariantCulture, type, type_0));
                }
                return smethod_11(null, type, type_0);
            }
            if (object_0 is INullable)
            {
                return smethod_11(smethod_12((INullable) object_0), type, type_0);
            }
            if ((!type_0.smethod_3() && !type_0.smethod_5()) && !type_0.smethod_10())
            {
                throw new InvalidOperationException("Can not convert from {0} to {1}.".smethod_1(CultureInfo.InvariantCulture, type, type_0));
            }
            throw new ArgumentException("Target type {0} is not a value type or a non-abstract class.".smethod_0(CultureInfo.InvariantCulture, type_0), "targetType");
        }

        public static bool smethod_9(object object_0, CultureInfo cultureInfo_0, Type type_0, out object object_1)
        {
            try
            {
                object_1 = smethod_8(object_0, cultureInfo_0, type_0);
                return true;
            }
            catch
            {
                object_1 = null;
                return false;
            }
        }

        [CompilerGenerated]
        private sealed class Class182
        {
            public Delegate3<object, object> delegate3_0;

            public object method_0(object object_0)
            {
                return this.delegate3_0(null, new object[] { object_0 });
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct Struct30 : IEquatable<Class181.Struct30>
        {
            private readonly Type type_0;
            private readonly Type type_1;
            public Type Type_0
            {
                get
                {
                    return this.type_0;
                }
            }
            public Type Type_1
            {
                get
                {
                    return this.type_1;
                }
            }
            public Struct30(Type initialType, Type targetType)
            {
                this.type_0 = initialType;
                this.type_1 = targetType;
            }

            int ValueType.GetHashCode()
            {
                return (this.type_0.GetHashCode() ^ this.type_1.GetHashCode());
            }

            bool ValueType.Equals(object obj)
            {
                return ((obj is Class181.Struct30) && this.Equals((Class181.Struct30) obj));
            }

            public bool Equals(Class181.Struct30 other)
            {
                return ((this.type_0 == other.type_0) && (this.type_1 == other.type_1));
            }
        }
    }
}

