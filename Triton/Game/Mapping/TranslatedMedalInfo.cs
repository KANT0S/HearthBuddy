namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("TranslatedMedalInfo")]
    public class TranslatedMedalInfo : MonoClass
    {
        public TranslatedMedalInfo(IntPtr address) : this(address, "TranslatedMedalInfo")
        {
        }

        public TranslatedMedalInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public bool CanGetRankedRewardChest()
        {
            return base.method_11<bool>("CanGetRankedRewardChest", Array.Empty<object>());
        }

        public bool IsHighestRankThatCannotBeLost()
        {
            return base.method_11<bool>("IsHighestRankThatCannotBeLost", Array.Empty<object>());
        }

        public bool IsLegendRank()
        {
            return base.method_11<bool>("IsLegendRank", Array.Empty<object>());
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public int bestRank
        {
            get
            {
                return base.method_2<int>("bestRank");
            }
        }

        public bool canLoseLevel
        {
            get
            {
                return base.method_2<bool>("canLoseLevel");
            }
        }

        public bool canLoseStars
        {
            get
            {
                return base.method_2<bool>("canLoseStars");
            }
        }

        public int earnedStars
        {
            get
            {
                return base.method_2<int>("earnedStars");
            }
        }

        public int legendIndex
        {
            get
            {
                return base.method_2<int>("legendIndex");
            }
        }

        public string name
        {
            get
            {
                return base.method_4("name");
            }
        }

        public string nextMedalName
        {
            get
            {
                return base.method_4("nextMedalName");
            }
        }

        public int rank
        {
            get
            {
                return base.method_2<int>("rank");
            }
        }

        public int streakStars
        {
            get
            {
                return base.method_2<int>("streakStars");
            }
        }

        public string textureName
        {
            get
            {
                return base.method_4("textureName");
            }
        }

        public int totalStars
        {
            get
            {
                return base.method_2<int>("totalStars");
            }
        }

        public int winStreak
        {
            get
            {
                return base.method_2<int>("winStreak");
            }
        }
    }
}

