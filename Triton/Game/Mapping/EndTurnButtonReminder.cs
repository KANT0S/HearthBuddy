namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("EndTurnButtonReminder")]
    public class EndTurnButtonReminder : MonoBehaviour
    {
        public EndTurnButtonReminder(IntPtr address) : this(address, "EndTurnButtonReminder")
        {
        }

        public EndTurnButtonReminder(IntPtr address, string className) : base(address, className)
        {
        }

        public bool ShowFriendlySidePlayerTurnReminder()
        {
            return base.method_11<bool>("ShowFriendlySidePlayerTurnReminder", Array.Empty<object>());
        }

        public List<Card> m_cardsWaitingToRemind
        {
            get
            {
                Class267<Card> class2 = base.method_3<Class267<Card>>("m_cardsWaitingToRemind");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_MaxDelaySec
        {
            get
            {
                return base.method_2<float>("m_MaxDelaySec");
            }
        }
    }
}

