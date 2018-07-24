namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("GvG_Promotion")]
    public class GvG_Promotion : MonoBehaviour
    {
        public GvG_Promotion(IntPtr address) : this(address, "GvG_Promotion")
        {
        }

        public GvG_Promotion(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public bool m_AnimExisted
        {
            get
            {
                return base.method_2<bool>("m_AnimExisted");
            }
        }

        public GameObject m_arenaObj
        {
            get
            {
                return base.method_3<GameObject>("m_arenaObj");
            }
        }
    }
}

