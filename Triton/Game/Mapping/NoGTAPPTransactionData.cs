namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("NoGTAPPTransactionData")]
    public class NoGTAPPTransactionData : MonoClass
    {
        public NoGTAPPTransactionData(IntPtr address) : this(address, "NoGTAPPTransactionData")
        {
        }

        public NoGTAPPTransactionData(IntPtr address, string className) : base(address, className)
        {
        }

        public int ProductData
        {
            get
            {
                return base.method_11<int>("get_ProductData", Array.Empty<object>());
            }
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

