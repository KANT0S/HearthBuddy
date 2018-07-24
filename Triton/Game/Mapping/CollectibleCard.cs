namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CollectibleCard")]
    public class CollectibleCard : MonoClass
    {
        public CollectibleCard(IntPtr address) : this(address, "CollectibleCard")
        {
        }

        public CollectibleCard(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddCounts(int addOwnedCount, int addSeenCount, DateTime latestInsertDate)
        {
            object[] objArray1 = new object[] { addOwnedCount, addSeenCount, latestInsertDate };
            base.method_8("AddCounts", objArray1);
        }

        public bool Equals(object obj)
        {
            object[] objArray1 = new object[] { obj };
            return base.method_11<bool>("Equals", objArray1);
        }

        public bool FindTextInCard(string searchStr)
        {
            object[] objArray1 = new object[] { searchStr };
            return base.method_11<bool>("FindTextInCard", objArray1);
        }

        public static bool FindTextInternational(string searchStr, string stringToSearch)
        {
            object[] objArray1 = new object[] { searchStr, stringToSearch };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "CollectibleCard", "FindTextInternational", objArray1);
        }

        public EntityDef GetEntityDef()
        {
            return base.method_14<EntityDef>("GetEntityDef", Array.Empty<object>());
        }

        public int GetHashCode()
        {
            return base.method_11<int>("GetHashCode", Array.Empty<object>());
        }

        public void RemoveCounts(int removeOwnedCount)
        {
            object[] objArray1 = new object[] { removeOwnedCount };
            base.method_8("RemoveCounts", objArray1);
        }

        public string ArtistName
        {
            get
            {
                return base.method_13("get_ArtistName", Array.Empty<object>());
            }
        }

        public int Attack
        {
            get
            {
                return base.method_11<int>("get_Attack", Array.Empty<object>());
            }
        }

        public int CardDbId
        {
            get
            {
                return base.method_11<int>("get_CardDbId", Array.Empty<object>());
            }
        }

        public string CardId
        {
            get
            {
                return base.method_13("get_CardId", Array.Empty<object>());
            }
        }

        public string CardInHandText
        {
            get
            {
                return base.method_13("get_CardInHandText", Array.Empty<object>());
            }
        }

        public TAG_CARDTYPE CardType
        {
            get
            {
                return base.method_11<TAG_CARDTYPE>("get_CardType", Array.Empty<object>());
            }
        }

        public TAG_CLASS Class
        {
            get
            {
                return base.method_11<TAG_CLASS>("get_Class", Array.Empty<object>());
            }
        }

        public int CraftBuyCost
        {
            get
            {
                return base.method_11<int>("get_CraftBuyCost", Array.Empty<object>());
            }
        }

        public int CraftSellCost
        {
            get
            {
                return base.method_11<int>("get_CraftSellCost", Array.Empty<object>());
            }
        }

        public int DisenchantCount
        {
            get
            {
                return base.method_11<int>("get_DisenchantCount", Array.Empty<object>());
            }
        }

        public int Health
        {
            get
            {
                return base.method_11<int>("get_Health", Array.Empty<object>());
            }
        }

        public bool IsCraftable
        {
            get
            {
                return base.method_11<bool>("get_IsCraftable", Array.Empty<object>());
            }
        }

        public bool IsHero
        {
            get
            {
                return base.method_11<bool>("get_IsHero", Array.Empty<object>());
            }
        }

        public bool IsNewCard
        {
            get
            {
                return base.method_11<bool>("get_IsNewCard", Array.Empty<object>());
            }
        }

        public DateTime LatestInsertDate
        {
            get
            {
                return base.method_11<DateTime>("get_LatestInsertDate", Array.Empty<object>());
            }
        }

        public int m_CardDbId
        {
            get
            {
                return base.method_2<int>("m_CardDbId");
            }
        }

        public CardDbfRecord m_CardRecord
        {
            get
            {
                return base.method_3<CardDbfRecord>("m_CardRecord");
            }
        }

        public EntityDef m_EntityDef
        {
            get
            {
                return base.method_3<EntityDef>("m_EntityDef");
            }
        }

        public DateTime m_LatestInsertDate
        {
            get
            {
                return base.method_2<DateTime>("m_LatestInsertDate");
            }
        }

        public string m_LongSearchableName
        {
            get
            {
                return base.method_4("m_LongSearchableName");
            }
        }

        public string m_LongSearchableNameNoDiacritics
        {
            get
            {
                return base.method_4("m_LongSearchableNameNoDiacritics");
            }
        }

        public string m_LongSearchableNameNonEuropean
        {
            get
            {
                return base.method_4("m_LongSearchableNameNonEuropean");
            }
        }

        public TAG_PREMIUM m_PremiumType
        {
            get
            {
                return base.method_2<TAG_PREMIUM>("m_PremiumType");
            }
        }

        public int ManaCost
        {
            get
            {
                return base.method_11<int>("get_ManaCost", Array.Empty<object>());
            }
        }

        public int MaxCopiesPerDeck
        {
            get
            {
                return base.method_11<int>("get_MaxCopiesPerDeck", Array.Empty<object>());
            }
        }

        public string Name
        {
            get
            {
                return base.method_13("get_Name", Array.Empty<object>());
            }
        }

        public int OwnedCount
        {
            get
            {
                return base.method_11<int>("get_OwnedCount", Array.Empty<object>());
            }
        }

        public TAG_PREMIUM PremiumType
        {
            get
            {
                return base.method_11<TAG_PREMIUM>("get_PremiumType", Array.Empty<object>());
            }
        }

        public TAG_RACE Race
        {
            get
            {
                return base.method_11<TAG_RACE>("get_Race", Array.Empty<object>());
            }
        }

        public TAG_RARITY Rarity
        {
            get
            {
                return base.method_11<TAG_RARITY>("get_Rarity", Array.Empty<object>());
            }
        }

        public int SeenCount
        {
            get
            {
                return base.method_11<int>("get_SeenCount", Array.Empty<object>());
            }
        }

        public TAG_CARD_SET Set
        {
            get
            {
                return base.method_11<TAG_CARD_SET>("get_Set", Array.Empty<object>());
            }
        }

        public int SuggestWeight
        {
            get
            {
                return base.method_11<int>("get_SuggestWeight", Array.Empty<object>());
            }
        }
    }
}

