namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("UberFloaty")]
    public class UberFloaty : MonoBehaviour
    {
        public UberFloaty(IntPtr address) : this(address, "UberFloaty")
        {
        }

        public UberFloaty(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public float frequencyMax
        {
            get
            {
                return base.method_2<float>("frequencyMax");
            }
        }

        public float frequencyMaxRot
        {
            get
            {
                return base.method_2<float>("frequencyMaxRot");
            }
        }

        public float frequencyMin
        {
            get
            {
                return base.method_2<float>("frequencyMin");
            }
        }

        public float frequencyMinRot
        {
            get
            {
                return base.method_2<float>("frequencyMinRot");
            }
        }

        public bool localSpace
        {
            get
            {
                return base.method_2<bool>("localSpace");
            }
        }

        public Vector3 m_interval
        {
            get
            {
                return base.method_2<Vector3>("m_interval");
            }
        }

        public Vector3 m_offset
        {
            get
            {
                return base.method_2<Vector3>("m_offset");
            }
        }

        public Vector3 m_rotationInterval
        {
            get
            {
                return base.method_2<Vector3>("m_rotationInterval");
            }
        }

        public Vector3 magnitude
        {
            get
            {
                return base.method_2<Vector3>("magnitude");
            }
        }

        public Vector3 magnitudeRot
        {
            get
            {
                return base.method_2<Vector3>("magnitudeRot");
            }
        }
    }
}

