namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("ClassFilterHeaderButton")]
    public class ClassFilterHeaderButton : PegUIElement
    {
        public ClassFilterHeaderButton(IntPtr address) : this(address, "ClassFilterHeaderButton")
        {
        }

        public ClassFilterHeaderButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void HandleRelease()
        {
            base.method_8("HandleRelease", Array.Empty<object>());
        }

        public List<ClassFilterButton> m_buttons
        {
            get
            {
                Class247<ClassFilterButton> class2 = base.method_3<Class247<ClassFilterButton>>("m_buttons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public SlidingTray m_classFilterTray
        {
            get
            {
                return base.method_3<SlidingTray>("m_classFilterTray");
            }
        }

        public ClassFilterButtonContainer m_container
        {
            get
            {
                return base.method_3<ClassFilterButtonContainer>("m_container");
            }
        }

        public UberText m_headerText
        {
            get
            {
                return base.method_3<UberText>("m_headerText");
            }
        }

        public Transform m_showTwoRowsBone
        {
            get
            {
                return base.method_3<Transform>("m_showTwoRowsBone");
            }
        }
    }
}

