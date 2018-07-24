namespace ns16
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.ComponentModel;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Security;
    using System.Security.Permissions;

    internal static class Class139
    {
        private static readonly Class178<object, Type> class178_0 = new Class178<object, Type>(new Func<object, Type>(Class139.smethod_9));
        private static readonly Class178<Type, Type> class178_1 = new Class178<Type, Type>(new Func<Type, Type>(Class139.smethod_13));
        private static bool? nullable_0;
        private static bool? nullable_1;
        public const string string_0 = "$id";
        public const string string_1 = "$ref";
        public const string string_2 = "$type";
        public const string string_3 = "$value";
        public const string string_4 = "$values";
        public const string string_5 = "ShouldSerialize";
        public const string string_6 = "Specified";
        private const string string_7 = "System.ComponentModel.DataAnnotations.MetadataTypeAttribute, System.ComponentModel.DataAnnotations, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
        private static Type type_0;

        public static JsonContainerAttribute smethod_0(Type type_1)
        {
            return Class140<JsonContainerAttribute>.smethod_0(type_1);
        }

        public static JsonObjectAttribute smethod_1(Type type_1)
        {
            return (smethod_0(type_1) as JsonObjectAttribute);
        }

        public static JsonConverter smethod_10(object object_0, Type type_1)
        {
            Type type = smethod_8(object_0);
            if (type != null)
            {
                return JsonConverterAttribute.smethod_0(type);
            }
            return null;
        }

        public static TypeConverter smethod_11(Type type_1)
        {
            return TypeDescriptor.GetConverter(type_1);
        }

        private static Type smethod_12(Type type_1)
        {
            return class178_1.method_0(type_1);
        }

        private static Type smethod_13(Type type_1)
        {
            Type attributeType = smethod_14();
            if (attributeType == null)
            {
                return null;
            }
            object obj2 = type_1.GetCustomAttributes(attributeType, true).SingleOrDefault<object>();
            if (obj2 == null)
            {
                return null;
            }
            Interface14 interface2 = Boolean_0 ? Class163.smethod_5<Interface14>(obj2) : new Class141(obj2);
            return interface2.Type_0;
        }

        private static Type smethod_14()
        {
            if (type_0 == null)
            {
                Type type = Type.GetType("System.ComponentModel.DataAnnotations.MetadataTypeAttribute, System.ComponentModel.DataAnnotations, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");
                if (type == null)
                {
                    return null;
                }
                type_0 = type;
            }
            return type_0;
        }

        private static T smethod_15<T>(Type type_1) where T: Attribute
        {
            T local;
            Type type = smethod_12(type_1);
            if (type != null)
            {
                local = Class194.smethod_30<T>(type, true);
                if (local != null)
                {
                    return local;
                }
            }
            local = Class194.smethod_30<T>(type_1, true);
            if (local != null)
            {
                return local;
            }
            foreach (Type type2 in type_1.GetInterfaces())
            {
                local = Class194.smethod_30<T>(type2, true);
                if (local != null)
                {
                    return local;
                }
            }
            return default(T);
        }

        private static T smethod_16<T>(MemberInfo memberInfo_0) where T: Attribute
        {
            T local;
            Type type = smethod_12(memberInfo_0.DeclaringType);
            if (type != null)
            {
                MemberInfo info = Class194.smethod_34(type, memberInfo_0);
                if (info != null)
                {
                    local = Class194.smethod_30<T>(info, true);
                    if (local != null)
                    {
                        return local;
                    }
                }
            }
            local = Class194.smethod_30<T>(memberInfo_0, true);
            if (local != null)
            {
                return local;
            }
            if (memberInfo_0.DeclaringType != null)
            {
                foreach (Type type2 in memberInfo_0.DeclaringType.GetInterfaces())
                {
                    MemberInfo info2 = Class194.smethod_34(type2, memberInfo_0);
                    if (info2 != null)
                    {
                        local = Class194.smethod_30<T>(info2, true);
                        if (local != null)
                        {
                            return local;
                        }
                    }
                }
            }
            return default(T);
        }

        public static T smethod_17<T>(object object_0) where T: Attribute
        {
            Type type = object_0 as Type;
            if (type != null)
            {
                return smethod_15<T>(type);
            }
            MemberInfo info = object_0 as MemberInfo;
            if (info != null)
            {
                return smethod_16<T>(info);
            }
            return Class194.smethod_30<T>(object_0, true);
        }

        public static JsonArrayAttribute smethod_2(Type type_1)
        {
            return (smethod_0(type_1) as JsonArrayAttribute);
        }

        public static JsonDictionaryAttribute smethod_3(Type type_1)
        {
            return (smethod_0(type_1) as JsonDictionaryAttribute);
        }

        public static SerializableAttribute smethod_4(Type type_1)
        {
            return Class140<SerializableAttribute>.smethod_0(type_1);
        }

        public static DataContractAttribute smethod_5(Type type_1)
        {
            for (Type type = type_1; type != null; type = type.smethod_6())
            {
                DataContractAttribute attribute = Class140<DataContractAttribute>.smethod_0(type);
                if (attribute != null)
                {
                    return attribute;
                }
            }
            return null;
        }

        public static DataMemberAttribute smethod_6(MemberInfo memberInfo_0)
        {
            if (memberInfo_0.smethod_1() == MemberTypes.Field)
            {
                return Class140<DataMemberAttribute>.smethod_0(memberInfo_0);
            }
            PropertyInfo info = (PropertyInfo) memberInfo_0;
            DataMemberAttribute attribute = Class140<DataMemberAttribute>.smethod_0(info);
            if ((attribute == null) && info.smethod_0())
            {
                for (Type type = info.DeclaringType; attribute == null; type = type.smethod_6())
                {
                    if (type == null)
                    {
                        return attribute;
                    }
                    PropertyInfo info2 = (PropertyInfo) Class194.smethod_34(type, info);
                    if ((info2 != null) && info2.smethod_0())
                    {
                        attribute = Class140<DataMemberAttribute>.smethod_0(info2);
                    }
                }
            }
            return attribute;
        }

        public static MemberSerialization smethod_7(Type type_1, bool bool_0)
        {
            JsonObjectAttribute attribute = smethod_1(type_1);
            if (attribute != null)
            {
                return attribute.MemberSerialization;
            }
            if (smethod_5(type_1) != null)
            {
                return MemberSerialization.OptIn;
            }
            if (!bool_0 && (smethod_4(type_1) != null))
            {
                return MemberSerialization.Fields;
            }
            return MemberSerialization.OptOut;
        }

        private static Type smethod_8(object object_0)
        {
            return class178_0.method_0(object_0);
        }

        private static Type smethod_9(object object_0)
        {
            JsonConverterAttribute attribute = smethod_17<JsonConverterAttribute>(object_0);
            if (attribute == null)
            {
                return null;
            }
            return attribute.ConverterType;
        }

        public static bool Boolean_0
        {
            [SecuritySafeCritical]
            get
            {
                if (!nullable_0.HasValue)
                {
                    try
                    {
                        new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Demand();
                        new ReflectionPermission(ReflectionPermissionFlag.RestrictedMemberAccess).Demand();
                        new SecurityPermission(SecurityPermissionFlag.SkipVerification).Demand();
                        new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
                        new SecurityPermission(PermissionState.Unrestricted).Demand();
                        nullable_0 = true;
                    }
                    catch (Exception)
                    {
                        nullable_0 = false;
                    }
                }
                return nullable_0.Value;
            }
        }

        public static bool Boolean_1
        {
            get
            {
                if (!nullable_1.HasValue)
                {
                    AppDomain currentDomain = AppDomain.CurrentDomain;
                    nullable_1 = new bool?(currentDomain.IsHomogenous && currentDomain.IsFullyTrusted);
                }
                return nullable_1.Value;
            }
        }

        public static Class166 Class166_0
        {
            get
            {
                if (Boolean_0)
                {
                    return Class167.class167_0;
                }
                return Class169.Class166_0;
            }
        }
    }
}

