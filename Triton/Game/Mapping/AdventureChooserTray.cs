namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdventureChooserTray")]
    public class AdventureChooserTray : MonoBehaviour
    {
        public AdventureChooserTray(IntPtr address) : this(address, "AdventureChooserTray")
        {
        }

        public AdventureChooserTray(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static void BackToMainMenu()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "AdventureChooserTray", "BackToMainMenu");
        }

        public void ButtonExpanded(AdventureChooserButton button, bool expand)
        {
            object[] objArray1 = new object[] { button, expand };
            base.method_8("ButtonExpanded", objArray1);
        }

        public void ButtonModeSelected(AdventureChooserSubButton btn)
        {
            object[] objArray1 = new object[] { btn };
            base.method_8("ButtonModeSelected", objArray1);
        }

        public void ChangeSubScene()
        {
            base.method_8("ChangeSubScene", Array.Empty<object>());
        }

        public void CreateAdventureChooserButton(AdventureDef advDef)
        {
            object[] objArray1 = new object[] { advDef };
            base.method_8("CreateAdventureChooserButton", objArray1);
        }

        public void CreateAdventureChooserDescriptionFromPrefab(AdventureDbId adventureId, AdventureSubDef subDef, bool active)
        {
            object[] objArray1 = new object[] { adventureId, subDef, active };
            base.method_8("CreateAdventureChooserDescriptionFromPrefab", objArray1);
        }

        public AdventureChooserDescription GetAdventureChooserDescription(AdventureDbId adventureId, AdventureModeDbId modeId)
        {
            object[] objArray1 = new object[] { adventureId, modeId };
            return base.method_14<AdventureChooserDescription>("GetAdventureChooserDescription", objArray1);
        }

        public void OnAdventureButtonToggled(AdventureChooserButton btn, bool toggled, int index)
        {
            object[] objArray1 = new object[] { btn, toggled, index };
            base.method_8("OnAdventureButtonToggled", objArray1);
        }

        public void OnBackButton()
        {
            base.method_8("OnBackButton", Array.Empty<object>());
        }

        public void OnBoxTransitionFinished(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnBoxTransitionFinished", objArray1);
        }

        public void OnButtonVisualUpdated()
        {
            base.method_8("OnButtonVisualUpdated", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public static bool OnNavigateBack()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "AdventureChooserTray", "OnNavigateBack", Array.Empty<object>());
        }

        public void OnSelectedModeChange(AdventureDbId adventureId, AdventureModeDbId modeId)
        {
            object[] objArray1 = new object[] { adventureId, modeId };
            base.method_8("OnSelectedModeChange", objArray1);
        }

        public void SetTitleText(AdventureDbId adventureId, AdventureModeDbId modeId)
        {
            object[] objArray1 = new object[] { adventureId, modeId };
            base.method_8("SetTitleText", objArray1);
        }

        public void ShowDisabledAdventureModeRequirementsWarning()
        {
            base.method_8("ShowDisabledAdventureModeRequirementsWarning", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateChooseButton(AdventureDbId adventureId, AdventureModeDbId modeId)
        {
            object[] objArray1 = new object[] { adventureId, modeId };
            base.method_8("UpdateChooseButton", objArray1);
        }

        public float ButtonOffset
        {
            get
            {
                return base.method_11<float>("get_ButtonOffset", Array.Empty<object>());
            }
        }

        public List<AdventureChooserButton> m_AdventureButtons
        {
            get
            {
                Class267<AdventureChooserButton> class2 = base.method_3<Class267<AdventureChooserButton>>("m_AdventureButtons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_AttemptedLoad
        {
            get
            {
                return base.method_2<bool>("m_AttemptedLoad");
            }
        }

        public UIBButton m_BackButton
        {
            get
            {
                return base.method_3<UIBButton>("m_BackButton");
            }
        }

        public float m_ButtonOffset
        {
            get
            {
                return base.method_2<float>("m_ButtonOffset");
            }
        }

        public PlayButton m_ChooseButton
        {
            get
            {
                return base.method_3<PlayButton>("m_ChooseButton");
            }
        }

        public GameObject m_ChooseElementsContainer
        {
            get
            {
                return base.method_3<GameObject>("m_ChooseElementsContainer");
            }
        }

        public AdventureChooserDescription m_CurrentChooserDescription
        {
            get
            {
                return base.method_3<AdventureChooserDescription>("m_CurrentChooserDescription");
            }
        }

        public string m_DefaultChooserButtonPrefab
        {
            get
            {
                return base.method_4("m_DefaultChooserButtonPrefab");
            }
        }

        public string m_DefaultChooserSubButtonPrefab
        {
            get
            {
                return base.method_4("m_DefaultChooserSubButtonPrefab");
            }
        }

        public GameObject m_DescriptionContainer
        {
            get
            {
                return base.method_3<GameObject>("m_DescriptionContainer");
            }
        }

        public UberText m_DescriptionTitleObject
        {
            get
            {
                return base.method_3<UberText>("m_DescriptionTitleObject");
            }
        }

        public bool m_isStarted
        {
            get
            {
                return base.method_2<bool>("m_isStarted");
            }
        }

        public bool m_OnlyOneExpands
        {
            get
            {
                return base.method_2<bool>("m_OnlyOneExpands");
            }
        }

        public AdventureSubScene m_ParentSubScene
        {
            get
            {
                return base.method_3<AdventureSubScene>("m_ParentSubScene");
            }
        }

        public AdventureChooserSubButton m_SelectedSubButton
        {
            get
            {
                return base.method_3<AdventureChooserSubButton>("m_SelectedSubButton");
            }
        }

        public static int s_DefaultPortraitMaterialIndex
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AdventureChooserTray", "s_DefaultPortraitMaterialIndex");
            }
        }

        public static string s_DefaultPortraitMaterialTextureName
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureChooserTray", "s_DefaultPortraitMaterialTextureName");
            }
        }
    }
}

