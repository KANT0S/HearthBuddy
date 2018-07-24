namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("OptionsMenuPhone")]
    public class OptionsMenuPhone : MonoBehaviour
    {
        public OptionsMenuPhone(IntPtr address) : this(address, "OptionsMenuPhone")
        {
        }

        public OptionsMenuPhone(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public UIBButton m_doneButton
        {
            get
            {
                return base.method_3<UIBButton>("m_doneButton");
            }
        }

        public GameObject m_mainContentsPanel
        {
            get
            {
                return base.method_3<GameObject>("m_mainContentsPanel");
            }
        }

        public OptionsMenu m_optionsMenu
        {
            get
            {
                return base.method_3<OptionsMenu>("m_optionsMenu");
            }
        }
    }
}

