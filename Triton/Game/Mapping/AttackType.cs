namespace Triton.Game.Mapping
{
    using System;

    public enum AttackType
    {
        INVALID,
        REGULAR,
        PROPOSED,
        CANCELED,
        ONLY_ATTACKER,
        ONLY_DEFENDER,
        ONLY_PROPOSED_ATTACKER,
        ONLY_PROPOSED_DEFENDER,
        WAITING_ON_PROPOSED_ATTACKER,
        WAITING_ON_PROPOSED_DEFENDER,
        WAITING_ON_ATTACKER,
        WAITING_ON_DEFENDER
    }
}

