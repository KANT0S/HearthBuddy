namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DeckHelper")]
    public class DeckHelper : MonoBehaviour
    {
        public DeckHelper(IntPtr address) : this(address, "DeckHelper")
        {
        }

        public DeckHelper(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CleanOldChoices()
        {
            base.method_8("CleanOldChoices", Array.Empty<object>());
        }

        public void EndButtonClick(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("EndButtonClick", objArray1);
        }

        public void FinishHidePopup()
        {
            base.method_8("FinishHidePopup", Array.Empty<object>());
        }

        public void FireStateChangedEvent()
        {
            base.method_8("FireStateChangedEvent", Array.Empty<object>());
        }

        public static DeckHelper Get()
        {
            return MonoClass.smethod_15<DeckHelper>(TritonHs.MainAssemblyPath, "", "DeckHelper", "Get", Array.Empty<object>());
        }

        public void Hide(bool popnavigation)
        {
            object[] objArray1 = new object[] { popnavigation };
            base.method_8("Hide", objArray1);
        }

        public void HideInnkeeperPopup()
        {
            base.method_8("HideInnkeeperPopup", Array.Empty<object>());
        }

        public void InnkeeperPopupClicked(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("InnkeeperPopupClicked", objArray1);
        }

        public bool IsActive()
        {
            return base.method_11<bool>("IsActive", Array.Empty<object>());
        }

        public Actor LoadBestCardActor(EntityDef entityDef, TAG_PREMIUM premiumToUse, bool ghostCard)
        {
            object[] objArray1 = new object[] { entityDef, premiumToUse, ghostCard };
            return base.method_14<Actor>("LoadBestCardActor", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public bool OnNavigateBack()
        {
            return base.method_11<bool>("OnNavigateBack", Array.Empty<object>());
        }

        public void OnVisualOut(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            base.method_8("OnVisualOut", objArray1);
        }

        public void OnVisualOver(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            base.method_8("OnVisualOver", objArray1);
        }

        public void OnVisualRelease(Actor addCardActor, EntityDef cardToRemove)
        {
            object[] objArray1 = new object[] { addCardActor, cardToRemove };
            base.method_8("OnVisualRelease", objArray1);
        }

        public void PositionAndShowChoices()
        {
            base.method_8("PositionAndShowChoices", Array.Empty<object>());
        }

        public void Show(DeckTrayDeckTileVisual tileToRemove, bool continueAfterReplace, bool replacingCard)
        {
            object[] objArray1 = new object[] { tileToRemove, continueAfterReplace, replacingCard };
            base.method_8("Show", objArray1);
        }

        public void ShowInnkeeperPopup()
        {
            base.method_8("ShowInnkeeperPopup", Array.Empty<object>());
        }

        public void UpdateChoices()
        {
            base.method_8("UpdateChoices", Array.Empty<object>());
        }

        public static float INNKEEPER_POPUP_DURATION
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "DeckHelper", "INNKEEPER_POPUP_DURATION");
            }
        }

        public GameObject m_2choiceContainer
        {
            get
            {
                return base.method_3<GameObject>("m_2choiceContainer");
            }
        }

        public GameObject m_3choiceContainer
        {
            get
            {
                return base.method_3<GameObject>("m_3choiceContainer");
            }
        }

        public Vector3 m_cardSpacing
        {
            get
            {
                return base.method_2<Vector3>("m_cardSpacing");
            }
        }

        public EntityDef m_cardToRemove
        {
            get
            {
                return base.method_3<EntityDef>("m_cardToRemove");
            }
        }

        public List<Actor> m_choiceActors
        {
            get
            {
                Class267<Actor> class2 = base.method_3<Class267<Actor>>("m_choiceActors");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_continueAfterReplace
        {
            get
            {
                return base.method_2<bool>("m_continueAfterReplace");
            }
        }

        public Vector3 m_deckCardLocalScale
        {
            get
            {
                return base.method_2<Vector3>("m_deckCardLocalScale");
            }
        }

        public Vector3 m_innkeeperFullScale
        {
            get
            {
                return base.method_2<Vector3>("m_innkeeperFullScale");
            }
        }

        public UIBButton m_innkeeperPopup
        {
            get
            {
                return base.method_3<UIBButton>("m_innkeeperPopup");
            }
        }

        public bool m_innkeeperPopupShown
        {
            get
            {
                return base.method_2<bool>("m_innkeeperPopupShown");
            }
        }

        public PegUIElement m_inputBlocker
        {
            get
            {
                return base.method_3<PegUIElement>("m_inputBlocker");
            }
        }

        public UberText m_instructionText
        {
            get
            {
                return base.method_3<UberText>("m_instructionText");
            }
        }

        public GameObject m_replaceACardPane
        {
            get
            {
                return base.method_3<GameObject>("m_replaceACardPane");
            }
        }

        public Actor m_replaceCardActor
        {
            get
            {
                return base.method_3<Actor>("m_replaceCardActor");
            }
        }

        public GameObject m_replaceContainer
        {
            get
            {
                return base.method_3<GameObject>("m_replaceContainer");
            }
        }

        public UIBButton m_replaceDoneButton
        {
            get
            {
                return base.method_3<UIBButton>("m_replaceDoneButton");
            }
        }

        public bool m_ReplaceSingleTemplateCard
        {
            get
            {
                return base.method_2<bool>("m_ReplaceSingleTemplateCard");
            }
        }

        public GameObject m_rootObject
        {
            get
            {
                return base.method_3<GameObject>("m_rootObject");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }

        public GameObject m_suggestACardPane
        {
            get
            {
                return base.method_3<GameObject>("m_suggestACardPane");
            }
        }

        public UIBButton m_suggestDoneButton
        {
            get
            {
                return base.method_3<UIBButton>("m_suggestDoneButton");
            }
        }

        public DeckTrayDeckTileVisual m_tileToRemove
        {
            get
            {
                return base.method_3<DeckTrayDeckTileVisual>("m_tileToRemove");
            }
        }
    }
}

