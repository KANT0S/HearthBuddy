namespace Buddy.Coroutines
{
    using System;

    public class CoroutineBehaviorException : CoroutineException
    {
        public CoroutineBehaviorException(string message) : base(message)
        {
        }

        public CoroutineBehaviorException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

