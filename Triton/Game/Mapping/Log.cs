namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Log")]
    public class Log : MonoClass
    {
        public Log(IntPtr address) : this(address, "Log")
        {
        }

        public Log(IntPtr address, string className) : base(address, className)
        {
        }

        public static Triton.Game.Mapping.Log Get()
        {
            return MonoClass.smethod_15<Triton.Game.Mapping.Log>(TritonHs.MainAssemblyPath, "", "Log", "Get", Array.Empty<object>());
        }

        public LogInfo GetLogInfo(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_14<LogInfo>("GetLogInfo", objArray1);
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public void Load()
        {
            base.method_8("Load", Array.Empty<object>());
        }

        public void LoadConfig(string path)
        {
            object[] objArray1 = new object[] { path };
            base.method_8("LoadConfig", objArray1);
        }

        public static Logger Achievements
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Achievements");
            }
        }

        public static Logger AdTracking
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "AdTracking");
            }
        }

        public static Logger Arena
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Arena");
            }
        }

        public static Logger Asset
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Asset");
            }
        }

        public static Logger BattleNet
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "BattleNet");
            }
        }

        public static Logger Becca
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Becca");
            }
        }

        public static Logger Ben
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Ben");
            }
        }

        public static Logger BIReport
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "BIReport");
            }
        }

        public static Logger Bob
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Bob");
            }
        }

        public static Logger Brian
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Brian");
            }
        }

        public static Logger BugReporter
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "BugReporter");
            }
        }

        public static Logger Cameron
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Cameron");
            }
        }

        public static Logger CardbackMgr
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "CardbackMgr");
            }
        }

        public static Logger ClientRequestManager
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "ClientRequestManager");
            }
        }

        public static string CONFIG_FILE_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Log", "CONFIG_FILE_NAME");
            }
        }

        public static Logger ConfigFile
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "ConfigFile");
            }
        }

        public static Logger DbfXml
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "DbfXml");
            }
        }

        public List<LogInfo> DEFAULT_LOG_INFOS
        {
            get
            {
                Class247<LogInfo> class2 = base.method_3<Class247<LogInfo>>("DEFAULT_LOG_INFOS");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static Logger Derek
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Derek");
            }
        }

        public static Logger DeviceEmulation
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "DeviceEmulation");
            }
        }

        public static Logger Downloader
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Downloader");
            }
        }

        public static Logger EndOfGame
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "EndOfGame");
            }
        }

        public static Logger EventTiming
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "EventTiming");
            }
        }

        public static Logger FaceDownCard
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "FaceDownCard");
            }
        }

        public static Logger FullScreenFX
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "FullScreenFX");
            }
        }

        public static Logger GameMgr
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "GameMgr");
            }
        }

        public static Logger Graphics
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Graphics");
            }
        }

        public static Logger Hand
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Hand");
            }
        }

        public static Logger HealthyGaming
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "HealthyGaming");
            }
        }

        public static Logger Henry
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Henry");
            }
        }

        public static Logger InnKeepersSpecial
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "InnKeepersSpecial");
            }
        }

        public static Logger Jay
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Jay");
            }
        }

        public static Logger JMac
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "JMac");
            }
        }

        public static Logger Josh
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Josh");
            }
        }

        public static Logger Kyle
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Kyle");
            }
        }

        public static Logger LoadingScreen
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "LoadingScreen");
            }
        }

        public static Logger Mike
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Mike");
            }
        }

        public static Logger MikeH
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "MikeH");
            }
        }

        public static Logger MissingAssets
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "MissingAssets");
            }
        }

        public static Logger Net
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Net");
            }
        }

        public static Logger Packets
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Packets");
            }
        }

        public static Logger Party
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Party");
            }
        }

        public static Logger PlayErrors
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "PlayErrors");
            }
        }

        public static Logger Power
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Power");
            }
        }

        public static Logger Rachelle
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Rachelle");
            }
        }

        public static Logger Reset
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Reset");
            }
        }

        public static Logger Robin
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Robin");
            }
        }

        public static Logger Ryan
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Ryan");
            }
        }

        public static Logger Sound
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Sound");
            }
        }

        public static Logger Spectator
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Spectator");
            }
        }

        public static Logger Store
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Store");
            }
        }

        public static Logger UpdateManager
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "UpdateManager");
            }
        }

        public static Logger Yim
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Yim");
            }
        }

        public static Logger Zone
        {
            get
            {
                return MonoClass.smethod_7<Logger>(TritonHs.MainAssemblyPath, "", "Log", "Zone");
            }
        }
    }
}

