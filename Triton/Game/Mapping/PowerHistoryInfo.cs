namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("PowerHistoryInfo")]
    public class PowerHistoryInfo : MonoClass
    {
        public PowerHistoryInfo(IntPtr address) : this(address, "PowerHistoryInfo")
        {
        }

        public PowerHistoryInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public int GetEffectIndex()
        {
            return base.method_11<int>("GetEffectIndex", Array.Empty<object>());
        }

        public bool ShouldShowInHistory()
        {
            return base.method_11<bool>("ShouldShowInHistory", Array.Empty<object>());
        }

        public int mEffectIndex
        {
            get
            {
                return base.method_2<int>("mEffectIndex");
            }
        }

        public bool mShowInHistory
        {
            get
            {
                return base.method_2<bool>("mShowInHistory");
            }
        }
    }
}

