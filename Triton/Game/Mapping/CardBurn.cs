namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardBurn")]
    public class CardBurn : Spell
    {
        public CardBurn(IntPtr address) : this(address, "CardBurn")
        {
        }

        public CardBurn(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnBirth(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnBirth", objArray1);
        }

        public string m_BurnCardAnim
        {
            get
            {
                return base.method_4("m_BurnCardAnim");
            }
        }

        public GameObject m_BurnCardQuad
        {
            get
            {
                return base.method_3<GameObject>("m_BurnCardQuad");
            }
        }
    }
}

