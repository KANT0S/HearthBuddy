namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("W8Touch")]
    public class W8Touch : MonoBehaviour
    {
        public W8Touch(IntPtr address) : this(address, "W8Touch")
        {
        }

        public W8Touch(IntPtr address, string className) : base(address, className)
        {
        }

        public static void AppQuit()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "W8Touch", "AppQuit");
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Destroy()
        {
            base.method_8("Destroy", Array.Empty<object>());
        }

        public static IntPtr FindWindow(string className, string windowName)
        {
            object[] objArray1 = new object[] { className, windowName };
            return MonoClass.smethod_14<IntPtr>(TritonHs.MainAssemblyPath, "", "W8Touch", "FindWindow", objArray1);
        }

        public static W8Touch Get()
        {
            return MonoClass.smethod_15<W8Touch>(TritonHs.MainAssemblyPath, "", "W8Touch", "Get", Array.Empty<object>());
        }

        public PowerSource GetBatteryMode()
        {
            return base.method_11<PowerSource>("GetBatteryMode", Array.Empty<object>());
        }

        public IntPtr GetFunction(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_11<IntPtr>("GetFunction", objArray1);
        }

        public string GetIntelDeviceName()
        {
            return base.method_13("GetIntelDeviceName", Array.Empty<object>());
        }

        public int GetPercentBatteryLife()
        {
            return base.method_11<int>("GetPercentBatteryLife", Array.Empty<object>());
        }

        public bool GetTouch(int touchCount)
        {
            object[] objArray1 = new object[] { touchCount };
            return base.method_11<bool>("GetTouch", objArray1);
        }

        public Vector2 GetTouchDelta()
        {
            return base.method_11<Vector2>("GetTouchDelta", Array.Empty<object>());
        }

        public bool GetTouchDown(int touchCount)
        {
            object[] objArray1 = new object[] { touchCount };
            return base.method_11<bool>("GetTouchDown", objArray1);
        }

        public Vector3 GetTouchPosition()
        {
            return base.method_11<Vector3>("GetTouchPosition", Array.Empty<object>());
        }

        public Vector3 GetTouchPositionForGUI()
        {
            return base.method_11<Vector3>("GetTouchPositionForGUI", Array.Empty<object>());
        }

        public bool GetTouchUp(int touchCount)
        {
            object[] objArray1 = new object[] { touchCount };
            return base.method_11<bool>("GetTouchUp", objArray1);
        }

        public void HideKeyboard()
        {
            base.method_8("HideKeyboard", Array.Empty<object>());
        }

        public void InitializeDLL()
        {
            base.method_8("InitializeDLL", Array.Empty<object>());
        }

        public static bool IsInitialized()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "W8Touch", "IsInitialized", Array.Empty<object>());
        }

        public bool IsVirtualKeyboardVisible()
        {
            return base.method_11<bool>("IsVirtualKeyboardVisible", Array.Empty<object>());
        }

        public bool LoadW8TouchDLL()
        {
            return base.method_11<bool>("LoadW8TouchDLL", Array.Empty<object>());
        }

        public void OnGUI()
        {
            base.method_8("OnGUI", Array.Empty<object>());
        }

        public void ResetWindowFeedbackSetting()
        {
            base.method_8("ResetWindowFeedbackSetting", Array.Empty<object>());
        }

        public void ShowKeyboard()
        {
            base.method_8("ShowKeyboard", Array.Empty<object>());
        }

        public void ShowOSK()
        {
            base.method_8("ShowOSK", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void ToggleTouchMode()
        {
            base.method_8("ToggleTouchMode", Array.Empty<object>());
        }

        public Vector2 TransformTouchPosition(Vector2 touchInput)
        {
            object[] objArray1 = new object[] { touchInput };
            return base.method_11<Vector2>("TransformTouchPosition", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public bool m_bIsWindowFeedbackDisabled
        {
            get
            {
                return base.method_2<bool>("m_bIsWindowFeedbackDisabled");
            }
        }

        public bool m_bWindowFeedbackSettingValue
        {
            get
            {
                return base.method_2<bool>("m_bWindowFeedbackSettingValue");
            }
        }

        public RECT m_desktopRect
        {
            get
            {
                return base.method_2<RECT>("m_desktopRect");
            }
        }

        public int m_intializationAttemptCount
        {
            get
            {
                return base.method_2<int>("m_intializationAttemptCount");
            }
        }

        public bool m_isVirtualKeyboardHideRequested
        {
            get
            {
                return base.method_2<bool>("m_isVirtualKeyboardHideRequested");
            }
        }

        public bool m_isVirtualKeyboardShowRequested
        {
            get
            {
                return base.method_2<bool>("m_isVirtualKeyboardShowRequested");
            }
        }

        public bool m_isVirtualKeyboardVisible
        {
            get
            {
                return base.method_2<bool>("m_isVirtualKeyboardVisible");
            }
        }

        public PowerSource m_lastPowerSourceState
        {
            get
            {
                return base.method_2<PowerSource>("m_lastPowerSourceState");
            }
        }

        public Vector2 m_touchDelta
        {
            get
            {
                return base.method_2<Vector2>("m_touchDelta");
            }
        }

        public Vector3 m_touchPosition
        {
            get
            {
                return base.method_2<Vector3>("m_touchPosition");
            }
        }

        public List<TouchState> m_touchState
        {
            get
            {
                Class246<TouchState> class2 = base.method_3<Class246<TouchState>>("m_touchState");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static int MaxInitializationAttempts
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "W8Touch", "MaxInitializationAttempts");
            }
        }

        public static int MaxTouches
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "W8Touch", "MaxTouches");
            }
        }

        public static IntPtr s_DLL
        {
            get
            {
                return MonoClass.smethod_6<IntPtr>(TritonHs.MainAssemblyPath, "", "W8Touch", "s_DLL");
            }
        }

        public static bool s_initialized
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "W8Touch", "s_initialized");
            }
        }

        public static bool s_isWindows8OrGreater
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "W8Touch", "s_isWindows8OrGreater");
            }
        }

        public enum FEEDBACK_TYPE
        {
            FEEDBACK_GESTURE_PRESSANDTAP = 11,
            FEEDBACK_PEN_BARRELVISUALIZATION = 2,
            FEEDBACK_PEN_DOUBLETAP = 4,
            FEEDBACK_PEN_PRESSANDHOLD = 5,
            FEEDBACK_PEN_RIGHTTAP = 6,
            FEEDBACK_PEN_TAP = 3,
            FEEDBACK_TOUCH_CONTACTVISUALIZATION = 1,
            FEEDBACK_TOUCH_DOUBLETAP = 8,
            FEEDBACK_TOUCH_PRESSANDHOLD = 9,
            FEEDBACK_TOUCH_RIGHTTAP = 10,
            FEEDBACK_TOUCH_TAP = 7
        }

        [Attribute38("W8Touch.IntelDevice")]
        public class IntelDevice : MonoClass
        {
            public IntelDevice(IntPtr address) : this(address, "IntelDevice")
            {
            }

            public IntelDevice(IntPtr address, string className) : base(address, className)
            {
            }

            public static string GetDeviceName(int deviceId)
            {
                object[] objArray1 = new object[] { deviceId };
                return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "IntelDevice", "GetDeviceName", objArray1);
            }
        }

        public enum KeyboardFlags
        {
            ErrorOSK = 0x20,
            ErrorTabTip = 0x10,
            NotFoundOSK = 0x80,
            NotFoundTabTip = 0x40,
            NotShown = 2,
            Shown = 1,
            SuccessOSK = 8,
            SuccessTabTip = 4
        }

        public enum PowerSource
        {
            ACPower = 1,
            BatteryPower = 0,
            UndefinedPower = 0xff,
            Unintialized = -1
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public enum TouchState
        {
            None,
            InitialDown,
            Down,
            InitialUp
        }

        [Attribute38("W8Touch.tTouchData")]
        public class tTouchData : MonoClass
        {
            public tTouchData(IntPtr address) : this(address, "tTouchData")
            {
            }

            public tTouchData(IntPtr address, string className) : base(address, className)
            {
            }

            public int m_ID
            {
                get
                {
                    return base.method_2<int>("m_ID");
                }
            }

            public int m_Time
            {
                get
                {
                    return base.method_2<int>("m_Time");
                }
            }

            public int m_x
            {
                get
                {
                    return base.method_2<int>("m_x");
                }
            }

            public int m_y
            {
                get
                {
                    return base.method_2<int>("m_y");
                }
            }
        }
    }
}

