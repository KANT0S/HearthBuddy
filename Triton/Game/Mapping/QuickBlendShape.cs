namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("QuickBlendShape")]
    public class QuickBlendShape : MonoBehaviour
    {
        public QuickBlendShape(IntPtr address) : this(address, "QuickBlendShape")
        {
        }

        public QuickBlendShape(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BlendShapeAnimate()
        {
            base.method_8("BlendShapeAnimate", Array.Empty<object>());
        }

        public void CreateBlendMeshes()
        {
            base.method_8("CreateBlendMeshes", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void PlayAnimation()
        {
            base.method_8("PlayAnimation", Array.Empty<object>());
        }

        public void StopAnimation()
        {
            base.method_8("StopAnimation", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public BLEND_SHAPE_ANIMATION_TYPE m_AnimationType
        {
            get
            {
                return base.method_2<BLEND_SHAPE_ANIMATION_TYPE>("m_AnimationType");
            }
        }

        public float m_animTime
        {
            get
            {
                return base.method_2<float>("m_animTime");
            }
        }

        public List<Material> m_BlendMaterials
        {
            get
            {
                Class247<Material> class2 = base.method_3<Class247<Material>>("m_BlendMaterials");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Mesh> m_BlendMeshes
        {
            get
            {
                Class267<Mesh> class2 = base.method_3<Class267<Mesh>>("m_BlendMeshes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_BlendValue
        {
            get
            {
                return base.method_2<float>("m_BlendValue");
            }
        }

        public bool m_DisableOnMobile
        {
            get
            {
                return base.method_2<bool>("m_DisableOnMobile");
            }
        }

        public bool m_Loop
        {
            get
            {
                return base.method_2<bool>("m_Loop");
            }
        }

        public List<Mesh> m_Meshes
        {
            get
            {
                Class247<Mesh> class2 = base.method_3<Class247<Mesh>>("m_Meshes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Mesh m_OrgMesh
        {
            get
            {
                return base.method_3<Mesh>("m_OrgMesh");
            }
        }

        public bool m_Play
        {
            get
            {
                return base.method_2<bool>("m_Play");
            }
        }

        public bool m_PlayOnAwake
        {
            get
            {
                return base.method_2<bool>("m_PlayOnAwake");
            }
        }

        public enum BLEND_SHAPE_ANIMATION_TYPE
        {
            Curve,
            Float
        }
    }
}

