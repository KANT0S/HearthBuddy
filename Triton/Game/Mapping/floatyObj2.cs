namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("floatyObj2")]
    public class floatyObj2 : MonoBehaviour
    {
        public floatyObj2(IntPtr address) : this(address, "floatyObj2")
        {
        }

        public floatyObj2(IntPtr address, string className) : base(address, className)
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

        public float m_interval
        {
            get
            {
                return base.method_2<float>("m_interval");
            }
        }

        public float m_rotationInterval
        {
            get
            {
                return base.method_2<float>("m_rotationInterval");
            }
        }

        public float magnitude
        {
            get
            {
                return base.method_2<float>("magnitude");
            }
        }

        public float magnitudeRot
        {
            get
            {
                return base.method_2<float>("magnitudeRot");
            }
        }
    }
}

