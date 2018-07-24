namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FullScreenEffects")]
    public class FullScreenEffects : MonoBehaviour
    {
        public FullScreenEffects(IntPtr address) : this(address, "FullScreenEffects")
        {
        }

        public FullScreenEffects(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Disable()
        {
            base.method_8("Disable", Array.Empty<object>());
        }

        public void Freeze()
        {
            base.method_8("Freeze", Array.Empty<object>());
        }

        public bool isActive()
        {
            return base.method_11<bool>("isActive", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnPostRender()
        {
            base.method_8("OnPostRender", Array.Empty<object>());
        }

        public void OnPreRender()
        {
            base.method_8("OnPreRender", Array.Empty<object>());
        }

        public void SetDefaults()
        {
            base.method_8("SetDefaults", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Unfreeze()
        {
            base.method_8("Unfreeze", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateUniversalInputManager()
        {
            base.method_8("UpdateUniversalInputManager", Array.Empty<object>());
        }

        public static string BLEND_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FullScreenEffects", "BLEND_SHADER_NAME");
            }
        }

        public static string BLEND_TO_COLOR_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FullScreenEffects", "BLEND_TO_COLOR_SHADER_NAME");
            }
        }

        public Material blendMaterial
        {
            get
            {
                return base.method_14<Material>("get_blendMaterial", Array.Empty<object>());
            }
        }

        public Color BlendToColor
        {
            get
            {
                return base.method_11<Color>("get_BlendToColor", Array.Empty<object>());
            }
        }

        public float BlendToColorAmount
        {
            get
            {
                return base.method_11<float>("get_BlendToColorAmount", Array.Empty<object>());
            }
        }

        public bool BlendToColorEnable
        {
            get
            {
                return base.method_11<bool>("get_BlendToColorEnable", Array.Empty<object>());
            }
        }

        public Material BlendToColorMaterial
        {
            get
            {
                return base.method_14<Material>("get_BlendToColorMaterial", Array.Empty<object>());
            }
        }

        public static int BLUR_BUFFER_SIZE
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "FullScreenEffects", "BLUR_BUFFER_SIZE");
            }
        }

        public static string BLUR_DESATURATION_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FullScreenEffects", "BLUR_DESATURATION_SHADER_NAME");
            }
        }

        public static string BLUR_DESATURATION_VIGNETTING_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FullScreenEffects", "BLUR_DESATURATION_VIGNETTING_SHADER_NAME");
            }
        }

        public static float BLUR_PASS_1_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "FullScreenEffects", "BLUR_PASS_1_OFFSET");
            }
        }

        public static float BLUR_PASS_2_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "FullScreenEffects", "BLUR_PASS_2_OFFSET");
            }
        }

        public static float BLUR_PASS_3_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "FullScreenEffects", "BLUR_PASS_3_OFFSET");
            }
        }

        public static float BLUR_SECOND_PASS_REDUCTION
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "FullScreenEffects", "BLUR_SECOND_PASS_REDUCTION");
            }
        }

        public static string BLUR_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FullScreenEffects", "BLUR_SHADER_NAME");
            }
        }

        public static string BLUR_VIGNETTING_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FullScreenEffects", "BLUR_VIGNETTING_SHADER_NAME");
            }
        }

        public float BlurAmount
        {
            get
            {
                return base.method_11<float>("get_BlurAmount", Array.Empty<object>());
            }
        }

        public float BlurBlend
        {
            get
            {
                return base.method_11<float>("get_BlurBlend", Array.Empty<object>());
            }
        }

        public float BlurBrightness
        {
            get
            {
                return base.method_11<float>("get_BlurBrightness", Array.Empty<object>());
            }
        }

        public Material blurDesatMaterial
        {
            get
            {
                return base.method_14<Material>("get_blurDesatMaterial", Array.Empty<object>());
            }
        }

        public float BlurDesaturation
        {
            get
            {
                return base.method_11<float>("get_BlurDesaturation", Array.Empty<object>());
            }
        }

        public Material BlurDesaturationVignettingMaterial
        {
            get
            {
                return base.method_14<Material>("get_BlurDesaturationVignettingMaterial", Array.Empty<object>());
            }
        }

        public bool BlurEnabled
        {
            get
            {
                return base.method_11<bool>("get_BlurEnabled", Array.Empty<object>());
            }
        }

        public Material blurMaterial
        {
            get
            {
                return base.method_14<Material>("get_blurMaterial", Array.Empty<object>());
            }
        }

        public Material blurVignettingMaterial
        {
            get
            {
                return base.method_14<Material>("get_blurVignettingMaterial", Array.Empty<object>());
            }
        }

        public float Desaturation
        {
            get
            {
                return base.method_11<float>("get_Desaturation", Array.Empty<object>());
            }
        }

        public static string DESATURATION_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FullScreenEffects", "DESATURATION_SHADER_NAME");
            }
        }

        public static string DESATURATION_VIGNETTING_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FullScreenEffects", "DESATURATION_VIGNETTING_SHADER_NAME");
            }
        }

        public bool DesaturationEnabled
        {
            get
            {
                return base.method_11<bool>("get_DesaturationEnabled", Array.Empty<object>());
            }
        }

        public Material DesaturationMaterial
        {
            get
            {
                return base.method_14<Material>("get_DesaturationMaterial", Array.Empty<object>());
            }
        }

        public Material DesaturationVignettingMaterial
        {
            get
            {
                return base.method_14<Material>("get_DesaturationVignettingMaterial", Array.Empty<object>());
            }
        }

        public Material m_BlendMaterial
        {
            get
            {
                return base.method_3<Material>("m_BlendMaterial");
            }
        }

        public Color m_BlendToColor
        {
            get
            {
                return base.method_2<Color>("m_BlendToColor");
            }
        }

        public float m_BlendToColorAmount
        {
            get
            {
                return base.method_2<float>("m_BlendToColorAmount");
            }
        }

        public bool m_BlendToColorEnable
        {
            get
            {
                return base.method_2<bool>("m_BlendToColorEnable");
            }
        }

        public Material m_BlendToColorMaterial
        {
            get
            {
                return base.method_3<Material>("m_BlendToColorMaterial");
            }
        }

        public float m_BlurAmount
        {
            get
            {
                return base.method_2<float>("m_BlurAmount");
            }
        }

        public float m_BlurBlend
        {
            get
            {
                return base.method_2<float>("m_BlurBlend");
            }
        }

        public float m_BlurBrightness
        {
            get
            {
                return base.method_2<float>("m_BlurBrightness");
            }
        }

        public Material m_BlurDesatMaterial
        {
            get
            {
                return base.method_3<Material>("m_BlurDesatMaterial");
            }
        }

        public float m_BlurDesaturation
        {
            get
            {
                return base.method_2<float>("m_BlurDesaturation");
            }
        }

        public Material m_BlurDesaturationVignettingMaterial
        {
            get
            {
                return base.method_3<Material>("m_BlurDesaturationVignettingMaterial");
            }
        }

        public bool m_BlurEnabled
        {
            get
            {
                return base.method_2<bool>("m_BlurEnabled");
            }
        }

        public Material m_BlurMaterial
        {
            get
            {
                return base.method_3<Material>("m_BlurMaterial");
            }
        }

        public Material m_BlurVignettingMaterial
        {
            get
            {
                return base.method_3<Material>("m_BlurVignettingMaterial");
            }
        }

        public Camera m_Camera
        {
            get
            {
                return base.method_3<Camera>("m_Camera");
            }
        }

        public bool m_CaptureFrozenImage
        {
            get
            {
                return base.method_2<bool>("m_CaptureFrozenImage");
            }
        }

        public int m_DeactivateFrameCount
        {
            get
            {
                return base.method_2<int>("m_DeactivateFrameCount");
            }
        }

        public float m_Desaturation
        {
            get
            {
                return base.method_2<float>("m_Desaturation");
            }
        }

        public bool m_DesaturationEnabled
        {
            get
            {
                return base.method_2<bool>("m_DesaturationEnabled");
            }
        }

        public Material m_DesaturationMaterial
        {
            get
            {
                return base.method_3<Material>("m_DesaturationMaterial");
            }
        }

        public Material m_DesaturationVignettingMaterial
        {
            get
            {
                return base.method_3<Material>("m_DesaturationVignettingMaterial");
            }
        }

        public bool m_FrozenState
        {
            get
            {
                return base.method_2<bool>("m_FrozenState");
            }
        }

        public int m_LowQualityFreezeBufferSize
        {
            get
            {
                return base.method_2<int>("m_LowQualityFreezeBufferSize");
            }
        }

        public float m_PreviousBlurAmount
        {
            get
            {
                return base.method_2<float>("m_PreviousBlurAmount");
            }
        }

        public float m_PreviousBlurBrightness
        {
            get
            {
                return base.method_2<float>("m_PreviousBlurBrightness");
            }
        }

        public float m_PreviousBlurDesaturation
        {
            get
            {
                return base.method_2<float>("m_PreviousBlurDesaturation");
            }
        }

        public UniversalInputManager m_UniversalInputManager
        {
            get
            {
                return base.method_3<UniversalInputManager>("m_UniversalInputManager");
            }
        }

        public bool m_VignettingEnable
        {
            get
            {
                return base.method_2<bool>("m_VignettingEnable");
            }
        }

        public float m_VignettingIntensity
        {
            get
            {
                return base.method_2<float>("m_VignettingIntensity");
            }
        }

        public Material m_VignettingMaterial
        {
            get
            {
                return base.method_3<Material>("m_VignettingMaterial");
            }
        }

        public bool m_WireframeRender
        {
            get
            {
                return base.method_2<bool>("m_WireframeRender");
            }
        }

        public static int NO_WORK_FRAMES_BEFORE_DEACTIVATE
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "FullScreenEffects", "NO_WORK_FRAMES_BEFORE_DEACTIVATE");
            }
        }

        public static string VIGNETTING_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "FullScreenEffects", "VIGNETTING_SHADER_NAME");
            }
        }

        public bool VignettingEnable
        {
            get
            {
                return base.method_11<bool>("get_VignettingEnable", Array.Empty<object>());
            }
        }

        public float VignettingIntensity
        {
            get
            {
                return base.method_11<float>("get_VignettingIntensity", Array.Empty<object>());
            }
        }

        public Material VignettingMaterial
        {
            get
            {
                return base.method_14<Material>("get_VignettingMaterial", Array.Empty<object>());
            }
        }
    }
}

