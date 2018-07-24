namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CustomEditTypeUtils")]
    public class CustomEditTypeUtils : MonoClass
    {
        public CustomEditTypeUtils(IntPtr address) : this(address, "CustomEditTypeUtils")
        {
        }

        public CustomEditTypeUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static string GetExtension(EditType type)
        {
            object[] objArray1 = new object[] { type };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "CustomEditTypeUtils", "GetExtension", objArray1);
        }
    }
}

