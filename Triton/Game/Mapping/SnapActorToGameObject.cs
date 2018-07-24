namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("SnapActorToGameObject")]
    public class SnapActorToGameObject : MonoBehaviour
    {
        public SnapActorToGameObject(IntPtr address) : this(address, "SnapActorToGameObject")
        {
        }

        public SnapActorToGameObject(IntPtr address, string className) : base(address, className)
        {
        }

        public void LateUpdate()
        {
            base.method_8("LateUpdate", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public Transform m_actorTransform
        {
            get
            {
                return base.method_3<Transform>("m_actorTransform");
            }
        }

        public Vector3 m_OrgPosition
        {
            get
            {
                return base.method_2<Vector3>("m_OrgPosition");
            }
        }

        public Quaternion m_OrgRotation
        {
            get
            {
                return base.method_2<Quaternion>("m_OrgRotation");
            }
        }

        public Vector3 m_OrgScale
        {
            get
            {
                return base.method_2<Vector3>("m_OrgScale");
            }
        }

        public bool m_ResetTransformOnDisable
        {
            get
            {
                return base.method_2<bool>("m_ResetTransformOnDisable");
            }
        }

        public bool m_SnapPostion
        {
            get
            {
                return base.method_2<bool>("m_SnapPostion");
            }
        }

        public bool m_SnapRotation
        {
            get
            {
                return base.method_2<bool>("m_SnapRotation");
            }
        }

        public bool m_SnapScale
        {
            get
            {
                return base.method_2<bool>("m_SnapScale");
            }
        }
    }
}

