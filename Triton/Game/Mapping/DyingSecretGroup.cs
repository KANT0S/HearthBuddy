namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("DyingSecretGroup")]
    public class DyingSecretGroup : MonoClass
    {
        public DyingSecretGroup(IntPtr address) : this(address, "DyingSecretGroup")
        {
        }

        public DyingSecretGroup(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("AddCard", objArray1);
        }

        public List<Actor> GetActors()
        {
            Class267<Actor> class2 = base.method_14<Class267<Actor>>("GetActors", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
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

        public List<Actor> m_actors
        {
            get
            {
                Class267<Actor> class2 = base.method_3<Class267<Actor>>("m_actors");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
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

