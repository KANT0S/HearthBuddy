namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("SoundDef")]
    public class SoundDef : MonoBehaviour
    {
        public SoundDef(IntPtr address) : this(address, "SoundDef")
        {
        }

        public SoundDef(IntPtr address, string className) : base(address, className)
        {
        }

        public SoundCategory m_Category
        {
            get
            {
                return base.method_2<SoundCategory>("m_Category");
            }
        }

        public bool m_IgnoreDucking
        {
            get
            {
                return base.method_2<bool>("m_IgnoreDucking");
            }
        }

        public List<RandomAudioClip> m_RandomClips
        {
            get
            {
                Class267<RandomAudioClip> class2 = base.method_3<Class267<RandomAudioClip>>("m_RandomClips");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_RandomPitchMax
        {
            get
            {
                return base.method_2<float>("m_RandomPitchMax");
            }
        }

        public float m_RandomPitchMin
        {
            get
            {
                return base.method_2<float>("m_RandomPitchMin");
            }
        }

        public float m_RandomVolumeMax
        {
            get
            {
                return base.method_2<float>("m_RandomVolumeMax");
            }
        }

        public float m_RandomVolumeMin
        {
            get
            {
                return base.method_2<float>("m_RandomVolumeMin");
            }
        }
    }
}

