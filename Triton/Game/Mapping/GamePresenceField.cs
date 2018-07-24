namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GamePresenceField")]
    public class GamePresenceField : MonoClass
    {
        public GamePresenceField(IntPtr address) : this(address, "GamePresenceField")
        {
        }

        public GamePresenceField(IntPtr address, string className) : base(address, className)
        {
        }

        public static uint ARENA_RECORD
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "ARENA_RECORD");
            }
        }

        public static uint CAN_BE_INVITED_TO_GAME
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "CAN_BE_INVITED_TO_GAME");
            }
        }

        public static uint CARDS_OPENED
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "CARDS_OPENED");
            }
        }

        public static uint CLIENT_ENV
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "CLIENT_ENV");
            }
        }

        public static uint CLIENT_VERSION
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "CLIENT_VERSION");
            }
        }

        public static uint COLLECTION_EVENT
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "COLLECTION_EVENT");
            }
        }

        public static uint DEBUG_STRING
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "DEBUG_STRING");
            }
        }

        public static uint DRUID_LEVEL
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "DRUID_LEVEL");
            }
        }

        public static uint GAIN_MEDAL
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "GAIN_MEDAL");
            }
        }

        public static uint GAME_ACCOUNT
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "GAME_ACCOUNT");
            }
        }

        public static uint HUNTER_LEVEL
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "HUNTER_LEVEL");
            }
        }

        public static uint MAGE_LEVEL
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "MAGE_LEVEL");
            }
        }

        public static uint PALADIN_LEVEL
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "PALADIN_LEVEL");
            }
        }

        public static uint PRIEST_LEVEL
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "PRIEST_LEVEL");
            }
        }

        public static uint RANK
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "RANK");
            }
        }

        public static uint ROGUE_LEVEL
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "ROGUE_LEVEL");
            }
        }

        public static uint SHAMAN_LEVEL
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "SHAMAN_LEVEL");
            }
        }

        public static uint SPECTATOR_INFO
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "SPECTATOR_INFO");
            }
        }

        public static uint STATUS
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "STATUS");
            }
        }

        public static uint TUTORIAL_BEATEN
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "TUTORIAL_BEATEN");
            }
        }

        public static uint WARLOCK_LEVEL
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "WARLOCK_LEVEL");
            }
        }

        public static uint WARRIOR_LEVEL
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "GamePresenceField", "WARRIOR_LEVEL");
            }
        }
    }
}

