namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("TavernBrawlMission")]
    public class TavernBrawlMission : MonoClass
    {
        public TavernBrawlMission(IntPtr address) : this(address, "TavernBrawlMission")
        {
        }

        public TavernBrawlMission(IntPtr address, string className) : base(address, className)
        {
        }

        public bool canCreateDeck
        {
            get
            {
                return base.method_2<bool>("canCreateDeck");
            }
        }

        public bool canEditDeck
        {
            get
            {
                return base.method_2<bool>("canEditDeck");
            }
        }

        public bool canSelectHeroForDeck
        {
            get
            {
                return base.method_2<bool>("canSelectHeroForDeck");
            }
        }

        public DeckBuilder deckRuleset
        {
            get
            {
                return base.method_3<DeckBuilder>("deckRuleset");
            }
        }

        public int missionId
        {
            get
            {
                return base.method_2<int>("missionId");
            }
        }

        public long RewardData1
        {
            get
            {
                return base.method_2<long>("RewardData1");
            }
        }

        public long RewardData2
        {
            get
            {
                return base.method_2<long>("RewardData2");
            }
        }

        public RewardType rewardType
        {
            get
            {
                return base.method_2<RewardType>("rewardType");
            }
        }

        public int seasonId
        {
            get
            {
                return base.method_2<int>("seasonId");
            }
        }
    }
}

