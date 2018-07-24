namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("UIBFollowObject")]
    public class UIBFollowObject : MonoBehaviour
    {
        public UIBFollowObject(IntPtr address) : this(address, "UIBFollowObject")
        {
        }

        public UIBFollowObject(IntPtr address, string className) : base(address, className)
        {
        }

        public void UpdateFollowPosition()
        {
            base.method_8("UpdateFollowPosition", Array.Empty<object>());
        }

        public GameObject m_objectToFollow
        {
            get
            {
                return base.method_3<GameObject>("m_objectToFollow");
            }
        }

        public Vector3 m_offset
        {
            get
            {
                return base.method_2<Vector3>("m_offset");
            }
        }

        public GameObject m_rootObject
        {
            get
            {
                return base.method_3<GameObject>("m_rootObject");
            }
        }

        public bool m_useWorldOffset
        {
            get
            {
                return base.method_2<bool>("m_useWorldOffset");
            }
        }
    }
}

