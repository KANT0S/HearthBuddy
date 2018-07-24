namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ProjectedShadow")]
    public class ProjectedShadow : MonoBehaviour
    {
        public ProjectedShadow(IntPtr address) : this(address, "ProjectedShadow")
        {
        }

        public ProjectedShadow(IntPtr address, string className) : base(address, className)
        {
        }

        public void CreateCamera()
        {
            base.method_8("CreateCamera", Array.Empty<object>());
        }

        public void CreateProjector()
        {
            base.method_8("CreateProjector", Array.Empty<object>());
        }

        public void CreateRenderPlane()
        {
            base.method_8("CreateRenderPlane", Array.Empty<object>());
        }

        public void DisableShadow()
        {
            base.method_9("DisableShadow", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void DisableShadow(float FadeOutTime)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.R4 };
            object[] objArray1 = new object[] { FadeOutTime };
            base.method_9("DisableShadow", enumArray1, objArray1);
        }

        public void DisableShadowProjector()
        {
            base.method_8("DisableShadowProjector", Array.Empty<object>());
        }

        public void EnableShadow()
        {
            base.method_9("EnableShadow", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void EnableShadow(float FadeInTime)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.R4 };
            object[] objArray1 = new object[] { FadeInTime };
            base.method_9("EnableShadow", enumArray1, objArray1);
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

        public void Render()
        {
            base.method_8("Render", Array.Empty<object>());
        }

        public void RenderContactShadow()
        {
            base.method_8("RenderContactShadow", Array.Empty<object>());
        }

        public void RenderShadowMask()
        {
            base.method_8("RenderShadowMask", Array.Empty<object>());
        }

        public static void SetShadowColor(Color color)
        {
            object[] objArray1 = new object[] { color };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "SetShadowColor", objArray1);
        }

        public void SetWorldScale(Transform xform, Vector3 scale)
        {
            object[] objArray1 = new object[] { xform, scale };
            base.method_8("SetWorldScale", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateContactShadow()
        {
            base.method_9("UpdateContactShadow", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void UpdateContactShadow(Spell spell)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { spell };
            base.method_9("UpdateContactShadow", enumArray1, objArray1);
        }

        public void UpdateContactShadow(Spell spell, object userData)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { spell, userData };
            base.method_9("UpdateContactShadow", enumArray1, objArray1);
        }

        public void UpdateContactShadow(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_9("UpdateContactShadow", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void UpdateShadowColor(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("UpdateShadowColor", objArray1);
        }

        public static string CONTACT_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "CONTACT_SHADER_NAME");
            }
        }

        public static float CONTACT_SHADOW_FADE_IN_HEIGHT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "CONTACT_SHADOW_FADE_IN_HEIGHT");
            }
        }

        public static float CONTACT_SHADOW_INTENSITY
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "CONTACT_SHADOW_INTENSITY");
            }
        }

        public static int CONTACT_SHADOW_RESOLUTION
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "CONTACT_SHADOW_RESOLUTION");
            }
        }

        public static float CONTACT_SHADOW_SCALE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "CONTACT_SHADOW_SCALE");
            }
        }

        public Material ContactShadowMaterial
        {
            get
            {
                return base.method_14<Material>("get_ContactShadowMaterial", Array.Empty<object>());
            }
        }

        public static string EDGE_FALLOFF_TEXTURE
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "EDGE_FALLOFF_TEXTURE");
            }
        }

        public static string GAMEOBJECT_NAME_EXT
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "GAMEOBJECT_NAME_EXT");
            }
        }

        public float m_AdjustedShadowProjectorSize
        {
            get
            {
                return base.method_2<float>("m_AdjustedShadowProjectorSize");
            }
        }

        public bool m_AutoBoardHeightDisable
        {
            get
            {
                return base.method_2<bool>("m_AutoBoardHeightDisable");
            }
        }

        public float m_AutoDisableHeight
        {
            get
            {
                return base.method_2<float>("m_AutoDisableHeight");
            }
        }

        public float m_BoardHeight
        {
            get
            {
                return base.method_2<float>("m_BoardHeight");
            }
        }

        public Camera m_Camera
        {
            get
            {
                return base.method_3<Camera>("m_Camera");
            }
        }

        public Vector3 m_ContactOffset
        {
            get
            {
                return base.method_2<Vector3>("m_ContactOffset");
            }
        }

        public bool m_ContactShadow
        {
            get
            {
                return base.method_2<bool>("m_ContactShadow");
            }
        }

        public Material m_ContactShadowMaterial
        {
            get
            {
                return base.method_3<Material>("m_ContactShadowMaterial");
            }
        }

        public bool m_ContinuousRendering
        {
            get
            {
                return base.method_2<bool>("m_ContinuousRendering");
            }
        }

        public bool m_isDirtyContactShadow
        {
            get
            {
                return base.method_2<bool>("m_isDirtyContactShadow");
            }
        }

        public Material m_MultiSampleMaterial
        {
            get
            {
                return base.method_3<Material>("m_MultiSampleMaterial");
            }
        }

        public GameObject m_PlaneGameObject
        {
            get
            {
                return base.method_3<GameObject>("m_PlaneGameObject");
            }
        }

        public Mesh m_PlaneMesh
        {
            get
            {
                return base.method_3<Mesh>("m_PlaneMesh");
            }
        }

        public float m_ProjectionFarClip
        {
            get
            {
                return base.method_2<float>("m_ProjectionFarClip");
            }
        }

        public Vector3 m_ProjectionOffset
        {
            get
            {
                return base.method_2<Vector3>("m_ProjectionOffset");
            }
        }

        public GameObject m_ProjectorGameObject
        {
            get
            {
                return base.method_3<GameObject>("m_ProjectorGameObject");
            }
        }

        public Transform m_ProjectorTransform
        {
            get
            {
                return base.method_3<Transform>("m_ProjectorTransform");
            }
        }

        public GameObject m_RootObject
        {
            get
            {
                return base.method_3<GameObject>("m_RootObject");
            }
        }

        public bool m_ShadowEnabled
        {
            get
            {
                return base.method_2<bool>("m_ShadowEnabled");
            }
        }

        public Material m_ShadowMaterial
        {
            get
            {
                return base.method_3<Material>("m_ShadowMaterial");
            }
        }

        public float m_ShadowProjectorSize
        {
            get
            {
                return base.method_2<float>("m_ShadowProjectorSize");
            }
        }

        public static string MULTISAMPLE_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "MULTISAMPLE_SHADER_NAME");
            }
        }

        public Material MultiSampleMaterial
        {
            get
            {
                return base.method_14<Material>("get_MultiSampleMaterial", Array.Empty<object>());
            }
        }

        public static float NEARCLIP_PLANE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "NEARCLIP_PLANE");
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

        public static int RENDER_SIZE
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "RENDER_SIZE");
            }
        }

        public static float RENDERMASK_BLUR
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "RENDERMASK_BLUR");
            }
        }

        public static float RENDERMASK_BLUR2
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "RENDERMASK_BLUR2");
            }
        }

        public static float RENDERMASK_OFFSET
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "RENDERMASK_OFFSET");
            }
        }

        public static float s_offset
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "s_offset");
            }
        }

        public static Color s_ShadowColor
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "s_ShadowColor");
            }
        }

        public static string SHADER_FALLOFF_RAMP
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "SHADER_FALLOFF_RAMP");
            }
        }

        public static string SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "SHADER_NAME");
            }
        }

        public static float SHADOW_OFFSET_SCALE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "SHADOW_OFFSET_SCALE");
            }
        }

        public Material ShadowMaterial
        {
            get
            {
                return base.method_14<Material>("get_ShadowMaterial", Array.Empty<object>());
            }
        }

        public static string UNLIT_DARKGREY_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "UNLIT_DARKGREY_SHADER_NAME");
            }
        }

        public static string UNLIT_LIGHTGREY_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "UNLIT_LIGHTGREY_SHADER_NAME");
            }
        }

        public static string UNLIT_WHITE_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ProjectedShadow", "UNLIT_WHITE_SHADER_NAME");
            }
        }
    }
}

