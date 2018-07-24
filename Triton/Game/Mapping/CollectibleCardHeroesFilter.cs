namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("CollectibleCardHeroesFilter")]
    public class CollectibleCardHeroesFilter : CollectibleCardFilter
    {
        public CollectibleCardHeroesFilter(IntPtr address) : this(address, "CollectibleCardHeroesFilter")
        {
        }

        public CollectibleCardHeroesFilter(IntPtr address, string className) : base(address, className)
        {
        }

        public List<CollectibleCard> GetHeroesContents(int currentPage)
        {
            object[] objArray1 = new object[] { currentPage };
            Class267<CollectibleCard> class2 = base.method_14<Class267<CollectibleCard>>("GetHeroesContents", objArray1);
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

        public void Init(int heroesPerPage)
        {
            object[] objArray1 = new object[] { heroesPerPage };
            base.method_8("Init", objArray1);
        }

        public void UpdateResults()
        {
            base.method_8("UpdateResults", Array.Empty<object>());
        }

        public List<CollectibleCard> m_allResults
        {
            get
            {
                Class267<CollectibleCard> class2 = base.method_3<Class267<CollectibleCard>>("m_allResults");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_heroesPerPage
        {
            get
            {
                return base.method_2<int>("m_heroesPerPage");
            }
        }
    }
}

