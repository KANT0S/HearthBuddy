namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("CardSpecificVoData")]
    public class CardSpecificVoData : MonoClass
    {
        public CardSpecificVoData(IntPtr address) : this(address, "CardSpecificVoData")
        {
        }

        public CardSpecificVoData(IntPtr address, string className) : base(address, className)
        {
        }

        public string m_CardId
        {
            get
            {
                return base.method_4("m_CardId");
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

