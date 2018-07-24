namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FriendListGameIcon")]
    public class FriendListGameIcon : MonoBehaviour
    {
        public FriendListGameIcon(IntPtr address) : this(address, "FriendListGameIcon")
        {
        }

        public FriendListGameIcon(IntPtr address, string className) : base(address, className)
        {
        }

        public bool IsIconLoading()
        {
            return base.method_11<bool>("IsIconLoading", Array.Empty<object>());
        }

        public bool IsIconReady()
        {
            return base.method_11<bool>("IsIconReady", Array.Empty<object>());
        }

        public void OnIconLoaded(string name, object obj, object callbackData)
        {
            object[] objArray1 = new object[] { name, obj, callbackData };
            base.method_8("OnIconLoaded", objArray1);
        }

        public void UpdateIcon()
        {
            base.method_8("UpdateIcon", Array.Empty<object>());
        }

        public string m_currentIcon
        {
            get
            {
                return base.method_4("m_currentIcon");
            }
        }

        public GameObject m_Icon
        {
            get
            {
                return base.method_3<GameObject>("m_Icon");
            }
        }

        public string m_loadingIcon
        {
            get
            {
                return base.method_4("m_loadingIcon");
            }
        }
    }
}

