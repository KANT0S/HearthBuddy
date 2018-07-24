namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("UIBScrollableItem")]
    public class UIBScrollableItem : MonoBehaviour
    {
        public UIBScrollableItem(IntPtr address) : this(address, "UIBScrollableItem")
        {
        }

        public UIBScrollableItem(IntPtr address, string className) : base(address, className)
        {
        }

        public List<Vector3> GetBoundsPoints()
        {
            Class246<Vector3> class2 = base.method_14<Class246<Vector3>>("GetBoundsPoints", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public OrientedBounds GetOrientedBounds()
        {
            return base.method_14<OrientedBounds>("GetOrientedBounds", Array.Empty<object>());
        }

        public bool IsActive()
        {
            return base.method_11<bool>("IsActive", Array.Empty<object>());
        }

        public ActiveState m_active
        {
            get
            {
                return base.method_2<ActiveState>("m_active");
            }
        }

        public Vector3 m_offset
        {
            get
            {
                return base.method_2<Vector3>("m_offset");
            }
        }

        public Vector3 m_size
        {
            get
            {
                return base.method_2<Vector3>("m_size");
            }
        }

        public enum ActiveState
        {
            Active,
            Inactive,
            UseHierarchy
        }
    }
}

