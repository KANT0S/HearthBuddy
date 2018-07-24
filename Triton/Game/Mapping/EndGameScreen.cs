namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("EndGameScreen")]
    public class EndGameScreen : MonoBehaviour
    {
        public EndGameScreen(IntPtr address) : this(address, "EndGameScreen")
        {
        }

        public EndGameScreen(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BackToMode(SceneMgr.Mode mode)
        {
            object[] objArray1 = new object[] { mode };
            base.method_8("BackToMode", objArray1);
        }

        public void ContinueButtonPress_Common()
        {
            base.method_8("ContinueButtonPress_Common", Array.Empty<object>());
        }

        public void ContinueButtonPress_PrevMode(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ContinueButtonPress_PrevMode", objArray1);
        }

        public void ContinueButtonPress_TutorialProgress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("ContinueButtonPress_TutorialProgress", objArray1);
        }

        public bool ContinueDefaultEvents()
        {
            return base.method_11<bool>("ContinueDefaultEvents", Array.Empty<object>());
        }

        public bool ContinueEvents()
        {
            return base.method_11<bool>("ContinueEvents", Array.Empty<object>());
        }

        public void ContinueTutorialEvents()
        {
            base.method_8("ContinueTutorialEvents", Array.Empty<object>());
        }

        public static EndGameScreen Get()
        {
            return MonoClass.smethod_15<EndGameScreen>(TritonHs.MainAssemblyPath, "", "EndGameScreen", "Get", Array.Empty<object>());
        }

        public bool HasShownScoops()
        {
            return base.method_11<bool>("HasShownScoops", Array.Empty<object>());
        }

        public void HideTwoScoop()
        {
            base.method_8("HideTwoScoop", Array.Empty<object>());
        }

        public bool InitIfReady()
        {
            return base.method_11<bool>("InitIfReady", Array.Empty<object>());
        }

        public bool IsReady()
        {
            return base.method_11<bool>("IsReady", Array.Empty<object>());
        }

        public bool JustEarnedGoldenHero()
        {
            return base.method_11<bool>("JustEarnedGoldenHero", Array.Empty<object>());
        }

        public void LoadGoldenHeroEvent()
        {
            base.method_8("LoadGoldenHeroEvent", Array.Empty<object>());
        }

        public void MaybeUpdateRewards()
        {
            base.method_8("MaybeUpdateRewards", Array.Empty<object>());
        }

        public void NotifyOfAnimComplete()
        {
            base.method_8("NotifyOfAnimComplete", Array.Empty<object>());
        }

        public void NotifyOfRewardAnimComplete()
        {
            base.method_8("NotifyOfRewardAnimComplete", Array.Empty<object>());
        }

        public void OnAchievesUpdated(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnAchievesUpdated", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnNetCacheReady()
        {
            base.method_8("OnNetCacheReady", Array.Empty<object>());
        }

        public void OnRankChangeLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnRankChangeLoaded", objArray1);
        }

        public void OnRewardHidden(Reward reward)
        {
            object[] objArray1 = new object[] { reward };
            base.method_8("OnRewardHidden", objArray1);
        }

        public void OnTutorialProgressScreenCallback(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnTutorialProgressScreenCallback", objArray1);
        }

        public void OnTwoScoopHidden()
        {
            base.method_8("OnTwoScoopHidden", Array.Empty<object>());
        }

        public void OnTwoScoopShown()
        {
            base.method_8("OnTwoScoopShown", Array.Empty<object>());
        }

        public void PositionReward(Reward reward)
        {
            object[] objArray1 = new object[] { reward };
            base.method_8("PositionReward", objArray1);
        }

        public void ReturnToPreviousMode()
        {
            base.method_8("ReturnToPreviousMode", Array.Empty<object>());
        }

        public void RewardObjectLoaded(Reward reward, object callbackData)
        {
            object[] objArray1 = new object[] { reward, callbackData };
            base.method_8("RewardObjectLoaded", objArray1);
        }

        public void SetGoldenHeroEventReady(bool isReady)
        {
            object[] objArray1 = new object[] { isReady };
            base.method_8("SetGoldenHeroEventReady", objArray1);
        }

        public bool ShouldMakeUtilRequests()
        {
            return base.method_11<bool>("ShouldMakeUtilRequests", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public bool ShowFixedRewards()
        {
            return base.method_11<bool>("ShowFixedRewards", Array.Empty<object>());
        }

        public bool ShowGoldenHeroEvent()
        {
            return base.method_11<bool>("ShowGoldenHeroEvent", Array.Empty<object>());
        }

        public bool ShowNextCompletedQuest()
        {
            return base.method_11<bool>("ShowNextCompletedQuest", Array.Empty<object>());
        }

        public bool ShowNextReward()
        {
            return base.method_11<bool>("ShowNextReward", Array.Empty<object>());
        }

        public void ShowQuestToastCallback(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("ShowQuestToastCallback", objArray1);
        }

        public void ShowReward(Reward reward)
        {
            object[] objArray1 = new object[] { reward };
            base.method_8("ShowReward", objArray1);
        }

        public void ShowStandardFlow()
        {
            base.method_8("ShowStandardFlow", Array.Empty<object>());
        }

        public void ShowTutorialProgress()
        {
            base.method_8("ShowTutorialProgress", Array.Empty<object>());
        }

        public void ShowTwoScoop()
        {
            base.method_8("ShowTwoScoop", Array.Empty<object>());
        }

        public void UpdateRewards()
        {
            base.method_8("UpdateRewards", Array.Empty<object>());
        }

        public bool m_achievesReady
        {
            get
            {
                return base.method_2<bool>("m_achievesReady");
            }
        }

        public bool m_animationReadyToSkip
        {
            get
            {
                return base.method_2<bool>("m_animationReadyToSkip");
            }
        }

        public List<Achievement> m_completedQuests
        {
            get
            {
                Class267<Achievement> class2 = base.method_3<Class267<Achievement>>("m_completedQuests");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public UberText m_continueText
        {
            get
            {
                return base.method_3<UberText>("m_continueText");
            }
        }

        public Reward m_currentlyShowingReward
        {
            get
            {
                return base.method_3<Reward>("m_currentlyShowingReward");
            }
        }

        public bool m_goldenHeroEventReady
        {
            get
            {
                return base.method_2<bool>("m_goldenHeroEventReady");
            }
        }

        public bool m_hasAlreadySetMode
        {
            get
            {
                return base.method_2<bool>("m_hasAlreadySetMode");
            }
        }

        public bool m_haveShownTwoScoop
        {
            get
            {
                return base.method_2<bool>("m_haveShownTwoScoop");
            }
        }

        public PegUIElement m_hitbox
        {
            get
            {
                return base.method_3<PegUIElement>("m_hitbox");
            }
        }

        public bool m_netCacheReady
        {
            get
            {
                return base.method_2<bool>("m_netCacheReady");
            }
        }

        public int m_numRewardsToLoad
        {
            get
            {
                return base.method_2<int>("m_numRewardsToLoad");
            }
        }

        public List<Reward> m_rewards
        {
            get
            {
                Class267<Reward> class2 = base.method_3<Class267<Reward>>("m_rewards");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_rewardsLoaded
        {
            get
            {
                return base.method_2<bool>("m_rewardsLoaded");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }

        public EndGameTwoScoop m_twoScoop
        {
            get
            {
                return base.method_3<EndGameTwoScoop>("m_twoScoop");
            }
        }
    }
}

