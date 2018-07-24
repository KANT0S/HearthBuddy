namespace Buddy.Coroutines
{
    using System;

    public class CoroutineStoppedException : Exception
    {
        internal CoroutineStoppedException(string message) : base(message)
        {
        }
    }
}

