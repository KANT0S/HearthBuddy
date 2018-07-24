namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("StateEventTable")]
    public class StateEventTable : MonoBehaviour
    {
        public StateEventTable(IntPtr address) : this(address, "StateEventTable")
        {
        }

        public StateEventTable(IntPtr address, string className) : base(address, className)
        {
        }

        public void CancelQueuedStates()
        {
            base.method_8("CancelQueuedStates", Array.Empty<object>());
        }

        public string GetLastState()
        {
            return base.method_13("GetLastState", Array.Empty<object>());
        }

        public Spell GetSpellEvent(string eventName)
        {
            object[] objArray1 = new object[] { eventName };
            return base.method_14<Spell>("GetSpellEvent", objArray1);
        }

        public StateEvent GetStateEvent(string eventName)
        {
            object[] objArray1 = new object[] { eventName };
            return base.method_14<StateEvent>("GetStateEvent", objArray1);
        }

        public bool HasState(string eventName)
        {
            object[] objArray1 = new object[] { eventName };
            return base.method_11<bool>("HasState", objArray1);
        }

        public void QueueNextState(Spell spell, SpellStateType prevStateType, object thisStateEvent)
        {
            object[] objArray1 = new object[] { spell, prevStateType, thisStateEvent };
            base.method_8("QueueNextState", objArray1);
        }

        public void SetBoolVar(string eventName, string varName, bool value)
        {
            object[] objArray1 = new object[] { eventName, varName, value };
            base.method_8("SetBoolVar", objArray1);
        }

        public void SetFloatVar(string eventName, string varName, float value)
        {
            object[] objArray1 = new object[] { eventName, varName, value };
            base.method_8("SetFloatVar", objArray1);
        }

        public void SetGameObjectVar(string eventName, string varName, Component value)
        {
            object[] objArray1 = new object[] { eventName, varName, value };
            base.method_9("SetGameObjectVar", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public void SetGameObjectVar(string eventName, string varName, GameObject value)
        {
            object[] objArray1 = new object[] { eventName, varName, value };
            base.method_9("SetGameObjectVar", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public void SetIntVar(string eventName, string varName, int value)
        {
            object[] objArray1 = new object[] { eventName, varName, value };
            base.method_8("SetIntVar", objArray1);
        }

        public void SetVar(string eventName, string varName, object value)
        {
            object[] objArray1 = new object[] { eventName, varName, value };
            base.method_8("SetVar", objArray1);
        }

        public void SetVector3Var(string eventName, string varName, Vector3 value)
        {
            object[] objArray1 = new object[] { eventName, varName, value };
            base.method_8("SetVector3Var", objArray1);
        }

        public void StartNextQueuedState(QueueStateEvent lastEvt)
        {
            object[] objArray1 = new object[] { lastEvt };
            base.method_8("StartNextQueuedState", objArray1);
        }

        public void TriggerState(string eventName, bool saveLastState, string nameOverride)
        {
            object[] objArray1 = new object[] { eventName, saveLastState, nameOverride };
            base.method_8("TriggerState", objArray1);
        }

        public List<StateEvent> m_Events
        {
            get
            {
                Class267<StateEvent> class2 = base.method_3<Class267<StateEvent>>("m_Events");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public string m_LastState
        {
            get
            {
                return base.method_4("m_LastState");
            }
        }

        [Attribute38("StateEventTable.QueueStateEvent")]
        public class QueueStateEvent : MonoClass
        {
            public QueueStateEvent(IntPtr address) : this(address, "QueueStateEvent")
            {
            }

            public QueueStateEvent(IntPtr address, string className) : base(address, className)
            {
            }

            public string GetEventName()
            {
                return base.method_13("GetEventName", Array.Empty<object>());
            }

            public string m_NameOverride
            {
                get
                {
                    return base.method_4("m_NameOverride");
                }
            }

            public bool m_SaveAsLastState
            {
                get
                {
                    return base.method_2<bool>("m_SaveAsLastState");
                }
            }

            public StateEventTable.StateEvent m_StateEvent
            {
                get
                {
                    return base.method_3<StateEventTable.StateEvent>("m_StateEvent");
                }
            }
        }

        [Attribute38("StateEventTable.StateEvent")]
        public class StateEvent : MonoClass
        {
            public StateEvent(IntPtr address) : this(address, "StateEvent")
            {
            }

            public StateEvent(IntPtr address, string className) : base(address, className)
            {
            }

            public Spell m_Event
            {
                get
                {
                    return base.method_3<Spell>("m_Event");
                }
            }

            public string m_Name
            {
                get
                {
                    return base.method_4("m_Name");
                }
            }
        }
    }
}

