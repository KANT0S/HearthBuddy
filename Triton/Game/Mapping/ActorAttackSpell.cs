namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ActorAttackSpell")]
    public class ActorAttackSpell : Spell
    {
        public ActorAttackSpell(IntPtr address) : this(address, "ActorAttackSpell")
        {
        }

        public ActorAttackSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public void OnBirth(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnBirth", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StopWaitingToAct()
        {
            base.method_8("StopWaitingToAct", Array.Empty<object>());
        }

        public bool m_waitingToAct
        {
            get
            {
                return base.method_2<bool>("m_waitingToAct");
            }
        }
    }
}

