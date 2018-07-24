namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NAX7_05_Spell")]
    public class NAX7_05_Spell : Spell
    {
        public NAX7_05_Spell(IntPtr address) : this(address, "NAX7_05_Spell")
        {
        }

        public NAX7_05_Spell(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnBirth(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnBirth", objArray1);
        }
    }
}

