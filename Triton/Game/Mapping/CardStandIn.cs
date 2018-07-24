namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardStandIn")]
    public class CardStandIn : MonoBehaviour
    {
        public CardStandIn(IntPtr address) : this(address, "CardStandIn")
        {
        }

        public CardStandIn(IntPtr address, string className) : base(address, className)
        {
        }

        public void DisableStandIn()
        {
            base.method_8("DisableStandIn", Array.Empty<object>());
        }

        public void EnableStandIn()
        {
            base.method_8("EnableStandIn", Array.Empty<object>());
        }

        public Card linkedCard
        {
            get
            {
                return base.method_3<Card>("linkedCard");
            }
        }

        public int slot
        {
            get
            {
                return base.method_2<int>("slot");
            }
        }

        public Collider standInCollider
        {
            get
            {
                return base.method_3<Collider>("standInCollider");
            }
        }
    }
}

