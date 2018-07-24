namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GeneralStorePhoneCover")]
    public class GeneralStorePhoneCover : MonoBehaviour
    {
        public GeneralStorePhoneCover(IntPtr address) : this(address, "GeneralStorePhoneCover")
        {
        }

        public GeneralStorePhoneCover(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void HideCover(GeneralStoreMode selectedMode)
        {
            object[] objArray1 = new object[] { selectedMode };
            base.method_8("HideCover", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnGeneralStoreModeChanged(GeneralStoreMode oldMode, GeneralStoreMode newMode)
        {
            object[] objArray1 = new object[] { oldMode, newMode };
            base.method_8("OnGeneralStoreModeChanged", objArray1);
        }

        public static bool OnNavigateBack()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GeneralStorePhoneCover", "OnNavigateBack", Array.Empty<object>());
        }

        public void ShowCover()
        {
            base.method_8("ShowCover", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateCoverPosition(object data)
        {
            object[] objArray1 = new object[] { data };
            base.method_8("UpdateCoverPosition", objArray1);
        }

        public GameObject m_animationClickBlocker
        {
            get
            {
                return base.method_3<GameObject>("m_animationClickBlocker");
            }
        }

        public PegUIElement m_backToCoverButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_backToCoverButton");
            }
        }

        public string m_buttonEnterAnimation
        {
            get
            {
                return base.method_4("m_buttonEnterAnimation");
            }
        }

        public List<ModeAnimation> m_buttonExitAnimations
        {
            get
            {
                Class267<ModeAnimation> class2 = base.method_3<Class267<ModeAnimation>>("m_buttonExitAnimations");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_coverClickArea
        {
            get
            {
                return base.method_3<GameObject>("m_coverClickArea");
            }
        }

        public GeneralStore m_parentStore
        {
            get
            {
                return base.method_3<GeneralStore>("m_parentStore");
            }
        }

        public float m_yPos16to9
        {
            get
            {
                return base.method_2<float>("m_yPos16to9");
            }
        }

        public float m_yPos3to2
        {
            get
            {
                return base.method_2<float>("m_yPos3to2");
            }
        }

        public static string s_coverAnimationCoroutine
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GeneralStorePhoneCover", "s_coverAnimationCoroutine");
            }
        }

        [Attribute38("GeneralStorePhoneCover.ModeAnimation")]
        public class ModeAnimation : MonoClass
        {
            public ModeAnimation(IntPtr address) : this(address, "ModeAnimation")
            {
            }

            public ModeAnimation(IntPtr address, string className) : base(address, className)
            {
            }

            public GeneralStoreMode m_mode
            {
                get
                {
                    return base.method_2<GeneralStoreMode>("m_mode");
                }
            }

            public string m_playAnimationName
            {
                get
                {
                    return base.method_4("m_playAnimationName");
                }
            }
        }
    }
}

