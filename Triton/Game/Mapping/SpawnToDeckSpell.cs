namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SpawnToDeckSpell")]
    public class SpawnToDeckSpell : SuperSpell
    {
        public SpawnToDeckSpell(IntPtr address) : this(address, "SpawnToDeckSpell")
        {
        }

        public SpawnToDeckSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddPowerTargets()
        {
            return base.method_11<bool>("AddPowerTargets", Array.Empty<object>());
        }

        public Vector3 ComputeRevealPosition(Vector3 offset)
        {
            object[] objArray1 = new object[] { offset };
            return base.method_11<Vector3>("ComputeRevealPosition", objArray1);
        }

        public CardDef GetCardDef(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_14<CardDef>("GetCardDef", objArray1);
        }

        public EntityDef GetEntityDef(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_14<EntityDef>("GetEntityDef", objArray1);
        }

        public TAG_PREMIUM GetPremium(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<TAG_PREMIUM>("GetPremium", objArray1);
        }

        public Card GetTargetCardFromPowerTask(int index, PowerTask task)
        {
            object[] objArray1 = new object[] { index, task };
            return base.method_14<Card>("GetTargetCardFromPowerTask", objArray1);
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public List<float> RandomizeRevealTimes(int count, float revealSec, float nextRevealSecMin, float nextRevealSecMax)
        {
            object[] objArray1 = new object[] { count, revealSec, nextRevealSecMin, nextRevealSecMax };
            Class266<float> class2 = base.method_14<Class266<float>>("RandomizeRevealTimes", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public HandActorSource m_HandActorSource
        {
            get
            {
                return base.method_2<HandActorSource>("m_HandActorSource");
            }
        }

        public CardDef m_overrideCardDef
        {
            get
            {
                return base.method_3<CardDef>("m_overrideCardDef");
            }
        }

        public string m_OverrideCardId
        {
            get
            {
                return base.method_4("m_OverrideCardId");
            }
        }

        public float m_RevealFriendlySideZOffset
        {
            get
            {
                return base.method_2<float>("m_RevealFriendlySideZOffset");
            }
        }

        public float m_RevealOpponentSideZOffset
        {
            get
            {
                return base.method_2<float>("m_RevealOpponentSideZOffset");
            }
        }

        public float m_RevealStartScale
        {
            get
            {
                return base.method_2<float>("m_RevealStartScale");
            }
        }

        public float m_RevealYOffsetMax
        {
            get
            {
                return base.method_2<float>("m_RevealYOffsetMax");
            }
        }

        public float m_RevealYOffsetMin
        {
            get
            {
                return base.method_2<float>("m_RevealYOffsetMin");
            }
        }

        public SequenceData m_SequenceData
        {
            get
            {
                return base.method_3<SequenceData>("m_SequenceData");
            }
        }

        public SpreadType m_SpreadType
        {
            get
            {
                return base.method_2<SpreadType>("m_SpreadType");
            }
        }

        public StackData m_StackData
        {
            get
            {
                return base.method_3<StackData>("m_StackData");
            }
        }

        public static float PHONE_HAND_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SpawnToDeckSpell", "PHONE_HAND_OFFSET");
            }
        }

        public enum HandActorSource
        {
            CHOSEN_TARGET,
            OVERRIDE,
            SPELL_TARGET
        }

        [Attribute38("SpawnToDeckSpell.SequenceData")]
        public class SequenceData : MonoClass
        {
            public SequenceData(IntPtr address) : this(address, "SequenceData")
            {
            }

            public SequenceData(IntPtr address, string className) : base(address, className)
            {
            }

            public float m_HoldTime
            {
                get
                {
                    return base.method_2<float>("m_HoldTime");
                }
            }

            public float m_NextCardHoldTime
            {
                get
                {
                    return base.method_2<float>("m_NextCardHoldTime");
                }
            }

            public float m_NextCardRevealTimeMax
            {
                get
                {
                    return base.method_2<float>("m_NextCardRevealTimeMax");
                }
            }

            public float m_NextCardRevealTimeMin
            {
                get
                {
                    return base.method_2<float>("m_NextCardRevealTimeMin");
                }
            }

            public float m_RevealTime
            {
                get
                {
                    return base.method_2<float>("m_RevealTime");
                }
            }

            public float m_Spacing
            {
                get
                {
                    return base.method_2<float>("m_Spacing");
                }
            }
        }

        public enum SpreadType
        {
            STACK,
            SEQUENCE
        }

        [Attribute38("SpawnToDeckSpell.StackData")]
        public class StackData : MonoClass
        {
            public StackData(IntPtr address) : this(address, "StackData")
            {
            }

            public StackData(IntPtr address, string className) : base(address, className)
            {
            }

            public float m_RevealTime
            {
                get
                {
                    return base.method_2<float>("m_RevealTime");
                }
            }

            public float m_StaggerTime
            {
                get
                {
                    return base.method_2<float>("m_StaggerTime");
                }
            }
        }
    }
}

