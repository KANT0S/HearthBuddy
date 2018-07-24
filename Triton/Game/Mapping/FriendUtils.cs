namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FriendUtils")]
    public class FriendUtils : MonoClass
    {
        public FriendUtils(IntPtr address) : this(address, "FriendUtils")
        {
        }

        public FriendUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static int FriendNameSortCompare(BnetPlayer friend1, BnetPlayer friend2)
        {
            object[] objArray1 = new object[] { friend1, friend2 };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "FriendUtils", "FriendNameSortCompare", objArray1);
        }

        public static int FriendSortCompare(BnetPlayer friend1, BnetPlayer friend2)
        {
            object[] objArray1 = new object[] { friend1, friend2 };
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "FriendUtils", "FriendSortCompare", objArray1);
        }

        public static string GetAwayTimeString(ulong epochMicrosec)
        {
            object[] objArray1 = new object[] { epochMicrosec };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FriendUtils", "GetAwayTimeString", objArray1);
        }

        public static string GetBattleTagWithColor(BnetBattleTag battleTag, string nameColorStr)
        {
            object[] objArray1 = new object[] { battleTag, nameColorStr };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FriendUtils", "GetBattleTagWithColor", objArray1);
        }

        public static string GetFriendListName(BnetPlayer friend, bool addColorTags)
        {
            object[] objArray1 = new object[] { friend, addColorTags };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FriendUtils", "GetFriendListName", objArray1);
        }

        public static string GetLastOnlineElapsedTimeString(ulong epochMicrosec)
        {
            object[] objArray1 = new object[] { epochMicrosec };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FriendUtils", "GetLastOnlineElapsedTimeString", objArray1);
        }

        public static string GetRequestElapsedTimeString(ulong epochMicrosec)
        {
            object[] objArray1 = new object[] { epochMicrosec };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FriendUtils", "GetRequestElapsedTimeString", objArray1);
        }

        public static string GetUniqueName(BnetPlayer friend)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { friend };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "FriendUtils", "GetUniqueName", enumArray1, objArray1);
        }

        public static string GetUniqueNameWithColor(BnetPlayer friend)
        {
            object[] objArray1 = new object[] { friend };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "FriendUtils", "GetUniqueNameWithColor", objArray1);
        }

        public static bool IsValidEmail(string emailString)
        {
            object[] objArray1 = new object[] { emailString };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "FriendUtils", "IsValidEmail", objArray1);
        }
    }
}

