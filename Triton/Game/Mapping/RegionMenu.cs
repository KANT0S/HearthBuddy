namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("RegionMenu")]
    public class RegionMenu : ButtonListMenu
    {
        public RegionMenu(IntPtr address) : this(address, "RegionMenu")
        {
        }

        public RegionMenu(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public List<UIBButton> GetButtons()
        {
            Class267<UIBButton> class2 = base.method_14<Class267<UIBButton>>("GetButtons", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public List<UIBButton> m_buttons
        {
            get
            {
                Class267<UIBButton> class2 = base.method_3<Class267<UIBButton>>("m_buttons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Transform m_menuBone
        {
            get
            {
                return base.method_3<Transform>("m_menuBone");
            }
        }

        public string m_menuDefPrefabOverride
        {
            get
            {
                return base.method_4("m_menuDefPrefabOverride");
            }
        }
    }
}

