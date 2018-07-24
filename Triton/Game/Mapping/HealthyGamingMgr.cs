namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("HealthyGamingMgr")]
    public class HealthyGamingMgr : MonoBehaviour
    {
        public HealthyGamingMgr(IntPtr address) : this(address, "HealthyGamingMgr")
        {
        }

        public HealthyGamingMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ChinaRestrictions()
        {
            base.method_8("ChinaRestrictions", Array.Empty<object>());
        }

        public void ChinaRestrictions_3to5Hours(int minutesPlayed)
        {
            object[] objArray1 = new object[] { minutesPlayed };
            base.method_8("ChinaRestrictions_3to5Hours", objArray1);
        }

        public void ChinaRestrictions_LessThan3Hours(int minutesPlayed, int hours)
        {
            object[] objArray1 = new object[] { minutesPlayed, hours };
            base.method_8("ChinaRestrictions_LessThan3Hours", objArray1);
        }

        public void ChinaRestrictions_LockoutFeatures(int minutesPlayed)
        {
            object[] objArray1 = new object[] { minutesPlayed };
            base.method_8("ChinaRestrictions_LockoutFeatures", objArray1);
        }

        public void ChinaRestrictions_MoreThan5Hours(int minutesPlayed)
        {
            object[] objArray1 = new object[] { minutesPlayed };
            base.method_8("ChinaRestrictions_MoreThan5Hours", objArray1);
        }

        public static HealthyGamingMgr Get()
        {
            return MonoClass.smethod_15<HealthyGamingMgr>(TritonHs.MainAssemblyPath, "", "HealthyGamingMgr", "Get", Array.Empty<object>());
        }

        public ulong GetSessionStartTime()
        {
            return base.method_11<ulong>("GetSessionStartTime", Array.Empty<object>());
        }

        public bool isArenaEnabled()
        {
            return base.method_11<bool>("isArenaEnabled", Array.Empty<object>());
        }

        public void KoreaRestrictions()
        {
            base.method_8("KoreaRestrictions", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFatalError(FatalErrorMessage message, object userData)
        {
            object[] objArray1 = new object[] { message, userData };
            base.method_8("OnFatalError", objArray1);
        }

        public void OnLoggedIn()
        {
            base.method_8("OnLoggedIn", Array.Empty<object>());
        }

        public void OnReset()
        {
            base.method_8("OnReset", Array.Empty<object>());
        }

        public void StopCoroutinesAndResetState()
        {
            base.method_8("StopCoroutinesAndResetState", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public static float CAIS_ACTIVE_MESSAGE_DISPLAY_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HealthyGamingMgr", "CAIS_ACTIVE_MESSAGE_DISPLAY_TIME");
            }
        }

        public static float CAIS_MESSAGE_DISPLAY_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HealthyGamingMgr", "CAIS_MESSAGE_DISPLAY_TIME");
            }
        }

        public static float CHECK_INTERVAL
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HealthyGamingMgr", "CHECK_INTERVAL");
            }
        }

        public static float KOREA_MESSAGE_DISPLAY_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HealthyGamingMgr", "KOREA_MESSAGE_DISPLAY_TIME");
            }
        }

        public string m_AccountCountry
        {
            get
            {
                return base.method_4("m_AccountCountry");
            }
        }

        public bool m_BattleNetReady
        {
            get
            {
                return base.method_2<bool>("m_BattleNetReady");
            }
        }

        public bool m_DebugMode
        {
            get
            {
                return base.method_2<bool>("m_DebugMode");
            }
        }

        public bool m_HealthyGamingArenaEnabled
        {
            get
            {
                return base.method_2<bool>("m_HealthyGamingArenaEnabled");
            }
        }

        public bool m_NetworkDataReady
        {
            get
            {
                return base.method_2<bool>("m_NetworkDataReady");
            }
        }

        public float m_NextCheckTime
        {
            get
            {
                return base.method_2<float>("m_NextCheckTime");
            }
        }

        public float m_NextMessageDisplayTime
        {
            get
            {
                return base.method_2<float>("m_NextMessageDisplayTime");
            }
        }

        public ulong m_SessionStartTime
        {
            get
            {
                return base.method_2<ulong>("m_SessionStartTime");
            }
        }

        public int m_TimePlayed
        {
            get
            {
                return base.method_2<int>("m_TimePlayed");
            }
        }

        public int m_TimeRested
        {
            get
            {
                return base.method_2<int>("m_TimeRested");
            }
        }

        public static HealthyGamingMgr s_Instance
        {
            get
            {
                return MonoClass.smethod_7<HealthyGamingMgr>(TritonHs.MainAssemblyPath, "", "HealthyGamingMgr", "s_Instance");
            }
        }
    }
}

