namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("SpellState")]
    public class SpellState : MonoBehaviour
    {
        public SpellState(IntPtr address) : this(address, "SpellState")
        {
        }

        public SpellState(IntPtr address, string className) : base(address, className)
        {
        }

        public void HideState()
        {
            base.method_8("HideState", Array.Empty<object>());
        }

        public void OnChangeState(SpellStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("OnChangeState", objArray1);
        }

        public void OnLoad()
        {
            base.method_8("OnLoad", Array.Empty<object>());
        }

        public void OnSpellFinished()
        {
            base.method_8("OnSpellFinished", Array.Empty<object>());
        }

        public void OnStateFinished()
        {
            base.method_8("OnStateFinished", Array.Empty<object>());
        }

        public void Play()
        {
            base.method_8("Play", Array.Empty<object>());
        }

        public void PlayImpl()
        {
            base.method_8("PlayImpl", Array.Empty<object>());
        }

        public void PlayNow()
        {
            base.method_8("PlayNow", Array.Empty<object>());
        }

        public void ShowState()
        {
            base.method_8("ShowState", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public List<SpellStateAudioSource> m_AudioSources
        {
            get
            {
                Class267<SpellStateAudioSource> class2 = base.method_3<Class267<SpellStateAudioSource>>("m_AudioSources");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<SpellStateAnimObject> m_ExternalAnimatedObjects
        {
            get
            {
                Class267<SpellStateAnimObject> class2 = base.method_3<Class267<SpellStateAnimObject>>("m_ExternalAnimatedObjects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_initialized
        {
            get
            {
                return base.method_2<bool>("m_initialized");
            }
        }

        public bool m_playing
        {
            get
            {
                return base.method_2<bool>("m_playing");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }

        public Spell m_spell
        {
            get
            {
                return base.method_3<Spell>("m_spell");
            }
        }

        public float m_StartDelaySec
        {
            get
            {
                return base.method_2<float>("m_StartDelaySec");
            }
        }

        public SpellStateType m_StateType
        {
            get
            {
                return base.method_2<SpellStateType>("m_StateType");
            }
        }
    }
}

