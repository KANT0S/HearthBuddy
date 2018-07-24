namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("TGTArcheryTarget")]
    public class TGTArcheryTarget : MonoBehaviour
    {
        public TGTArcheryTarget(IntPtr address) : this(address, "TGTArcheryTarget")
        {
        }

        public TGTArcheryTarget(IntPtr address, string className) : base(address, className)
        {
        }

        public void FireArrow(TGTArrow arrow, Vector3 hitPosition, bool bullseye)
        {
            object[] objArray1 = new object[] { arrow, hitPosition, bullseye };
            base.method_8("FireArrow", objArray1);
        }

        public void HandleHits()
        {
            base.method_8("HandleHits", Array.Empty<object>());
        }

        public void HitTargetDummy()
        {
            base.method_8("HitTargetDummy", Array.Empty<object>());
        }

        public void HnadleFireArrow()
        {
            base.method_8("HnadleFireArrow", Array.Empty<object>());
        }

        public void ImpactTarget()
        {
            base.method_8("ImpactTarget", Array.Empty<object>());
        }

        public bool IsOver(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return base.method_11<bool>("IsOver", objArray1);
        }

        public void PlaySound(string soundPrefab)
        {
            object[] objArray1 = new object[] { soundPrefab };
            base.method_8("PlaySound", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public GameObject m_Arrow
        {
            get
            {
                return base.method_3<GameObject>("m_Arrow");
            }
        }

        public GameObject m_ArrowBone01
        {
            get
            {
                return base.method_3<GameObject>("m_ArrowBone01");
            }
        }

        public GameObject m_ArrowBone02
        {
            get
            {
                return base.method_3<GameObject>("m_ArrowBone02");
            }
        }

        public int m_ArrowCount
        {
            get
            {
                return base.method_2<int>("m_ArrowCount");
            }
        }

        public List<GameObject> m_arrows
        {
            get
            {
                Class247<GameObject> class2 = base.method_3<Class247<GameObject>>("m_arrows");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<int> m_AvailableTargetDummyArrows
        {
            get
            {
                Class266<int> class2 = base.method_3<Class266<int>>("m_AvailableTargetDummyArrows");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public BoxCollider m_BoxCollider01
        {
            get
            {
                return base.method_3<BoxCollider>("m_BoxCollider01");
            }
        }

        public BoxCollider m_BoxCollider02
        {
            get
            {
                return base.method_3<BoxCollider>("m_BoxCollider02");
            }
        }

        public BoxCollider m_BoxColliderBullseye
        {
            get
            {
                return base.method_3<BoxCollider>("m_BoxColliderBullseye");
            }
        }

        public Transform m_BullseyeCenterBone
        {
            get
            {
                return base.method_3<Transform>("m_BullseyeCenterBone");
            }
        }

        public int m_BullseyePercent
        {
            get
            {
                return base.method_2<int>("m_BullseyePercent");
            }
        }

        public float m_bullseyeRadius
        {
            get
            {
                return base.method_2<float>("m_bullseyeRadius");
            }
        }

        public Transform m_BullseyeRadiusBone
        {
            get
            {
                return base.method_3<Transform>("m_BullseyeRadiusBone");
            }
        }

        public Transform m_CenterBone
        {
            get
            {
                return base.method_3<Transform>("m_CenterBone");
            }
        }

        public bool m_clearingArrows
        {
            get
            {
                return base.method_2<bool>("m_clearingArrows");
            }
        }

        public GameObject m_Collider01
        {
            get
            {
                return base.method_3<GameObject>("m_Collider01");
            }
        }

        public string m_HitBullseyeSoundPrefab
        {
            get
            {
                return base.method_4("m_HitBullseyeSoundPrefab");
            }
        }

        public float m_HitIntensity
        {
            get
            {
                return base.method_2<float>("m_HitIntensity");
            }
        }

        public string m_HitTargetDummySoundPrefab
        {
            get
            {
                return base.method_4("m_HitTargetDummySoundPrefab");
            }
        }

        public string m_HitTargetSoundPrefab
        {
            get
            {
                return base.method_4("m_HitTargetSoundPrefab");
            }
        }

        public int m_lastArrow
        {
            get
            {
                return base.method_2<int>("m_lastArrow");
            }
        }

        public bool m_lastArrowWasBullseye
        {
            get
            {
                return base.method_2<bool>("m_lastArrowWasBullseye");
            }
        }

        public GameObject m_lastBullseyeArrow
        {
            get
            {
                return base.method_3<GameObject>("m_lastBullseyeArrow");
            }
        }

        public float m_lastClickTime
        {
            get
            {
                return base.method_2<float>("m_lastClickTime");
            }
        }

        public int m_Levelup
        {
            get
            {
                return base.method_2<int>("m_Levelup");
            }
        }

        public int m_MaxArrows
        {
            get
            {
                return base.method_2<int>("m_MaxArrows");
            }
        }

        public float m_MaxRandomOffset
        {
            get
            {
                return base.method_2<float>("m_MaxRandomOffset");
            }
        }

        public Transform m_OuterRadiusBone
        {
            get
            {
                return base.method_3<Transform>("m_OuterRadiusBone");
            }
        }

        public string m_RemoveArrowSoundPrefab
        {
            get
            {
                return base.method_4("m_RemoveArrowSoundPrefab");
            }
        }

        public GameObject m_SplitArrow
        {
            get
            {
                return base.method_3<GameObject>("m_SplitArrow");
            }
        }

        public string m_SplitArrowSoundPrefab
        {
            get
            {
                return base.method_4("m_SplitArrowSoundPrefab");
            }
        }

        public List<TGTArrow> m_TargetDummyArrows
        {
            get
            {
                Class267<TGTArrow> class2 = base.method_3<Class267<TGTArrow>>("m_TargetDummyArrows");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_TargetDummyPercent
        {
            get
            {
                return base.method_2<int>("m_TargetDummyPercent");
            }
        }

        public GameObject m_TargetPhysics
        {
            get
            {
                return base.method_3<GameObject>("m_TargetPhysics");
            }
        }

        public float m_targetRadius
        {
            get
            {
                return base.method_2<float>("m_targetRadius");
            }
        }

        public GameObject m_TargetRoot
        {
            get
            {
                return base.method_3<GameObject>("m_TargetRoot");
            }
        }
    }
}

