namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LOE01_Zinaar")]
    public class LOE01_Zinaar : LOE_MissionEntity
    {
        public LOE01_Zinaar(IntPtr address) : this(address, "LOE01_Zinaar")
        {
        }

        public LOE01_Zinaar(IntPtr address, string className) : base(address, className)
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

        public bool m_wishMoreWishesLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_wishMoreWishesLinePlayed");
            }
        }
    }
}

