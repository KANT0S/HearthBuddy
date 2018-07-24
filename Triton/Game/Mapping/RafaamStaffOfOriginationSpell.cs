namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RafaamStaffOfOriginationSpell")]
    public class RafaamStaffOfOriginationSpell : Spell
    {
        public RafaamStaffOfOriginationSpell(IntPtr address) : this(address, "RafaamStaffOfOriginationSpell")
        {
        }

        public RafaamStaffOfOriginationSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddPowerTargets()
        {
            return base.method_11<bool>("AddPowerTargets", Array.Empty<object>());
        }

        public void ApplyCustomSpawnOverride()
        {
            base.method_8("ApplyCustomSpawnOverride", Array.Empty<object>());
        }

        public void DoTasksUntilSpawn()
        {
            base.method_8("DoTasksUntilSpawn", Array.Empty<object>());
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

        public int m_spawnTaskIndex
        {
            get
            {
                return base.method_2<int>("m_spawnTaskIndex");
            }
        }
    }
}

