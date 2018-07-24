namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BoxStartButton")]
    public class BoxStartButton : PegUIElement
    {
        public BoxStartButton(IntPtr address) : this(address, "BoxStartButton")
        {
        }

        public BoxStartButton(IntPtr address, string className) : base(address, className)
        {
        }

        public bool ChangeState(State state)
        {
            object[] objArray1 = new object[] { state };
            return base.method_11<bool>("ChangeState", objArray1);
        }

        public BoxStartButtonStateInfo GetInfo()
        {
            return base.method_14<BoxStartButtonStateInfo>("GetInfo", Array.Empty<object>());
        }

        public Box GetParent()
        {
            return base.method_14<Box>("GetParent", Array.Empty<object>());
        }

        public string GetText()
        {
            return base.method_13("GetText", Array.Empty<object>());
        }

        public void OnHiddenAnimFinished()
        {
            base.method_8("OnHiddenAnimFinished", Array.Empty<object>());
        }

        public void OnShownAnimFinished()
        {
            base.method_8("OnShownAnimFinished", Array.Empty<object>());
        }

        public void SetInfo(BoxStartButtonStateInfo info)
        {
            object[] objArray1 = new object[] { info };
            base.method_8("SetInfo", objArray1);
        }

        public void SetParent(Box parent)
        {
            object[] objArray1 = new object[] { parent };
            base.method_8("SetParent", objArray1);
        }

        public void SetText(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("SetText", objArray1);
        }

        public void UpdateState(State state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("UpdateState", objArray1);
        }

        public BoxStartButtonStateInfo m_info
        {
            get
            {
                return base.method_3<BoxStartButtonStateInfo>("m_info");
            }
        }

        public Box m_parent
        {
            get
            {
                return base.method_3<Box>("m_parent");
            }
        }

        public State m_state
        {
            get
            {
                return base.method_2<State>("m_state");
            }
        }

        public UberText m_Text
        {
            get
            {
                return base.method_3<UberText>("m_Text");
            }
        }

        public enum State
        {
            SHOWN,
            HIDDEN
        }
    }
}

