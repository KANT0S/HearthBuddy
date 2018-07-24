namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ManaCounter")]
    public class ManaCounter : MonoBehaviour
    {
        public ManaCounter(IntPtr address) : this(address, "ManaCounter")
        {
        }

        public ManaCounter(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public GameObject GetPhoneGem()
        {
            return base.method_14<GameObject>("GetPhoneGem", Array.Empty<object>());
        }

        public Player GetPlayer()
        {
            return base.method_14<Player>("GetPlayer", Array.Empty<object>());
        }

        public void SetPlayer(Player player)
        {
            object[] objArray1 = new object[] { player };
            base.method_8("SetPlayer", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateText()
        {
            base.method_8("UpdateText", Array.Empty<object>());
        }

        public UberText m_availableManaPhone
        {
            get
            {
                return base.method_3<UberText>("m_availableManaPhone");
            }
        }

        public UberText m_permanentManaPhone
        {
            get
            {
                return base.method_3<UberText>("m_permanentManaPhone");
            }
        }

        public GameObject m_phoneGem
        {
            get
            {
                return base.method_3<GameObject>("m_phoneGem");
            }
        }

        public GameObject m_phoneGemContainer
        {
            get
            {
                return base.method_3<GameObject>("m_phoneGemContainer");
            }
        }

        public Player m_player
        {
            get
            {
                return base.method_3<Player>("m_player");
            }
        }

        public Player.Side m_Side
        {
            get
            {
                return base.method_2<Player.Side>("m_Side");
            }
        }

        public UberText m_textMesh
        {
            get
            {
                return base.method_3<UberText>("m_textMesh");
            }
        }
    }
}

