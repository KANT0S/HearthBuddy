namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("MassDisenchantSound")]
    public class MassDisenchantSound : MonoClass
    {
        public MassDisenchantSound(IntPtr address) : this(address, "MassDisenchantSound")
        {
        }

        public MassDisenchantSound(IntPtr address, string className) : base(address, className)
        {
        }

        public RaritySound m_common
        {
            get
            {
                return base.method_3<RaritySound>("m_common");
            }
        }

        public RaritySound m_epic
        {
            get
            {
                return base.method_3<RaritySound>("m_epic");
            }
        }

        public string m_intro
        {
            get
            {
                return base.method_4("m_intro");
            }
        }

        public RaritySound m_legendary
        {
            get
            {
                return base.method_3<RaritySound>("m_legendary");
            }
        }

        public RaritySound m_rare
        {
            get
            {
                return base.method_3<RaritySound>("m_rare");
            }
        }
    }
}

