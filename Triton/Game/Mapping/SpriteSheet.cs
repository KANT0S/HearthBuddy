namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("SpriteSheet")]
    public class SpriteSheet : MonoBehaviour
    {
        public SpriteSheet(IntPtr address) : this(address, "SpriteSheet")
        {
        }

        public SpriteSheet(IntPtr address, string className) : base(address, className)
        {
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public int _uvTieX
        {
            get
            {
                return base.method_2<int>("_uvTieX");
            }
        }

        public int _uvTieY
        {
            get
            {
                return base.method_2<int>("_uvTieY");
            }
        }

        public float m_fps
        {
            get
            {
                return base.method_2<float>("m_fps");
            }
        }

        public int m_LastIdx
        {
            get
            {
                return base.method_2<int>("m_LastIdx");
            }
        }

        public float m_NextFrame
        {
            get
            {
                return base.method_2<float>("m_NextFrame");
            }
        }

        public bool m_Old_Mode
        {
            get
            {
                return base.method_2<bool>("m_Old_Mode");
            }
        }

        public Vector2 m_Size
        {
            get
            {
                return base.method_2<Vector2>("m_Size");
            }
        }

        public int m_X
        {
            get
            {
                return base.method_2<int>("m_X");
            }
        }

        public int m_Y
        {
            get
            {
                return base.method_2<int>("m_Y");
            }
        }
    }
}

