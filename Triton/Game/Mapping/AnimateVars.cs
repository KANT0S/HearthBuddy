namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("AnimateVars")]
    public class AnimateVars : MonoBehaviour
    {
        public AnimateVars(IntPtr address) : this(address, "AnimateVars")
        {
        }

        public AnimateVars(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateValue()
        {
            base.method_8("AnimateValue", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public float amount
        {
            get
            {
                return base.method_2<float>("amount");
            }
        }

        public List<GameObject> m_objects
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_objects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Renderer> m_renderers
        {
            get
            {
                Class267<Renderer> class2 = base.method_3<Class267<Renderer>>("m_renderers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public string varName
        {
            get
            {
                return base.method_4("varName");
            }
        }
    }
}

