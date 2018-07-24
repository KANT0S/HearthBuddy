namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Achievement")]
    public class Achievement : MonoClass
    {
        public Achievement(IntPtr address) : this(address, "Achievement")
        {
        }

        public Achievement(IntPtr address, string className) : base(address, className)
        {
        }

        public void AckCurrentProgressAndRewardNotices()
        {
            base.method_9("AckCurrentProgressAndRewardNotices", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void AckCurrentProgressAndRewardNotices(bool ackIntermediateProgress)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { ackIntermediateProgress };
            base.method_9("AckCurrentProgressAndRewardNotices", enumArray1, objArray1);
        }

        public void AddRewardNoticeID(long noticeID)
        {
            object[] objArray1 = new object[] { noticeID };
            base.method_8("AddRewardNoticeID", objArray1);
        }

        public void AutoAckIfNeeded()
        {
            base.method_8("AutoAckIfNeeded", Array.Empty<object>());
        }

        public void Complete()
        {
            base.method_8("Complete", Array.Empty<object>());
        }

        public bool IsActiveLicenseAddedAchieve()
        {
            return base.method_11<bool>("IsActiveLicenseAddedAchieve", Array.Empty<object>());
        }

        public bool IsCompleted()
        {
            return base.method_11<bool>("IsCompleted", Array.Empty<object>());
        }

        public bool IsInternal()
        {
            return base.method_11<bool>("IsInternal", Array.Empty<object>());
        }

        public bool IsNewlyActive()
        {
            return base.method_11<bool>("IsNewlyActive", Array.Empty<object>());
        }

        public bool NeedToAcknowledgeProgress(bool ackIntermediateProgress)
        {
            object[] objArray1 = new object[] { ackIntermediateProgress };
            return base.method_11<bool>("NeedToAcknowledgeProgress", objArray1);
        }

        public void OnAchieveData(int progress, int acknowledgedProgress, int completionCount, bool isActive, long dateGiven, long dateCompleted, bool canAcknowledge)
        {
            object[] objArray1 = new object[] { progress, acknowledgedProgress, completionCount, isActive, dateGiven, dateCompleted, canAcknowledge };
            base.method_8("OnAchieveData", objArray1);
        }

        public void OnCancelSuccess()
        {
            base.method_8("OnCancelSuccess", Array.Empty<object>());
        }

        public void SetAcknowledgedProgress(int acknowledgedProgress)
        {
            object[] objArray1 = new object[] { acknowledgedProgress };
            base.method_8("SetAcknowledgedProgress", objArray1);
        }

        public void SetDescription(string description)
        {
            object[] objArray1 = new object[] { description };
            base.method_8("SetDescription", objArray1);
        }

        public void SetName(string name)
        {
            object[] objArray1 = new object[] { name };
            base.method_8("SetName", objArray1);
        }

        public void SetProgress(int progress)
        {
            object[] objArray1 = new object[] { progress };
            base.method_8("SetProgress", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public void UpdateActiveAchieve(int progress, int acknowledgedProgress, long dateGiven, bool canAcknowledge)
        {
            object[] objArray1 = new object[] { progress, acknowledgedProgress, dateGiven, canAcknowledge };
            base.method_8("UpdateActiveAchieve", objArray1);
        }

        public Group AchieveGroup
        {
            get
            {
                return base.method_11<Group>("get_AchieveGroup", Array.Empty<object>());
            }
        }

        public Trigger AchieveTrigger
        {
            get
            {
                return base.method_11<Trigger>("get_AchieveTrigger", Array.Empty<object>());
            }
        }

        public int AcknowledgedProgress
        {
            get
            {
                return base.method_11<int>("get_AcknowledgedProgress", Array.Empty<object>());
            }
        }

        public bool Active
        {
            get
            {
                return base.method_11<bool>("get_Active", Array.Empty<object>());
            }
        }

        public bool CanBeAcknowledged
        {
            get
            {
                return base.method_11<bool>("get_CanBeAcknowledged", Array.Empty<object>());
            }
        }

        public int CompletionCount
        {
            get
            {
                return base.method_11<int>("get_CompletionCount", Array.Empty<object>());
            }
        }

        public long DateCompleted
        {
            get
            {
                return base.method_11<long>("get_DateCompleted", Array.Empty<object>());
            }
        }

        public long DateGiven
        {
            get
            {
                return base.method_11<long>("get_DateGiven", Array.Empty<object>());
            }
        }

        public string Description
        {
            get
            {
                return base.method_13("get_Description", Array.Empty<object>());
            }
        }

        public bool Enabled
        {
            get
            {
                return base.method_11<bool>("get_Enabled", Array.Empty<object>());
            }
        }

        public SpecialEventType EventTrigger
        {
            get
            {
                return base.method_11<SpecialEventType>("get_EventTrigger", Array.Empty<object>());
            }
        }

        public int ID
        {
            get
            {
                return base.method_11<int>("get_ID", Array.Empty<object>());
            }
        }

        public int m_ackProgress
        {
            get
            {
                return base.method_2<int>("m_ackProgress");
            }
        }

        public bool m_active
        {
            get
            {
                return base.method_2<bool>("m_active");
            }
        }

        public bool m_canAck
        {
            get
            {
                return base.method_2<bool>("m_canAck");
            }
        }

        public int m_completionCount
        {
            get
            {
                return base.method_2<int>("m_completionCount");
            }
        }

        public long m_dateCompleted
        {
            get
            {
                return base.method_2<long>("m_dateCompleted");
            }
        }

        public long m_dateGiven
        {
            get
            {
                return base.method_2<long>("m_dateGiven");
            }
        }

        public string m_description
        {
            get
            {
                return base.method_4("m_description");
            }
        }

        public bool m_enabled
        {
            get
            {
                return base.method_2<bool>("m_enabled");
            }
        }

        public SpecialEventType m_eventTrigger
        {
            get
            {
                return base.method_2<SpecialEventType>("m_eventTrigger");
            }
        }

        public Group m_group
        {
            get
            {
                return base.method_2<Group>("m_group");
            }
        }

        public int m_id
        {
            get
            {
                return base.method_2<int>("m_id");
            }
        }

        public int m_maxProgress
        {
            get
            {
                return base.method_2<int>("m_maxProgress");
            }
        }

        public string m_name
        {
            get
            {
                return base.method_4("m_name");
            }
        }

        public int m_progress
        {
            get
            {
                return base.method_2<int>("m_progress");
            }
        }

        public List<long> m_rewardNoticeIDs
        {
            get
            {
                Class266<long> class2 = base.method_3<Class266<long>>("m_rewardNoticeIDs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<RewardData> m_rewards
        {
            get
            {
                Class267<RewardData> class2 = base.method_3<Class267<RewardData>>("m_rewards");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public RewardVisualTiming m_rewardTiming
        {
            get
            {
                return base.method_2<RewardVisualTiming>("m_rewardTiming");
            }
        }

        public Trigger m_trigger
        {
            get
            {
                return base.method_2<Trigger>("m_trigger");
            }
        }

        public int MaxProgress
        {
            get
            {
                return base.method_11<int>("get_MaxProgress", Array.Empty<object>());
            }
        }

        public string Name
        {
            get
            {
                return base.method_13("get_Name", Array.Empty<object>());
            }
        }

        public static int NEW_ACHIEVE_ACK_PROGRESS
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "Achievement", "NEW_ACHIEVE_ACK_PROGRESS");
            }
        }

        public int Progress
        {
            get
            {
                return base.method_11<int>("get_Progress", Array.Empty<object>());
            }
        }

        public List<RewardData> Rewards
        {
            get
            {
                Class267<RewardData> class2 = base.method_14<Class267<RewardData>>("get_Rewards", Array.Empty<object>());
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public RewardVisualTiming RewardTiming
        {
            get
            {
                return base.method_11<RewardVisualTiming>("get_RewardTiming", Array.Empty<object>());
            }
        }

        public enum ClickTriggerType
        {
            BUTTON_ARENA = 2,
            BUTTON_PLAY = 1
        }

        public enum Group
        {
            QUEST_DAILY,
            QUEST_DAILY_REPEATABLE,
            QUEST_HIDDEN,
            QUEST_INTERNAL_ACTIVE,
            QUEST_INTERNAL_INACTIVE,
            QUEST_STARTER,
            UNLOCK_GOLDEN_HERO,
            UNLOCK_HERO
        }

        public enum Trigger
        {
            IGNORE,
            ACCOUNT_LICENSE_ADDED,
            ADVENTURE_PROGRESS,
            CLICK,
            COMPLETE_CARD_SET,
            EVENT,
            EVENT_TIMING_ONLY,
            GAIN_CARD,
            GAIN_GOLDEN_CARD,
            PURCHASE,
            WIN
        }

        public enum UnlockableFeature
        {
            DAILY_QUESTS,
            FORGE,
            NAXX_WING_1_OWNED,
            NAXX_WING_2_OWNED,
            NAXX_WING_3_OWNED,
            NAXX_WING_4_OWNED,
            NAXX_WING_5_OWNED,
            NAXX_WING_1_PLAYABLE,
            NAXX_WING_2_PLAYABLE,
            NAXX_WING_3_PLAYABLE,
            NAXX_WING_4_PLAYABLE,
            NAXX_WING_5_PLAYABLE,
            VANILLA_HEROES
        }
    }
}

