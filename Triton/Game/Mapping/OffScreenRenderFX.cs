namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("OffScreenRenderFX")]
    public class OffScreenRenderFX : MonoBehaviour
    {
        public OffScreenRenderFX(IntPtr address) : this(address, "OffScreenRenderFX")
        {
        }

        public OffScreenRenderFX(IntPtr address, string className) : base(address, className)
        {
        }

        public void CreateCamera()
        {
            base.method_8("CreateCamera", Array.Empty<object>());
        }

        public void CreateRenderTexture()
        {
            base.method_8("CreateRenderTexture", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void PositionObjectToRender()
        {
            base.method_8("PositionObjectToRender", Array.Empty<object>());
        }

        public void SetupCamera()
        {
            base.method_8("SetupCamera", Array.Empty<object>());
        }

        public void SetupMaterial()
        {
            base.method_8("SetupMaterial", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateOffScreenCamera()
        {
            base.method_8("UpdateOffScreenCamera", Array.Empty<object>());
        }

        public float AboveClip
        {
            get
            {
                return base.method_2<float>("AboveClip");
            }
        }

        public float BelowClip
        {
            get
            {
                return base.method_2<float>("BelowClip");
            }
        }

        public Rect CameraRect
        {
            get
            {
                return base.method_2<Rect>("CameraRect");
            }
        }

        public float ForceSize
        {
            get
            {
                return base.method_2<float>("ForceSize");
            }
        }

        public static int IgnoreLayer
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "OffScreenRenderFX", "IgnoreLayer");
            }
        }

        public GameObject ObjectToRender
        {
            get
            {
                return base.method_3<GameObject>("ObjectToRender");
            }
        }

        public Camera offscreenFXCamera
        {
            get
            {
                return base.method_3<Camera>("offscreenFXCamera");
            }
        }

        public GameObject offscreenFXCameraGO
        {
            get
            {
                return base.method_3<GameObject>("offscreenFXCameraGO");
            }
        }

        public Bounds RenderBounds
        {
            get
            {
                return base.method_2<Bounds>("RenderBounds");
            }
        }

        public int RenderResolutionX
        {
            get
            {
                return base.method_2<int>("RenderResolutionX");
            }
        }

        public int RenderResolutionY
        {
            get
            {
                return base.method_2<int>("RenderResolutionY");
            }
        }

        public static float s_Xoffset
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "OffScreenRenderFX", "s_Xoffset");
            }
        }

        public static float s_Yoffset
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "OffScreenRenderFX", "s_Yoffset");
            }
        }

        public bool UseBounds
        {
            get
            {
                return base.method_2<bool>("UseBounds");
            }
        }

        public float Yoffset
        {
            get
            {
                return base.method_2<float>("Yoffset");
            }
        }
    }
}

