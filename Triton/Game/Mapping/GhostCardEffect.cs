namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GhostCardEffect")]
    public class GhostCardEffect : Spell
    {
        public GhostCardEffect(IntPtr address) : this(address, "GhostCardEffect")
        {
        }

        public GhostCardEffect(IntPtr address, string className) : base(address, className)
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

        public GameObject m_Glow
        {
            get
            {
                return base.method_3<GameObject>("m_Glow");
            }
        }

        public GameObject m_GlowUnique
        {
            get
            {
                return base.method_3<GameObject>("m_GlowUnique");
            }
        }
    }
}

