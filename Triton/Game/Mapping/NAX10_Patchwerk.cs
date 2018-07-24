namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NAX10_Patchwerk")]
    public class NAX10_Patchwerk : NAX_MissionEntity
    {
        public NAX10_Patchwerk(IntPtr address) : this(address, "NAX10_Patchwerk")
        {
        }

        public NAX10_Patchwerk(IntPtr address, string className) : base(address, className)
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

