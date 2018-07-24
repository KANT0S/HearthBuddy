namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BRM05_BaronGeddon")]
    public class BRM05_BaronGeddon : BRM_MissionEntity
    {
        public BRM05_BaronGeddon(IntPtr address) : this(address, "BRM05_BaronGeddon")
        {
        }

        public BRM05_BaronGeddon(IntPtr address, string className) : base(address, className)
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

