namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SpellStateAnimObject")]
    public class SpellStateAnimObject : MonoClass
    {
        public SpellStateAnimObject(IntPtr address) : this(address, "SpellStateAnimObject")
        {
        }

        public SpellStateAnimObject(IntPtr address, string className) : base(address, className)
        {
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void Init()
        {
            base.method_8("Init", Array.Empty<object>());
        }

        public void OnLoad(SpellState state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("OnLoad", objArray1);
        }

        public void Play()
        {
            base.method_8("Play", Array.Empty<object>());
        }

        public void SetupAnimation()
        {
            base.method_8("SetupAnimation", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
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

        public float m_AnimSpeed
        {
            get
            {
                return base.method_2<float>("m_AnimSpeed");
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

        public Target m_Target
        {
            get
            {
                return base.method_2<Target>("m_Target");
            }
        }

        public enum Target
        {
            AS_SPECIFIED,
            ACTOR,
            ROOT_OBJECT
        }
    }
}

