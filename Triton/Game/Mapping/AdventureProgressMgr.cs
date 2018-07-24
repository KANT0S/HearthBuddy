namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdventureProgressMgr")]
    public class AdventureProgressMgr : MonoClass
    {
        public AdventureProgressMgr(IntPtr address) : this(address, "AdventureProgressMgr")
        {
        }

        public AdventureProgressMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public bool CanPlayScenario(int scenarioID)
        {
            object[] objArray1 = new object[] { scenarioID };
            return base.method_11<bool>("CanPlayScenario", objArray1);
        }

        public void CreateOrUpdateProgress(bool isStartupAction, int wing, int progress)
        {
            object[] objArray1 = new object[] { isStartupAction, wing, progress };
            base.method_8("CreateOrUpdateProgress", objArray1);
        }

        public void CreateOrUpdateWingAck(int wing, int ack)
        {
            object[] objArray1 = new object[] { wing, ack };
            base.method_8("CreateOrUpdateWingAck", objArray1);
        }

        public void CreateOrUpdateWingFlags(bool isStartupAction, int wing, ulong flags)
        {
            object[] objArray1 = new object[] { isStartupAction, wing, flags };
            base.method_8("CreateOrUpdateWingFlags", objArray1);
        }

        public void FireProgressUpdate(bool isStartupAction, AdventureMission.WingProgress oldProgress, AdventureMission.WingProgress newProgress)
        {
            object[] objArray1 = new object[] { isStartupAction, oldProgress, newProgress };
            base.method_8("FireProgressUpdate", objArray1);
        }

        public static AdventureProgressMgr Get()
        {
            return MonoClass.smethod_15<AdventureProgressMgr>(TritonHs.MainAssemblyPath, "", "AdventureProgressMgr", "Get", Array.Empty<object>());
        }

        public List<AdventureOption> GetAdventureOptions()
        {
            Class247<AdventureOption> class2 = base.method_14<Class247<AdventureOption>>("GetAdventureOptions", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<AdventureMission.WingProgress> GetAllProgress()
        {
            Class267<AdventureMission.WingProgress> class2 = base.method_14<Class267<AdventureMission.WingProgress>>("GetAllProgress", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<CardRewardData> GetImmediateCardRewardsForDefeatingScenario(int scenarioID)
        {
            object[] objArray1 = new object[] { scenarioID };
            Class267<CardRewardData> class2 = base.method_14<Class267<CardRewardData>>("GetImmediateCardRewardsForDefeatingScenario", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public int GetPlayableAdventureScenarios(AdventureDbId adventureID, AdventureModeDbId modeID)
        {
            object[] objArray1 = new object[] { adventureID, modeID };
            return base.method_11<int>("GetPlayableAdventureScenarios", objArray1);
        }

        public int GetPlayableClassChallenges(AdventureDbId adventureID, AdventureModeDbId modeID)
        {
            object[] objArray1 = new object[] { adventureID, modeID };
            return base.method_11<int>("GetPlayableClassChallenges", objArray1);
        }

        public AdventureMission.WingProgress GetProgress(int wing)
        {
            object[] objArray1 = new object[] { wing };
            return base.method_14<AdventureMission.WingProgress>("GetProgress", objArray1);
        }

        public string GetWingName(int wing)
        {
            object[] objArray1 = new object[] { wing };
            return base.method_13("GetWingName", objArray1);
        }

        public SpecialEventType GetWingOpenEvent(int wing)
        {
            object[] objArray1 = new object[] { wing };
            return base.method_11<SpecialEventType>("GetWingOpenEvent", objArray1);
        }

        public bool HasDefeatedScenario(int scenarioID)
        {
            object[] objArray1 = new object[] { scenarioID };
            return base.method_11<bool>("HasDefeatedScenario", objArray1);
        }

        public static void Init()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "AdventureProgressMgr", "Init");
        }

        public static void InitRequests()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "AdventureProgressMgr", "InitRequests");
        }

        public bool IsWingComplete(AdventureDbId adventureID, AdventureModeDbId modeID, WingDbId wingId)
        {
            object[] objArray1 = new object[] { adventureID, modeID, wingId };
            return base.method_11<bool>("IsWingComplete", objArray1);
        }

        public bool IsWingLocked(int wingId)
        {
            object[] objArray1 = new object[] { wingId };
            return base.method_11<bool>("IsWingLocked", objArray1);
        }

        public bool IsWingOpen(int wing)
        {
            object[] objArray1 = new object[] { wing };
            return base.method_11<bool>("IsWingOpen", objArray1);
        }

        public void LoadAdventureMissionsFromDBF()
        {
            base.method_8("LoadAdventureMissionsFromDBF", Array.Empty<object>());
        }

        public void OnAdventureProgress()
        {
            base.method_8("OnAdventureProgress", Array.Empty<object>());
        }

        public bool OwnsWing(int wing)
        {
            object[] objArray1 = new object[] { wing };
            return base.method_11<bool>("OwnsWing", objArray1);
        }

        public void SetAdventureOptions(int id, ulong options)
        {
            object[] objArray1 = new object[] { id, options };
            base.method_8("SetAdventureOptions", objArray1);
        }

        public bool SetWingAck(int wing, int ackId)
        {
            object[] objArray1 = new object[] { wing, ackId };
            return base.method_11<bool>("SetWingAck", objArray1);
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }
    }
}

