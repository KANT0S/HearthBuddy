namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("AnimateTransitions")]
    public class AnimateTransitions : MonoBehaviour
    {
        public AnimateTransitions(IntPtr address) : this(address, "AnimateTransitions")
        {
        }

        public AnimateTransitions(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartTransitions()
        {
            base.method_8("StartTransitions", Array.Empty<object>());
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

        public List<GameObject> m_TargetList
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_TargetList");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Renderer> rend
        {
            get
            {
                Class267<Renderer> class2 = base.method_3<Class267<Renderer>>("rend");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

