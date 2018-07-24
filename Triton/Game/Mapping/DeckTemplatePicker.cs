namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("DeckTemplatePicker")]
    public class DeckTemplatePicker : MonoBehaviour
    {
        public DeckTemplatePicker(IntPtr address) : this(address, "DeckTemplatePicker")
        {
        }

        public DeckTemplatePicker(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ChooseRecipeAndFillInCards()
        {
            base.method_8("ChooseRecipeAndFillInCards", Array.Empty<object>());
        }

        public void FillDeckWithTemplate(CollectionManager.TemplateDeck tplDeck)
        {
            object[] objArray1 = new object[] { tplDeck };
            base.method_8("FillDeckWithTemplate", objArray1);
        }

        public void FillWithCustomDeck()
        {
            base.method_8("FillWithCustomDeck", Array.Empty<object>());
        }

        public void FireOnTemplateDeckChosenEvent()
        {
            base.method_8("FireOnTemplateDeckChosenEvent", Array.Empty<object>());
        }

        public bool IsShowingBottomPanel()
        {
            return base.method_11<bool>("IsShowingBottomPanel", Array.Empty<object>());
        }

        public bool IsShowingPacks()
        {
            return base.method_11<bool>("IsShowingPacks", Array.Empty<object>());
        }

        public void OnBackButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnBackButtonPressed", objArray1);
        }

        public bool OnNavigateBack()
        {
            return base.method_11<bool>("OnNavigateBack", Array.Empty<object>());
        }

        public void OnTrayToggled(bool shown)
        {
            object[] objArray1 = new object[] { shown };
            base.method_8("OnTrayToggled", objArray1);
        }

        public void SelectButtonWithIndex(int index)
        {
            object[] objArray1 = new object[] { index };
            base.method_8("SelectButtonWithIndex", objArray1);
        }

        public void SelectCustomDeckButton(bool preselect)
        {
            object[] objArray1 = new object[] { preselect };
            base.method_8("SelectCustomDeckButton", objArray1);
        }

        public void SetDeckClass(TAG_CLASS deckClass)
        {
            object[] objArray1 = new object[] { deckClass };
            base.method_8("SetDeckClass", objArray1);
        }

        public void SetupTemplateButtons(CollectionManager.TemplateDeck refDeck)
        {
            object[] objArray1 = new object[] { refDeck };
            base.method_8("SetupTemplateButtons", objArray1);
        }

        public void ShowBottomPanel(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowBottomPanel", objArray1);
        }

        public GameObject m_bottomPanel
        {
            get
            {
                return base.method_3<GameObject>("m_bottomPanel");
            }
        }

        public float m_bottomPanelAnimateTime
        {
            get
            {
                return base.method_2<float>("m_bottomPanelAnimateTime");
            }
        }

        public Vector3 m_bottomPanelHideOffset
        {
            get
            {
                return base.method_2<Vector3>("m_bottomPanelHideOffset");
            }
        }

        public float m_bottomPanelSlideInWaitDelay
        {
            get
            {
                return base.method_2<float>("m_bottomPanelSlideInWaitDelay");
            }
        }

        public PlayButton m_chooseButton
        {
            get
            {
                return base.method_3<PlayButton>("m_chooseButton");
            }
        }

        public TAG_CLASS m_currentSelectedClass
        {
            get
            {
                return base.method_2<TAG_CLASS>("m_currentSelectedClass");
            }
        }

        public CollectionManager.TemplateDeck m_currentSelectedDeck
        {
            get
            {
                return base.method_3<CollectionManager.TemplateDeck>("m_currentSelectedDeck");
            }
        }

        public CollectionManager.TemplateDeck m_customDeck
        {
            get
            {
                return base.method_3<CollectionManager.TemplateDeck>("m_customDeck");
            }
        }

        public DeckTemplatePickerButton m_customDeckButton
        {
            get
            {
                return base.method_3<DeckTemplatePickerButton>("m_customDeckButton");
            }
        }

        public TransformProps m_customDeckInitialPosition
        {
            get
            {
                return base.method_3<TransformProps>("m_customDeckInitialPosition");
            }
        }

        public UberText m_deckTemplateDescription
        {
            get
            {
                return base.method_3<UberText>("m_deckTemplateDescription");
            }
        }

        public UberText m_deckTemplatePhoneName
        {
            get
            {
                return base.method_3<UberText>("m_deckTemplatePhoneName");
            }
        }

        public Transform m_ghostCardTipBone
        {
            get
            {
                return base.method_3<Transform>("m_ghostCardTipBone");
            }
        }

        public Vector3 m_offscreenPackOffset
        {
            get
            {
                return base.method_2<Vector3>("m_offscreenPackOffset");
            }
        }

        public Vector3 m_origBottomPanelPos
        {
            get
            {
                return base.method_2<Vector3>("m_origBottomPanelPos");
            }
        }

        public float m_packAnimInTime
        {
            get
            {
                return base.method_2<float>("m_packAnimInTime");
            }
        }

        public float m_packAnimOutTime
        {
            get
            {
                return base.method_2<float>("m_packAnimOutTime");
            }
        }

        public bool m_packsShown
        {
            get
            {
                return base.method_2<bool>("m_packsShown");
            }
        }

        public GameObject m_pageHeader
        {
            get
            {
                return base.method_3<GameObject>("m_pageHeader");
            }
        }

        public UberText m_pageHeaderText
        {
            get
            {
                return base.method_3<UberText>("m_pageHeaderText");
            }
        }

        public UIBButton m_phoneBackButton
        {
            get
            {
                return base.method_3<UIBButton>("m_phoneBackButton");
            }
        }

        public DeckTemplatePhoneTray m_phoneTray
        {
            get
            {
                return base.method_3<DeckTemplatePhoneTray>("m_phoneTray");
            }
        }

        public UIBObjectSpacing m_pickerButtonRoot
        {
            get
            {
                return base.method_3<UIBObjectSpacing>("m_pickerButtonRoot");
            }
        }

        public List<DeckTemplatePickerButton> m_pickerButtons
        {
            get
            {
                Class267<DeckTemplatePickerButton> class2 = base.method_3<Class267<DeckTemplatePickerButton>>("m_pickerButtons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public DeckTemplatePickerButton m_pickerButtonTpl
        {
            get
            {
                return base.method_3<DeckTemplatePickerButton>("m_pickerButtonTpl");
            }
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }

        public bool m_showingBottomPanel
        {
            get
            {
                return base.method_2<bool>("m_showingBottomPanel");
            }
        }
    }
}

