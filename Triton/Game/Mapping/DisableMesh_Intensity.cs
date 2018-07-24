namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DisableMesh_Intensity")]
    public class DisableMesh_Intensity : MonoBehaviour
    {
        public DisableMesh_Intensity(IntPtr address) : this(address, "DisableMesh_Intensity")
        {
        }

        public DisableMesh_Intensity(IntPtr address, string className) : base(address, className)
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

