namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("HighlightRender")]
    public class HighlightRender : MonoBehaviour
    {
        public HighlightRender(IntPtr address) : this(address, "HighlightRender")
        {
        }

        public HighlightRender(IntPtr address, string className) : base(address, className)
        {
        }

        public void CreateCamera(Transform renderPlane)
        {
            object[] objArray1 = new object[] { renderPlane };
            base.method_8("CreateCamera", objArray1);
        }

        public void CreateSilhouetteTexture()
        {
            base.method_9("CreateSilhouetteTexture", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void CreateSilhouetteTexture(bool force)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { force };
            base.method_9("CreateSilhouetteTexture", enumArray1, objArray1);
        }

        public void ExportSilhouetteTexture()
        {
            base.method_8("ExportSilhouetteTexture", Array.Empty<object>());
        }

        public List<GameObject> GetExcludedObjects()
        {
            Class267<GameObject> class2 = base.method_14<Class267<GameObject>>("GetExcludedObjects", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static Vector3 GetWorldScale(Transform transform)
        {
            object[] objArray1 = new object[] { transform };
            return MonoClass.smethod_14<Vector3>(TritonHs.MainAssemblyPath, "", "HighlightRender", "GetWorldScale", objArray1);
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public bool isHighlighExclude(Transform objXform)
        {
            object[] objArray1 = new object[] { objXform };
            return base.method_11<bool>("isHighlighExclude", objArray1);
        }

        public bool isTextureCreated()
        {
            return base.method_11<bool>("isTextureCreated", Array.Empty<object>());
        }

        public void OnApplicationFocus(bool state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("OnApplicationFocus", objArray1);
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void RestoreRenderObjects()
        {
            base.method_8("RestoreRenderObjects", Array.Empty<object>());
        }

        public void SetupRenderObjects()
        {
            base.method_8("SetupRenderObjects", Array.Empty<object>());
        }

        public void SetWorldScale(Transform xform, Vector3 scale)
        {
            object[] objArray1 = new object[] { xform, scale };
            base.method_8("SetWorldScale", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public bool VisibilityStatesChanged()
        {
            return base.method_11<bool>("VisibilityStatesChanged", Array.Empty<object>());
        }

        public string BLEND_SHADER_NAME
        {
            get
            {
                return base.method_4("BLEND_SHADER_NAME");
            }
        }

        public Material BlendMaterial
        {
            get
            {
                return base.method_14<Material>("get_BlendMaterial", Array.Empty<object>());
            }
        }

        public static float BLUR_BLEND1
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HighlightRender", "BLUR_BLEND1");
            }
        }

        public static float BLUR_BLEND2
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HighlightRender", "BLUR_BLEND2");
            }
        }

        public static float BLUR_BLEND3
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HighlightRender", "BLUR_BLEND3");
            }
        }

        public static float BLUR_BLEND4
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HighlightRender", "BLUR_BLEND4");
            }
        }

        public string HIGHLIGHT_SHADER_NAME
        {
            get
            {
                return base.method_4("HIGHLIGHT_SHADER_NAME");
            }
        }

        public Material HighlightMaterial
        {
            get
            {
                return base.method_14<Material>("get_HighlightMaterial", Array.Empty<object>());
            }
        }

        public Material m_BlendMaterial
        {
            get
            {
                return base.method_3<Material>("m_BlendMaterial");
            }
        }

        public Camera m_Camera
        {
            get
            {
                return base.method_3<Camera>("m_Camera");
            }
        }

        public float m_CameraOrthoSize
        {
            get
            {
                return base.method_2<float>("m_CameraOrthoSize");
            }
        }

        public bool m_Initialized
        {
            get
            {
                return base.method_2<bool>("m_Initialized");
            }
        }

        public Material m_Material
        {
            get
            {
                return base.method_3<Material>("m_Material");
            }
        }

        public Material m_MultiSampleBlendMaterial
        {
            get
            {
                return base.method_3<Material>("m_MultiSampleBlendMaterial");
            }
        }

        public Material m_MultiSampleMaterial
        {
            get
            {
                return base.method_3<Material>("m_MultiSampleMaterial");
            }
        }

        public Vector3 m_OrgPosition
        {
            get
            {
                return base.method_2<Vector3>("m_OrgPosition");
            }
        }

        public Quaternion m_OrgRotation
        {
            get
            {
                return base.method_2<Quaternion>("m_OrgRotation");
            }
        }

        public Vector3 m_OrgScale
        {
            get
            {
                return base.method_2<Vector3>("m_OrgScale");
            }
        }

        public GameObject m_RenderPlane
        {
            get
            {
                return base.method_3<GameObject>("m_RenderPlane");
            }
        }

        public float m_RenderScale
        {
            get
            {
                return base.method_2<float>("m_RenderScale");
            }
        }

        public int m_RenderSizeX
        {
            get
            {
                return base.method_2<int>("m_RenderSizeX");
            }
        }

        public int m_RenderSizeY
        {
            get
            {
                return base.method_2<int>("m_RenderSizeY");
            }
        }

        public Transform m_RootTransform
        {
            get
            {
                return base.method_3<Transform>("m_RootTransform");
            }
        }

        public float m_SilouetteClipSize
        {
            get
            {
                return base.method_2<float>("m_SilouetteClipSize");
            }
        }

        public float m_SilouetteRenderSize
        {
            get
            {
                return base.method_2<float>("m_SilouetteRenderSize");
            }
        }

        public static int MAX_HIGHLIGHT_EXCLUDE_PARENT_SEARCH
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "HighlightRender", "MAX_HIGHLIGHT_EXCLUDE_PARENT_SEARCH");
            }
        }

        public string MULTISAMPLE_BLEND_SHADER_NAME
        {
            get
            {
                return base.method_4("MULTISAMPLE_BLEND_SHADER_NAME");
            }
        }

        public string MULTISAMPLE_SHADER_NAME
        {
            get
            {
                return base.method_4("MULTISAMPLE_SHADER_NAME");
            }
        }

        public Material MultiSampleBlendMaterial
        {
            get
            {
                return base.method_14<Material>("get_MultiSampleBlendMaterial", Array.Empty<object>());
            }
        }

        public Material MultiSampleMaterial
        {
            get
            {
                return base.method_14<Material>("get_MultiSampleMaterial", Array.Empty<object>());
            }
        }

        public static float ORTHO_SIZE1
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HighlightRender", "ORTHO_SIZE1");
            }
        }

        public static float ORTHO_SIZE2
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HighlightRender", "ORTHO_SIZE2");
            }
        }

        public static float ORTHO_SIZE3
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HighlightRender", "ORTHO_SIZE3");
            }
        }

        public static float ORTHO_SIZE4
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HighlightRender", "ORTHO_SIZE4");
            }
        }

        public static float RENDER_SIZE1
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HighlightRender", "RENDER_SIZE1");
            }
        }

        public static float RENDER_SIZE2
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HighlightRender", "RENDER_SIZE2");
            }
        }

        public static float RENDER_SIZE3
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HighlightRender", "RENDER_SIZE3");
            }
        }

        public static float RENDER_SIZE4
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HighlightRender", "RENDER_SIZE4");
            }
        }

        public static float s_offset
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "HighlightRender", "s_offset");
            }
        }

        public static int SILHOUETTE_RENDER_DEPTH
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "HighlightRender", "SILHOUETTE_RENDER_DEPTH");
            }
        }

        public static int SILHOUETTE_RENDER_SIZE
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "HighlightRender", "SILHOUETTE_RENDER_SIZE");
            }
        }

        public string UNLIT_BLACK_SHADER_NAME
        {
            get
            {
                return base.method_4("UNLIT_BLACK_SHADER_NAME");
            }
        }

        public string UNLIT_COLOR_SHADER_NAME
        {
            get
            {
                return base.method_4("UNLIT_COLOR_SHADER_NAME");
            }
        }

        public string UNLIT_DARKGREY_SHADER_NAME
        {
            get
            {
                return base.method_4("UNLIT_DARKGREY_SHADER_NAME");
            }
        }

        public string UNLIT_GREY_SHADER_NAME
        {
            get
            {
                return base.method_4("UNLIT_GREY_SHADER_NAME");
            }
        }

        public string UNLIT_LIGHTGREY_SHADER_NAME
        {
            get
            {
                return base.method_4("UNLIT_LIGHTGREY_SHADER_NAME");
            }
        }

        public string UNLIT_WHITE_SHADER_NAME
        {
            get
            {
                return base.method_4("UNLIT_WHITE_SHADER_NAME");
            }
        }
    }
}

