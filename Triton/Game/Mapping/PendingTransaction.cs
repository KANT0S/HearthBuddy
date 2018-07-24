namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("PendingTransaction")]
    public class PendingTransaction : MonoClass
    {
        public PendingTransaction(IntPtr address) : this(address, "PendingTransaction")
        {
        }

        public PendingTransaction(IntPtr address, string className) : base(address, className)
        {
        }

        public string CardID
        {
            get
            {
                return base.method_4("CardID");
            }
        }

        public TAG_PREMIUM Premium
        {
            get
            {
                return base.method_2<TAG_PREMIUM>("Premium");
            }
        }

        public int TransactionAmt
        {
            get
            {
                return base.method_2<int>("TransactionAmt");
            }
        }
    }
}

