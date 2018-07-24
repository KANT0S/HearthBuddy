namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DialogBase")]
    public class DialogBase : MonoBehaviour
    {
        public DialogBase(IntPtr address) : this(address, "DialogBase")
        {
        }

        public DialogBase(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DoHideAnimation()
        {
            base.method_8("DoHideAnimation", Array.Empty<object>());
        }

        public void DoShowAnimation()
        {
            base.method_8("DoShowAnimation", Array.Empty<object>());
        }

        public void FireHideListeners()
        {
            base.method_8("FireHideListeners", Array.Empty<object>());
        }

        public void GoBack()
        {
            base.method_8("GoBack", Array.Empty<object>());
        }

        public bool HandleKeyboardInput()
        {
            return base.method_11<bool>("HandleKeyboardInput", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public void OnHideAnimFinished()
        {
            base.method_8("OnHideAnimFinished", Array.Empty<object>());
        }

        public void OnShowAnimFinished()
        {
            base.method_8("OnShowAnimFinished", Array.Empty<object>());
        }

        public void SetHiddenPosition(Camera referenceCamera)
        {
            object[] objArray1 = new object[] { referenceCamera };
            base.method_8("SetHiddenPosition", objArray1);
        }

        public void SetShownPosition()
        {
            base.method_8("SetShownPosition", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public Vector3 m_originalPosition
        {
            get
            {
                return base.method_2<Vector3>("m_originalPosition");
            }
        }

        public Vector3 m_originalScale
        {
            get
            {
                return base.method_2<Vector3>("m_originalScale");
            }
        }

        public ShowAnimState m_showAnimState
        {
            get
            {
                return base.method_2<ShowAnimState>("m_showAnimState");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }

        public Vector3 PUNCH_SCALE
        {
            get
            {
                return base.method_2<Vector3>("PUNCH_SCALE");
            }
        }

        public Vector3 START_SCALE
        {
            get
            {
                return base.method_2<Vector3>("START_SCALE");
            }
        }

        public enum ShowAnimState
        {
            NOT_CALLED,
            IN_PROGRESS,
            FINISHED
        }
    }
}

