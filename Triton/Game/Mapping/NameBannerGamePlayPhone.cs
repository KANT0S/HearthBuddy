namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("NameBannerGamePlayPhone")]
    public class NameBannerGamePlayPhone : MonoBehaviour
    {
        public NameBannerGamePlayPhone(IntPtr address) : this(address, "NameBannerGamePlayPhone")
        {
        }

        public NameBannerGamePlayPhone(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void FadeIn()
        {
            base.method_8("FadeIn", Array.Empty<object>());
        }

        public Player.Side GetPlayerSide()
        {
            return base.method_11<Player.Side>("GetPlayerSide", Array.Empty<object>());
        }

        public bool IsReady(Player p)
        {
            object[] objArray1 = new object[] { p };
            return base.method_11<bool>("IsReady", objArray1);
        }

        public void SetName(string name)
        {
            object[] objArray1 = new object[] { name };
            base.method_8("SetName", objArray1);
        }

        public void SetPlayerSide(Player.Side side)
        {
            object[] objArray1 = new object[] { side };
            base.method_8("SetPlayerSide", objArray1);
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateAnchor()
        {
            base.method_8("UpdateAnchor", Array.Empty<object>());
        }

        public float FUDGE_FACTOR
        {
            get
            {
                return base.method_2<float>("FUDGE_FACTOR");
            }
        }

        public GameObject m_alphaBanner
        {
            get
            {
                return base.method_3<GameObject>("m_alphaBanner");
            }
        }

        public GameObject m_alphaBannerMiddle
        {
            get
            {
                return base.method_3<GameObject>("m_alphaBannerMiddle");
            }
        }

        public Transform m_nameBone
        {
            get
            {
                return base.method_3<Transform>("m_nameBone");
            }
        }

        public Transform m_nameBoneToUse
        {
            get
            {
                return base.method_3<Transform>("m_nameBoneToUse");
            }
        }

        public UberText m_playerName
        {
            get
            {
                return base.method_3<UberText>("m_playerName");
            }
        }

        public Player.Side m_playerSide
        {
            get
            {
                return base.method_2<Player.Side>("m_playerSide");
            }
        }

        public static float UNKNOWN_NAME_WAIT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "NameBannerGamePlayPhone", "UNKNOWN_NAME_WAIT");
            }
        }
    }
}

