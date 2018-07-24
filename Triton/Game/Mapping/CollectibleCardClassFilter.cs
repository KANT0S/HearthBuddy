namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("CollectibleCardClassFilter")]
    public class CollectibleCardClassFilter : CollectibleCardFilter
    {
        public CollectibleCardClassFilter(IntPtr address) : this(address, "CollectibleCardClassFilter")
        {
        }

        public CollectibleCardClassFilter(IntPtr address, string className) : base(address, className)
        {
        }

        public int GetNumNewCardsForClass(TAG_CLASS cardClass)
        {
            object[] objArray1 = new object[] { cardClass };
            return base.method_11<int>("GetNumNewCardsForClass", objArray1);
        }

        public int GetNumPagesForClass(TAG_CLASS cardClass)
        {
            object[] objArray1 = new object[] { cardClass };
            return base.method_11<int>("GetNumPagesForClass", objArray1);
        }

        public List<CollectibleCard> GetPageContents(int page)
        {
            object[] objArray1 = new object[] { page };
            Class267<CollectibleCard> class2 = base.method_14<Class267<CollectibleCard>>("GetPageContents", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public int GetTotalNumPages()
        {
            return base.method_11<int>("GetTotalNumPages", Array.Empty<object>());
        }

        public void UpdateResults()
        {
            base.method_8("UpdateResults", Array.Empty<object>());
        }

        public int m_cardsPerPage
        {
            get
            {
                return base.method_2<int>("m_cardsPerPage");
            }
        }

        public List<TAG_CLASS> m_classTabOrder
        {
            get
            {
                Class246<TAG_CLASS> class2 = base.method_3<Class246<TAG_CLASS>>("m_classTabOrder");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

