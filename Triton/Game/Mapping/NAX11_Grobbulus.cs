namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NAX11_Grobbulus")]
    public class NAX11_Grobbulus : NAX_MissionEntity
    {
        public NAX11_Grobbulus(IntPtr address) : this(address, "NAX11_Grobbulus")
        {
        }

        public NAX11_Grobbulus(IntPtr address, string className) : base(address, className)
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

