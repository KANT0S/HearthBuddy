namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("PlayErrors")]
    public class PlayErrors : MonoClass
    {
        public PlayErrors(IntPtr address) : this(address, "PlayErrors")
        {
        }

        public PlayErrors(IntPtr address, string className) : base(address, className)
        {
        }

        public static void AppQuit()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "PlayErrors", "AppQuit");
        }

        public static bool CanShowMinionTauntError()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "PlayErrors", "CanShowMinionTauntError", Array.Empty<object>());
        }

        public static void DisplayPlayError(ErrorType error, Triton.Game.Mapping.Entity errorSource)
        {
            object[] objArray1 = new object[] { error, errorSource };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "PlayErrors", "DisplayPlayError", objArray1);
        }

        public static void DisplayTauntErrorEffects()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "PlayErrors", "DisplayTauntErrorEffects");
        }

        public static string GetErrorDescription(ErrorType type, PlayRequirementInfo requirementInfo)
        {
            object[] objArray1 = new object[] { type, requirementInfo };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "PlayErrors", "GetErrorDescription", objArray1);
        }

        public static IntPtr GetFunction(string name)
        {
            object[] objArray1 = new object[] { name };
            return MonoClass.smethod_14<IntPtr>(TritonHs.MainAssemblyPath, "", "PlayErrors", "GetFunction", objArray1);
        }

        public static List<Marshaled_TargetEntityInfo> GetMarshaledEntitiesInPlay()
        {
            Class266<Marshaled_TargetEntityInfo> class2 = MonoClass.smethod_15<Class266<Marshaled_TargetEntityInfo>>(TritonHs.MainAssemblyPath, "", "PlayErrors", "GetMarshaledEntitiesInPlay", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static List<Marshaled_SourceEntityInfo> GetMarshaledSubCards(Triton.Game.Mapping.Entity source)
        {
            object[] objArray1 = new object[] { source };
            Class266<Marshaled_SourceEntityInfo> class2 = MonoClass.smethod_15<Class266<Marshaled_SourceEntityInfo>>(TritonHs.MainAssemblyPath, "", "PlayErrors", "GetMarshaledSubCards", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static Player GetOwningPlayer(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return MonoClass.smethod_15<Player>(TritonHs.MainAssemblyPath, "", "PlayErrors", "GetOwningPlayer", objArray1);
        }

        public static ErrorType GetPlayEntityError(Triton.Game.Mapping.Entity source)
        {
            object[] objArray1 = new object[] { source };
            return MonoClass.smethod_14<ErrorType>(TritonHs.MainAssemblyPath, "", "PlayErrors", "GetPlayEntityError", objArray1);
        }

        public static PlayRequirementInfo GetPlayRequirementInfo(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return MonoClass.smethod_15<PlayRequirementInfo>(TritonHs.MainAssemblyPath, "", "PlayErrors", "GetPlayRequirementInfo", objArray1);
        }

        public static ErrorType GetTargetEntityError(Triton.Game.Mapping.Entity source, Triton.Game.Mapping.Entity target)
        {
            object[] objArray1 = new object[] { source, target };
            return MonoClass.smethod_14<ErrorType>(TritonHs.MainAssemblyPath, "", "PlayErrors", "GetTargetEntityError", objArray1);
        }

        public static bool Init()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "PlayErrors", "Init", Array.Empty<object>());
        }

        public static bool IsInitialized()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "PlayErrors", "IsInitialized", Array.Empty<object>());
        }

        public static bool LoadDLL()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "PlayErrors", "LoadDLL", Array.Empty<object>());
        }

        public static void UnloadDLL()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "PlayErrors", "UnloadDLL");
        }

        public static string PLAYERRORS_DLL_FILENAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "PlayErrors", "PLAYERRORS_DLL_FILENAME");
            }
        }

        public static bool PLAYERRORS_ENABLED
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "PlayErrors", "PLAYERRORS_ENABLED");
            }
        }

        public static IntPtr s_DLL
        {
            get
            {
                return MonoClass.smethod_6<IntPtr>(TritonHs.MainAssemblyPath, "", "PlayErrors", "s_DLL");
            }
        }

        public static bool s_initialized
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "PlayErrors", "s_initialized");
            }
        }

        public enum ErrorType
        {
            NONE,
            REQ_MINION_TARGET,
            REQ_FRIENDLY_TARGET,
            REQ_ENEMY_TARGET,
            REQ_DAMAGED_TARGET,
            REQ_ENCHANTED_TARGET,
            REQ_FROZEN_TARGET,
            REQ_CHARGE_TARGET,
            REQ_TARGET_MAX_ATTACK,
            REQ_NONSELF_TARGET,
            REQ_TARGET_WITH_RACE,
            REQ_TARGET_TO_PLAY,
            REQ_NUM_MINION_SLOTS,
            REQ_WEAPON_EQUIPPED,
            REQ_ENOUGH_MANA,
            REQ_YOUR_TURN,
            REQ_NONSTEALTH_ENEMY_TARGET,
            REQ_HERO_TARGET,
            REQ_SECRET_CAP,
            REQ_MINION_CAP_IF_TARGET_AVAILABLE,
            REQ_MINION_CAP,
            REQ_TARGET_ATTACKED_THIS_TURN,
            REQ_TARGET_IF_AVAILABLE,
            REQ_MINIMUM_ENEMY_MINIONS,
            REQ_TARGET_FOR_COMBO,
            REQ_NOT_EXHAUSTED_ACTIVATE,
            REQ_UNIQUE_SECRET,
            REQ_TARGET_TAUNTER,
            REQ_CAN_BE_ATTACKED,
            REQ_ACTION_PWR_IS_MASTER_PWR,
            REQ_TARGET_MAGNET,
            REQ_ATTACK_GREATER_THAN_0,
            REQ_ATTACKER_NOT_FROZEN,
            REQ_HERO_OR_MINION_TARGET,
            REQ_CAN_BE_TARGETED_BY_SPELLS,
            REQ_SUBCARD_IS_PLAYABLE,
            REQ_TARGET_FOR_NO_COMBO,
            REQ_NOT_MINION_JUST_PLAYED,
            REQ_NOT_EXHAUSTED_HERO_POWER,
            REQ_CAN_BE_TARGETED_BY_OPPONENTS,
            REQ_ATTACKER_CAN_ATTACK,
            REQ_TARGET_MIN_ATTACK,
            REQ_CAN_BE_TARGETED_BY_HERO_POWERS,
            REQ_ENEMY_TARGET_NOT_IMMUNE,
            REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY,
            REQ_MINIMUM_TOTAL_MINIONS,
            REQ_MUST_TARGET_TAUNTER,
            REQ_UNDAMAGED_TARGET,
            REQ_CAN_BE_TARGETED_BY_BATTLECRIES,
            REQ_STEADY_SHOT,
            REQ_MINION_OR_ENEMY_HERO,
            REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND,
            REQ_LEGENDARY_TARGET,
            REQ_FRIENDLY_MINION_DIED_THIS_TURN,
            REQ_FRIENDLY_MINION_DIED_THIS_GAME,
            REQ_ENEMY_WEAPON_EQUIPPED,
            REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS,
            REQ_TARGET_WITH_BATTLECRY,
            REQ_TARGET_WITH_DEATHRATTLE,
            REQ_DRAG_TO_PLAY
        }

        [Attribute38("PlayErrors.GameStateInfo")]
        public class GameStateInfo : MonoClass
        {
            public GameStateInfo(IntPtr address) : this(address, "GameStateInfo")
            {
            }

            public GameStateInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public TAG_STEP currentStep
            {
                get
                {
                    return base.method_2<TAG_STEP>("currentStep");
                }
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Marshaled_GameStateInfo
        {
            public TAG_STEP currentStep;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Marshaled_PlayerInfo
        {
            public int id;
            public int numResources;
            public int numFriendlyMinionsInPlay;
            public int numEnemyMinionsInPlay;
            public int numMinionSlotsPerPlayer;
            public int numOpenSecretSlots;
            public int numDragonsInHand;
            public int numFriendlyMinionsThatDiedThisTurn;
            public int numFriendlyMinionsThatDiedThisGame;
            public bool isCurrentPlayer;
            public bool weaponEquipped;
            public bool enemyWeaponEquipped;
            public bool comboActive;
            public bool steadyShotRequiresTarget;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Marshaled_PlayErrorsParams
        {
            public PlayErrors.Marshaled_SourceEntityInfo source;
            public PlayErrors.Marshaled_PlayerInfo player;
            public PlayErrors.Marshaled_GameStateInfo game;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Marshaled_SourceEntityInfo
        {
            public ulong requirementsMap;
            public int id;
            public int cost;
            public int attack;
            public int minAttackRequirement;
            public int maxAttackRequirement;
            public int raceRequirement;
            public int numMinionSlotsRequirement;
            public int numMinionSlotsWithTargetRequirement;
            public int minTotalMinionsRequirement;
            public int minFriendlyMinionsRequirement;
            public int minEnemyMinionsRequirement;
            public int numTurnsInPlay;
            public int numAttacksThisTurn;
            public int numWindfury;
            public TAG_CARDTYPE cardType;
            public TAG_ZONE zone;
            public bool isSecret;
            public bool isDuplicateSecret;
            public bool isExhausted;
            public bool isMasterPower;
            public bool isActionPower;
            public bool isActivatePower;
            public bool isAttackPower;
            public bool isFrozen;
            public bool hasBattlecry;
            public bool canAttack;
            public bool entireEntourageInPlay;
            public bool hasCharge;
            public bool isChoiceMinion;
            public bool cannotAttackHeroes;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Marshaled_TargetEntityInfo
        {
            public int id;
            public int owningPlayerID;
            public int damage;
            public int attack;
            public int race;
            public int rarity;
            public TAG_CARDTYPE cardType;
            public bool isImmune;
            public bool canBeAttacked;
            public bool canBeTargetedByOpponents;
            public bool canBeTargetedBySpells;
            public bool canBeTargetedByHeroPowers;
            public bool canBeTargetedByBattlecries;
            public bool isFrozen;
            public bool isEnchanted;
            public bool isStealthed;
            public bool isTaunter;
            public bool isMagnet;
            public bool hasCharge;
            public bool hasAttackedThisTurn;
            public bool hasBattlecry;
            public bool hasDeathrattle;
        }

        [Attribute38("PlayErrors.PlayerInfo")]
        public class PlayerInfo : MonoClass
        {
            public PlayerInfo(IntPtr address) : this(address, "PlayerInfo")
            {
            }

            public PlayerInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public bool comboActive
            {
                get
                {
                    return base.method_2<bool>("comboActive");
                }
            }

            public bool enemyWeaponEquipped
            {
                get
                {
                    return base.method_2<bool>("enemyWeaponEquipped");
                }
            }

            public int id
            {
                get
                {
                    return base.method_2<int>("id");
                }
            }

            public bool isCurrentPlayer
            {
                get
                {
                    return base.method_2<bool>("isCurrentPlayer");
                }
            }

            public int numDragonsInHand
            {
                get
                {
                    return base.method_2<int>("numDragonsInHand");
                }
            }

            public int numEnemyMinionsInPlay
            {
                get
                {
                    return base.method_2<int>("numEnemyMinionsInPlay");
                }
            }

            public int numFriendlyMinionsInPlay
            {
                get
                {
                    return base.method_2<int>("numFriendlyMinionsInPlay");
                }
            }

            public int numFriendlyMinionsThatDiedThisGame
            {
                get
                {
                    return base.method_2<int>("numFriendlyMinionsThatDiedThisGame");
                }
            }

            public int numFriendlyMinionsThatDiedThisTurn
            {
                get
                {
                    return base.method_2<int>("numFriendlyMinionsThatDiedThisTurn");
                }
            }

            public int numMinionSlotsPerPlayer
            {
                get
                {
                    return base.method_2<int>("numMinionSlotsPerPlayer");
                }
            }

            public int numOpenSecretSlots
            {
                get
                {
                    return base.method_2<int>("numOpenSecretSlots");
                }
            }

            public int numResources
            {
                get
                {
                    return base.method_2<int>("numResources");
                }
            }

            public bool steadyShotRequiresTarget
            {
                get
                {
                    return base.method_2<bool>("steadyShotRequiresTarget");
                }
            }

            public bool weaponEquipped
            {
                get
                {
                    return base.method_2<bool>("weaponEquipped");
                }
            }
        }

        [Attribute38("PlayErrors.PlayRequirementInfo")]
        public class PlayRequirementInfo : MonoClass
        {
            public PlayRequirementInfo(IntPtr address) : this(address, "PlayRequirementInfo")
            {
            }

            public PlayRequirementInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public int paramMaxAtk
            {
                get
                {
                    return base.method_2<int>("paramMaxAtk");
                }
            }

            public int paramMinAtk
            {
                get
                {
                    return base.method_2<int>("paramMinAtk");
                }
            }

            public int paramMinNumEnemyMinions
            {
                get
                {
                    return base.method_2<int>("paramMinNumEnemyMinions");
                }
            }

            public int paramMinNumFriendlyMinions
            {
                get
                {
                    return base.method_2<int>("paramMinNumFriendlyMinions");
                }
            }

            public int paramMinNumTotalMinions
            {
                get
                {
                    return base.method_2<int>("paramMinNumTotalMinions");
                }
            }

            public int paramNumMinionSlots
            {
                get
                {
                    return base.method_2<int>("paramNumMinionSlots");
                }
            }

            public int paramNumMinionSlotsWithTarget
            {
                get
                {
                    return base.method_2<int>("paramNumMinionSlotsWithTarget");
                }
            }

            public int paramRace
            {
                get
                {
                    return base.method_2<int>("paramRace");
                }
            }

            public ulong requirementsMap
            {
                get
                {
                    return base.method_2<ulong>("requirementsMap");
                }
            }
        }

        [Attribute38("PlayErrors.SourceEntityInfo")]
        public class SourceEntityInfo : MonoClass
        {
            public SourceEntityInfo(IntPtr address) : this(address, "SourceEntityInfo")
            {
            }

            public SourceEntityInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public int attack
            {
                get
                {
                    return base.method_2<int>("attack");
                }
            }

            public bool canAttack
            {
                get
                {
                    return base.method_2<bool>("canAttack");
                }
            }

            public bool cannotAttackHeroes
            {
                get
                {
                    return base.method_2<bool>("cannotAttackHeroes");
                }
            }

            public TAG_CARDTYPE cardType
            {
                get
                {
                    return base.method_2<TAG_CARDTYPE>("cardType");
                }
            }

            public int cost
            {
                get
                {
                    return base.method_2<int>("cost");
                }
            }

            public bool entireEntourageInPlay
            {
                get
                {
                    return base.method_2<bool>("entireEntourageInPlay");
                }
            }

            public bool hasBattlecry
            {
                get
                {
                    return base.method_2<bool>("hasBattlecry");
                }
            }

            public bool hasCharge
            {
                get
                {
                    return base.method_2<bool>("hasCharge");
                }
            }

            public int id
            {
                get
                {
                    return base.method_2<int>("id");
                }
            }

            public bool isActionPower
            {
                get
                {
                    return base.method_2<bool>("isActionPower");
                }
            }

            public bool isActivatePower
            {
                get
                {
                    return base.method_2<bool>("isActivatePower");
                }
            }

            public bool isAttackPower
            {
                get
                {
                    return base.method_2<bool>("isAttackPower");
                }
            }

            public bool isChoiceMinion
            {
                get
                {
                    return base.method_2<bool>("isChoiceMinion");
                }
            }

            public bool isDuplicateSecret
            {
                get
                {
                    return base.method_2<bool>("isDuplicateSecret");
                }
            }

            public bool isExhausted
            {
                get
                {
                    return base.method_2<bool>("isExhausted");
                }
            }

            public bool isFrozen
            {
                get
                {
                    return base.method_2<bool>("isFrozen");
                }
            }

            public bool isMasterPower
            {
                get
                {
                    return base.method_2<bool>("isMasterPower");
                }
            }

            public bool isSecret
            {
                get
                {
                    return base.method_2<bool>("isSecret");
                }
            }

            public int maxAttackRequirement
            {
                get
                {
                    return base.method_2<int>("maxAttackRequirement");
                }
            }

            public int minAttackRequirement
            {
                get
                {
                    return base.method_2<int>("minAttackRequirement");
                }
            }

            public int minEnemyMinionsRequirement
            {
                get
                {
                    return base.method_2<int>("minEnemyMinionsRequirement");
                }
            }

            public int minFriendlyMinionsRequirement
            {
                get
                {
                    return base.method_2<int>("minFriendlyMinionsRequirement");
                }
            }

            public int minTotalMinionsRequirement
            {
                get
                {
                    return base.method_2<int>("minTotalMinionsRequirement");
                }
            }

            public int numAttacksThisTurn
            {
                get
                {
                    return base.method_2<int>("numAttacksThisTurn");
                }
            }

            public int numMinionSlotsRequirement
            {
                get
                {
                    return base.method_2<int>("numMinionSlotsRequirement");
                }
            }

            public int numMinionSlotsWithTargetRequirement
            {
                get
                {
                    return base.method_2<int>("numMinionSlotsWithTargetRequirement");
                }
            }

            public int numTurnsInPlay
            {
                get
                {
                    return base.method_2<int>("numTurnsInPlay");
                }
            }

            public int numWindfury
            {
                get
                {
                    return base.method_2<int>("numWindfury");
                }
            }

            public int raceRequirement
            {
                get
                {
                    return base.method_2<int>("raceRequirement");
                }
            }

            public ulong requirementsMap
            {
                get
                {
                    return base.method_2<ulong>("requirementsMap");
                }
            }

            public TAG_ZONE zone
            {
                get
                {
                    return base.method_2<TAG_ZONE>("zone");
                }
            }
        }

        [Attribute38("PlayErrors.TargetEntityInfo")]
        public class TargetEntityInfo : MonoClass
        {
            public TargetEntityInfo(IntPtr address) : this(address, "TargetEntityInfo")
            {
            }

            public TargetEntityInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public int attack
            {
                get
                {
                    return base.method_2<int>("attack");
                }
            }

            public bool canBeAttacked
            {
                get
                {
                    return base.method_2<bool>("canBeAttacked");
                }
            }

            public bool canBeTargetedByBattlecries
            {
                get
                {
                    return base.method_2<bool>("canBeTargetedByBattlecries");
                }
            }

            public bool canBeTargetedByHeroPowers
            {
                get
                {
                    return base.method_2<bool>("canBeTargetedByHeroPowers");
                }
            }

            public bool canBeTargetedByOpponents
            {
                get
                {
                    return base.method_2<bool>("canBeTargetedByOpponents");
                }
            }

            public bool canBeTargetedBySpells
            {
                get
                {
                    return base.method_2<bool>("canBeTargetedBySpells");
                }
            }

            public TAG_CARDTYPE cardType
            {
                get
                {
                    return base.method_2<TAG_CARDTYPE>("cardType");
                }
            }

            public int damage
            {
                get
                {
                    return base.method_2<int>("damage");
                }
            }

            public bool hasAttackedThisTurn
            {
                get
                {
                    return base.method_2<bool>("hasAttackedThisTurn");
                }
            }

            public bool hasBattlecry
            {
                get
                {
                    return base.method_2<bool>("hasBattlecry");
                }
            }

            public bool hasCharge
            {
                get
                {
                    return base.method_2<bool>("hasCharge");
                }
            }

            public bool hasDeathrattle
            {
                get
                {
                    return base.method_2<bool>("hasDeathrattle");
                }
            }

            public int id
            {
                get
                {
                    return base.method_2<int>("id");
                }
            }

            public bool isEnchanted
            {
                get
                {
                    return base.method_2<bool>("isEnchanted");
                }
            }

            public bool isFrozen
            {
                get
                {
                    return base.method_2<bool>("isFrozen");
                }
            }

            public bool isImmune
            {
                get
                {
                    return base.method_2<bool>("isImmune");
                }
            }

            public bool isMagnet
            {
                get
                {
                    return base.method_2<bool>("isMagnet");
                }
            }

            public bool isStealthed
            {
                get
                {
                    return base.method_2<bool>("isStealthed");
                }
            }

            public bool isTaunter
            {
                get
                {
                    return base.method_2<bool>("isTaunter");
                }
            }

            public int owningPlayerID
            {
                get
                {
                    return base.method_2<int>("owningPlayerID");
                }
            }

            public int race
            {
                get
                {
                    return base.method_2<int>("race");
                }
            }

            public int rarity
            {
                get
                {
                    return base.method_2<int>("rarity");
                }
            }
        }
    }
}

