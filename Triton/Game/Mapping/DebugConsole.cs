namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DebugConsole")]
    public class DebugConsole : MonoClass
    {
        public DebugConsole(IntPtr address) : this(address, "DebugConsole")
        {
        }

        public DebugConsole(IntPtr address, string className) : base(address, className)
        {
        }

        public static DebugConsole Get()
        {
            return MonoClass.smethod_15<DebugConsole>(TritonHs.MainAssemblyPath, "", "DebugConsole", "Get", Array.Empty<object>());
        }

        public void Init()
        {
            base.method_8("Init", Array.Empty<object>());
        }

        public void InitClientConsoleCallbackMap()
        {
            base.method_8("InitClientConsoleCallbackMap", Array.Empty<object>());
        }

        public void InitConsoleCallbackMaps()
        {
            base.method_8("InitConsoleCallbackMaps", Array.Empty<object>());
        }

        public void InitServerConsoleCallbackMap()
        {
            base.method_8("InitServerConsoleCallbackMap", Array.Empty<object>());
        }

        public void OnCommandReceived()
        {
            base.method_8("OnCommandReceived", Array.Empty<object>());
        }

        public void OnCommandResponseReceived()
        {
            base.method_8("OnCommandResponseReceived", Array.Empty<object>());
        }

        public void SendDebugConsoleResponse(DebugConsoleResponseType type, string message)
        {
            object[] objArray1 = new object[] { type, message };
            base.method_8("SendDebugConsoleResponse", objArray1);
        }

        public bool m_initialized
        {
            get
            {
                return base.method_2<bool>("m_initialized");
            }
        }

        [Attribute38("DebugConsole.CommandParamDecl")]
        public class CommandParamDecl : MonoClass
        {
            public CommandParamDecl(IntPtr address) : this(address, "CommandParamDecl")
            {
            }

            public CommandParamDecl(IntPtr address, string className) : base(address, className)
            {
            }

            public string Name
            {
                get
                {
                    return base.method_4("Name");
                }
            }

            public ParamType Type
            {
                get
                {
                    return base.method_2<ParamType>("Type");
                }
            }

            public enum ParamType
            {
                STR,
                I32,
                F32,
                BOOL
            }
        }

        [Attribute38("DebugConsole.ConsoleCallbackInfo")]
        public class ConsoleCallbackInfo : MonoClass
        {
            public ConsoleCallbackInfo(IntPtr address) : this(address, "ConsoleCallbackInfo")
            {
            }

            public ConsoleCallbackInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public int GetNumParams()
            {
                return base.method_11<int>("GetNumParams", Array.Empty<object>());
            }

            public bool DisplayInCommandList
            {
                get
                {
                    return base.method_2<bool>("DisplayInCommandList");
                }
            }

            public List<DebugConsole.CommandParamDecl> ParamList
            {
                get
                {
                    Class267<DebugConsole.CommandParamDecl> class2 = base.method_3<Class267<DebugConsole.CommandParamDecl>>("ParamList");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }
        }

        public enum DebugConsoleResponseType
        {
            CONSOLE_OUTPUT,
            LOG_MESSAGE
        }
    }
}

