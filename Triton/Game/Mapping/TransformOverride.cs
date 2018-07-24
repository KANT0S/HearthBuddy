namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("TransformOverride")]
    public class TransformOverride : MonoBehaviour
    {
        public TransformOverride(IntPtr address) : this(address, "TransformOverride")
        {
        }

        public TransformOverride(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddCategory()
        {
            base.method_9("AddCategory", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void AddCategory(ScreenCategory screen)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { screen };
            base.method_9("AddCategory", enumArray1, objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void UpdateObject()
        {
            base.method_8("UpdateObject", Array.Empty<object>());
        }

        public List<Vector3> m_localPosition
        {
            get
            {
                Class266<Vector3> class2 = base.method_3<Class266<Vector3>>("m_localPosition");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Quaternion> m_localRotation
        {
            get
            {
                Class266<Quaternion> class2 = base.method_3<Class266<Quaternion>>("m_localRotation");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Vector3> m_localScale
        {
            get
            {
                Class266<Vector3> class2 = base.method_3<Class266<Vector3>>("m_localScale");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<ScreenCategory> m_screenCategory
        {
            get
            {
                Class266<ScreenCategory> class2 = base.method_3<Class266<ScreenCategory>>("m_screenCategory");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float testVal
        {
            get
            {
                return base.method_2<float>("testVal");
            }
        }
    }
}

