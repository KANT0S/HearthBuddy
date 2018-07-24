namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("MemUtils")]
    public class MemUtils : MonoClass
    {
        public MemUtils(IntPtr address) : this(address, "MemUtils")
        {
        }

        public MemUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static void FreePtr(IntPtr ptr)
        {
            object[] objArray1 = new object[] { ptr };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "MemUtils", "FreePtr", objArray1);
        }

        public static List<byte> PtrToBytes(IntPtr ptr, int size)
        {
            object[] objArray1 = new object[] { ptr, size };
            Class246<byte> class2 = MonoClass.smethod_15<Class246<byte>>(TritonHs.MainAssemblyPath, "", "MemUtils", "PtrToBytes", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static string StringFromUtf8Ptr(IntPtr ptr)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { ptr };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "MemUtils", "StringFromUtf8Ptr", enumArray1, objArray1);
        }

        public static int StringPtrByteLen(IntPtr ptr)
        {
            object[] objArray1 = new object[] { ptr };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "MemUtils", "StringPtrByteLen", objArray1);
        }

        public static IntPtr Utf8PtrFromString(string managedString)
        {
            object[] objArray1 = new object[] { managedString };
            return MonoClass.smethod_14<IntPtr>(TritonHs.MainAssemblyPath, "", "MemUtils", "Utf8PtrFromString", objArray1);
        }
    }
}

