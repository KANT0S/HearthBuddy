namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NAX12_Gluth")]
    public class NAX12_Gluth : NAX_MissionEntity
    {
        public NAX12_Gluth(IntPtr address) : this(address, "NAX12_Gluth")
        {
        }

        public NAX12_Gluth(IntPtr address, string className) : base(address, className)
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

        public bool m_achievementTauntPlayed
        {
            get
            {
                return base.method_2<bool>("m_achievementTauntPlayed");
            }
        }

        public bool m_cardLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_cardLinePlayed");
            }
        }

        public int m_heroPowerLinePlayed
        {
            get
            {
                return base.method_2<int>("m_heroPowerLinePlayed");
            }
        }
    }
}

