namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using System.Diagnostics;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GeneralUtils")]
    public class GeneralUtils : MonoClass
    {
        public GeneralUtils(IntPtr address) : this(address, "GeneralUtils")
        {
        }

        public GeneralUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static bool CompleteProcess(Process proc)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { proc };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "CompleteProcess", enumArray1, objArray1);
        }

        public static bool CompleteProcess(Process proc, int millisecondTimout)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { proc, millisecondTimout };
            return MonoClass.smethod_11<bool>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "CompleteProcess", enumArray1, objArray1);
        }

        public static bool Contains(string str, string val, StringComparison comparison)
        {
            object[] objArray1 = new object[] { str, val, comparison };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "Contains", objArray1);
        }

        public static void ExitApplication()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "GeneralUtils", "ExitApplication");
        }

        public static bool ForceBool(string strVal)
        {
            object[] objArray1 = new object[] { strVal };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "ForceBool", objArray1);
        }

        public static float ForceFloat(string str)
        {
            object[] objArray1 = new object[] { str };
            return MonoClass.smethod_14<float>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "ForceFloat", objArray1);
        }

        public static int ForceInt(string str)
        {
            object[] objArray1 = new object[] { str };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "ForceInt", objArray1);
        }

        public static long ForceLong(string str)
        {
            object[] objArray1 = new object[] { str };
            return MonoClass.smethod_14<long>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "ForceLong", objArray1);
        }

        public static ulong ForceULong(string str)
        {
            object[] objArray1 = new object[] { str };
            return MonoClass.smethod_14<ulong>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "ForceULong", objArray1);
        }

        public static string GetPatchDir()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "GeneralUtils", "GetPatchDir", Array.Empty<object>());
        }

        public static bool IsCallbackValid(Delegate callback)
        {
            object[] objArray1 = new object[] { callback };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "IsCallbackValid", objArray1);
        }

        public static bool IsDevelopmentBuildTextVisible()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "IsDevelopmentBuildTextVisible", Array.Empty<object>());
        }

        public static bool IsEditorPlaying()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "IsEditorPlaying", Array.Empty<object>());
        }

        public static bool IsEven(int n)
        {
            object[] objArray1 = new object[] { n };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "IsEven", objArray1);
        }

        public static bool IsObjectAlive(object obj)
        {
            object[] objArray1 = new object[] { obj };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "IsObjectAlive", objArray1);
        }

        public static bool IsOdd(int n)
        {
            object[] objArray1 = new object[] { n };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "IsOdd", objArray1);
        }

        public static bool LogCompletedProcess(Process proc)
        {
            object[] objArray1 = new object[] { proc };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "LogCompletedProcess", objArray1);
        }

        public static bool RandomBool()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "RandomBool", Array.Empty<object>());
        }

        public static float RandomSign()
        {
            return MonoClass.smethod_14<float>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "RandomSign", Array.Empty<object>());
        }

        public static int UnsignedMod(int x, int y)
        {
            object[] objArray1 = new object[] { x, y };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "UnsignedMod", objArray1);
        }

        public static float DEVELOPMENT_BUILD_TEXT_WIDTH
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "GeneralUtils", "DEVELOPMENT_BUILD_TEXT_WIDTH");
            }
        }
    }
}

