namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("MimironsHead")]
    public class MimironsHead : SuperSpell
    {
        public MimironsHead(IntPtr address) : this(address, "MimironsHead")
        {
        }

        public MimironsHead(IntPtr address, string className) : base(address, className)
        {
        }

        public void AbsorbMinions()
        {
            base.method_8("AbsorbMinions", Array.Empty<object>());
        }

        public bool AddPowerTargets()
        {
            return base.method_11<bool>("AddPowerTargets", Array.Empty<object>());
        }

        public void DestroyMinions()
        {
            base.method_8("DestroyMinions", Array.Empty<object>());
        }

        public void DropV07tron()
        {
            base.method_8("DropV07tron", Array.Empty<object>());
        }

        public void FadeInBackground()
        {
            base.method_8("FadeInBackground", Array.Empty<object>());
        }

        public void FadeOutBackground()
        {
            base.method_8("FadeOutBackground", Array.Empty<object>());
        }

        public void Finish()
        {
            base.method_8("Finish", Array.Empty<object>());
        }

        public void FlareMimiron()
        {
            base.method_8("FlareMimiron", Array.Empty<object>());
        }

        public void MimironPowerUp()
        {
            base.method_8("MimironPowerUp", Array.Empty<object>());
        }

        public void MinionCleanup(GameObject minion)
        {
            object[] objArray1 = new object[] { minion };
            base.method_8("MinionCleanup", objArray1);
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public void RaiseVolt()
        {
            base.method_8("RaiseVolt", Array.Empty<object>());
        }

        public void SetGlow(Material glowMat, float newVal, string colorVal)
        {
            object[] objArray1 = new object[] { glowMat, newVal, colorVal };
            base.method_8("SetGlow", objArray1);
        }

        public void TransformMinions()
        {
            base.method_8("TransformMinions", Array.Empty<object>());
        }

        public void UnflareMimiron()
        {
            base.method_8("UnflareMimiron", Array.Empty<object>());
        }

        public float m_absorbTime
        {
            get
            {
                return base.method_2<float>("m_absorbTime");
            }
        }

        public GameObject m_background
        {
            get
            {
                return base.method_3<GameObject>("m_background");
            }
        }

        public Color m_clear
        {
            get
            {
                return base.method_2<Color>("m_clear");
            }
        }

        public float m_flashDelay
        {
            get
            {
                return base.method_2<float>("m_flashDelay");
            }
        }

        public float m_glowTime
        {
            get
            {
                return base.method_2<float>("m_glowTime");
            }
        }

        public GameObject m_highPosBone
        {
            get
            {
                return base.method_3<GameObject>("m_highPosBone");
            }
        }

        public bool m_isNegFlash
        {
            get
            {
                return base.method_2<bool>("m_isNegFlash");
            }
        }

        public List<Card> m_mechMinions
        {
            get
            {
                Class267<Card> class2 = base.method_3<Class267<Card>>("m_mechMinions");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Card m_mimiron
        {
            get
            {
                return base.method_3<Card>("m_mimiron");
            }
        }

        public GameObject m_mimironElectricity
        {
            get
            {
                return base.method_3<GameObject>("m_mimironElectricity");
            }
        }

        public GameObject m_mimironFlare
        {
            get
            {
                return base.method_3<GameObject>("m_mimironFlare");
            }
        }

        public GameObject m_mimironGlow
        {
            get
            {
                return base.method_3<GameObject>("m_mimironGlow");
            }
        }

        public float m_mimironHighTime
        {
            get
            {
                return base.method_2<float>("m_mimironHighTime");
            }
        }

        public GameObject m_mimironNegative
        {
            get
            {
                return base.method_3<GameObject>("m_mimironNegative");
            }
        }

        public GameObject m_minionElectricity
        {
            get
            {
                return base.method_3<GameObject>("m_minionElectricity");
            }
        }

        public GameObject m_minionGlow
        {
            get
            {
                return base.method_3<GameObject>("m_minionGlow");
            }
        }

        public float m_minionHighTime
        {
            get
            {
                return base.method_2<float>("m_minionHighTime");
            }
        }

        public GameObject m_minionPosBone
        {
            get
            {
                return base.method_3<GameObject>("m_minionPosBone");
            }
        }

        public string m_perMinionSound
        {
            get
            {
                return base.method_4("m_perMinionSound");
            }
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }

        public float m_sparkDelay
        {
            get
            {
                return base.method_2<float>("m_sparkDelay");
            }
        }

        public List<string> m_startSounds
        {
            get
            {
                Class245 class2 = base.method_3<Class245>("m_startSounds");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Card m_volt
        {
            get
            {
                return base.method_3<Card>("m_volt");
            }
        }

        public Transform m_voltParent
        {
            get
            {
                return base.method_3<Transform>("m_voltParent");
            }
        }

        public Spell m_voltSpawnOverrideSpell
        {
            get
            {
                return base.method_3<Spell>("m_voltSpawnOverrideSpell");
            }
        }

        public PowerTaskList m_waitForTaskList
        {
            get
            {
                return base.method_3<PowerTaskList>("m_waitForTaskList");
            }
        }
    }
}

