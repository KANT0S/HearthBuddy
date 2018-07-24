namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DisableMesh_ColorAlpha")]
    public class DisableMesh_ColorAlpha : MonoBehaviour
    {
        public DisableMesh_ColorAlpha(IntPtr address) : this(address, "DisableMesh_ColorAlpha")
        {
        }

        public DisableMesh_ColorAlpha(IntPtr address, string className) : base(address, className)
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

        public Material m_material
        {
            get
            {
                return base.method_3<Material>("m_material");
            }
        }
    }
}

