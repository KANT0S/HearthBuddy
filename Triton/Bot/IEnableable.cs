namespace Triton.Bot
{
    using System;

    public interface IEnableable
    {
        void Disable();
        void Enable();

        bool IsEnabled { get; }
    }
}

