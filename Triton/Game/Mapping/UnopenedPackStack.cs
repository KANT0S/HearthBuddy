namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("UnopenedPackStack")]
    public class UnopenedPackStack : MonoClass
    {
        public UnopenedPackStack(IntPtr address) : this(address, "UnopenedPackStack")
        {
        }

        public UnopenedPackStack(IntPtr address, string className) : base(address, className)
        {
        }

        public UberText m_AmountText
        {
            get
            {
                return base.method_3<UberText>("m_AmountText");
            }
        }

        public GameObject m_RootObject
        {
            get
            {
                return base.method_3<GameObject>("m_RootObject");
            }
        }
    }
}

