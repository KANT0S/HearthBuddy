namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("UIBObjectSpacing")]
    public class UIBObjectSpacing : MonoBehaviour
    {
        public UIBObjectSpacing(IntPtr address) : this(address, "UIBObjectSpacing")
        {
        }

        public UIBObjectSpacing(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddObject(Component comp, bool countIfNull)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { comp, countIfNull };
            base.method_9("AddObject", enumArray1, objArray1);
        }

        public void AddObject(GameObject obj, bool countIfNull)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { obj, countIfNull };
            base.method_9("AddObject", enumArray1, objArray1);
        }

        public void AddObject(Component comp, Vector3 offset, bool countIfNull)
        {
            object[] objArray1 = new object[] { comp, offset, countIfNull };
            base.method_9("AddObject", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void AddObject(GameObject obj, Vector3 offset, bool countIfNull)
        {
            object[] objArray1 = new object[] { obj, offset, countIfNull };
            base.method_9("AddObject", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void AddSpace(int index)
        {
            object[] objArray1 = new object[] { index };
            base.method_8("AddSpace", objArray1);
        }

        public void AnimateUpdatePositions(float animTime, iTween.EaseType tweenType)
        {
            object[] objArray1 = new object[] { animTime, tweenType };
            base.method_8("AnimateUpdatePositions", objArray1);
        }

        public void ClearObjects()
        {
            base.method_8("ClearObjects", Array.Empty<object>());
        }

        public void UpdatePositions()
        {
            base.method_8("UpdatePositions", Array.Empty<object>());
        }

        public Vector3 Alignment
        {
            get
            {
                return base.method_11<Vector3>("get_Alignment", Array.Empty<object>());
            }
        }

        public Vector3 LocalOffset
        {
            get
            {
                return base.method_11<Vector3>("get_LocalOffset", Array.Empty<object>());
            }
        }

        public Vector3 LocalSpacing
        {
            get
            {
                return base.method_11<Vector3>("get_LocalSpacing", Array.Empty<object>());
            }
        }

        public Vector3 m_Alignment
        {
            get
            {
                return base.method_2<Vector3>("m_Alignment");
            }
        }

        public Vector3 m_LocalOffset
        {
            get
            {
                return base.method_2<Vector3>("m_LocalOffset");
            }
        }

        public Vector3 m_LocalSpacing
        {
            get
            {
                return base.method_2<Vector3>("m_LocalSpacing");
            }
        }

        public List<SpacedObject> m_Objects
        {
            get
            {
                Class267<SpacedObject> class2 = base.method_3<Class267<SpacedObject>>("m_Objects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_reverse
        {
            get
            {
                return base.method_2<bool>("m_reverse");
            }
        }

        [Attribute38("UIBObjectSpacing.AnimationPosition")]
        public class AnimationPosition : MonoClass
        {
            public AnimationPosition(IntPtr address) : this(address, "AnimationPosition")
            {
            }

            public AnimationPosition(IntPtr address, string className) : base(address, className)
            {
            }

            public GameObject m_object
            {
                get
                {
                    return base.method_3<GameObject>("m_object");
                }
            }

            public Vector3 m_targetPos
            {
                get
                {
                    return base.method_2<Vector3>("m_targetPos");
                }
            }
        }

        [Attribute38("UIBObjectSpacing.SpacedObject")]
        public class SpacedObject : MonoClass
        {
            public SpacedObject(IntPtr address) : this(address, "SpacedObject")
            {
            }

            public SpacedObject(IntPtr address, string className) : base(address, className)
            {
            }

            public bool m_CountIfNull
            {
                get
                {
                    return base.method_2<bool>("m_CountIfNull");
                }
            }

            public GameObject m_Object
            {
                get
                {
                    return base.method_3<GameObject>("m_Object");
                }
            }

            public Vector3 m_Offset
            {
                get
                {
                    return base.method_2<Vector3>("m_Offset");
                }
            }
        }
    }
}

