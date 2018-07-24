namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ClassProgressInfo")]
    public class ClassProgressInfo : MonoClass
    {
        public ClassProgressInfo(IntPtr address) : this(address, "ClassProgressInfo")
        {
        }

        public ClassProgressInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public GameObject m_bone
        {
            get
            {
                return base.method_3<GameObject>("m_bone");
            }
        }

        public TAG_CLASS m_class
        {
            get
            {
                return base.method_2<TAG_CLASS>("m_class");
            }
        }

        public Material m_iconMaterial
        {
            get
            {
                return base.method_3<Material>("m_iconMaterial");
            }
        }
    }
}

