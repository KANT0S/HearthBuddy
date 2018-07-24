namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AutomationInterpretor")]
    public class AutomationInterpretor : MonoClass
    {
        public AutomationInterpretor(IntPtr address) : this(address, "AutomationInterpretor")
        {
        }

        public AutomationInterpretor(IntPtr address, string className) : base(address, className)
        {
        }

        public static AutomationInterpretor Get()
        {
            return MonoClass.smethod_15<AutomationInterpretor>(TritonHs.MainAssemblyPath, "", "AutomationInterpretor", "Get", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public static string CUSTOM_ARG_PREFIX
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AutomationInterpretor", "CUSTOM_ARG_PREFIX");
            }
        }

        public static bool m_DebugLog
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "AutomationInterpretor", "m_DebugLog");
            }
        }

        public bool m_initLoadComplete
        {
            get
            {
                return base.method_2<bool>("m_initLoadComplete");
            }
        }

        public bool m_isClosed
        {
            get
            {
                return base.method_2<bool>("m_isClosed");
            }
        }

        public bool m_isClosing
        {
            get
            {
                return base.method_2<bool>("m_isClosing");
            }
        }

        public static bool m_isDebugBuild
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "AutomationInterpretor", "m_isDebugBuild");
            }
        }

        public bool m_wasPaused
        {
            get
            {
                return base.method_2<bool>("m_wasPaused");
            }
        }

        public static float s_connectionTimeoutLength
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AutomationInterpretor", "s_connectionTimeoutLength");
            }
        }

        public static string s_newPacketTag
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AutomationInterpretor", "s_newPacketTag");
            }
        }
    }
}

