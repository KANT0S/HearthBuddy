namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardBackDeckDisplay")]
    public class CardBackDeckDisplay : MonoBehaviour
    {
        public CardBackDeckDisplay(IntPtr address) : this(address, "CardBackDeckDisplay")
        {
        }

        public CardBackDeckDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateDeckCardBacks()
        {
            base.method_8("UpdateDeckCardBacks", Array.Empty<object>());
        }

        public CardBackManager m_CardBackManager
        {
            get
            {
                return base.method_3<CardBackManager>("m_CardBackManager");
            }
        }

        public bool m_FriendlyDeck
        {
            get
            {
                return base.method_2<bool>("m_FriendlyDeck");
            }
        }
    }
}

