namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ErrorReporter")]
    public class ErrorReporter : MonoBehaviour
    {
        public ErrorReporter(IntPtr address) : this(address, "ErrorReporter")
        {
        }

        public ErrorReporter(IntPtr address, string className) : base(address, className)
        {
        }

        public static bool alreadySent(string hash)
        {
            object[] objArray1 = new object[] { hash };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "ErrorReporter", "alreadySent", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static string buildMarkup(string title, string stackTrace, string hashBlock)
        {
            object[] objArray1 = new object[] { title, stackTrace, hashBlock };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "ErrorReporter", "buildMarkup", objArray1);
        }

        public static string createEscapedSGML(string blob)
        {
            object[] objArray1 = new object[] { blob };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "ErrorReporter", "createEscapedSGML", objArray1);
        }

        public static string createHash(string blob)
        {
            object[] objArray1 = new object[] { blob };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "ErrorReporter", "createHash", objArray1);
        }

        public static ErrorReporter Get()
        {
            return MonoClass.smethod_15<ErrorReporter>(TritonHs.MainAssemblyPath, "", "ErrorReporter", "Get", Array.Empty<object>());
        }

        public void OnApplicationQuit()
        {
            base.method_8("OnApplicationQuit", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void register()
        {
            base.method_8("register", Array.Empty<object>());
        }

        public void reportUnhandledException(string message, string stackTrace)
        {
            object[] objArray1 = new object[] { message, stackTrace };
            base.method_8("reportUnhandledException", objArray1);
        }

        public void send(string message, string stackTrace)
        {
            object[] objArray1 = new object[] { message, stackTrace };
            base.method_8("send", objArray1);
        }

        public void unregister()
        {
            base.method_8("unregister", Array.Empty<object>());
        }

        public bool busy
        {
            get
            {
                return base.method_11<bool>("get_busy", Array.Empty<object>());
            }
        }

        public static int hearthstoneProjectID_
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "ErrorReporter", "hearthstoneProjectID_");
            }
        }

        public static ErrorReporter instance_
        {
            get
            {
                return MonoClass.smethod_7<ErrorReporter>(TritonHs.MainAssemblyPath, "", "ErrorReporter", "instance_");
            }
        }

        public static string localTime
        {
            get
            {
                return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "ErrorReporter", "get_localTime", Array.Empty<object>());
            }
        }

        public List<string> m_previousExceptions
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_previousExceptions");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int sendCount_
        {
            get
            {
                return base.method_2<int>("sendCount_");
            }
        }

        public string submitURL
        {
            get
            {
                return base.method_13("get_submitURL", Array.Empty<object>());
            }
        }
    }
}

