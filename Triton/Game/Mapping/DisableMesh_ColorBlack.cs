namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DisableMesh_ColorBlack")]
    public class DisableMesh_ColorBlack : MonoBehaviour
    {
        public DisableMesh_ColorBlack(IntPtr address) : this(address, "DisableMesh_ColorBlack")
        {
        }

        public DisableMesh_ColorBlack(IntPtr address, string className) : base(address, className)
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

        public Color m_color
        {
            get
            {
                return base.method_2<Color>("m_color");
            }
        }

        public Material m_material
        {
            get
            {
                return base.method_3<Material>("m_material");
            }
        }

        public bool m_tintColor
        {
            get
            {
                return base.method_2<bool>("m_tintColor");
            }
        }
    }
}

