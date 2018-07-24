namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ButtonListMenuDef")]
    public class ButtonListMenuDef : MonoBehaviour
    {
        public ButtonListMenuDef(IntPtr address) : this(address, "ButtonListMenuDef")
        {
        }

        public ButtonListMenuDef(IntPtr address, string className) : base(address, className)
        {
        }

        public NineSliceElement m_background
        {
            get
            {
                return base.method_3<NineSliceElement>("m_background");
            }
        }

        public NineSliceElement m_border
        {
            get
            {
                return base.method_3<NineSliceElement>("m_border");
            }
        }

        public MultiSliceElement m_buttonContainer
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_buttonContainer");
            }
        }

        public MultiSliceElement m_header
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_header");
            }
        }

        public GameObject m_headerMiddle
        {
            get
            {
                return base.method_3<GameObject>("m_headerMiddle");
            }
        }

        public UberText m_headerText
        {
            get
            {
                return base.method_3<UberText>("m_headerText");
            }
        }

        public Vector3 m_horizontalDividerMinPadding
        {
            get
            {
                return base.method_2<Vector3>("m_horizontalDividerMinPadding");
            }
        }

        public UIBButton m_templateButton
        {
            get
            {
                return base.method_3<UIBButton>("m_templateButton");
            }
        }

        public GameObject m_templateHorizontalDivider
        {
            get
            {
                return base.method_3<GameObject>("m_templateHorizontalDivider");
            }
        }
    }
}

