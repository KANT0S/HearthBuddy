namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ArenaTicketReward")]
    public class ArenaTicketReward : Reward
    {
        public ArenaTicketReward(IntPtr address) : this(address, "ArenaTicketReward")
        {
        }

        public ArenaTicketReward(IntPtr address, string className) : base(address, className)
        {
        }

        public void HideReward()
        {
            base.method_8("HideReward", Array.Empty<object>());
        }

        public void InitData()
        {
            base.method_8("InitData", Array.Empty<object>());
        }

        public void ShowReward(bool updateCacheValues)
        {
            object[] objArray1 = new object[] { updateCacheValues };
            base.method_8("ShowReward", objArray1);
        }

        public UberText m_countLabel
        {
            get
            {
                return base.method_3<UberText>("m_countLabel");
            }
        }

        public UberText m_playerNameLabel
        {
            get
            {
                return base.method_3<UberText>("m_playerNameLabel");
            }
        }

        public GameObject m_ticketVisual
        {
            get
            {
                return base.method_3<GameObject>("m_ticketVisual");
            }
        }
    }
}

