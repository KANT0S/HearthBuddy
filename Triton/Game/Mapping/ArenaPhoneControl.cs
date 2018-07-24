namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ArenaPhoneControl")]
    public class ArenaPhoneControl : MonoBehaviour
    {
        public ArenaPhoneControl(IntPtr address) : this(address, "ArenaPhoneControl")
        {
        }

        public ArenaPhoneControl(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void RotateTo(float rotFrom, float rotTo)
        {
            object[] objArray1 = new object[] { rotFrom, rotTo };
            base.method_8("RotateTo", objArray1);
        }

        public void SetMode(ControlMode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("SetMode", objArray1);
        }

        public void SetModeCardCountViewDeck()
        {
            base.method_8("SetModeCardCountViewDeck", Array.Empty<object>());
        }

        public void SetModeChooseCard()
        {
            base.method_8("SetModeChooseCard", Array.Empty<object>());
        }

        public void SetModeChooseHero()
        {
            base.method_8("SetModeChooseHero", Array.Empty<object>());
        }

        public void SetModeViewDeck()
        {
            base.method_8("SetModeViewDeck", Array.Empty<object>());
        }

        public BoxCollider m_ButtonCollider
        {
            get
            {
                return base.method_3<BoxCollider>("m_ButtonCollider");
            }
        }

        public UberText m_ChooseText
        {
            get
            {
                return base.method_3<UberText>("m_ChooseText");
            }
        }

        public Vector3 m_CountAndViewDeckCollCenter
        {
            get
            {
                return base.method_2<Vector3>("m_CountAndViewDeckCollCenter");
            }
        }

        public Vector3 m_CountAndViewDeckCollSize
        {
            get
            {
                return base.method_2<Vector3>("m_CountAndViewDeckCollSize");
            }
        }

        public ControlMode m_CurrentMode
        {
            get
            {
                return base.method_2<ControlMode>("m_CurrentMode");
            }
        }

        public GameObject m_ViewDeckButton
        {
            get
            {
                return base.method_3<GameObject>("m_ViewDeckButton");
            }
        }

        public Vector3 m_ViewDeckCollCenter
        {
            get
            {
                return base.method_2<Vector3>("m_ViewDeckCollCenter");
            }
        }

        public Vector3 m_ViewDeckCollSize
        {
            get
            {
                return base.method_2<Vector3>("m_ViewDeckCollSize");
            }
        }

        public enum ControlMode
        {
            ChooseHero,
            ChooseCard,
            CardCountViewDeck,
            ViewDeck,
            Rewards
        }
    }
}

