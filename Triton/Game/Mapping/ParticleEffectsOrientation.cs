namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ParticleEffectsOrientation")]
    public class ParticleEffectsOrientation : MonoClass
    {
        public ParticleEffectsOrientation(IntPtr address) : this(address, "ParticleEffectsOrientation")
        {
        }

        public ParticleEffectsOrientation(IntPtr address, string className) : base(address, className)
        {
        }

        public bool m_OrientToDirection
        {
            get
            {
                return base.method_2<bool>("m_OrientToDirection");
            }
        }

        public ParticleEffectsOrientUpVectors m_UpVector
        {
            get
            {
                return base.method_2<ParticleEffectsOrientUpVectors>("m_UpVector");
            }
        }
    }
}

