namespace Triton.Bot
{
    using System;
    using System.Runtime.CompilerServices;

    public class NewGameEventArgs : EventArgs
    {
        [CompilerGenerated]
        private int int_0;

        internal NewGameEventArgs(int id)
        {
            this.Id = id;
        }

        public int Id
        {
            [CompilerGenerated]
            get
            {
                return this.int_0;
            }
            [CompilerGenerated]
            set
            {
                this.int_0 = value;
            }
        }
    }
}

