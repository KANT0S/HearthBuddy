namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Screen")]
    public class Screen : MonoClass
    {
        public Screen(IntPtr address) : base(address, "Screen")
        {
        }

        public static int Height
        {
            get
            {
                return MonoClass.smethod_14<int>(TritonHs.UnityEngineAssemblyPath, "UnityEngine", "Screen", "get_height", Array.Empty<object>());
            }
        }

        public static int Width
        {
            get
            {
                return MonoClass.smethod_14<int>(TritonHs.UnityEngineAssemblyPath, "UnityEngine", "Screen", "get_width", Array.Empty<object>());
            }
        }
    }
}

