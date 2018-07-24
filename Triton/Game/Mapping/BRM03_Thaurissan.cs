namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BRM03_Thaurissan")]
    public class BRM03_Thaurissan : BRM_MissionEntity
    {
        public BRM03_Thaurissan(IntPtr address) : this(address, "BRM03_Thaurissan")
        {
        }

        public BRM03_Thaurissan(IntPtr address, string className) : base(address, className)
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

        public bool m_moiraDead
        {
            get
            {
                return base.method_2<bool>("m_moiraDead");
            }
        }
    }
}

