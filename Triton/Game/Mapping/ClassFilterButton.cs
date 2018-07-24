namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ClassFilterButton")]
    public class ClassFilterButton : PegUIElement
    {
        public ClassFilterButton(IntPtr address) : this(address, "ClassFilterButton")
        {
        }

        public ClassFilterButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void HandleRelease()
        {
            base.method_8("HandleRelease", Array.Empty<object>());
        }

        public void SetNewCardCount(int count)
        {
            object[] objArray1 = new object[] { count };
            base.method_8("SetNewCardCount", objArray1);
        }

        public GameObject m_disabled
        {
            get
            {
                return base.method_3<GameObject>("m_disabled");
            }
        }

        public GameObject m_newCardCount
        {
            get
            {
                return base.method_3<GameObject>("m_newCardCount");
            }
        }

        public UberText m_newCardCountText
        {
            get
            {
                return base.method_3<UberText>("m_newCardCountText");
            }
        }

        public CollectionManagerDisplay.ViewMode m_tabViewMode
        {
            get
            {
                return base.method_2<CollectionManagerDisplay.ViewMode>("m_tabViewMode");
            }
        }
    }
}

