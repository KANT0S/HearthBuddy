namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SpellPath")]
    public class SpellPath : MonoClass
    {
        public SpellPath(IntPtr address) : this(address, "SpellPath")
        {
        }

        public SpellPath(IntPtr address, string className) : base(address, className)
        {
        }

        public Vector3 m_FirstNodeOffset
        {
            get
            {
                return base.method_2<Vector3>("m_FirstNodeOffset");
            }
        }

        public Vector3 m_LastNodeOffset
        {
            get
            {
                return base.method_2<Vector3>("m_LastNodeOffset");
            }
        }

        public string m_PathName
        {
            get
            {
                return base.method_4("m_PathName");
            }
        }

        public SpellPathType m_Type
        {
            get
            {
                return base.method_2<SpellPathType>("m_Type");
            }
        }
    }
}

