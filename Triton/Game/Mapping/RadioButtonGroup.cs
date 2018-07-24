namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    [Attribute38("RadioButtonGroup")]
    public class RadioButtonGroup : MonoBehaviour
    {
        public RadioButtonGroup(IntPtr address) : this(address, "RadioButtonGroup")
        {
        }

        public RadioButtonGroup(IntPtr address, string className) : base(address, className)
        {
        }

        public FramedRadioButton CreateNewFramedRadioButton()
        {
            return base.method_14<FramedRadioButton>("CreateNewFramedRadioButton", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void OnRadioButtonDoubleClicked(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnRadioButtonDoubleClicked", objArray1);
        }

        public void OnRadioButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnRadioButtonReleased", objArray1);
        }

        public void SetSpacingFudgeFactor(Vector3 amount)
        {
            object[] objArray1 = new object[] { amount };
            base.method_8("SetSpacingFudgeFactor", objArray1);
        }

        public GameObject m_buttonContainer
        {
            get
            {
                return base.method_3<GameObject>("m_buttonContainer");
            }
        }

        public GameObject m_firstRadioButtonBone
        {
            get
            {
                return base.method_3<GameObject>("m_firstRadioButtonBone");
            }
        }

        public FramedRadioButton m_framedRadioButtonPrefab
        {
            get
            {
                return base.method_3<FramedRadioButton>("m_framedRadioButtonPrefab");
            }
        }

        public List<FramedRadioButton> m_framedRadioButtons
        {
            get
            {
                Class267<FramedRadioButton> class2 = base.method_3<Class267<FramedRadioButton>>("m_framedRadioButtons");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Vector3 m_spacingFudgeFactor
        {
            get
            {
                return base.method_2<Vector3>("m_spacingFudgeFactor");
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ButtonData
        {
            public int m_id;
            public string m_text;
            public bool m_selected;
            public object m_userData;
        }
    }
}

