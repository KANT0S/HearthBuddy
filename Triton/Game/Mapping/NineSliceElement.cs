namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("NineSliceElement")]
    public class NineSliceElement : MonoBehaviour
    {
        public NineSliceElement(IntPtr address) : this(address, "NineSliceElement")
        {
        }

        public NineSliceElement(IntPtr address, string className) : base(address, className)
        {
        }

        public OrientedBounds GetSliceBounds(GameObject slice)
        {
            object[] objArray1 = new object[] { slice };
            return base.method_14<OrientedBounds>("GetSliceBounds", objArray1);
        }

        public Vector2 GetWorldDimensions()
        {
            return base.method_11<Vector2>("GetWorldDimensions", Array.Empty<object>());
        }

        public void SetEntireHeight(float height)
        {
            object[] objArray1 = new object[] { height };
            base.method_8("SetEntireHeight", objArray1);
        }

        public void SetEntireSize(Vector2 size)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { size };
            base.method_9("SetEntireSize", enumArray1, objArray1);
        }

        public void SetEntireSize(float width, float height)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.R4, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { width, height };
            base.method_9("SetEntireSize", enumArray1, objArray1);
        }

        public void SetEntireWidth(float width)
        {
            object[] objArray1 = new object[] { width };
            base.method_8("SetEntireWidth", objArray1);
        }

        public void SetHeight(float height)
        {
            object[] objArray1 = new object[] { height };
            base.method_8("SetHeight", objArray1);
        }

        public void SetMiddleScale(float scaleWidth, float scaleHeight)
        {
            object[] objArray1 = new object[] { scaleWidth, scaleHeight };
            base.method_8("SetMiddleScale", objArray1);
        }

        public void SetSize(Vector2 size)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { size };
            base.method_9("SetSize", enumArray1, objArray1);
        }

        public void SetSize(float width, float height)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.R4, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { width, height };
            base.method_9("SetSize", enumArray1, objArray1);
        }

        public void SetWidth(float width)
        {
            object[] objArray1 = new object[] { width };
            base.method_8("SetWidth", objArray1);
        }

        public void UpdateAllSlices()
        {
            base.method_8("UpdateAllSlices", Array.Empty<object>());
        }

        public void UpdateSegmentsToMatchMiddle()
        {
            base.method_8("UpdateSegmentsToMatchMiddle", Array.Empty<object>());
        }

        public MultiSliceElement.Slice m_bottom
        {
            get
            {
                return base.method_3<MultiSliceElement.Slice>("m_bottom");
            }
        }

        public MultiSliceElement.Slice m_bottomLeft
        {
            get
            {
                return base.method_3<MultiSliceElement.Slice>("m_bottomLeft");
            }
        }

        public MultiSliceElement.Slice m_bottomRight
        {
            get
            {
                return base.method_3<MultiSliceElement.Slice>("m_bottomRight");
            }
        }

        public MultiSliceElement.Slice m_btmRow
        {
            get
            {
                return base.method_3<MultiSliceElement.Slice>("m_btmRow");
            }
        }

        public MultiSliceElement.Direction m_HeightDirection
        {
            get
            {
                return base.method_2<MultiSliceElement.Direction>("m_HeightDirection");
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

        public MultiSliceElement.Slice m_left
        {
            get
            {
                return base.method_3<MultiSliceElement.Slice>("m_left");
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

        public MultiSliceElement.Slice m_middle
        {
            get
            {
                return base.method_3<MultiSliceElement.Slice>("m_middle");
            }
        }

        public MultiSliceElement.Slice m_midRow
        {
            get
            {
                return base.method_3<MultiSliceElement.Slice>("m_midRow");
            }
        }

        public bool m_reverse
        {
            get
            {
                return base.method_2<bool>("m_reverse");
            }
        }

        public MultiSliceElement.Slice m_right
        {
            get
            {
                return base.method_3<MultiSliceElement.Slice>("m_right");
            }
        }

        public MultiSliceElement.Slice m_top
        {
            get
            {
                return base.method_3<MultiSliceElement.Slice>("m_top");
            }
        }

        public MultiSliceElement.Slice m_topLeft
        {
            get
            {
                return base.method_3<MultiSliceElement.Slice>("m_topLeft");
            }
        }

        public MultiSliceElement.Slice m_topRight
        {
            get
            {
                return base.method_3<MultiSliceElement.Slice>("m_topRight");
            }
        }

        public MultiSliceElement.Slice m_topRow
        {
            get
            {
                return base.method_3<MultiSliceElement.Slice>("m_topRow");
            }
        }

        public bool m_useUberText
        {
            get
            {
                return base.method_2<bool>("m_useUberText");
            }
        }

        public MultiSliceElement.Direction m_WidthDirection
        {
            get
            {
                return base.method_2<MultiSliceElement.Direction>("m_WidthDirection");
            }
        }

        public MultiSliceElement.XAxisAlign m_XAlign
        {
            get
            {
                return base.method_2<MultiSliceElement.XAxisAlign>("m_XAlign");
            }
        }

        public MultiSliceElement.YAxisAlign m_YAlign
        {
            get
            {
                return base.method_2<MultiSliceElement.YAxisAlign>("m_YAlign");
            }
        }

        public MultiSliceElement.ZAxisAlign m_ZAlign
        {
            get
            {
                return base.method_2<MultiSliceElement.ZAxisAlign>("m_ZAlign");
            }
        }
    }
}

