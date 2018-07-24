namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("PresenceMgr")]
    public class PresenceMgr : MonoClass
    {
        public PresenceMgr(IntPtr address) : this(address, "PresenceMgr")
        {
        }

        public PresenceMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public static PresenceMgr Get()
        {
            return MonoClass.smethod_15<PresenceMgr>(TritonHs.MainAssemblyPath, "", "PresenceMgr", "Get", Array.Empty<object>());
        }

        public List<MonoEnum> GetPrevStatus()
        {
            Class247<MonoEnum> class2 = base.method_14<Class247<MonoEnum>>("GetPrevStatus", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<MonoEnum> GetStatus()
        {
            Class247<MonoEnum> class2 = base.method_15<Class247<MonoEnum>>("GetStatus", new Class272.Enum20[0], Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public PresenceStatus GetStatus(BnetPlayer player)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { player };
            return base.method_10<PresenceStatus>("GetStatus", enumArray1, objArray1);
        }

        public List<MonoEnum> GetStatusEnums(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            Class247<MonoEnum> class2 = base.method_14<Class247<MonoEnum>>("GetStatusEnums", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public string GetStatusText(BnetPlayer player)
        {
            object[] objArray1 = new object[] { player };
            return base.method_13("GetStatusText", objArray1);
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public static bool IsStatusPlayingGame(PresenceStatus status)
        {
            object[] objArray1 = new object[] { status };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "PresenceMgr", "IsStatusPlayingGame", objArray1);
        }

        public bool SetPrevStatus()
        {
            return base.method_11<bool>("SetPrevStatus", Array.Empty<object>());
        }

        public bool SetStatus_EnteringAdventure(AdventureDbId adventureId, AdventureModeDbId adventureModeId)
        {
            object[] objArray1 = new object[] { adventureId, adventureModeId };
            return base.method_11<bool>("SetStatus_EnteringAdventure", objArray1);
        }

        public bool SetStatus_PlayingMission(ScenarioDbId missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return base.method_11<bool>("SetStatus_PlayingMission", objArray1);
        }

        public bool SetStatus_SpectatingMission(ScenarioDbId missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return base.method_11<bool>("SetStatus_SpectatingMission", objArray1);
        }

        public List<MonoEnum> m_prevStatus
        {
            get
            {
                Class247<MonoEnum> class2 = base.method_3<Class247<MonoEnum>>("m_prevStatus");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<MonoEnum> m_richPresence
        {
            get
            {
                Class247<MonoEnum> class2 = base.method_3<Class247<MonoEnum>>("m_richPresence");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<MonoEnum> m_status
        {
            get
            {
                Class247<MonoEnum> class2 = base.method_3<Class247<MonoEnum>>("m_status");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static List<System.Type> s_enumIdList
        {
            get
            {
                Class247<System.Type> class2 = MonoClass.smethod_7<Class247<System.Type>>(TritonHs.MainAssemblyPath, "", "PresenceMgr", "s_enumIdList");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PresenceTargets
        {
            public PresenceAdventureMode EnteringAdventureValue;
            public PresenceStatus SpectatingValue;
        }
    }
}

