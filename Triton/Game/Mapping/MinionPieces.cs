namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("MinionPieces")]
    public class MinionPieces : MonoClass
    {
        public MinionPieces(IntPtr address) : this(address, "MinionPieces")
        {
        }

        public MinionPieces(IntPtr address, string className) : base(address, className)
        {
        }

        public GameObject m_legendary
        {
            get
            {
                return base.method_3<GameObject>("m_legendary");
            }
        }

        public GameObject m_main
        {
            get
            {
                return base.method_3<GameObject>("m_main");
            }
        }

        public GameObject m_premium
        {
            get
            {
                return base.method_3<GameObject>("m_premium");
            }
        }

        public GameObject m_taunt
        {
            get
            {
                return base.method_3<GameObject>("m_taunt");
            }
        }
    }
}

