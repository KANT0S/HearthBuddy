namespace Triton.Common
{
    using System;
    using System.Runtime.CompilerServices;

    public class WaitTimer
    {
        [CompilerGenerated]
        private DateTime dateTime_0;
        [CompilerGenerated]
        private TimeSpan timeSpan_0;

        public WaitTimer(TimeSpan timePeriod)
        {
            this.Time = timePeriod;
            this.Restart();
        }

        public void Restart()
        {
            this.Started = DateTime.Now;
        }

        public void Restart(TimeSpan time)
        {
            this.Time = time;
            this.Started = DateTime.Now;
        }

        public bool Finished
        {
            get
            {
                return (this.Started.Add(this.Time) < DateTime.Now);
            }
        }

        public DateTime Started
        {
            [CompilerGenerated]
            get
            {
                return this.dateTime_0;
            }
            [CompilerGenerated]
            private set
            {
                this.dateTime_0 = value;
            }
        }

        public TimeSpan Time
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
    }
}

