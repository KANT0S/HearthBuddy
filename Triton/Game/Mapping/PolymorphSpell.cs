namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PolymorphSpell")]
    public class PolymorphSpell : SuperSpell
    {
        public PolymorphSpell(IntPtr address) : this(address, "PolymorphSpell")
        {
        }

        public PolymorphSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public Card FindNewCard()
        {
            return base.method_14<Card>("FindNewCard", Array.Empty<object>());
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public bool m_SuppressNewCardPlaySound
        {
            get
            {
                return base.method_2<bool>("m_SuppressNewCardPlaySound");
            }
        }
    }
}

