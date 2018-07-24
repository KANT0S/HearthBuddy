namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CollectibleCardFilter")]
    public class CollectibleCardFilter : MonoClass
    {
        public CollectibleCardFilter(IntPtr address) : this(address, "CollectibleCardFilter")
        {
        }

        public CollectibleCardFilter(IntPtr address, string className) : base(address, className)
        {
        }

        public static string ConvertEuropeanCharacters(string input)
        {
            object[] objArray1 = new object[] { input };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "CollectibleCardFilter", "ConvertEuropeanCharacters", objArray1);
        }

        public void FilterHero(bool isHero)
        {
            object[] objArray1 = new object[] { isHero };
            base.method_8("FilterHero", objArray1);
        }

        public void FilterOnlyCraftable(bool onlyCraftable)
        {
            object[] objArray1 = new object[] { onlyCraftable };
            base.method_8("FilterOnlyCraftable", objArray1);
        }

        public void FilterOnlyOwned(bool owned)
        {
            object[] objArray1 = new object[] { owned };
            base.method_8("FilterOnlyOwned", objArray1);
        }

        public void FilterSearchText(string searchText)
        {
            object[] objArray1 = new object[] { searchText };
            base.method_8("FilterSearchText", objArray1);
        }

        public List<CollectibleCard> GenerateList()
        {
            Class267<CollectibleCard> class2 = base.method_14<Class267<CollectibleCard>>("GenerateList", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public bool HasSearchText()
        {
            return base.method_11<bool>("HasSearchText", Array.Empty<object>());
        }

        public static string RemoveDiacritics(string input)
        {
            object[] objArray1 = new object[] { input };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "CollectibleCardFilter", "RemoveDiacritics", objArray1);
        }

        public void SetDeckBuilder(DeckBuilder deckBuilder)
        {
            object[] objArray1 = new object[] { deckBuilder };
            base.method_8("SetDeckBuilder", objArray1);
        }

        public DeckBuilder m_deckBuilder
        {
            get
            {
                return base.method_3<DeckBuilder>("m_deckBuilder");
            }
        }

        public List<TAG_CARD_SET> m_filterCardSets
        {
            get
            {
                Class246<TAG_CARD_SET> class2 = base.method_3<Class246<TAG_CARD_SET>>("m_filterCardSets");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<TAG_CARDTYPE> m_filterCardTypes
        {
            get
            {
                Class246<TAG_CARDTYPE> class2 = base.method_3<Class246<TAG_CARDTYPE>>("m_filterCardTypes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<TAG_CLASS> m_filterClasses
        {
            get
            {
                Class246<TAG_CLASS> class2 = base.method_3<Class246<TAG_CLASS>>("m_filterClasses");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_filterIsHero
        {
            get
            {
                return base.method_2<bool>("m_filterIsHero");
            }
        }

        public string m_filterText
        {
            get
            {
                return base.method_4("m_filterText");
            }
        }
    }
}

