namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("RaritySound")]
    public class RaritySound : MonoClass
    {
        public RaritySound(IntPtr address) : this(address, "RaritySound")
        {
        }

        public RaritySound(IntPtr address, string className) : base(address, className)
        {
        }

        public string m_drainSound
        {
            get
            {
                return base.method_4("m_drainSound");
            }
        }

        public string m_jarSound
        {
            get
            {
                return base.method_4("m_jarSound");
            }
        }

        public string m_missileSound
        {
            get
            {
                return base.method_4("m_missileSound");
            }
        }
    }
}

