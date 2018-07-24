namespace ns20
{
    using ns16;
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    internal static class Class157
    {
        public static IEnumerable<string> smethod_0(this IDynamicMetaObjectProvider idynamicMetaObjectProvider_0)
        {
            return idynamicMetaObjectProvider_0.GetMetaObject(Expression.Constant(idynamicMetaObjectProvider_0)).GetDynamicMemberNames();
        }

        internal static class Class158
        {
            private static bool bool_0;
            private static Delegate3<object, object> delegate3_0;
            private static Delegate3<object, object> delegate3_1;
            private static object object_0;
            private static object object_1;
            public const string string_0 = "Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
            private const string string_1 = "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
            private const string string_2 = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
            private const string string_3 = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
            private const string string_4 = "Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

            private static void smethod_0()
            {
                if (!bool_0)
                {
                    if (Type.GetType("Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", false) == null)
                    {
                        throw new InvalidOperationException("Could not resolve type '{0}'. You may need to add a reference to Microsoft.CSharp.dll to work with dynamic types.".smethod_0(CultureInfo.InvariantCulture, "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
                    }
                    object_0 = smethod_1(new int[1]);
                    int[] numArray2 = new int[2];
                    numArray2[1] = 3;
                    object_1 = smethod_1(numArray2);
                    smethod_2();
                    bool_0 = true;
                }
            }

            private static object smethod_1(params int[] int_0)
            {
                Type elementType = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
                Type type = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
                Array array = Array.CreateInstance(elementType, int_0.Length);
                for (int i = 0; i < int_0.Length; i++)
                {
                    object[] parameters = new object[2];
                    parameters[0] = 0;
                    object obj2 = elementType.GetMethod("Create", new Type[] { type, typeof(string) }).Invoke(null, parameters);
                    array.SetValue(obj2, i);
                }
                return array;
            }

            private static void smethod_2()
            {
                Type type = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true);
                Type type2 = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true);
                Type type3 = Type.GetType("Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true);
                Type type4 = typeof(IEnumerable<>).MakeGenericType(new Type[] { type });
                MethodInfo method = type3.GetMethod("GetMember", new Type[] { type2, typeof(string), typeof(Type), type4 });
                delegate3_0 = Class139.Class166_0.ns20.Class166.‫‌‪⁪⁪‭⁬⁪‭‪‌‎‮‬​‌⁫‌⁫‬‎⁪‮‌⁮‏⁪‌‎‪‌⁭⁪⁯‏‬‫‭⁫⁬‮<object>(method);
                MethodInfo info2 = type3.GetMethod("SetMember", new Type[] { type2, typeof(string), typeof(Type), type4 });
                delegate3_1 = Class139.Class166_0.ns20.Class166.‫‌‪⁪⁪‭⁬⁪‭‪‌‎‮‬​‌⁫‌⁫‬‎⁪‮‌⁮‏⁪‌‎‪‌⁭⁪⁯‏‬‫‭⁫⁬‮<object>(info2);
            }

            public static CallSiteBinder smethod_3(string string_5, Type type_0)
            {
                smethod_0();
                return (CallSiteBinder) delegate3_0(null, new object[] { 0, string_5, type_0, object_0 });
            }

            public static CallSiteBinder smethod_4(string string_5, Type type_0)
            {
                smethod_0();
                return (CallSiteBinder) delegate3_1(null, new object[] { 0, string_5, type_0, object_1 });
            }
        }
    }
}

