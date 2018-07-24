namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("RandomPickPlaymakerEvent")]
    public class RandomPickPlaymakerEvent : MonoBehaviour
    {
        public RandomPickPlaymakerEvent(IntPtr address) : this(address, "RandomPickPlaymakerEvent")
        {
        }

        public RandomPickPlaymakerEvent(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DisableCollider()
        {
            base.method_8("DisableCollider", Array.Empty<object>());
        }

        public void EnableCollider()
        {
            base.method_8("EnableCollider", Array.Empty<object>());
        }

        public void EndAnimationFinished()
        {
            base.method_8("EndAnimationFinished", Array.Empty<object>());
        }

        public void RandomPickEvent()
        {
            base.method_8("RandomPickEvent", Array.Empty<object>());
        }

        public void SendAlternateRandomEvent()
        {
            base.method_8("SendAlternateRandomEvent", Array.Empty<object>());
        }

        public void SendRandomEvent()
        {
            base.method_8("SendRandomEvent", Array.Empty<object>());
        }

        public void StartAnimationFinished()
        {
            base.method_8("StartAnimationFinished", Array.Empty<object>());
        }

        public bool m_AllowNoneState
        {
            get
            {
                return base.method_2<bool>("m_AllowNoneState");
            }
        }

        public bool m_AlternateEventState
        {
            get
            {
                return base.method_2<bool>("m_AlternateEventState");
            }
        }

        public List<PickEvent> m_AlternateState
        {
            get
            {
                Class267<PickEvent> class2 = base.method_3<Class267<PickEvent>>("m_AlternateState");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_AwakeStateIndex
        {
            get
            {
                return base.method_2<int>("m_AwakeStateIndex");
            }
        }

        public Collider m_Collider
        {
            get
            {
                return base.method_3<Collider>("m_Collider");
            }
        }

        public PickEvent m_CurrentState
        {
            get
            {
                return base.method_3<PickEvent>("m_CurrentState");
            }
        }

        public bool m_EndAnimationFinished
        {
            get
            {
                return base.method_2<bool>("m_EndAnimationFinished");
            }
        }

        public int m_LastAlternateIndex
        {
            get
            {
                return base.method_2<int>("m_LastAlternateIndex");
            }
        }

        public int m_LastEventIndex
        {
            get
            {
                return base.method_2<int>("m_LastEventIndex");
            }
        }

        public bool m_StartAnimationFinished
        {
            get
            {
                return base.method_2<bool>("m_StartAnimationFinished");
            }
        }

        public List<PickEvent> m_State
        {
            get
            {
                Class267<PickEvent> class2 = base.method_3<Class267<PickEvent>>("m_State");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_StateActive
        {
            get
            {
                return base.method_2<bool>("m_StateActive");
            }
        }

        [Attribute38("RandomPickPlaymakerEvent.PickEvent")]
        public class PickEvent : MonoClass
        {
            public PickEvent(IntPtr address) : this(address, "PickEvent")
            {
            }

            public PickEvent(IntPtr address, string className) : base(address, className)
            {
            }

            public int m_CurrentItemIndex
            {
                get
                {
                    return base.method_2<int>("m_CurrentItemIndex");
                }
            }

            public string m_EndEvent
            {
                get
                {
                    return base.method_4("m_EndEvent");
                }
            }

            public string m_StartEvent
            {
                get
                {
                    return base.method_4("m_StartEvent");
                }
            }
        }
    }
}

