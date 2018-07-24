namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DialogManager")]
    public class DialogManager : MonoBehaviour
    {
        public DialogManager(IntPtr address) : this(address, "DialogManager")
        {
        }

        public DialogManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddToQueue(DialogRequest request)
        {
            object[] objArray1 = new object[] { request };
            base.method_8("AddToQueue", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DestroyPopupAssetsIfPossible()
        {
            base.method_8("DestroyPopupAssetsIfPossible", Array.Empty<object>());
        }

        public static DialogManager Get()
        {
            return MonoClass.smethod_15<DialogManager>(TritonHs.MainAssemblyPath, "", "DialogManager", "Get", Array.Empty<object>());
        }

        public void GoBack()
        {
            base.method_8("GoBack", Array.Empty<object>());
        }

        public bool HandleKeyboardInput()
        {
            return base.method_11<bool>("HandleKeyboardInput", Array.Empty<object>());
        }

        public bool IsSuppressed()
        {
            return base.method_11<bool>("IsSuppressed", Array.Empty<object>());
        }

        public void LoadPopup(DialogRequest request)
        {
            object[] objArray1 = new object[] { request };
            base.method_8("LoadPopup", objArray1);
        }

        public void OnCurrentDialogHidden(DialogBase dialog, object userData)
        {
            object[] objArray1 = new object[] { dialog, userData };
            base.method_8("OnCurrentDialogHidden", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnPopupLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnPopupLoaded", objArray1);
        }

        public void ProcessAlertRequest(DialogRequest request, AlertPopup alertPopup)
        {
            object[] objArray1 = new object[] { request, alertPopup };
            base.method_8("ProcessAlertRequest", objArray1);
        }

        public void ProcessExistingAccountRequest(DialogRequest request, ExistingAccountPopup exAcctPopup)
        {
            object[] objArray1 = new object[] { request, exAcctPopup };
            base.method_8("ProcessExistingAccountRequest", objArray1);
        }

        public void ProcessFriendlyChallengeRequest(DialogRequest request, FriendlyChallengeDialog friendlyChallengeDialog)
        {
            object[] objArray1 = new object[] { request, friendlyChallengeDialog };
            base.method_8("ProcessFriendlyChallengeRequest", objArray1);
        }

        public void ProcessMedalRequest(DialogRequest request, SeasonEndDialog seasonEndDialog)
        {
            object[] objArray1 = new object[] { request, seasonEndDialog };
            base.method_8("ProcessMedalRequest", objArray1);
        }

        public void ProcessRequest(DialogRequest request, DialogBase dialog)
        {
            object[] objArray1 = new object[] { request, dialog };
            base.method_8("ProcessRequest", objArray1);
        }

        public void ReadyForSeasonEndPopup(bool ready)
        {
            object[] objArray1 = new object[] { ready };
            base.method_8("ReadyForSeasonEndPopup", objArray1);
        }

        public void RemoveUniquePopupRequestFromQueue(string id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("RemoveUniquePopupRequestFromQueue", objArray1);
        }

        public bool ShowingDialog()
        {
            return base.method_11<bool>("ShowingDialog", Array.Empty<object>());
        }

        public void ShowMessageOfTheDay(string message)
        {
            object[] objArray1 = new object[] { message };
            base.method_8("ShowMessageOfTheDay", objArray1);
        }

        public void ShowPopup(AlertPopup.PopupInfo info)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { info };
            base.method_9("ShowPopup", enumArray1, objArray1);
        }

        public bool ShowUniquePopup(AlertPopup.PopupInfo info)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { info };
            return base.method_10<bool>("ShowUniquePopup", enumArray1, objArray1);
        }

        public void Suppress(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("Suppress", objArray1);
        }

        public void UpdateQueue()
        {
            base.method_8("UpdateQueue", Array.Empty<object>());
        }

        public bool WaitingToShowSeasonEndDialog()
        {
            return base.method_11<bool>("WaitingToShowSeasonEndDialog", Array.Empty<object>());
        }

        public DialogBase m_currentDialog
        {
            get
            {
                return base.method_3<DialogBase>("m_currentDialog");
            }
        }

        public List<long> m_handledMedalNoticeIDs
        {
            get
            {
                Class266<long> class2 = base.method_3<Class266<long>>("m_handledMedalNoticeIDs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_isReadyForSeasonEndPopup
        {
            get
            {
                return base.method_2<bool>("m_isReadyForSeasonEndPopup");
            }
        }

        public bool m_loadingDialog
        {
            get
            {
                return base.method_2<bool>("m_loadingDialog");
            }
        }

        public bool m_suppressed
        {
            get
            {
                return base.method_2<bool>("m_suppressed");
            }
        }

        public List<DialogTypeMapping> m_typeMapping
        {
            get
            {
                Class267<DialogTypeMapping> class2 = base.method_3<Class267<DialogTypeMapping>>("m_typeMapping");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_waitingToShowSeasonEndDialog
        {
            get
            {
                return base.method_2<bool>("m_waitingToShowSeasonEndDialog");
            }
        }

        [Attribute38("DialogManager.DialogRequest")]
        public class DialogRequest : MonoClass
        {
            public DialogRequest(IntPtr address) : this(address, "DialogRequest")
            {
            }

            public DialogRequest(IntPtr address, string className) : base(address, className)
            {
            }

            public object m_info
            {
                get
                {
                    return base.method_3<object>("m_info");
                }
            }

            public bool m_isFake
            {
                get
                {
                    return base.method_2<bool>("m_isFake");
                }
            }

            public DialogManager.DialogType m_type
            {
                get
                {
                    return base.method_2<DialogManager.DialogType>("m_type");
                }
            }

            public object m_userData
            {
                get
                {
                    return base.method_3<object>("m_userData");
                }
            }
        }

        public enum DialogType
        {
            ALERT,
            SEASON_END,
            FRIENDLY_CHALLENGE,
            TAVERN_BRAWL_CHALLENGE,
            EXISTING_ACCOUNT
        }

        [Attribute38("DialogManager.DialogTypeMapping")]
        public class DialogTypeMapping : MonoClass
        {
            public DialogTypeMapping(IntPtr address) : this(address, "DialogTypeMapping")
            {
            }

            public DialogTypeMapping(IntPtr address, string className) : base(address, className)
            {
            }

            public string m_prefabName
            {
                get
                {
                    return base.method_4("m_prefabName");
                }
            }

            public DialogManager.DialogType m_type
            {
                get
                {
                    return base.method_2<DialogManager.DialogType>("m_type");
                }
            }
        }

        [Attribute38("DialogManager.SeasonEndDialogRequestInfo")]
        public class SeasonEndDialogRequestInfo : MonoClass
        {
            public SeasonEndDialogRequestInfo(IntPtr address) : this(address, "SeasonEndDialogRequestInfo")
            {
            }

            public SeasonEndDialogRequestInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public NetCache.ProfileNoticeBonusStars m_noticeBonusStars
            {
                get
                {
                    return base.method_3<NetCache.ProfileNoticeBonusStars>("m_noticeBonusStars");
                }
            }

            public NetCache.ProfileNoticeRewardCardBack m_noticeCardBack
            {
                get
                {
                    return base.method_3<NetCache.ProfileNoticeRewardCardBack>("m_noticeCardBack");
                }
            }

            public NetCache.ProfileNoticeMedal m_noticeMedal
            {
                get
                {
                    return base.method_3<NetCache.ProfileNoticeMedal>("m_noticeMedal");
                }
            }
        }
    }
}

