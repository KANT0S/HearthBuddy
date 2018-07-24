namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SaleBanner")]
    public class SaleBanner : MonoClass
    {
        public SaleBanner(IntPtr address) : this(address, "SaleBanner")
        {
        }

        public SaleBanner(IntPtr address, string className) : base(address, className)
        {
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }

        public UberText m_saleText
        {
            get
            {
                return base.method_3<UberText>("m_saleText");
            }
        }
    }
}

