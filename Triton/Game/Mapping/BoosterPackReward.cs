namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BoosterPackReward")]
    public class BoosterPackReward : Reward
    {
        public BoosterPackReward(IntPtr address) : this(address, "BoosterPackReward")
        {
        }

        public BoosterPackReward(IntPtr address, string className) : base(address, className)
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

        public void OnUnopenedPackPrefabLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnUnopenedPackPrefabLoaded", objArray1);
        }

        public void ShowReward(bool updateCacheValues)
        {
            object[] objArray1 = new object[] { updateCacheValues };
            base.method_8("ShowReward", objArray1);
        }

        public void UpdatePackStacks()
        {
            base.method_8("UpdatePackStacks", Array.Empty<object>());
        }

        public GameObject m_BoosterPackBone
        {
            get
            {
                return base.method_3<GameObject>("m_BoosterPackBone");
            }
        }

        public GameLayer m_Layer
        {
            get
            {
                return base.method_2<GameLayer>("m_Layer");
            }
        }

        public UnopenedPack m_unopenedPack
        {
            get
            {
                return base.method_3<UnopenedPack>("m_unopenedPack");
            }
        }
    }
}

