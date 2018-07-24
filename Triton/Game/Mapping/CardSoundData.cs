namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("CardSoundData")]
    public class CardSoundData : MonoClass
    {
        public CardSoundData(IntPtr address) : this(address, "CardSoundData")
        {
        }

        public CardSoundData(IntPtr address, string className) : base(address, className)
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

