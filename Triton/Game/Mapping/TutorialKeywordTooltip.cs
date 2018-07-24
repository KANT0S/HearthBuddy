namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("TutorialKeywordTooltip")]
    public class TutorialKeywordTooltip : MonoBehaviour
    {
        public TutorialKeywordTooltip(IntPtr address) : this(address, "TutorialKeywordTooltip")
        {
        }

        public TutorialKeywordTooltip(IntPtr address, string className) : base(address, className)
        {
        }

        public float GetHeight()
        {
            return base.method_11<float>("GetHeight", Array.Empty<object>());
        }

        public float GetWidth()
        {
            return base.method_11<float>("GetWidth", Array.Empty<object>());
        }

        public void Initialize(string keywordName, string keywordText)
        {
            object[] objArray1 = new object[] { keywordName, keywordText };
            base.method_8("Initialize", objArray1);
        }

        public void SetBodyText(string s)
        {
            object[] objArray1 = new object[] { s };
            base.method_8("SetBodyText", objArray1);
        }

        public void SetName(string s)
        {
            object[] objArray1 = new object[] { s };
            base.method_8("SetName", objArray1);
        }

        public UberText m_body
        {
            get
            {
                return base.method_3<UberText>("m_body");
            }
        }

        public UberText m_name
        {
            get
            {
                return base.method_3<UberText>("m_name");
            }
        }
    }
}

