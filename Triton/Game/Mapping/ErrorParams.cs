namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("ErrorParams")]
    public class ErrorParams : MonoClass
    {
        public ErrorParams(IntPtr address) : this(address, "ErrorParams")
        {
        }

        public ErrorParams(IntPtr address, string className) : base(address, className)
        {
        }

        public object m_ackUserData
        {
            get
            {
                return base.method_3<object>("m_ackUserData");
            }
        }

        public bool m_allowClick
        {
            get
            {
                return base.method_2<bool>("m_allowClick");
            }
        }

        public float m_delayBeforeNextReset
        {
            get
            {
                return base.method_2<float>("m_delayBeforeNextReset");
            }
        }

        public string m_header
        {
            get
            {
                return base.method_4("m_header");
            }
        }

        public string m_message
        {
            get
            {
                return base.method_4("m_message");
            }
        }

        public bool m_redirectToStore
        {
            get
            {
                return base.method_2<bool>("m_redirectToStore");
            }
        }

        public Triton.Game.Mapping.ErrorType m_type
        {
            get
            {
                return base.method_2<Triton.Game.Mapping.ErrorType>("m_type");
            }
        }
    }
}

