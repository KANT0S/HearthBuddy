namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdventureConfig")]
    public class AdventureConfig : MonoBehaviour
    {
        public AdventureConfig(IntPtr address) : this(address, "AdventureConfig")
        {
        }

        public AdventureConfig(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool CanPlayMode(AdventureDbId adventureId, AdventureModeDbId modeId)
        {
            object[] objArray1 = new object[] { adventureId, modeId };
            return base.method_11<bool>("CanPlayMode", objArray1);
        }

        public void ChangeSubScene(AdventureSubScenes subscene)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { subscene };
            base.method_9("ChangeSubScene", enumArray1, objArray1);
        }

        public void ChangeSubScene(AdventureDbId adventureId, AdventureModeDbId modeId)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { adventureId, modeId };
            base.method_9("ChangeSubScene", enumArray1, objArray1);
        }

        public void ChangeSubSceneToSelectedAdventure()
        {
            base.method_8("ChangeSubSceneToSelectedAdventure", Array.Empty<object>());
        }

        public void ChangeToLastSubScene(bool fireevent)
        {
            object[] objArray1 = new object[] { fireevent };
            base.method_8("ChangeToLastSubScene", objArray1);
        }

        public void ClearBossDefs()
        {
            base.method_8("ClearBossDefs", Array.Empty<object>());
        }

        public bool DoesMissionRequireDeck(ScenarioDbId scenario)
        {
            object[] objArray1 = new object[] { scenario };
            return base.method_11<bool>("DoesMissionRequireDeck", objArray1);
        }

        public bool DoesSelectedMissionRequireDeck()
        {
            return base.method_11<bool>("DoesSelectedMissionRequireDeck", Array.Empty<object>());
        }

        public void FireAdventureModeChangeEvent()
        {
            base.method_8("FireAdventureModeChangeEvent", Array.Empty<object>());
        }

        public void FireSelectedModeChangeEvent()
        {
            base.method_8("FireSelectedModeChangeEvent", Array.Empty<object>());
        }

        public void FireSubSceneChangeEvent(bool forward)
        {
            object[] objArray1 = new object[] { forward };
            base.method_8("FireSubSceneChangeEvent", objArray1);
        }

        public static AdventureConfig Get()
        {
            return MonoClass.smethod_15<AdventureConfig>(TritonHs.MainAssemblyPath, "", "AdventureConfig", "Get", Array.Empty<object>());
        }

        public AdventureBossDef GetBossDef(ScenarioDbId mission)
        {
            object[] objArray1 = new object[] { mission };
            return base.method_14<AdventureBossDef>("GetBossDef", objArray1);
        }

        public string GetBossDefAssetPath(ScenarioDbId mission)
        {
            object[] objArray1 = new object[] { mission };
            return base.method_13("GetBossDefAssetPath", objArray1);
        }

        public AdventureModeDbId GetClientChooserAdventureMode(AdventureDbId adventureDbId)
        {
            object[] objArray1 = new object[] { adventureDbId };
            return base.method_11<AdventureModeDbId>("GetClientChooserAdventureMode", objArray1);
        }

        public AdventureSubScenes GetCurrentSubScene()
        {
            return base.method_11<AdventureSubScenes>("GetCurrentSubScene", Array.Empty<object>());
        }

        public ScenarioDbId GetLastSelectedMission()
        {
            return base.method_11<ScenarioDbId>("GetLastSelectedMission", Array.Empty<object>());
        }

        public ScenarioDbId GetMission()
        {
            return base.method_11<ScenarioDbId>("GetMission", Array.Empty<object>());
        }

        public AdventureDbId GetSelectedAdventure()
        {
            return base.method_11<AdventureDbId>("GetSelectedAdventure", Array.Empty<object>());
        }

        public string GetSelectedAdventureAndModeString()
        {
            return base.method_13("GetSelectedAdventureAndModeString", Array.Empty<object>());
        }

        public AdventureModeDbId GetSelectedMode()
        {
            return base.method_11<AdventureModeDbId>("GetSelectedMode", Array.Empty<object>());
        }

        public static AdventureSubScenes GetSubSceneFromMode(AdventureDbId adventureId, AdventureModeDbId modeId)
        {
            object[] objArray1 = new object[] { adventureId, modeId };
            return MonoClass.smethod_14<AdventureSubScenes>(TritonHs.MainAssemblyPath, "", "AdventureConfig", "GetSubSceneFromMode", objArray1);
        }

        public int GetWingBossesDefeated(AdventureDbId advId, AdventureModeDbId mode, WingDbId wing, int defaultvalue)
        {
            object[] objArray1 = new object[] { advId, mode, wing, defaultvalue };
            return base.method_11<int>("GetWingBossesDefeated", objArray1);
        }

        public string GetWingUniqueId(AdventureDbId advId, AdventureModeDbId modeId, WingDbId wing)
        {
            object[] objArray1 = new object[] { advId, modeId, wing };
            return base.method_13("GetWingUniqueId", objArray1);
        }

        public bool IsFeaturedMode(AdventureDbId adventureId, AdventureModeDbId modeId)
        {
            object[] objArray1 = new object[] { adventureId, modeId };
            return base.method_11<bool>("IsFeaturedMode", objArray1);
        }

        public bool IsMissionAvailable(int missionId)
        {
            object[] objArray1 = new object[] { missionId };
            return base.method_11<bool>("IsMissionAvailable", objArray1);
        }

        public bool IsScenarioDefeatedAndInitCache(ScenarioDbId mission)
        {
            object[] objArray1 = new object[] { mission };
            return base.method_11<bool>("IsScenarioDefeatedAndInitCache", objArray1);
        }

        public bool IsScenarioJustDefeated(ScenarioDbId mission)
        {
            object[] objArray1 = new object[] { mission };
            return base.method_11<bool>("IsScenarioJustDefeated", objArray1);
        }

        public bool MarkFeaturedMode(AdventureDbId adventureId, AdventureModeDbId modeId)
        {
            object[] objArray1 = new object[] { adventureId, modeId };
            return base.method_11<bool>("MarkFeaturedMode", objArray1);
        }

        public void OnAdventureSceneAwake()
        {
            base.method_8("OnAdventureSceneAwake", Array.Empty<object>());
        }

        public void OnAdventureSceneUnload()
        {
            base.method_8("OnAdventureSceneUnload", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void ResetSubScene()
        {
            base.method_9("ResetSubScene", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void ResetSubScene(AdventureSubScenes subscene)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { subscene };
            base.method_9("ResetSubScene", enumArray1, objArray1);
        }

        public void SetMission(ScenarioDbId mission, bool showDetails)
        {
            object[] objArray1 = new object[] { mission, showDetails };
            base.method_8("SetMission", objArray1);
        }

        public void SetSelectedAdventureMode(AdventureDbId adventureId, AdventureModeDbId modeId)
        {
            object[] objArray1 = new object[] { adventureId, modeId };
            base.method_8("SetSelectedAdventureMode", objArray1);
        }

        public void SetWingAckIfGreater(int wingId, int ackProgress)
        {
            object[] objArray1 = new object[] { wingId, ackProgress };
            base.method_8("SetWingAckIfGreater", objArray1);
        }

        public void UpdatePresence()
        {
            base.method_8("UpdatePresence", Array.Empty<object>());
        }

        public void UpdateWingBossesDefeated(AdventureDbId advId, AdventureModeDbId mode, WingDbId wing, int bossesDefeated)
        {
            object[] objArray1 = new object[] { advId, mode, wing, bossesDefeated };
            base.method_8("UpdateWingBossesDefeated", objArray1);
        }

        public AdventureSubScenes m_CurrentSubScene
        {
            get
            {
                return base.method_2<AdventureSubScenes>("m_CurrentSubScene");
            }
        }

        public AdventureDbId m_SelectedAdventure
        {
            get
            {
                return base.method_2<AdventureDbId>("m_SelectedAdventure");
            }
        }

        public AdventureModeDbId m_SelectedMode
        {
            get
            {
                return base.method_2<AdventureModeDbId>("m_SelectedMode");
            }
        }

        public ScenarioDbId m_StartMission
        {
            get
            {
                return base.method_2<ScenarioDbId>("m_StartMission");
            }
        }
    }
}

