namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("CardBackData")]
    public class CardBackData : MonoClass
    {
        public CardBackData(IntPtr address) : this(address, "CardBackData")
        {
        }

        public CardBackData(IntPtr address, string className) : base(address, className)
        {
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public bool Enabled
        {
            get
            {
                return base.method_11<bool>("get_Enabled", Array.Empty<object>());
            }
        }

        public int ID
        {
            get
            {
                return base.method_11<int>("get_ID", Array.Empty<object>());
            }
        }

        public string Name
        {
            get
            {
                return base.method_13("get_Name", Array.Empty<object>());
            }
        }

        public string PrefabName
        {
            get
            {
                return base.method_13("get_PrefabName", Array.Empty<object>());
            }
        }

        public CardBackSource Source
        {
            get
            {
                return base.method_11<CardBackSource>("get_Source", Array.Empty<object>());
            }
        }

        public long SourceData
        {
            get
            {
                return base.method_11<long>("get_SourceData", Array.Empty<object>());
            }
        }

        public enum CardBackSource
        {
            ACHIEVE = 2,
            FIXED_REWARD = 3,
            SEASON = 1,
            STARTUP = 0,
            TAVERN_BRAWL = 5
        }
    }
}

