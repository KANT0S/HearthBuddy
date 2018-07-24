namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("PlayAnimRandomStart")]
    public class PlayAnimRandomStart : MonoBehaviour
    {
        public PlayAnimRandomStart(IntPtr address) : this(address, "PlayAnimRandomStart")
        {
        }

        public PlayAnimRandomStart(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public string animName
        {
            get
            {
                return base.method_4("animName");
            }
        }

        public List<GameObject> m_Bubbles
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_Bubbles");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float MaxSpeed
        {
            get
            {
                return base.method_2<float>("MaxSpeed");
            }
        }

        public float maxWait
        {
            get
            {
                return base.method_2<float>("maxWait");
            }
        }

        public float MinSpeed
        {
            get
            {
                return base.method_2<float>("MinSpeed");
            }
        }

        public float minWait
        {
            get
            {
                return base.method_2<float>("minWait");
            }
        }
    }
}

