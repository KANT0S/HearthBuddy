namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BRM16_Atramedes")]
    public class BRM16_Atramedes : BRM_MissionEntity
    {
        public BRM16_Atramedes(IntPtr address) : this(address, "BRM16_Atramedes")
        {
        }

        public BRM16_Atramedes(IntPtr address, string className) : base(address, className)
        {
        }

        public string GetAlternatePlayerName()
        {
            return base.method_13("GetAlternatePlayerName", Array.Empty<object>());
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

        public int m_gongLinePlayed
        {
            get
            {
                return base.method_2<int>("m_gongLinePlayed");
            }
        }

        public bool m_heroPowerLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_heroPowerLinePlayed");
            }
        }

        public int m_weaponLinePlayed
        {
            get
            {
                return base.method_2<int>("m_weaponLinePlayed");
            }
        }
    }
}

