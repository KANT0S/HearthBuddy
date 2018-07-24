namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BoxDisk")]
    public class BoxDisk : MonoBehaviour
    {
        public BoxDisk(IntPtr address) : this(address, "BoxDisk")
        {
        }

        public BoxDisk(IntPtr address, string className) : base(address, className)
        {
        }

        public bool ChangeState(State state)
        {
            object[] objArray1 = new object[] { state };
            return base.method_11<bool>("ChangeState", objArray1);
        }

        public BoxDiskStateInfo GetInfo()
        {
            return base.method_14<BoxDiskStateInfo>("GetInfo", Array.Empty<object>());
        }

        public Box GetParent()
        {
            return base.method_14<Box>("GetParent", Array.Empty<object>());
        }

        public void SetInfo(BoxDiskStateInfo info)
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

        public BoxDiskStateInfo m_info
        {
            get
            {
                return base.method_3<BoxDiskStateInfo>("m_info");
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
            LOADING,
            MAINMENU
        }
    }
}

