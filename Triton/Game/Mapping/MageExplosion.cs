namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MageExplosion")]
    public class MageExplosion : MonoBehaviour
    {
        public MageExplosion(IntPtr address) : this(address, "MageExplosion")
        {
        }

        public MageExplosion(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void KillExplosion()
        {
            base.method_8("KillExplosion", Array.Empty<object>());
        }

        public void Play()
        {
            base.method_8("Play", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public GameObject m_ring
        {
            get
            {
                return base.method_3<GameObject>("m_ring");
            }
        }
    }
}

