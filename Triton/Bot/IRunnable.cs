namespace Triton.Bot
{
    using System;

    public interface IRunnable
    {
        void Start();
        void Stop();
        void Tick();
    }
}

