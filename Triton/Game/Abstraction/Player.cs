namespace Triton.Game.Abstraction
{
    using ns27;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using Triton.Game.Mapping;

    public class Player : Triton.Game.Abstraction.Entity
    {
        [CompilerGenerated]
        private Triton.Game.Abstraction.Card card_0;
        [CompilerGenerated]
        private Triton.Game.Abstraction.Card card_1;
        [CompilerGenerated]
        private Triton.Game.Abstraction.Card card_2;
        [CompilerGenerated]
        private int int_29;
        [CompilerGenerated]
        private int int_30;
        [CompilerGenerated]
        private int int_31;
        [CompilerGenerated]
        private int int_32;
        [CompilerGenerated]
        private int int_33;
        [CompilerGenerated]
        private int int_34;
        [CompilerGenerated]
        private List<Triton.Game.Abstraction.Card> list_1;
        [CompilerGenerated]
        private List<Triton.Game.Abstraction.Card> list_2;
        [CompilerGenerated]
        private List<Triton.Game.Abstraction.Card> list_3;
        [CompilerGenerated]
        private List<Triton.Game.Abstraction.Card> list_4;
        [CompilerGenerated]
        private Triton.Game.Mapping.Player player_0;

        internal Player(Triton.Game.Mapping.Player backingObject) : base(backingObject)
        {
            this.Player_0 = backingObject;
            this.CardsInHand = new List<Triton.Game.Abstraction.Card>();
            foreach (Triton.Game.Mapping.Card card in this.Player_0.GetHandZone().m_cards)
            {
                this.CardsInHand.Add(Class274.Class274_0.method_1(card));
            }
            this.CardsInBattlefield = new List<Triton.Game.Abstraction.Card>();
            foreach (Triton.Game.Mapping.Card card2 in this.Player_0.GetBattlefieldZone().m_cards)
            {
                this.CardsInBattlefield.Add(Class274.Class274_0.method_1(card2));
            }
            this.CardsInGraveyard = new List<Triton.Game.Abstraction.Card>();
            foreach (Triton.Game.Mapping.Card card3 in this.Player_0.GetGraveyardZone().m_cards)
            {
                this.CardsInGraveyard.Add(Class274.Class274_0.method_1(card3));
            }
            this.NumCardsPlayedThisTurn = this.Player_0.GetTag(GAME_TAG.NUM_CARDS_PLAYED_THIS_TURN);
            this.NumMinionsPlayedThisTurn = this.Player_0.GetTag(GAME_TAG.NUM_MINIONS_PLAYED_THIS_TURN);
            this.Resources = this.Player_0.GetTag(GAME_TAG.RESOURCES);
            this.AvailableResources = this.Player_0.GetNumAvailableResources();
            this.OverloadOwed = this.Player_0.GetTag(GAME_TAG.OVERLOAD_OWED);
            this.OverloadLocked = this.Player_0.GetTag(GAME_TAG.OVERLOAD_LOCKED);
            this.WeaponCard = Class274.Class274_0.method_1(this.Player_0.GetWeaponCard());
            this.HeroCard = Class274.Class274_0.method_1(this.Player_0.GetHeroCard());
            this.HeroPowerCard = Class274.Class274_0.method_1(this.Player_0.GetHeroPowerCard());
            this.AllCards = new List<Triton.Game.Abstraction.Card>();
            this.AllCards.AddRange(this.CardsInHand);
            this.AllCards.AddRange(this.CardsInBattlefield);
            this.AllCards.AddRange(this.CardsInGraveyard);
            this.AllCards.Add(this.HeroCard);
            this.AllCards.Add(this.HeroPowerCard);
        }

        public List<Triton.Game.Abstraction.Card> AllCards
        {
            [CompilerGenerated]
            get
            {
                return this.list_1;
            }
            [CompilerGenerated]
            private set
            {
                this.list_1 = value;
            }
        }

        public int AvailableResources
        {
            [CompilerGenerated]
            get
            {
                return this.int_32;
            }
            [CompilerGenerated]
            private set
            {
                this.int_32 = value;
            }
        }

        public List<Triton.Game.Abstraction.Card> CardsInBattlefield
        {
            [CompilerGenerated]
            get
            {
                return this.list_3;
            }
            [CompilerGenerated]
            private set
            {
                this.list_3 = value;
            }
        }

        public List<Triton.Game.Abstraction.Card> CardsInGraveyard
        {
            [CompilerGenerated]
            get
            {
                return this.list_4;
            }
            [CompilerGenerated]
            private set
            {
                this.list_4 = value;
            }
        }

        public List<Triton.Game.Abstraction.Card> CardsInHand
        {
            [CompilerGenerated]
            get
            {
                return this.list_2;
            }
            [CompilerGenerated]
            private set
            {
                this.list_2 = value;
            }
        }

        public Triton.Game.Abstraction.Card HeroCard
        {
            [CompilerGenerated]
            get
            {
                return this.card_0;
            }
            [CompilerGenerated]
            private set
            {
                this.card_0 = value;
            }
        }

        public Triton.Game.Abstraction.Card HeroPowerCard
        {
            [CompilerGenerated]
            get
            {
                return this.card_1;
            }
            [CompilerGenerated]
            private set
            {
                this.card_1 = value;
            }
        }

        public int NumCardsPlayedThisTurn
        {
            [CompilerGenerated]
            get
            {
                return this.int_29;
            }
            [CompilerGenerated]
            private set
            {
                this.int_29 = value;
            }
        }

        public int NumMinionsPlayedThisTurn
        {
            [CompilerGenerated]
            get
            {
                return this.int_30;
            }
            [CompilerGenerated]
            private set
            {
                this.int_30 = value;
            }
        }

        public int OverloadLocked
        {
            [CompilerGenerated]
            get
            {
                return this.int_34;
            }
            [CompilerGenerated]
            private set
            {
                this.int_34 = value;
            }
        }

        public int OverloadOwed
        {
            [CompilerGenerated]
            get
            {
                return this.int_33;
            }
            [CompilerGenerated]
            private set
            {
                this.int_33 = value;
            }
        }

        internal Triton.Game.Mapping.Player Player_0
        {
            [CompilerGenerated]
            get
            {
                return this.player_0;
            }
            [CompilerGenerated]
            set
            {
                this.player_0 = value;
            }
        }

        public int Resources
        {
            [CompilerGenerated]
            get
            {
                return this.int_31;
            }
            [CompilerGenerated]
            private set
            {
                this.int_31 = value;
            }
        }

        public Triton.Game.Abstraction.Card WeaponCard
        {
            [CompilerGenerated]
            get
            {
                return this.card_2;
            }
            [CompilerGenerated]
            private set
            {
                this.card_2 = value;
            }
        }
    }
}

