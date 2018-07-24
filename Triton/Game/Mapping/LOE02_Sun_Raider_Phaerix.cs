namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LOE02_Sun_Raider_Phaerix")]
    public class LOE02_Sun_Raider_Phaerix : LOE_MissionEntity
    {
        public LOE02_Sun_Raider_Phaerix(IntPtr address) : this(address, "LOE02_Sun_Raider_Phaerix")
        {
        }

        public LOE02_Sun_Raider_Phaerix(IntPtr address, string className) : base(address, className)
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

        public bool m_damageLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_damageLinePlayed");
            }
        }

        public int m_staffLinesPlayed
        {
            get
            {
                return base.method_2<int>("m_staffLinesPlayed");
            }
        }
    }
}

