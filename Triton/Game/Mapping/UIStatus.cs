namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("UIStatus")]
    public class UIStatus : MonoBehaviour
    {
        public UIStatus(IntPtr address) : this(address, "UIStatus")
        {
        }

        public UIStatus(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddError(string message)
        {
            object[] objArray1 = new object[] { message };
            base.method_8("AddError", objArray1);
        }

        public void AddInfo(string message)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { message };
            base.method_9("AddInfo", enumArray1, objArray1);
        }

        public void AddInfo(string message, bool isScreenshot)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { message, isScreenshot };
            base.method_9("AddInfo", enumArray1, objArray1);
        }

        public void AddInfo(string message, float delay)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { message, delay };
            base.method_9("AddInfo", enumArray1, objArray1);
        }

        public void AddInfo(string message, bool isScreenshot, float delay)
        {
            object[] objArray1 = new object[] { message, isScreenshot, delay };
            base.method_9("AddInfo", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static UIStatus Get()
        {
            return MonoClass.smethod_15<UIStatus>(TritonHs.MainAssemblyPath, "", "UIStatus", "Get", Array.Empty<object>());
        }

        public void HideIfScreenshotMessage()
        {
            base.method_8("HideIfScreenshotMessage", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFadeComplete()
        {
            base.method_8("OnFadeComplete", Array.Empty<object>());
        }

        public void ShowMessage(string message)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { message };
            base.method_9("ShowMessage", enumArray1, objArray1);
        }

        public void ShowMessage(string message, float delay)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { message, delay };
            base.method_9("ShowMessage", enumArray1, objArray1);
        }

        public Color m_ErrorColor
        {
            get
            {
                return base.method_2<Color>("m_ErrorColor");
            }
        }

        public float m_FadeDelaySec
        {
            get
            {
                return base.method_2<float>("m_FadeDelaySec");
            }
        }

        public iTween.EaseType m_FadeEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_FadeEaseType");
            }
        }

        public float m_FadeSec
        {
            get
            {
                return base.method_2<float>("m_FadeSec");
            }
        }

        public Color m_InfoColor
        {
            get
            {
                return base.method_2<Color>("m_InfoColor");
            }
        }

        public bool m_isScreenshot
        {
            get
            {
                return base.method_2<bool>("m_isScreenshot");
            }
        }

        public UberText m_Text
        {
            get
            {
                return base.method_3<UberText>("m_Text");
            }
        }
    }
}

