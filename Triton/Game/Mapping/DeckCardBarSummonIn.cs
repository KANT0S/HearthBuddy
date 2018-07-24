namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeckCardBarSummonIn")]
    public class DeckCardBarSummonIn : SpellImpl
    {
        public DeckCardBarSummonIn(IntPtr address) : this(address, "DeckCardBarSummonIn")
        {
        }

        public DeckCardBarSummonIn(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnBirth(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnBirth", objArray1);
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public GameObject m_echoQuad
        {
            get
            {
                return base.method_3<GameObject>("m_echoQuad");
            }
        }

        public GameObject m_fxEvaporate
        {
            get
            {
                return base.method_3<GameObject>("m_fxEvaporate");
            }
        }
    }
}

