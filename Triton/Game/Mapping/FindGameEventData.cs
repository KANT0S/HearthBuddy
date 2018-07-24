namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("FindGameEventData")]
    public class FindGameEventData : MonoClass
    {
        public FindGameEventData(IntPtr address) : this(address, "FindGameEventData")
        {
        }

        public FindGameEventData(IntPtr address, string className) : base(address, className)
        {
        }

        public Network.GameCancelInfo m_cancelInfo
        {
            get
            {
                return base.method_3<Network.GameCancelInfo>("m_cancelInfo");
            }
        }

        public int m_queueMaxSeconds
        {
            get
            {
                return base.method_2<int>("m_queueMaxSeconds");
            }
        }

        public int m_queueMinSeconds
        {
            get
            {
                return base.method_2<int>("m_queueMinSeconds");
            }
        }

        public FindGameState m_state
        {
            get
            {
                return base.method_2<FindGameState>("m_state");
            }
        }
    }
}

