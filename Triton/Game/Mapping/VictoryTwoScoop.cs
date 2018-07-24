namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("VictoryTwoScoop")]
    public class VictoryTwoScoop : EndGameTwoScoop
    {
        public VictoryTwoScoop(IntPtr address) : this(address, "VictoryTwoScoop")
        {
        }

        public VictoryTwoScoop(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateCrownFro()
        {
            base.method_8("AnimateCrownFro", Array.Empty<object>());
        }

        public void AnimateCrownTo()
        {
            base.method_8("AnimateCrownTo", Array.Empty<object>());
        }

        public void AnimateGodraysFro()
        {
            base.method_8("AnimateGodraysFro", Array.Empty<object>());
        }

        public void AnimateGodraysTo()
        {
            base.method_8("AnimateGodraysTo", Array.Empty<object>());
        }

        public void CloudFro()
        {
            base.method_8("CloudFro", Array.Empty<object>());
        }

        public void CloudTo()
        {
            base.method_8("CloudTo", Array.Empty<object>());
        }

        public void LaurelWaveFro()
        {
            base.method_8("LaurelWaveFro", Array.Empty<object>());
        }

        public void LaurelWaveTo()
        {
            base.method_8("LaurelWaveTo", Array.Empty<object>());
        }

        public void ResetPositions()
        {
            base.method_8("ResetPositions", Array.Empty<object>());
        }

        public void ShowImpl()
        {
            base.method_8("ShowImpl", Array.Empty<object>());
        }

        public void StopAnimating()
        {
            base.method_8("StopAnimating", Array.Empty<object>());
        }

        public void TokyoDriftFro()
        {
            base.method_8("TokyoDriftFro", Array.Empty<object>());
        }

        public void TokyoDriftTo()
        {
            base.method_8("TokyoDriftTo", Array.Empty<object>());
        }

        public static float GOD_RAY_ANGLE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "VictoryTwoScoop", "GOD_RAY_ANGLE");
            }
        }

        public static float GOD_RAY_DURATION
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "VictoryTwoScoop", "GOD_RAY_DURATION");
            }
        }

        public static float LAUREL_ROTATION
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "VictoryTwoScoop", "LAUREL_ROTATION");
            }
        }

        public GameObject m_crown
        {
            get
            {
                return base.method_3<GameObject>("m_crown");
            }
        }

        public GameObject m_godRays
        {
            get
            {
                return base.method_3<GameObject>("m_godRays");
            }
        }

        public GameObject m_godRays2
        {
            get
            {
                return base.method_3<GameObject>("m_godRays2");
            }
        }

        public GameObject m_leftBanner
        {
            get
            {
                return base.method_3<GameObject>("m_leftBanner");
            }
        }

        public GameObject m_leftCloud
        {
            get
            {
                return base.method_3<GameObject>("m_leftCloud");
            }
        }

        public GameObject m_leftLaurel
        {
            get
            {
                return base.method_3<GameObject>("m_leftLaurel");
            }
        }

        public GameObject m_leftTrumpet
        {
            get
            {
                return base.method_3<GameObject>("m_leftTrumpet");
            }
        }

        public GameObject m_rightBanner
        {
            get
            {
                return base.method_3<GameObject>("m_rightBanner");
            }
        }

        public GameObject m_rightCloud
        {
            get
            {
                return base.method_3<GameObject>("m_rightCloud");
            }
        }

        public GameObject m_rightLaurel
        {
            get
            {
                return base.method_3<GameObject>("m_rightLaurel");
            }
        }

        public GameObject m_rightTrumpet
        {
            get
            {
                return base.method_3<GameObject>("m_rightTrumpet");
            }
        }
    }
}

