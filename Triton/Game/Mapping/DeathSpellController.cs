namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeathSpellController")]
    public class DeathSpellController : SpellController
    {
        public DeathSpellController(IntPtr address) : this(address, "DeathSpellController")
        {
        }

        public DeathSpellController(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddDeadCardsToTargetList(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            base.method_8("AddDeadCardsToTargetList", objArray1);
        }

        public bool AddPowerSourceAndTargets(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("AddPowerSourceAndTargets", objArray1);
        }

        public bool CanAddTarget(Triton.Game.Mapping.Entity entity, Card card)
        {
            object[] objArray1 = new object[] { entity, card };
            return base.method_11<bool>("CanAddTarget", objArray1);
        }

        public bool CanPlayDeathSound(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("CanPlayDeathSound", objArray1);
        }

        public void OnProcessTaskList()
        {
            base.method_8("OnProcessTaskList", Array.Empty<object>());
        }

        public int PickDeathSoundCardIndex()
        {
            return base.method_11<int>("PickDeathSoundCardIndex", Array.Empty<object>());
        }

        public int PickRandomDeathSoundCardIndex()
        {
            return base.method_11<int>("PickRandomDeathSoundCardIndex", Array.Empty<object>());
        }

        public bool WasAttackedBy(Triton.Game.Mapping.Entity defender, Triton.Game.Mapping.Entity attacker)
        {
            object[] objArray1 = new object[] { defender, attacker };
            return base.method_11<bool>("WasAttackedBy", objArray1);
        }
    }
}

