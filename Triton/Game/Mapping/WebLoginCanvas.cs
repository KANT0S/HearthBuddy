namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("WebLoginCanvas")]
    public class WebLoginCanvas : MonoBehaviour
    {
        public WebLoginCanvas(IntPtr address) : this(address, "WebLoginCanvas")
        {
        }

        public WebLoginCanvas(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CauseReconnect()
        {
            base.method_8("CauseReconnect", Array.Empty<object>());
        }

        public void OnBackPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnBackPressed", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public bool OnDialogProcess(DialogBase dialog, object userData)
        {
            object[] objArray1 = new object[] { dialog, userData };
            return base.method_11<bool>("OnDialogProcess", objArray1);
        }

        public void onMenuShown(bool shown)
        {
            object[] objArray1 = new object[] { shown };
            base.method_8("onMenuShown", objArray1);
        }

        public bool OnNavigateBack()
        {
            return base.method_11<bool>("OnNavigateBack", Array.Empty<object>());
        }

        public void onRegionChange(object selection, object prevSelection)
        {
            object[] objArray1 = new object[] { selection, prevSelection };
            base.method_8("onRegionChange", objArray1);
        }

        public void onRegionChangeCB(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("onRegionChangeCB", objArray1);
        }

        public string onRegionText(object val)
        {
            object[] objArray1 = new object[] { val };
            return base.method_13("onRegionText", objArray1);
        }

        public void onRegionWarning(object selection, object prevSelection)
        {
            object[] objArray1 = new object[] { selection, prevSelection };
            base.method_8("onRegionWarning", objArray1);
        }

        public void SetUpRegionButton()
        {
            base.method_8("SetUpRegionButton", Array.Empty<object>());
        }

        public void SetUpRegionDropdown()
        {
            base.method_8("SetUpRegionDropdown", Array.Empty<object>());
        }

        public void ShowRegionMenu()
        {
            base.method_8("ShowRegionMenu", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void WebViewBackButtonPressed(string dummyState)
        {
            object[] objArray1 = new object[] { dummyState };
            base.method_8("WebViewBackButtonPressed", objArray1);
        }

        public void WebViewDidFinishLoad(string pageState)
        {
            object[] objArray1 = new object[] { pageState };
            base.method_8("WebViewDidFinishLoad", objArray1);
        }

        public GameObject m_accountCreation
        {
            get
            {
                return base.method_3<GameObject>("m_accountCreation");
            }
        }

        public float m_acFlipbookCur
        {
            get
            {
                return base.method_2<float>("m_acFlipbookCur");
            }
        }

        public float m_acFlipbookSwap
        {
            get
            {
                return base.method_2<float>("m_acFlipbookSwap");
            }
        }

        public PegUIElement m_backButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_backButton");
            }
        }

        public GameObject m_bottomRightBone
        {
            get
            {
                return base.method_3<GameObject>("m_bottomRightBone");
            }
        }

        public bool m_canGoBack
        {
            get
            {
                return base.method_2<bool>("m_canGoBack");
            }
        }

        public AccountCreationFlipbook m_flipbook
        {
            get
            {
                return base.method_3<AccountCreationFlipbook>("m_flipbook");
            }
        }

        public object m_prevSelection
        {
            get
            {
                return base.method_3<object>("m_prevSelection");
            }
        }

        public UIBButton m_regionButton
        {
            get
            {
                return base.method_3<UIBButton>("m_regionButton");
            }
        }

        public RegionMenu m_regionMenu
        {
            get
            {
                return base.method_3<RegionMenu>("m_regionMenu");
            }
        }

        public GameObject m_regionSelectContents
        {
            get
            {
                return base.method_3<GameObject>("m_regionSelectContents");
            }
        }

        public GameObject m_regionSelectDropdownBone
        {
            get
            {
                return base.method_3<GameObject>("m_regionSelectDropdownBone");
            }
        }

        public DropdownControl m_regionSelectDropdownPrefab
        {
            get
            {
                return base.method_3<DropdownControl>("m_regionSelectDropdownPrefab");
            }
        }

        public DropdownControl m_regionSelector
        {
            get
            {
                return base.method_3<DropdownControl>("m_regionSelector");
            }
        }

        public KeywordHelpPanel m_regionSelectTooltip
        {
            get
            {
                return base.method_3<KeywordHelpPanel>("m_regionSelectTooltip");
            }
        }

        public GameObject m_regionSelectTooltipBone
        {
            get
            {
                return base.method_3<GameObject>("m_regionSelectTooltipBone");
            }
        }

        public object m_selection
        {
            get
            {
                return base.method_3<object>("m_selection");
            }
        }

        public GameObject m_topLeftBone
        {
            get
            {
                return base.method_3<GameObject>("m_topLeftBone");
            }
        }
    }
}

