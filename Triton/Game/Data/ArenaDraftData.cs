namespace Triton.Game.Data
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using Triton.Game;
    using Triton.Game.Abstraction;
    using Triton.Game.Mapping;

    public class ArenaDraftData
    {
        [CompilerGenerated]
        private Triton.Game.Abstraction.Actor actor_0;
        [CompilerGenerated]
        private Triton.Game.Abstraction.Actor actor_1;
        [CompilerGenerated]
        private int int_0;
        [CompilerGenerated]
        private int int_1;
        [CompilerGenerated]
        private List<Triton.Game.Abstraction.Actor> list_0;
        [CompilerGenerated]
        private List<Triton.Game.Abstraction.EntityDef> list_1;

        internal ArenaDraftData()
        {
            this.Deck = new List<Triton.Game.Abstraction.EntityDef>();
            DraftDisplay display = DraftDisplay.Get();
            if (display.m_chosenHero != null)
            {
                this.Hero = new Triton.Game.Abstraction.Actor(display.m_chosenHero);
            }
            this.Choices = new List<Triton.Game.Abstraction.Actor>();
            foreach (DraftDisplay.DraftChoice choice in display.m_choices)
            {
                this.Choices.Add(new Triton.Game.Abstraction.Actor(choice.m_actor));
            }
            DefLoader loader = DefLoader.Get();
            DraftManager manager = DraftManager.Get();
            foreach (CollectionDeckSlot slot in manager.m_draftDeck.m_slots)
            {
                for (int i = 0; i < slot.Count; i++)
                {
                    this.Deck.Add(new Triton.Game.Abstraction.EntityDef(loader.GetEntityDef(slot.CardID)));
                }
            }
            this.Wins = manager.m_wins;
            this.Losses = manager.m_losses;
        }

        public void RandomSelection()
        {
            this.Selection = this.Choices[Client.Random.Next(0, this.Choices.Count)];
        }

        public List<Triton.Game.Abstraction.Actor> Choices
        {
            [CompilerGenerated]
            get
            {
                return this.list_0;
            }
            [CompilerGenerated]
            private set
            {
                this.list_0 = value;
            }
        }

        public List<Triton.Game.Abstraction.EntityDef> Deck
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

        public Triton.Game.Abstraction.Actor Hero
        {
            [CompilerGenerated]
            get
            {
                return this.actor_0;
            }
            [CompilerGenerated]
            private set
            {
                this.actor_0 = value;
            }
        }

        public int Losses
        {
            [CompilerGenerated]
            get
            {
                return this.int_1;
            }
            [CompilerGenerated]
            private set
            {
                this.int_1 = value;
            }
        }

        public Triton.Game.Abstraction.Actor Selection
        {
            [CompilerGenerated]
            get
            {
                return this.actor_1;
            }
            [CompilerGenerated]
            set
            {
                this.actor_1 = value;
            }
        }

        public int Wins
        {
            [CompilerGenerated]
            get
            {
                return this.int_0;
            }
            [CompilerGenerated]
            private set
            {
                this.int_0 = value;
            }
        }
    }
}

