namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DemoMgr")]
    public class DemoMgr : MonoClass
    {
        public DemoMgr(IntPtr address) : this(address, "DemoMgr")
        {
        }

        public DemoMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void ApplyAppleStoreDemoDefaults()
        {
            base.method_8("ApplyAppleStoreDemoDefaults", Array.Empty<object>());
        }

        public bool ArenaIs1WinMode()
        {
            return base.method_11<bool>("ArenaIs1WinMode", Array.Empty<object>());
        }

        public bool CantExitArena()
        {
            return base.method_11<bool>("CantExitArena", Array.Empty<object>());
        }

        public void ChangeDemoText(string demoText)
        {
            object[] objArray1 = new object[] { demoText };
            base.method_8("ChangeDemoText", objArray1);
        }

        public void CreateDemoText(string demoText)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { demoText };
            base.method_9("CreateDemoText", enumArray1, objArray1);
        }

        public void CreateDemoText(string demoText, bool unclickable)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { demoText, unclickable };
            base.method_9("CreateDemoText", enumArray1, objArray1);
        }

        public void CreateDemoText(string demoText, bool unclickable, bool shouldDoArenaInstruction)
        {
            object[] objArray1 = new object[] { demoText, unclickable, shouldDoArenaInstruction };
            base.method_9("CreateDemoText", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public void DemoTextLoaded(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("DemoTextLoaded", objArray1);
        }

        public static DemoMgr Get()
        {
            return MonoClass.smethod_15<DemoMgr>(TritonHs.MainAssemblyPath, "", "DemoMgr", "Get", Array.Empty<object>());
        }

        public DemoMode GetMode()
        {
            return base.method_11<DemoMode>("GetMode", Array.Empty<object>());
        }

        public DemoMode GetModeFromString(string modeString)
        {
            object[] objArray1 = new object[] { modeString };
            return base.method_11<DemoMode>("GetModeFromString", objArray1);
        }

        public string GetStoredGameMode()
        {
            return base.method_13("GetStoredGameMode", Array.Empty<object>());
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public bool IsCurrencyEnabled()
        {
            return base.method_11<bool>("IsCurrencyEnabled", Array.Empty<object>());
        }

        public bool IsDemo()
        {
            return base.method_11<bool>("IsDemo", Array.Empty<object>());
        }

        public bool IsExpoDemo()
        {
            return base.method_11<bool>("IsExpoDemo", Array.Empty<object>());
        }

        public bool IsHubEscMenuEnabled()
        {
            return base.method_11<bool>("IsHubEscMenuEnabled", Array.Empty<object>());
        }

        public bool IsSocialEnabled()
        {
            return base.method_11<bool>("IsSocialEnabled", Array.Empty<object>());
        }

        public void MakeDemoTextClickable(bool clickable)
        {
            object[] objArray1 = new object[] { clickable };
            base.method_8("MakeDemoTextClickable", objArray1);
        }

        public void NextDemoTipIsNewArenaMatch()
        {
            base.method_8("NextDemoTipIsNewArenaMatch", Array.Empty<object>());
        }

        public void RemoveDemoTextDialog()
        {
            base.method_9("RemoveDemoTextDialog", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void RemoveDemoTextDialog(UIEvent e)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { e };
            base.method_9("RemoveDemoTextDialog", enumArray1, objArray1);
        }

        public void SetMode(DemoMode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("SetMode", objArray1);
        }

        public void SetModeFromString(string modeString)
        {
            object[] objArray1 = new object[] { modeString };
            base.method_8("SetModeFromString", objArray1);
        }

        public bool ShouldShowWelcomeQuests()
        {
            return base.method_11<bool>("ShouldShowWelcomeQuests", Array.Empty<object>());
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public static bool LOAD_STORED_SETTING
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "DemoMgr", "LOAD_STORED_SETTING");
            }
        }

        public Triton.Game.Mapping.Notification m_demoText
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Notification>("m_demoText");
            }
        }

        public DemoMode m_mode
        {
            get
            {
                return base.method_2<DemoMode>("m_mode");
            }
        }

        public bool m_nextDemoTipIsNewArenaMatch
        {
            get
            {
                return base.method_2<bool>("m_nextDemoTipIsNewArenaMatch");
            }
        }

        public bool m_nextTipUnclickable
        {
            get
            {
                return base.method_2<bool>("m_nextTipUnclickable");
            }
        }

        public bool m_shouldGiveArenaInstruction
        {
            get
            {
                return base.method_2<bool>("m_shouldGiveArenaInstruction");
            }
        }
    }
}

