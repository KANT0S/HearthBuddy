namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("GameDbfIndex")]
    public class GameDbfIndex : MonoClass
    {
        public GameDbfIndex(IntPtr address) : this(address, "GameDbfIndex")
        {
        }

        public GameDbfIndex(IntPtr address, string className) : base(address, className)
        {
        }

        public List<int> GetAllCardDbIds()
        {
            Class266<int> class2 = base.method_14<Class266<int>>("GetAllCardDbIds", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<string> GetAllCardIds()
        {
            Class268 class2 = base.method_14<Class268>("GetAllCardIds", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public CardDbfRecord GetCardRecord(int dbId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { dbId };
            return base.method_15<CardDbfRecord>("GetCardRecord", enumArray1, objArray1);
        }

        public CardDbfRecord GetCardRecord(string cardId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { cardId };
            return base.method_15<CardDbfRecord>("GetCardRecord", enumArray1, objArray1);
        }

        public int GetCollectibleCardCount()
        {
            return base.method_11<int>("GetCollectibleCardCount", Array.Empty<object>());
        }

        public List<int> GetCollectibleCardDbIds()
        {
            Class266<int> class2 = base.method_14<Class266<int>>("GetCollectibleCardDbIds", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<string> GetCollectibleCardIds()
        {
            Class268 class2 = base.method_14<Class268>("GetCollectibleCardIds", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<FixedRewardActionDbfRecord> GetFixedActionRecordsForType(FixedActionType type)
        {
            object[] objArray1 = new object[] { type };
            Class267<FixedRewardActionDbfRecord> class2 = base.method_14<Class267<FixedRewardActionDbfRecord>>("GetFixedActionRecordsForType", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<FixedRewardMapDbfRecord> GetFixedRewardMapRecordsForAction(int actionId)
        {
            object[] objArray1 = new object[] { actionId };
            Class267<FixedRewardMapDbfRecord> class2 = base.method_14<Class267<FixedRewardMapDbfRecord>>("GetFixedRewardMapRecordsForAction", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public void OnCardAdded(CardDbfRecord cardRecord)
        {
            object[] objArray1 = new object[] { cardRecord };
            base.method_8("OnCardAdded", objArray1);
        }

        public void OnDeckBuilderRuleSubsetAdded(DeckRulesetRuleSubsetDbfRecord record)
        {
            object[] objArray1 = new object[] { record };
            base.method_8("OnDeckBuilderRuleSubsetAdded", objArray1);
        }

        public void OnFixedRewardActionAdded(FixedRewardActionDbfRecord record)
        {
            object[] objArray1 = new object[] { record };
            base.method_8("OnFixedRewardActionAdded", objArray1);
        }

        public void OnFixedRewardMapAdded(FixedRewardMapDbfRecord record)
        {
            object[] objArray1 = new object[] { record };
            base.method_8("OnFixedRewardMapAdded", objArray1);
        }

        public void OnSubsetCardAdded(SubsetCardDbfRecord record)
        {
            object[] objArray1 = new object[] { record };
            base.method_8("OnSubsetCardAdded", objArray1);
        }

        public List<int> m_allCardDbIds
        {
            get
            {
                Class266<int> class2 = base.method_3<Class266<int>>("m_allCardDbIds");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<string> m_allCardIds
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_allCardIds");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_collectibleCardCount
        {
            get
            {
                return base.method_2<int>("m_collectibleCardCount");
            }
        }

        public List<int> m_collectibleCardDbIds
        {
            get
            {
                Class266<int> class2 = base.method_3<Class266<int>>("m_collectibleCardDbIds");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<string> m_collectibleCardIds
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_collectibleCardIds");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

