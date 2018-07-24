namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("Flipbook")]
    public class Flipbook : MonoBehaviour
    {
        public Flipbook(IntPtr address) : this(address, "Flipbook")
        {
        }

        public Flipbook(IntPtr address, string className) : base(address, className)
        {
        }

        public void SetIndex(int i)
        {
            object[] objArray1 = new object[] { i };
            base.method_8("SetIndex", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public bool m_animate
        {
            get
            {
                return base.method_2<bool>("m_animate");
            }
        }

        public float m_flipbookFrame
        {
            get
            {
                return base.method_2<float>("m_flipbookFrame");
            }
        }

        public int m_flipbookLastOffset
        {
            get
            {
                return base.method_2<int>("m_flipbookLastOffset");
            }
        }

        public List<Vector2> m_flipbookOffsets
        {
            get
            {
                Class246<Vector2> class2 = base.method_3<Class246<Vector2>>("m_flipbookOffsets");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_flipbookRandom
        {
            get
            {
                return base.method_2<bool>("m_flipbookRandom");
            }
        }

        public float m_flipbookRate
        {
            get
            {
                return base.method_2<float>("m_flipbookRate");
            }
        }

        public bool m_flipbookReverse
        {
            get
            {
                return base.method_2<bool>("m_flipbookReverse");
            }
        }

        public float m_RandomRateMax
        {
            get
            {
                return base.method_2<float>("m_RandomRateMax");
            }
        }

        public float m_RandomRateMin
        {
            get
            {
                return base.method_2<float>("m_RandomRateMin");
            }
        }

        public bool m_RandomRateRange
        {
            get
            {
                return base.method_2<bool>("m_RandomRateRange");
            }
        }

        public bool m_reverse
        {
            get
            {
                return base.method_2<bool>("m_reverse");
            }
        }
    }
}

