namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BoardEvents")]
    public class BoardEvents : MonoBehaviour
    {
        public BoardEvents(IntPtr address) : this(address, "BoardEvents")
        {
        }

        public BoardEvents(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddWeight(EVENT_TYPE eventType, float weight)
        {
            object[] objArray1 = new object[] { eventType, weight };
            base.method_8("AddWeight", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DamageEvent(Card targetCard, float damage)
        {
            object[] objArray1 = new object[] { targetCard, damage };
            base.method_8("DamageEvent", objArray1);
        }

        public void DeathEvent(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("DeathEvent", objArray1);
        }

        public static BoardEvents Get()
        {
            return MonoClass.smethod_15<BoardEvents>(TritonHs.MainAssemblyPath, "", "BoardEvents", "Get", Array.Empty<object>());
        }

        public void HealEvent(Card targetCard, float health)
        {
            object[] objArray1 = new object[] { targetCard, health };
            base.method_8("HealEvent", objArray1);
        }

        public void LargeShakeEvent()
        {
            base.method_8("LargeShakeEvent", Array.Empty<object>());
        }

        public void MinionShakeEvent(ShakeMinionIntensity shakeIntensity, float customIntensity)
        {
            object[] objArray1 = new object[] { shakeIntensity, customIntensity };
            base.method_8("MinionShakeEvent", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void ProcessEvents()
        {
            base.method_8("ProcessEvents", Array.Empty<object>());
        }

        public void ProcessImmediateEvents()
        {
            base.method_8("ProcessImmediateEvents", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void SummonedEvent(Card minionCard)
        {
            object[] objArray1 = new object[] { minionCard };
            base.method_8("SummonedEvent", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public static float AI_PROCESS_INTERVAL
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "BoardEvents", "AI_PROCESS_INTERVAL");
            }
        }

        public static float FAST_PROCESS_INTERVAL
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "BoardEvents", "FAST_PROCESS_INTERVAL");
            }
        }

        public List<EventCallback> m_friendlyHeroDamageCallacks
        {
            get
            {
                Class267<EventCallback> class2 = base.method_3<Class267<EventCallback>>("m_friendlyHeroDamageCallacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<EventCallback> m_friendlyHeroHealCallbacks
        {
            get
            {
                Class267<EventCallback> class2 = base.method_3<Class267<EventCallback>>("m_friendlyHeroHealCallbacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<EventCallback> m_friendlyMinionDamageCallacks
        {
            get
            {
                Class267<EventCallback> class2 = base.method_3<Class267<EventCallback>>("m_friendlyMinionDamageCallacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<EventCallback> m_friendlyMinionHealCallbacks
        {
            get
            {
                Class267<EventCallback> class2 = base.method_3<Class267<EventCallback>>("m_friendlyMinionHealCallbacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<EventCallback> m_frindlyLegendaryMinionDeathCallbacks
        {
            get
            {
                Class267<EventCallback> class2 = base.method_3<Class267<EventCallback>>("m_frindlyLegendaryMinionDeathCallbacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<EventCallback> m_frindlyLegendaryMinionSpawnCallbacks
        {
            get
            {
                Class267<EventCallback> class2 = base.method_3<Class267<EventCallback>>("m_frindlyLegendaryMinionSpawnCallbacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<EventCallback> m_frindlyMinionDeathCallbacks
        {
            get
            {
                Class267<EventCallback> class2 = base.method_3<Class267<EventCallback>>("m_frindlyMinionDeathCallbacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<EventCallback> m_frindlyMinionSpawnCallbacks
        {
            get
            {
                Class267<EventCallback> class2 = base.method_3<Class267<EventCallback>>("m_frindlyMinionSpawnCallbacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_nextFastProcessTime
        {
            get
            {
                return base.method_2<float>("m_nextFastProcessTime");
            }
        }

        public float m_nextProcessTime
        {
            get
            {
                return base.method_2<float>("m_nextProcessTime");
            }
        }

        public List<EventCallback> m_opponentHeroDamageCallacks
        {
            get
            {
                Class267<EventCallback> class2 = base.method_3<Class267<EventCallback>>("m_opponentHeroDamageCallacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<EventCallback> m_opponentHeroHealCallbacks
        {
            get
            {
                Class267<EventCallback> class2 = base.method_3<Class267<EventCallback>>("m_opponentHeroHealCallbacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<EventCallback> m_opponentLegendaryMinionDeathCallbacks
        {
            get
            {
                Class267<EventCallback> class2 = base.method_3<Class267<EventCallback>>("m_opponentLegendaryMinionDeathCallbacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<EventCallback> m_opponentLegendaryMinionSpawnCallbacks
        {
            get
            {
                Class267<EventCallback> class2 = base.method_3<Class267<EventCallback>>("m_opponentLegendaryMinionSpawnCallbacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<EventCallback> m_opponentMinionDamageCallacks
        {
            get
            {
                Class267<EventCallback> class2 = base.method_3<Class267<EventCallback>>("m_opponentMinionDamageCallacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<EventCallback> m_opponentMinionDeathCallbacks
        {
            get
            {
                Class267<EventCallback> class2 = base.method_3<Class267<EventCallback>>("m_opponentMinionDeathCallbacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<EventCallback> m_opponentMinionHealCallbacks
        {
            get
            {
                Class267<EventCallback> class2 = base.method_3<Class267<EventCallback>>("m_opponentMinionHealCallbacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<EventCallback> m_opponentMinionSpawnCallbacks
        {
            get
            {
                Class267<EventCallback> class2 = base.method_3<Class267<EventCallback>>("m_opponentMinionSpawnCallbacks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Dictionary<EVENT_TYPE, float> m_weights
        {
            get
            {
                Class248<EVENT_TYPE, float> class2 = base.method_3<Class248<EVENT_TYPE, float>>("m_weights");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static float PROCESS_INTERVAL
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "BoardEvents", "PROCESS_INTERVAL");
            }
        }

        public enum EVENT_TYPE
        {
            FriendlyHeroDamage,
            OpponentHeroDamage,
            FriendlyHeroHeal,
            OpponentHeroHeal,
            FriendlyLegendaryMinionSpawn,
            OpponentLegendaryMinionSpawn,
            FriendlyLegendaryMinionDeath,
            OpponentLegendaryMinionDeath,
            FriendlyMinionSpawn,
            OpponentMinionSpawn,
            FriendlyMinionDeath,
            OpponentMinionDeath,
            FriendlyMinionDamage,
            OpponentMinionDamage,
            FriendlyMinionHeal,
            OpponentMinionHeal,
            LargeMinionShake
        }

        [Attribute38("BoardEvents.EventCallback")]
        public class EventCallback : MonoClass
        {
            public EventCallback(IntPtr address) : this(address, "EventCallback")
            {
            }

            public EventCallback(IntPtr address, string className) : base(address, className)
            {
            }

            public float minimumWeight
            {
                get
                {
                    return base.method_2<float>("minimumWeight");
                }
            }
        }

        [Attribute38("BoardEvents.EventData")]
        public class EventData : MonoClass
        {
            public EventData(IntPtr address) : this(address, "EventData")
            {
            }

            public EventData(IntPtr address, string className) : base(address, className)
            {
            }

            public Card m_card
            {
                get
                {
                    return base.method_3<Card>("m_card");
                }
            }

            public BoardEvents.EVENT_TYPE m_eventType
            {
                get
                {
                    return base.method_2<BoardEvents.EVENT_TYPE>("m_eventType");
                }
            }

            public TAG_RARITY m_rarity
            {
                get
                {
                    return base.method_2<TAG_RARITY>("m_rarity");
                }
            }

            public float m_timeStamp
            {
                get
                {
                    return base.method_2<float>("m_timeStamp");
                }
            }

            public float m_value
            {
                get
                {
                    return base.method_2<float>("m_value");
                }
            }
        }
    }
}

