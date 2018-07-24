namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("QuestLog")]
    public class QuestLog : UIBPopup
    {
        public QuestLog(IntPtr address) : this(address, "QuestLog")
        {
        }

        public QuestLog(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddCurrentQuestTile(Achievement achieveQuest, int slot)
        {
            object[] objArray1 = new object[] { achieveQuest, slot };
            base.method_8("AddCurrentQuestTile", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DeleteQuests()
        {
            base.method_8("DeleteQuests", Array.Empty<object>());
        }

        public static QuestLog Get()
        {
            return MonoClass.smethod_15<QuestLog>(TritonHs.MainAssemblyPath, "", "QuestLog", "Get", Array.Empty<object>());
        }

        public void Hide(bool animate)
        {
            object[] objArray1 = new object[] { animate };
            base.method_8("Hide", objArray1);
        }

        public void OnActiveAchievesUpdated(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnActiveAchievesUpdated", objArray1);
        }

        public void OnCloseButtonReleased(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCloseButtonReleased", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public bool OnNavigateBack()
        {
            return base.method_11<bool>("OnNavigateBack", Array.Empty<object>());
        }

        public void OnQuestCanceled(int achieveID, bool canceled, object userData)
        {
            object[] objArray1 = new object[] { achieveID, canceled, userData };
            base.method_8("OnQuestCanceled", objArray1);
        }

        public void OnQuestLogCloseEvent(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnQuestLogCloseEvent", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UpdateActiveQuests()
        {
            base.method_8("UpdateActiveQuests", Array.Empty<object>());
        }

        public void UpdateBestArenaMedal()
        {
            base.method_8("UpdateBestArenaMedal", Array.Empty<object>());
        }

        public void UpdateClassProgress()
        {
            base.method_8("UpdateClassProgress", Array.Empty<object>());
        }

        public void UpdateCurrentMedal()
        {
            base.method_8("UpdateCurrentMedal", Array.Empty<object>());
        }

        public void UpdateData()
        {
            base.method_8("UpdateData", Array.Empty<object>());
        }

        public void UpdateTotalWins()
        {
            base.method_8("UpdateTotalWins", Array.Empty<object>());
        }

        public ArenaMedal m_arenaMedal
        {
            get
            {
                return base.method_3<ArenaMedal>("m_arenaMedal");
            }
        }

        public Transform m_arenaMedalBone
        {
            get
            {
                return base.method_3<Transform>("m_arenaMedalBone");
            }
        }

        public ArenaMedal m_arenaMedalPrefab
        {
            get
            {
                return base.method_3<ArenaMedal>("m_arenaMedalPrefab");
            }
        }

        public List<ClassProgressBar> m_classProgressBars
        {
            get
            {
                Class267<ClassProgressBar> class2 = base.method_3<Class267<ClassProgressBar>>("m_classProgressBars");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<ClassProgressInfo> m_classProgressInfos
        {
            get
            {
                Class267<ClassProgressInfo> class2 = base.method_3<Class267<ClassProgressInfo>>("m_classProgressInfos");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public ClassProgressBar m_classProgressPrefab
        {
            get
            {
                return base.method_3<ClassProgressBar>("m_classProgressPrefab");
            }
        }

        public UIBButton m_closeButton
        {
            get
            {
                return base.method_3<UIBButton>("m_closeButton");
            }
        }

        public TournamentMedal m_currentMedal
        {
            get
            {
                return base.method_3<TournamentMedal>("m_currentMedal");
            }
        }

        public List<QuestTile> m_currentQuests
        {
            get
            {
                Class267<QuestTile> class2 = base.method_3<Class267<QuestTile>>("m_currentQuests");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public UberText m_forgeRecordCountText
        {
            get
            {
                return base.method_3<UberText>("m_forgeRecordCountText");
            }
        }

        public int m_justCanceledQuestID
        {
            get
            {
                return base.method_2<int>("m_justCanceledQuestID");
            }
        }

        public Transform m_medalBone
        {
            get
            {
                return base.method_3<Transform>("m_medalBone");
            }
        }

        public TournamentMedal m_medalPrefab
        {
            get
            {
                return base.method_3<TournamentMedal>("m_medalPrefab");
            }
        }

        public UberText m_noQuestText
        {
            get
            {
                return base.method_3<UberText>("m_noQuestText");
            }
        }

        public PegUIElement m_offClickCatcher
        {
            get
            {
                return base.method_3<PegUIElement>("m_offClickCatcher");
            }
        }

        public List<MonoEnum> m_presencePrevStatus
        {
            get
            {
                Class247<MonoEnum> class2 = base.method_3<Class247<MonoEnum>>("m_presencePrevStatus");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Transform> m_questBones
        {
            get
            {
                Class267<Transform> class2 = base.method_3<Class267<Transform>>("m_questBones");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_questTilePrefab
        {
            get
            {
                return base.method_3<GameObject>("m_questTilePrefab");
            }
        }

        public RankedRewardChest2D m_rewardChest
        {
            get
            {
                return base.method_3<RankedRewardChest2D>("m_rewardChest");
            }
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }

        public UberText m_totalLevelsText
        {
            get
            {
                return base.method_3<UberText>("m_totalLevelsText");
            }
        }

        public UberText m_winsCountText
        {
            get
            {
                return base.method_3<UberText>("m_winsCountText");
            }
        }

        public float m_yPosRoot16to9
        {
            get
            {
                return base.method_2<float>("m_yPosRoot16to9");
            }
        }

        public float m_yPosRoot3to2
        {
            get
            {
                return base.method_2<float>("m_yPosRoot3to2");
            }
        }
    }
}

