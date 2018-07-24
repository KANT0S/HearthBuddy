namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("MobileFriendListItem")]
    public class MobileFriendListItem : MonoBehaviour
    {
        public MobileFriendListItem(IntPtr address) : this(address, "MobileFriendListItem")
        {
        }

        public MobileFriendListItem(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public Bounds ComputeWorldBounds()
        {
            return base.method_11<Bounds>("ComputeWorldBounds", Array.Empty<object>());
        }

        public bool IsSelected()
        {
            return base.method_11<bool>("IsSelected", Array.Empty<object>());
        }

        public void Selected()
        {
            base.method_8("Selected", Array.Empty<object>());
        }

        public void SetShowObject(GameObject showobj)
        {
            object[] objArray1 = new object[] { showobj };
            base.method_8("SetShowObject", objArray1);
        }

        public void Unselected()
        {
            base.method_8("Unselected", Array.Empty<object>());
        }

        public bool IsHeader
        {
            get
            {
                return base.method_11<bool>("get_IsHeader", Array.Empty<object>());
            }
        }

        public Bounds LocalBounds
        {
            get
            {
                return base.method_11<Bounds>("get_LocalBounds", Array.Empty<object>());
            }
        }

        public Bounds m_localBounds
        {
            get
            {
                return base.method_2<Bounds>("m_localBounds");
            }
        }

        public GameObject m_showObject
        {
            get
            {
                return base.method_3<GameObject>("m_showObject");
            }
        }

        public bool Selectable
        {
            get
            {
                return base.method_11<bool>("get_Selectable", Array.Empty<object>());
            }
        }

        public TypeFlags Type
        {
            get
            {
                return base.method_11<TypeFlags>("get_Type", Array.Empty<object>());
            }
        }

        public bool Visible
        {
            get
            {
                return base.method_11<bool>("get_Visible", Array.Empty<object>());
            }
        }

        public enum TypeFlags
        {
            CurrentGame = 0x20,
            Friend = 0x10,
            Header = 1,
            NearbyPlayer = 0x40,
            Recruit = 8,
            Request = 0x80
        }
    }
}

