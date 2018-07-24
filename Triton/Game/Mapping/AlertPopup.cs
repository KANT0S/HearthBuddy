namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AlertPopup")]
    public class AlertPopup : DialogBase
    {
        public AlertPopup(IntPtr address) : this(address, "AlertPopup")
        {
        }

        public AlertPopup(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ButtonPress(Response response)
        {
            object[] objArray1 = new object[] { response };
            base.method_8("ButtonPress", objArray1);
        }

        public PopupInfo GetInfo()
        {
            return base.method_14<PopupInfo>("GetInfo", Array.Empty<object>());
        }

        public void GoBack()
        {
            base.method_8("GoBack", Array.Empty<object>());
        }

        public bool HandleKeyboardInput()
        {
            return base.method_11<bool>("HandleKeyboardInput", Array.Empty<object>());
        }

        public void InitInfo()
        {
            base.method_8("InitInfo", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnHideAnimFinished()
        {
            base.method_8("OnHideAnimFinished", Array.Empty<object>());
        }

        public void OnShowAnimFinished()
        {
            base.method_8("OnShowAnimFinished", Array.Empty<object>());
        }

        public void SetInfo(PopupInfo info)
        {
            object[] objArray1 = new object[] { info };
            base.method_8("SetInfo", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateAll(PopupInfo popupInfo)
        {
            object[] objArray1 = new object[] { popupInfo };
            base.method_8("UpdateAll", objArray1);
        }

        public void UpdateButtons(ResponseDisplay displayType)
        {
            object[] objArray1 = new object[] { displayType };
            base.method_8("UpdateButtons", objArray1);
        }

        public void UpdateHeaderText(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("UpdateHeaderText", objArray1);
        }

        public void UpdateInfo(PopupInfo info)
        {
            object[] objArray1 = new object[] { info };
            base.method_8("UpdateInfo", objArray1);
        }

        public void UpdateInfoAfterAnim()
        {
            base.method_8("UpdateInfoAfterAnim", Array.Empty<object>());
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public void UpdateTexts(PopupInfo popupInfo)
        {
            object[] objArray1 = new object[] { popupInfo };
            base.method_8("UpdateTexts", objArray1);
        }

        public string BodyText
        {
            get
            {
                return base.method_13("get_BodyText", Array.Empty<object>());
            }
        }

        public static float BUTTON_FRAME_WIDTH
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AlertPopup", "BUTTON_FRAME_WIDTH");
            }
        }

        public GameObject m_alertIcon
        {
            get
            {
                return base.method_3<GameObject>("m_alertIcon");
            }
        }

        public Vector3 m_alertIconOffset
        {
            get
            {
                return base.method_2<Vector3>("m_alertIconOffset");
            }
        }

        public UberText m_alertText
        {
            get
            {
                return base.method_3<UberText>("m_alertText");
            }
        }

        public NineSliceElement m_body
        {
            get
            {
                return base.method_3<NineSliceElement>("m_body");
            }
        }

        public MultiSliceElement m_buttonContainer
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_buttonContainer");
            }
        }

        public List<GameObject> m_buttonIconsSet1
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_buttonIconsSet1");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<GameObject> m_buttonIconsSet2
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_buttonIconsSet2");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public UIBButton m_cancelButton
        {
            get
            {
                return base.method_3<UIBButton>("m_cancelButton");
            }
        }

        public GameObject m_clickCatcher
        {
            get
            {
                return base.method_3<GameObject>("m_clickCatcher");
            }
        }

        public UIBButton m_confirmButton
        {
            get
            {
                return base.method_3<UIBButton>("m_confirmButton");
            }
        }

        public Vector3 m_loadPosition
        {
            get
            {
                return base.method_2<Vector3>("m_loadPosition");
            }
        }

        public UIBButton m_okayButton
        {
            get
            {
                return base.method_3<UIBButton>("m_okayButton");
            }
        }

        public float m_padding
        {
            get
            {
                return base.method_2<float>("m_padding");
            }
        }

        public PopupInfo m_popupInfo
        {
            get
            {
                return base.method_3<PopupInfo>("m_popupInfo");
            }
        }

        public Vector3 m_showPosition
        {
            get
            {
                return base.method_2<Vector3>("m_showPosition");
            }
        }

        public PopupInfo m_updateInfo
        {
            get
            {
                return base.method_3<PopupInfo>("m_updateInfo");
            }
        }

        [Attribute38("AlertPopup.PopupInfo")]
        public class PopupInfo : MonoClass
        {
            public PopupInfo(IntPtr address) : this(address, "PopupInfo")
            {
            }

            public PopupInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public UberText.AlignmentOptions m_alertTextAlignment
            {
                get
                {
                    return base.method_2<UberText.AlignmentOptions>("m_alertTextAlignment");
                }
            }

            public string m_cancelText
            {
                get
                {
                    return base.method_4("m_cancelText");
                }
            }

            public string m_confirmText
            {
                get
                {
                    return base.method_4("m_confirmText");
                }
            }

            public bool m_disableBlocker
            {
                get
                {
                    return base.method_2<bool>("m_disableBlocker");
                }
            }

            public string m_headerText
            {
                get
                {
                    return base.method_4("m_headerText");
                }
            }

            public IconSet m_iconSet
            {
                get
                {
                    return base.method_2<IconSet>("m_iconSet");
                }
            }

            public string m_id
            {
                get
                {
                    return base.method_4("m_id");
                }
            }

            public bool m_keyboardEscIsCancel
            {
                get
                {
                    return base.method_2<bool>("m_keyboardEscIsCancel");
                }
            }

            public Vector3 m_offset
            {
                get
                {
                    return base.method_2<Vector3>("m_offset");
                }
            }

            public string m_okText
            {
                get
                {
                    return base.method_4("m_okText");
                }
            }

            public float m_padding
            {
                get
                {
                    return base.method_2<float>("m_padding");
                }
            }

            public AlertPopup.ResponseDisplay m_responseDisplay
            {
                get
                {
                    return base.method_2<AlertPopup.ResponseDisplay>("m_responseDisplay");
                }
            }

            public object m_responseUserData
            {
                get
                {
                    return base.method_3<object>("m_responseUserData");
                }
            }

            public bool m_richTextEnabled
            {
                get
                {
                    return base.method_2<bool>("m_richTextEnabled");
                }
            }

            public bool m_showAlertIcon
            {
                get
                {
                    return base.method_2<bool>("m_showAlertIcon");
                }
            }

            public string m_text
            {
                get
                {
                    return base.method_4("m_text");
                }
            }

            public enum IconSet
            {
                Default,
                Alternate,
                None
            }
        }

        public enum Response
        {
            OK,
            CONFIRM,
            CANCEL
        }

        public enum ResponseDisplay
        {
            NONE,
            OK,
            CONFIRM,
            CANCEL,
            CONFIRM_CANCEL
        }
    }
}

