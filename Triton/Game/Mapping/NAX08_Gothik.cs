namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NAX08_Gothik")]
    public class NAX08_Gothik : NAX_MissionEntity
    {
        public NAX08_Gothik(IntPtr address) : this(address, "NAX08_Gothik")
        {
        }

        public NAX08_Gothik(IntPtr address, string className) : base(address, className)
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

        public bool m_deadReturnLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_deadReturnLinePlayed");
            }
        }

        public bool m_unrelentingMinionLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_unrelentingMinionLinePlayed");
            }
        }
    }
}

