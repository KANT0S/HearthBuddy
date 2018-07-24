namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("BoxSpinnerStateInfo")]
    public class BoxSpinnerStateInfo : MonoClass
    {
        public BoxSpinnerStateInfo(IntPtr address) : this(address, "BoxSpinnerStateInfo")
        {
        }

        public BoxSpinnerStateInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_DegreesPerSec
        {
            get
            {
                return base.method_2<float>("m_DegreesPerSec");
            }
        }
    }
}

