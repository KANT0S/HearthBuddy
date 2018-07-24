namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TimeDelete")]
    public class TimeDelete : MonoBehaviour
    {
        public TimeDelete(IntPtr address) : this(address, "TimeDelete")
        {
        }

        public TimeDelete(IntPtr address, string className) : base(address, className)
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

        public float m_SecondsToDelete
        {
            get
            {
                return base.method_2<float>("m_SecondsToDelete");
            }
        }

        public float m_StartTime
        {
            get
            {
                return base.method_2<float>("m_StartTime");
            }
        }
    }
}

