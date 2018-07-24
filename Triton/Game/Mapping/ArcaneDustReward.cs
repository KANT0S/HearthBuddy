namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ArcaneDustReward")]
    public class ArcaneDustReward : Reward
    {
        public ArcaneDustReward(IntPtr address) : this(address, "ArcaneDustReward")
        {
        }

        public ArcaneDustReward(IntPtr address, string className) : base(address, className)
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

        public UberText m_dustCount
        {
            get
            {
                return base.method_3<UberText>("m_dustCount");
            }
        }

        public GameObject m_dustJar
        {
            get
            {
                return base.method_3<GameObject>("m_dustJar");
            }
        }
    }
}

