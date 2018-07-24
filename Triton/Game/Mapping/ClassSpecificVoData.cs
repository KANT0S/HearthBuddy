namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("ClassSpecificVoData")]
    public class ClassSpecificVoData : MonoClass
    {
        public ClassSpecificVoData(IntPtr address) : this(address, "ClassSpecificVoData")
        {
        }

        public ClassSpecificVoData(IntPtr address, string className) : base(address, className)
        {
        }

        public List<ClassSpecificVoLine> m_Lines
        {
            get
            {
                Class267<ClassSpecificVoLine> class2 = base.method_3<Class267<ClassSpecificVoLine>>("m_Lines");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public SpellPlayerSide m_SideToSearch
        {
            get
            {
                return base.method_2<SpellPlayerSide>("m_SideToSearch");
            }
        }

        public List<SpellZoneTag> m_ZonesToSearch
        {
            get
            {
                Class266<SpellZoneTag> class2 = base.method_3<Class266<SpellZoneTag>>("m_ZonesToSearch");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

