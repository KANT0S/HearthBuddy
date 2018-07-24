namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AdventureChooserDescription")]
    public class AdventureChooserDescription : MonoBehaviour
    {
        public AdventureChooserDescription(IntPtr address) : this(address, "AdventureChooserDescription")
        {
        }

        public AdventureChooserDescription(IntPtr address, string className) : base(address, className)
        {
        }

        public string GetText()
        {
            return base.method_13("GetText", Array.Empty<object>());
        }

        public void RefreshText()
        {
            base.method_8("RefreshText", Array.Empty<object>());
        }

        public void SetText(string requiredText, string descText)
        {
            object[] objArray1 = new object[] { requiredText, descText };
            base.method_8("SetText", objArray1);
        }

        public UberText m_DescriptionObject
        {
            get
            {
                return base.method_3<UberText>("m_DescriptionObject");
            }
        }

        public string m_DescText
        {
            get
            {
                return base.method_4("m_DescText");
            }
        }

        public string m_RequiredText
        {
            get
            {
                return base.method_4("m_RequiredText");
            }
        }

        public Color32 m_WarningTextColor
        {
            get
            {
                return base.method_2<Color32>("m_WarningTextColor");
            }
        }

        public Color WarningTextColor
        {
            get
            {
                return base.method_11<Color>("get_WarningTextColor", Array.Empty<object>());
            }
        }
    }
}

