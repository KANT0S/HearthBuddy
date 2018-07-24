namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdventureWingProgressDisplay_LOE")]
    public class AdventureWingProgressDisplay_LOE : AdventureWingProgressDisplay
    {
        public AdventureWingProgressDisplay_LOE(IntPtr address) : this(address, "AdventureWingProgressDisplay_LOE")
        {
        }

        public AdventureWingProgressDisplay_LOE(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool HasProgressAnimationToPlay()
        {
            return base.method_11<bool>("HasProgressAnimationToPlay", Array.Empty<object>());
        }

        public void OnCompleteStaffClick()
        {
            base.method_8("OnCompleteStaffClick", Array.Empty<object>());
        }

        public void OnHangingSignClick()
        {
            base.method_8("OnHangingSignClick", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdatePartVisibility()
        {
            base.method_8("UpdatePartVisibility", Array.Empty<object>());
        }

        public void UpdateProgress(WingDbId wingDbId, bool normalComplete)
        {
            object[] objArray1 = new object[] { wingDbId, normalComplete };
            base.method_8("UpdateProgress", objArray1);
        }

        public bool m_animating
        {
            get
            {
                return base.method_2<bool>("m_animating");
            }
        }

        public PegUIElement m_completeStaffHitArea
        {
            get
            {
                return base.method_3<PegUIElement>("m_completeStaffHitArea");
            }
        }

        public string m_completeStaffQuotePrefab
        {
            get
            {
                return base.method_4("m_completeStaffQuotePrefab");
            }
        }

        public string m_completeStaffQuoteVOLine
        {
            get
            {
                return base.method_4("m_completeStaffQuoteVOLine");
            }
        }

        public List<GameObject> m_emptyStaffObjects
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_emptyStaffObjects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_finalWingComplete
        {
            get
            {
                return base.method_2<bool>("m_finalWingComplete");
            }
        }

        public PegUIElement m_hangingSignHitArea
        {
            get
            {
                return base.method_3<PegUIElement>("m_hangingSignHitArea");
            }
        }

        public string m_hangingSignQuotePrefab
        {
            get
            {
                return base.method_4("m_hangingSignQuotePrefab");
            }
        }

        public string m_hangingSignQuoteVOLine
        {
            get
            {
                return base.method_4("m_hangingSignQuoteVOLine");
            }
        }

        public UberText m_hangingSignText
        {
            get
            {
                return base.method_3<UberText>("m_hangingSignText");
            }
        }

        public bool m_headComplete
        {
            get
            {
                return base.method_2<bool>("m_headComplete");
            }
        }

        public List<GameObject> m_headObjects
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_headObjects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_pearlComplete
        {
            get
            {
                return base.method_2<bool>("m_pearlComplete");
            }
        }

        public List<GameObject> m_pearlObjects
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_pearlObjects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_rodComplete
        {
            get
            {
                return base.method_2<bool>("m_rodComplete");
            }
        }

        public List<GameObject> m_rodObjects
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_rodObjects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<GameObject> m_visibleStaffObjects
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_visibleStaffObjects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static string s_CompleteAnimationVarName
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureWingProgressDisplay_LOE", "s_CompleteAnimationVarName");
            }
        }

        public static string s_WingDisappearAnimateEventName
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureWingProgressDisplay_LOE", "s_WingDisappearAnimateEventName");
            }
        }

        public static string s_WingReappearAnimateEventName
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureWingProgressDisplay_LOE", "s_WingReappearAnimateEventName");
            }
        }
    }
}

