namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ReticlePerspectiveAdjust")]
    public class ReticlePerspectiveAdjust : MonoBehaviour
    {
        public ReticlePerspectiveAdjust(IntPtr address) : this(address, "ReticlePerspectiveAdjust")
        {
        }

        public ReticlePerspectiveAdjust(IntPtr address, string className) : base(address, className)
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

        public float m_HorizontalAdjustment
        {
            get
            {
                return base.method_2<float>("m_HorizontalAdjustment");
            }
        }

        public float m_VertialAdjustment
        {
            get
            {
                return base.method_2<float>("m_VertialAdjustment");
            }
        }
    }
}

