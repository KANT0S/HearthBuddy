namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("SpellAreaEffect")]
    public class SpellAreaEffect : Spell
    {
        public SpellAreaEffect(IntPtr address) : this(address, "SpellAreaEffect")
        {
        }

        public SpellAreaEffect(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddPowerTargets()
        {
            return base.method_11<bool>("AddPowerTargets", Array.Empty<object>());
        }

        public void OnDeath(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnDeath", objArray1);
        }

        public void OnImpactSpellStateFinished(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnImpactSpellStateFinished", objArray1);
        }

        public void SpawnImpactSpell(GameObject targetObject)
        {
            object[] objArray1 = new object[] { targetObject };
            base.method_8("SpawnImpactSpell", objArray1);
        }

        public Spell m_ImpactSpellPrefab
        {
            get
            {
                return base.method_3<Spell>("m_ImpactSpellPrefab");
            }
        }
    }
}

