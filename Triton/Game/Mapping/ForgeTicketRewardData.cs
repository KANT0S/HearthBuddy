namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ForgeTicketRewardData")]
    public class ForgeTicketRewardData : RewardData
    {
        public ForgeTicketRewardData(IntPtr address) : this(address, "ForgeTicketRewardData")
        {
        }

        public ForgeTicketRewardData(IntPtr address, string className) : base(address, className)
        {
        }

        public string GetGameObjectName()
        {
            return base.method_13("GetGameObjectName", Array.Empty<object>());
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public int Quantity
        {
            get
            {
                return base.method_11<int>("get_Quantity", Array.Empty<object>());
            }
        }
    }
}

