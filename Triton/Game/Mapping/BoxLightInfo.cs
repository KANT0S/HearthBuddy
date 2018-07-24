namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("BoxLightInfo")]
    public class BoxLightInfo : MonoClass
    {
        public BoxLightInfo(IntPtr address) : this(address, "BoxLightInfo")
        {
        }

        public BoxLightInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public Color m_Color
        {
            get
            {
                return base.method_2<Color>("m_Color");
            }
        }

        public float m_Intensity
        {
            get
            {
                return base.method_2<float>("m_Intensity");
            }
        }

        public float m_Range
        {
            get
            {
                return base.method_2<float>("m_Range");
            }
        }

        public float m_SpotAngle
        {
            get
            {
                return base.method_2<float>("m_SpotAngle");
            }
        }
    }
}

