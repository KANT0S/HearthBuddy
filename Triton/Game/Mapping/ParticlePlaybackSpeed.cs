namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ParticlePlaybackSpeed")]
    public class ParticlePlaybackSpeed : MonoBehaviour
    {
        public ParticlePlaybackSpeed(IntPtr address) : this(address, "ParticlePlaybackSpeed")
        {
        }

        public ParticlePlaybackSpeed(IntPtr address, string className) : base(address, className)
        {
        }

        public void Init()
        {
            base.method_8("Init", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public float m_ParticlePlaybackSpeed
        {
            get
            {
                return base.method_2<float>("m_ParticlePlaybackSpeed");
            }
        }

        public float m_PreviousPlaybackSpeed
        {
            get
            {
                return base.method_2<float>("m_PreviousPlaybackSpeed");
            }
        }

        public bool m_RestoreSpeedOnDisable
        {
            get
            {
                return base.method_2<bool>("m_RestoreSpeedOnDisable");
            }
        }
    }
}

