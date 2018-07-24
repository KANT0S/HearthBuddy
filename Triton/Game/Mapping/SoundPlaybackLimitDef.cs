namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("SoundPlaybackLimitDef")]
    public class SoundPlaybackLimitDef : MonoClass
    {
        public SoundPlaybackLimitDef(IntPtr address) : this(address, "SoundPlaybackLimitDef")
        {
        }

        public SoundPlaybackLimitDef(IntPtr address, string className) : base(address, className)
        {
        }

        public List<SoundPlaybackLimitClipDef> m_ClipDefs
        {
            get
            {
                Class267<SoundPlaybackLimitClipDef> class2 = base.method_3<Class267<SoundPlaybackLimitClipDef>>("m_ClipDefs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_Limit
        {
            get
            {
                return base.method_2<int>("m_Limit");
            }
        }
    }
}

