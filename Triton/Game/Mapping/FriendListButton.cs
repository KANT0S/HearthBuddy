namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FriendListButton")]
    public class FriendListButton : FriendListUIElement
    {
        public FriendListButton(IntPtr address) : this(address, "FriendListButton")
        {
        }

        public FriendListButton(IntPtr address, string className) : base(address, className)
        {
        }

        public string GetText()
        {
            return base.method_13("GetText", Array.Empty<object>());
        }

        public void SetText(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("SetText", objArray1);
        }

        public void ShowActiveGlow(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowActiveGlow", objArray1);
        }

        public void UpdateAll()
        {
            base.method_8("UpdateAll", Array.Empty<object>());
        }

        public GameObject m_ActiveGlow
        {
            get
            {
                return base.method_3<GameObject>("m_ActiveGlow");
            }
        }

        public GameObject m_Background
        {
            get
            {
                return base.method_3<GameObject>("m_Background");
            }
        }

        public UberText m_Text
        {
            get
            {
                return base.method_3<UberText>("m_Text");
            }
        }
    }
}

