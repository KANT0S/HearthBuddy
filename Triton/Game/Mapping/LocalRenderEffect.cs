namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("LocalRenderEffect")]
    public class LocalRenderEffect : MonoBehaviour
    {
        public LocalRenderEffect(IntPtr address) : this(address, "LocalRenderEffect")
        {
        }

        public LocalRenderEffect(IntPtr address, string className) : base(address, className)
        {
        }

        public Vector2 CalcTextureSize()
        {
            return base.method_11<Vector2>("CalcTextureSize", Array.Empty<object>());
        }

        public void CreateCamera()
        {
            base.method_8("CreateCamera", Array.Empty<object>());
        }

        public void CreateRenderPlane()
        {
            base.method_8("CreateRenderPlane", Array.Empty<object>());
        }

        public void CreateTexture()
        {
            base.method_8("CreateTexture", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDrawGizmos()
        {
            base.method_8("OnDrawGizmos", Array.Empty<object>());
        }

        public void Render()
        {
            base.method_8("Render", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public string ADDITIVE_SHADER_NAME
        {
            get
            {
                return base.method_4("ADDITIVE_SHADER_NAME");
            }
        }

        public Material AdditiveMaterial
        {
            get
            {
                return base.method_14<Material>("get_AdditiveMaterial", Array.Empty<object>());
            }
        }

        public string BLOOM_SHADER_NAME
        {
            get
            {
                return base.method_4("BLOOM_SHADER_NAME");
            }
        }

        public Material BloomMaterial
        {
            get
            {
                return base.method_14<Material>("get_BloomMaterial", Array.Empty<object>());
            }
        }

        public string BLUR_SHADER_NAME
        {
            get
            {
                return base.method_4("BLUR_SHADER_NAME");
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

        public Material m_BloomMaterial
        {
            get
            {
                return base.method_3<Material>("m_BloomMaterial");
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

        public Color m_Color
        {
            get
            {
                return base.method_2<Color>("m_Color");
            }
        }

        public float m_Depth
        {
            get
            {
                return base.method_2<float>("m_Depth");
            }
        }

        public localRenderEffects m_Effect
        {
            get
            {
                return base.method_2<localRenderEffects>("m_Effect");
            }
        }

        public float m_Height
        {
            get
            {
                return base.method_2<float>("m_Height");
            }
        }

        public LayerMask m_LayerMask
        {
            get
            {
                return base.method_2<LayerMask>("m_LayerMask");
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

        public float m_PreviousHeight
        {
            get
            {
                return base.method_2<float>("m_PreviousHeight");
            }
        }

        public float m_PreviousWidth
        {
            get
            {
                return base.method_2<float>("m_PreviousWidth");
            }
        }

        public int m_Resolution
        {
            get
            {
                return base.method_2<int>("m_Resolution");
            }
        }

        public float m_Width
        {
            get
            {
                return base.method_2<float>("m_Width");
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

        public float RENDER_PLANE_OFFSET
        {
            get
            {
                return base.method_2<float>("RENDER_PLANE_OFFSET");
            }
        }
    }
}

