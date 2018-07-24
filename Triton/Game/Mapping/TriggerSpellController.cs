namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("TriggerSpellController")]
    public class TriggerSpellController : SpellController
    {
        public TriggerSpellController(IntPtr address) : this(address, "TriggerSpellController")
        {
        }

        public TriggerSpellController(IntPtr address, string className) : base(address, className)
        {
        }

        public bool ActivateActorTriggerSpell()
        {
            return base.method_11<bool>("ActivateActorTriggerSpell", Array.Empty<object>());
        }

        public bool ActivateCardEffects()
        {
            return base.method_11<bool>("ActivateCardEffects", Array.Empty<object>());
        }

        public bool ActivateInitialSpell()
        {
            return base.method_11<bool>("ActivateInitialSpell", Array.Empty<object>());
        }

        public bool ActivateTriggerSounds()
        {
            return base.method_11<bool>("ActivateTriggerSounds", Array.Empty<object>());
        }

        public bool ActivateTriggerSpell()
        {
            return base.method_11<bool>("ActivateTriggerSpell", Array.Empty<object>());
        }

        public bool AddPowerSourceAndTargets(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("AddPowerSourceAndTargets", objArray1);
        }

        public bool CanPlayActorTriggerSpell(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("CanPlayActorTriggerSpell", objArray1);
        }

        public void CardSpellFinished()
        {
            base.method_8("CardSpellFinished", Array.Empty<object>());
        }

        public void CardSpellNoneStateEntered()
        {
            base.method_8("CardSpellNoneStateEntered", Array.Empty<object>());
        }

        public Spell GetActorTriggerSpell(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_14<Spell>("GetActorTriggerSpell", objArray1);
        }

        public Card GetCardWithActorTrigger(Triton.Game.Mapping.Entity entity)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { entity };
            return base.method_15<Card>("GetCardWithActorTrigger", enumArray1, objArray1);
        }

        public Card GetCardWithActorTrigger(PowerTaskList taskList)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { taskList };
            return base.method_15<Card>("GetCardWithActorTrigger", enumArray1, objArray1);
        }

        public bool HasSourceCard(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("HasSourceCard", objArray1);
        }

        public CardEffect InitEffect(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_14<CardEffect>("InitEffect", objArray1);
        }

        public bool InitTriggerSounds(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("InitTriggerSounds", objArray1);
        }

        public void InitTriggerSpell(Card sourceCard)
        {
            object[] objArray1 = new object[] { sourceCard };
            base.method_8("InitTriggerSpell", objArray1);
        }

        public void OnActorTriggerSpellStateFinished(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnActorTriggerSpellStateFinished", objArray1);
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

        public Spell m_actorTriggerSpell
        {
            get
            {
                return base.method_3<Spell>("m_actorTriggerSpell");
            }
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

        public CardEffect m_triggerEffect
        {
            get
            {
                return base.method_3<CardEffect>("m_triggerEffect");
            }
        }

        public bool m_triggerEffectCreated
        {
            get
            {
                return base.method_2<bool>("m_triggerEffectCreated");
            }
        }

        public List<CardSoundSpell> m_triggerSoundSpells
        {
            get
            {
                Class267<CardSoundSpell> class2 = base.method_3<Class267<CardSoundSpell>>("m_triggerSoundSpells");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Spell m_triggerSpell
        {
            get
            {
                return base.method_3<Spell>("m_triggerSpell");
            }
        }
    }
}

