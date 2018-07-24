namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeathrattleSummonSpell")]
    public class DeathrattleSummonSpell : Spell
    {
        public DeathrattleSummonSpell(IntPtr address) : this(address, "DeathrattleSummonSpell")
        {
        }

        public DeathrattleSummonSpell(IntPtr address, string className) : base(address, className)
        {
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
    }
}

