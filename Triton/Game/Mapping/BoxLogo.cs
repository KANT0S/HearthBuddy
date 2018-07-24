namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BoxLogo")]
    public class BoxLogo : MonoBehaviour
    {
        public BoxLogo(IntPtr address) : this(address, "BoxLogo")
        {
        }

        public BoxLogo(IntPtr address, string className) : base(address, className)
        {
        }

        public bool ChangeState(State state)
        {
            object[] objArray1 = new object[] { state };
            return base.method_11<bool>("ChangeState", objArray1);
        }

        public BoxLogoStateInfo GetInfo()
        {
            return base.method_14<BoxLogoStateInfo>("GetInfo", Array.Empty<object>());
        }

        public Box GetParent()
        {
            return base.method_14<Box>("GetParent", Array.Empty<object>());
        }

        public void SetInfo(BoxLogoStateInfo info)
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

        public BoxLogoStateInfo m_info
        {
            get
            {
                return base.method_3<BoxLogoStateInfo>("m_info");
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
            SHOWN,
            HIDDEN
        }
    }
}

