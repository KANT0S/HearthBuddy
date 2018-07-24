namespace Triton.Game.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using Triton.Game.Mapping;

    public class EmoteData
    {
        [CompilerGenerated]
        private EmoteType emoteType_0;
        [CompilerGenerated]
        private EmoteType emoteType_1;

        internal EmoteData(EmoteType emote)
        {
            this.Emote = emote;
            this.Response = EmoteType.INVALID;
        }

        public EmoteType Emote
        {
            [CompilerGenerated]
            get
            {
                return this.emoteType_0;
            }
            [CompilerGenerated]
            private set
            {
                this.emoteType_0 = value;
            }
        }

        public EmoteType Response
        {
            [CompilerGenerated]
            get
            {
                return this.emoteType_1;
            }
            [CompilerGenerated]
            set
            {
                this.emoteType_1 = value;
            }
        }
    }
}

