namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("KelThuzad_StealTurn")]
    public class KelThuzad_StealTurn : Spell
    {
        public KelThuzad_StealTurn(IntPtr address) : this(address, "KelThuzad_StealTurn")
        {
        }

        public KelThuzad_StealTurn(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public GameObject m_Lightning
        {
            get
            {
                return base.method_3<GameObject>("m_Lightning");
            }
        }
    }
}

