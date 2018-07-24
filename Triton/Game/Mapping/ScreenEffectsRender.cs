namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ScreenEffectsRender")]
    public class ScreenEffectsRender : MonoBehaviour
    {
        public ScreenEffectsRender(IntPtr address) : this(address, "ScreenEffectsRender")
        {
        }

        public ScreenEffectsRender(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void OnPreRender()
        {
            base.method_8("OnPreRender", Array.Empty<object>());
        }

        public void RenderEffectsObjects()
        {
            base.method_8("RenderEffectsObjects", Array.Empty<object>());
        }

        public void SetupDistortion()
        {
            base.method_8("SetupDistortion", Array.Empty<object>());
        }

        public void SetupEffect()
        {
            base.method_8("SetupEffect", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public static string BLOOM_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ScreenEffectsRender", "BLOOM_SHADER_NAME");
            }
        }

        public static string DISTORTION_SHADER_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ScreenEffectsRender", "DISTORTION_SHADER_NAME");
            }
        }

        public Material DistortionMaterial
        {
            get
            {
                return base.method_14<Material>("get_DistortionMaterial", Array.Empty<object>());
            }
        }

        public static string GLOW_MASK_SHADER
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "ScreenEffectsRender", "GLOW_MASK_SHADER");
            }
        }

        public static int GLOW_RANDER_BUFFER_RESOLUTION
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "ScreenEffectsRender", "GLOW_RANDER_BUFFER_RESOLUTION");
            }
        }

        public Material GlowMaterial
        {
            get
            {
                return base.method_14<Material>("get_GlowMaterial", Array.Empty<object>());
            }
        }

        public bool m_Debug
        {
            get
            {
                return base.method_2<bool>("m_Debug");
            }
        }

        public Material m_DistortionMaterial
        {
            get
            {
                return base.method_3<Material>("m_DistortionMaterial");
            }
        }

        public Camera m_EffectsObjectsCamera
        {
            get
            {
                return base.method_3<Camera>("m_EffectsObjectsCamera");
            }
        }

        public Material m_GlowMaterial
        {
            get
            {
                return base.method_3<Material>("m_GlowMaterial");
            }
        }

        public int m_height
        {
            get
            {
                return base.method_2<int>("m_height");
            }
        }

        public int m_previousHeight
        {
            get
            {
                return base.method_2<int>("m_previousHeight");
            }
        }

        public int m_previousWidth
        {
            get
            {
                return base.method_2<int>("m_previousWidth");
            }
        }

        public int m_width
        {
            get
            {
                return base.method_2<int>("m_width");
            }
        }
    }
}

