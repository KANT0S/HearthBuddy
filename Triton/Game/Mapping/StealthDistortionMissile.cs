namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("StealthDistortionMissile")]
    public class StealthDistortionMissile : MonoBehaviour
    {
        public StealthDistortionMissile(IntPtr address) : this(address, "StealthDistortionMissile")
        {
        }

        public StealthDistortionMissile(IntPtr address, string className) : base(address, className)
        {
        }

        public void CreateCameras()
        {
            base.method_8("CreateCameras", Array.Empty<object>());
        }

        public void CreateRenderTextures()
        {
            base.method_8("CreateRenderTextures", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void PositionObjectToRender()
        {
            base.method_8("PositionObjectToRender", Array.Empty<object>());
        }

        public void SetupCameras()
        {
            base.method_8("SetupCameras", Array.Empty<object>());
        }

        public void SetupMaterial()
        {
            base.method_8("SetupMaterial", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public Camera boardCamera
        {
            get
            {
                return base.method_3<Camera>("boardCamera");
            }
        }

        public GameObject boardCameraGO
        {
            get
            {
                return base.method_3<GameObject>("boardCameraGO");
            }
        }

        public float DistortionAboveClip
        {
            get
            {
                return base.method_2<float>("DistortionAboveClip");
            }
        }

        public float DistortionBelowClip
        {
            get
            {
                return base.method_2<float>("DistortionBelowClip");
            }
        }

        public int DistortionResolutionX
        {
            get
            {
                return base.method_2<int>("DistortionResolutionX");
            }
        }

        public int DistortionResolutionY
        {
            get
            {
                return base.method_2<int>("DistortionResolutionY");
            }
        }

        public static int IgnoreLayer
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "StealthDistortionMissile", "IgnoreLayer");
            }
        }

        public GameObject ObjectToRender
        {
            get
            {
                return base.method_3<GameObject>("ObjectToRender");
            }
        }

        public float ParticleAboveClip
        {
            get
            {
                return base.method_2<float>("ParticleAboveClip");
            }
        }

        public float ParticleBelowClip
        {
            get
            {
                return base.method_2<float>("ParticleBelowClip");
            }
        }

        public Camera particleCamera
        {
            get
            {
                return base.method_3<Camera>("particleCamera");
            }
        }

        public GameObject particleCameraGO
        {
            get
            {
                return base.method_3<GameObject>("particleCameraGO");
            }
        }

        public int ParticleResolutionX
        {
            get
            {
                return base.method_2<int>("ParticleResolutionX");
            }
        }

        public int ParticleResolutionY
        {
            get
            {
                return base.method_2<int>("ParticleResolutionY");
            }
        }

        public float RenderOffsetX
        {
            get
            {
                return base.method_2<float>("RenderOffsetX");
            }
        }

        public float RenderOffsetY
        {
            get
            {
                return base.method_2<float>("RenderOffsetY");
            }
        }

        public float RenderOffsetZ
        {
            get
            {
                return base.method_2<float>("RenderOffsetZ");
            }
        }

        public static float s_Yoffset
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "StealthDistortionMissile", "s_Yoffset");
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

