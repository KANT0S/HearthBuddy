namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardBurstLegendary")]
    public class CardBurstLegendary : Spell
    {
        public CardBurstLegendary(IntPtr address) : this(address, "CardBurstLegendary")
        {
        }

        public CardBurstLegendary(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnBirth(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnBirth", objArray1);
        }

        public void OnDeath(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnDeath", objArray1);
        }

        public GameObject m_EdgeGlow
        {
            get
            {
                return base.method_3<GameObject>("m_EdgeGlow");
            }
        }

        public string m_EdgeGlowBirthAnimation
        {
            get
            {
                return base.method_4("m_EdgeGlowBirthAnimation");
            }
        }

        public string m_EdgeGlowDeathAnimation
        {
            get
            {
                return base.method_4("m_EdgeGlowDeathAnimation");
            }
        }

        public GameObject m_RaysMask
        {
            get
            {
                return base.method_3<GameObject>("m_RaysMask");
            }
        }

        public GameObject m_RenderPlane
        {
            get
            {
                return base.method_3<GameObject>("m_RenderPlane");
            }
        }
    }
}

