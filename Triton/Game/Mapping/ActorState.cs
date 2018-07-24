namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("ActorState")]
    public class ActorState : MonoBehaviour
    {
        public ActorState(IntPtr address) : this(address, "ActorState")
        {
        }

        public ActorState(IntPtr address, string className) : base(address, className)
        {
        }

        public float GetAnimationDuration()
        {
            return base.method_11<float>("GetAnimationDuration", Array.Empty<object>());
        }

        public void HideState()
        {
            base.method_8("HideState", Array.Empty<object>());
        }

        public void OnChangeState(ActorStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("OnChangeState", objArray1);
        }

        public void Play()
        {
            base.method_8("Play", Array.Empty<object>());
        }

        public void PlayNow()
        {
            base.method_8("PlayNow", Array.Empty<object>());
        }

        public void ShowState()
        {
            base.method_8("ShowState", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public List<ActorStateAnimObject> m_ExternalAnimatedObjects
        {
            get
            {
                Class267<ActorStateAnimObject> class2 = base.method_3<Class267<ActorStateAnimObject>>("m_ExternalAnimatedObjects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_initialized
        {
            get
            {
                return base.method_2<bool>("m_initialized");
            }
        }

        public bool m_playing
        {
            get
            {
                return base.method_2<bool>("m_playing");
            }
        }

        public ActorStateMgr m_stateMgr
        {
            get
            {
                return base.method_3<ActorStateMgr>("m_stateMgr");
            }
        }

        public ActorStateType m_StateType
        {
            get
            {
                return base.method_2<ActorStateType>("m_StateType");
            }
        }
    }
}

