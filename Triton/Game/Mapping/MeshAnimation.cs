namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("MeshAnimation")]
    public class MeshAnimation : MonoBehaviour
    {
        public MeshAnimation(IntPtr address) : this(address, "MeshAnimation")
        {
        }

        public MeshAnimation(IntPtr address, string className) : base(address, className)
        {
        }

        public void Play()
        {
            base.method_8("Play", Array.Empty<object>());
        }

        public void Reset()
        {
            base.method_8("Reset", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Stop()
        {
            base.method_8("Stop", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public float FrameDuration
        {
            get
            {
                return base.method_2<float>("FrameDuration");
            }
        }

        public bool Loop
        {
            get
            {
                return base.method_2<bool>("Loop");
            }
        }

        public float m_FrameTime
        {
            get
            {
                return base.method_2<float>("m_FrameTime");
            }
        }

        public int m_Index
        {
            get
            {
                return base.method_2<int>("m_Index");
            }
        }

        public bool m_Playing
        {
            get
            {
                return base.method_2<bool>("m_Playing");
            }
        }

        public List<Mesh> Meshes
        {
            get
            {
                Class247<Mesh> class2 = base.method_3<Class247<Mesh>>("Meshes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

