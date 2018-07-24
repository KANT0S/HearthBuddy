namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("AdventureWingDef")]
    public class AdventureWingDef : MonoBehaviour
    {
        public AdventureWingDef(IntPtr address) : this(address, "AdventureWingDef")
        {
        }

        public AdventureWingDef(IntPtr address, string className) : base(address, className)
        {
        }

        public AdventureDbId GetAdventureId()
        {
            return base.method_11<AdventureDbId>("GetAdventureId", Array.Empty<object>());
        }

        public string GetComingSoonLabel()
        {
            return base.method_13("GetComingSoonLabel", Array.Empty<object>());
        }

        public WingDbId GetOwnershipPrereqId()
        {
            return base.method_11<WingDbId>("GetOwnershipPrereqId", Array.Empty<object>());
        }

        public string GetRequiresLabel()
        {
            return base.method_13("GetRequiresLabel", Array.Empty<object>());
        }

        public int GetSortOrder()
        {
            return base.method_11<int>("GetSortOrder", Array.Empty<object>());
        }

        public WingDbId GetWingId()
        {
            return base.method_11<WingDbId>("GetWingId", Array.Empty<object>());
        }

        public string GetWingName()
        {
            return base.method_13("GetWingName", Array.Empty<object>());
        }

        public void Init(WingDbfRecord wingRecord)
        {
            object[] objArray1 = new object[] { wingRecord };
            base.method_8("Init", objArray1);
        }

        public string m_AccentPrefab
        {
            get
            {
                return base.method_4("m_AccentPrefab");
            }
        }

        public AdventureDbId m_AdventureId
        {
            get
            {
                return base.method_2<AdventureDbId>("m_AdventureId");
            }
        }

        public string m_CoinPrefab
        {
            get
            {
                return base.method_4("m_CoinPrefab");
            }
        }

        public string m_ComingSoonLabel
        {
            get
            {
                return base.method_4("m_ComingSoonLabel");
            }
        }

        public string m_CompleteQuotePrefab
        {
            get
            {
                return base.method_4("m_CompleteQuotePrefab");
            }
        }

        public string m_CompleteQuoteVOLine
        {
            get
            {
                return base.method_4("m_CompleteQuoteVOLine");
            }
        }

        public int m_HiddenRewardsPreviewCount
        {
            get
            {
                return base.method_2<int>("m_HiddenRewardsPreviewCount");
            }
        }

        public string m_LockedLocString
        {
            get
            {
                return base.method_4("m_LockedLocString");
            }
        }

        public string m_LockedPurchaseLocString
        {
            get
            {
                return base.method_4("m_LockedPurchaseLocString");
            }
        }

        public string m_OpenQuotePrefab
        {
            get
            {
                return base.method_4("m_OpenQuotePrefab");
            }
        }

        public string m_OpenQuoteVOLine
        {
            get
            {
                return base.method_4("m_OpenQuoteVOLine");
            }
        }

        public WingDbId m_OwnershipPrereq
        {
            get
            {
                return base.method_2<WingDbId>("m_OwnershipPrereq");
            }
        }

        public string m_RequiresLabel
        {
            get
            {
                return base.method_4("m_RequiresLabel");
            }
        }

        public string m_RewardsPrefab
        {
            get
            {
                return base.method_4("m_RewardsPrefab");
            }
        }

        public int m_SortOrder
        {
            get
            {
                return base.method_2<int>("m_SortOrder");
            }
        }

        public List<string> m_SpecificRewardsPreviewCards
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_SpecificRewardsPreviewCards");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public string m_UnlockSpellPrefab
        {
            get
            {
                return base.method_4("m_UnlockSpellPrefab");
            }
        }

        public WingDbId m_WingId
        {
            get
            {
                return base.method_2<WingDbId>("m_WingId");
            }
        }

        public string m_WingName
        {
            get
            {
                return base.method_4("m_WingName");
            }
        }

        public string m_WingOpenPopup
        {
            get
            {
                return base.method_4("m_WingOpenPopup");
            }
        }

        public string m_WingPrefab
        {
            get
            {
                return base.method_4("m_WingPrefab");
            }
        }
    }
}

