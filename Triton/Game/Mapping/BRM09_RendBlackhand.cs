namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BRM09_RendBlackhand")]
    public class BRM09_RendBlackhand : BRM_MissionEntity
    {
        public BRM09_RendBlackhand(IntPtr address) : this(address, "BRM09_RendBlackhand")
        {
        }

        public BRM09_RendBlackhand(IntPtr address, string className) : base(address, className)
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

        public bool m_heroPower1LinePlayed
        {
            get
            {
                return base.method_2<bool>("m_heroPower1LinePlayed");
            }
        }

        public bool m_heroPower2LinePlayed
        {
            get
            {
                return base.method_2<bool>("m_heroPower2LinePlayed");
            }
        }

        public bool m_heroPower3LinePlayed
        {
            get
            {
                return base.method_2<bool>("m_heroPower3LinePlayed");
            }
        }

        public bool m_heroPower4LinePlayed
        {
            get
            {
                return base.method_2<bool>("m_heroPower4LinePlayed");
            }
        }
    }
}

