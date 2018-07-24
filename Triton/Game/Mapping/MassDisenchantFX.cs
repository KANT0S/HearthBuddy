namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("MassDisenchantFX")]
    public class MassDisenchantFX : MonoClass
    {
        public MassDisenchantFX(IntPtr address) : this(address, "MassDisenchantFX")
        {
        }

        public MassDisenchantFX(IntPtr address, string className) : base(address, className)
        {
        }

        public GameObject m_blockInteraction
        {
            get
            {
                return base.method_3<GameObject>("m_blockInteraction");
            }
        }

        public GameObject m_burstFX_Common
        {
            get
            {
                return base.method_3<GameObject>("m_burstFX_Common");
            }
        }

        public GameObject m_burstFX_Epic
        {
            get
            {
                return base.method_3<GameObject>("m_burstFX_Epic");
            }
        }

        public GameObject m_burstFX_Legendary
        {
            get
            {
                return base.method_3<GameObject>("m_burstFX_Legendary");
            }
        }

        public GameObject m_burstFX_Rare
        {
            get
            {
                return base.method_3<GameObject>("m_burstFX_Rare");
            }
        }

        public GameObject m_gemBoxLeft1
        {
            get
            {
                return base.method_3<GameObject>("m_gemBoxLeft1");
            }
        }

        public GameObject m_gemBoxLeft2
        {
            get
            {
                return base.method_3<GameObject>("m_gemBoxLeft2");
            }
        }

        public GameObject m_gemBoxRight1
        {
            get
            {
                return base.method_3<GameObject>("m_gemBoxRight1");
            }
        }

        public GameObject m_gemBoxRight2
        {
            get
            {
                return base.method_3<GameObject>("m_gemBoxRight2");
            }
        }

        public GameObject m_glowBall
        {
            get
            {
                return base.method_3<GameObject>("m_glowBall");
            }
        }

        public Material m_glowBallMat_Common
        {
            get
            {
                return base.method_3<Material>("m_glowBallMat_Common");
            }
        }

        public Material m_glowBallMat_Epic
        {
            get
            {
                return base.method_3<Material>("m_glowBallMat_Epic");
            }
        }

        public Material m_glowBallMat_Legendary
        {
            get
            {
                return base.method_3<Material>("m_glowBallMat_Legendary");
            }
        }

        public Material m_glowBallMat_Rare
        {
            get
            {
                return base.method_3<Material>("m_glowBallMat_Rare");
            }
        }

        public GameObject m_glowTotal
        {
            get
            {
                return base.method_3<GameObject>("m_glowTotal");
            }
        }

        public Material m_glowTrailMat_Common
        {
            get
            {
                return base.method_3<Material>("m_glowTrailMat_Common");
            }
        }

        public Material m_glowTrailMat_Epic
        {
            get
            {
                return base.method_3<Material>("m_glowTrailMat_Epic");
            }
        }

        public Material m_glowTrailMat_Legendary
        {
            get
            {
                return base.method_3<Material>("m_glowTrailMat_Legendary");
            }
        }

        public Material m_glowTrailMat_Rare
        {
            get
            {
                return base.method_3<Material>("m_glowTrailMat_Rare");
            }
        }

        public HighlightState m_highlight
        {
            get
            {
                return base.method_3<HighlightState>("m_highlight");
            }
        }
    }
}

