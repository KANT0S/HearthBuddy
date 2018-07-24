namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BRM01_GrimGuzzler")]
    public class BRM01_GrimGuzzler : BRM_MissionEntity
    {
        public BRM01_GrimGuzzler(IntPtr address) : this(address, "BRM01_GrimGuzzler")
        {
        }

        public BRM01_GrimGuzzler(IntPtr address, string className) : base(address, className)
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

        public bool m_disableSpecialCardVO
        {
            get
            {
                return base.method_2<bool>("m_disableSpecialCardVO");
            }
        }

        public bool m_eTCLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_eTCLinePlayed");
            }
        }

        public bool m_heroPowerLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_heroPowerLinePlayed");
            }
        }

        public bool m_succubusLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_succubusLinePlayed");
            }
        }

        public bool m_warGolemLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_warGolemLinePlayed");
            }
        }
    }
}

