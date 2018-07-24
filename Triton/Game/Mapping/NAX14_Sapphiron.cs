namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NAX14_Sapphiron")]
    public class NAX14_Sapphiron : NAX_MissionEntity
    {
        public NAX14_Sapphiron(IntPtr address) : this(address, "NAX14_Sapphiron")
        {
        }

        public NAX14_Sapphiron(IntPtr address, string className) : base(address, className)
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

        public bool m_cardKtLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_cardKtLinePlayed");
            }
        }

        public int m_numTimesFrostBreathMisses
        {
            get
            {
                return base.method_2<int>("m_numTimesFrostBreathMisses");
            }
        }
    }
}

