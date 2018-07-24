namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NAX01_AnubRekhan")]
    public class NAX01_AnubRekhan : NAX_MissionEntity
    {
        public NAX01_AnubRekhan(IntPtr address) : this(address, "NAX01_AnubRekhan")
        {
        }

        public NAX01_AnubRekhan(IntPtr address, string className) : base(address, className)
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

        public bool m_locustSwarmLinePlayed
        {
            get
            {
                return base.method_2<bool>("m_locustSwarmLinePlayed");
            }
        }
    }
}

