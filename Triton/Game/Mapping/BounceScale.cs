namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BounceScale")]
    public class BounceScale : MonoBehaviour
    {
        public BounceScale(IntPtr address) : this(address, "BounceScale")
        {
        }

        public BounceScale(IntPtr address, string className) : base(address, className)
        {
        }

        public void BounceyScale()
        {
            base.method_8("BounceyScale", Array.Empty<object>());
        }

        public float m_Time
        {
            get
            {
                return base.method_2<float>("m_Time");
            }
        }
    }
}

