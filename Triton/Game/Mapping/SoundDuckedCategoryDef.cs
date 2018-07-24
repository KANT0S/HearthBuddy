namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SoundDuckedCategoryDef")]
    public class SoundDuckedCategoryDef : MonoClass
    {
        public SoundDuckedCategoryDef(IntPtr address) : this(address, "SoundDuckedCategoryDef")
        {
        }

        public SoundDuckedCategoryDef(IntPtr address, string className) : base(address, className)
        {
        }

        public iTween.EaseType m_BeginEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_BeginEaseType");
            }
        }

        public float m_BeginSec
        {
            get
            {
                return base.method_2<float>("m_BeginSec");
            }
        }

        public SoundCategory m_Category
        {
            get
            {
                return base.method_2<SoundCategory>("m_Category");
            }
        }

        public iTween.EaseType m_RestoreEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_RestoreEaseType");
            }
        }

        public float m_RestoreSec
        {
            get
            {
                return base.method_2<float>("m_RestoreSec");
            }
        }

        public float m_Volume
        {
            get
            {
                return base.method_2<float>("m_Volume");
            }
        }
    }
}

