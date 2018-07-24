namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("JaraxxusHeroSpell")]
    public class JaraxxusHeroSpell : Spell
    {
        public JaraxxusHeroSpell(IntPtr address) : this(address, "JaraxxusHeroSpell")
        {
        }

        public JaraxxusHeroSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddPowerTargets()
        {
            return base.method_11<bool>("AddPowerTargets", Array.Empty<object>());
        }

        public void Finish()
        {
            base.method_8("Finish", Array.Empty<object>());
        }

        public Card GetCardFromTask(PowerTask task)
        {
            object[] objArray1 = new object[] { task };
            return base.method_14<Card>("GetCardFromTask", objArray1);
        }

        public Triton.Game.Mapping.Entity LoadCardFromTask(PowerTask task)
        {
            object[] objArray1 = new object[] { task };
            return base.method_14<Triton.Game.Mapping.Entity>("LoadCardFromTask", objArray1);
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public void OnSpellFinished_HeroPower(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished_HeroPower", objArray1);
        }

        public void OnSpellFinished_Weapon(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished_Weapon", objArray1);
        }

        public void PlayCardSpells(Card heroPowerCard, Card weaponCard)
        {
            object[] objArray1 = new object[] { heroPowerCard, weaponCard };
            base.method_8("PlayCardSpells", objArray1);
        }

        public void Reset()
        {
            base.method_8("Reset", Array.Empty<object>());
        }

        public PowerTask m_heroPowerTask
        {
            get
            {
                return base.method_3<PowerTask>("m_heroPowerTask");
            }
        }

        public PowerTask m_weaponTask
        {
            get
            {
                return base.method_3<PowerTask>("m_weaponTask");
            }
        }
    }
}

