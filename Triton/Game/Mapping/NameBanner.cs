namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("NameBanner")]
    public class NameBanner : MonoBehaviour
    {
        public NameBanner(IntPtr address) : this(address, "NameBanner")
        {
        }

        public NameBanner(IntPtr address, string className) : base(address, className)
        {
        }

        public void AdjustBanner()
        {
            base.method_8("AdjustBanner", Array.Empty<object>());
        }

        public void AdjustSkinnedBanner()
        {
            base.method_8("AdjustSkinnedBanner", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void FadeClass()
        {
            base.method_8("FadeClass", Array.Empty<object>());
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

        public void SetClass(string className, bool isAI)
        {
            object[] objArray1 = new object[] { className, isAI };
            base.method_8("SetClass", objArray1);
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

        public void UpdateMedalChange(MedalInfoTranslator medalInfo)
        {
            object[] objArray1 = new object[] { medalInfo };
            base.method_8("UpdateMedalChange", objArray1);
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

        public GameObject m_alphaBannerBone
        {
            get
            {
                return base.method_3<GameObject>("m_alphaBannerBone");
            }
        }

        public GameObject m_alphaBannerLeft
        {
            get
            {
                return base.method_3<GameObject>("m_alphaBannerLeft");
            }
        }

        public GameObject m_alphaBannerMiddle
        {
            get
            {
                return base.method_3<GameObject>("m_alphaBannerMiddle");
            }
        }

        public GameObject m_alphaBannerRight
        {
            get
            {
                return base.method_3<GameObject>("m_alphaBannerRight");
            }
        }

        public GameObject m_alphaBannerSkinned
        {
            get
            {
                return base.method_3<GameObject>("m_alphaBannerSkinned");
            }
        }

        public Transform m_classBone
        {
            get
            {
                return base.method_3<Transform>("m_classBone");
            }
        }

        public Transform m_classBoneToUse
        {
            get
            {
                return base.method_3<Transform>("m_classBoneToUse");
            }
        }

        public UberText m_className
        {
            get
            {
                return base.method_3<UberText>("m_className");
            }
        }

        public TournamentMedal m_medal
        {
            get
            {
                return base.method_3<TournamentMedal>("m_medal");
            }
        }

        public GameObject m_medalAlphaBanner
        {
            get
            {
                return base.method_3<GameObject>("m_medalAlphaBanner");
            }
        }

        public GameObject m_medalAlphaBannerLeft
        {
            get
            {
                return base.method_3<GameObject>("m_medalAlphaBannerLeft");
            }
        }

        public GameObject m_medalAlphaBannerMiddle
        {
            get
            {
                return base.method_3<GameObject>("m_medalAlphaBannerMiddle");
            }
        }

        public GameObject m_medalAlphaBannerRight
        {
            get
            {
                return base.method_3<GameObject>("m_medalAlphaBannerRight");
            }
        }

        public GameObject m_medalBannerBone
        {
            get
            {
                return base.method_3<GameObject>("m_medalBannerBone");
            }
        }

        public GameObject m_medalBannerSkinned
        {
            get
            {
                return base.method_3<GameObject>("m_medalBannerSkinned");
            }
        }

        public Transform m_medalClassBone
        {
            get
            {
                return base.method_3<Transform>("m_medalClassBone");
            }
        }

        public Transform m_medalNameBone
        {
            get
            {
                return base.method_3<Transform>("m_medalNameBone");
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

        public static float SKINNED_BANNER_MIN_SIZE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "NameBanner", "SKINNED_BANNER_MIN_SIZE");
            }
        }

        public static float SKINNED_MEDAL_BANNER_MIN_SIZE
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "NameBanner", "SKINNED_MEDAL_BANNER_MIN_SIZE");
            }
        }

        public static float UNKNOWN_NAME_WAIT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "NameBanner", "UNKNOWN_NAME_WAIT");
            }
        }
    }
}

