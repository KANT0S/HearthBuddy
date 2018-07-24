namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("PackConstants")]
    public class PackConstants : MonoClass
    {
        public PackConstants(IntPtr address) : this(address, "PackConstants")
        {
        }

        public PackConstants(IntPtr address, string className) : base(address, className)
        {
        }

        public static int CARDS_PER_PACK
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "PackConstants", "CARDS_PER_PACK");
            }
        }
    }
}

