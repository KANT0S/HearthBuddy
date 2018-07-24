namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("CardSpecificMultiVoLine")]
    public class CardSpecificMultiVoLine : MonoClass
    {
        public CardSpecificMultiVoLine(IntPtr address) : this(address, "CardSpecificMultiVoLine")
        {
        }

        public CardSpecificMultiVoLine(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_DelaySec
        {
            get
            {
                return base.method_2<float>("m_DelaySec");
            }
        }
    }
}

