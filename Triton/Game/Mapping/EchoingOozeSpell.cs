namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("EchoingOozeSpell")]
    public class EchoingOozeSpell : Spell
    {
        public EchoingOozeSpell(IntPtr address) : this(address, "EchoingOozeSpell")
        {
        }

        public EchoingOozeSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public void DoEffect(Card targetCard)
        {
            object[] objArray1 = new object[] { targetCard };
            base.method_8("DoEffect", objArray1);
        }

        public void DoTasksUntilSpawn(Card targetCard)
        {
            object[] objArray1 = new object[] { targetCard };
            base.method_8("DoTasksUntilSpawn", objArray1);
        }

        public Card GetTargetCardFromPowerTask(int index, PowerTask task)
        {
            object[] objArray1 = new object[] { index, task };
            return base.method_14<Card>("GetTargetCardFromPowerTask", objArray1);
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

        public float m_PostSpawnDelayMax
        {
            get
            {
                return base.method_2<float>("m_PostSpawnDelayMax");
            }
        }

        public float m_PostSpawnDelayMin
        {
            get
            {
                return base.method_2<float>("m_PostSpawnDelayMin");
            }
        }
    }
}

