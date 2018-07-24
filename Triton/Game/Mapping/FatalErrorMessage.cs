namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("FatalErrorMessage")]
    public class FatalErrorMessage : MonoClass
    {
        public FatalErrorMessage(IntPtr address) : this(address, "FatalErrorMessage")
        {
        }

        public FatalErrorMessage(IntPtr address, string className) : base(address, className)
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

        public string m_id
        {
            get
            {
                return base.method_4("m_id");
            }
        }

        public bool m_redirectToStore
        {
            get
            {
                return base.method_2<bool>("m_redirectToStore");
            }
        }

        public string m_text
        {
            get
            {
                return base.method_4("m_text");
            }
        }
    }
}

