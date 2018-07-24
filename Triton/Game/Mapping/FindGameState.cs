namespace Triton.Game.Mapping
{
    using System;

    public enum FindGameState
    {
        INVALID,
        CLIENT_STARTED,
        CLIENT_CANCELED,
        CLIENT_ERROR,
        BNET_QUEUE_ENTERED,
        BNET_QUEUE_DELAYED,
        BNET_QUEUE_UPDATED,
        BNET_QUEUE_CANCELED,
        BNET_ERROR,
        SERVER_GAME_CONNECTING,
        SERVER_GAME_STARTED,
        SERVER_GAME_CANCELED
    }
}

