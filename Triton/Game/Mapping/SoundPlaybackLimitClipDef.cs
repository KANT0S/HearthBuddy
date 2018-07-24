namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SoundPlaybackLimitClipDef")]
    public class SoundPlaybackLimitClipDef : MonoClass
    {
        public SoundPlaybackLimitClipDef(IntPtr address) : this(address, "SoundPlaybackLimitClipDef")
        {
        }

        public SoundPlaybackLimitClipDef(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_ExclusivePlaybackThreshold
        {
            get
            {
                return base.method_2<float>("m_ExclusivePlaybackThreshold");
            }
        }

        public string m_Path
        {
            get
            {
                return base.method_4("m_Path");
            }
        }

        public int m_Priority
        {
            get
            {
                return base.method_2<int>("m_Priority");
            }
        }
    }
}

