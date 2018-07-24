namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RewardCardBack")]
    public class RewardCardBack : MonoBehaviour
    {
        public RewardCardBack(IntPtr address) : this(address, "RewardCardBack")
        {
        }

        public RewardCardBack(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Death()
        {
            base.method_8("Death", Array.Empty<object>());
        }

        public bool IsReady()
        {
            return base.method_11<bool>("IsReady", Array.Empty<object>());
        }

        public void LoadCardBack(CardBackRewardData cardbackData, GameLayer layer)
        {
            object[] objArray1 = new object[] { cardbackData, layer };
            base.method_8("LoadCardBack", objArray1);
        }

        public void OnCardBackLoaded(CardBackManager.LoadCardBackData cardbackData)
        {
            object[] objArray1 = new object[] { cardbackData };
            base.method_8("OnCardBackLoaded", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public Actor m_actor
        {
            get
            {
                return base.method_3<Actor>("m_actor");
            }
        }

        public GameObject m_cardbackBone
        {
            get
            {
                return base.method_3<GameObject>("m_cardbackBone");
            }
        }

        public int m_CardBackID
        {
            get
            {
                return base.method_2<int>("m_CardBackID");
            }
        }

        public UberText m_cardbackName
        {
            get
            {
                return base.method_3<UberText>("m_cardbackName");
            }
        }

        public UberText m_cardbackTitle
        {
            get
            {
                return base.method_3<UberText>("m_cardbackTitle");
            }
        }

        public GameLayer m_layer
        {
            get
            {
                return base.method_2<GameLayer>("m_layer");
            }
        }

        public bool m_Ready
        {
            get
            {
                return base.method_2<bool>("m_Ready");
            }
        }
    }
}

