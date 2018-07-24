namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AdventureRewardsCardback")]
    public class AdventureRewardsCardback : MonoBehaviour
    {
        public AdventureRewardsCardback(IntPtr address) : this(address, "AdventureRewardsCardback")
        {
        }

        public AdventureRewardsCardback(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void HideCardBackReward()
        {
            base.method_8("HideCardBackReward", Array.Empty<object>());
        }

        public void LoadCardBackWithId()
        {
            base.method_8("LoadCardBackWithId", Array.Empty<object>());
        }

        public void ShowCardBackReward()
        {
            base.method_8("ShowCardBackReward", Array.Empty<object>());
        }

        public string m_cardBackAppearAnimationName
        {
            get
            {
                return base.method_4("m_cardBackAppearAnimationName");
            }
        }

        public float m_cardBackAppearDelay
        {
            get
            {
                return base.method_2<float>("m_cardBackAppearDelay");
            }
        }

        public string m_cardBackAppearSound
        {
            get
            {
                return base.method_4("m_cardBackAppearSound");
            }
        }

        public float m_cardBackAppearTime
        {
            get
            {
                return base.method_2<float>("m_cardBackAppearTime");
            }
        }

        public GameObject m_cardBackContainer
        {
            get
            {
                return base.method_3<GameObject>("m_cardBackContainer");
            }
        }

        public int m_cardBackId
        {
            get
            {
                return base.method_2<int>("m_cardBackId");
            }
        }

        public GameObject m_cardBackObject
        {
            get
            {
                return base.method_3<GameObject>("m_cardBackObject");
            }
        }

        public bool m_cardBackObjectLoading
        {
            get
            {
                return base.method_2<bool>("m_cardBackObjectLoading");
            }
        }

        public UberText m_cardBackText
        {
            get
            {
                return base.method_3<UberText>("m_cardBackText");
            }
        }

        public Vector3 m_cardBackTextOrigScale
        {
            get
            {
                return base.method_2<Vector3>("m_cardBackTextOrigScale");
            }
        }

        public float m_driftRadius
        {
            get
            {
                return base.method_2<float>("m_driftRadius");
            }
        }

        public float m_driftTime
        {
            get
            {
                return base.method_2<float>("m_driftTime");
            }
        }

        public GeneralStoreAdventureContent m_parentContent
        {
            get
            {
                return base.method_3<GeneralStoreAdventureContent>("m_parentContent");
            }
        }
    }
}

