namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("InitialConversationLines")]
    public class InitialConversationLines : MonoClass
    {
        public InitialConversationLines(IntPtr address) : this(address, "InitialConversationLines")
        {
        }

        public InitialConversationLines(IntPtr address, string className) : base(address, className)
        {
        }

        public static List<string> BRM_INITIAL_CONVO_LINES
        {
            get
            {
                Class245 class2 = MonoClass.smethod_7<Class245>(TritonHs.MainAssemblyPath, "", "InitialConversationLines", "BRM_INITIAL_CONVO_LINES");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static List<string> LOE_INITIAL_CONVO_LINES
        {
            get
            {
                Class245 class2 = MonoClass.smethod_7<Class245>(TritonHs.MainAssemblyPath, "", "InitialConversationLines", "LOE_INITIAL_CONVO_LINES");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

