namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CameraShakeMgr")]
    public class CameraShakeMgr : MonoBehaviour
    {
        public CameraShakeMgr(IntPtr address) : this(address, "CameraShakeMgr")
        {
        }

        public CameraShakeMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public float ComputeIntensity()
        {
            return base.method_11<float>("ComputeIntensity", Array.Empty<object>());
        }

        public void DestroyShake()
        {
            base.method_8("DestroyShake", Array.Empty<object>());
        }

        public bool IsHolding()
        {
            return base.method_11<bool>("IsHolding", Array.Empty<object>());
        }

        public static bool IsShaking(Camera camera)
        {
            object[] objArray1 = new object[] { camera };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "CameraShakeMgr", "IsShaking", objArray1);
        }

        public static void Shake(Camera camera, Vector3 amount, float time)
        {
            object[] objArray1 = new object[] { camera, amount, time };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "CameraShakeMgr", "Shake", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void Stop(Camera camera, float time)
        {
            object[] objArray1 = new object[] { camera, time };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "CameraShakeMgr", "Stop", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateShake()
        {
            base.method_8("UpdateShake", Array.Empty<object>());
        }

        public Vector3 m_amount
        {
            get
            {
                return base.method_2<Vector3>("m_amount");
            }
        }

        public float m_durationSec
        {
            get
            {
                return base.method_2<float>("m_durationSec");
            }
        }

        public Vector3 m_initialPos
        {
            get
            {
                return base.method_2<Vector3>("m_initialPos");
            }
        }

        public float m_progressSec
        {
            get
            {
                return base.method_2<float>("m_progressSec");
            }
        }

        public bool m_started
        {
            get
            {
                return base.method_2<bool>("m_started");
            }
        }
    }
}

