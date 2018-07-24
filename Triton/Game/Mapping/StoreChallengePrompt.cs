namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("StoreChallengePrompt")]
    public class StoreChallengePrompt : UIBPopup
    {
        public StoreChallengePrompt(IntPtr address) : this(address, "StoreChallengePrompt")
        {
        }

        public StoreChallengePrompt(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Cancel()
        {
            base.method_8("Cancel", Array.Empty<object>());
        }

        public void ClearInput()
        {
            base.method_8("ClearInput", Array.Empty<object>());
        }

        public void Hide(bool animate)
        {
            object[] objArray1 = new object[] { animate };
            base.method_8("Hide", objArray1);
        }

        public string HideChallenge()
        {
            return base.method_13("HideChallenge", Array.Empty<object>());
        }

        public void HideInput()
        {
            base.method_8("HideInput", Array.Empty<object>());
        }

        public void OnCancelPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCancelPressed", objArray1);
        }

        public void OnHidden()
        {
            base.method_8("OnHidden", Array.Empty<object>());
        }

        public void OnInfoPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnInfoPressed", objArray1);
        }

        public void OnInputCanceled(bool userRequested, GameObject requester)
        {
            object[] objArray1 = new object[] { userRequested, requester };
            base.method_8("OnInputCanceled", objArray1);
        }

        public void OnInputComplete(string input)
        {
            object[] objArray1 = new object[] { input };
            base.method_8("OnInputComplete", objArray1);
        }

        public void OnInputUpdated(string input)
        {
            object[] objArray1 = new object[] { input };
            base.method_8("OnInputUpdated", objArray1);
        }

        public void OnShown()
        {
            base.method_8("OnShown", Array.Empty<object>());
        }

        public void OnSubmitPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnSubmitPressed", objArray1);
        }

        public void ShowInput()
        {
            base.method_8("ShowInput", Array.Empty<object>());
        }

        public void UpdateInputText()
        {
            base.method_8("UpdateInputText", Array.Empty<object>());
        }

        public static string FMT_URL_CVV_INFO
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "StoreChallengePrompt", "FMT_URL_CVV_INFO");
            }
        }

        public UIBButton m_cancelButton
        {
            get
            {
                return base.method_3<UIBButton>("m_cancelButton");
            }
        }

        public string m_challengeID
        {
            get
            {
                return base.method_4("m_challengeID");
            }
        }

        public string m_challengeType
        {
            get
            {
                return base.method_4("m_challengeType");
            }
        }

        public string m_challengeUrl
        {
            get
            {
                return base.method_4("m_challengeUrl");
            }
        }

        public UIBButton m_infoButton
        {
            get
            {
                return base.method_3<UIBButton>("m_infoButton");
            }
        }

        public GameObject m_infoButtonFrame
        {
            get
            {
                return base.method_3<GameObject>("m_infoButtonFrame");
            }
        }

        public string m_input
        {
            get
            {
                return base.method_4("m_input");
            }
        }

        public UberText m_inputText
        {
            get
            {
                return base.method_3<UberText>("m_inputText");
            }
        }

        public UberText m_messageText
        {
            get
            {
                return base.method_3<UberText>("m_messageText");
            }
        }

        public UIBButton m_submitButton
        {
            get
            {
                return base.method_3<UIBButton>("m_submitButton");
            }
        }

        public static StoreURL s_cvvURL
        {
            get
            {
                return MonoClass.smethod_7<StoreURL>(TritonHs.MainAssemblyPath, "", "StoreChallengePrompt", "s_cvvURL");
            }
        }

        public static float TASSADAR_CHALLENGE_TIMEOUT_SECONDS
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "StoreChallengePrompt", "TASSADAR_CHALLENGE_TIMEOUT_SECONDS");
            }
        }
    }
}

