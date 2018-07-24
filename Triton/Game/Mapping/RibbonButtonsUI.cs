namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("RibbonButtonsUI")]
    public class RibbonButtonsUI : MonoBehaviour
    {
        public RibbonButtonsUI(IntPtr address) : this(address, "RibbonButtonsUI")
        {
        }

        public RibbonButtonsUI(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void SetPackCount(int packs)
        {
            object[] objArray1 = new object[] { packs };
            base.method_8("SetPackCount", objArray1);
        }

        public void Toggle(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("Toggle", objArray1);
        }

        public PegUIElement m_collectionManagerRibbon
        {
            get
            {
                return base.method_3<PegUIElement>("m_collectionManagerRibbon");
            }
        }

        public float m_EaseInTime
        {
            get
            {
                return base.method_2<float>("m_EaseInTime");
            }
        }

        public float m_EaseOutTime
        {
            get
            {
                return base.method_2<float>("m_EaseOutTime");
            }
        }

        public Transform m_LeftBones
        {
            get
            {
                return base.method_3<Transform>("m_LeftBones");
            }
        }

        public float m_minAspectRatioAdjustment
        {
            get
            {
                return base.method_2<float>("m_minAspectRatioAdjustment");
            }
        }

        public UberText m_packCount
        {
            get
            {
                return base.method_3<UberText>("m_packCount");
            }
        }

        public GameObject m_packCountFrame
        {
            get
            {
                return base.method_3<GameObject>("m_packCountFrame");
            }
        }

        public PegUIElement m_packOpeningRibbon
        {
            get
            {
                return base.method_3<PegUIElement>("m_packOpeningRibbon");
            }
        }

        public PegUIElement m_questLogRibbon
        {
            get
            {
                return base.method_3<PegUIElement>("m_questLogRibbon");
            }
        }

        public List<RibbonButtonObject> m_Ribbons
        {
            get
            {
                Class267<RibbonButtonObject> class2 = base.method_3<Class267<RibbonButtonObject>>("m_Ribbons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Transform m_RightBones
        {
            get
            {
                return base.method_3<Transform>("m_RightBones");
            }
        }

        public GameObject m_rootObject
        {
            get
            {
                return base.method_3<GameObject>("m_rootObject");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }

        public PegUIElement m_storeRibbon
        {
            get
            {
                return base.method_3<PegUIElement>("m_storeRibbon");
            }
        }

        [Attribute38("RibbonButtonsUI.RibbonButtonObject")]
        public class RibbonButtonObject : MonoClass
        {
            public RibbonButtonObject(IntPtr address) : this(address, "RibbonButtonObject")
            {
            }

            public RibbonButtonObject(IntPtr address, string className) : base(address, className)
            {
            }

            public float m_AnimateInDelay
            {
                get
                {
                    return base.method_2<float>("m_AnimateInDelay");
                }
            }

            public Transform m_HiddenBone
            {
                get
                {
                    return base.method_3<Transform>("m_HiddenBone");
                }
            }

            public bool m_LeftSide
            {
                get
                {
                    return base.method_2<bool>("m_LeftSide");
                }
            }

            public PegUIElement m_Ribbon
            {
                get
                {
                    return base.method_3<PegUIElement>("m_Ribbon");
                }
            }

            public Transform m_ShownBone
            {
                get
                {
                    return base.method_3<Transform>("m_ShownBone");
                }
            }
        }
    }
}

