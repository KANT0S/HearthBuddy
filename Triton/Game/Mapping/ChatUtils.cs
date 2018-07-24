namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ChatUtils")]
    public class ChatUtils : MonoClass
    {
        public ChatUtils(IntPtr address) : this(address, "ChatUtils")
        {
        }

        public ChatUtils(IntPtr address, string className) : base(address, className)
        {
        }

        public static string GetMessage(string message)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { message };
            return MonoClass.smethod_13(TritonHs.MainAssemblyPath, "", "ChatUtils", "GetMessage", enumArray1, objArray1);
        }

        public static float FRIENDLIST_CHATICON_INACTIVE_SEC
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ChatUtils", "FRIENDLIST_CHATICON_INACTIVE_SEC");
            }
        }

        public static int MAX_INPUT_CHARACTERS
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "ChatUtils", "MAX_INPUT_CHARACTERS");
            }
        }

        public static int MAX_RECENT_WHISPER_RECEIVERS
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "ChatUtils", "MAX_RECENT_WHISPER_RECEIVERS");
            }
        }
    }
}

