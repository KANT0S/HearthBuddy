namespace Triton.Game.Abstraction
{
    using System;
    using System.Runtime.CompilerServices;
    using Triton.Game.Mapping;

    public class HistoryChildCard : Triton.Game.Abstraction.HistoryItem
    {
        [CompilerGenerated]
        private Triton.Game.Mapping.HistoryChildCard historyChildCard_0;

        internal HistoryChildCard(Triton.Game.Mapping.HistoryChildCard backingObject) : base(backingObject)
        {
            this.HistoryChildCard_0 = backingObject;
        }

        internal Triton.Game.Mapping.HistoryChildCard HistoryChildCard_0
        {
            [CompilerGenerated]
            get
            {
                return this.historyChildCard_0;
            }
            [CompilerGenerated]
            set
            {
                this.historyChildCard_0 = value;
            }
        }
    }
}

