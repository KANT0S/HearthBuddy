namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NAX09_Horsemen")]
    public class NAX09_Horsemen : NAX_MissionEntity
    {
        public NAX09_Horsemen(IntPtr address) : this(address, "NAX09_Horsemen")
        {
        }

        public NAX09_Horsemen(IntPtr address, string className) : base(address, className)
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

        public bool m_introSequenceComplete
        {
            get
            {
                return base.method_2<bool>("m_introSequenceComplete");
            }
        }
    }
}

