namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ScrollingUVs")]
    public class ScrollingUVs : MonoBehaviour
    {
        public ScrollingUVs(IntPtr address) : this(address, "ScrollingUVs")
        {
        }

        public ScrollingUVs(IntPtr address, string className) : base(address, className)
        {
        }

        public void LateUpdate()
        {
            base.method_8("LateUpdate", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public Material m_material
        {
            get
            {
                return base.method_3<Material>("m_material");
            }
        }

        public Vector2 m_offset
        {
            get
            {
                return base.method_2<Vector2>("m_offset");
            }
        }

        public int materialIndex
        {
            get
            {
                return base.method_2<int>("materialIndex");
            }
        }

        public Vector2 uvAnimationRate
        {
            get
            {
                return base.method_2<Vector2>("uvAnimationRate");
            }
        }
    }
}

