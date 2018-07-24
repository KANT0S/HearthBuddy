namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FriendListRecruitUI")]
    public class FriendListRecruitUI : MonoBehaviour
    {
        public FriendListRecruitUI(IntPtr address) : this(address, "FriendListRecruitUI")
        {
        }

        public FriendListRecruitUI(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnCancelButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCancelButtonPressed", objArray1);
        }

        public void OnCancelPopupResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("OnCancelPopupResponse", objArray1);
        }

        public bool OnCancelShown(DialogBase dialog, object userData)
        {
            object[] objArray1 = new object[] { dialog, userData };
            return base.method_11<bool>("OnCancelShown", objArray1);
        }

        public void SetInfo(Network.RecruitInfo info)
        {
            object[] objArray1 = new object[] { info };
            base.method_8("SetInfo", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public FriendListUIElement m_CancelButton
        {
            get
            {
                return base.method_3<FriendListUIElement>("m_CancelButton");
            }
        }

        public Network.RecruitInfo m_recruitInfo
        {
            get
            {
                return base.method_3<Network.RecruitInfo>("m_recruitInfo");
            }
        }

        public UberText m_recruitText
        {
            get
            {
                return base.method_3<UberText>("m_recruitText");
            }
        }

        public GameObject m_success
        {
            get
            {
                return base.method_3<GameObject>("m_success");
            }
        }
    }
}

