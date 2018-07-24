namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ParticleSystemSizes")]
    public class ParticleSystemSizes : MonoClass
    {
        public ParticleSystemSizes(IntPtr address) : this(address, "ParticleSystemSizes")
        {
        }

        public ParticleSystemSizes(IntPtr address, string className) : base(address, className)
        {
        }

        public float gravityModifier
        {
            get
            {
                return base.method_2<float>("gravityModifier");
            }
        }

        public float startSize
        {
            get
            {
                return base.method_2<float>("startSize");
            }
        }

        public float startSpeed
        {
            get
            {
                return base.method_2<float>("startSpeed");
            }
        }
    }
}

