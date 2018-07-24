namespace Triton.Game
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Windows;

    public class GuiTickEventArgs : EventArgs
    {
        [CompilerGenerated]
        private System.Windows.Window window_0;

        internal GuiTickEventArgs(System.Windows.Window window)
        {
            this.Window = window;
        }

        public System.Windows.Window Window
        {
            [CompilerGenerated]
            get
            {
                return this.window_0;
            }
            [CompilerGenerated]
            private set
            {
                this.window_0 = value;
            }
        }
    }
}

