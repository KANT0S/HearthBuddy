namespace Triton.Bot
{
    using System;

    public interface IAuthored
    {
        string Author { get; }

        string Description { get; }

        string Name { get; }

        string Version { get; }
    }
}

