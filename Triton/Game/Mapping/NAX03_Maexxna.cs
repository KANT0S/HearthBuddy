namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NAX03_Maexxna")]
    public class NAX03_Maexxna : NAX_MissionEntity
    {
        public NAX03_Maexxna(IntPtr address) : this(address, "NAX03_Maexxna")
        {
        }

        public NAX03_Maexxna(IntPtr address, string className) : base(address, className)
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

        public bool m_heroPowerLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_heroPowerLinePlayed");
            }
        }

        public bool m_seaGiantLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_seaGiantLinePlayed");
            }
        }
    }
}

