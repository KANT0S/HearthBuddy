namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("CollectionPageLayoutSettings")]
    public class CollectionPageLayoutSettings : MonoClass
    {
        public CollectionPageLayoutSettings(IntPtr address) : this(address, "CollectionPageLayoutSettings")
        {
        }

        public CollectionPageLayoutSettings(IntPtr address, string className) : base(address, className)
        {
        }

        public Variables GetVariables(CollectionManagerDisplay.ViewMode mode)
        {
            object[] objArray1 = new object[] { mode };
            return base.method_14<Variables>("GetVariables", objArray1);
        }

        public List<Variables> m_layoutVariables
        {
            get
            {
                Class267<Variables> class2 = base.method_3<Class267<Variables>>("m_layoutVariables");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        [Attribute38("CollectionPageLayoutSettings.Variables")]
        public class Variables : MonoClass
        {
            public Variables(IntPtr address) : this(address, "Variables")
            {
            }

            public Variables(IntPtr address, string className) : base(address, className)
            {
            }

            public int m_ColumnCount
            {
                get
                {
                    return base.method_2<int>("m_ColumnCount");
                }
            }

            public float m_ColumnSpacing
            {
                get
                {
                    return base.method_2<float>("m_ColumnSpacing");
                }
            }

            public Vector3 m_Offset
            {
                get
                {
                    return base.method_2<Vector3>("m_Offset");
                }
            }

            public int m_RowCount
            {
                get
                {
                    return base.method_2<int>("m_RowCount");
                }
            }

            public float m_RowSpacing
            {
                get
                {
                    return base.method_2<float>("m_RowSpacing");
                }
            }

            public float m_Scale
            {
                get
                {
                    return base.method_2<float>("m_Scale");
                }
            }

            public CollectionManagerDisplay.ViewMode m_ViewMode
            {
                get
                {
                    return base.method_2<CollectionManagerDisplay.ViewMode>("m_ViewMode");
                }
            }
        }
    }
}

