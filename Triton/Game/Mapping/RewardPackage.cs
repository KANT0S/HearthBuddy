namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("RewardPackage")]
    public class RewardPackage : PegUIElement
    {
        public RewardPackage(IntPtr address) : this(address, "RewardPackage")
        {
        }

        public RewardPackage(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void OnOver(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOver", objArray1);
        }

        public void OnPress()
        {
            base.method_8("OnPress", Array.Empty<object>());
        }

        public void OpenReward()
        {
            base.method_8("OpenReward", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public int m_RewardIndex
        {
            get
            {
                return base.method_2<int>("m_RewardIndex");
            }
        }
    }
}

