namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ShowAllCardsTab")]
    public class ShowAllCardsTab : MonoBehaviour
    {
        public ShowAllCardsTab(IntPtr address) : this(address, "ShowAllCardsTab")
        {
        }

        public ShowAllCardsTab(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool IsShowAllChecked()
        {
            return base.method_11<bool>("IsShowAllChecked", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void ToggleIncludePremiums(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ToggleIncludePremiums", objArray1);
        }

        public CheckBox m_includePremiumsCheckBox
        {
            get
            {
                return base.method_3<CheckBox>("m_includePremiumsCheckBox");
            }
        }

        public CheckBox m_showAllCardsCheckBox
        {
            get
            {
                return base.method_3<CheckBox>("m_showAllCardsCheckBox");
            }
        }
    }
}

