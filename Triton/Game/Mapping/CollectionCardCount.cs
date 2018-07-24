namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CollectionCardCount")]
    public class CollectionCardCount : MonoBehaviour
    {
        public CollectionCardCount(IntPtr address) : this(address, "CollectionCardCount")
        {
        }

        public CollectionCardCount(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public int GetCount()
        {
            return base.method_11<int>("GetCount", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void SetCount(int cardCount)
        {
            object[] objArray1 = new object[] { cardCount };
            base.method_8("SetCount", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateVisibility()
        {
            base.method_8("UpdateVisibility", Array.Empty<object>());
        }

        public GameObject m_border
        {
            get
            {
                return base.method_3<GameObject>("m_border");
            }
        }

        public int m_count
        {
            get
            {
                return base.method_2<int>("m_count");
            }
        }

        public UberText m_countText
        {
            get
            {
                return base.method_3<UberText>("m_countText");
            }
        }

        public GameObject m_wideBorder
        {
            get
            {
                return base.method_3<GameObject>("m_wideBorder");
            }
        }
    }
}

