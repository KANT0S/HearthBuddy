namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CameraShaker")]
    public class CameraShaker : MonoBehaviour
    {
        public CameraShaker(IntPtr address) : this(address, "CameraShaker")
        {
        }

        public CameraShaker(IntPtr address, string className) : base(address, className)
        {
        }

        public void StartShake()
        {
            base.method_8("StartShake", Array.Empty<object>());
        }

        public Vector3 m_Amount
        {
            get
            {
                return base.method_2<Vector3>("m_Amount");
            }
        }

        public bool m_Hold
        {
            get
            {
                return base.method_2<bool>("m_Hold");
            }
        }

        public float m_HoldAtSec
        {
            get
            {
                return base.method_2<float>("m_HoldAtSec");
            }
        }
    }
}

