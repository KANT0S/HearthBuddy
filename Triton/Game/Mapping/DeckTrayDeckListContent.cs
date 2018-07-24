namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DeckTrayDeckListContent")]
    public class DeckTrayDeckListContent : DeckTrayContent
    {
        public DeckTrayDeckListContent(IntPtr address) : this(address, "DeckTrayDeckListContent")
        {
        }

        public DeckTrayDeckListContent(IntPtr address, string className) : base(address, className)
        {
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

        public void CancelRenameEditingDeck()
        {
            base.method_8("CancelRenameEditingDeck", Array.Empty<object>());
        }

        public bool CanShowNewDeckButton()
        {
            return base.method_11<bool>("CanShowNewDeckButton", Array.Empty<object>());
        }

        public void CreateNewDeckCancelled()
        {
            base.method_8("CreateNewDeckCancelled", Array.Empty<object>());
        }

        public void CreateNewDeckFromUserSelection(TAG_CLASS heroClass, string heroCardID, string customDeckName)
        {
            object[] objArray1 = new object[] { heroClass, heroCardID, customDeckName };
            base.method_8("CreateNewDeckFromUserSelection", objArray1);
        }

        public void CreateTraySections()
        {
            base.method_8("CreateTraySections", Array.Empty<object>());
        }

        public void DeleteDeck(long deckID)
        {
            object[] objArray1 = new object[] { deckID };
            base.method_8("DeleteDeck", objArray1);
        }

        public void DeleteEditingDeck()
        {
            base.method_8("DeleteEditingDeck", Array.Empty<object>());
        }

        public void DeleteQueuedDecks(bool force)
        {
            object[] objArray1 = new object[] { force };
            base.method_8("DeleteQueuedDecks", objArray1);
        }

        public void EndCreateNewDeck(bool newDeck)
        {
            object[] objArray1 = new object[] { newDeck };
            base.method_8("EndCreateNewDeck", objArray1);
        }

        public void FinishRenamingEditingDeck(string newDeckName)
        {
            object[] objArray1 = new object[] { newDeckName };
            base.method_8("FinishRenamingEditingDeck", objArray1);
        }

        public void FireBusyWithDeckEvent(bool busy)
        {
            object[] objArray1 = new object[] { busy };
            base.method_8("FireBusyWithDeckEvent", objArray1);
        }

        public void FireDeckCountChangedEvent()
        {
            base.method_8("FireDeckCountChangedEvent", Array.Empty<object>());
        }

        public TraySection GetExistingTrayFromDeck(long deckID)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I8 };
            object[] objArray1 = new object[] { deckID };
            return base.method_15<TraySection>("GetExistingTrayFromDeck", enumArray1, objArray1);
        }

        public TraySection GetExistingTrayFromDeck(CollectionDeck deck)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { deck };
            return base.method_15<TraySection>("GetExistingTrayFromDeck", enumArray1, objArray1);
        }

        public TraySection GetLastUnusedTraySection()
        {
            return base.method_14<TraySection>("GetLastUnusedTraySection", Array.Empty<object>());
        }

        public TraySection GetLastUsedTraySection()
        {
            return base.method_14<TraySection>("GetLastUsedTraySection", Array.Empty<object>());
        }

        public Vector3 GetNewDeckButtonPosition()
        {
            return base.method_11<Vector3>("GetNewDeckButtonPosition", Array.Empty<object>());
        }

        public int GetTotalDeckBoxesInUse()
        {
            return base.method_11<int>("GetTotalDeckBoxesInUse", Array.Empty<object>());
        }

        public void HideTraySectionsNotInBounds(Bounds bounds)
        {
            object[] objArray1 = new object[] { bounds };
            base.method_8("HideTraySectionsNotInBounds", objArray1);
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public void InitializeTraysFromDecks()
        {
            base.method_8("InitializeTraysFromDecks", Array.Empty<object>());
        }

        public bool IsDeletingDecks()
        {
            return base.method_11<bool>("IsDeletingDecks", Array.Empty<object>());
        }

        public bool IsEditingCards()
        {
            return base.method_11<bool>("IsEditingCards", Array.Empty<object>());
        }

        public bool IsWaitingToDeleteDeck()
        {
            return base.method_11<bool>("IsWaitingToDeleteDeck", Array.Empty<object>());
        }

        public int NumDecksToDelete()
        {
            return base.method_11<int>("NumDecksToDelete", Array.Empty<object>());
        }

        public void OnBoxTransitionFinished(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnBoxTransitionFinished", objArray1);
        }

        public void OnDeckBoxVisualOut(CollectionDeckBoxVisual deckBox)
        {
            object[] objArray1 = new object[] { deckBox };
            base.method_8("OnDeckBoxVisualOut", objArray1);
        }

        public void OnDeckBoxVisualOver(CollectionDeckBoxVisual deckBox)
        {
            object[] objArray1 = new object[] { deckBox };
            base.method_8("OnDeckBoxVisualOver", objArray1);
        }

        public void OnDeckBoxVisualPress(CollectionDeckBoxVisual deckBox)
        {
            object[] objArray1 = new object[] { deckBox };
            base.method_8("OnDeckBoxVisualPress", objArray1);
        }

        public void OnDeckBoxVisualRelease(TraySection traySection)
        {
            object[] objArray1 = new object[] { traySection };
            base.method_8("OnDeckBoxVisualRelease", objArray1);
        }

        public void OnDeckDeleted(long deckID)
        {
            object[] objArray1 = new object[] { deckID };
            base.method_8("OnDeckDeleted", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDrawGizmos()
        {
            base.method_8("OnDrawGizmos", Array.Empty<object>());
        }

        public void OnFavoriteHeroChanged(TAG_CLASS heroClass, NetCache.CardDefinition favoriteHero, object userData)
        {
            object[] objArray1 = new object[] { heroClass, favoriteHero, userData };
            base.method_8("OnFavoriteHeroChanged", objArray1);
        }

        public void OnNewDeckButtonPress()
        {
            base.method_8("OnNewDeckButtonPress", Array.Empty<object>());
        }

        public void OnTaggedDeckChanged(CollectionManager.DeckTag tag, CollectionDeck newDeck, CollectionDeck oldDeck, bool isNewDeck)
        {
            object[] objArray1 = new object[] { tag, newDeck, oldDeck, isNewDeck };
            base.method_8("OnTaggedDeckChanged", objArray1);
        }

        public bool PostAnimateContentExit()
        {
            return base.method_11<bool>("PostAnimateContentExit", Array.Empty<object>());
        }

        public bool PreAnimateContentEntrance()
        {
            return base.method_11<bool>("PreAnimateContentEntrance", Array.Empty<object>());
        }

        public bool PreAnimateContentExit()
        {
            return base.method_11<bool>("PreAnimateContentExit", Array.Empty<object>());
        }

        public void RenameCurrentlyEditingDeck()
        {
            base.method_8("RenameCurrentlyEditingDeck", Array.Empty<object>());
        }

        public void SetEditingTraySection(int index)
        {
            object[] objArray1 = new object[] { index };
            base.method_8("SetEditingTraySection", objArray1);
        }

        public void StartCreateNewDeck()
        {
            base.method_8("StartCreateNewDeck", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateAllTrays(bool immediate)
        {
            object[] objArray1 = new object[] { immediate };
            base.method_8("UpdateAllTrays", objArray1);
        }

        public void UpdateDeckName(string deckName)
        {
            object[] objArray1 = new object[] { deckName };
            base.method_8("UpdateDeckName", objArray1);
        }

        public int UpdateDeckTrayVisuals()
        {
            return base.method_11<int>("UpdateDeckTrayVisuals", Array.Empty<object>());
        }

        public void UpdateEditingDeckBoxVisual(string heroCardId)
        {
            object[] objArray1 = new object[] { heroCardId };
            base.method_8("UpdateEditingDeckBoxVisual", objArray1);
        }

        public void UpdateNewDeckButton(TraySection setNewDeckButtonPosition)
        {
            object[] objArray1 = new object[] { setNewDeckButtonPosition };
            base.method_8("UpdateNewDeckButton", objArray1);
        }

        public bool UpdateNewDeckButtonPosition(TraySection setNewDeckButtonPosition)
        {
            object[] objArray1 = new object[] { setNewDeckButtonPosition };
            return base.method_11<bool>("UpdateNewDeckButtonPosition", objArray1);
        }

        public CollectionDeck UpdateRenamingEditingDeck(string newDeckName)
        {
            object[] objArray1 = new object[] { newDeckName };
            return base.method_14<CollectionDeck>("UpdateRenamingEditingDeck", objArray1);
        }

        public static float DECK_BUTTON_ROTATION_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DeckTrayDeckListContent", "DECK_BUTTON_ROTATION_TIME");
            }
        }

        public Vector3 DeckButtonOffset
        {
            get
            {
                return base.method_11<Vector3>("get_DeckButtonOffset", Array.Empty<object>());
            }
        }

        public static float DELETE_DECK_ANIM_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DeckTrayDeckListContent", "DELETE_DECK_ANIM_TIME");
            }
        }

        public bool m_animatingExit
        {
            get
            {
                return base.method_2<bool>("m_animatingExit");
            }
        }

        public int m_centeringDeckList
        {
            get
            {
                return base.method_2<int>("m_centeringDeckList");
            }
        }

        public Vector3 m_deckButtonOffset
        {
            get
            {
                return base.method_2<Vector3>("m_deckButtonOffset");
            }
        }

        public Transform m_deckEditTopPos
        {
            get
            {
                return base.method_3<Transform>("m_deckEditTopPos");
            }
        }

        public string m_deckInfoActorPrefab
        {
            get
            {
                return base.method_4("m_deckInfoActorPrefab");
            }
        }

        public CollectionDeckInfo m_deckInfoTooltip
        {
            get
            {
                return base.method_3<CollectionDeckInfo>("m_deckInfoTooltip");
            }
        }

        public GameObject m_deckInfoTooltipBone
        {
            get
            {
                return base.method_3<GameObject>("m_deckInfoTooltipBone");
            }
        }

        public List<long> m_decksToDelete
        {
            get
            {
                Class266<long> class2 = base.method_3<Class266<long>>("m_decksToDelete");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_deletingDecks
        {
            get
            {
                return base.method_2<bool>("m_deletingDecks");
            }
        }

        public TraySection m_editingTraySection
        {
            get
            {
                return base.method_3<TraySection>("m_editingTraySection");
            }
        }

        public bool m_initialized
        {
            get
            {
                return base.method_2<bool>("m_initialized");
            }
        }

        public CollectionNewDeckButton m_newDeckButton
        {
            get
            {
                return base.method_3<CollectionNewDeckButton>("m_newDeckButton");
            }
        }

        public GameObject m_newDeckButtonContainer
        {
            get
            {
                return base.method_3<GameObject>("m_newDeckButtonContainer");
            }
        }

        public TraySection m_newlyCreatedTraySection
        {
            get
            {
                return base.method_3<TraySection>("m_newlyCreatedTraySection");
            }
        }

        public string m_previousDeckName
        {
            get
            {
                return base.method_4("m_previousDeckName");
            }
        }

        public UIBScrollable m_scrollbar
        {
            get
            {
                return base.method_3<UIBScrollable>("m_scrollbar");
            }
        }

        public TraySection m_traySectionPrefab
        {
            get
            {
                return base.method_3<TraySection>("m_traySectionPrefab");
            }
        }

        public List<TraySection> m_traySections
        {
            get
            {
                Class267<TraySection> class2 = base.method_3<Class267<TraySection>>("m_traySections");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Transform m_traySectionStartPos
        {
            get
            {
                return base.method_3<Transform>("m_traySectionStartPos");
            }
        }

        public bool m_waitingToDeleteDeck
        {
            get
            {
                return base.method_2<bool>("m_waitingToDeleteDeck");
            }
        }

        public bool m_wasTouchModeEnabled
        {
            get
            {
                return base.method_2<bool>("m_wasTouchModeEnabled");
            }
        }

        public static int MAX_NUM_DECKBOXES_AVAILABLE
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "DeckTrayDeckListContent", "MAX_NUM_DECKBOXES_AVAILABLE");
            }
        }

        public static int NUM_DECKBOXES_TO_DISPLAY
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "DeckTrayDeckListContent", "NUM_DECKBOXES_TO_DISPLAY");
            }
        }

        public static float TIME_BETWEEN_TRAY_DOOR_ANIMS
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DeckTrayDeckListContent", "TIME_BETWEEN_TRAY_DOOR_ANIMS");
            }
        }
    }
}

