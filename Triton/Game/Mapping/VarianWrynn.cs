namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("VarianWrynn")]
    public class VarianWrynn : SuperSpell
    {
        public VarianWrynn(IntPtr address) : this(address, "VarianWrynn")
        {
        }

        public VarianWrynn(IntPtr address, string className) : base(address, className)
        {
        }

        public bool IsMinion(Network.HistShowEntity showEntity)
        {
            object[] objArray1 = new object[] { showEntity };
            return base.method_11<bool>("IsMinion", objArray1);
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public Spell m_deckSpellPrefab
        {
            get
            {
                return base.method_3<Spell>("m_deckSpellPrefab");
            }
        }

        public string m_perMinionSound
        {
            get
            {
                return base.method_4("m_perMinionSound");
            }
        }

        public float m_spellLeadTime
        {
            get
            {
                return base.method_2<float>("m_spellLeadTime");
            }
        }

        public Spell m_varianSpellPrefab
        {
            get
            {
                return base.method_3<Spell>("m_varianSpellPrefab");
            }
        }
    }
}

