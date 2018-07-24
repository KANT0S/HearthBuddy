namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("MultiSliceElement")]
    public class MultiSliceElement : MonoBehaviour
    {
        public MultiSliceElement(IntPtr address) : this(address, "MultiSliceElement")
        {
        }

        public MultiSliceElement(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddSlice(GameObject obj)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { obj };
            base.method_9("AddSlice", enumArray1, objArray1);
        }

        public void AddSlice(GameObject obj, Vector3 minLocalPadding, Vector3 maxLocalPadding, bool reverse)
        {
            object[] objArray1 = new object[] { obj, minLocalPadding, maxLocalPadding, reverse };
            base.method_9("AddSlice", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void ClearSlices()
        {
            base.method_8("ClearSlices", Array.Empty<object>());
        }

        public static Vector3 GetAlignmentVector(Vector3 interpolate, XAxisAlign x, YAxisAlign y, ZAxisAlign z)
        {
            object[] objArray1 = new object[] { interpolate, x, y, z };
            return MonoClass.smethod_14<Vector3>(TritonHs.MainAssemblyPath, "", "MultiSliceElement", "GetAlignmentVector", objArray1);
        }

        public void UpdateSlices()
        {
            base.method_8("UpdateSlices", Array.Empty<object>());
        }

        public Direction m_direction
        {
            get
            {
                return base.method_2<Direction>("m_direction");
            }
        }

        public List<GameObject> m_ignore
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_ignore");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Vector3 m_localPinnedPointOffset
        {
            get
            {
                return base.method_2<Vector3>("m_localPinnedPointOffset");
            }
        }

        public Vector3 m_localSliceSpacing
        {
            get
            {
                return base.method_2<Vector3>("m_localSliceSpacing");
            }
        }

        public bool m_reverse
        {
            get
            {
                return base.method_2<bool>("m_reverse");
            }
        }

        public List<Slice> m_slices
        {
            get
            {
                Class267<Slice> class2 = base.method_3<Class267<Slice>>("m_slices");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_useUberText
        {
            get
            {
                return base.method_2<bool>("m_useUberText");
            }
        }

        public XAxisAlign m_XAlign
        {
            get
            {
                return base.method_2<XAxisAlign>("m_XAlign");
            }
        }

        public YAxisAlign m_YAlign
        {
            get
            {
                return base.method_2<YAxisAlign>("m_YAlign");
            }
        }

        public ZAxisAlign m_ZAlign
        {
            get
            {
                return base.method_2<ZAxisAlign>("m_ZAlign");
            }
        }

        public enum Direction
        {
            X,
            Y,
            Z
        }

        [Attribute38("MultiSliceElement.Slice")]
        public class Slice : MonoClass
        {
            public Slice(IntPtr address) : this(address, "Slice")
            {
            }

            public Slice(IntPtr address, string className) : base(address, className)
            {
            }

            public static GameObject op_Implicit(MultiSliceElement.Slice slice)
            {
                object[] objArray1 = new object[] { slice };
                return MonoClass.smethod_15<GameObject>(TritonHs.MainAssemblyPath, "", "Slice", "op_Implicit", objArray1);
            }

            public Vector3 m_maxLocalPadding
            {
                get
                {
                    return base.method_2<Vector3>("m_maxLocalPadding");
                }
            }

            public Vector3 m_minLocalPadding
            {
                get
                {
                    return base.method_2<Vector3>("m_minLocalPadding");
                }
            }

            public bool m_reverse
            {
                get
                {
                    return base.method_2<bool>("m_reverse");
                }
            }

            public GameObject m_slice
            {
                get
                {
                    return base.method_3<GameObject>("m_slice");
                }
            }
        }

        public enum XAxisAlign
        {
            LEFT,
            MIDDLE,
            RIGHT
        }

        public enum YAxisAlign
        {
            TOP,
            MIDDLE,
            BOTTOM
        }

        public enum ZAxisAlign
        {
            FRONT,
            MIDDLE,
            BACK
        }
    }
}

