namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("PackOpeningBones")]
    public class PackOpeningBones : MonoClass
    {
        public PackOpeningBones(IntPtr address) : this(address, "PackOpeningBones")
        {
        }

        public PackOpeningBones(IntPtr address, string className) : base(address, className)
        {
        }

        public Transform m_Director
        {
            get
            {
                return base.method_3<Transform>("m_Director");
            }
        }

        public Transform m_DoneButton
        {
            get
            {
                return base.method_3<Transform>("m_DoneButton");
            }
        }

        public Transform m_Hint
        {
            get
            {
                return base.method_3<Transform>("m_Hint");
            }
        }
    }
}

