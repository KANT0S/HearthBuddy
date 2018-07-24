namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("ActorStateMgr")]
    public class ActorStateMgr : MonoBehaviour
    {
        public ActorStateMgr(IntPtr address) : this(address, "ActorStateMgr")
        {
        }

        public ActorStateMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void BuildStateMap()
        {
            base.method_8("BuildStateMap", Array.Empty<object>());
        }

        public bool ChangeState(ActorStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            return base.method_11<bool>("ChangeState", objArray1);
        }

        public bool ChangeState_LegacyState(ActorStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            return base.method_11<bool>("ChangeState_LegacyState", objArray1);
        }

        public bool ChangeState_NewState(ActorStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            return base.method_11<bool>("ChangeState_NewState", objArray1);
        }

        public HighlightState FindHightlightObject()
        {
            return base.method_14<HighlightState>("FindHightlightObject", Array.Empty<object>());
        }

        public List<ActorState> GetActiveStateList()
        {
            Class267<ActorState> class2 = base.method_14<Class267<ActorState>>("GetActiveStateList", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public ActorStateType GetActiveStateType()
        {
            return base.method_11<ActorStateType>("GetActiveStateType", Array.Empty<object>());
        }

        public float GetMaximumAnimationTimeOfActiveStates()
        {
            return base.method_11<float>("GetMaximumAnimationTimeOfActiveStates", Array.Empty<object>());
        }

        public void HideImpl()
        {
            base.method_8("HideImpl", Array.Empty<object>());
        }

        public void HideStateMgr()
        {
            base.method_8("HideStateMgr", Array.Empty<object>());
        }

        public void RefreshStateMgr()
        {
            base.method_8("RefreshStateMgr", Array.Empty<object>());
        }

        public void ShowImpl()
        {
            base.method_8("ShowImpl", Array.Empty<object>());
        }

        public void ShowStateMgr()
        {
            base.method_8("ShowStateMgr", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public ActorStateType m_activeStateType
        {
            get
            {
                return base.method_2<ActorStateType>("m_activeStateType");
            }
        }

        public HighlightState m_HighlightState
        {
            get
            {
                return base.method_3<HighlightState>("m_HighlightState");
            }
        }

        public GameObject m_ObjectContainer
        {
            get
            {
                return base.method_3<GameObject>("m_ObjectContainer");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }
    }
}

