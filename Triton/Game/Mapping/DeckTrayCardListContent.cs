namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DeckTrayCardListContent")]
    public class DeckTrayCardListContent : DeckTrayContent
    {
        public DeckTrayCardListContent(IntPtr address) : this(address, "DeckTrayCardListContent")
        {
        }

        public DeckTrayCardListContent(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddCard(EntityDef cardEntityDef, TAG_PREMIUM premium, DeckTrayDeckTileVisual deckTileToRemove, bool playSound, Actor animateFromActor)
        {
            object[] objArray1 = new object[] { cardEntityDef, premium, deckTileToRemove, playSound, animateFromActor };
            return base.method_11<bool>("AddCard", objArray1);
        }

        public bool AnimateContentEntranceEnd()
        {
            return base.method_11<bool>("AnimateContentEntranceEnd", Array.Empty<object>());
        }

        public bool AnimateContentEntranceStart()
        {
            return base.method_11<bool>("AnimateContentEntranceStart", Array.Empty<object>());
        }

        public bool AnimateContentExitEnd()
        {
            return base.method_11<bool>("AnimateContentExitEnd", Array.Empty<object>());
        }

        public bool AnimateContentExitStart()
        {
            return base.method_11<bool>("AnimateContentExitStart", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CommitFakeDeckChanges()
        {
            base.method_8("CommitFakeDeckChanges", Array.Empty<object>());
        }

        public void FireCardCountChangedEvent()
        {
            base.method_8("FireCardCountChangedEvent", Array.Empty<object>());
        }

        public void FireCardTileHeldEvent(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("FireCardTileHeldEvent", objArray1);
        }

        public void FireCardTileOutEvent(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("FireCardTileOutEvent", objArray1);
        }

        public void FireCardTileOverEvent(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("FireCardTileOverEvent", objArray1);
        }

        public void FireCardTilePressEvent(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("FireCardTilePressEvent", objArray1);
        }

        public void FireCardTileReleaseEvent(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("FireCardTileReleaseEvent", objArray1);
        }

        public void FireCardTileRightClickedEvent(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("FireCardTileRightClickedEvent", objArray1);
        }

        public void FireCardTileTapEvent(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("FireCardTileTapEvent", objArray1);
        }

        public Vector3 GetCardTileOffset(CollectionDeck currentDeck)
        {
            object[] objArray1 = new object[] { currentDeck };
            return base.method_11<Vector3>("GetCardTileOffset", objArray1);
        }

        public List<DeckTrayDeckTileVisual> GetCardTiles()
        {
            Class267<DeckTrayDeckTileVisual> class2 = base.method_14<Class267<DeckTrayDeckTileVisual>>("GetCardTiles", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
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

        public DeckTrayDeckTileVisual GetCardTileVisualOrLastVisible(string cardID)
        {
            object[] objArray1 = new object[] { cardID };
            return base.method_14<DeckTrayDeckTileVisual>("GetCardTileVisualOrLastVisible", objArray1);
        }

        public Vector3 GetCardVisualExtents()
        {
            return base.method_11<Vector3>("GetCardVisualExtents", Array.Empty<object>());
        }

        public CollectionDeck GetEditingDeck()
        {
            return base.method_14<CollectionDeck>("GetEditingDeck", Array.Empty<object>());
        }

        public DeckTrayDeckTileVisual GetFirstGhostCard()
        {
            return base.method_14<DeckTrayDeckTileVisual>("GetFirstGhostCard", Array.Empty<object>());
        }

        public Vector3 GetOffscreenLocalPosition()
        {
            return base.method_11<Vector3>("GetOffscreenLocalPosition", Array.Empty<object>());
        }

        public DeckTrayDeckTileVisual GetOrAddCardTileVisual(int index)
        {
            object[] objArray1 = new object[] { index };
            return base.method_14<DeckTrayDeckTileVisual>("GetOrAddCardTileVisual", objArray1);
        }

        public bool HasFinishedEntering()
        {
            return base.method_11<bool>("HasFinishedEntering", Array.Empty<object>());
        }

        public bool HasFinishedExiting()
        {
            return base.method_11<bool>("HasFinishedExiting", Array.Empty<object>());
        }

        public void Hide(bool hideAll)
        {
            object[] objArray1 = new object[] { hideAll };
            base.method_8("Hide", objArray1);
        }

        public void HideDeckHelpPopup()
        {
            base.method_8("HideDeckHelpPopup", Array.Empty<object>());
        }

        public void IsCardTileVisible(GameObject obj, bool visible)
        {
            object[] objArray1 = new object[] { obj, visible };
            base.method_8("IsCardTileVisible", objArray1);
        }

        public void OnDeckHelpButtonOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDeckHelpButtonOut", objArray1);
        }

        public void OnDeckHelpButtonOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDeckHelpButtonOver", objArray1);
        }

        public void OnDeckHelpButtonPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDeckHelpButtonPress", objArray1);
        }

        public void OnDeckTemplateHelpButtonOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDeckTemplateHelpButtonOut", objArray1);
        }

        public void OnDeckTemplateHelpButtonOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDeckTemplateHelpButtonOver", objArray1);
        }

        public void OnDeckTemplateHelpButtonPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDeckTemplateHelpButtonPress", objArray1);
        }

        public void OnTaggedDeckChanged(CollectionManager.DeckTag tag, CollectionDeck newDeck, CollectionDeck oldDeck, bool isNewDeck)
        {
            object[] objArray1 = new object[] { tag, newDeck, oldDeck, isNewDeck };
            base.method_8("OnTaggedDeckChanged", objArray1);
        }

        public int RemoveClosestTemplateCard(EntityDef entityDef, int sameRemoveCount)
        {
            object[] objArray1 = new object[] { entityDef, sameRemoveCount };
            return base.method_11<int>("RemoveClosestTemplateCard", objArray1);
        }

        public void ResetFakeDeck()
        {
            base.method_8("ResetFakeDeck", Array.Empty<object>());
        }

        public void SetInArena(bool inArena)
        {
            object[] objArray1 = new object[] { inArena };
            base.method_8("SetInArena", objArray1);
        }

        public void Show(bool showAll)
        {
            object[] objArray1 = new object[] { showAll };
            base.method_8("Show", objArray1);
        }

        public void ShowDeckCompleteEffects()
        {
            base.method_8("ShowDeckCompleteEffects", Array.Empty<object>());
        }

        public void ShowDeckEditingTipsIfNeeded()
        {
            base.method_8("ShowDeckEditingTipsIfNeeded", Array.Empty<object>());
        }

        public void ShowDeckHelpButtonIfNeeded()
        {
            base.method_8("ShowDeckHelpButtonIfNeeded", Array.Empty<object>());
        }

        public void ShowDeckHelper(DeckTrayDeckTileVisual tileToRemove, bool continueAfterReplace, bool replacingCard)
        {
            object[] objArray1 = new object[] { tileToRemove, continueAfterReplace, replacingCard };
            base.method_8("ShowDeckHelper", objArray1);
        }

        public void ShowFakeDeck(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowFakeDeck", objArray1);
        }

        public void TriggerCardCountUpdate()
        {
            base.method_8("TriggerCardCountUpdate", Array.Empty<object>());
        }

        public void UpdateCardList(bool updateHighlight, Actor animateFromActor)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean, Class272.Enum20.Class };
            object[] objArray1 = new object[] { updateHighlight, animateFromActor };
            base.method_9("UpdateCardList", enumArray1, objArray1);
        }

        public void UpdateCardList(string justChangedCardID, bool updateHighlight, Actor animateFromActor)
        {
            object[] objArray1 = new object[] { justChangedCardID, updateHighlight, animateFromActor };
            base.method_9("UpdateCardList", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public void UpdateCardList(EntityDef justChangedCardEntityDef, bool updateHighlight, Actor animateFromActor)
        {
            object[] objArray1 = new object[] { justChangedCardEntityDef, updateHighlight, animateFromActor };
            base.method_9("UpdateCardList", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void UpdateDeckCompleteHighlight()
        {
            base.method_8("UpdateDeckCompleteHighlight", Array.Empty<object>());
        }

        public static string ADD_CARD_TO_DECK_SOUND
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "DeckTrayCardListContent", "ADD_CARD_TO_DECK_SOUND");
            }
        }

        public static float CARD_MOVEMENT_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DeckTrayCardListContent", "CARD_MOVEMENT_TIME");
            }
        }

        public static float DECK_HELP_BUTTON_EMPTY_DECK_Y_LOCAL_POS
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DeckTrayCardListContent", "DECK_HELP_BUTTON_EMPTY_DECK_Y_LOCAL_POS");
            }
        }

        public static float DECK_HELP_BUTTON_Y_TILE_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DeckTrayCardListContent", "DECK_HELP_BUTTON_Y_TILE_OFFSET");
            }
        }

        public bool m_animating
        {
            get
            {
                return base.method_2<bool>("m_animating");
            }
        }

        public float m_cardHelpButtonHeight
        {
            get
            {
                return base.method_2<float>("m_cardHelpButtonHeight");
            }
        }

        public float m_cardTileHeight
        {
            get
            {
                return base.method_2<float>("m_cardTileHeight");
            }
        }

        public Vector3 m_cardTileOffset
        {
            get
            {
                return base.method_2<Vector3>("m_cardTileOffset");
            }
        }

        public List<DeckTrayDeckTileVisual> m_cardTiles
        {
            get
            {
                Class267<DeckTrayDeckTileVisual> class2 = base.method_3<Class267<DeckTrayDeckTileVisual>>("m_cardTiles");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_cardTileSlotLocalHeight
        {
            get
            {
                return base.method_2<float>("m_cardTileSlotLocalHeight");
            }
        }

        public Vector3 m_cardTileSlotLocalScaleVec3
        {
            get
            {
                return base.method_2<Vector3>("m_cardTileSlotLocalScaleVec3");
            }
        }

        public float m_deckCardBarFlareUpInterval
        {
            get
            {
                return base.method_2<float>("m_deckCardBarFlareUpInterval");
            }
        }

        public GameObject m_deckCompleteHighlight
        {
            get
            {
                return base.method_3<GameObject>("m_deckCompleteHighlight");
            }
        }

        public UIBButton m_deckHelpButton
        {
            get
            {
                return base.method_3<UIBButton>("m_deckHelpButton");
            }
        }

        public Triton.Game.Mapping.Notification m_deckHelpPopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("m_deckHelpPopup");
            }
        }

        public UIBButton m_deckTemplateHelpButton
        {
            get
            {
                return base.method_3<UIBButton>("m_deckTemplateHelpButton");
            }
        }

        public CollectionManager.DeckTag m_deckType
        {
            get
            {
                return base.method_2<CollectionManager.DeckTag>("m_deckType");
            }
        }

        public bool m_hasFinishedEntering
        {
            get
            {
                return base.method_2<bool>("m_hasFinishedEntering");
            }
        }

        public bool m_hasFinishedExiting
        {
            get
            {
                return base.method_2<bool>("m_hasFinishedExiting");
            }
        }

        public bool m_inArena
        {
            get
            {
                return base.method_2<bool>("m_inArena");
            }
        }

        public bool m_isShowingFakeDeck
        {
            get
            {
                return base.method_2<bool>("m_isShowingFakeDeck");
            }
        }

        public bool m_loading
        {
            get
            {
                return base.method_2<bool>("m_loading");
            }
        }

        public Vector3 m_originalLocalPosition
        {
            get
            {
                return base.method_2<Vector3>("m_originalLocalPosition");
            }
        }

        public GameObject m_phoneDeckTileBone
        {
            get
            {
                return base.method_3<GameObject>("m_phoneDeckTileBone");
            }
        }

        public UIBScrollable m_scrollbar
        {
            get
            {
                return base.method_3<UIBScrollable>("m_scrollbar");
            }
        }

        public CollectionDeck m_templateFakeDeck
        {
            get
            {
                return base.method_3<CollectionDeck>("m_templateFakeDeck");
            }
        }
    }
}

