namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FatalErrorDialog")]
    public class FatalErrorDialog : MonoBehaviour
    {
        public FatalErrorDialog(IntPtr address) : this(address, "FatalErrorDialog")
        {
        }

        public FatalErrorDialog(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BuildText()
        {
            base.method_8("BuildText", Array.Empty<object>());
        }

        public void InitGUIStyles()
        {
            base.method_8("InitGUIStyles", Array.Empty<object>());
        }

        public void OnFatalError(FatalErrorMessage message, object userData)
        {
            object[] objArray1 = new object[] { message, userData };
            base.method_8("OnFatalError", objArray1);
        }

        public void OnGUI()
        {
            base.method_8("OnGUI", Array.Empty<object>());
        }

        public static float ButtonHeight
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "FatalErrorDialog", "ButtonHeight");
            }
        }

        public float ButtonLeft
        {
            get
            {
                return base.method_11<float>("get_ButtonLeft", Array.Empty<object>());
            }
        }

        public Rect ButtonRect
        {
            get
            {
                return base.method_11<Rect>("get_ButtonRect", Array.Empty<object>());
            }
        }

        public float ButtonTop
        {
            get
            {
                return base.method_11<float>("get_ButtonTop", Array.Empty<object>());
            }
        }

        public static float ButtonWidth
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "FatalErrorDialog", "ButtonWidth");
            }
        }

        public static float DialogHeight
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "FatalErrorDialog", "DialogHeight");
            }
        }

        public float DialogLeft
        {
            get
            {
                return base.method_11<float>("get_DialogLeft", Array.Empty<object>());
            }
        }

        public static float DialogPadding
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "FatalErrorDialog", "DialogPadding");
            }
        }

        public Rect DialogRect
        {
            get
            {
                return base.method_11<Rect>("get_DialogRect", Array.Empty<object>());
            }
        }

        public float DialogTop
        {
            get
            {
                return base.method_11<float>("get_DialogTop", Array.Empty<object>());
            }
        }

        public static float DialogWidth
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "FatalErrorDialog", "DialogWidth");
            }
        }

        public string m_text
        {
            get
            {
                return base.method_4("m_text");
            }
        }
    }
}

