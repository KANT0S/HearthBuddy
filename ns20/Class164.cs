namespace ns20
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;

    internal class Class164
    {
        [CompilerGenerated]
        private static Func<ParameterInfo, Type> func_0;
        [CompilerGenerated]
        private static Func<Type, string> func_1;
        private readonly Type type_0;
        private readonly TypeBuilder typeBuilder_0;

        public Class164(Type realObjectType, TypeBuilder proxyBuilder)
        {
            this.type_0 = realObjectType;
            this.typeBuilder_0 = proxyBuilder;
        }

        public void method_0(MethodInfo methodInfo_0)
        {
            if (methodInfo_0.IsGenericMethod)
            {
                methodInfo_0 = methodInfo_0.GetGenericMethodDefinition();
            }
            FieldInfo field = typeof(Class162).GetField("UnderlyingObject", BindingFlags.NonPublic | BindingFlags.Instance);
            ParameterInfo[] parameters = methodInfo_0.GetParameters();
            if (func_0 == null)
            {
                func_0 = new Func<ParameterInfo, Type>(Class164.smethod_3);
            }
            Type[] parameterTypes = parameters.Select<ParameterInfo, Type>(func_0).ToArray<Type>();
            MethodBuilder builder = this.typeBuilder_0.DefineMethod(methodInfo_0.Name, MethodAttributes.Virtual | MethodAttributes.Public, methodInfo_0.ReturnType, parameterTypes);
            if (methodInfo_0.IsGenericMethod)
            {
                if (func_1 == null)
                {
                    func_1 = new Func<Type, string>(Class164.smethod_4);
                }
                builder.DefineGenericParameters(methodInfo_0.GetGenericArguments().Select<Type, string>(func_1).ToArray<string>());
            }
            ILGenerator iLGenerator = builder.GetILGenerator();
            smethod_2(iLGenerator, field);
            smethod_1(parameters, iLGenerator);
            this.method_1(methodInfo_0, parameterTypes, iLGenerator);
            smethod_0(iLGenerator);
        }

        private void method_1(MethodBase methodBase_0, Type[] type_1, ILGenerator ilgenerator_0)
        {
            MethodInfo meth = this.method_2(methodBase_0, type_1);
            if (meth == null)
            {
                throw new MissingMethodException("Unable to find method " + methodBase_0.Name + " on " + this.type_0.FullName);
            }
            ilgenerator_0.Emit(OpCodes.Call, meth);
        }

        private MethodInfo method_2(MethodBase methodBase_0, Type[] type_1)
        {
            if (methodBase_0.IsGenericMethod)
            {
                return this.type_0.smethod_15(methodBase_0.Name, type_1);
            }
            return this.type_0.GetMethod(methodBase_0.Name, type_1);
        }

        private static void smethod_0(ILGenerator ilgenerator_0)
        {
            ilgenerator_0.Emit(OpCodes.Ret);
        }

        private static void smethod_1(ICollection<ParameterInfo> icollection_0, ILGenerator ilgenerator_0)
        {
            for (int i = 1; i < (icollection_0.Count + 1); i++)
            {
                ilgenerator_0.Emit(OpCodes.Ldarg, i);
            }
        }

        private static void smethod_2(ILGenerator ilgenerator_0, FieldInfo fieldInfo_0)
        {
            ilgenerator_0.Emit(OpCodes.Ldarg_0);
            ilgenerator_0.Emit(OpCodes.Ldfld, fieldInfo_0);
        }

        [CompilerGenerated]
        private static Type smethod_3(ParameterInfo parameterInfo_0)
        {
            return parameterInfo_0.ParameterType;
        }

        [CompilerGenerated]
        private static string smethod_4(Type type_1)
        {
            return type_1.Name;
        }
    }
}

