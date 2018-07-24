namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GameColors")]
    public class GameColors : MonoClass
    {
        public GameColors(IntPtr address) : this(address, "GameColors")
        {
        }

        public GameColors(IntPtr address, string className) : base(address, className)
        {
        }

        public static Color BLIZZARD_BLUE
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "GameColors", "BLIZZARD_BLUE");
            }
        }

        public static string BLIZZARD_BLUE_STR
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GameColors", "BLIZZARD_BLUE_STR");
            }
        }

        public static string GOLD_STR
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GameColors", "GOLD_STR");
            }
        }

        public static string ORANGE_STR
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GameColors", "ORANGE_STR");
            }
        }

        public static Color PLAYER_NAME
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "GameColors", "PLAYER_NAME");
            }
        }

        public static Color PLAYER_NAME_OFFLINE
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "GameColors", "PLAYER_NAME_OFFLINE");
            }
        }

        public static string PLAYER_NAME_OFFLINE_STR
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GameColors", "PLAYER_NAME_OFFLINE_STR");
            }
        }

        public static Color PLAYER_NAME_ONLINE
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "GameColors", "PLAYER_NAME_ONLINE");
            }
        }

        public static string PLAYER_NAME_ONLINE_STR
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GameColors", "PLAYER_NAME_ONLINE_STR");
            }
        }

        public static string PLAYER_NAME_STR
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GameColors", "PLAYER_NAME_STR");
            }
        }

        public static Color PLAYER_NUMBER
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "GameColors", "PLAYER_NUMBER");
            }
        }

        public static string PLAYER_NUMBER_STR
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GameColors", "PLAYER_NUMBER_STR");
            }
        }

        public static Color SERVER_SHUTDOWN
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "GameColors", "SERVER_SHUTDOWN");
            }
        }

        public static string SERVER_SHUTDOWN_STR
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "GameColors", "SERVER_SHUTDOWN_STR");
            }
        }
    }
}

