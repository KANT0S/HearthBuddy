namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("FeignDeath")]
    public class FeignDeath : SuperSpell
    {
        public FeignDeath(IntPtr address) : this(address, "FeignDeath")
        {
        }

        public FeignDeath(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public GameObject m_Glow
        {
            get
            {
                return base.method_3<GameObject>("m_Glow");
            }
        }

        public float m_Height
        {
            get
            {
                return base.method_2<float>("m_Height");
            }
        }

        public GameObject m_RootObject
        {
            get
            {
                return base.method_3<GameObject>("m_RootObject");
            }
        }
    }
}

