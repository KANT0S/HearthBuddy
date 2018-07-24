namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("PowerSpellController")]
    public class PowerSpellController : SpellController
    {
        public PowerSpellController(IntPtr address) : this(address, "PowerSpellController")
        {
        }

        public PowerSpellController(IntPtr address, string className) : base(address, className)
        {
        }

        public bool ActivateActorBattlecrySpell()
        {
            return base.method_11<bool>("ActivateActorBattlecrySpell", Array.Empty<object>());
        }

        public bool ActivateCardEffects()
        {
            return base.method_11<bool>("ActivateCardEffects", Array.Empty<object>());
        }

        public bool ActivatePowerSounds()
        {
            return base.method_11<bool>("ActivatePowerSounds", Array.Empty<object>());
        }

        public bool ActivatePowerSpell()
        {
            return base.method_11<bool>("ActivatePowerSpell", Array.Empty<object>());
        }

        public bool AddPowerSourceAndTargets(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("AddPowerSourceAndTargets", objArray1);
        }

        public bool CanActivateActorBattlecrySpell(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("CanActivateActorBattlecrySpell", objArray1);
        }

        public void CardSpellFinished()
        {
            base.method_8("CardSpellFinished", Array.Empty<object>());
        }

        public void CardSpellNoneStateEntered()
        {
            base.method_8("CardSpellNoneStateEntered", Array.Empty<object>());
        }

        public Spell GetActorBattlecrySpell(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_14<Spell>("GetActorBattlecrySpell", objArray1);
        }

        public CardEffect InitEffect(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_14<CardEffect>("InitEffect", objArray1);
        }

        public bool InitPowerSounds(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("InitPowerSounds", objArray1);
        }

        public bool InitPowerSpell(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("InitPowerSpell", objArray1);
        }

        public void OnCardSpellFinished(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnCardSpellFinished", objArray1);
        }

        public void OnCardSpellStateFinished(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnCardSpellStateFinished", objArray1);
        }

        public void OnFinished()
        {
            base.method_8("OnFinished", Array.Empty<object>());
        }

        public void OnProcessTaskList()
        {
            base.method_8("OnProcessTaskList", Array.Empty<object>());
        }

        public void Reset()
        {
            base.method_8("Reset", Array.Empty<object>());
        }

        public int m_cardEffectsBlockingFinish
        {
            get
            {
                return base.method_2<int>("m_cardEffectsBlockingFinish");
            }
        }

        public int m_cardEffectsBlockingTaskListFinish
        {
            get
            {
                return base.method_2<int>("m_cardEffectsBlockingTaskListFinish");
            }
        }

        public CardEffect m_powerEffect
        {
            get
            {
                return base.method_3<CardEffect>("m_powerEffect");
            }
        }

        public bool m_powerEffectCreated
        {
            get
            {
                return base.method_2<bool>("m_powerEffectCreated");
            }
        }

        public List<CardSoundSpell> m_powerSoundSpells
        {
            get
            {
                Class267<CardSoundSpell> class2 = base.method_3<Class267<CardSoundSpell>>("m_powerSoundSpells");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Spell m_powerSpell
        {
            get
            {
                return base.method_3<Spell>("m_powerSpell");
            }
        }
    }
}

