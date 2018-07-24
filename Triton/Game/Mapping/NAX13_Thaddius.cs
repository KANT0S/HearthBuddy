namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NAX13_Thaddius")]
    public class NAX13_Thaddius : NAX_MissionEntity
    {
        public NAX13_Thaddius(IntPtr address) : this(address, "NAX13_Thaddius")
        {
        }

        public NAX13_Thaddius(IntPtr address, string className) : base(address, className)
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
    }
}

