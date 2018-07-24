namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ParticleEffectsRepulser")]
    public class ParticleEffectsRepulser : MonoClass
    {
        public ParticleEffectsRepulser(IntPtr address) : this(address, "ParticleEffectsRepulser")
        {
        }

        public ParticleEffectsRepulser(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_Power
        {
            get
            {
                return base.method_2<float>("m_Power");
            }
        }

        public float m_Radius
        {
            get
            {
                return base.method_2<float>("m_Radius");
            }
        }

        public Transform m_Transform
        {
            get
            {
                return base.method_3<Transform>("m_Transform");
            }
        }
    }
}

