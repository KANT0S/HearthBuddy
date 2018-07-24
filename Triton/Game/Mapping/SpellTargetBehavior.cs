namespace Triton.Game.Mapping
{
    using System;

    public enum SpellTargetBehavior
    {
        DEFAULT,
        FRIENDLY_PLAY_ZONE_CENTER,
        FRIENDLY_PLAY_ZONE_RANDOM,
        OPPONENT_PLAY_ZONE_CENTER,
        OPPONENT_PLAY_ZONE_RANDOM,
        BOARD_CENTER,
        UNTARGETED,
        CHOSEN_TARGET_ONLY,
        BOARD_RANDOM,
        TARGET_ZONE_CENTER,
        NEW_CREATED_CARDS
    }
}

