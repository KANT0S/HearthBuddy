namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("MoneyOrGTAPPTransaction")]
    public class MoneyOrGTAPPTransaction : MonoClass
    {
        public MoneyOrGTAPPTransaction(IntPtr address) : this(address, "MoneyOrGTAPPTransaction")
        {
        }

        public MoneyOrGTAPPTransaction(IntPtr address, string className) : base(address, className)
        {
        }

        public bool Equals(object obj)
        {
            object[] objArray1 = new object[] { obj };
            return base.method_11<bool>("Equals", objArray1);
        }

        public int GetHashCode()
        {
            return base.method_11<int>("GetHashCode", Array.Empty<object>());
        }

        public bool ShouldShowMiniSummary()
        {
            return base.method_11<bool>("ShouldShowMiniSummary", Array.Empty<object>());
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public bool ClosedStore
        {
            get
            {
                return base.method_11<bool>("get_ClosedStore", Array.Empty<object>());
            }
        }

        public long ID
        {
            get
            {
                return base.method_11<long>("get_ID", Array.Empty<object>());
            }
        }

        public bool IsGTAPP
        {
            get
            {
                return base.method_11<bool>("get_IsGTAPP", Array.Empty<object>());
            }
        }

        public string ProductID
        {
            get
            {
                return base.method_13("get_ProductID", Array.Empty<object>());
            }
        }
    }
}

