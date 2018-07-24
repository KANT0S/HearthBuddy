namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BoxDrawer")]
    public class BoxDrawer : MonoBehaviour
    {
        public BoxDrawer(IntPtr address) : this(address, "BoxDrawer")
        {
        }

        public BoxDrawer(IntPtr address, string className) : base(address, className)
        {
        }

        public bool ChangeState(State state)
        {
            object[] objArray1 = new object[] { state };
            return base.method_11<bool>("ChangeState", objArray1);
        }

        public BoxDrawerStateInfo GetInfo()
        {
            return base.method_14<BoxDrawerStateInfo>("GetInfo", Array.Empty<object>());
        }

        public Box GetParent()
        {
            return base.method_14<Box>("GetParent", Array.Empty<object>());
        }

        public bool IsInactiveState(State state)
        {
            object[] objArray1 = new object[] { state };
            return base.method_11<bool>("IsInactiveState", objArray1);
        }

        public void OnClosedAnimFinished()
        {
            base.method_8("OnClosedAnimFinished", Array.Empty<object>());
        }

        public void OnClosedBoxOpenedAnimFinished()
        {
            base.method_8("OnClosedBoxOpenedAnimFinished", Array.Empty<object>());
        }

        public void OnOpenedAnimFinished()
        {
            base.method_8("OnOpenedAnimFinished", Array.Empty<object>());
        }

        public void SetInfo(BoxDrawerStateInfo info)
        {
            object[] objArray1 = new object[] { info };
            base.method_8("SetInfo", objArray1);
        }

        public void SetParent(Box parent)
        {
            object[] objArray1 = new object[] { parent };
            base.method_8("SetParent", objArray1);
        }

        public void UpdateState(State state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("UpdateState", objArray1);
        }

        public BoxDrawerStateInfo m_info
        {
            get
            {
                return base.method_3<BoxDrawerStateInfo>("m_info");
            }
        }

        public Box m_parent
        {
            get
            {
                return base.method_3<Box>("m_parent");
            }
        }

        public State m_state
        {
            get
            {
                return base.method_2<State>("m_state");
            }
        }

        public enum State
        {
            CLOSED,
            CLOSED_BOX_OPENED,
            OPENED
        }
    }
}

