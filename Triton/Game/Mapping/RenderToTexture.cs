namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("RenderToTexture")]
    public class RenderToTexture : MonoBehaviour
    {
        public RenderToTexture(IntPtr address) : this(address, "RenderToTexture")
        {
        }

        public RenderToTexture(IntPtr address, string className) : base(address, className)
        {
        }

        public void AlphaCameraRender()
        {
            base.method_8("AlphaCameraRender", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public Vector2 CalcTextureSize()
        {
            return base.method_11<Vector2>("CalcTextureSize", Array.Empty<object>());
        }

        public void CalcWorldWidthHeightScale()
        {
            base.method_8("CalcWorldWidthHeightScale", Array.Empty<object>());
        }

        public void CameraRender()
        {
            base.method_8("CameraRender", Array.Empty<object>());
        }

        public void CleanUp()
        {
            base.method_8("CleanUp", Array.Empty<object>());
        }

        public void CreateAlphaCamera()
        {
            base.method_8("CreateAlphaCamera", Array.Empty<object>());
        }

        public void CreateBloomCaptureCamera()
        {
            base.method_8("CreateBloomCaptureCamera", Array.Empty<object>());
        }

        public void CreateBloomCapturePlane()
        {
            base.method_8("CreateBloomCapturePlane", Array.Empty<object>());
        }

        public void CreateBloomPlane()
        {
            base.method_8("CreateBloomPlane", Array.Empty<object>());
        }

        public void CreateCamera()
        {
            base.method_8("CreateCamera", Array.Empty<object>());
        }

        public GameObject CreateMeshPlane(string name, Material material)
        {
            object[] objArray1 = new object[] { name, material };
            return base.method_14<GameObject>("CreateMeshPlane", objArray1);
        }

        public void CreateRenderPlane()
        {
            base.method_8("CreateRenderPlane", Array.Empty<object>());
        }

        public void CreateTexture()
        {
            base.method_8("CreateTexture", Array.Empty<object>());
        }

        public void ForceTextureRebuild()
        {
            base.method_8("ForceTextureRebuild", Array.Empty<object>());
        }

        public Vector3 GetOffscreenPosition()
        {
            return base.method_11<Vector3>("GetOffscreenPosition", Array.Empty<object>());
        }

        public Vector3 GetOffscreenPositionOffset()
        {
            return base.method_11<Vector3>("GetOffscreenPositionOffset", Array.Empty<object>());
        }

        public Material GetRenderMaterial()
        {
            return base.method_14<Material>("GetRenderMaterial", Array.Empty<object>());
        }

        public GameObject GetRenderToObject()
        {
            return base.method_14<GameObject>("GetRenderToObject", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void Init()
        {
            base.method_8("Init", Array.Empty<object>());
        }

        public void LateUpdate()
        {
            base.method_8("LateUpdate", Array.Empty<object>());
        }

        public void OnApplicationFocus(bool state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("OnApplicationFocus", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnDrawGizmos()
        {
            base.method_8("OnDrawGizmos", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public float OrthoSize()
        {
            return base.method_11<float>("OrthoSize", Array.Empty<object>());
        }

        public void PositionHiddenObjectsAndCameras()
        {
            base.method_8("PositionHiddenObjectsAndCameras", Array.Empty<object>());
        }

        public void ReleaseTexture()
        {
            base.method_8("ReleaseTexture", Array.Empty<object>());
        }

        public void RenderBloom()
        {
            base.method_8("RenderBloom", Array.Empty<object>());
        }

        public void RenderTex()
        {
            base.method_8("RenderTex", Array.Empty<object>());
        }

        public void RestoreAfterRender()
        {
            base.method_8("RestoreAfterRender", Array.Empty<object>());
        }

        public void SetDirty()
        {
            base.method_8("SetDirty", Array.Empty<object>());
        }

        public void SetupForRender()
        {
            base.method_8("SetupForRender", Array.Empty<object>());
        }

        public void SetupMaterial()
        {
            base.method_8("SetupMaterial", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_9("Show", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void Show(bool render)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { render };
            base.method_9("Show", enumArray1, objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public static string ADDITIVE_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "RenderToTexture", "ADDITIVE_SHADER_NAME");
            }
        }

        public Material AdditiveMaterial
        {
            get
            {
                return base.method_14<Material>("get_AdditiveMaterial", Array.Empty<object>());
            }
        }

        public static string ALPHA_BLEND_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "RenderToTexture", "ALPHA_BLEND_SHADER_NAME");
            }
        }

        public static string ALPHA_CLIP_BLOOM_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "RenderToTexture", "ALPHA_CLIP_BLOOM_SHADER_NAME");
            }
        }

        public static string ALPHA_CLIP_GRADIENT_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "RenderToTexture", "ALPHA_CLIP_GRADIENT_SHADER_NAME");
            }
        }

        public static string ALPHA_CLIP_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "RenderToTexture", "ALPHA_CLIP_SHADER_NAME");
            }
        }

        public Vector3 ALPHA_OBJECT_OFFSET
        {
            get
            {
                return base.method_2<Vector3>("ALPHA_OBJECT_OFFSET");
            }
        }

        public Material AlphaBlendMaterial
        {
            get
            {
                return base.method_14<Material>("get_AlphaBlendMaterial", Array.Empty<object>());
            }
        }

        public Material AlphaBlurMaterial
        {
            get
            {
                return base.method_14<Material>("get_AlphaBlurMaterial", Array.Empty<object>());
            }
        }

        public Material AlphaClipBloomMaterial
        {
            get
            {
                return base.method_14<Material>("get_AlphaClipBloomMaterial", Array.Empty<object>());
            }
        }

        public Material AlphaClipGradientMaterial
        {
            get
            {
                return base.method_14<Material>("get_AlphaClipGradientMaterial", Array.Empty<object>());
            }
        }

        public Material AlphaClipMaterial
        {
            get
            {
                return base.method_14<Material>("get_AlphaClipMaterial", Array.Empty<object>());
            }
        }

        public static string BLOOM_ALPHA_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "RenderToTexture", "BLOOM_ALPHA_SHADER_NAME");
            }
        }

        public static string BLOOM_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "RenderToTexture", "BLOOM_SHADER_NAME");
            }
        }

        public Material BloomMaterial
        {
            get
            {
                return base.method_14<Material>("get_BloomMaterial", Array.Empty<object>());
            }
        }

        public Material BloomMaterialAlpha
        {
            get
            {
                return base.method_14<Material>("get_BloomMaterialAlpha", Array.Empty<object>());
            }
        }

        public static string BLUR_ALPHA_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "RenderToTexture", "BLUR_ALPHA_SHADER_NAME");
            }
        }

        public static string BLUR_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "RenderToTexture", "BLUR_SHADER_NAME");
            }
        }

        public Material BlurMaterial
        {
            get
            {
                return base.method_14<Material>("get_BlurMaterial", Array.Empty<object>());
            }
        }

        public Material m_AdditiveMaterial
        {
            get
            {
                return base.method_3<Material>("m_AdditiveMaterial");
            }
        }

        public Material m_AlphaBlendMaterial
        {
            get
            {
                return base.method_3<Material>("m_AlphaBlendMaterial");
            }
        }

        public Material m_AlphaBlurMaterial
        {
            get
            {
                return base.method_3<Material>("m_AlphaBlurMaterial");
            }
        }

        public Camera m_AlphaCamera
        {
            get
            {
                return base.method_3<Camera>("m_AlphaCamera");
            }
        }

        public GameObject m_AlphaCameraGO
        {
            get
            {
                return base.method_3<GameObject>("m_AlphaCameraGO");
            }
        }

        public float m_AlphaClip
        {
            get
            {
                return base.method_2<float>("m_AlphaClip");
            }
        }

        public float m_AlphaClipAlphaIntensity
        {
            get
            {
                return base.method_2<float>("m_AlphaClipAlphaIntensity");
            }
        }

        public Material m_AlphaClipBloomMaterial
        {
            get
            {
                return base.method_3<Material>("m_AlphaClipBloomMaterial");
            }
        }

        public Material m_AlphaClipGradientMaterial
        {
            get
            {
                return base.method_3<Material>("m_AlphaClipGradientMaterial");
            }
        }

        public float m_AlphaClipIntensity
        {
            get
            {
                return base.method_2<float>("m_AlphaClipIntensity");
            }
        }

        public Material m_AlphaClipMaterial
        {
            get
            {
                return base.method_3<Material>("m_AlphaClipMaterial");
            }
        }

        public AlphaClipShader m_AlphaClipRenderStyle
        {
            get
            {
                return base.method_2<AlphaClipShader>("m_AlphaClipRenderStyle");
            }
        }

        public GameObject m_AlphaObjectToRender
        {
            get
            {
                return base.method_3<GameObject>("m_AlphaObjectToRender");
            }
        }

        public Vector3 m_AlphaObjectToRenderOffset
        {
            get
            {
                return base.method_2<Vector3>("m_AlphaObjectToRenderOffset");
            }
        }

        public float m_BloomAlphaIntensity
        {
            get
            {
                return base.method_2<float>("m_BloomAlphaIntensity");
            }
        }

        public BloomBlendType m_BloomBlend
        {
            get
            {
                return base.method_2<BloomBlendType>("m_BloomBlend");
            }
        }

        public float m_BloomBlur
        {
            get
            {
                return base.method_2<float>("m_BloomBlur");
            }
        }

        public Camera m_BloomCaptureCamera
        {
            get
            {
                return base.method_3<Camera>("m_BloomCaptureCamera");
            }
        }

        public GameObject m_BloomCaptureCameraGO
        {
            get
            {
                return base.method_3<GameObject>("m_BloomCaptureCameraGO");
            }
        }

        public GameObject m_BloomCapturePlaneGameObject
        {
            get
            {
                return base.method_3<GameObject>("m_BloomCapturePlaneGameObject");
            }
        }

        public Color m_BloomColor
        {
            get
            {
                return base.method_2<Color>("m_BloomColor");
            }
        }

        public float m_BloomIntensity
        {
            get
            {
                return base.method_2<float>("m_BloomIntensity");
            }
        }

        public Material m_BloomMaterial
        {
            get
            {
                return base.method_3<Material>("m_BloomMaterial");
            }
        }

        public Material m_BloomMaterialAlpha
        {
            get
            {
                return base.method_3<Material>("m_BloomMaterialAlpha");
            }
        }

        public GameObject m_BloomPlaneGameObject
        {
            get
            {
                return base.method_3<GameObject>("m_BloomPlaneGameObject");
            }
        }

        public BloomRenderType m_BloomRenderType
        {
            get
            {
                return base.method_2<BloomRenderType>("m_BloomRenderType");
            }
        }

        public float m_BloomResolutionRatio
        {
            get
            {
                return base.method_2<float>("m_BloomResolutionRatio");
            }
        }

        public float m_BloomThreshold
        {
            get
            {
                return base.method_2<float>("m_BloomThreshold");
            }
        }

        public bool m_BlurAlphaOnly
        {
            get
            {
                return base.method_2<bool>("m_BlurAlphaOnly");
            }
        }

        public float m_BlurAmount
        {
            get
            {
                return base.method_2<float>("m_BlurAmount");
            }
        }

        public Material m_BlurMaterial
        {
            get
            {
                return base.method_3<Material>("m_BlurMaterial");
            }
        }

        public Camera m_Camera
        {
            get
            {
                return base.method_3<Camera>("m_Camera");
            }
        }

        public GameObject m_CameraGO
        {
            get
            {
                return base.method_3<GameObject>("m_CameraGO");
            }
        }

        public Color m_ClearColor
        {
            get
            {
                return base.method_2<Color>("m_ClearColor");
            }
        }

        public bool m_CreateRenderPlane
        {
            get
            {
                return base.method_2<bool>("m_CreateRenderPlane");
            }
        }

        public float m_FarClip
        {
            get
            {
                return base.method_2<float>("m_FarClip");
            }
        }

        public float m_Height
        {
            get
            {
                return base.method_2<float>("m_Height");
            }
        }

        public bool m_HideRenderObject
        {
            get
            {
                return base.method_2<bool>("m_HideRenderObject");
            }
        }

        public bool m_init
        {
            get
            {
                return base.method_2<bool>("m_init");
            }
        }

        public bool m_isDirty
        {
            get
            {
                return base.method_2<bool>("m_isDirty");
            }
        }

        public bool m_LateUpdate
        {
            get
            {
                return base.method_2<bool>("m_LateUpdate");
            }
        }

        public LayerMask m_LayerMask
        {
            get
            {
                return base.method_2<LayerMask>("m_LayerMask");
            }
        }

        public Material m_Material
        {
            get
            {
                return base.method_3<Material>("m_Material");
            }
        }

        public float m_NearClip
        {
            get
            {
                return base.method_2<float>("m_NearClip");
            }
        }

        public GameObject m_ObjectToRender
        {
            get
            {
                return base.method_3<GameObject>("m_ObjectToRender");
            }
        }

        public Vector3 m_ObjectToRenderOffset
        {
            get
            {
                return base.method_2<Vector3>("m_ObjectToRenderOffset");
            }
        }

        public Transform m_ObjectToRenderOrgParent
        {
            get
            {
                return base.method_3<Transform>("m_ObjectToRenderOrgParent");
            }
        }

        public Vector3 m_ObjectToRenderOrgPosition
        {
            get
            {
                return base.method_2<Vector3>("m_ObjectToRenderOrgPosition");
            }
        }

        public bool m_ObjectToRenderOrgPositionStored
        {
            get
            {
                return base.method_2<bool>("m_ObjectToRenderOrgPositionStored");
            }
        }

        public GameObject m_OffscreenGameObject
        {
            get
            {
                return base.method_3<GameObject>("m_OffscreenGameObject");
            }
        }

        public Vector3 m_OffscreenPos
        {
            get
            {
                return base.method_2<Vector3>("m_OffscreenPos");
            }
        }

        public float m_Offset
        {
            get
            {
                return base.method_2<float>("m_Offset");
            }
        }

        public Vector3 m_OriginalRenderPosition
        {
            get
            {
                return base.method_2<Vector3>("m_OriginalRenderPosition");
            }
        }

        public GameObject m_PlaneGameObject
        {
            get
            {
                return base.method_3<GameObject>("m_PlaneGameObject");
            }
        }

        public Vector3 m_PositionOffset
        {
            get
            {
                return base.method_2<Vector3>("m_PositionOffset");
            }
        }

        public RenderToTextureMaterial m_PreviousRenderMaterial
        {
            get
            {
                return base.method_2<RenderToTextureMaterial>("m_PreviousRenderMaterial");
            }
        }

        public bool m_RealtimeRender
        {
            get
            {
                return base.method_2<bool>("m_RealtimeRender");
            }
        }

        public bool m_RealtimeTranslation
        {
            get
            {
                return base.method_2<bool>("m_RealtimeTranslation");
            }
        }

        public bool m_renderEnabled
        {
            get
            {
                return base.method_2<bool>("m_renderEnabled");
            }
        }

        public RenderToTextureMaterial m_RenderMaterial
        {
            get
            {
                return base.method_2<RenderToTextureMaterial>("m_RenderMaterial");
            }
        }

        public bool m_RenderMeshAsAlpha
        {
            get
            {
                return base.method_2<bool>("m_RenderMeshAsAlpha");
            }
        }

        public bool m_RenderOnEnable
        {
            get
            {
                return base.method_2<bool>("m_RenderOnEnable");
            }
        }

        public bool m_RenderOnStart
        {
            get
            {
                return base.method_2<bool>("m_RenderOnStart");
            }
        }

        public int m_RenderQueue
        {
            get
            {
                return base.method_2<int>("m_RenderQueue");
            }
        }

        public GameObject m_RenderToObject
        {
            get
            {
                return base.method_3<GameObject>("m_RenderToObject");
            }
        }

        public string m_ReplacmentTag
        {
            get
            {
                return base.method_4("m_ReplacmentTag");
            }
        }

        public int m_Resolution
        {
            get
            {
                return base.method_2<int>("m_Resolution");
            }
        }

        public string m_ShaderTextureName
        {
            get
            {
                return base.method_4("m_ShaderTextureName");
            }
        }

        public Color m_TintColor
        {
            get
            {
                return base.method_2<Color>("m_TintColor");
            }
        }

        public Material m_TransparentMaterial
        {
            get
            {
                return base.method_3<Material>("m_TransparentMaterial");
            }
        }

        public float m_Width
        {
            get
            {
                return base.method_2<float>("m_Width");
            }
        }

        public float m_WorldHeight
        {
            get
            {
                return base.method_2<float>("m_WorldHeight");
            }
        }

        public Vector3 m_WorldScale
        {
            get
            {
                return base.method_2<Vector3>("m_WorldScale");
            }
        }

        public float m_WorldWidth
        {
            get
            {
                return base.method_2<float>("m_WorldWidth");
            }
        }

        public float Offset
        {
            get
            {
                return base.method_11<float>("get_Offset", Array.Empty<object>());
            }
        }

        public static float OFFSET_DISTANCE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "RenderToTexture", "OFFSET_DISTANCE");
            }
        }

        public List<Vector3> PLANE_NORMALS
        {
            get
            {
                Class246<Vector3> class2 = base.method_3<Class246<Vector3>>("PLANE_NORMALS");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<int> PLANE_TRIANGLES
        {
            get
            {
                Class246<int> class2 = base.method_3<Class246<int>>("PLANE_TRIANGLES");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Vector2> PLANE_UVS
        {
            get
            {
                Class246<Vector2> class2 = base.method_3<Class246<Vector2>>("PLANE_UVS");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static float RENDER_SIZE_QUALITY_HIGH
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "RenderToTexture", "RENDER_SIZE_QUALITY_HIGH");
            }
        }

        public static float RENDER_SIZE_QUALITY_LOW
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "RenderToTexture", "RENDER_SIZE_QUALITY_LOW");
            }
        }

        public static float RENDER_SIZE_QUALITY_MEDIUM
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "RenderToTexture", "RENDER_SIZE_QUALITY_MEDIUM");
            }
        }

        public static float s_offset
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "RenderToTexture", "s_offset");
            }
        }

        public static string TRANSPARENT_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "RenderToTexture", "TRANSPARENT_SHADER_NAME");
            }
        }

        public Material TransparentMaterial
        {
            get
            {
                return base.method_14<Material>("get_TransparentMaterial", Array.Empty<object>());
            }
        }

        public static string UNLIT_WHITE_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "RenderToTexture", "UNLIT_WHITE_SHADER_NAME");
            }
        }

        public enum AlphaClipShader
        {
            Standard,
            ColorGradient
        }

        public enum BloomBlendType
        {
            Additive,
            Transparent
        }

        public enum BloomRenderType
        {
            Color,
            Alpha
        }

        public enum RenderToTextureMaterial
        {
            Custom,
            Transparent,
            Additive,
            Bloom,
            AlphaClip,
            AlphaClipBloom
        }
    }
}

