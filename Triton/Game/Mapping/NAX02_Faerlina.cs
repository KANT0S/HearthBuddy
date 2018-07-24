namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NAX02_Faerlina")]
    public class NAX02_Faerlina : NAX_MissionEntity
    {
        public NAX02_Faerlina(IntPtr address) : this(address, "NAX02_Faerlina")
        {
        }

        public NAX02_Faerlina(IntPtr address, string className) : base(address, className)
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

