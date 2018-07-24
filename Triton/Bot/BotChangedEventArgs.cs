namespace Triton.Bot
{
    using System;

    public class BotChangedEventArgs : EventArgs
    {
        public IBot New;
        public IBot Old;

        internal BotChangedEventArgs(IBot old, IBot @new)
        {
            this.Old = old;
            this.New = @new;
        }
    }
}

