namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardBurstCommon")]
    public class CardBurstCommon : Spell
    {
        public CardBurstCommon(IntPtr address) : this(address, "CardBurstCommon")
        {
        }

        public CardBurstCommon(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnBirth(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnBirth", objArray1);
        }

        public GameObject m_EdgeGlow
        {
            get
            {
                return base.method_3<GameObject>("m_EdgeGlow");
            }
        }
    }
}

