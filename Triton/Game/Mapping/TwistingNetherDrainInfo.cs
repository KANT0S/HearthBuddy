namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("TwistingNetherDrainInfo")]
    public class TwistingNetherDrainInfo : MonoClass
    {
        public TwistingNetherDrainInfo(IntPtr address) : this(address, "TwistingNetherDrainInfo")
        {
        }

        public TwistingNetherDrainInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_DelayMax
        {
            get
            {
                return base.method_2<float>("m_DelayMax");
            }
        }

        public float m_DelayMin
        {
            get
            {
                return base.method_2<float>("m_DelayMin");
            }
        }

        public float m_DurationMax
        {
            get
            {
                return base.method_2<float>("m_DurationMax");
            }
        }

        public float m_DurationMin
        {
            get
            {
                return base.method_2<float>("m_DurationMin");
            }
        }

        public iTween.EaseType m_EaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_EaseType");
            }
        }
    }
}

