namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("HeroPickerButton")]
    public class HeroPickerButton : PegUIElement
    {
        public HeroPickerButton(IntPtr address) : this(address, "HeroPickerButton")
        {
        }

        public HeroPickerButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Activate(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("Activate", objArray1);
        }

        public Material GetClassIconMaterial(TAG_CLASS classTag)
        {
            object[] objArray1 = new object[] { classTag };
            return base.method_14<Material>("GetClassIconMaterial", objArray1);
        }

        public FullDef GetFullDef()
        {
            return base.method_14<FullDef>("GetFullDef", Array.Empty<object>());
        }

        public long GetPreconDeckID()
        {
            return base.method_11<long>("GetPreconDeckID", Array.Empty<object>());
        }

        public TAG_PREMIUM GetPremium()
        {
            return base.method_11<TAG_PREMIUM>("GetPremium", Array.Empty<object>());
        }

        public bool IsDeckValid()
        {
            return base.method_11<bool>("IsDeckValid", Array.Empty<object>());
        }

        public bool IsLocked()
        {
            return base.method_11<bool>("IsLocked", Array.Empty<object>());
        }

        public bool IsSelected()
        {
            return base.method_11<bool>("IsSelected", Array.Empty<object>());
        }

        public void Lock()
        {
            base.method_8("Lock", Array.Empty<object>());
        }

        public void Lower()
        {
            base.method_8("Lower", Array.Empty<object>());
        }

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public void Raise()
        {
            base.method_8("Raise", Array.Empty<object>());
        }

        public void SetBasicSetProgress(TAG_CLASS classTag)
        {
            object[] objArray1 = new object[] { classTag };
            base.method_8("SetBasicSetProgress", objArray1);
        }

        public void SetClassIcon(Material mat)
        {
            object[] objArray1 = new object[] { mat };
            base.method_8("SetClassIcon", objArray1);
        }

        public void SetClassname(string s)
        {
            object[] objArray1 = new object[] { s };
            base.method_8("SetClassname", objArray1);
        }

        public void SetFullDef(FullDef def)
        {
            object[] objArray1 = new object[] { def };
            base.method_8("SetFullDef", objArray1);
        }

        public void SetHighlightState(ActorStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("SetHighlightState", objArray1);
        }

        public void SetIsDeckValid(bool isValid)
        {
            object[] objArray1 = new object[] { isValid };
            base.method_8("SetIsDeckValid", objArray1);
        }

        public void SetPreconDeckID(long preconDeckID)
        {
            object[] objArray1 = new object[] { preconDeckID };
            base.method_8("SetPreconDeckID", objArray1);
        }

        public void SetPremium(TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { premium };
            base.method_8("SetPremium", objArray1);
        }

        public void SetProgress(int acknowledgedProgress, int currProgress, int maxProgress)
        {
            object[] objArray1 = new object[] { acknowledgedProgress, currProgress, maxProgress };
            base.method_9("SetProgress", new Class272.Enum20[] { Class272.Enum20.I4 }, objArray1);
        }

        public void SetProgress(int acknowledgedProgress, int currProgress, int maxProgress, bool shouldAnimate)
        {
            object[] objArray1 = new object[] { acknowledgedProgress, currProgress, maxProgress, shouldAnimate };
            base.method_9("SetProgress", new Class272.Enum20[] { Class272.Enum20.I4 }, objArray1);
        }

        public void SetSelected(bool isSelected)
        {
            object[] objArray1 = new object[] { isSelected };
            base.method_8("SetSelected", objArray1);
        }

        public void Unlock(bool animate)
        {
            object[] objArray1 = new object[] { animate };
            base.method_8("Unlock", objArray1);
        }

        public void UnlockAfterAnimate()
        {
            base.method_8("UnlockAfterAnimate", Array.Empty<object>());
        }

        public void UpdateDisplay(FullDef def, TAG_PREMIUM premium)
        {
            object[] objArray1 = new object[] { def, premium };
            base.method_8("UpdateDisplay", objArray1);
        }

        public void UpdatePortrait()
        {
            base.method_8("UpdatePortrait", Array.Empty<object>());
        }

        public static Color BASIC_SET_COLOR_IN_PROGRESS
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "HeroPickerButton", "BASIC_SET_COLOR_IN_PROGRESS");
            }
        }

        public List<Material> CLASS_MATERIALS
        {
            get
            {
                Class267<Material> class2 = base.method_3<Class267<Material>>("CLASS_MATERIALS");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public HeroPickerButtonBones m_bones
        {
            get
            {
                return base.method_3<HeroPickerButtonBones>("m_bones");
            }
        }

        public GameObject m_buttonFrame
        {
            get
            {
                return base.method_3<GameObject>("m_buttonFrame");
            }
        }

        public UberText m_classLabel
        {
            get
            {
                return base.method_3<UberText>("m_classLabel");
            }
        }

        public FullDef m_fullDef
        {
            get
            {
                return base.method_3<FullDef>("m_fullDef");
            }
        }

        public TAG_CLASS m_heroClass
        {
            get
            {
                return base.method_2<TAG_CLASS>("m_heroClass");
            }
        }

        public GameObject m_heroClassIcon
        {
            get
            {
                return base.method_3<GameObject>("m_heroClassIcon");
            }
        }

        public HighlightState m_highlightState
        {
            get
            {
                return base.method_3<HighlightState>("m_highlightState");
            }
        }

        public GameObject m_invalidDeckX
        {
            get
            {
                return base.method_3<GameObject>("m_invalidDeckX");
            }
        }

        public bool m_isDeckValid
        {
            get
            {
                return base.method_2<bool>("m_isDeckValid");
            }
        }

        public bool m_isSelected
        {
            get
            {
                return base.method_2<bool>("m_isSelected");
            }
        }

        public GameObject m_labelGradient
        {
            get
            {
                return base.method_3<GameObject>("m_labelGradient");
            }
        }

        public bool m_locked
        {
            get
            {
                return base.method_2<bool>("m_locked");
            }
        }

        public long m_preconDeckID
        {
            get
            {
                return base.method_2<long>("m_preconDeckID");
            }
        }

        public TAG_PREMIUM m_premium
        {
            get
            {
                return base.method_2<TAG_PREMIUM>("m_premium");
            }
        }

        public UberText m_setProgressLabel
        {
            get
            {
                return base.method_3<UberText>("m_setProgressLabel");
            }
        }
    }
}

