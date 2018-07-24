namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("QuestProgressToast")]
    public class QuestProgressToast : GameToast
    {
        public QuestProgressToast(IntPtr address) : this(address, "QuestProgressToast")
        {
        }

        public QuestProgressToast(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void UpdateDisplay(string title, string description, int progress, int maxProgress)
        {
            object[] objArray1 = new object[] { title, description, progress, maxProgress };
            base.method_8("UpdateDisplay", objArray1);
        }

        public GameObject m_background
        {
            get
            {
                return base.method_3<GameObject>("m_background");
            }
        }

        public UberText m_questDescription
        {
            get
            {
                return base.method_3<UberText>("m_questDescription");
            }
        }

        public UberText m_questProgressCount
        {
            get
            {
                return base.method_3<UberText>("m_questProgressCount");
            }
        }

        public GameObject m_questProgressCountBg
        {
            get
            {
                return base.method_3<GameObject>("m_questProgressCountBg");
            }
        }

        public UberText m_questTitle
        {
            get
            {
                return base.method_3<UberText>("m_questTitle");
            }
        }
    }
}

