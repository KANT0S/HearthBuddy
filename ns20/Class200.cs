namespace ns20
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;

    internal static class Class200
    {
        [CompilerGenerated]
        private static Func<ParameterInfo, Type> func_0;
        [CompilerGenerated]
        private static Func<Type, IEnumerable<MethodInfo>> func_1;
        [CompilerGenerated]
        private static Func<Type, MethodInfo, MethodInfo> func_2;

        public static MethodInfo smethod_0(this Delegate delegate_0)
        {
            return delegate_0.Method;
        }

        public static MemberTypes smethod_1(this MemberInfo memberInfo_0)
        {
            return memberInfo_0.MemberType;
        }

        public static bool smethod_10(this Type type_0)
        {
            return type_0.IsAbstract;
        }

        public static bool smethod_11(this Type type_0)
        {
            return type_0.IsVisible;
        }

        public static bool smethod_12(this Type type_0)
        {
            return type_0.IsValueType;
        }

        public static bool smethod_13(this Type type_0, string string_0, out Type type_1)
        {
            for (Type type = type_0; type != null; type = type.smethod_6())
            {
                if (string.Equals(type.FullName, string_0, StringComparison.Ordinal))
                {
                    type_1 = type;
                    return true;
                }
            }
            foreach (Type type2 in type_0.GetInterfaces())
            {
                if (string.Equals(type2.Name, string_0, StringComparison.Ordinal))
                {
                    type_1 = type_0;
                    return true;
                }
            }
            type_1 = null;
            return false;
        }

        public static bool smethod_14(this Type type_0, string string_0)
        {
            Type type;
            return type_0.smethod_13(string_0, out type);
        }

        public static MethodInfo smethod_15(this Type type_0, string string_0, params Type[] type_1)
        {
            Class201 class2 = new Class201 {
                string_0 = string_0
            };
            foreach (MethodInfo info in type_0.GetMethods().Where<MethodInfo>(new Func<MethodInfo, bool>(class2.method_0)))
            {
                if (info.smethod_16(type_1))
                {
                    return info;
                }
            }
            return null;
        }

        public static bool smethod_16(this MethodInfo methodInfo_0, params Type[] type_0)
        {
            if (func_0 == null)
            {
                func_0 = new Func<ParameterInfo, Type>(Class200.smethod_19);
            }
            Type[] typeArray = methodInfo_0.GetParameters().Select<ParameterInfo, Type>(func_0).ToArray<Type>();
            if (typeArray.Length != type_0.Length)
            {
                return false;
            }
            for (int i = 0; i < typeArray.Length; i++)
            {
                if (typeArray[i].ToString() != type_0[i].ToString())
                {
                    return false;
                }
            }
            return true;
        }

        public static IEnumerable<Type> smethod_17(this Type type_0)
        {
            this.type_5 = type_0.GetInterfaces();
            this.int_2 = 0;
        Label_00AF:
            if (this.int_2 >= this.type_5.Length)
            {
                this.method_0();
            }
            this.type_3 = this.type_5[this.int_2];
            yield return this.type_3;
            this.type_6 = this.type_3.GetInterfaces();
            this.int_3 = 0;
        Label_PostSwitchInIterator:;
            if (this.int_3 < this.type_6.Length)
            {
                this.type_4 = this.type_6[this.int_3];
                yield return this.type_4;
                this.int_3++;
                goto Label_PostSwitchInIterator;
            }
            this.method_1();
            this.int_2++;
            goto Label_00AF;
        }

        public static IEnumerable<MethodInfo> smethod_18(this Type type_0)
        {
            List<Type> source = type_0.smethod_17().ToList<Type>();
            source.Add(type_0);
            if (func_1 == null)
            {
                func_1 = new Func<Type, IEnumerable<MethodInfo>>(Class200.smethod_20);
            }
            if (func_2 == null)
            {
                func_2 = new Func<Type, MethodInfo, MethodInfo>(Class200.smethod_21);
            }
            return source.SelectMany<Type, MethodInfo, MethodInfo>(func_1, func_2);
        }

        [CompilerGenerated]
        private static Type smethod_19(ParameterInfo parameterInfo_0)
        {
            return parameterInfo_0.ParameterType;
        }

        public static bool smethod_2(this Type type_0)
        {
            return type_0.ContainsGenericParameters;
        }

        [CompilerGenerated]
        private static IEnumerable<MethodInfo> smethod_20(Type type_0)
        {
            return type_0.GetMethods();
        }

        [CompilerGenerated]
        private static MethodInfo smethod_21(Type type_0, MethodInfo methodInfo_0)
        {
            return methodInfo_0;
        }

        public static bool smethod_3(this Type type_0)
        {
            return type_0.IsInterface;
        }

        public static bool smethod_4(this Type type_0)
        {
            return type_0.IsGenericType;
        }

        public static bool smethod_5(this Type type_0)
        {
            return type_0.IsGenericTypeDefinition;
        }

        public static Type smethod_6(this Type type_0)
        {
            return type_0.BaseType;
        }

        public static bool smethod_7(this Type type_0)
        {
            return type_0.IsEnum;
        }

        public static bool smethod_8(this Type type_0)
        {
            return type_0.IsClass;
        }

        public static bool smethod_9(this Type type_0)
        {
            return type_0.IsSealed;
        }

        [CompilerGenerated]
        private sealed class Class201
        {
            public string string_0;

            public bool method_0(MethodInfo methodInfo_0)
            {
                return (methodInfo_0.Name == this.string_0);
            }
        }

    }
}

