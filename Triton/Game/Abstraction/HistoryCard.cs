namespace Triton.Game.Abstraction
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using Triton.Game.Mapping;

    public class HistoryCard : Triton.Game.Abstraction.HistoryItem
    {
        [CompilerGenerated]
        private Triton.Game.Abstraction.Actor actor_1;
        [CompilerGenerated]
        private bool bool_2;
        [CompilerGenerated]
        private Triton.Game.Mapping.HistoryCard historyCard_0;
        [CompilerGenerated]
        private List<Triton.Game.Abstraction.HistoryChildCard> list_0;

        internal HistoryCard(Triton.Game.Mapping.HistoryCard backingObject) : base(backingObject)
        {
            this.HistoryCard_0 = backingObject;
            this.TileActor = new Triton.Game.Abstraction.Actor(this.HistoryCard_0.m_tileActor);
            this.WasCountered = this.HistoryCard_0.wasCountered;
            this.HistoryChildren = new List<Triton.Game.Abstraction.HistoryChildCard>();
            foreach (Triton.Game.Mapping.HistoryChildCard card in this.HistoryCard_0.historyChildren)
            {
                this.HistoryChildren.Add(new Triton.Game.Abstraction.HistoryChildCard(card));
            }
        }

        internal Triton.Game.Mapping.HistoryCard HistoryCard_0
        {
            [CompilerGenerated]
            get
            {
                return this.historyCard_0;
            }
            [CompilerGenerated]
            set
            {
                this.historyCard_0 = value;
            }
        }

        public List<Triton.Game.Abstraction.HistoryChildCard> HistoryChildren
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

        public Triton.Game.Abstraction.Actor TileActor
        {
            [CompilerGenerated]
            get
            {
                return this.actor_1;
            }
            [CompilerGenerated]
            private set
            {
                this.actor_1 = value;
            }
        }

        public bool WasCountered
        {
            [CompilerGenerated]
            get
            {
                return this.bool_2;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_2 = value;
            }
        }
    }
}

