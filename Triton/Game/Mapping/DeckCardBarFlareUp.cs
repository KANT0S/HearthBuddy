namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeckCardBarFlareUp")]
    public class DeckCardBarFlareUp : SpellImpl
    {
        public DeckCardBarFlareUp(IntPtr address) : this(address, "DeckCardBarFlareUp")
        {
        }

        public DeckCardBarFlareUp(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnBirth(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnBirth", objArray1);
        }

        public GameObject m_fuseQuad
        {
            get
            {
                return base.method_3<GameObject>("m_fuseQuad");
            }
        }

        public GameObject m_fxSparks
        {
            get
            {
                return base.method_3<GameObject>("m_fxSparks");
            }
        }
    }
}

