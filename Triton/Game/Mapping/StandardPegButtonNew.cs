namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("StandardPegButtonNew")]
    public class StandardPegButtonNew : PegUIElement
    {
        public StandardPegButtonNew(IntPtr address) : this(address, "StandardPegButtonNew")
        {
        }

        public StandardPegButtonNew(IntPtr address, string className) : base(address, className)
        {
        }

        public void Disable()
        {
            base.method_8("Disable", Array.Empty<object>());
        }

        public void Enable()
        {
            base.method_8("Enable", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void LockHighlight()
        {
            base.method_8("LockHighlight", Array.Empty<object>());
        }

        public void OnOut(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOut", objArray1);
        }

        public void OnOver(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOver", objArray1);
        }

        public void OnPress()
        {
            base.method_8("OnPress", Array.Empty<object>());
        }

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public void Reset()
        {
            base.method_8("Reset", Array.Empty<object>());
        }

        public void SetText(string t)
        {
            object[] objArray1 = new object[] { t };
            base.method_8("SetText", objArray1);
        }

        public void SetWidth(float globalWidth)
        {
            object[] objArray1 = new object[] { globalWidth };
            base.method_8("SetWidth", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void UnlockHighlight()
        {
            base.method_8("UnlockHighlight", Array.Empty<object>());
        }

        public static float GRAY_FRAME_SCALE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "StandardPegButtonNew", "GRAY_FRAME_SCALE");
            }
        }

        public static float HIGHLIGHT_SCALE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "StandardPegButtonNew", "HIGHLIGHT_SCALE");
            }
        }

        public ThreeSliceElement m_border
        {
            get
            {
                return base.method_3<ThreeSliceElement>("m_border");
            }
        }

        public ThreeSliceElement m_button
        {
            get
            {
                return base.method_3<ThreeSliceElement>("m_button");
            }
        }

        public UberText m_buttonText
        {
            get
            {
                return base.method_3<UberText>("m_buttonText");
            }
        }

        public float m_buttonWidth
        {
            get
            {
                return base.method_2<float>("m_buttonWidth");
            }
        }

        public GameObject m_downBone
        {
            get
            {
                return base.method_3<GameObject>("m_downBone");
            }
        }

        public bool m_ExecuteInEditMode
        {
            get
            {
                return base.method_2<bool>("m_ExecuteInEditMode");
            }
        }

        public ThreeSliceElement m_highlight
        {
            get
            {
                return base.method_3<ThreeSliceElement>("m_highlight");
            }
        }

        public bool m_highlightLocked
        {
            get
            {
                return base.method_2<bool>("m_highlightLocked");
            }
        }

        public GameObject m_upBone
        {
            get
            {
                return base.method_3<GameObject>("m_upBone");
            }
        }
    }
}

