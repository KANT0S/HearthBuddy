namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CollectionDeckTray")]
    public class CollectionDeckTray : MonoBehaviour
    {
        public CollectionDeckTray(IntPtr address) : this(address, "CollectionDeckTray")
        {
        }

        public CollectionDeckTray(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddCard(EntityDef cardEntityDef, TAG_PREMIUM premium, DeckTrayDeckTileVisual deckTileToRemove, bool playSound, Actor animateActor)
        {
            object[] objArray1 = new object[] { cardEntityDef, premium, deckTileToRemove, playSound, animateActor };
            return base.method_11<bool>("AddCard", objArray1);
        }

        public void AllowInput(bool allowed)
        {
            object[] objArray1 = new object[] { allowed };
            base.method_8("AllowInput", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CancelRenamingDeck()
        {
            base.method_8("CancelRenamingDeck", Array.Empty<object>());
        }

        public bool CanPickupCard()
        {
            return base.method_11<bool>("CanPickupCard", Array.Empty<object>());
        }

        public void ClearCountLabels()
        {
            base.method_8("ClearCountLabels", Array.Empty<object>());
        }

        public void DeleteEditingDeck(bool popNavigation)
        {
            object[] objArray1 = new object[] { popNavigation };
            base.method_8("DeleteEditingDeck", objArray1);
        }

        public void DoneButtonPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("DoneButtonPress", objArray1);
        }

        public void EnterEditDeckModeForTavernBrawl()
        {
            base.method_8("EnterEditDeckModeForTavernBrawl", Array.Empty<object>());
        }

        public void Exit()
        {
            base.method_8("Exit", Array.Empty<object>());
        }

        public void ExitEditDeckModeForTavernBrawl()
        {
            base.method_8("ExitEditDeckModeForTavernBrawl", Array.Empty<object>());
        }

        public void FireModeSwitchedEvent()
        {
            base.method_8("FireModeSwitchedEvent", Array.Empty<object>());
        }

        public void FlashDeckTemplateHighlight()
        {
            base.method_8("FlashDeckTemplateHighlight", Array.Empty<object>());
        }

        public static CollectionDeckTray Get()
        {
            return MonoClass.smethod_15<CollectionDeckTray>(TritonHs.MainAssemblyPath, "", "CollectionDeckTray", "Get", Array.Empty<object>());
        }

        public DeckTrayCardBackContent GetCardBackContent()
        {
            return base.method_14<DeckTrayCardBackContent>("GetCardBackContent", Array.Empty<object>());
        }

        public DeckTrayCardListContent GetCardsContent()
        {
            return base.method_14<DeckTrayCardListContent>("GetCardsContent", Array.Empty<object>());
        }

        public DeckTrayDeckTileVisual GetCardTileVisual(int index)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { index };
            return base.method_15<DeckTrayDeckTileVisual>("GetCardTileVisual", enumArray1, objArray1);
        }

        public DeckTrayDeckTileVisual GetCardTileVisual(string cardID)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { cardID };
            return base.method_15<DeckTrayDeckTileVisual>("GetCardTileVisual", enumArray1, objArray1);
        }

        public DeckTrayDeckTileVisual GetCardTileVisual(string cardID, TAG_PREMIUM premType)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { cardID, premType };
            return base.method_15<DeckTrayDeckTileVisual>("GetCardTileVisual", enumArray1, objArray1);
        }

        public DeckContentTypes GetContentTypeFromViewMode(CollectionManagerDisplay.ViewMode viewMode)
        {
            object[] objArray1 = new object[] { viewMode };
            return base.method_11<DeckContentTypes>("GetContentTypeFromViewMode", objArray1);
        }

        public DeckTrayContent GetCurrentContent()
        {
            return base.method_14<DeckTrayContent>("GetCurrentContent", Array.Empty<object>());
        }

        public DeckContentTypes GetCurrentContentType()
        {
            return base.method_11<DeckContentTypes>("GetCurrentContentType", Array.Empty<object>());
        }

        public DeckBigCard GetDeckBigCard()
        {
            return base.method_14<DeckBigCard>("GetDeckBigCard", Array.Empty<object>());
        }

        public DeckTrayDeckListContent GetDecksContent()
        {
            return base.method_14<DeckTrayDeckListContent>("GetDecksContent", Array.Empty<object>());
        }

        public DeckTrayHeroSkinContent GetHeroSkinContent()
        {
            return base.method_14<DeckTrayHeroSkinContent>("GetHeroSkinContent", Array.Empty<object>());
        }

        public DeckTrayDeckTileVisual GetOrAddCardTileVisual(int index, bool affectedByScrollbar)
        {
            object[] objArray1 = new object[] { index, affectedByScrollbar };
            return base.method_14<DeckTrayDeckTileVisual>("GetOrAddCardTileVisual", objArray1);
        }

        public TooltipZone GetTooltipZone()
        {
            return base.method_14<TooltipZone>("GetTooltipZone", Array.Empty<object>());
        }

        public bool HandleDeletedCardDeckUpdate(string cardID)
        {
            object[] objArray1 = new object[] { cardID };
            return base.method_11<bool>("HandleDeletedCardDeckUpdate", objArray1);
        }

        public void HideDeckBigCard(DeckTrayDeckTileVisual cardTile, bool force)
        {
            object[] objArray1 = new object[] { cardTile, force };
            base.method_8("HideDeckBigCard", objArray1);
        }

        public void HideUnseenDeckTrays()
        {
            base.method_8("HideUnseenDeckTrays", Array.Empty<object>());
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public bool IsShowingDeckContents()
        {
            return base.method_11<bool>("IsShowingDeckContents", Array.Empty<object>());
        }

        public bool IsUpdatingTrayMode()
        {
            return base.method_11<bool>("IsUpdatingTrayMode", Array.Empty<object>());
        }

        public bool IsWaitingToDeleteDeck()
        {
            return base.method_11<bool>("IsWaitingToDeleteDeck", Array.Empty<object>());
        }

        public bool MouseIsOver()
        {
            return base.method_11<bool>("MouseIsOver", Array.Empty<object>());
        }

        public bool OnBackOutOfCollectionScreen()
        {
            return base.method_11<bool>("OnBackOutOfCollectionScreen", Array.Empty<object>());
        }

        public bool OnBackOutOfDeckContents()
        {
            return base.method_11<bool>("OnBackOutOfDeckContents", Array.Empty<object>());
        }

        public bool OnBackOutOfDeckContentsImpl(bool deleteDeck)
        {
            object[] objArray1 = new object[] { deleteDeck };
            return base.method_11<bool>("OnBackOutOfDeckContentsImpl", objArray1);
        }

        public void OnBusyWithDeck(bool busy)
        {
            object[] objArray1 = new object[] { busy };
            base.method_8("OnBusyWithDeck", objArray1);
        }

        public void OnCardCountUpdated(int cardCount)
        {
            object[] objArray1 = new object[] { cardCount };
            base.method_8("OnCardCountUpdated", objArray1);
        }

        public void OnCardTileHeld(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("OnCardTileHeld", objArray1);
        }

        public void OnCardTileOut(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("OnCardTileOut", objArray1);
        }

        public void OnCardTileOver(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("OnCardTileOver", objArray1);
        }

        public void OnCardTilePress(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("OnCardTilePress", objArray1);
        }

        public void OnCardTileRelease(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("OnCardTileRelease", objArray1);
        }

        public void OnCardTileTap(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("OnCardTileTap", objArray1);
        }

        public void OnCMViewModeChanged(CollectionManagerDisplay.ViewMode prevMode, CollectionManagerDisplay.ViewMode mode, CollectionManagerDisplay.ViewModeData userdata)
        {
            object[] objArray1 = new object[] { prevMode, mode, userdata };
            base.method_8("OnCMViewModeChanged", objArray1);
        }

        public void OnDeckCountUpdated(int deckCount)
        {
            object[] objArray1 = new object[] { deckCount };
            base.method_8("OnDeckCountUpdated", objArray1);
        }

        public static void OnDeckTrayTileScrollVisibleAffected(GameObject obj, bool visible)
        {
            object[] objArray1 = new object[] { obj, visible };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "CollectionDeckTray", "OnDeckTrayTileScrollVisibleAffected", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnHeroAssigned(string cardID)
        {
            object[] objArray1 = new object[] { cardID };
            base.method_8("OnHeroAssigned", objArray1);
        }

        public void OnTaggedDeckChanged(CollectionManager.DeckTag tag, CollectionDeck newDeck, CollectionDeck oldDeck, object callbackData)
        {
            object[] objArray1 = new object[] { tag, newDeck, oldDeck, callbackData };
            base.method_8("OnTaggedDeckChanged", objArray1);
        }

        public void OnTouchScrollEnded()
        {
            base.method_8("OnTouchScrollEnded", Array.Empty<object>());
        }

        public void OnTouchScrollStarted()
        {
            base.method_8("OnTouchScrollStarted", Array.Empty<object>());
        }

        public void PopupInvalidDeckConfirmation(string reason, bool finishForMe)
        {
            object[] objArray1 = new object[] { reason, finishForMe };
            base.method_8("PopupInvalidDeckConfirmation", objArray1);
        }

        public void RemoveCard(string cardID, TAG_PREMIUM premium, bool owned)
        {
            object[] objArray1 = new object[] { cardID, premium, owned };
            base.method_8("RemoveCard", objArray1);
        }

        public int RemoveClosestTemplateCard(EntityDef entityDef, int sameRemoveCount)
        {
            object[] objArray1 = new object[] { entityDef, sameRemoveCount };
            return base.method_11<int>("RemoveClosestTemplateCard", objArray1);
        }

        public void SaveCurrentDeckAndEnterDeckListMode()
        {
            base.method_8("SaveCurrentDeckAndEnterDeckListMode", Array.Empty<object>());
        }

        public void SaveScrollbarPosition(DeckContentTypes contentType)
        {
            object[] objArray1 = new object[] { contentType };
            base.method_8("SaveScrollbarPosition", objArray1);
        }

        public bool SetCardBack(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            return base.method_11<bool>("SetCardBack", objArray1);
        }

        public void SetHeroSkin(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            base.method_8("SetHeroSkin", objArray1);
        }

        public void SetMyDecksLabelText(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("SetMyDecksLabelText", objArray1);
        }

        public void SetTrayMode(DeckContentTypes contentType)
        {
            object[] objArray1 = new object[] { contentType };
            base.method_8("SetTrayMode", objArray1);
        }

        public void ShowDeck(CollectionManagerDisplay.ViewMode viewMode, long deckID, bool isNewDeck)
        {
            object[] objArray1 = new object[] { viewMode, deckID, isNewDeck };
            base.method_8("ShowDeck", objArray1);
        }

        public void ShowDeckBigCard(DeckTrayDeckTileVisual cardTile, float delay)
        {
            object[] objArray1 = new object[] { cardTile, delay };
            base.method_8("ShowDeckBigCard", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void TryDisableScrollbar()
        {
            base.method_8("TryDisableScrollbar", Array.Empty<object>());
        }

        public void TryEnableScrollbar()
        {
            base.method_8("TryEnableScrollbar", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public void UpdateDoneButtonText()
        {
            base.method_8("UpdateDoneButtonText", Array.Empty<object>());
        }

        public GameObject m_backArrow
        {
            get
            {
                return base.method_3<GameObject>("m_backArrow");
            }
        }

        public DeckTrayCardBackContent m_cardBackContent
        {
            get
            {
                return base.method_3<DeckTrayCardBackContent>("m_cardBackContent");
            }
        }

        public DeckTrayCardListContent m_cardsContent
        {
            get
            {
                return base.method_3<DeckTrayCardListContent>("m_cardsContent");
            }
        }

        public DeckContentTypes m_contentToSet
        {
            get
            {
                return base.method_2<DeckContentTypes>("m_contentToSet");
            }
        }

        public UberText m_countLabelText
        {
            get
            {
                return base.method_3<UberText>("m_countLabelText");
            }
        }

        public UberText m_countText
        {
            get
            {
                return base.method_3<UberText>("m_countText");
            }
        }

        public DeckContentTypes m_currentContent
        {
            get
            {
                return base.method_2<DeckContentTypes>("m_currentContent");
            }
        }

        public DeckBigCard m_deckBigCard
        {
            get
            {
                return base.method_3<DeckBigCard>("m_deckBigCard");
            }
        }

        public TooltipZone m_deckHeaderTooltip
        {
            get
            {
                return base.method_3<TooltipZone>("m_deckHeaderTooltip");
            }
        }

        public DeckTrayDeckListContent m_decksContent
        {
            get
            {
                return base.method_3<DeckTrayDeckListContent>("m_decksContent");
            }
        }

        public UIBButton m_doneButton
        {
            get
            {
                return base.method_3<UIBButton>("m_doneButton");
            }
        }

        public DeckTrayHeroSkinContent m_heroSkinContent
        {
            get
            {
                return base.method_3<DeckTrayHeroSkinContent>("m_heroSkinContent");
            }
        }

        public GameObject m_inputBlocker
        {
            get
            {
                return base.method_3<GameObject>("m_inputBlocker");
            }
        }

        public UberText m_myDecksLabel
        {
            get
            {
                return base.method_3<UberText>("m_myDecksLabel");
            }
        }

        public Transform m_removeCardTutorialBone
        {
            get
            {
                return base.method_3<Transform>("m_removeCardTutorialBone");
            }
        }

        public List<DeckContentScroll> m_scrollables
        {
            get
            {
                Class267<DeckContentScroll> class2 = base.method_3<Class267<DeckContentScroll>>("m_scrollables");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public UIBScrollable m_scrollbar
        {
            get
            {
                return base.method_3<UIBScrollable>("m_scrollbar");
            }
        }

        public bool m_settingNewMode
        {
            get
            {
                return base.method_2<bool>("m_settingNewMode");
            }
        }

        public GameObject m_topCardPositionBone
        {
            get
            {
                return base.method_3<GameObject>("m_topCardPositionBone");
            }
        }

        public bool m_updatingTrayMode
        {
            get
            {
                return base.method_2<bool>("m_updatingTrayMode");
            }
        }

        [Attribute38("CollectionDeckTray.DeckContentScroll")]
        public class DeckContentScroll : MonoClass
        {
            public DeckContentScroll(IntPtr address) : this(address, "DeckContentScroll")
            {
            }

            public DeckContentScroll(IntPtr address, string className) : base(address, className)
            {
            }

            public Vector3 GetCurrentPosition()
            {
                return base.method_11<Vector3>("GetCurrentPosition", Array.Empty<object>());
            }

            public float GetCurrentScroll()
            {
                return base.method_11<float>("GetCurrentScroll", Array.Empty<object>());
            }

            public Vector3 GetStartPosition()
            {
                return base.method_11<Vector3>("GetStartPosition", Array.Empty<object>());
            }

            public void SaveCurrentScroll(float scroll)
            {
                object[] objArray1 = new object[] { scroll };
                base.method_8("SaveCurrentScroll", objArray1);
            }

            public void SaveStartPosition()
            {
                base.method_8("SaveStartPosition", Array.Empty<object>());
            }

            public CollectionDeckTray.DeckContentTypes m_contentType
            {
                get
                {
                    return base.method_2<CollectionDeckTray.DeckContentTypes>("m_contentType");
                }
            }

            public float m_currentScroll
            {
                get
                {
                    return base.method_2<float>("m_currentScroll");
                }
            }

            public bool m_saveScrollPosition
            {
                get
                {
                    return base.method_2<bool>("m_saveScrollPosition");
                }
            }

            public GameObject m_scrollObject
            {
                get
                {
                    return base.method_3<GameObject>("m_scrollObject");
                }
            }

            public Vector3 m_startPos
            {
                get
                {
                    return base.method_2<Vector3>("m_startPos");
                }
            }
        }

        public enum DeckContentTypes
        {
            Decks,
            Cards,
            HeroSkin,
            CardBack,
            INVALID
        }
    }
}

