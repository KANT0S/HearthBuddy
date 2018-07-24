namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CollectionCardLock")]
    public class CollectionCardLock : MonoBehaviour
    {
        public CollectionCardLock(IntPtr address) : this(address, "CollectionCardLock")
        {
        }

        public CollectionCardLock(IntPtr address, string className) : base(address, className)
        {
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void SetLockText(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("SetLockText", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateLockVisual(EntityDef entityDef, CollectionCardVisual.LockType lockType, string reason)
        {
            object[] objArray1 = new object[] { entityDef, lockType, reason };
            base.method_8("UpdateLockVisual", objArray1);
        }

        public GameObject m_allyBg
        {
            get
            {
                return base.method_3<GameObject>("m_allyBg");
            }
        }

        public GameObject m_lockPlate
        {
            get
            {
                return base.method_3<GameObject>("m_lockPlate");
            }
        }

        public GameObject m_lockPlateBone
        {
            get
            {
                return base.method_3<GameObject>("m_lockPlateBone");
            }
        }

        public UberText m_lockText
        {
            get
            {
                return base.method_3<UberText>("m_lockText");
            }
        }

        public GameObject m_spellBg
        {
            get
            {
                return base.method_3<GameObject>("m_spellBg");
            }
        }

        public GameObject m_weaponBg
        {
            get
            {
                return base.method_3<GameObject>("m_weaponBg");
            }
        }

        public GameObject m_weaponLockPlateBone
        {
            get
            {
                return base.method_3<GameObject>("m_weaponLockPlateBone");
            }
        }
    }
}

