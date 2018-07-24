namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("GraphicsManager")]
    public class GraphicsManager : MonoBehaviour
    {
        public GraphicsManager(IntPtr address) : this(address, "GraphicsManager")
        {
        }

        public GraphicsManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DeregisterLowQualityDisableObject(GameObject lowQualityObject)
        {
            object[] objArray1 = new object[] { lowQualityObject };
            base.method_8("DeregisterLowQualityDisableObject", objArray1);
        }

        public static IntPtr FindWindow(string className, string windowName)
        {
            object[] objArray1 = new object[] { className, windowName };
            return MonoClass.smethod_14<IntPtr>(TritonHs.MainAssemblyPath, "", "GraphicsManager", "FindWindow", objArray1);
        }

        public static GraphicsManager Get()
        {
            return MonoClass.smethod_15<GraphicsManager>(TritonHs.MainAssemblyPath, "", "GraphicsManager", "Get", Array.Empty<object>());
        }

        public static IntPtr GetActiveWindow()
        {
            return MonoClass.smethod_14<IntPtr>(TritonHs.MainAssemblyPath, "", "GraphicsManager", "GetActiveWindow", Array.Empty<object>());
        }

        public static IntPtr GetForegroundWindow()
        {
            return MonoClass.smethod_14<IntPtr>(TritonHs.MainAssemblyPath, "", "GraphicsManager", "GetForegroundWindow", Array.Empty<object>());
        }

        public GPULimits GetGPULimits()
        {
            return base.method_11<GPULimits>("GetGPULimits", Array.Empty<object>());
        }

        public static List<int> GetWindowPosition()
        {
            Class246<int> class2 = MonoClass.smethod_15<Class246<int>>(TritonHs.MainAssemblyPath, "", "GraphicsManager", "GetWindowPosition", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void InitializeScreen()
        {
            base.method_8("InitializeScreen", Array.Empty<object>());
        }

        public bool isVeryLowQualityDevice()
        {
            return base.method_11<bool>("isVeryLowQualityDevice", Array.Empty<object>());
        }

        public void LogGPULimits()
        {
            base.method_8("LogGPULimits", Array.Empty<object>());
        }

        public void LogSystemInfo()
        {
            base.method_8("LogSystemInfo", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void RegisterLowQualityDisableObject(GameObject lowQualityObject)
        {
            object[] objArray1 = new object[] { lowQualityObject };
            base.method_8("RegisterLowQualityDisableObject", objArray1);
        }

        public void SetQualityByName(string qualityName)
        {
            object[] objArray1 = new object[] { qualityName };
            base.method_8("SetQualityByName", objArray1);
        }

        public void SetScreenEffects()
        {
            base.method_8("SetScreenEffects", Array.Empty<object>());
        }

        public void SetScreenResolution(int width, int height, bool fullscreen)
        {
            object[] objArray1 = new object[] { width, height, fullscreen };
            base.method_8("SetScreenResolution", objArray1);
        }

        public static bool SetWindowPos(IntPtr hwnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags)
        {
            object[] objArray1 = new object[] { hwnd, hWndInsertAfter, x, Y, cx, cy, wFlags };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GraphicsManager", "SetWindowPos", objArray1);
        }

        public static bool SetWindowPosition(int x, int y, int resX, int resY)
        {
            object[] objArray1 = new object[] { x, y, resX, resY };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "GraphicsManager", "SetWindowPosition", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateAntiAliasing()
        {
            base.method_8("UpdateAntiAliasing", Array.Empty<object>());
        }

        public void UpdateQualitySettings()
        {
            base.method_8("UpdateQualitySettings", Array.Empty<object>());
        }

        public void UpdateRenderQualitySettings()
        {
            base.method_8("UpdateRenderQualitySettings", Array.Empty<object>());
        }

        public static int ANDROID_MIN_DPI_HIGH_RES_TEXTURES
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "GraphicsManager", "ANDROID_MIN_DPI_HIGH_RES_TEXTURES");
            }
        }

        public List<GameObject> m_DisableLowQualityObjects
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_DisableLowQualityObjects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GraphicsQuality m_GraphicsQuality
        {
            get
            {
                return base.method_2<GraphicsQuality>("m_GraphicsQuality");
            }
        }

        public int m_lastHeight
        {
            get
            {
                return base.method_2<int>("m_lastHeight");
            }
        }

        public int m_lastWidth
        {
            get
            {
                return base.method_2<int>("m_lastWidth");
            }
        }

        public bool m_RealtimeShadows
        {
            get
            {
                return base.method_2<bool>("m_RealtimeShadows");
            }
        }

        public bool m_VeryLowQuality
        {
            get
            {
                return base.method_2<bool>("m_VeryLowQuality");
            }
        }

        public int m_winPosX
        {
            get
            {
                return base.method_2<int>("m_winPosX");
            }
        }

        public int m_winPosY
        {
            get
            {
                return base.method_2<int>("m_winPosY");
            }
        }

        public bool RealtimeShadows
        {
            get
            {
                return base.method_11<bool>("get_RealtimeShadows", Array.Empty<object>());
            }
        }

        public static int REDUCE_MAX_WINDOW_SIZE_X
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "GraphicsManager", "REDUCE_MAX_WINDOW_SIZE_X");
            }
        }

        public static int REDUCE_MAX_WINDOW_SIZE_Y
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "GraphicsManager", "REDUCE_MAX_WINDOW_SIZE_Y");
            }
        }

        public GraphicsQuality RenderQualityLevel
        {
            get
            {
                return base.method_11<GraphicsQuality>("get_RenderQualityLevel", Array.Empty<object>());
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct GPULimits
        {
            public int highPrecisionBits;
            public int mediumPrecisionBits;
            public int lowPrecisionBits;
            public int maxFragmentTextureUnits;
            public int maxVertexTextureUnits;
            public int maxCombinedTextureUnits;
            public int maxTextureSize;
            public int maxCubeMapSize;
            public int maxRenderBufferSize;
            public int maxFragmentUniforms;
            public int maxVertexUniforms;
            public int maxVaryings;
            public int maxVertexAttribs;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
    }
}

