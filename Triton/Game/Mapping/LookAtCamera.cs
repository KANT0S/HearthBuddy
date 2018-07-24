namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("LookAtCamera")]
    public class LookAtCamera : MonoBehaviour
    {
        public LookAtCamera(IntPtr address) : this(address, "LookAtCamera")
        {
        }

        public LookAtCamera(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CreateLookAtTarget()
        {
            base.method_8("CreateLookAtTarget", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public Vector3 m_LookAtPositionOffset
        {
            get
            {
                return base.method_2<Vector3>("m_LookAtPositionOffset");
            }
        }

        public GameObject m_LookAtTarget
        {
            get
            {
                return base.method_3<GameObject>("m_LookAtTarget");
            }
        }

        public Camera m_MainCamera
        {
            get
            {
                return base.method_3<Camera>("m_MainCamera");
            }
        }

        public Vector3 X_VECTOR
        {
            get
            {
                return base.method_2<Vector3>("X_VECTOR");
            }
        }

        public Vector3 Y_VECTOR
        {
            get
            {
                return base.method_2<Vector3>("Y_VECTOR");
            }
        }

        public Vector3 Z_VECTOR
        {
            get
            {
                return base.method_2<Vector3>("Z_VECTOR");
            }
        }
    }
}

