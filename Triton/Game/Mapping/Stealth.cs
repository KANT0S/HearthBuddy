namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Stealth")]
    public class Stealth : MonoBehaviour
    {
        public Stealth(IntPtr address) : this(address, "Stealth")
        {
        }

        public Stealth(IntPtr address, string className) : base(address, className)
        {
        }

        public void CameraRender()
        {
            base.method_8("CameraRender", Array.Empty<object>());
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

        public static int IgnoreLayer
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Stealth", "IgnoreLayer");
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

        public Camera stealthCamera
        {
            get
            {
                return base.method_3<Camera>("stealthCamera");
            }
        }

        public GameObject stealthCameraGO
        {
            get
            {
                return base.method_3<GameObject>("stealthCameraGO");
            }
        }
    }
}

