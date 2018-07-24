namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("BoxEventInfo")]
    public class BoxEventInfo : MonoClass
    {
        public BoxEventInfo(IntPtr address) : this(address, "BoxEventInfo")
        {
        }

        public BoxEventInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public Spell m_DiskLoading
        {
            get
            {
                return base.method_3<Spell>("m_DiskLoading");
            }
        }

        public Spell m_DiskMainMenu
        {
            get
            {
                return base.method_3<Spell>("m_DiskMainMenu");
            }
        }

        public Spell m_DoorsClose
        {
            get
            {
                return base.method_3<Spell>("m_DoorsClose");
            }
        }

        public Spell m_DoorsOpen
        {
            get
            {
                return base.method_3<Spell>("m_DoorsOpen");
            }
        }

        public Spell m_DrawerClose
        {
            get
            {
                return base.method_3<Spell>("m_DrawerClose");
            }
        }

        public Spell m_DrawerOpen
        {
            get
            {
                return base.method_3<Spell>("m_DrawerOpen");
            }
        }

        public Spell m_ShadowFadeIn
        {
            get
            {
                return base.method_3<Spell>("m_ShadowFadeIn");
            }
        }

        public Spell m_ShadowFadeOut
        {
            get
            {
                return base.method_3<Spell>("m_ShadowFadeOut");
            }
        }

        public Spell m_StartupHub
        {
            get
            {
                return base.method_3<Spell>("m_StartupHub");
            }
        }

        public Spell m_StartupTutorial
        {
            get
            {
                return base.method_3<Spell>("m_StartupTutorial");
            }
        }

        public Spell m_TutorialPlay
        {
            get
            {
                return base.method_3<Spell>("m_TutorialPlay");
            }
        }
    }
}

