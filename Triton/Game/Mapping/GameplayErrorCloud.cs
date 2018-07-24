namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GameplayErrorCloud")]
    public class GameplayErrorCloud : MonoBehaviour
    {
        public GameplayErrorCloud(IntPtr address) : this(address, "GameplayErrorCloud")
        {
        }

        public GameplayErrorCloud(IntPtr address, string className) : base(address, className)
        {
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void HideMessage()
        {
            base.method_8("HideMessage", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void ShowMessage(string message, float timeToDisplay)
        {
            object[] objArray1 = new object[] { message, timeToDisplay };
            base.method_8("ShowMessage", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public static float ERROR_MESSAGE_DURATION
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "GameplayErrorCloud", "ERROR_MESSAGE_DURATION");
            }
        }

        public static float ERROR_MESSAGE_FADEIN
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "GameplayErrorCloud", "ERROR_MESSAGE_FADEIN");
            }
        }

        public static float ERROR_MESSAGE_FADEOUT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "GameplayErrorCloud", "ERROR_MESSAGE_FADEOUT");
            }
        }

        public float initTime
        {
            get
            {
                return base.method_2<float>("initTime");
            }
        }

        public UberText m_errorText
        {
            get
            {
                return base.method_3<UberText>("m_errorText");
            }
        }

        public float m_holdDuration
        {
            get
            {
                return base.method_2<float>("m_holdDuration");
            }
        }

        public string START_COROUTINE_NAME
        {
            get
            {
                return base.method_4("START_COROUTINE_NAME");
            }
        }
    }
}

