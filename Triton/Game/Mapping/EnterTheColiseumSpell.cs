namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("EnterTheColiseumSpell")]
    public class EnterTheColiseumSpell : Spell
    {
        public EnterTheColiseumSpell(IntPtr address) : this(address, "EnterTheColiseumSpell")
        {
        }

        public EnterTheColiseumSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public List<Card> FindSurvivors()
        {
            Class267<Card> class2 = base.method_14<Class267<Card>>("FindSurvivors", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public Card GetTargetCardFromPowerTask(int index, PowerTask task)
        {
            object[] objArray1 = new object[] { index, task };
            return base.method_14<Card>("GetTargetCardFromPowerTask", objArray1);
        }

        public void LiftCard(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("LiftCard", objArray1);
        }

        public void LowerCard(GameObject target, Vector3 finalPosition)
        {
            object[] objArray1 = new object[] { target, finalPosition };
            base.method_8("LowerCard", objArray1);
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public void PlayDustCloudSpell()
        {
            base.method_8("PlayDustCloudSpell", Array.Empty<object>());
        }

        public void PlaySurvivorSpell(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("PlaySurvivorSpell", objArray1);
        }

        public float m_CameraShakeMagnitude
        {
            get
            {
                return base.method_2<float>("m_CameraShakeMagnitude");
            }
        }

        public float m_DestroyMinionDelay
        {
            get
            {
                return base.method_2<float>("m_DestroyMinionDelay");
            }
        }

        public Spell m_DustSpellPrefab
        {
            get
            {
                return base.method_3<Spell>("m_DustSpellPrefab");
            }
        }

        public bool m_effectsPlaying
        {
            get
            {
                return base.method_2<bool>("m_effectsPlaying");
            }
        }

        public Spell m_ImpactSpellPrefab
        {
            get
            {
                return base.method_3<Spell>("m_ImpactSpellPrefab");
            }
        }

        public iTween.EaseType m_liftEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_liftEaseType");
            }
        }

        public float m_LiftOffset
        {
            get
            {
                return base.method_2<float>("m_LiftOffset");
            }
        }

        public float m_LiftTime
        {
            get
            {
                return base.method_2<float>("m_LiftTime");
            }
        }

        public iTween.EaseType m_lightFadeEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_lightFadeEaseType");
            }
        }

        public float m_LightingFadeTime
        {
            get
            {
                return base.method_2<float>("m_LightingFadeTime");
            }
        }

        public float m_LowerDelay
        {
            get
            {
                return base.method_2<float>("m_LowerDelay");
            }
        }

        public iTween.EaseType m_lowerEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_lowerEaseType");
            }
        }

        public float m_LowerOffset
        {
            get
            {
                return base.method_2<float>("m_LowerOffset");
            }
        }

        public float m_LowerTime
        {
            get
            {
                return base.method_2<float>("m_LowerTime");
            }
        }

        public int m_numSurvivorSpellsPlaying
        {
            get
            {
                return base.method_2<int>("m_numSurvivorSpellsPlaying");
            }
        }

        public string m_RaiseSoundName
        {
            get
            {
                return base.method_4("m_RaiseSoundName");
            }
        }

        public string m_SpellStartSoundPrefab
        {
            get
            {
                return base.method_4("m_SpellStartSoundPrefab");
            }
        }

        public List<Card> m_survivorCards
        {
            get
            {
                Class267<Card> class2 = base.method_3<Class267<Card>>("m_survivorCards");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_survivorLiftHeight
        {
            get
            {
                return base.method_2<float>("m_survivorLiftHeight");
            }
        }

        public bool m_survivorsMeetInMiddle
        {
            get
            {
                return base.method_2<bool>("m_survivorsMeetInMiddle");
            }
        }

        public Spell m_survivorSpellPrefab
        {
            get
            {
                return base.method_3<Spell>("m_survivorSpellPrefab");
            }
        }
    }
}

