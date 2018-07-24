namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("OverrideCustomDeathSpell")]
    public class OverrideCustomDeathSpell : SuperSpell
    {
        public OverrideCustomDeathSpell(IntPtr address) : this(address, "OverrideCustomDeathSpell")
        {
        }

        public OverrideCustomDeathSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public Spell m_CustomDeathSpell
        {
            get
            {
                return base.method_3<Spell>("m_CustomDeathSpell");
            }
        }

        public bool m_SuppressKeywordDeaths
        {
            get
            {
                return base.method_2<bool>("m_SuppressKeywordDeaths");
            }
        }
    }
}

