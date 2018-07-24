namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BRM07_Omokk")]
    public class BRM07_Omokk : BRM_MissionEntity
    {
        public BRM07_Omokk(IntPtr address) : this(address, "BRM07_Omokk")
        {
        }

        public BRM07_Omokk(IntPtr address, string className) : base(address, className)
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

