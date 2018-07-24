namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("StringUtils")]
    public class StringUtils : MonoClass
    {
        public StringUtils(IntPtr address) : this(address, "StringUtils")
        {
        }

        public StringUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static bool CompareIgnoreCase(string a, string b)
        {
            object[] objArray1 = new object[] { a, b };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "StringUtils", "CompareIgnoreCase", objArray1);
        }

        public static List<string> SplitLines(string str)
        {
            object[] objArray1 = new object[] { str };
            Class245 class2 = MonoClass.smethod_15<Class245>(TritonHs.MainAssemblyPath, "", "StringUtils", "SplitLines", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static string StripNewlines(string str)
        {
            object[] objArray1 = new object[] { str };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "StringUtils", "StripNewlines", objArray1);
        }

        public static string StripNonNumbers(string str)
        {
            object[] objArray1 = new object[] { str };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "StringUtils", "StripNonNumbers", objArray1);
        }

        public static List<string> SPLIT_LINES_CHARS
        {
            get
            {
                Class245 class2 = MonoClass.smethod_7<Class245>(TritonHs.MainAssemblyPath, "", "StringUtils", "SPLIT_LINES_CHARS");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

