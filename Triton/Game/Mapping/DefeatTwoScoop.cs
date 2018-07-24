namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DefeatTwoScoop")]
    public class DefeatTwoScoop : EndGameTwoScoop
    {
        public DefeatTwoScoop(IntPtr address) : this(address, "DefeatTwoScoop")
        {
        }

        public DefeatTwoScoop(IntPtr address, string className) : base(address, className)
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

        public void AnimateLeftTrumpetFro()
        {
            base.method_8("AnimateLeftTrumpetFro", Array.Empty<object>());
        }

        public void AnimateLeftTrumpetTo()
        {
            base.method_8("AnimateLeftTrumpetTo", Array.Empty<object>());
        }

        public void AnimateRightTrumpetFro()
        {
            base.method_8("AnimateRightTrumpetFro", Array.Empty<object>());
        }

        public void AnimateRightTrumpetTo()
        {
            base.method_8("AnimateRightTrumpetTo", Array.Empty<object>());
        }

        public void CloudFro()
        {
            base.method_8("CloudFro", Array.Empty<object>());
        }

        public void CloudTo()
        {
            base.method_8("CloudTo", Array.Empty<object>());
        }

        public void ResetPositions()
        {
            base.method_8("ResetPositions", Array.Empty<object>());
        }

        public void ShowImpl()
        {
            base.method_8("ShowImpl", Array.Empty<object>());
        }

        public void TokyoDriftFro()
        {
            base.method_8("TokyoDriftFro", Array.Empty<object>());
        }

        public void TokyoDriftTo()
        {
            base.method_8("TokyoDriftTo", Array.Empty<object>());
        }

        public GameObject m_crown
        {
            get
            {
                return base.method_3<GameObject>("m_crown");
            }
        }

        public GameObject m_defeatBanner
        {
            get
            {
                return base.method_3<GameObject>("m_defeatBanner");
            }
        }

        public GameObject m_leftBanner
        {
            get
            {
                return base.method_3<GameObject>("m_leftBanner");
            }
        }

        public GameObject m_leftBannerFront
        {
            get
            {
                return base.method_3<GameObject>("m_leftBannerFront");
            }
        }

        public GameObject m_leftCloud
        {
            get
            {
                return base.method_3<GameObject>("m_leftCloud");
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

        public GameObject m_rightBannerShred
        {
            get
            {
                return base.method_3<GameObject>("m_rightBannerShred");
            }
        }

        public GameObject m_rightCloud
        {
            get
            {
                return base.method_3<GameObject>("m_rightCloud");
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

