namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SceneDebugger")]
    public class SceneDebugger : MonoBehaviour
    {
        public SceneDebugger(IntPtr address) : this(address, "SceneDebugger")
        {
        }

        public SceneDebugger(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddMessage(string message)
        {
            object[] objArray1 = new object[] { message };
            base.method_8("AddMessage", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static SceneDebugger Get()
        {
            return MonoClass.smethod_15<SceneDebugger>(TritonHs.MainAssemblyPath, "", "SceneDebugger", "Get", Array.Empty<object>());
        }

        public static float GetDevTimescale()
        {
            return MonoClass.smethod_14<float>(TritonHs.MainAssemblyPath, "", "SceneDebugger", "GetDevTimescale", Array.Empty<object>());
        }

        public string GetMessageText()
        {
            return base.method_13("GetMessageText", Array.Empty<object>());
        }

        public void InitMessagesIfNecessary()
        {
            base.method_8("InitMessagesIfNecessary", Array.Empty<object>());
        }

        public void InitMessageStyleIfNecessary()
        {
            base.method_8("InitMessageStyleIfNecessary", Array.Empty<object>());
        }

        public void LayoutLeftScreenControls()
        {
            base.method_8("LayoutLeftScreenControls", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnGUI()
        {
            base.method_8("OnGUI", Array.Empty<object>());
        }

        public static void SetDevTimescale(float f)
        {
            object[] objArray1 = new object[] { f };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "SceneDebugger", "SetDevTimescale", objArray1);
        }

        public Vector2 m_GUIPosition
        {
            get
            {
                return base.method_2<Vector2>("m_GUIPosition");
            }
        }

        public Vector2 m_GUISize
        {
            get
            {
                return base.method_2<Vector2>("m_GUISize");
            }
        }

        public bool m_hideMessages
        {
            get
            {
                return base.method_2<bool>("m_hideMessages");
            }
        }

        public float m_MaxTimeScale
        {
            get
            {
                return base.method_2<float>("m_MaxTimeScale");
            }
        }

        public float m_MinTimeScale
        {
            get
            {
                return base.method_2<float>("m_MinTimeScale");
            }
        }

        public static int MAX_MESSAGES
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "SceneDebugger", "MAX_MESSAGES");
            }
        }
    }
}

