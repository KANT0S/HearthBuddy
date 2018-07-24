namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using System.Runtime.InteropServices;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TextField")]
    public class TextField : PegUIElement
    {
        public TextField(IntPtr address) : this(address, "TextField")
        {
        }

        public TextField(IntPtr address, string className) : base(address, className)
        {
        }

        public void Activate()
        {
            base.method_8("Activate", Array.Empty<object>());
        }

        public static PluginRect ActivateTextField(string name, PluginRect bounds, int autocorrect, uint keyboardType, uint returnKeyType)
        {
            object[] objArray1 = new object[] { name, bounds, autocorrect, keyboardType, returnKeyType };
            return MonoClass.smethod_14<PluginRect>(TritonHs.MainAssemblyPath, "", "TextField", "ActivateTextField", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public Rect ComputeBounds()
        {
            return base.method_11<Rect>("ComputeBounds", Array.Empty<object>());
        }

        public void Deactivate()
        {
            base.method_8("Deactivate", Array.Empty<object>());
        }

        public static void DeactivateTextField()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "TextField", "DeactivateTextField");
        }

        public static string GetTextFieldText()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "TextField", "GetTextFieldText", Array.Empty<object>());
        }

        public void InputCanceled(bool userRequested, GameObject requester)
        {
            object[] objArray1 = new object[] { userRequested, requester };
            base.method_8("InputCanceled", objArray1);
        }

        public void OnCanceled()
        {
            base.method_8("OnCanceled", Array.Empty<object>());
        }

        public void OnChanged(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("OnChanged", objArray1);
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

        public void OnKeyboardAreaChanged(Rect area)
        {
            object[] objArray1 = new object[] { area };
            base.method_8("OnKeyboardAreaChanged", objArray1);
        }

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public void OnSubmitted(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("OnSubmitted", objArray1);
        }

        public static PluginRect Plugin_ActivateTextField(string name, PluginRect bounds, int autocorrect, uint keyboardType, uint returnKeyType)
        {
            object[] objArray1 = new object[] { name, bounds, autocorrect, keyboardType, returnKeyType };
            return MonoClass.smethod_14<PluginRect>(TritonHs.MainAssemblyPath, "", "TextField", "Plugin_ActivateTextField", objArray1);
        }

        public static void Plugin_DeactivateTextField()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "TextField", "Plugin_DeactivateTextField");
        }

        public static string Plugin_GetTextFieldText()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "TextField", "Plugin_GetTextFieldText", Array.Empty<object>());
        }

        public static void Plugin_SetTextFieldBounds(PluginRect bounds)
        {
            object[] objArray1 = new object[] { bounds };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "TextField", "Plugin_SetTextFieldBounds", objArray1);
        }

        public static void Plugin_SetTextFieldColor(float r, float g, float b, float a)
        {
            object[] objArray1 = new object[] { r, g, b, a };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "TextField", "Plugin_SetTextFieldColor", objArray1);
        }

        public static void Plugin_SetTextFieldMaxCharacters(int maxCharacters)
        {
            object[] objArray1 = new object[] { maxCharacters };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "TextField", "Plugin_SetTextFieldMaxCharacters", objArray1);
        }

        public static void Plugin_SetTextFieldText(string text)
        {
            object[] objArray1 = new object[] { text };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "TextField", "Plugin_SetTextFieldText", objArray1);
        }

        public static void SetTextFieldBounds(PluginRect bounds)
        {
            object[] objArray1 = new object[] { bounds };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "TextField", "SetTextFieldBounds", objArray1);
        }

        public static void SetTextFieldColor(float r, float g, float b, float a)
        {
            object[] objArray1 = new object[] { r, g, b, a };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "TextField", "SetTextFieldColor", objArray1);
        }

        public static void SetTextFieldMaxCharacters(int maxCharacters)
        {
            object[] objArray1 = new object[] { maxCharacters };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "TextField", "SetTextFieldMaxCharacters", objArray1);
        }

        public static void SetTextFieldText(string text)
        {
            object[] objArray1 = new object[] { text };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "TextField", "SetTextFieldText", objArray1);
        }

        public void Unity_KeyboardAreaChanged(string rectString)
        {
            object[] objArray1 = new object[] { rectString };
            base.method_8("Unity_KeyboardAreaChanged", objArray1);
        }

        public void Unity_TextInputCanceled(string unused)
        {
            object[] objArray1 = new object[] { unused };
            base.method_8("Unity_TextInputCanceled", objArray1);
        }

        public void Unity_TextInputChanged(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("Unity_TextInputChanged", objArray1);
        }

        public void Unity_TextInputSubmitted(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("Unity_TextInputSubmitted", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateCollider()
        {
            base.method_8("UpdateCollider", Array.Empty<object>());
        }

        public void UpdateTextInput()
        {
            base.method_8("UpdateTextInput", Array.Empty<object>());
        }

        public static bool UseNativeKeyboard()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "TextField", "UseNativeKeyboard", Array.Empty<object>());
        }

        public bool Active
        {
            get
            {
                return base.method_11<bool>("get_Active", Array.Empty<object>());
            }
        }

        public bool autocorrect
        {
            get
            {
                return base.method_2<bool>("autocorrect");
            }
        }

        public bool hideInput
        {
            get
            {
                return base.method_2<bool>("hideInput");
            }
        }

        public Transform inputBottomRight
        {
            get
            {
                return base.method_3<Transform>("inputBottomRight");
            }
        }

        public bool inputKeepFocusOnComplete
        {
            get
            {
                return base.method_2<bool>("inputKeepFocusOnComplete");
            }
        }

        public UniversalInputManager.TextInputParams inputParams
        {
            get
            {
                return base.method_3<UniversalInputManager.TextInputParams>("inputParams");
            }
        }

        public Transform inputTopLeft
        {
            get
            {
                return base.method_3<Transform>("inputTopLeft");
            }
        }

        public static TextField instance
        {
            get
            {
                return MonoClass.smethod_7<TextField>(TritonHs.MainAssemblyPath, "", "TextField", "instance");
            }
        }

        public static Rect KeyboardArea
        {
            get
            {
                return MonoClass.smethod_14<Rect>(TritonHs.MainAssemblyPath, "", "TextField", "get_KeyboardArea", Array.Empty<object>());
            }
        }

        public KeyboardType keyboardType
        {
            get
            {
                return base.method_2<KeyboardType>("keyboardType");
            }
        }

        public Vector3 lastBottomRight
        {
            get
            {
                return base.method_2<Vector3>("lastBottomRight");
            }
        }

        public Rect lastBounds
        {
            get
            {
                return base.method_2<Rect>("lastBounds");
            }
        }

        public Vector3 lastTopLeft
        {
            get
            {
                return base.method_2<Vector3>("lastTopLeft");
            }
        }

        public int maxCharacters
        {
            get
            {
                return base.method_2<int>("maxCharacters");
            }
        }

        public static uint nextId
        {
            get
            {
                return MonoClass.smethod_6<uint>(TritonHs.MainAssemblyPath, "", "TextField", "nextId");
            }
        }

        public KeyboardReturnKeyType returnKeyType
        {
            get
            {
                return base.method_2<KeyboardReturnKeyType>("returnKeyType");
            }
        }

        public string Text
        {
            get
            {
                return base.method_13("get_Text", Array.Empty<object>());
            }
        }

        public Color textColor
        {
            get
            {
                return base.method_2<Color>("textColor");
            }
        }

        public bool useNativeKeyboard
        {
            get
            {
                return base.method_2<bool>("useNativeKeyboard");
            }
        }

        public enum KeyboardReturnKeyType
        {
            Default,
            Go,
            Google,
            Join,
            Next,
            Route,
            Search,
            Send,
            Yahoo,
            Done,
            EmergencyCall
        }

        public enum KeyboardType
        {
            Default,
            ASCIICapable,
            NumbersAndPunctuation,
            URL,
            NumberPad,
            PhonePad,
            NamePhonePad,
            EmailAddress,
            DecimalPad,
            Twitter
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PluginRect
        {
            public float x;
            public float y;
            public float width;
            public float height;
        }
    }
}

