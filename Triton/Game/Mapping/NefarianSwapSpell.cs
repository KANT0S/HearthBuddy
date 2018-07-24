namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("NefarianSwapSpell")]
    public class NefarianSwapSpell : HeroSwapSpell
    {
        public NefarianSwapSpell(IntPtr address) : this(address, "NefarianSwapSpell")
        {
        }

        public NefarianSwapSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddPowerTargets()
        {
            return base.method_11<bool>("AddPowerTargets", Array.Empty<object>());
        }

        public void CustomizeFXProcess(Actor heroActor)
        {
            object[] objArray1 = new object[] { heroActor };
            base.method_8("CustomizeFXProcess", objArray1);
        }

        public Card m_obsoleteHeroCard
        {
            get
            {
                return base.method_3<Card>("m_obsoleteHeroCard");
            }
        }

        public float m_obsoleteRemovalDelay
        {
            get
            {
                return base.method_2<float>("m_obsoleteRemovalDelay");
            }
        }
    }
}

