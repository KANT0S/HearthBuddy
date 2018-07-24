namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ClockHandSet")]
    public class ClockHandSet : MonoBehaviour
    {
        public ClockHandSet(IntPtr address) : this(address, "ClockHandSet")
        {
        }

        public ClockHandSet(IntPtr address, string className) : base(address, className)
        {
        }

        public float ComputeHourRotation(int hour)
        {
            object[] objArray1 = new object[] { hour };
            return base.method_11<float>("ComputeHourRotation", objArray1);
        }

        public float ComputeMinuteRotation(int minute)
        {
            object[] objArray1 = new object[] { minute };
            return base.method_11<float>("ComputeMinuteRotation", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public GameObject m_HourHand
        {
            get
            {
                return base.method_3<GameObject>("m_HourHand");
            }
        }

        public GameObject m_MinuteHand
        {
            get
            {
                return base.method_3<GameObject>("m_MinuteHand");
            }
        }

        public int m_prevHour
        {
            get
            {
                return base.method_2<int>("m_prevHour");
            }
        }

        public int m_prevMinute
        {
            get
            {
                return base.method_2<int>("m_prevMinute");
            }
        }
    }
}

