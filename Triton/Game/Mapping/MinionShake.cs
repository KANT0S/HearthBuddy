namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("MinionShake")]
    public class MinionShake : MonoBehaviour
    {
        public MinionShake(IntPtr address) : this(address, "MinionShake")
        {
        }

        public MinionShake(IntPtr address, string className) : base(address, className)
        {
        }

        public Vector2 AngleToVector(float angle)
        {
            object[] objArray1 = new object[] { angle };
            return base.method_11<Vector2>("AngleToVector", objArray1);
        }

        public static List<MinionShake> FindAllMinionShakers(GameObject shakeTrigger)
        {
            object[] objArray1 = new object[] { shakeTrigger };
            Class247<MinionShake> class2 = MonoClass.smethod_15<Class247<MinionShake>>(TritonHs.MainAssemblyPath, "", "MinionShake", "FindAllMinionShakers", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public bool isShaking()
        {
            return base.method_11<bool>("isShaking", Array.Empty<object>());
        }

        public void LateUpdate()
        {
            base.method_8("LateUpdate", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void RandomShake(float impact)
        {
            object[] objArray1 = new object[] { impact };
            base.method_8("RandomShake", objArray1);
        }

        public static void ShakeAllMinions(GameObject shakeTrigger, ShakeMinionType shakeType, Vector3 impactPoint, ShakeMinionIntensity intensityType, float intensityValue, float radius, float startDelay)
        {
            object[] objArray1 = new object[] { shakeTrigger, shakeType, impactPoint, intensityType, intensityValue, radius, startDelay };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "MinionShake", "ShakeAllMinions", objArray1);
        }

        public void ShakeAllMinionsRandomLarge()
        {
            base.method_8("ShakeAllMinionsRandomLarge", Array.Empty<object>());
        }

        public void ShakeAllMinionsRandomMedium()
        {
            base.method_8("ShakeAllMinionsRandomMedium", Array.Empty<object>());
        }

        public void ShakeMinion()
        {
            base.method_8("ShakeMinion", Array.Empty<object>());
        }

        public static void ShakeObject(GameObject shakeObject, ShakeMinionType shakeType, Vector3 impactPoint, ShakeMinionIntensity intensityType, float intensityValue, float radius, float startDelay)
        {
            object[] objArray1 = new object[] { shakeObject, shakeType, impactPoint, intensityType, intensityValue, radius, startDelay };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "MinionShake", "ShakeObject", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ShakeObject(GameObject shakeObject, ShakeMinionType shakeType, Vector3 impactPoint, ShakeMinionIntensity intensityType, float intensityValue, float radius, float startDelay, bool ignoreAnimationPlaying)
        {
            object[] objArray1 = new object[] { shakeObject, shakeType, impactPoint, intensityType, intensityValue, radius, startDelay, ignoreAnimationPlaying };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "MinionShake", "ShakeObject", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ShakeObject(GameObject shakeObject, ShakeMinionType shakeType, Vector3 impactPoint, ShakeMinionIntensity intensityType, float intensityValue, float radius, float startDelay, bool ignoreAnimationPlaying, bool ignoreHeight)
        {
            object[] objArray1 = new object[] { shakeObject, shakeType, impactPoint, intensityType, intensityValue, radius, startDelay, ignoreAnimationPlaying, ignoreHeight };
            MonoClass.smethod_19(TritonHs.MainAssemblyPath, "", "MinionShake", "ShakeObject", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public static void ShakeTargetMinion(GameObject shakeTarget, ShakeMinionType shakeType, Vector3 impactPoint, ShakeMinionIntensity intensityType, float intensityValue, float radius, float startDelay)
        {
            object[] objArray1 = new object[] { shakeTarget, shakeType, impactPoint, intensityType, intensityValue, radius, startDelay };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "MinionShake", "ShakeTargetMinion", objArray1);
        }

        public static float DISABLE_HEIGHT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "MinionShake", "DISABLE_HEIGHT");
            }
        }

        public static float INTENSITY_LARGE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "MinionShake", "INTENSITY_LARGE");
            }
        }

        public static float INTENSITY_MEDIUM
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "MinionShake", "INTENSITY_MEDIUM");
            }
        }

        public static float INTENSITY_SMALL
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "MinionShake", "INTENSITY_SMALL");
            }
        }

        public float m_Angle
        {
            get
            {
                return base.method_2<float>("m_Angle");
            }
        }

        public bool m_Animating
        {
            get
            {
                return base.method_2<bool>("m_Animating");
            }
        }

        public Transform m_CardPlayAllyTransform
        {
            get
            {
                return base.method_3<Transform>("m_CardPlayAllyTransform");
            }
        }

        public bool m_IgnoreAnimationPlaying
        {
            get
            {
                return base.method_2<bool>("m_IgnoreAnimationPlaying");
            }
        }

        public bool m_IgnoreHeight
        {
            get
            {
                return base.method_2<bool>("m_IgnoreHeight");
            }
        }

        public Vector2 m_ImpactDirection
        {
            get
            {
                return base.method_2<Vector2>("m_ImpactDirection");
            }
        }

        public Vector3 m_ImpactPosition
        {
            get
            {
                return base.method_2<Vector3>("m_ImpactPosition");
            }
        }

        public float m_IntensityValue
        {
            get
            {
                return base.method_2<float>("m_IntensityValue");
            }
        }

        public Vector3 m_MinionOrgPos
        {
            get
            {
                return base.method_2<Vector3>("m_MinionOrgPos");
            }
        }

        public Quaternion m_MinionOrgRot
        {
            get
            {
                return base.method_2<Quaternion>("m_MinionOrgRot");
            }
        }

        public GameObject m_MinionShakeAnimator
        {
            get
            {
                return base.method_3<GameObject>("m_MinionShakeAnimator");
            }
        }

        public GameObject m_MinionShakeInstance
        {
            get
            {
                return base.method_3<GameObject>("m_MinionShakeInstance");
            }
        }

        public float m_Radius
        {
            get
            {
                return base.method_2<float>("m_Radius");
            }
        }

        public ShakeMinionIntensity m_ShakeIntensityType
        {
            get
            {
                return base.method_2<ShakeMinionIntensity>("m_ShakeIntensityType");
            }
        }

        public ShakeMinionType m_ShakeType
        {
            get
            {
                return base.method_2<ShakeMinionType>("m_ShakeType");
            }
        }

        public float m_StartDelay
        {
            get
            {
                return base.method_2<float>("m_StartDelay");
            }
        }

        public Vector3 OFFSCREEN_POSITION
        {
            get
            {
                return base.method_2<Vector3>("OFFSCREEN_POSITION");
            }
        }

        public static int s_IdleState
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "MinionShake", "s_IdleState");
            }
        }
    }
}

