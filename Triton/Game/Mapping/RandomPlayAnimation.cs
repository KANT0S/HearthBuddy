namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RandomPlayAnimation")]
    public class RandomPlayAnimation : MonoBehaviour
    {
        public RandomPlayAnimation(IntPtr address) : this(address, "RandomPlayAnimation")
        {
        }

        public RandomPlayAnimation(IntPtr address, string className) : base(address, className)
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

        public float m_MaxWaitTime
        {
            get
            {
                return base.method_2<float>("m_MaxWaitTime");
            }
        }

        public float m_MinWaitTime
        {
            get
            {
                return base.method_2<float>("m_MinWaitTime");
            }
        }

        public float m_startTime
        {
            get
            {
                return base.method_2<float>("m_startTime");
            }
        }

        public float m_waitTime
        {
            get
            {
                return base.method_2<float>("m_waitTime");
            }
        }
    }
}

