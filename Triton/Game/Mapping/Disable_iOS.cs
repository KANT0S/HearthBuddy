namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("Disable_iOS")]
    public class Disable_iOS : MonoBehaviour
    {
        public Disable_iOS(IntPtr address) : this(address, "Disable_iOS")
        {
        }

        public Disable_iOS(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
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

