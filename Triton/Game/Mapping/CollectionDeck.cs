namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("CollectionDeck")]
    public class CollectionDeck : MonoClass
    {
        public CollectionDeck(IntPtr address) : this(address, "CollectionDeck")
        {
        }

        public CollectionDeck(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddCard(string cardID, TAG_PREMIUM premium, bool exceedMax)
        {
            object[] objArray1 = new object[] { cardID, premium, exceedMax };
            return base.method_10<bool>("AddCard", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public bool AddCard(EntityDef cardEntityDef, TAG_PREMIUM premium, bool exceedMax)
        {
            object[] objArray1 = new object[] { cardEntityDef, premium, exceedMax };
            return base.method_10<bool>("AddCard", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public bool CanAddOwnedCard(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            return base.method_11<bool>("CanAddOwnedCard", objArray1);
        }

        public bool CanInsertCard(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            return base.method_11<bool>("CanInsertCard", objArray1);
        }

        public Network.CardUserData CardUserDataFromSlot(CollectionDeckSlot deckSlot, bool deleted)
        {
            object[] objArray1 = new object[] { deckSlot, deleted };
            return base.method_14<Network.CardUserData>("CardUserDataFromSlot", objArray1);
        }

        public void ClearSlotContents()
        {
            base.method_8("ClearSlotContents", Array.Empty<object>());
        }

        public void CopyContents(CollectionDeck otherDeck)
        {
            object[] objArray1 = new object[] { otherDeck };
            base.method_8("CopyContents", objArray1);
        }

        public void CopyFrom(CollectionDeck otherDeck)
        {
            object[] objArray1 = new object[] { otherDeck };
            base.method_8("CopyFrom", objArray1);
        }

        public void FillFromTemplateDeck(CollectionManager.TemplateDeck tplDeck)
        {
            object[] objArray1 = new object[] { tplDeck };
            base.method_8("FillFromTemplateDeck", objArray1);
        }

        public CollectionDeckSlot FindSlotByCardIdAndPremium(string cardID, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { cardID, premium };
            return base.method_14<CollectionDeckSlot>("FindSlotByCardIdAndPremium", objArray1);
        }

        public CollectionDeckSlot FindSlotByCardIdPremiumAndOwned(string cardID, TAG_PREMIUM premium, bool owned)
        {
            object[] objArray1 = new object[] { cardID, premium, owned };
            return base.method_14<CollectionDeckSlot>("FindSlotByCardIdPremiumAndOwned", objArray1);
        }

        public List<Network.CardUserData> GenerateContentChanges(CollectionDeck baseDeck)
        {
            object[] objArray1 = new object[] { baseDeck };
            Class267<Network.CardUserData> class2 = base.method_14<Class267<Network.CardUserData>>("GenerateContentChanges", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public int GetCardCount(string cardID, TAG_PREMIUM type)
        {
            object[] objArray1 = new object[] { cardID, type };
            return base.method_11<int>("GetCardCount", objArray1);
        }

        public int GetCardIdCount(string cardID, bool includeUnowned)
        {
            object[] objArray1 = new object[] { cardID, includeUnowned };
            return base.method_11<int>("GetCardIdCount", objArray1);
        }

        public TAG_CLASS GetClass()
        {
            return base.method_11<TAG_CLASS>("GetClass", Array.Empty<object>());
        }

        public List<DeckMaker.DeckFill> GetDeckFillFromString(string deckString)
        {
            object[] objArray1 = new object[] { deckString };
            Class267<DeckMaker.DeckFill> class2 = base.method_14<Class267<DeckMaker.DeckFill>>("GetDeckFillFromString", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public int GetInsertionIdxByDefaultSort(CollectionDeckSlot slot)
        {
            object[] objArray1 = new object[] { slot };
            return base.method_11<int>("GetInsertionIdxByDefaultSort", objArray1);
        }

        public int GetOwnedCardCount(string cardID, TAG_PREMIUM type, bool owned)
        {
            object[] objArray1 = new object[] { cardID, type, owned };
            return base.method_11<int>("GetOwnedCardCount", objArray1);
        }

        public CollectionDeckSlot GetSlotByIndex(int slotIndex)
        {
            object[] objArray1 = new object[] { slotIndex };
            return base.method_14<CollectionDeckSlot>("GetSlotByIndex", objArray1);
        }

        public CollectionDeckSlot GetSlotByUID(long uid)
        {
            object[] objArray1 = new object[] { uid };
            return base.method_14<CollectionDeckSlot>("GetSlotByUID", objArray1);
        }

        public int GetSlotCount()
        {
            return base.method_11<int>("GetSlotCount", Array.Empty<object>());
        }

        public List<CollectionDeckSlot> GetSlots()
        {
            Class267<CollectionDeckSlot> class2 = base.method_14<Class267<CollectionDeckSlot>>("GetSlots", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public CollectionManager.TemplateDeck GetTemplateDeckReference()
        {
            return base.method_14<CollectionManager.TemplateDeck>("GetTemplateDeckReference", Array.Empty<object>());
        }

        public int GetTotalCardCount()
        {
            return base.method_11<int>("GetTotalCardCount", Array.Empty<object>());
        }

        public int GetTotalOwnedCardCount()
        {
            return base.method_11<int>("GetTotalOwnedCardCount", Array.Empty<object>());
        }

        public int GetTotalUnownedCardCount()
        {
            return base.method_11<int>("GetTotalUnownedCardCount", Array.Empty<object>());
        }

        public int GetUnownedCardIdCount(string cardID)
        {
            object[] objArray1 = new object[] { cardID };
            return base.method_11<int>("GetUnownedCardIdCount", objArray1);
        }

        public bool HasTemplateDeckReference()
        {
            return base.method_11<bool>("HasTemplateDeckReference", Array.Empty<object>());
        }

        public bool InsertSlot(int slotIndex, CollectionDeckSlot slot)
        {
            object[] objArray1 = new object[] { slotIndex, slot };
            return base.method_11<bool>("InsertSlot", objArray1);
        }

        public bool InsertSlotByDefaultSort(CollectionDeckSlot slot)
        {
            object[] objArray1 = new object[] { slot };
            return base.method_11<bool>("InsertSlotByDefaultSort", objArray1);
        }

        public bool IsBeingDeleted()
        {
            return base.method_11<bool>("IsBeingDeleted", Array.Empty<object>());
        }

        public bool IsCardOwnershipUnique()
        {
            return base.method_11<bool>("IsCardOwnershipUnique", Array.Empty<object>());
        }

        public bool IsSavingChanges()
        {
            return base.method_11<bool>("IsSavingChanges", Array.Empty<object>());
        }

        public void MarkBeingDeleted()
        {
            base.method_8("MarkBeingDeleted", Array.Empty<object>());
        }

        public void MarkNetworkContentsLoaded()
        {
            base.method_8("MarkNetworkContentsLoaded", Array.Empty<object>());
        }

        public bool NetworkContentsLoaded()
        {
            return base.method_11<bool>("NetworkContentsLoaded", Array.Empty<object>());
        }

        public void OnContentChangesComplete()
        {
            base.method_8("OnContentChangesComplete", Array.Empty<object>());
        }

        public void OnNameChangeComplete()
        {
            base.method_8("OnNameChangeComplete", Array.Empty<object>());
        }

        public void OnSlotEmptied(CollectionDeckSlot slot)
        {
            object[] objArray1 = new object[] { slot };
            base.method_8("OnSlotEmptied", objArray1);
        }

        public bool RemoveCard(string cardID, TAG_PREMIUM premium, bool owned)
        {
            object[] objArray1 = new object[] { cardID, premium, owned };
            return base.method_11<bool>("RemoveCard", objArray1);
        }

        public void RemoveSlot(CollectionDeckSlot slot)
        {
            object[] objArray1 = new object[] { slot };
            base.method_8("RemoveSlot", objArray1);
        }

        public void SendChanges()
        {
            base.method_8("SendChanges", Array.Empty<object>());
        }

        public void SetTemplateDeckReference(CollectionManager.TemplateDeck tplDeck)
        {
            object[] objArray1 = new object[] { tplDeck };
            base.method_8("SetTemplateDeckReference", objArray1);
        }

        public string ToDeckString()
        {
            return base.method_13("ToDeckString", Array.Empty<object>());
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public void UpdateSlotIndices(int indexA, int indexB)
        {
            object[] objArray1 = new object[] { indexA, indexB };
            base.method_8("UpdateSlotIndices", objArray1);
        }

        public int CardBackID
        {
            get
            {
                return base.method_2<int>("CardBackID");
            }
        }

        public bool CardBackOverridden
        {
            get
            {
                return base.method_2<bool>("CardBackOverridden");
            }
        }

        public string HeroCardID
        {
            get
            {
                return base.method_4("HeroCardID");
            }
        }

        public bool HeroOverridden
        {
            get
            {
                return base.method_2<bool>("HeroOverridden");
            }
        }

        public TAG_PREMIUM HeroPremium
        {
            get
            {
                return base.method_2<TAG_PREMIUM>("HeroPremium");
            }
        }

        public long ID
        {
            get
            {
                return base.method_2<long>("ID");
            }
        }

        public bool IsTourneyValid
        {
            get
            {
                return base.method_2<bool>("IsTourneyValid");
            }
        }

        public bool m_isBeingDeleted
        {
            get
            {
                return base.method_2<bool>("m_isBeingDeleted");
            }
        }

        public bool m_isSavingContentChanges
        {
            get
            {
                return base.method_2<bool>("m_isSavingContentChanges");
            }
        }

        public bool m_isSavingNameChanges
        {
            get
            {
                return base.method_2<bool>("m_isSavingNameChanges");
            }
        }

        public string m_name
        {
            get
            {
                return base.method_4("m_name");
            }
        }

        public bool m_netContentsLoaded
        {
            get
            {
                return base.method_2<bool>("m_netContentsLoaded");
            }
        }

        public List<CollectionDeckSlot> m_slots
        {
            get
            {
                Class267<CollectionDeckSlot> class2 = base.method_3<Class267<CollectionDeckSlot>>("m_slots");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public CollectionManager.TemplateDeck m_templateDeckReference
        {
            get
            {
                return base.method_3<CollectionManager.TemplateDeck>("m_templateDeckReference");
            }
        }

        public string Name
        {
            get
            {
                return base.method_13("get_Name", Array.Empty<object>());
            }
        }

        public bool NeedsName
        {
            get
            {
                return base.method_2<bool>("NeedsName");
            }
        }

        public int SeasonId
        {
            get
            {
                return base.method_2<int>("SeasonId");
            }
        }

        public long SortOrder
        {
            get
            {
                return base.method_2<long>("SortOrder");
            }
        }

        public DeckType Type
        {
            get
            {
                return base.method_2<DeckType>("Type");
            }
        }
    }
}

