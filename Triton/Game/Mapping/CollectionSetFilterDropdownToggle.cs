namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CollectionSetFilterDropdownToggle")]
    public class CollectionSetFilterDropdownToggle : PegUIElement
    {
        public CollectionSetFilterDropdownToggle(IntPtr address) : this(address, "CollectionSetFilterDropdownToggle")
        {
        }

        public CollectionSetFilterDropdownToggle(IntPtr address, string className) : base(address, className)
        {
        }

        public void SetEnabledVisual(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("SetEnabledVisual", objArray1);
        }

        public MeshRenderer m_buttonMesh
        {
            get
            {
                return base.method_3<MeshRenderer>("m_buttonMesh");
            }
        }

        public MeshRenderer m_currentIconQuad
        {
            get
            {
                return base.method_3<MeshRenderer>("m_currentIconQuad");
            }
        }
    }
}

