namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardBackSummon")]
    public class CardBackSummon : MonoBehaviour
    {
        public CardBackSummon(IntPtr address) : this(address, "CardBackSummon")
        {
        }

        public CardBackSummon(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateEchoTexture()
        {
            base.method_8("UpdateEchoTexture", Array.Empty<object>());
        }

        public void UpdateEffect()
        {
            base.method_8("UpdateEffect", Array.Empty<object>());
        }

        public Actor m_Actor
        {
            get
            {
                return base.method_3<Actor>("m_Actor");
            }
        }

        public CardBackManager m_CardBackManager
        {
            get
            {
                return base.method_3<CardBackManager>("m_CardBackManager");
            }
        }
    }
}

