namespace ns20
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Numerics;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters;
    using System.Text;

    internal static class Class194
    {
        [CompilerGenerated]
        private static Func<ConstructorInfo, bool> func_0;
        [CompilerGenerated]
        private static Func<MemberInfo, string> func_1;
        [CompilerGenerated]
        private static Func<ParameterInfo, Type> func_2;
        [CompilerGenerated]
        private static Func<FieldInfo, bool> func_3;
        public static readonly Type[] type_0 = Type.EmptyTypes;

        public static bool smethod_0(this PropertyInfo propertyInfo_0)
        {
            Class203.smethod_2(propertyInfo_0, "propertyInfo");
            MethodInfo getMethod = propertyInfo_0.GetGetMethod();
            if ((getMethod != null) && getMethod.IsVirtual)
            {
                return true;
            }
            getMethod = propertyInfo_0.GetSetMethod();
            return ((getMethod != null) && getMethod.IsVirtual);
        }

        public static MethodInfo smethod_1(this PropertyInfo propertyInfo_0)
        {
            Class203.smethod_2(propertyInfo_0, "propertyInfo");
            MethodInfo getMethod = propertyInfo_0.GetGetMethod();
            if (getMethod != null)
            {
                return getMethod.GetBaseDefinition();
            }
            getMethod = propertyInfo_0.GetSetMethod();
            if (getMethod != null)
            {
                return getMethod.GetBaseDefinition();
            }
            return null;
        }

        public static bool smethod_10(Type type_1)
        {
            Class203.smethod_2(type_1, "t");
            return (type_1.smethod_4() && (type_1.GetGenericTypeDefinition() == typeof(Nullable<>)));
        }

        public static Type smethod_11(Type type_1)
        {
            if (!smethod_10(type_1))
            {
                return type_1;
            }
            return Nullable.GetUnderlyingType(type_1);
        }

        public static bool smethod_12(Type type_1, Type type_2)
        {
            if (!type_1.smethod_4())
            {
                return false;
            }
            return (type_1.GetGenericTypeDefinition() == type_2);
        }

        public static bool smethod_13(Type type_1, Type type_2)
        {
            Type type;
            return smethod_14(type_1, type_2, out type);
        }

        public static bool smethod_14(Type type_1, Type type_2, out Type type_3)
        {
            Class203.smethod_2(type_1, "type");
            Class203.smethod_2(type_2, "genericInterfaceDefinition");
            if (!type_2.smethod_3() || !type_2.smethod_5())
            {
                throw new ArgumentNullException("'{0}' is not a generic interface definition.".smethod_0(CultureInfo.InvariantCulture, type_2));
            }
            if (type_1.smethod_3() && type_1.smethod_4())
            {
                Type genericTypeDefinition = type_1.GetGenericTypeDefinition();
                if (type_2 == genericTypeDefinition)
                {
                    type_3 = type_1;
                    return true;
                }
            }
            foreach (Type type2 in type_1.GetInterfaces())
            {
                if (type2.smethod_4())
                {
                    Type type3 = type2.GetGenericTypeDefinition();
                    if (type_2 == type3)
                    {
                        type_3 = type2;
                        return true;
                    }
                }
            }
            type_3 = null;
            return false;
        }

        public static bool smethod_15(Type type_1, Type type_2)
        {
            Type type;
            return smethod_16(type_1, type_2, out type);
        }

        public static bool smethod_16(Type type_1, Type type_2, out Type type_3)
        {
            Class203.smethod_2(type_1, "type");
            Class203.smethod_2(type_2, "genericClassDefinition");
            if (!type_2.smethod_8() || !type_2.smethod_5())
            {
                throw new ArgumentNullException("'{0}' is not a generic class definition.".smethod_0(CultureInfo.InvariantCulture, type_2));
            }
            return smethod_17(type_1, type_2, out type_3);
        }

        private static bool smethod_17(Type type_1, Type type_2, out Type type_3)
        {
            if (type_1.smethod_4())
            {
                Type genericTypeDefinition = type_1.GetGenericTypeDefinition();
                if (type_2 == genericTypeDefinition)
                {
                    type_3 = type_1;
                    return true;
                }
            }
            if (type_1.smethod_6() == null)
            {
                type_3 = null;
                return false;
            }
            return smethod_17(type_1.smethod_6(), type_2, out type_3);
        }

        public static Type smethod_18(Type type_1)
        {
            Type type;
            Class203.smethod_2(type_1, "type");
            if (type_1.IsArray)
            {
                return type_1.GetElementType();
            }
            if (smethod_14(type_1, typeof(IEnumerable<>), out type))
            {
                if (type.smethod_5())
                {
                    throw new Exception("Type {0} is not a collection.".smethod_0(CultureInfo.InvariantCulture, type_1));
                }
                return type.GetGenericArguments()[0];
            }
            if (!typeof(IEnumerable).IsAssignableFrom(type_1))
            {
                throw new Exception("Type {0} is not a collection.".smethod_0(CultureInfo.InvariantCulture, type_1));
            }
            return null;
        }

        public static void smethod_19(Type type_1, out Type type_2, out Type type_3)
        {
            Type type;
            Class203.smethod_2(type_1, "type");
            if (smethod_14(type_1, typeof(IDictionary<,>), out type))
            {
                if (type.smethod_5())
                {
                    throw new Exception("Type {0} is not a dictionary.".smethod_0(CultureInfo.InvariantCulture, type_1));
                }
                Type[] genericArguments = type.GetGenericArguments();
                type_2 = genericArguments[0];
                type_3 = genericArguments[1];
            }
            else
            {
                if (!typeof(IDictionary).IsAssignableFrom(type_1))
                {
                    throw new Exception("Type {0} is not a dictionary.".smethod_0(CultureInfo.InvariantCulture, type_1));
                }
                type_2 = null;
                type_3 = null;
            }
        }

        public static bool smethod_2(PropertyInfo propertyInfo_0)
        {
            return (((propertyInfo_0.GetGetMethod() != null) && propertyInfo_0.GetGetMethod().IsPublic) || ((propertyInfo_0.GetSetMethod() != null) && propertyInfo_0.GetSetMethod().IsPublic));
        }

        public static Type smethod_20(MemberInfo memberInfo_0)
        {
            Class203.smethod_2(memberInfo_0, "member");
            switch (memberInfo_0.smethod_1())
            {
                case MemberTypes.Event:
                    return ((EventInfo) memberInfo_0).EventHandlerType;

                case MemberTypes.Field:
                    return ((FieldInfo) memberInfo_0).FieldType;

                case MemberTypes.Property:
                    return ((PropertyInfo) memberInfo_0).PropertyType;
            }
            throw new ArgumentException("MemberInfo must be of type FieldInfo, PropertyInfo or EventInfo", "member");
        }

        public static bool smethod_21(MemberInfo memberInfo_0)
        {
            Class203.smethod_2(memberInfo_0, "member");
            PropertyInfo info = memberInfo_0 as PropertyInfo;
            return ((info != null) && smethod_22(info));
        }

        public static bool smethod_22(PropertyInfo propertyInfo_0)
        {
            Class203.smethod_2(propertyInfo_0, "property");
            return (propertyInfo_0.GetIndexParameters().Length > 0);
        }

        public static object smethod_23(MemberInfo memberInfo_0, object object_0)
        {
            object obj2;
            Class203.smethod_2(memberInfo_0, "member");
            Class203.smethod_2(object_0, "target");
            MemberTypes types = memberInfo_0.smethod_1();
            if (types == MemberTypes.Field)
            {
                return ((FieldInfo) memberInfo_0).GetValue(object_0);
            }
            if (types != MemberTypes.Property)
            {
                throw new ArgumentException("MemberInfo '{0}' is not of type FieldInfo or PropertyInfo".smethod_1(CultureInfo.InvariantCulture, CultureInfo.InvariantCulture, memberInfo_0.Name), "member");
            }
            try
            {
                obj2 = ((PropertyInfo) memberInfo_0).GetValue(object_0, null);
            }
            catch (TargetParameterCountException exception)
            {
                throw new ArgumentException("MemberInfo '{0}' has index parameters".smethod_0(CultureInfo.InvariantCulture, memberInfo_0.Name), exception);
            }
            return obj2;
        }

        public static void smethod_24(MemberInfo memberInfo_0, object object_0, object object_1)
        {
            Class203.smethod_2(memberInfo_0, "member");
            Class203.smethod_2(object_0, "target");
            MemberTypes types = memberInfo_0.smethod_1();
            if (types != MemberTypes.Field)
            {
                if (types != MemberTypes.Property)
                {
                    throw new ArgumentException("MemberInfo '{0}' must be of type FieldInfo or PropertyInfo".smethod_0(CultureInfo.InvariantCulture, memberInfo_0.Name), "member");
                }
                ((PropertyInfo) memberInfo_0).SetValue(object_0, object_1, null);
            }
            else
            {
                ((FieldInfo) memberInfo_0).SetValue(object_0, object_1);
            }
        }

        public static bool smethod_25(MemberInfo memberInfo_0, bool bool_0)
        {
            MemberTypes types = memberInfo_0.smethod_1();
            if (types != MemberTypes.Field)
            {
                if (types != MemberTypes.Property)
                {
                    return false;
                }
                PropertyInfo info2 = (PropertyInfo) memberInfo_0;
                if (!info2.CanRead)
                {
                    return false;
                }
                return (bool_0 || (info2.GetGetMethod(bool_0) != null));
            }
            FieldInfo info = (FieldInfo) memberInfo_0;
            return (bool_0 || info.IsPublic);
        }

        public static bool smethod_26(MemberInfo memberInfo_0, bool bool_0, bool bool_1)
        {
            MemberTypes types = memberInfo_0.smethod_1();
            if (types != MemberTypes.Field)
            {
                if (types != MemberTypes.Property)
                {
                    return false;
                }
                PropertyInfo info2 = (PropertyInfo) memberInfo_0;
                if (!info2.CanWrite)
                {
                    return false;
                }
                return (bool_0 || (info2.GetSetMethod(bool_0) != null));
            }
            FieldInfo info = (FieldInfo) memberInfo_0;
            if (info.IsInitOnly && !bool_1)
            {
                return false;
            }
            return (bool_0 || info.IsPublic);
        }

        public static List<MemberInfo> smethod_27(Type type_1, BindingFlags bindingFlags_0)
        {
            Func<MemberInfo, bool> predicate = null;
            Class195 class2 = new Class195 {
                bindingFlags_0 = bindingFlags_0
            };
            List<MemberInfo> source = new List<MemberInfo>();
            source.AddRange(smethod_35(type_1, class2.bindingFlags_0));
            source.AddRange(smethod_37(type_1, class2.bindingFlags_0));
            List<MemberInfo> list2 = new List<MemberInfo>(source.Count);
            if (func_1 == null)
            {
                func_1 = new Func<MemberInfo, string>(Class194.smethod_43);
            }
            foreach (IGrouping<string, MemberInfo> grouping in source.GroupBy<MemberInfo, string>(func_1))
            {
                int num = grouping.Count<MemberInfo>();
                IList<MemberInfo> list3 = grouping.ToList<MemberInfo>();
                if (num == 1)
                {
                    list2.Add(list3.First<MemberInfo>());
                }
                else
                {
                    if (predicate == null)
                    {
                        predicate = new Func<MemberInfo, bool>(class2.method_0);
                    }
                    IEnumerable<MemberInfo> collection = list3.Where<MemberInfo>(predicate);
                    list2.AddRange(collection);
                }
            }
            return list2;
        }

        private static bool smethod_28(MemberInfo memberInfo_0, BindingFlags bindingFlags_0)
        {
            MemberTypes types = memberInfo_0.smethod_1();
            if ((types != MemberTypes.Field) && (types != MemberTypes.Property))
            {
                throw new ArgumentException("Member must be a field or property.");
            }
            Type declaringType = memberInfo_0.DeclaringType;
            if (!declaringType.smethod_4())
            {
                return false;
            }
            Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
            if (genericTypeDefinition == null)
            {
                return false;
            }
            MemberInfo[] member = genericTypeDefinition.GetMember(memberInfo_0.Name, bindingFlags_0);
            if (member.Length == 0)
            {
                return false;
            }
            if (!smethod_20(member[0]).IsGenericParameter)
            {
                return false;
            }
            return true;
        }

        public static T smethod_29<T>(object object_0) where T: Attribute
        {
            return smethod_30<T>(object_0, true);
        }

        public static Type smethod_3(object object_0)
        {
            if (object_0 == null)
            {
                return null;
            }
            return object_0.GetType();
        }

        public static T smethod_30<T>(object object_0, bool bool_0) where T: Attribute
        {
            T[] source = smethod_31<T>(object_0, bool_0);
            if (source == null)
            {
                return default(T);
            }
            return source.SingleOrDefault<T>();
        }

        public static T[] smethod_31<T>(object object_0, bool bool_0) where T: Attribute
        {
            Class203.smethod_2(object_0, "attributeProvider");
            object obj2 = object_0;
            if (obj2 is Type)
            {
                return (T[]) ((Type) obj2).GetCustomAttributes(typeof(T), bool_0);
            }
            if (obj2 is Assembly)
            {
                return (T[]) Attribute.GetCustomAttributes((Assembly) obj2, typeof(T));
            }
            if (obj2 is MemberInfo)
            {
                return (T[]) Attribute.GetCustomAttributes((MemberInfo) obj2, typeof(T), bool_0);
            }
            if (obj2 is Module)
            {
                return (T[]) Attribute.GetCustomAttributes((Module) obj2, typeof(T), bool_0);
            }
            if (obj2 is ParameterInfo)
            {
                return (T[]) Attribute.GetCustomAttributes((ParameterInfo) obj2, typeof(T), bool_0);
            }
            return (T[]) ((ICustomAttributeProvider) object_0).GetCustomAttributes(typeof(T), bool_0);
        }

        public static void smethod_32(string string_0, out string string_1, out string string_2)
        {
            int? nullable = smethod_33(string_0);
            if (nullable.HasValue)
            {
                string_1 = string_0.Substring(0, nullable.Value).Trim();
                string_2 = string_0.Substring(nullable.Value + 1, (string_0.Length - nullable.Value) - 1).Trim();
            }
            else
            {
                string_1 = string_0;
                string_2 = null;
            }
        }

        private static int? smethod_33(string string_0)
        {
            int num = 0;
            for (int i = 0; i < string_0.Length; i++)
            {
                switch (string_0[i])
                {
                    case '[':
                        num++;
                        break;

                    case ']':
                        num--;
                        break;

                    case ',':
                        if (num == 0)
                        {
                            return new int?(i);
                        }
                        break;
                }
            }
            return null;
        }

        public static MemberInfo smethod_34(Type type_1, MemberInfo memberInfo_0)
        {
            if (memberInfo_0.smethod_1() != MemberTypes.Property)
            {
                return type_1.GetMember(memberInfo_0.Name, memberInfo_0.smethod_1(), BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance).SingleOrDefault<MemberInfo>();
            }
            PropertyInfo info = (PropertyInfo) memberInfo_0;
            if (func_2 == null)
            {
                func_2 = new Func<ParameterInfo, Type>(Class194.smethod_44);
            }
            Type[] types = info.GetIndexParameters().Select<ParameterInfo, Type>(func_2).ToArray<Type>();
            return type_1.GetProperty(info.Name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance, null, info.PropertyType, types, null);
        }

        public static IEnumerable<FieldInfo> smethod_35(Type type_1, BindingFlags bindingFlags_0)
        {
            Class203.smethod_2(type_1, "targetType");
            List<MemberInfo> list = new List<MemberInfo>(type_1.GetFields(bindingFlags_0));
            smethod_36(list, type_1, bindingFlags_0);
            return list.Cast<FieldInfo>();
        }

        private static void smethod_36(IList<MemberInfo> ilist_0, Type type_1, BindingFlags bindingFlags_0)
        {
            if ((bindingFlags_0 & BindingFlags.NonPublic) != BindingFlags.Default)
            {
                BindingFlags bindingAttr = bindingFlags_0.smethod_38(BindingFlags.Public);
                while ((type_1 = type_1.smethod_6()) != null)
                {
                    if (func_3 == null)
                    {
                        func_3 = new Func<FieldInfo, bool>(Class194.smethod_45);
                    }
                    IEnumerable<MemberInfo> enumerable = type_1.GetFields(bindingAttr).Where<FieldInfo>(func_3).Cast<MemberInfo>();
                    ilist_0.smethod_1<MemberInfo>(enumerable);
                }
            }
        }

        public static IEnumerable<PropertyInfo> smethod_37(Type type_1, BindingFlags bindingFlags_0)
        {
            Class203.smethod_2(type_1, "targetType");
            List<PropertyInfo> list = new List<PropertyInfo>(type_1.GetProperties(bindingFlags_0));
            smethod_39(list, type_1, bindingFlags_0);
            for (int i = 0; i < list.Count; i++)
            {
                PropertyInfo info = list[i];
                if (info.DeclaringType != type_1)
                {
                    PropertyInfo info2 = (PropertyInfo) smethod_34(info.DeclaringType, info);
                    list[i] = info2;
                }
            }
            return list;
        }

        public static BindingFlags smethod_38(this BindingFlags bindingFlags_0, BindingFlags bindingFlags_1)
        {
            if ((bindingFlags_0 & bindingFlags_1) != bindingFlags_1)
            {
                return bindingFlags_0;
            }
            return (bindingFlags_0 ^ bindingFlags_1);
        }

        private static void smethod_39(IList<PropertyInfo> ilist_0, Type type_1, BindingFlags bindingFlags_0)
        {
            while ((type_1 = type_1.smethod_6()) != null)
            {
                foreach (PropertyInfo info in type_1.GetProperties(bindingFlags_0))
                {
                    Func<PropertyInfo, bool> func = null;
                    Func<PropertyInfo, bool> func2 = null;
                    Func<PropertyInfo, bool> func3 = null;
                    Class196 class2 = new Class196 {
                        propertyInfo_0 = info
                    };
                    if (!smethod_2(class2.propertyInfo_0))
                    {
                        if (func == null)
                        {
                            func = new Func<PropertyInfo, bool>(class2.method_0);
                        }
                        int num = ilist_0.smethod_8<PropertyInfo>(func);
                        if (num == -1)
                        {
                            ilist_0.Add(class2.propertyInfo_0);
                        }
                        else
                        {
                            ilist_0[num] = class2.propertyInfo_0;
                        }
                    }
                    else if (!class2.propertyInfo_0.smethod_0())
                    {
                        if (func2 == null)
                        {
                            func2 = new Func<PropertyInfo, bool>(class2.method_1);
                        }
                        if (ilist_0.smethod_8<PropertyInfo>(func2) == -1)
                        {
                            ilist_0.Add(class2.propertyInfo_0);
                        }
                    }
                    else
                    {
                        if (func3 == null)
                        {
                            func3 = new Func<PropertyInfo, bool>(class2.method_2);
                        }
                        if (ilist_0.smethod_8<PropertyInfo>(func3) == -1)
                        {
                            ilist_0.Add(class2.propertyInfo_0);
                        }
                    }
                }
            }
        }

        public static string smethod_4(Type type_1, FormatterAssemblyStyle formatterAssemblyStyle_0, SerializationBinder serializationBinder_0)
        {
            string assemblyQualifiedName;
            if (serializationBinder_0 != null)
            {
                string str2;
                string str3;
                serializationBinder_0.BindToName(type_1, out str2, out str3);
                assemblyQualifiedName = str3 + ((str2 == null) ? "" : (", " + str2));
            }
            else
            {
                assemblyQualifiedName = type_1.AssemblyQualifiedName;
            }
            switch (formatterAssemblyStyle_0)
            {
                case FormatterAssemblyStyle.Simple:
                    return smethod_5(assemblyQualifiedName);

                case FormatterAssemblyStyle.Full:
                    return assemblyQualifiedName;
            }
            throw new ArgumentOutOfRangeException();
        }

        public static bool smethod_40(Type type_1, Type type_2, string string_0)
        {
            Class197 class2 = new Class197 {
                type_0 = type_2,
                string_0 = string_0
            };
            return type_1.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).Any<MethodInfo>(new Func<MethodInfo, bool>(class2.method_0));
        }

        public static object smethod_41(Type type_1)
        {
            if (!type_1.smethod_12())
            {
                return null;
            }
            switch (Class181.smethod_0(type_1))
            {
                case Enum17.Char:
                case Enum17.SByte:
                case Enum17.Int16:
                case Enum17.UInt16:
                case Enum17.Int32:
                case Enum17.Byte:
                case Enum17.UInt32:
                    return 0;

                case Enum17.Boolean:
                    return false;

                case Enum17.Int64:
                case Enum17.UInt64:
                    return 0L;

                case Enum17.Single:
                    return 0f;

                case Enum17.Double:
                    return 0.0;

                case Enum17.DateTime:
                    return new DateTime();

                case Enum17.DateTimeOffset:
                    return new DateTimeOffset();

                case Enum17.Decimal:
                    return 0M;

                case Enum17.Guid:
                    return new Guid();

                case Enum17.BigInteger:
                    return new BigInteger();
            }
            if (smethod_9(type_1))
            {
                return null;
            }
            return Activator.CreateInstance(type_1);
        }

        [CompilerGenerated]
        private static bool smethod_42(ConstructorInfo constructorInfo_0)
        {
            return !constructorInfo_0.GetParameters().Any<ParameterInfo>();
        }

        [CompilerGenerated]
        private static string smethod_43(MemberInfo memberInfo_0)
        {
            return memberInfo_0.Name;
        }

        [CompilerGenerated]
        private static Type smethod_44(ParameterInfo parameterInfo_0)
        {
            return parameterInfo_0.ParameterType;
        }

        [CompilerGenerated]
        private static bool smethod_45(FieldInfo fieldInfo_0)
        {
            return fieldInfo_0.IsPrivate;
        }

        private static string smethod_5(string string_0)
        {
            StringBuilder builder = new StringBuilder();
            bool flag = false;
            bool flag2 = false;
            for (int i = 0; i < string_0.Length; i++)
            {
                char ch = string_0[i];
                switch (ch)
                {
                    case '[':
                    {
                        flag = false;
                        flag2 = false;
                        builder.Append(ch);
                        continue;
                    }
                    case ']':
                    {
                        flag = false;
                        flag2 = false;
                        builder.Append(ch);
                        continue;
                    }
                    case ',':
                    {
                        if (!flag)
                        {
                            flag = true;
                            builder.Append(ch);
                        }
                        else
                        {
                            flag2 = true;
                        }
                        continue;
                    }
                }
                if (!flag2)
                {
                    builder.Append(ch);
                }
            }
            return builder.ToString();
        }

        public static bool smethod_6(Type type_1, bool bool_0)
        {
            Class203.smethod_2(type_1, "t");
            return (type_1.smethod_12() || (smethod_8(type_1, bool_0) != null));
        }

        public static ConstructorInfo smethod_7(Type type_1)
        {
            return smethod_8(type_1, false);
        }

        public static ConstructorInfo smethod_8(Type type_1, bool bool_0)
        {
            BindingFlags bindingAttr = BindingFlags.Public | BindingFlags.Instance;
            if (bool_0)
            {
                bindingAttr |= BindingFlags.NonPublic;
            }
            if (func_0 == null)
            {
                func_0 = new Func<ConstructorInfo, bool>(Class194.smethod_42);
            }
            return type_1.GetConstructors(bindingAttr).SingleOrDefault<ConstructorInfo>(func_0);
        }

        public static bool smethod_9(Type type_1)
        {
            Class203.smethod_2(type_1, "t");
            if (type_1.smethod_12())
            {
                return smethod_10(type_1);
            }
            return true;
        }

        [CompilerGenerated]
        private sealed class Class195
        {
            public BindingFlags bindingFlags_0;

            public bool method_0(MemberInfo memberInfo_0)
            {
                if (Class194.smethod_28(memberInfo_0, this.bindingFlags_0))
                {
                    return (memberInfo_0.Name == "Item");
                }
                return true;
            }
        }

        [CompilerGenerated]
        private sealed class Class196
        {
            public PropertyInfo propertyInfo_0;

            public bool method_0(PropertyInfo propertyInfo_1)
            {
                return (propertyInfo_1.Name == this.propertyInfo_0.Name);
            }

            public bool method_1(PropertyInfo propertyInfo_1)
            {
                return ((propertyInfo_1.Name == this.propertyInfo_0.Name) && (propertyInfo_1.DeclaringType == this.propertyInfo_0.DeclaringType));
            }

            public bool method_2(PropertyInfo propertyInfo_1)
            {
                return ((((propertyInfo_1.Name == this.propertyInfo_0.Name) && propertyInfo_1.smethod_0()) && (propertyInfo_1.smethod_1() != null)) && propertyInfo_1.smethod_1().DeclaringType.IsAssignableFrom(this.propertyInfo_0.DeclaringType));
            }
        }

        [CompilerGenerated]
        private sealed class Class197
        {
            public string string_0;
            public Type type_0;

            public bool method_0(MethodInfo methodInfo_0)
            {
                return (((methodInfo_0.Name == this.string_0) && (methodInfo_0.DeclaringType != this.type_0)) && (methodInfo_0.GetBaseDefinition().DeclaringType == this.type_0));
            }
        }
    }
}

