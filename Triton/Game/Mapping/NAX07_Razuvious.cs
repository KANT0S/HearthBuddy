namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NAX07_Razuvious")]
    public class NAX07_Razuvious : NAX_MissionEntity
    {
        public NAX07_Razuvious(IntPtr address) : this(address, "NAX07_Razuvious")
        {
        }

        public NAX07_Razuvious(IntPtr address, string className) : base(address, className)
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

