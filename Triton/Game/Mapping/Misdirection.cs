namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("Misdirection")]
    public class Misdirection : Spell
    {
        public Misdirection(IntPtr address) : this(address, "Misdirection")
        {
        }

        public Misdirection(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddPowerTargets()
        {
            return base.method_11<bool>("AddPowerTargets", Array.Empty<object>());
        }

        public List<Vector3> BuildAnimationPath()
        {
            Class246<Vector3> class2 = base.method_14<Class246<Vector3>>("BuildAnimationPath", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<Card> FindPossibleTargetCards()
        {
            Class247<Card> class2 = base.method_14<Class247<Card>>("FindPossibleTargetCards", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public Card GetCurrentPlayerHeroCard()
        {
            return base.method_14<Card>("GetCurrentPlayerHeroCard", Array.Empty<object>());
        }

        public Card GetOpponentHeroCard()
        {
            return base.method_14<Card>("GetOpponentHeroCard", Array.Empty<object>());
        }

        public List<Card> GetOpponentZoneMinions()
        {
            Class247<Card> class2 = base.method_14<Class247<Card>>("GetOpponentZoneMinions", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public Card GetTargetCardFromPowerTask(int index, PowerTask task)
        {
            object[] objArray1 = new object[] { index, task };
            return base.method_14<Card>("GetTargetCardFromPowerTask", objArray1);
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public void ReticleAnimationComplete()
        {
            base.method_8("ReticleAnimationComplete", Array.Empty<object>());
        }

        public void SetReticleAlphaValue(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("SetReticleAlphaValue", objArray1);
        }

        public void StartAnimation()
        {
            base.method_8("StartAnimation", Array.Empty<object>());
        }

        public Card m_AttackingMinionCard
        {
            get
            {
                return base.method_3<Card>("m_AttackingMinionCard");
            }
        }

        public Color m_OrgAmbient
        {
            get
            {
                return base.method_2<Color>("m_OrgAmbient");
            }
        }

        public Card m_PlayerHeroCard
        {
            get
            {
                return base.method_3<Card>("m_PlayerHeroCard");
            }
        }

        public GameObject m_Reticle
        {
            get
            {
                return base.method_3<GameObject>("m_Reticle");
            }
        }

        public Color m_ReticleAttackColor
        {
            get
            {
                return base.method_2<Color>("m_ReticleAttackColor");
            }
        }

        public float m_ReticleAttackHold
        {
            get
            {
                return base.method_2<float>("m_ReticleAttackHold");
            }
        }

        public Vector3 m_ReticleAttackRotate
        {
            get
            {
                return base.method_2<Vector3>("m_ReticleAttackRotate");
            }
        }

        public float m_ReticleAttackScale
        {
            get
            {
                return base.method_2<float>("m_ReticleAttackScale");
            }
        }

        public float m_ReticleAttackTime
        {
            get
            {
                return base.method_2<float>("m_ReticleAttackTime");
            }
        }

        public float m_ReticleBlur
        {
            get
            {
                return base.method_2<float>("m_ReticleBlur");
            }
        }

        public float m_ReticleBlurFocusTime
        {
            get
            {
                return base.method_2<float>("m_ReticleBlurFocusTime");
            }
        }

        public float m_ReticleFadeInTime
        {
            get
            {
                return base.method_2<float>("m_ReticleFadeInTime");
            }
        }

        public float m_ReticleFadeOutTime
        {
            get
            {
                return base.method_2<float>("m_ReticleFadeOutTime");
            }
        }

        public GameObject m_ReticleInstance
        {
            get
            {
                return base.method_3<GameObject>("m_ReticleInstance");
            }
        }

        public float m_ReticlePathTime
        {
            get
            {
                return base.method_2<float>("m_ReticlePathTime");
            }
        }
    }
}

