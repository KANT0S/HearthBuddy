namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MulliganTimer")]
    public class MulliganTimer : MonoBehaviour
    {
        public MulliganTimer(IntPtr address) : this(address, "MulliganTimer")
        {
        }

        public MulliganTimer(IntPtr address, string className) : base(address, className)
        {
        }

        public float ComputeCountdownRemainingSec()
        {
            return base.method_11<float>("ComputeCountdownRemainingSec", Array.Empty<object>());
        }

        public void SelfDestruct()
        {
            base.method_8("SelfDestruct", Array.Empty<object>());
        }

        public void SetEndTime(float endTimeStamp)
        {
            object[] objArray1 = new object[] { endTimeStamp };
            base.method_8("SetEndTime", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public float m_endTimeStamp
        {
            get
            {
                return base.method_2<float>("m_endTimeStamp");
            }
        }

        public bool m_remainingTimeSet
        {
            get
            {
                return base.method_2<bool>("m_remainingTimeSet");
            }
        }

        public UberText m_timeText
        {
            get
            {
                return base.method_3<UberText>("m_timeText");
            }
        }
    }
}

