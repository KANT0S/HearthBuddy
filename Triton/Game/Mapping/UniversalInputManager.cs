namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("UniversalInputManager")]
    public class UniversalInputManager : MonoBehaviour
    {
        public UniversalInputManager(IntPtr address) : this(address, "UniversalInputManager")
        {
        }

        public UniversalInputManager(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddCameraMaskCamera(Camera camera)
        {
            object[] objArray1 = new object[] { camera };
            return base.method_11<bool>("AddCameraMaskCamera", objArray1);
        }

        public bool AddIgnoredCamera(Camera camera)
        {
            object[] objArray1 = new object[] { camera };
            return base.method_11<bool>("AddIgnoredCamera", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CancelTextInput(bool userRequested, GameObject requester)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean, Class272.Enum20.Class };
            object[] objArray1 = new object[] { userRequested, requester };
            base.method_9("CancelTextInput", enumArray1, objArray1);
        }

        public void CancelTextInput(GameObject requester, bool force)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { requester, force };
            base.method_9("CancelTextInput", enumArray1, objArray1);
        }

        public bool CanHitTestOffCamera(GameLayer layer)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { layer };
            return base.method_10<bool>("CanHitTestOffCamera", enumArray1, objArray1);
        }

        public bool CanHitTestOffCamera(LayerMask layerMask)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { layerMask };
            return base.method_10<bool>("CanHitTestOffCamera", enumArray1, objArray1);
        }

        public void CleanDeadCameras()
        {
            base.method_8("CleanDeadCameras", Array.Empty<object>());
        }

        public void ClearTextInputVars()
        {
            base.method_8("ClearTextInputVars", Array.Empty<object>());
        }

        public void CompleteTextInput()
        {
            base.method_8("CompleteTextInput", Array.Empty<object>());
        }

        public int ComputeTextInputFontSize(Vector2 screenSize, float rectHeight)
        {
            object[] objArray1 = new object[] { screenSize, rectHeight };
            return base.method_11<int>("ComputeTextInputFontSize", objArray1);
        }

        public Rect ComputeTextInputRect(Vector2 screenSize)
        {
            object[] objArray1 = new object[] { screenSize };
            return base.method_11<Rect>("ComputeTextInputRect", objArray1);
        }

        public void CreateHitTestPriorityMap()
        {
            base.method_8("CreateHitTestPriorityMap", Array.Empty<object>());
        }

        public void EnableHitTestOffCamera(GameLayer layer, bool enable)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { layer, enable };
            base.method_9("EnableHitTestOffCamera", enumArray1, objArray1);
        }

        public void EnableHitTestOffCamera(LayerMask mask, bool enable)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { mask, enable };
            base.method_9("EnableHitTestOffCamera", enumArray1, objArray1);
        }

        public void FocusTextInput(GameObject owner)
        {
            object[] objArray1 = new object[] { owner };
            base.method_8("FocusTextInput", objArray1);
        }

        public bool ForcedInputIsOver(Camera camera, GameObject gameObj)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { camera, gameObj };
            return base.method_10<bool>("ForcedInputIsOver", enumArray1, objArray1);
        }

        public static UniversalInputManager Get()
        {
            return MonoClass.smethod_15<UniversalInputManager>(TritonHs.MainAssemblyPath, "", "UniversalInputManager", "Get", Array.Empty<object>());
        }

        public LayerMask GetHigherPriorityLayerMask(GameLayer layer)
        {
            object[] objArray1 = new object[] { layer };
            return base.method_11<LayerMask>("GetHigherPriorityLayerMask", objArray1);
        }

        public string GetInputText()
        {
            return base.method_13("GetInputText", Array.Empty<object>());
        }

        public bool GetMouseButton(int button)
        {
            object[] objArray1 = new object[] { button };
            return base.method_11<bool>("GetMouseButton", objArray1);
        }

        public bool GetMouseButtonDown(int button)
        {
            object[] objArray1 = new object[] { button };
            return base.method_11<bool>("GetMouseButtonDown", objArray1);
        }

        public bool GetMouseButtonUp(int button)
        {
            object[] objArray1 = new object[] { button };
            return base.method_11<bool>("GetMouseButtonUp", objArray1);
        }

        public Vector3 GetMousePosition()
        {
            return base.method_11<Vector3>("GetMousePosition", Array.Empty<object>());
        }

        public Camera GuessBestHitTestCamera(LayerMask mask)
        {
            object[] objArray1 = new object[] { mask };
            return base.method_14<Camera>("GuessBestHitTestCamera", objArray1);
        }

        public void HandleGUIInputActive()
        {
            base.method_8("HandleGUIInputActive", Array.Empty<object>());
        }

        public void HandleGUIInputInactive()
        {
            base.method_8("HandleGUIInputInactive", Array.Empty<object>());
        }

        public bool HigherPriorityCollisionExists(GameLayer layer)
        {
            object[] objArray1 = new object[] { layer };
            return base.method_11<bool>("HigherPriorityCollisionExists", objArray1);
        }

        public bool IgnoreGUIInput()
        {
            return base.method_11<bool>("IgnoreGUIInput", Array.Empty<object>());
        }

        public bool InputHitAnyObject(Camera requestedCamera)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { requestedCamera };
            return base.method_10<bool>("InputHitAnyObject", enumArray1, objArray1);
        }

        public bool InputHitAnyObject(GameLayer layer)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { layer };
            return base.method_10<bool>("InputHitAnyObject", enumArray1, objArray1);
        }

        public bool InputHitAnyObject(LayerMask layerMask)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { layerMask };
            return base.method_10<bool>("InputHitAnyObject", enumArray1, objArray1);
        }

        public bool InputHitAnyObject(Camera requestedCamera, GameLayer layer)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { requestedCamera, layer };
            return base.method_10<bool>("InputHitAnyObject", enumArray1, objArray1);
        }

        public bool InputHitAnyObject(Camera requestedCamera, LayerMask mask)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { requestedCamera, mask };
            return base.method_10<bool>("InputHitAnyObject", enumArray1, objArray1);
        }

        public bool InputIsOver(GameObject gameObj)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { gameObj };
            return base.method_10<bool>("InputIsOver", enumArray1, objArray1);
        }

        public bool InputIsOver(Camera camera, GameObject gameObj)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { camera, gameObj };
            return base.method_10<bool>("InputIsOver", enumArray1, objArray1);
        }

        public bool IsMouseOnScreen()
        {
            return base.method_11<bool>("IsMouseOnScreen", Array.Empty<object>());
        }

        public bool IsTextInputActive()
        {
            return base.method_11<bool>("IsTextInputActive", Array.Empty<object>());
        }

        public bool IsTextInputPassword()
        {
            return base.method_11<bool>("IsTextInputPassword", Array.Empty<object>());
        }

        public bool IsTouchMode()
        {
            return base.method_11<bool>("IsTouchMode", Array.Empty<object>());
        }

        public void ObjectCancelTextInput(GameObject requester)
        {
            object[] objArray1 = new object[] { requester };
            base.method_8("ObjectCancelTextInput", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnGUI()
        {
            base.method_8("OnGUI", Array.Empty<object>());
        }

        public bool PreprocessGUITextInput()
        {
            return base.method_11<bool>("PreprocessGUITextInput", Array.Empty<object>());
        }

        public bool ProcessTextInputFinishKeys()
        {
            return base.method_11<bool>("ProcessTextInputFinishKeys", Array.Empty<object>());
        }

        public bool RemoveCameraMaskCamera(Camera camera)
        {
            object[] objArray1 = new object[] { camera };
            return base.method_11<bool>("RemoveCameraMaskCamera", objArray1);
        }

        public bool RemoveIgnoredCamera(Camera camera)
        {
            object[] objArray1 = new object[] { camera };
            return base.method_11<bool>("RemoveIgnoredCamera", objArray1);
        }

        public void SetFullScreenEffectsCamera(Camera camera, bool active)
        {
            object[] objArray1 = new object[] { camera, active };
            base.method_8("SetFullScreenEffectsCamera", objArray1);
        }

        public void SetGameDialogActive(bool active)
        {
            object[] objArray1 = new object[] { active };
            base.method_8("SetGameDialogActive", objArray1);
        }

        public void SetGUISkin(GUISkinContainer skinContainer)
        {
            object[] objArray1 = new object[] { skinContainer };
            base.method_8("SetGUISkin", objArray1);
        }

        public void SetInputText(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("SetInputText", objArray1);
        }

        public void SetSystemDialogActive(bool active)
        {
            object[] objArray1 = new object[] { active };
            base.method_8("SetSystemDialogActive", objArray1);
        }

        public void SetupTextInput(Vector2 screenSize, Rect inputScreenRect)
        {
            object[] objArray1 = new object[] { screenSize, inputScreenRect };
            base.method_8("SetupTextInput", objArray1);
        }

        public string ShowTextInput(Rect inputScreenRect)
        {
            object[] objArray1 = new object[] { inputScreenRect };
            return base.method_13("ShowTextInput", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateInput()
        {
            base.method_8("UpdateInput", Array.Empty<object>());
        }

        public void UpdateMouseOnOrOffScreen()
        {
            base.method_8("UpdateMouseOnOrOffScreen", Array.Empty<object>());
        }

        public void UpdateTabKeyDown()
        {
            base.method_8("UpdateTabKeyDown", Array.Empty<object>());
        }

        public bool UpdateTextInput()
        {
            return base.method_11<bool>("UpdateTextInput", Array.Empty<object>());
        }

        public void UpdateTextInputFocus()
        {
            base.method_8("UpdateTextInputFocus", Array.Empty<object>());
        }

        public void UpdateTextInputRect(GameObject owner, Rect rect)
        {
            object[] objArray1 = new object[] { owner, rect };
            base.method_8("UpdateTextInputRect", objArray1);
        }

        public void UserCancelTextInput()
        {
            base.method_8("UserCancelTextInput", Array.Empty<object>());
        }

        public void UseTextInput(TextInputParams parms, bool force)
        {
            object[] objArray1 = new object[] { parms, force };
            base.method_8("UseTextInput", objArray1);
        }

        public bool WasTouchCanceled()
        {
            return base.method_11<bool>("WasTouchCanceled", Array.Empty<object>());
        }

        public static List<GameLayer> HIT_TEST_PRIORITY_ORDER
        {
            get
            {
                Class246<GameLayer> class2 = MonoClass.smethod_7<Class246<GameLayer>>(TritonHs.MainAssemblyPath, "", "UniversalInputManager", "HIT_TEST_PRIORITY_ORDER");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static bool IsIMEEverUsed
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "UniversalInputManager", "IsIMEEverUsed");
            }
        }

        public List<Camera> m_CameraMaskCameras
        {
            get
            {
                Class267<Camera> class2 = base.method_3<Class267<Camera>>("m_CameraMaskCameras");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public TextAnchor m_defaultInputAlignment
        {
            get
            {
                return base.method_2<TextAnchor>("m_defaultInputAlignment");
            }
        }

        public Camera m_FullscreenEffectsCamera
        {
            get
            {
                return base.method_3<Camera>("m_FullscreenEffectsCamera");
            }
        }

        public bool m_FullscreenEffectsCameraActive
        {
            get
            {
                return base.method_2<bool>("m_FullscreenEffectsCameraActive");
            }
        }

        public bool m_gameDialogActive
        {
            get
            {
                return base.method_2<bool>("m_gameDialogActive");
            }
        }

        public bool m_hideVirtualKeyboardOnComplete
        {
            get
            {
                return base.method_2<bool>("m_hideVirtualKeyboardOnComplete");
            }
        }

        public List<Camera> m_ignoredCameras
        {
            get
            {
                Class267<Camera> class2 = base.method_3<Class267<Camera>>("m_ignoredCameras");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_inputActive
        {
            get
            {
                return base.method_2<bool>("m_inputActive");
            }
        }

        public TextAnchor m_inputAlignment
        {
            get
            {
                return base.method_2<TextAnchor>("m_inputAlignment");
            }
        }

        public bool m_inputFocused
        {
            get
            {
                return base.method_2<bool>("m_inputFocused");
            }
        }

        public TextInputIgnoreState m_inputIgnoreState
        {
            get
            {
                return base.method_2<TextInputIgnoreState>("m_inputIgnoreState");
            }
        }

        public Vector2 m_inputInitialScreenSize
        {
            get
            {
                return base.method_2<Vector2>("m_inputInitialScreenSize");
            }
        }

        public bool m_inputKeepFocusOnComplete
        {
            get
            {
                return base.method_2<bool>("m_inputKeepFocusOnComplete");
            }
        }

        public int m_inputMaxCharacters
        {
            get
            {
                return base.method_2<int>("m_inputMaxCharacters");
            }
        }

        public bool m_inputMultiLine
        {
            get
            {
                return base.method_2<bool>("m_inputMultiLine");
            }
        }

        public bool m_inputNeedsFocus
        {
            get
            {
                return base.method_2<bool>("m_inputNeedsFocus");
            }
        }

        public bool m_inputNeedsFocusFromTabKeyDown
        {
            get
            {
                return base.method_2<bool>("m_inputNeedsFocusFromTabKeyDown");
            }
        }

        public Rect m_inputNormalizedRect
        {
            get
            {
                return base.method_2<Rect>("m_inputNormalizedRect");
            }
        }

        public bool m_inputNumber
        {
            get
            {
                return base.method_2<bool>("m_inputNumber");
            }
        }

        public GameObject m_inputOwner
        {
            get
            {
                return base.method_3<GameObject>("m_inputOwner");
            }
        }

        public bool m_inputPassword
        {
            get
            {
                return base.method_2<bool>("m_inputPassword");
            }
        }

        public string m_inputText
        {
            get
            {
                return base.method_4("m_inputText");
            }
        }

        public bool m_mouseOnScreen
        {
            get
            {
                return base.method_2<bool>("m_mouseOnScreen");
            }
        }

        public int m_offCameraHitTestMask
        {
            get
            {
                return base.method_2<int>("m_offCameraHitTestMask");
            }
        }

        public GUISkinContainer m_skinContainer
        {
            get
            {
                return base.method_3<GUISkinContainer>("m_skinContainer");
            }
        }

        public bool m_systemDialogActive
        {
            get
            {
                return base.method_2<bool>("m_systemDialogActive");
            }
        }

        public bool m_tabKeyDown
        {
            get
            {
                return base.method_2<bool>("m_tabKeyDown");
            }
        }

        public static int TEXT_INPUT_FONT_SIZE_INSET
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "UniversalInputManager", "TEXT_INPUT_FONT_SIZE_INSET");
            }
        }

        public static int TEXT_INPUT_IME_FONT_SIZE_INSET
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "UniversalInputManager", "TEXT_INPUT_IME_FONT_SIZE_INSET");
            }
        }

        public static int TEXT_INPUT_MAX_FONT_SIZE
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "UniversalInputManager", "TEXT_INPUT_MAX_FONT_SIZE");
            }
        }

        public static int TEXT_INPUT_MIN_FONT_SIZE
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "UniversalInputManager", "TEXT_INPUT_MIN_FONT_SIZE");
            }
        }

        public static string TEXT_INPUT_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "UniversalInputManager", "TEXT_INPUT_NAME");
            }
        }

        public static float TEXT_INPUT_RECT_HEIGHT_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "UniversalInputManager", "TEXT_INPUT_RECT_HEIGHT_OFFSET");
            }
        }

        public enum TextInputIgnoreState
        {
            INVALID,
            COMPLETE_KEY_UP,
            CANCEL_KEY_UP,
            NEXT_CALL
        }

        [Attribute38("UniversalInputManager.TextInputParams")]
        public class TextInputParams : MonoClass
        {
            public TextInputParams(IntPtr address) : this(address, "TextInputParams")
            {
            }

            public TextInputParams(IntPtr address, string className) : base(address, className)
            {
            }

            public bool m_hideVirtualKeyboardOnComplete
            {
                get
                {
                    return base.method_2<bool>("m_hideVirtualKeyboardOnComplete");
                }
            }

            public bool m_inputKeepFocusOnComplete
            {
                get
                {
                    return base.method_2<bool>("m_inputKeepFocusOnComplete");
                }
            }

            public int m_maxCharacters
            {
                get
                {
                    return base.method_2<int>("m_maxCharacters");
                }
            }

            public bool m_multiLine
            {
                get
                {
                    return base.method_2<bool>("m_multiLine");
                }
            }

            public bool m_number
            {
                get
                {
                    return base.method_2<bool>("m_number");
                }
            }

            public GameObject m_owner
            {
                get
                {
                    return base.method_3<GameObject>("m_owner");
                }
            }

            public bool m_password
            {
                get
                {
                    return base.method_2<bool>("m_password");
                }
            }

            public Rect m_rect
            {
                get
                {
                    return base.method_2<Rect>("m_rect");
                }
            }

            public bool m_showVirtualKeyboard
            {
                get
                {
                    return base.method_2<bool>("m_showVirtualKeyboard");
                }
            }

            public string m_text
            {
                get
                {
                    return base.method_4("m_text");
                }
            }

            public bool m_touchScreenKeyboardHideInput
            {
                get
                {
                    return base.method_2<bool>("m_touchScreenKeyboardHideInput");
                }
            }

            public int m_touchScreenKeyboardType
            {
                get
                {
                    return base.method_2<int>("m_touchScreenKeyboardType");
                }
            }

            public bool m_useNativeKeyboard
            {
                get
                {
                    return base.method_2<bool>("m_useNativeKeyboard");
                }
            }
        }
    }
}

