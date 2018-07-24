namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AdventureClassChallengeChestButton")]
    public class AdventureClassChallengeChestButton : PegUIElement
    {
        public AdventureClassChallengeChestButton(IntPtr address) : this(address, "AdventureClassChallengeChestButton")
        {
        }

        public AdventureClassChallengeChestButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Depress()
        {
            base.method_8("Depress", Array.Empty<object>());
        }

        public void EffectFadeOutFinished()
        {
            base.method_8("EffectFadeOutFinished", Array.Empty<object>());
        }

        public void HideRewardCard()
        {
            base.method_8("HideRewardCard", Array.Empty<object>());
        }

        public void OnOut(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOut", objArray1);
        }

        public void OnOver(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOver", objArray1);
        }

        public void Press()
        {
            base.method_8("Press", Array.Empty<object>());
        }

        public void Raise()
        {
            base.method_8("Raise", Array.Empty<object>());
        }

        public void Release()
        {
            base.method_8("Release", Array.Empty<object>());
        }

        public void ShowHighlight(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowHighlight", objArray1);
        }

        public Transform m_DownBone
        {
            get
            {
                return base.method_3<Transform>("m_DownBone");
            }
        }

        public GameObject m_HighlightPlane
        {
            get
            {
                return base.method_3<GameObject>("m_HighlightPlane");
            }
        }

        public bool m_IsRewardLoading
        {
            get
            {
                return base.method_2<bool>("m_IsRewardLoading");
            }
        }

        public GameObject m_RewardBone
        {
            get
            {
                return base.method_3<GameObject>("m_RewardBone");
            }
        }

        public GameObject m_RewardCard
        {
            get
            {
                return base.method_3<GameObject>("m_RewardCard");
            }
        }

        public GameObject m_RootObject
        {
            get
            {
                return base.method_3<GameObject>("m_RootObject");
            }
        }

        public Transform m_UpBone
        {
            get
            {
                return base.method_3<Transform>("m_UpBone");
            }
        }
    }
}

