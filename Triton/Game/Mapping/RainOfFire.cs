namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RainOfFire")]
    public class RainOfFire : SuperSpell
    {
        public RainOfFire(IntPtr address) : this(address, "RainOfFire")
        {
        }

        public RainOfFire(IntPtr address, string className) : base(address, className)
        {
        }

        public int NumberOfCardsInOpponentsHand()
        {
            return base.method_11<int>("NumberOfCardsInOpponentsHand", Array.Empty<object>());
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public void UpdateVisualTargets()
        {
            base.method_8("UpdateVisualTargets", Array.Empty<object>());
        }
    }
}

