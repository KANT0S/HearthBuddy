namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GameplayErrorManager")]
    public class GameplayErrorManager : MonoBehaviour
    {
        public GameplayErrorManager(IntPtr address) : this(address, "GameplayErrorManager")
        {
        }

        public GameplayErrorManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DisplayMessage(string message)
        {
            object[] objArray1 = new object[] { message };
            base.method_8("DisplayMessage", objArray1);
        }

        public static GameplayErrorManager Get()
        {
            return MonoClass.smethod_15<GameplayErrorManager>(TritonHs.MainAssemblyPath, "", "GameplayErrorManager", "Get", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public float m_displaySecsLeft
        {
            get
            {
                return base.method_2<float>("m_displaySecsLeft");
            }
        }

        public GameplayErrorCloud m_errorMessagePrefab
        {
            get
            {
                return base.method_3<GameplayErrorCloud>("m_errorMessagePrefab");
            }
        }

        public string m_message
        {
            get
            {
                return base.method_4("m_message");
            }
        }

        public static GameplayErrorCloud s_messageInstance
        {
            get
            {
                return MonoClass.smethod_7<GameplayErrorCloud>(TritonHs.MainAssemblyPath, "", "GameplayErrorManager", "s_messageInstance");
            }
        }
    }
}

