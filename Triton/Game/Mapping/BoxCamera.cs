namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BoxCamera")]
    public class BoxCamera : MonoBehaviour
    {
        public BoxCamera(IntPtr address) : this(address, "BoxCamera")
        {
        }

        public BoxCamera(IntPtr address, string className) : base(address, className)
        {
        }

        public bool ChangeState(State state)
        {
            object[] objArray1 = new object[] { state };
            return base.method_11<bool>("ChangeState", objArray1);
        }

        public void EnableAccelerometer()
        {
            base.method_8("EnableAccelerometer", Array.Empty<object>());
        }

        public Vector3 GetCameraPosition(State state)
        {
            object[] objArray1 = new object[] { state };
            return base.method_11<Vector3>("GetCameraPosition", objArray1);
        }

        public BoxCameraEventTable GetEventTable()
        {
            return base.method_14<BoxCameraEventTable>("GetEventTable", Array.Empty<object>());
        }

        public BoxCameraStateInfo GetInfo()
        {
            return base.method_14<BoxCameraStateInfo>("GetInfo", Array.Empty<object>());
        }

        public Box GetParent()
        {
            return base.method_14<Box>("GetParent", Array.Empty<object>());
        }

        public State GetState()
        {
            return base.method_11<State>("GetState", Array.Empty<object>());
        }

        public void OnAnimFinished()
        {
            base.method_8("OnAnimFinished", Array.Empty<object>());
        }

        public void SetInfo(BoxCameraStateInfo info)
        {
            object[] objArray1 = new object[] { info };
            base.method_8("SetInfo", objArray1);
        }

        public void SetParent(Box parent)
        {
            object[] objArray1 = new object[] { parent };
            base.method_8("SetParent", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateState(State state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("UpdateState", objArray1);
        }

        public bool m_applyAccelerometer
        {
            get
            {
                return base.method_2<bool>("m_applyAccelerometer");
            }
        }

        public Vector3 m_basePosition
        {
            get
            {
                return base.method_2<Vector3>("m_basePosition");
            }
        }

        public Vector2 m_currentAngle
        {
            get
            {
                return base.method_2<Vector2>("m_currentAngle");
            }
        }

        public bool m_disableAccelerometer
        {
            get
            {
                return base.method_2<bool>("m_disableAccelerometer");
            }
        }

        public BoxCameraEventTable m_EventTable
        {
            get
            {
                return base.method_3<BoxCameraEventTable>("m_EventTable");
            }
        }

        public Vector2 m_gyroRotation
        {
            get
            {
                return base.method_2<Vector2>("m_gyroRotation");
            }
        }

        public GameObject m_IgnoreFullscreenEffectsCamera
        {
            get
            {
                return base.method_3<GameObject>("m_IgnoreFullscreenEffectsCamera");
            }
        }

        public BoxCameraStateInfo m_info
        {
            get
            {
                return base.method_3<BoxCameraStateInfo>("m_info");
            }
        }

        public Vector3 m_lookAtPoint
        {
            get
            {
                return base.method_2<Vector3>("m_lookAtPoint");
            }
        }

        public float m_offset
        {
            get
            {
                return base.method_2<float>("m_offset");
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

        public GameObject m_TooltipCamera
        {
            get
            {
                return base.method_3<GameObject>("m_TooltipCamera");
            }
        }

        public float MAX_GYRO_RANGE
        {
            get
            {
                return base.method_2<float>("MAX_GYRO_RANGE");
            }
        }

        public float ROTATION_SCALE
        {
            get
            {
                return base.method_2<float>("ROTATION_SCALE");
            }
        }

        public enum State
        {
            CLOSED,
            CLOSED_WITH_DRAWER,
            OPENED
        }
    }
}

