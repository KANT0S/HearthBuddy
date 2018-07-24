namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BRM10_Razorgore")]
    public class BRM10_Razorgore : BRM_MissionEntity
    {
        public BRM10_Razorgore(IntPtr address) : this(address, "BRM10_Razorgore")
        {
        }

        public BRM10_Razorgore(IntPtr address, string className) : base(address, className)
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

        public int m_eggDeathLinePlayed
        {
            get
            {
                return base.method_2<int>("m_eggDeathLinePlayed");
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

