namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("PearlOfTidesSpell")]
    public class PearlOfTidesSpell : SuperSpell
    {
        public PearlOfTidesSpell(IntPtr address) : this(address, "PearlOfTidesSpell")
        {
        }

        public PearlOfTidesSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }
    }
}

