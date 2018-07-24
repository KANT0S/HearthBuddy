namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GoldReward")]
    public class GoldReward : Reward
    {
        public GoldReward(IntPtr address) : this(address, "GoldReward")
        {
        }

        public GoldReward(IntPtr address, string className) : base(address, className)
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

        public void OnDataSet(bool updateVisuals)
        {
            object[] objArray1 = new object[] { updateVisuals };
            base.method_8("OnDataSet", objArray1);
        }

        public void ShowReward(bool updateCacheValues)
        {
            object[] objArray1 = new object[] { updateCacheValues };
            base.method_8("ShowReward", objArray1);
        }

        public GameObject m_coin
        {
            get
            {
                return base.method_3<GameObject>("m_coin");
            }
        }
    }
}

