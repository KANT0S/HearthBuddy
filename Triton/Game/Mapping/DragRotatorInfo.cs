namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("DragRotatorInfo")]
    public class DragRotatorInfo : MonoClass
    {
        public DragRotatorInfo(IntPtr address) : this(address, "DragRotatorInfo")
        {
        }

        public DragRotatorInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public DragRotatorAxisInfo m_PitchInfo
        {
            get
            {
                return base.method_3<DragRotatorAxisInfo>("m_PitchInfo");
            }
        }

        public DragRotatorAxisInfo m_RollInfo
        {
            get
            {
                return base.method_3<DragRotatorAxisInfo>("m_RollInfo");
            }
        }
    }
}

