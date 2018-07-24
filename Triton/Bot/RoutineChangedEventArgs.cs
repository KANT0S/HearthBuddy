namespace Triton.Bot
{
    using System;

    public class RoutineChangedEventArgs : EventArgs
    {
        public IRoutine New;
        public IRoutine Old;

        internal RoutineChangedEventArgs(IRoutine old, IRoutine @new)
        {
            this.Old = old;
            this.New = @new;
        }
    }
}

