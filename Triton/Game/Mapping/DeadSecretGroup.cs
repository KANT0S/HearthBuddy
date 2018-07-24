namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("DeadSecretGroup")]
    public class DeadSecretGroup : MonoClass
    {
        public DeadSecretGroup(IntPtr address) : this(address, "DeadSecretGroup")
        {
        }

        public DeadSecretGroup(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("AddCard", objArray1);
        }

        public List<Card> GetCards()
        {
            Class267<Card> class2 = base.method_14<Class267<Card>>("GetCards", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public Card GetMainCard()
        {
            return base.method_14<Card>("GetMainCard", Array.Empty<object>());
        }

        public void SetMainCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("SetMainCard", objArray1);
        }

        public List<Card> m_cards
        {
            get
            {
                Class267<Card> class2 = base.method_3<Class267<Card>>("m_cards");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Card m_mainCard
        {
            get
            {
                return base.method_3<Card>("m_mainCard");
            }
        }
    }
}

