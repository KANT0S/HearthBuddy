namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TGTTargetDummy")]
    public class TGTTargetDummy : MonoBehaviour
    {
        public TGTTargetDummy(IntPtr address) : this(address, "TGTTargetDummy")
        {
        }

        public TGTTargetDummy(IntPtr address, string className) : base(address, className)
        {
        }

        public void ArrowHit()
        {
            base.method_8("ArrowHit", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BodyHit()
        {
            base.method_8("BodyHit", Array.Empty<object>());
        }

        public static TGTTargetDummy Get()
        {
            return MonoClass.smethod_15<TGTTargetDummy>(TritonHs.MainAssemblyPath, "", "TGTTargetDummy", "Get", Array.Empty<object>());
        }

        public void HandleHits()
        {
            base.method_8("HandleHits", Array.Empty<object>());
        }

        public bool IsOver(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return base.method_11<bool>("IsOver", objArray1);
        }

        public void PlaySqueakSound()
        {
            base.method_8("PlaySqueakSound", Array.Empty<object>());
        }

        public void ShieldHit()
        {
            base.method_8("ShieldHit", Array.Empty<object>());
        }

        public void Spin(bool reverse)
        {
            object[] objArray1 = new object[] { reverse };
            base.method_8("Spin", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void SwordHit()
        {
            base.method_8("SwordHit", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public GameObject m_Body
        {
            get
            {
                return base.method_3<GameObject>("m_Body");
            }
        }

        public float m_BodyHitIntensity
        {
            get
            {
                return base.method_2<float>("m_BodyHitIntensity");
            }
        }

        public GameObject m_BodyMesh
        {
            get
            {
                return base.method_3<GameObject>("m_BodyMesh");
            }
        }

        public GameObject m_BodyRotX
        {
            get
            {
                return base.method_3<GameObject>("m_BodyRotX");
            }
        }

        public GameObject m_BodyRotY
        {
            get
            {
                return base.method_3<GameObject>("m_BodyRotY");
            }
        }

        public string m_HitBodySoundPrefab
        {
            get
            {
                return base.method_4("m_HitBodySoundPrefab");
            }
        }

        public string m_HitShieldSoundPrefab
        {
            get
            {
                return base.method_4("m_HitShieldSoundPrefab");
            }
        }

        public string m_HitSpinSoundPrefab
        {
            get
            {
                return base.method_4("m_HitSpinSoundPrefab");
            }
        }

        public string m_HitSwordSoundPrefab
        {
            get
            {
                return base.method_4("m_HitSwordSoundPrefab");
            }
        }

        public Quaternion m_lastFrameSqueakAngle
        {
            get
            {
                return base.method_2<Quaternion>("m_lastFrameSqueakAngle");
            }
        }

        public float m_lastSqueakSoundVol
        {
            get
            {
                return base.method_2<float>("m_lastSqueakSoundVol");
            }
        }

        public GameObject m_Shield
        {
            get
            {
                return base.method_3<GameObject>("m_Shield");
            }
        }

        public float m_ShieldHitIntensity
        {
            get
            {
                return base.method_2<float>("m_ShieldHitIntensity");
            }
        }

        public string m_SqueakSoundPrefab
        {
            get
            {
                return base.method_4("m_SqueakSoundPrefab");
            }
        }

        public float m_squeakSoundVelocity
        {
            get
            {
                return base.method_2<float>("m_squeakSoundVelocity");
            }
        }

        public GameObject m_Sword
        {
            get
            {
                return base.method_3<GameObject>("m_Sword");
            }
        }

        public float m_SwordHitIntensity
        {
            get
            {
                return base.method_2<float>("m_SwordHitIntensity");
            }
        }

        public static int SPIN_PERCENT
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "TGTTargetDummy", "SPIN_PERCENT");
            }
        }
    }
}

