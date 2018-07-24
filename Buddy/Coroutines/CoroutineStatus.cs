namespace Buddy.Coroutines
{
    using System;

    public enum CoroutineStatus
    {
        Runnable,
        RanToCompletion,
        Stopped,
        Faulted
    }
}

