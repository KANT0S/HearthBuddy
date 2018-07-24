namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Bounce")]
    public class Bounce : MonoBehaviour
    {
        public Bounce(IntPtr address) : this(address, "Bounce")
        {
        }

        public Bounce(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartAnimation()
        {
            base.method_8("StartAnimation", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public float m_BounceAmount
        {
            get
            {
                return base.method_2<float>("m_BounceAmount");
            }
        }

        public float m_BounceAmountOverTime
        {
            get
            {
                return base.method_2<float>("m_BounceAmountOverTime");
            }
        }

        public int m_BounceCount
        {
            get
            {
                return base.method_2<int>("m_BounceCount");
            }
        }

        public float m_Bounceness
        {
            get
            {
                return base.method_2<float>("m_Bounceness");
            }
        }

        public float m_BounceSpeed
        {
            get
            {
                return base.method_2<float>("m_BounceSpeed");
            }
        }

        public float m_Delay
        {
            get
            {
                return base.method_2<float>("m_Delay");
            }
        }

        public bool m_PlayOnStart
        {
            get
            {
                return base.method_2<bool>("m_PlayOnStart");
            }
        }

        public Vector3 m_StartingPosition
        {
            get
            {
                return base.method_2<Vector3>("m_StartingPosition");
            }
        }
    }
}

