namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("TurnTimerUpdate")]
    public class TurnTimerUpdate : MonoClass
    {
        public TurnTimerUpdate(IntPtr address) : this(address, "TurnTimerUpdate")
        {
        }

        public TurnTimerUpdate(IntPtr address, string className) : base(address, className)
        {
        }

        public float GetEndTimestamp()
        {
            return base.method_11<float>("GetEndTimestamp", Array.Empty<object>());
        }

        public float GetSecondsRemaining()
        {
            return base.method_11<float>("GetSecondsRemaining", Array.Empty<object>());
        }

        public void SetEndTimestamp(float timestamp)
        {
            object[] objArray1 = new object[] { timestamp };
            base.method_8("SetEndTimestamp", objArray1);
        }

        public void SetSecondsRemaining(float sec)
        {
            object[] objArray1 = new object[] { sec };
            base.method_8("SetSecondsRemaining", objArray1);
        }

        public void SetShow(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("SetShow", objArray1);
        }

        public bool ShouldShow()
        {
            return base.method_11<bool>("ShouldShow", Array.Empty<object>());
        }

        public float m_endTimestamp
        {
            get
            {
                return base.method_2<float>("m_endTimestamp");
            }
        }

        public float m_secondsRemaining
        {
            get
            {
                return base.method_2<float>("m_secondsRemaining");
            }
        }

        public bool m_show
        {
            get
            {
                return base.method_2<bool>("m_show");
            }
        }
    }
}

