namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("QuestTile")]
    public class QuestTile : MonoBehaviour
    {
        public QuestTile(IntPtr address) : this(address, "QuestTile")
        {
        }

        public QuestTile(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public int GetQuestID()
        {
            return base.method_11<int>("GetQuestID", Array.Empty<object>());
        }

        public void LoadCenterImage()
        {
            base.method_8("LoadCenterImage", Array.Empty<object>());
        }

        public void OnCancelButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCancelButtonReleased", objArray1);
        }

        public void PlayBirth()
        {
            base.method_8("PlayBirth", Array.Empty<object>());
        }

        public void SetCanShowCancelButton(bool canShowCancel)
        {
            object[] objArray1 = new object[] { canShowCancel };
            base.method_8("SetCanShowCancelButton", objArray1);
        }

        public void SetupTile(Achievement quest)
        {
            object[] objArray1 = new object[] { quest };
            base.method_8("SetupTile", objArray1);
        }

        public void UpdateCancelButtonVisibility()
        {
            base.method_8("UpdateCancelButtonVisibility", Array.Empty<object>());
        }

        public NormalButton m_cancelButton
        {
            get
            {
                return base.method_3<NormalButton>("m_cancelButton");
            }
        }

        public GameObject m_cancelButtonRoot
        {
            get
            {
                return base.method_3<GameObject>("m_cancelButtonRoot");
            }
        }

        public bool m_canShowCancelButton
        {
            get
            {
                return base.method_2<bool>("m_canShowCancelButton");
            }
        }

        public GameObject m_defaultBone
        {
            get
            {
                return base.method_3<GameObject>("m_defaultBone");
            }
        }

        public UberText m_goldAmount
        {
            get
            {
                return base.method_3<UberText>("m_goldAmount");
            }
        }

        public GameObject m_nameLine
        {
            get
            {
                return base.method_3<GameObject>("m_nameLine");
            }
        }

        public float m_nameLinePadding
        {
            get
            {
                return base.method_2<float>("m_nameLinePadding");
            }
        }

        public GameObject m_progress
        {
            get
            {
                return base.method_3<GameObject>("m_progress");
            }
        }

        public UberText m_progressText
        {
            get
            {
                return base.method_3<UberText>("m_progressText");
            }
        }

        public Achievement m_quest
        {
            get
            {
                return base.method_3<Achievement>("m_quest");
            }
        }

        public UberText m_questName
        {
            get
            {
                return base.method_3<UberText>("m_questName");
            }
        }

        public UberText m_requirement
        {
            get
            {
                return base.method_3<UberText>("m_requirement");
            }
        }

        public GameObject m_rewardIcon
        {
            get
            {
                return base.method_3<GameObject>("m_rewardIcon");
            }
        }
    }
}

