namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("TextureOffsetStates")]
    public class TextureOffsetStates : MonoBehaviour
    {
        public TextureOffsetStates(IntPtr address) : this(address, "TextureOffsetStates")
        {
        }

        public TextureOffsetStates(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public string CurrentState
        {
            get
            {
                return base.method_13("get_CurrentState", Array.Empty<object>());
            }
        }

        public string m_currentState
        {
            get
            {
                return base.method_4("m_currentState");
            }
        }

        public Material m_originalMaterial
        {
            get
            {
                return base.method_3<Material>("m_originalMaterial");
            }
        }

        public List<TextureOffsetState> m_states
        {
            get
            {
                Class247<TextureOffsetState> class2 = base.method_3<Class247<TextureOffsetState>>("m_states");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

