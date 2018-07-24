namespace Buddy.Coroutines
{
    using System;

    public class CoroutineUnhandledException : CoroutineException
    {
        public CoroutineUnhandledException(string message) : base(message)
        {
        }

        public CoroutineUnhandledException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

