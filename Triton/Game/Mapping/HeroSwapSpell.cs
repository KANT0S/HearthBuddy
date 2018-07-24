namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("HeroSwapSpell")]
    public class HeroSwapSpell : Spell
    {
        public HeroSwapSpell(IntPtr address) : this(address, "HeroSwapSpell")
        {
        }

        public HeroSwapSpell(IntPtr address, string className) : base(address, className)
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

        public PowerTask FindFullEntityTask()
        {
            return base.method_14<PowerTask>("FindFullEntityTask", Array.Empty<object>());
        }

        public void Finish()
        {
            base.method_8("Finish", Array.Empty<object>());
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public float m_FinishDelay
        {
            get
            {
                return base.method_2<float>("m_FinishDelay");
            }
        }

        public Card m_newHeroCard
        {
            get
            {
                return base.method_3<Card>("m_newHeroCard");
            }
        }

        public Spell m_NewHeroFX
        {
            get
            {
                return base.method_3<Spell>("m_NewHeroFX");
            }
        }

        public Card m_oldHeroCard
        {
            get
            {
                return base.method_3<Card>("m_oldHeroCard");
            }
        }

        public Spell m_OldHeroFX
        {
            get
            {
                return base.method_3<Spell>("m_OldHeroFX");
            }
        }

        public bool removeOldStats
        {
            get
            {
                return base.method_2<bool>("removeOldStats");
            }
        }
    }
}

