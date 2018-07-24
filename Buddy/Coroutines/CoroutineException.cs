namespace Buddy.Coroutines
{
    using System;

    public abstract class CoroutineException : Exception
    {
        protected CoroutineException(string message) : base(message)
        {
        }

        protected CoroutineException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

