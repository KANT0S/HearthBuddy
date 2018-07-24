namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("BrawlSpell")]
    public class BrawlSpell : Spell
    {
        public BrawlSpell(IntPtr address) : this(address, "BrawlSpell")
        {
        }

        public BrawlSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public Card FindSurvivor()
        {
            return base.method_14<Card>("FindSurvivor", Array.Empty<object>());
        }

        public Card GetTargetCardFromPowerTask(int index, PowerTask task)
        {
            object[] objArray1 = new object[] { index, task };
            return base.method_14<Card>("GetTargetCardFromPowerTask", objArray1);
        }

        public bool IsSurvivorAlone()
        {
            return base.method_11<bool>("IsSurvivorAlone", Array.Empty<object>());
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public void OnJumpInComplete(Card targetCard)
        {
            object[] objArray1 = new object[] { targetCard };
            base.method_8("OnJumpInComplete", objArray1);
        }

        public void OnJumpOutComplete(Card targetCard)
        {
            object[] objArray1 = new object[] { targetCard };
            base.method_8("OnJumpOutComplete", objArray1);
        }

        public void StartJumpIns()
        {
            base.method_8("StartJumpIns", Array.Empty<object>());
        }

        public void StartJumpOuts()
        {
            base.method_8("StartJumpOuts", Array.Empty<object>());
        }

        public float m_HoldTime
        {
            get
            {
                return base.method_2<float>("m_HoldTime");
            }
        }

        public float m_JumpInDuration
        {
            get
            {
                return base.method_2<float>("m_JumpInDuration");
            }
        }

        public iTween.EaseType m_JumpInEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_JumpInEaseType");
            }
        }

        public float m_JumpInSoundDelay
        {
            get
            {
                return base.method_2<float>("m_JumpInSoundDelay");
            }
        }

        public float m_JumpOutDuration
        {
            get
            {
                return base.method_2<float>("m_JumpOutDuration");
            }
        }

        public iTween.EaseType m_JumpOutEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_JumpOutEaseType");
            }
        }

        public float m_JumpOutSoundDelay
        {
            get
            {
                return base.method_2<float>("m_JumpOutSoundDelay");
            }
        }

        public int m_jumpsPending
        {
            get
            {
                return base.method_2<int>("m_jumpsPending");
            }
        }

        public float m_LandSoundDelay
        {
            get
            {
                return base.method_2<float>("m_LandSoundDelay");
            }
        }

        public List<GameObject> m_LeftJumpOutBones
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_LeftJumpOutBones");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_MaxJumpHeight
        {
            get
            {
                return base.method_2<float>("m_MaxJumpHeight");
            }
        }

        public float m_MaxJumpInDelay
        {
            get
            {
                return base.method_2<float>("m_MaxJumpInDelay");
            }
        }

        public float m_MaxJumpOutDelay
        {
            get
            {
                return base.method_2<float>("m_MaxJumpOutDelay");
            }
        }

        public float m_MinJumpHeight
        {
            get
            {
                return base.method_2<float>("m_MinJumpHeight");
            }
        }

        public float m_MinJumpInDelay
        {
            get
            {
                return base.method_2<float>("m_MinJumpInDelay");
            }
        }

        public float m_MinJumpOutDelay
        {
            get
            {
                return base.method_2<float>("m_MinJumpOutDelay");
            }
        }

        public List<GameObject> m_RightJumpOutBones
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_RightJumpOutBones");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Card m_survivorCard
        {
            get
            {
                return base.method_3<Card>("m_survivorCard");
            }
        }

        public float m_SurvivorHoldDuration
        {
            get
            {
                return base.method_2<float>("m_SurvivorHoldDuration");
            }
        }
    }
}

