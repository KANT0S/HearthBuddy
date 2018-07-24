namespace ns20
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;

    internal static class Class171
    {
        public static void smethod_0(this ILGenerator ilgenerator_0, Type type_0)
        {
            ilgenerator_0.Emit(OpCodes.Ldarg_0);
            if (type_0.smethod_12())
            {
                ilgenerator_0.Emit(OpCodes.Unbox, type_0);
            }
            else
            {
                ilgenerator_0.Emit(OpCodes.Castclass, type_0);
            }
        }

        public static void smethod_1(this ILGenerator ilgenerator_0, Type type_0)
        {
            if (type_0.smethod_12())
            {
                ilgenerator_0.Emit(OpCodes.Box, type_0);
            }
            else
            {
                ilgenerator_0.Emit(OpCodes.Castclass, type_0);
            }
        }

        public static void smethod_2(this ILGenerator ilgenerator_0, Type type_0)
        {
            if (type_0.smethod_12())
            {
                ilgenerator_0.Emit(OpCodes.Unbox_Any, type_0);
            }
            else
            {
                ilgenerator_0.Emit(OpCodes.Castclass, type_0);
            }
        }

        public static void smethod_3(this ILGenerator ilgenerator_0, MethodInfo methodInfo_0)
        {
            if (!methodInfo_0.IsFinal && methodInfo_0.IsVirtual)
            {
                ilgenerator_0.Emit(OpCodes.Callvirt, methodInfo_0);
            }
            else
            {
                ilgenerator_0.Emit(OpCodes.Call, methodInfo_0);
            }
        }

        public static void smethod_4(this ILGenerator ilgenerator_0)
        {
            ilgenerator_0.Emit(OpCodes.Ret);
        }
    }
}

