namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("BoxLightState")]
    public class BoxLightState : MonoClass
    {
        public BoxLightState(IntPtr address) : this(address, "BoxLightState")
        {
        }

        public BoxLightState(IntPtr address, string className) : base(address, className)
        {
        }

        public Color m_AmbientColor
        {
            get
            {
                return base.method_2<Color>("m_AmbientColor");
            }
        }

        public float m_DelaySec
        {
            get
            {
                return base.method_2<float>("m_DelaySec");
            }
        }

        public List<BoxLightInfo> m_LightInfos
        {
            get
            {
                Class267<BoxLightInfo> class2 = base.method_3<Class267<BoxLightInfo>>("m_LightInfos");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Spell m_Spell
        {
            get
            {
                return base.method_3<Spell>("m_Spell");
            }
        }

        public iTween.EaseType m_TransitionEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_TransitionEaseType");
            }
        }

        public float m_TransitionSec
        {
            get
            {
                return base.method_2<float>("m_TransitionSec");
            }
        }

        public BoxLightStateType m_Type
        {
            get
            {
                return base.method_2<BoxLightStateType>("m_Type");
            }
        }
    }
}

