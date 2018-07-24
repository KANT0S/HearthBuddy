namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardBackReward")]
    public class CardBackReward : Reward
    {
        public CardBackReward(IntPtr address) : this(address, "CardBackReward")
        {
        }

        public CardBackReward(IntPtr address, string className) : base(address, className)
        {
        }

        public void HideReward()
        {
            base.method_8("HideReward", Array.Empty<object>());
        }

        public void InitData()
        {
            base.method_8("InitData", Array.Empty<object>());
        }

        public void OnBackCardBackLoaded(CardBackManager.LoadCardBackData cardbackData)
        {
            object[] objArray1 = new object[] { cardbackData };
            base.method_8("OnBackCardBackLoaded", objArray1);
        }

        public void OnDataSet(bool updateVisuals)
        {
            object[] objArray1 = new object[] { updateVisuals };
            base.method_8("OnDataSet", objArray1);
        }

        public void OnFrontCardBackLoaded(CardBackManager.LoadCardBackData cardbackData)
        {
            object[] objArray1 = new object[] { cardbackData };
            base.method_8("OnFrontCardBackLoaded", objArray1);
        }

        public void ShowReward(bool updateCacheValues)
        {
            object[] objArray1 = new object[] { updateCacheValues };
            base.method_8("ShowReward", objArray1);
        }

        public GameObject m_cardbackBone
        {
            get
            {
                return base.method_3<GameObject>("m_cardbackBone");
            }
        }

        public int m_numCardBacksLoaded
        {
            get
            {
                return base.method_2<int>("m_numCardBacksLoaded");
            }
        }
    }
}

