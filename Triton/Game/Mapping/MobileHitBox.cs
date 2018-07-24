namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MobileHitBox")]
    public class MobileHitBox : MonoBehaviour
    {
        public MobileHitBox(IntPtr address) : this(address, "MobileHitBox")
        {
        }

        public MobileHitBox(IntPtr address, string className) : base(address, className)
        {
        }

        public bool HasExecuted()
        {
            return base.method_11<bool>("HasExecuted", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public BoxCollider m_boxCollider
        {
            get
            {
                return base.method_3<BoxCollider>("m_boxCollider");
            }
        }

        public bool m_hasExecuted
        {
            get
            {
                return base.method_2<bool>("m_hasExecuted");
            }
        }

        public Vector3 m_offset
        {
            get
            {
                return base.method_2<Vector3>("m_offset");
            }
        }

        public bool m_phoneOnly
        {
            get
            {
                return base.method_2<bool>("m_phoneOnly");
            }
        }

        public float m_scaleX
        {
            get
            {
                return base.method_2<float>("m_scaleX");
            }
        }

        public float m_scaleY
        {
            get
            {
                return base.method_2<float>("m_scaleY");
            }
        }

        public float m_scaleZ
        {
            get
            {
                return base.method_2<float>("m_scaleZ");
            }
        }
    }
}

