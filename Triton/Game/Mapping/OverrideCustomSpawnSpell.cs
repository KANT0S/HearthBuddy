namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("OverrideCustomSpawnSpell")]
    public class OverrideCustomSpawnSpell : SuperSpell
    {
        public OverrideCustomSpawnSpell(IntPtr address) : this(address, "OverrideCustomSpawnSpell")
        {
        }

        public OverrideCustomSpawnSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public Spell m_CustomSpawnSpell
        {
            get
            {
                return base.method_3<Spell>("m_CustomSpawnSpell");
            }
        }

        public bool m_SuppressPlaySounds
        {
            get
            {
                return base.method_2<bool>("m_SuppressPlaySounds");
            }
        }
    }
}

