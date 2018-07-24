namespace Triton.Game.Data
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using Triton.Game.Abstraction;
    using Triton.Game.Mapping;

    public class MulliganData
    {
        [CompilerGenerated]
        private List<Triton.Game.Abstraction.Card> list_0;
        [CompilerGenerated]
        private List<bool> list_1;
        [CompilerGenerated]
        private TAG_CLASS tag_CLASS_0;
        [CompilerGenerated]
        private TAG_CLASS tag_CLASS_1;

        internal MulliganData()
        {
            this.UserClass = GameState.Get().GetFriendlySidePlayer().GetHero().GetClass();
            this.OpponentClass = GameState.Get().GetOpposingSidePlayer().GetHero().GetClass();
            this.Cards = new List<Triton.Game.Abstraction.Card>();
            this.Mulligans = new List<bool>();
            foreach (Triton.Game.Mapping.Card card in MulliganManager.Get().m_startingCards)
            {
                this.Cards.Add(new Triton.Game.Abstraction.Card(card));
                this.Mulligans.Add(false);
            }
        }

        public List<Triton.Game.Abstraction.Card> Cards
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

        public List<bool> Mulligans
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

        public TAG_CLASS OpponentClass
        {
            [CompilerGenerated]
            get
            {
                return this.tag_CLASS_1;
            }
            [CompilerGenerated]
            private set
            {
                this.tag_CLASS_1 = value;
            }
        }

        public TAG_CLASS UserClass
        {
            [CompilerGenerated]
            get
            {
                return this.tag_CLASS_0;
            }
            [CompilerGenerated]
            private set
            {
                this.tag_CLASS_0 = value;
            }
        }
    }
}

