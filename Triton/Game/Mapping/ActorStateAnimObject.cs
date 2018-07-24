namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ActorStateAnimObject")]
    public class ActorStateAnimObject : MonoClass
    {
        public ActorStateAnimObject(IntPtr address) : this(address, "ActorStateAnimObject")
        {
        }

        public ActorStateAnimObject(IntPtr address, string className) : base(address, className)
        {
        }

        public void Init()
        {
            base.method_8("Init", Array.Empty<object>());
        }

        public void Play()
        {
            base.method_8("Play", Array.Empty<object>());
        }

        public void Stop()
        {
            base.method_9("Stop", new Class272.Enum20[0], Array.Empty<object>());
        }

        public int m_AnimLayer
        {
            get
            {
                return base.method_2<int>("m_AnimLayer");
            }
        }

        public string m_Comment
        {
            get
            {
                return base.method_4("m_Comment");
            }
        }

        public bool m_ControlParticles
        {
            get
            {
                return base.method_2<bool>("m_ControlParticles");
            }
        }

        public float m_CrossFadeSec
        {
            get
            {
                return base.method_2<float>("m_CrossFadeSec");
            }
        }

        public bool m_EmitParticles
        {
            get
            {
                return base.method_2<bool>("m_EmitParticles");
            }
        }

        public bool m_Enabled
        {
            get
            {
                return base.method_2<bool>("m_Enabled");
            }
        }

        public GameObject m_GameObject
        {
            get
            {
                return base.method_3<GameObject>("m_GameObject");
            }
        }

        public bool m_prevParticleEmitValue
        {
            get
            {
                return base.method_2<bool>("m_prevParticleEmitValue");
            }
        }
    }
}

