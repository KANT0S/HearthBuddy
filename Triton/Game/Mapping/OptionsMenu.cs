namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("OptionsMenu")]
    public class OptionsMenu : MonoBehaviour
    {
        public OptionsMenu(IntPtr address) : this(address, "OptionsMenu")
        {
        }

        public OptionsMenu(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool CanShowCredits()
        {
            return base.method_11<bool>("CanShowCredits", Array.Empty<object>());
        }

        public static OptionsMenu Get()
        {
            return MonoClass.smethod_15<OptionsMenu>(TritonHs.MainAssemblyPath, "", "OptionsMenu", "Get", Array.Empty<object>());
        }

        public string GetCurrentGraphicsQuality()
        {
            return base.method_13("GetCurrentGraphicsQuality", Array.Empty<object>());
        }

        public GraphicsResolution GetCurrentGraphicsResolution()
        {
            return base.method_14<GraphicsResolution>("GetCurrentGraphicsResolution", Array.Empty<object>());
        }

        public string GetCurrentLanguage()
        {
            return base.method_13("GetCurrentLanguage", Array.Empty<object>());
        }

        public List<GraphicsResolution> GetGoodGraphicsResolution()
        {
            Class267<GraphicsResolution> class2 = base.method_14<Class267<GraphicsResolution>>("GetGoodGraphicsResolution", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void Hide(bool callHideHandler)
        {
            object[] objArray1 = new object[] { callHideHandler };
            base.method_8("Hide", objArray1);
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public void OnChangeLanguageConfirmationResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("OnChangeLanguageConfirmationResponse", objArray1);
        }

        public void OnCinematicButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCinematicButtonReleased", objArray1);
        }

        public void OnCreditsButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCreditsButtonReleased", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFatalError(FatalErrorMessage message, object userData)
        {
            object[] objArray1 = new object[] { message, userData };
            base.method_8("OnFatalError", objArray1);
        }

        public string OnGraphicsResolutionDropdownText(object val)
        {
            object[] objArray1 = new object[] { val };
            return base.method_13("OnGraphicsResolutionDropdownText", objArray1);
        }

        public void OnMasterVolumeRelease()
        {
            base.method_8("OnMasterVolumeRelease", Array.Empty<object>());
        }

        public void OnNewGraphicsQuality(object selection, object prevSelection)
        {
            object[] objArray1 = new object[] { selection, prevSelection };
            base.method_8("OnNewGraphicsQuality", objArray1);
        }

        public void OnNewGraphicsResolution(object selection, object prevSelection)
        {
            object[] objArray1 = new object[] { selection, prevSelection };
            base.method_8("OnNewGraphicsResolution", objArray1);
        }

        public void OnNewLanguage(object selection, object prevSelection)
        {
            object[] objArray1 = new object[] { selection, prevSelection };
            base.method_8("OnNewLanguage", objArray1);
        }

        public void OnNewMasterVolume(float newVolume)
        {
            object[] objArray1 = new object[] { newVolume };
            base.method_8("OnNewMasterVolume", objArray1);
        }

        public void OnNewMusicVolume(float newVolume)
        {
            object[] objArray1 = new object[] { newVolume };
            base.method_8("OnNewMusicVolume", objArray1);
        }

        public void OnToggleFullScreenCheckbox(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnToggleFullScreenCheckbox", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void ShowOrHide(bool showOrHide)
        {
            object[] objArray1 = new object[] { showOrHide };
            base.method_8("ShowOrHide", objArray1);
        }

        public string StringNameFromLocale(Locale locale)
        {
            object[] objArray1 = new object[] { locale };
            return base.method_13("StringNameFromLocale", objArray1);
        }

        public void ToggleBackgroundSound(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ToggleBackgroundSound", objArray1);
        }

        public void ToggleLanguagePackCheckbox(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ToggleLanguagePackCheckbox", objArray1);
        }

        public void ToggleNearbyPlayers(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ToggleNearbyPlayers", objArray1);
        }

        public void ToggleSpectatorOpenJoin(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ToggleSpectatorOpenJoin", objArray1);
        }

        public void UpdateCreditsUI()
        {
            base.method_8("UpdateCreditsUI", Array.Empty<object>());
        }

        public Vector3 HIDDEN_SCALE
        {
            get
            {
                return base.method_2<Vector3>("HIDDEN_SCALE");
            }
        }

        public CheckBox m_backgroundSound
        {
            get
            {
                return base.method_3<CheckBox>("m_backgroundSound");
            }
        }

        public UIBButton m_cinematicButton
        {
            get
            {
                return base.method_3<UIBButton>("m_cinematicButton");
            }
        }

        public UIBButton m_creditsButton
        {
            get
            {
                return base.method_3<UIBButton>("m_creditsButton");
            }
        }

        public CheckBox m_fullScreenCheckbox
        {
            get
            {
                return base.method_3<CheckBox>("m_fullScreenCheckbox");
            }
        }

        public List<GraphicsResolution> m_fullScreenResolutions
        {
            get
            {
                Class267<GraphicsResolution> class2 = base.method_3<Class267<GraphicsResolution>>("m_fullScreenResolutions");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_graphicsGroup
        {
            get
            {
                return base.method_3<GameObject>("m_graphicsGroup");
            }
        }

        public DropdownControl m_graphicsQuality
        {
            get
            {
                return base.method_3<DropdownControl>("m_graphicsQuality");
            }
        }

        public DropdownControl m_graphicsRes
        {
            get
            {
                return base.method_3<DropdownControl>("m_graphicsRes");
            }
        }

        public PegUIElement m_inputBlocker
        {
            get
            {
                return base.method_3<PegUIElement>("m_inputBlocker");
            }
        }

        public bool m_isShown
        {
            get
            {
                return base.method_2<bool>("m_isShown");
            }
        }

        public DropdownControl m_languageDropdown
        {
            get
            {
                return base.method_3<DropdownControl>("m_languageDropdown");
            }
        }

        public FontDef m_languageDropdownFont
        {
            get
            {
                return base.method_3<FontDef>("m_languageDropdownFont");
            }
        }

        public GameObject m_languageGroup
        {
            get
            {
                return base.method_3<GameObject>("m_languageGroup");
            }
        }

        public CheckBox m_languagePackCheckbox
        {
            get
            {
                return base.method_3<CheckBox>("m_languagePackCheckbox");
            }
        }

        public MultiSliceElement m_leftPane
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_leftPane");
            }
        }

        public ScrollbarControl m_masterVolume
        {
            get
            {
                return base.method_3<ScrollbarControl>("m_masterVolume");
            }
        }

        public MultiSliceElement m_middlePane
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_middlePane");
            }
        }

        public GameObject m_miscGroup
        {
            get
            {
                return base.method_3<GameObject>("m_miscGroup");
            }
        }

        public ScrollbarControl m_musicVolume
        {
            get
            {
                return base.method_3<ScrollbarControl>("m_musicVolume");
            }
        }

        public CheckBox m_nearbyPlayers
        {
            get
            {
                return base.method_3<CheckBox>("m_nearbyPlayers");
            }
        }

        public MultiSliceElement m_rightPane
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_rightPane");
            }
        }

        public GameObject m_soundGroup
        {
            get
            {
                return base.method_3<GameObject>("m_soundGroup");
            }
        }

        public CheckBox m_spectatorOpenJoinCheckbox
        {
            get
            {
                return base.method_3<CheckBox>("m_spectatorOpenJoinCheckbox");
            }
        }

        public UberText m_versionLabel
        {
            get
            {
                return base.method_3<UberText>("m_versionLabel");
            }
        }

        public Vector3 NORMAL_SCALE
        {
            get
            {
                return base.method_2<Vector3>("NORMAL_SCALE");
            }
        }
    }
}

