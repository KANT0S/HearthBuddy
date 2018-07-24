namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FramedRadioButton")]
    public class FramedRadioButton : MonoBehaviour
    {
        public FramedRadioButton(IntPtr address) : this(address, "FramedRadioButton")
        {
        }

        public FramedRadioButton(IntPtr address, string className) : base(address, className)
        {
        }

        public Bounds GetBounds()
        {
            return base.method_11<Bounds>("GetBounds", Array.Empty<object>());
        }

        public int GetButtonID()
        {
            return base.method_11<int>("GetButtonID", Array.Empty<object>());
        }

        public float GetLeftEdgeOffset()
        {
            return base.method_11<float>("GetLeftEdgeOffset", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void Init(FrameType frameType, string text, int buttonID, object userData)
        {
            object[] objArray1 = new object[] { frameType, text, buttonID, userData };
            base.method_8("Init", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public GameObject m_frameEndLeft
        {
            get
            {
                return base.method_3<GameObject>("m_frameEndLeft");
            }
        }

        public GameObject m_frameEndRight
        {
            get
            {
                return base.method_3<GameObject>("m_frameEndRight");
            }
        }

        public GameObject m_frameFill
        {
            get
            {
                return base.method_3<GameObject>("m_frameFill");
            }
        }

        public GameObject m_frameLeft
        {
            get
            {
                return base.method_3<GameObject>("m_frameLeft");
            }
        }

        public float m_leftEdgeOffset
        {
            get
            {
                return base.method_2<float>("m_leftEdgeOffset");
            }
        }

        public RadioButton m_radioButton
        {
            get
            {
                return base.method_3<RadioButton>("m_radioButton");
            }
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }

        public UberText m_text
        {
            get
            {
                return base.method_3<UberText>("m_text");
            }
        }

        public enum FrameType
        {
            SINGLE,
            MULTI_LEFT_END,
            MULTI_RIGHT_END,
            MULTI_MIDDLE
        }
    }
}

