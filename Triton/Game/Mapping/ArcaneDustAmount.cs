namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ArcaneDustAmount")]
    public class ArcaneDustAmount : MonoBehaviour
    {
        public ArcaneDustAmount(IntPtr address) : this(address, "ArcaneDustAmount")
        {
        }

        public ArcaneDustAmount(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static ArcaneDustAmount Get()
        {
            return MonoClass.smethod_15<ArcaneDustAmount>(TritonHs.MainAssemblyPath, "", "ArcaneDustAmount", "Get", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateCurrentDustAmount()
        {
            base.method_8("UpdateCurrentDustAmount", Array.Empty<object>());
        }

        public UberText m_dustCount
        {
            get
            {
                return base.method_3<UberText>("m_dustCount");
            }
        }

        public GameObject m_dustFX
        {
            get
            {
                return base.method_3<GameObject>("m_dustFX");
            }
        }

        public GameObject m_dustJar
        {
            get
            {
                return base.method_3<GameObject>("m_dustJar");
            }
        }

        public GameObject m_explodeFX_Common
        {
            get
            {
                return base.method_3<GameObject>("m_explodeFX_Common");
            }
        }

        public GameObject m_explodeFX_Epic
        {
            get
            {
                return base.method_3<GameObject>("m_explodeFX_Epic");
            }
        }

        public GameObject m_explodeFX_Legendary
        {
            get
            {
                return base.method_3<GameObject>("m_explodeFX_Legendary");
            }
        }

        public GameObject m_explodeFX_Rare
        {
            get
            {
                return base.method_3<GameObject>("m_explodeFX_Rare");
            }
        }
    }
}

