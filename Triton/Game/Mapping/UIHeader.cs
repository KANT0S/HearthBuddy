namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("UIHeader")]
    public class UIHeader : ThreeSliceElement
    {
        public UIHeader(IntPtr address) : this(address, "UIHeader")
        {
        }

        public UIHeader(IntPtr address, string className) : base(address, className)
        {
        }

        public void SetText(string t)
        {
            object[] objArray1 = new object[] { t };
            base.method_8("SetText", objArray1);
        }

        public UberText m_headerUberText
        {
            get
            {
                return base.method_3<UberText>("m_headerUberText");
            }
        }
    }
}

