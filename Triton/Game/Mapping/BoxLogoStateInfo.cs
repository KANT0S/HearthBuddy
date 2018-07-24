namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("BoxLogoStateInfo")]
    public class BoxLogoStateInfo : MonoClass
    {
        public BoxLogoStateInfo(IntPtr address) : this(address, "BoxLogoStateInfo")
        {
        }

        public BoxLogoStateInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_HiddenAlpha
        {
            get
            {
                return base.method_2<float>("m_HiddenAlpha");
            }
        }

        public float m_HiddenDelaySec
        {
            get
            {
                return base.method_2<float>("m_HiddenDelaySec");
            }
        }

        public iTween.EaseType m_HiddenFadeEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_HiddenFadeEaseType");
            }
        }

        public float m_HiddenFadeSec
        {
            get
            {
                return base.method_2<float>("m_HiddenFadeSec");
            }
        }

        public float m_ShownAlpha
        {
            get
            {
                return base.method_2<float>("m_ShownAlpha");
            }
        }

        public float m_ShownDelaySec
        {
            get
            {
                return base.method_2<float>("m_ShownDelaySec");
            }
        }

        public iTween.EaseType m_ShownFadeEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_ShownFadeEaseType");
            }
        }

        public float m_ShownFadeSec
        {
            get
            {
                return base.method_2<float>("m_ShownFadeSec");
            }
        }
    }
}

