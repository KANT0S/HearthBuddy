namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Tags")]
    public class Tags : MonoClass
    {
        public Tags(IntPtr address) : this(address, "Tags")
        {
        }

        public Tags(IntPtr address, string className) : base(address, className)
        {
        }

        public static string DebugTag(int tag, int val)
        {
            object[] objArray1 = new object[] { tag, val };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "Tags", "DebugTag", objArray1);
        }

        public static int MAX
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Tags", "MAX");
            }
        }
    }
}

