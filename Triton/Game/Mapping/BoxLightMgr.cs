namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("BoxLightMgr")]
    public class BoxLightMgr : MonoBehaviour
    {
        public BoxLightMgr(IntPtr address) : this(address, "BoxLightMgr")
        {
        }

        public BoxLightMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void ChangeAmbient(BoxLightState state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("ChangeAmbient", objArray1);
        }

        public void ChangeLight(BoxLightState state, BoxLightInfo lightInfo)
        {
            object[] objArray1 = new object[] { state, lightInfo };
            base.method_8("ChangeLight", objArray1);
        }

        public void ChangeState(BoxLightStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("ChangeState", objArray1);
        }

        public void ChangeStateImpl(BoxLightStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("ChangeStateImpl", objArray1);
        }

        public BoxLightState FindState(BoxLightStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            return base.method_14<BoxLightState>("FindState", objArray1);
        }

        public BoxLightStateType GetActiveState()
        {
            return base.method_11<BoxLightStateType>("GetActiveState", Array.Empty<object>());
        }

        public void SetState(BoxLightStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("SetState", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateState()
        {
            base.method_8("UpdateState", Array.Empty<object>());
        }

        public BoxLightStateType m_activeStateType
        {
            get
            {
                return base.method_2<BoxLightStateType>("m_activeStateType");
            }
        }

        public List<BoxLightState> m_States
        {
            get
            {
                Class267<BoxLightState> class2 = base.method_3<Class267<BoxLightState>>("m_States");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

