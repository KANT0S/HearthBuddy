namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MaterialContainer")]
    public class MaterialContainer : MonoBehaviour
    {
        public MaterialContainer(IntPtr address) : this(address, "MaterialContainer")
        {
        }

        public MaterialContainer(IntPtr address, string className) : base(address, className)
        {
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

