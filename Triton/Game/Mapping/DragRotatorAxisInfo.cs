namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("DragRotatorAxisInfo")]
    public class DragRotatorAxisInfo : MonoClass
    {
        public DragRotatorAxisInfo(IntPtr address) : this(address, "DragRotatorAxisInfo")
        {
        }

        public DragRotatorAxisInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_ForceMultiplier
        {
            get
            {
                return base.method_2<float>("m_ForceMultiplier");
            }
        }

        public float m_MaxDegrees
        {
            get
            {
                return base.method_2<float>("m_MaxDegrees");
            }
        }

        public float m_MinDegrees
        {
            get
            {
                return base.method_2<float>("m_MinDegrees");
            }
        }

        public float m_RestSeconds
        {
            get
            {
                return base.method_2<float>("m_RestSeconds");
            }
        }
    }
}

