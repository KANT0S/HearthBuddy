namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ClassSpecificVoLine")]
    public class ClassSpecificVoLine : MonoClass
    {
        public ClassSpecificVoLine(IntPtr address) : this(address, "ClassSpecificVoLine")
        {
        }

        public ClassSpecificVoLine(IntPtr address, string className) : base(address, className)
        {
        }

        public SpellClassTag m_Class
        {
            get
            {
                return base.method_2<SpellClassTag>("m_Class");
            }
        }
    }
}

