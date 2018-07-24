namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CollectionDeckBoxVisual")]
    public class CollectionDeckBoxVisual : PegUIElement
    {
        public CollectionDeckBoxVisual(IntPtr address) : this(address, "CollectionDeckBoxVisual")
        {
        }

        public CollectionDeckBoxVisual(IntPtr address, string className) : base(address, className)
        {
        }

        public void AssignFromCollectionDeck(CollectionDeck deck)
        {
            object[] objArray1 = new object[] { deck };
            base.method_8("AssignFromCollectionDeck", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DisableButtonAnimation()
        {
            base.method_8("DisableButtonAnimation", Array.Empty<object>());
        }

        public void EnableButtonAnimation()
        {
            base.method_8("EnableButtonAnimation", Array.Empty<object>());
        }

        public CardDef GetCardDef()
        {
            return base.method_14<CardDef>("GetCardDef", Array.Empty<object>());
        }

        public TAG_CLASS GetClass()
        {
            return base.method_11<TAG_CLASS>("GetClass", Array.Empty<object>());
        }

        public long GetDeckID()
        {
            return base.method_11<long>("GetDeckID", Array.Empty<object>());
        }

        public UberText GetDeckNameText()
        {
            return base.method_14<UberText>("GetDeckNameText", Array.Empty<object>());
        }

        public FullDef GetFullDef()
        {
            return base.method_14<FullDef>("GetFullDef", Array.Empty<object>());
        }

        public string GetHeroCardID()
        {
            return base.method_13("GetHeroCardID", Array.Empty<object>());
        }

        public Texture GetHeroPortraitTexture()
        {
            return base.method_14<Texture>("GetHeroPortraitTexture", Array.Empty<object>());
        }

        public int GetPositionIndex()
        {
            return base.method_11<int>("GetPositionIndex", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void HideBanner()
        {
            base.method_8("HideBanner", Array.Empty<object>());
        }

        public void HideDeckName()
        {
            base.method_8("HideDeckName", Array.Empty<object>());
        }

        public bool IsLocked()
        {
            return base.method_11<bool>("IsLocked", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public bool IsValid()
        {
            return base.method_11<bool>("IsValid", Array.Empty<object>());
        }

        public void OnDeleteButtonConfirmationResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("OnDeleteButtonConfirmationResponse", objArray1);
        }

        public void OnDeleteButtonOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDeleteButtonOver", objArray1);
        }

        public void OnDeleteButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDeleteButtonPressed", objArray1);
        }

        public void OnDeleteButtonRollout(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDeleteButtonRollout", objArray1);
        }

        public void OnHeroFullDefLoaded(string cardID, FullDef def, object userData)
        {
            object[] objArray1 = new object[] { cardID, def, userData };
            base.method_8("OnHeroFullDefLoaded", objArray1);
        }

        public void OnOut(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOut", objArray1);
        }

        public void OnOutEvent()
        {
            base.method_8("OnOutEvent", Array.Empty<object>());
        }

        public void OnOver(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOver", objArray1);
        }

        public void OnOverEvent()
        {
            base.method_8("OnOverEvent", Array.Empty<object>());
        }

        public void OnPress()
        {
            base.method_8("OnPress", Array.Empty<object>());
        }

        public void OnPressEvent()
        {
            base.method_8("OnPressEvent", Array.Empty<object>());
        }

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public void OnReleaseEvent()
        {
            base.method_8("OnReleaseEvent", Array.Empty<object>());
        }

        public void OnScaleComplete(OnScaleFinishedCallbackData callbackData)
        {
            object[] objArray1 = new object[] { callbackData };
            base.method_8("OnScaleComplete", objArray1);
        }

        public void OnScaledDown(object callbackData)
        {
            object[] objArray1 = new object[] { callbackData };
            base.method_8("OnScaledDown", objArray1);
        }

        public void PlayPopAnimation(string animationName)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { animationName };
            base.method_9("PlayPopAnimation", enumArray1, objArray1);
        }

        public void PlayPopDownAnimation()
        {
            base.method_9("PlayPopDownAnimation", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void PlayPopDownAnimationImmediately()
        {
            base.method_9("PlayPopDownAnimationImmediately", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void PlayPopUpAnimation()
        {
            base.method_9("PlayPopUpAnimation", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void PlayScaleDownAnimation()
        {
            base.method_9("PlayScaleDownAnimation", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void PlayScaleUpAnimation()
        {
            base.method_9("PlayScaleUpAnimation", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void ScaleDownComplete(OnScaleFinishedCallbackData onScaledDownData)
        {
            object[] objArray1 = new object[] { onScaledDownData };
            base.method_8("ScaleDownComplete", objArray1);
        }

        public void ScaleUpNow(OnScaleFinishedCallbackData readyToScaleUpData)
        {
            object[] objArray1 = new object[] { readyToScaleUpData };
            base.method_8("ScaleUpNow", objArray1);
        }

        public void SetBasicSetProgress(TAG_CLASS classTag)
        {
            object[] objArray1 = new object[] { classTag };
            base.method_8("SetBasicSetProgress", objArray1);
        }

        public void SetClassDisplay(TAG_CLASS classTag)
        {
            object[] objArray1 = new object[] { classTag };
            base.method_8("SetClassDisplay", objArray1);
        }

        public void SetDeckID(long id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("SetDeckID", objArray1);
        }

        public void SetDeckName(string deckName)
        {
            object[] objArray1 = new object[] { deckName };
            base.method_8("SetDeckName", objArray1);
        }

        public void SetHeroCardID(string heroCardID)
        {
            object[] objArray1 = new object[] { heroCardID };
            base.method_8("SetHeroCardID", objArray1);
        }

        public void SetHighlightState(ActorStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("SetHighlightState", objArray1);
        }

        public void SetIsLocked(bool isLocked)
        {
            object[] objArray1 = new object[] { isLocked };
            base.method_8("SetIsLocked", objArray1);
        }

        public void SetIsValid(bool isValid)
        {
            object[] objArray1 = new object[] { isValid };
            base.method_8("SetIsValid", objArray1);
        }

        public void SetOriginalButtonPosition()
        {
            base.method_8("SetOriginalButtonPosition", Array.Empty<object>());
        }

        public void SetPortrait(Material portraitMaterial)
        {
            object[] objArray1 = new object[] { portraitMaterial };
            base.method_8("SetPortrait", objArray1);
        }

        public void SetPositionIndex(int idx)
        {
            object[] objArray1 = new object[] { idx };
            base.method_8("SetPositionIndex", objArray1);
        }

        public void SetShowGlow(bool showGlow)
        {
            object[] objArray1 = new object[] { showGlow };
            base.method_8("SetShowGlow", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void ShowBanner()
        {
            base.method_8("ShowBanner", Array.Empty<object>());
        }

        public void ShowDeckName()
        {
            base.method_8("ShowDeckName", Array.Empty<object>());
        }

        public void ShowDeleteButton(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowDeleteButton", objArray1);
        }

        public void ShowEditDecal(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowEditDecal", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public static float ADJUST_Y_OFFSET_ANIM_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CollectionDeckBoxVisual", "ADJUST_Y_OFFSET_ANIM_TIME");
            }
        }

        public static Color BASIC_SET_COLOR_IN_PROGRESS
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "CollectionDeckBoxVisual", "BASIC_SET_COLOR_IN_PROGRESS");
            }
        }

        public static float BUTTON_POP_SPEED
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CollectionDeckBoxVisual", "BUTTON_POP_SPEED");
            }
        }

        public static string DECKBOX_POPDOWN_ANIM_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "CollectionDeckBoxVisual", "DECKBOX_POPDOWN_ANIM_NAME");
            }
        }

        public static string DECKBOX_POPUP_ANIM_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "CollectionDeckBoxVisual", "DECKBOX_POPUP_ANIM_NAME");
            }
        }

        public static float DECKBOX_SCALE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CollectionDeckBoxVisual", "DECKBOX_SCALE");
            }
        }

        public bool m_animateButtonPress
        {
            get
            {
                return base.method_2<bool>("m_animateButtonPress");
            }
        }

        public Material m_bannerMaterial
        {
            get
            {
                return base.method_3<Material>("m_bannerMaterial");
            }
        }

        public CustomDeckBones m_bones
        {
            get
            {
                return base.method_3<CustomDeckBones>("m_bones");
            }
        }

        public CardDef m_cardDef
        {
            get
            {
                return base.method_3<CardDef>("m_cardDef");
            }
        }

        public int m_classBannerMaterialIndex
        {
            get
            {
                return base.method_2<int>("m_classBannerMaterialIndex");
            }
        }

        public Material m_classIconMaterial
        {
            get
            {
                return base.method_3<Material>("m_classIconMaterial");
            }
        }

        public int m_classIconMaterialIndex
        {
            get
            {
                return base.method_2<int>("m_classIconMaterialIndex");
            }
        }

        public GameObject m_classObject
        {
            get
            {
                return base.method_3<GameObject>("m_classObject");
            }
        }

        public Transform m_customDeckTransform
        {
            get
            {
                return base.method_3<Transform>("m_customDeckTransform");
            }
        }

        public long m_deckID
        {
            get
            {
                return base.method_2<long>("m_deckID");
            }
        }

        public UberText m_deckName
        {
            get
            {
                return base.method_3<UberText>("m_deckName");
            }
        }

        public PegUIElement m_deleteButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_deleteButton");
            }
        }

        public GameObject m_editDecal
        {
            get
            {
                return base.method_3<GameObject>("m_editDecal");
            }
        }

        public EntityDef m_entityDef
        {
            get
            {
                return base.method_3<EntityDef>("m_entityDef");
            }
        }

        public FullDef m_fullDef
        {
            get
            {
                return base.method_3<FullDef>("m_fullDef");
            }
        }

        public string m_heroCardID
        {
            get
            {
                return base.method_4("m_heroCardID");
            }
        }

        public GameObject m_highlight
        {
            get
            {
                return base.method_3<GameObject>("m_highlight");
            }
        }

        public HighlightState m_highlightState
        {
            get
            {
                return base.method_3<HighlightState>("m_highlightState");
            }
        }

        public GameObject m_invalidDeckX
        {
            get
            {
                return base.method_3<GameObject>("m_invalidDeckX");
            }
        }

        public bool m_isLocked
        {
            get
            {
                return base.method_2<bool>("m_isLocked");
            }
        }

        public bool m_isPoppedUp
        {
            get
            {
                return base.method_2<bool>("m_isPoppedUp");
            }
        }

        public bool m_isShown
        {
            get
            {
                return base.method_2<bool>("m_isShown");
            }
        }

        public bool m_isValid
        {
            get
            {
                return base.method_2<bool>("m_isValid");
            }
        }

        public GameObject m_labelGradient
        {
            get
            {
                return base.method_3<GameObject>("m_labelGradient");
            }
        }

        public GameObject m_lockedDeckVisuals
        {
            get
            {
                return base.method_3<GameObject>("m_lockedDeckVisuals");
            }
        }

        public GameObject m_normalDeckVisuals
        {
            get
            {
                return base.method_3<GameObject>("m_normalDeckVisuals");
            }
        }

        public Vector3 m_originalButtonPosition
        {
            get
            {
                return base.method_2<Vector3>("m_originalButtonPosition");
            }
        }

        public int m_portraitMaterialIndex
        {
            get
            {
                return base.method_2<int>("m_portraitMaterialIndex");
            }
        }

        public GameObject m_portraitObject
        {
            get
            {
                return base.method_3<GameObject>("m_portraitObject");
            }
        }

        public int m_positionIndex
        {
            get
            {
                return base.method_2<int>("m_positionIndex");
            }
        }

        public GameObject m_pressedBone
        {
            get
            {
                return base.method_3<GameObject>("m_pressedBone");
            }
        }

        public UberText m_setProgressLabel
        {
            get
            {
                return base.method_3<UberText>("m_setProgressLabel");
            }
        }

        public bool m_showGlow
        {
            get
            {
                return base.method_2<bool>("m_showGlow");
            }
        }

        public TooltipZone m_tooltipZone
        {
            get
            {
                return base.method_3<TooltipZone>("m_tooltipZone");
            }
        }

        public bool m_wasTouchModeEnabled
        {
            get
            {
                return base.method_2<bool>("m_wasTouchModeEnabled");
            }
        }

        public static Vector3 POPPED_DOWN_LOCAL_POS
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "CollectionDeckBoxVisual", "POPPED_DOWN_LOCAL_POS");
            }
        }

        public static float POPPED_UP_LOCAL_Z
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CollectionDeckBoxVisual", "POPPED_UP_LOCAL_Z");
            }
        }

        public static float SCALE_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CollectionDeckBoxVisual", "SCALE_TIME");
            }
        }

        public static Vector3 SCALED_DOWN_LOCAL_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "CollectionDeckBoxVisual", "SCALED_DOWN_LOCAL_SCALE");
            }
        }

        public static float SCALED_DOWN_LOCAL_Y_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CollectionDeckBoxVisual", "SCALED_DOWN_LOCAL_Y_OFFSET");
            }
        }

        public Vector3 SCALED_UP_DECK_OFFSET
        {
            get
            {
                return base.method_2<Vector3>("SCALED_UP_DECK_OFFSET");
            }
        }

        public Vector3 SCALED_UP_LOCAL_SCALE
        {
            get
            {
                return base.method_2<Vector3>("SCALED_UP_LOCAL_SCALE");
            }
        }

        public static float SCALED_UP_LOCAL_Y_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CollectionDeckBoxVisual", "SCALED_UP_LOCAL_Y_OFFSET");
            }
        }

        [Attribute38("CollectionDeckBoxVisual.OnPopAnimationFinishedCallbackData")]
        public class OnPopAnimationFinishedCallbackData : MonoClass
        {
            public OnPopAnimationFinishedCallbackData(IntPtr address) : this(address, "OnPopAnimationFinishedCallbackData")
            {
            }

            public OnPopAnimationFinishedCallbackData(IntPtr address, string className) : base(address, className)
            {
            }

            public string m_animationName
            {
                get
                {
                    return base.method_4("m_animationName");
                }
            }

            public object m_callbackData
            {
                get
                {
                    return base.method_3<object>("m_callbackData");
                }
            }
        }

        [Attribute38("CollectionDeckBoxVisual.OnScaleFinishedCallbackData")]
        public class OnScaleFinishedCallbackData : MonoClass
        {
            public OnScaleFinishedCallbackData(IntPtr address) : this(address, "OnScaleFinishedCallbackData")
            {
            }

            public OnScaleFinishedCallbackData(IntPtr address, string className) : base(address, className)
            {
            }

            public object m_callbackData
            {
                get
                {
                    return base.method_3<object>("m_callbackData");
                }
            }
        }
    }
}

