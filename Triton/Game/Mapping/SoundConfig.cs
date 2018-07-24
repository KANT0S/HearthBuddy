namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("SoundConfig")]
    public class SoundConfig : MonoBehaviour
    {
        public SoundConfig(IntPtr address) : this(address, "SoundConfig")
        {
        }

        public SoundConfig(IntPtr address, string className) : base(address, className)
        {
        }

        public List<SoundDuckingDef> m_DuckingDefs
        {
            get
            {
                Class267<SoundDuckingDef> class2 = base.method_3<Class267<SoundDuckingDef>>("m_DuckingDefs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<SoundPlaybackLimitDef> m_PlaybackLimitDefs
        {
            get
            {
                Class267<SoundPlaybackLimitDef> class2 = base.method_3<Class267<SoundPlaybackLimitDef>>("m_PlaybackLimitDefs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_SecondsBetweenMusicTracks
        {
            get
            {
                return base.method_2<float>("m_SecondsBetweenMusicTracks");
            }
        }
    }
}

