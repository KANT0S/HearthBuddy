namespace Hearthbuddy.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Windows;

    public class TimeSelectedChangedRoutedEventArgs : RoutedEventArgs
    {
        [CompilerGenerated]
        private TimeSpan timeSpan_0;
        [CompilerGenerated]
        private TimeSpan timeSpan_1;

        public TimeSelectedChangedRoutedEventArgs(RoutedEvent routedEvent) : base(routedEvent)
        {
        }

        public TimeSpan NewTime
        {
            [CompilerGenerated]
            get
            {
                return this.timeSpan_0;
            }
            [CompilerGenerated]
            set
            {
                this.timeSpan_0 = value;
            }
        }

        public TimeSpan OldTime
        {
            [CompilerGenerated]
            get
            {
                return this.timeSpan_1;
            }
            [CompilerGenerated]
            set
            {
                this.timeSpan_1 = value;
            }
        }
    }
}

