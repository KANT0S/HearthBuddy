namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GameMenu")]
    public class GameMenu : ButtonListMenu
    {
        public GameMenu(IntPtr address) : this(address, "GameMenu")
        {
        }

        public GameMenu(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ConcedeButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ConcedeButtonPressed", objArray1);
        }

        public static GameMenu Get()
        {
            return MonoClass.smethod_15<GameMenu>(TritonHs.MainAssemblyPath, "", "GameMenu", "Get", Array.Empty<object>());
        }

        public List<UIBButton> GetButtons()
        {
            Class267<UIBButton> class2 = base.method_14<Class267<UIBButton>>("GetButtons", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void HideLoginTooltip()
        {
            base.method_8("HideLoginTooltip", Array.Empty<object>());
        }

        public bool IsInGameMenu()
        {
            return base.method_11<bool>("IsInGameMenu", Array.Empty<object>());
        }

        public void LayoutMenu()
        {
            base.method_8("LayoutMenu", Array.Empty<object>());
        }

        public void LoadRatings()
        {
            base.method_8("LoadRatings", Array.Empty<object>());
        }

        public void LogoutButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("LogoutButtonPressed", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnOptionsMenuHidden()
        {
            base.method_8("OnOptionsMenuHidden", Array.Empty<object>());
        }

        public void OptionsButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OptionsButtonPressed", objArray1);
        }

        public void QuitButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("QuitButtonPressed", objArray1);
        }

        public void ResumeButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ResumeButtonPressed", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void ShowLoginTooltipIfNeeded()
        {
            base.method_8("ShowLoginTooltipIfNeeded", Array.Empty<object>());
        }

        public void ShowOptionsMenu()
        {
            base.method_8("ShowOptionsMenu", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void SwitchToOptionsMenu()
        {
            base.method_8("SwitchToOptionsMenu", Array.Empty<object>());
        }

        public bool UseKoreanRating()
        {
            return base.method_11<bool>("UseKoreanRating", Array.Empty<object>());
        }

        public Vector3 BUTTON_SCALE
        {
            get
            {
                return base.method_2<Vector3>("BUTTON_SCALE");
            }
        }

        public Vector3 BUTTON_SCALE_PHONE
        {
            get
            {
                return base.method_2<Vector3>("BUTTON_SCALE_PHONE");
            }
        }

        public UIBButton m_concedeButton
        {
            get
            {
                return base.method_3<UIBButton>("m_concedeButton");
            }
        }

        public bool m_hasSeenLoginTooltip
        {
            get
            {
                return base.method_2<bool>("m_hasSeenLoginTooltip");
            }
        }

        public Triton.Game.Mapping.Notification m_loginButtonPopup
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("m_loginButtonPopup");
            }
        }

        public Transform m_menuBone
        {
            get
            {
                return base.method_3<Transform>("m_menuBone");
            }
        }

        public UIBButton m_optionsButton
        {
            get
            {
                return base.method_3<UIBButton>("m_optionsButton");
            }
        }

        public OptionsMenu m_optionsMenu
        {
            get
            {
                return base.method_3<OptionsMenu>("m_optionsMenu");
            }
        }

        public UIBButton m_quitButton
        {
            get
            {
                return base.method_3<UIBButton>("m_quitButton");
            }
        }

        public GameObject m_ratingsObject
        {
            get
            {
                return base.method_3<GameObject>("m_ratingsObject");
            }
        }

        public Vector3 m_ratingsObjectMinPadding
        {
            get
            {
                return base.method_2<Vector3>("m_ratingsObjectMinPadding");
            }
        }

        public UIBButton m_resumeButton
        {
            get
            {
                return base.method_3<UIBButton>("m_resumeButton");
            }
        }
    }
}

