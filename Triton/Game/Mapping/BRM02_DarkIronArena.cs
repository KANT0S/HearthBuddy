namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BRM02_DarkIronArena")]
    public class BRM02_DarkIronArena : BRM_MissionEntity
    {
        public BRM02_DarkIronArena(IntPtr address) : this(address, "BRM02_DarkIronArena")
        {
        }

        public BRM02_DarkIronArena(IntPtr address, string className) : base(address, className)
        {
        }

        public void InitEmoteResponses()
        {
            base.method_8("InitEmoteResponses", Array.Empty<object>());
        }

        public void PreloadAssets()
        {
            base.method_8("PreloadAssets", Array.Empty<object>());
        }

        public static float PLAY_CARD_DELAY
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "BRM02_DarkIronArena", "PLAY_CARD_DELAY");
            }
        }
    }
}

