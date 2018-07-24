namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CheatMgr")]
    public class CheatMgr : MonoBehaviour
    {
        public CheatMgr(IntPtr address) : this(address, "CheatMgr")
        {
        }

        public CheatMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public string ExtractFunc(string inputCommand)
        {
            object[] objArray1 = new object[] { inputCommand };
            return base.method_13("ExtractFunc", objArray1);
        }

        public static CheatMgr Get()
        {
            return MonoClass.smethod_15<CheatMgr>(TritonHs.MainAssemblyPath, "", "CheatMgr", "Get", Array.Empty<object>());
        }

        public string GetOriginalFunc(string func)
        {
            object[] objArray1 = new object[] { func };
            return base.method_13("GetOriginalFunc", objArray1);
        }

        public bool HandleKeyboardInput()
        {
            return base.method_11<bool>("HandleKeyboardInput", Array.Empty<object>());
        }

        public void OnGUI()
        {
            base.method_8("OnGUI", Array.Empty<object>());
        }

        public void OnInputComplete(string inputCommand)
        {
            object[] objArray1 = new object[] { inputCommand };
            base.method_8("OnInputComplete", objArray1);
        }

        public string ProcessCheat(string inputCommand)
        {
            object[] objArray1 = new object[] { inputCommand };
            return base.method_13("ProcessCheat", objArray1);
        }

        public void ReadCheatHistoryOption()
        {
            base.method_8("ReadCheatHistoryOption", Array.Empty<object>());
        }

        public void WriteCheatHistoryOption()
        {
            base.method_8("WriteCheatHistoryOption", Array.Empty<object>());
        }

        public List<string> m_cheatHistory
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_cheatHistory");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_cheatHistoryIndex
        {
            get
            {
                return base.method_2<int>("m_cheatHistoryIndex");
            }
        }

        public Rect m_cheatInputBackground
        {
            get
            {
                return base.method_2<Rect>("m_cheatInputBackground");
            }
        }

        public string m_cheatTextBeforeScrollingThruHistory
        {
            get
            {
                return base.method_4("m_cheatTextBeforeScrollingThruHistory");
            }
        }

        public bool m_inputActive
        {
            get
            {
                return base.method_2<bool>("m_inputActive");
            }
        }

        public static int MAX_HISTORY_LINES
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CheatMgr", "MAX_HISTORY_LINES");
            }
        }
    }
}

