namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BRM12_Chromaggus")]
    public class BRM12_Chromaggus : BRM_MissionEntity
    {
        public BRM12_Chromaggus(IntPtr address) : this(address, "BRM12_Chromaggus")
        {
        }

        public BRM12_Chromaggus(IntPtr address, string className) : base(address, className)
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

        public bool m_cardLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_cardLinePlayed");
            }
        }

        public bool m_heroPowerLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_heroPowerLinePlayed");
            }
        }
    }
}

