namespace Triton.Bot
{
    using System;
    using System.Runtime.CompilerServices;

    public class GameOverEventArgs : EventArgs
    {
        [CompilerGenerated]
        private bool bool_0;
        [CompilerGenerated]
        private GameOverFlag gameOverFlag_0;

        internal GameOverEventArgs(GameOverFlag result, bool conceded)
        {
            this.Result = result;
            this.Conceded = conceded;
        }

        public bool Conceded
        {
            [CompilerGenerated]
            get
            {
                return this.bool_0;
            }
            [CompilerGenerated]
            set
            {
                this.bool_0 = value;
            }
        }

        public GameOverFlag Result
        {
            [CompilerGenerated]
            get
            {
                return this.gameOverFlag_0;
            }
            [CompilerGenerated]
            set
            {
                this.gameOverFlag_0 = value;
            }
        }
    }
}

