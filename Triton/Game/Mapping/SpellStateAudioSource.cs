namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SpellStateAudioSource")]
    public class SpellStateAudioSource : MonoClass
    {
        public SpellStateAudioSource(IntPtr address) : this(address, "SpellStateAudioSource")
        {
        }

        public SpellStateAudioSource(IntPtr address, string className) : base(address, className)
        {
        }

        public void Init()
        {
            base.method_8("Init", Array.Empty<object>());
        }

        public void Play(SpellState parent)
        {
            object[] objArray1 = new object[] { parent };
            base.method_8("Play", objArray1);
        }

        public void PlayNow()
        {
            base.method_8("PlayNow", Array.Empty<object>());
        }

        public void Stop()
        {
            base.method_8("Stop", Array.Empty<object>());
        }

        public string m_Comment
        {
            get
            {
                return base.method_4("m_Comment");
            }
        }

        public bool m_Enabled
        {
            get
            {
                return base.method_2<bool>("m_Enabled");
            }
        }

        public bool m_PlayGlobally
        {
            get
            {
                return base.method_2<bool>("m_PlayGlobally");
            }
        }

        public float m_StartDelaySec
        {
            get
            {
                return base.method_2<float>("m_StartDelaySec");
            }
        }

        public bool m_StopOnStateChange
        {
            get
            {
                return base.method_2<bool>("m_StopOnStateChange");
            }
        }
    }
}

