namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ForgeTicketReward")]
    public class ForgeTicketReward : Reward
    {
        public ForgeTicketReward(IntPtr address) : this(address, "ForgeTicketReward")
        {
        }

        public ForgeTicketReward(IntPtr address, string className) : base(address, className)
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

        public GameObject m_rotateParent
        {
            get
            {
                return base.method_3<GameObject>("m_rotateParent");
            }
        }
    }
}

