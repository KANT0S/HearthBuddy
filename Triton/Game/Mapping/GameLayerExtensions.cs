namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GameLayerExtensions")]
    public class GameLayerExtensions : MonoClass
    {
        public GameLayerExtensions(IntPtr address) : this(address, "GameLayerExtensions")
        {
        }

        public GameLayerExtensions(IntPtr address, string className) : base(address, className)
        {
        }

        public static int LayerBit(GameLayer gameLayer)
        {
            object[] objArray1 = new object[] { gameLayer };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "GameLayerExtensions", "LayerBit", objArray1);
        }
    }
}

