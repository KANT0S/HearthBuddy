namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DebugUtils")]
    public class DebugUtils : MonoClass
    {
        public DebugUtils(IntPtr address) : this(address, "DebugUtils")
        {
        }

        public DebugUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static void Assert(bool test)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { test };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "DebugUtils", "Assert", enumArray1, objArray1);
        }

        public static void Assert(bool test, string message)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean, Class272.Enum20.String };
            object[] objArray1 = new object[] { test, message };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "DebugUtils", "Assert", enumArray1, objArray1);
        }

        public static int CountParents(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "DebugUtils", "CountParents", objArray1);
        }

        public static string GetHierarchyPath(object obj)
        {
            object[] objArray1 = new object[] { obj };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "DebugUtils", "GetHierarchyPath", objArray1);
        }

        public static string GetHierarchyPathAndType(object obj)
        {
            object[] objArray1 = new object[] { obj };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "DebugUtils", "GetHierarchyPathAndType", objArray1);
        }
    }
}

