namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AspectRatioDependentPosition")]
    public class AspectRatioDependentPosition : MonoBehaviour
    {
        public AspectRatioDependentPosition(IntPtr address) : this(address, "AspectRatioDependentPosition")
        {
        }

        public AspectRatioDependentPosition(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public Vector3 m_minLocalPosition
        {
            get
            {
                return base.method_2<Vector3>("m_minLocalPosition");
            }
        }
    }
}

