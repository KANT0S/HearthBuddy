namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BoxDoor")]
    public class BoxDoor : MonoBehaviour
    {
        public BoxDoor(IntPtr address) : this(address, "BoxDoor")
        {
        }

        public BoxDoor(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool ChangeState(State state)
        {
            object[] objArray1 = new object[] { state };
            return base.method_11<bool>("ChangeState", objArray1);
        }

        public void EnableMaster(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableMaster", objArray1);
        }

        public BoxDoorStateInfo GetInfo()
        {
            return base.method_14<BoxDoorStateInfo>("GetInfo", Array.Empty<object>());
        }

        public Box GetParent()
        {
            return base.method_14<Box>("GetParent", Array.Empty<object>());
        }

        public bool IsMaster()
        {
            return base.method_11<bool>("IsMaster", Array.Empty<object>());
        }

        public void SetInfo(BoxDoorStateInfo info)
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

        public static float BOX_SLIDE_PERCENTAGE_PHONE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "BoxDoor", "BOX_SLIDE_PERCENTAGE_PHONE");
            }
        }

        public BoxDoorStateInfo m_info
        {
            get
            {
                return base.method_3<BoxDoorStateInfo>("m_info");
            }
        }

        public bool m_master
        {
            get
            {
                return base.method_2<bool>("m_master");
            }
        }

        public Box m_parent
        {
            get
            {
                return base.method_3<Box>("m_parent");
            }
        }

        public Vector3 m_startingPosition
        {
            get
            {
                return base.method_2<Vector3>("m_startingPosition");
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
            OPENED
        }
    }
}

