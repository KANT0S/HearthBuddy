namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ZoneMgr")]
    public class ZoneMgr : MonoBehaviour
    {
        public ZoneMgr(IntPtr address) : this(address, "ZoneMgr")
        {
        }

        public ZoneMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public ZoneChangeList AddLocalZoneChange(Card triggerCard, TAG_ZONE zoneTag)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { triggerCard, zoneTag };
            return base.method_15<ZoneChangeList>("AddLocalZoneChange", enumArray1, objArray1);
        }

        public ZoneChangeList AddLocalZoneChange(Card triggerCard, TAG_ZONE zoneTag, int destinationPos)
        {
            object[] objArray1 = new object[] { triggerCard, zoneTag, destinationPos };
            return base.method_15<ZoneChangeList>("AddLocalZoneChange", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public ZoneChangeList AddLocalZoneChange(Card triggerCard, Zone destinationZone, int destinationPos)
        {
            object[] objArray1 = new object[] { triggerCard, destinationZone, destinationPos };
            return base.method_15<ZoneChangeList>("AddLocalZoneChange", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public ZoneChangeList AddPredictedLocalZoneChange(Card triggerCard, Zone destinationZone, int destinationPos, int predictedPos)
        {
            object[] objArray1 = new object[] { triggerCard, destinationZone, destinationPos, predictedPos };
            return base.method_14<ZoneChangeList>("AddPredictedLocalZoneChange", objArray1);
        }

        public void AutoCorrectZones()
        {
            base.method_8("AutoCorrectZones", Array.Empty<object>());
        }

        public void AutoCorrectZonesAfterLocalChange()
        {
            base.method_8("AutoCorrectZonesAfterLocalChange", Array.Empty<object>());
        }

        public void AutoCorrectZonesAfterServerChange()
        {
            base.method_8("AutoCorrectZonesAfterServerChange", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public TempZone BuildTempZone(Zone zone)
        {
            object[] objArray1 = new object[] { zone };
            return base.method_14<TempZone>("BuildTempZone", objArray1);
        }

        public bool CheckAndIgnoreServerChangeList(ZoneChangeList serverChangeList)
        {
            object[] objArray1 = new object[] { serverChangeList };
            return base.method_11<bool>("CheckAndIgnoreServerChangeList", objArray1);
        }

        public void CreateLocalChangesFromTrigger(ZoneChangeList changeList, ZoneChange triggerChange)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { changeList, triggerChange };
            base.method_9("CreateLocalChangesFromTrigger", enumArray1, objArray1);
        }

        public void CreateLocalChangesFromTrigger(ZoneChangeList changeList, Triton.Game.Mapping.Entity triggerEntity, Zone sourceZone, TAG_ZONE sourceZoneTag, int sourcePos, Zone destinationZone, TAG_ZONE destinationZoneTag, int destinationPos)
        {
            object[] objArray1 = new object[] { changeList, triggerEntity, sourceZone, sourceZoneTag, sourcePos, destinationZone, destinationZoneTag, destinationPos };
            base.method_9("CreateLocalChangesFromTrigger", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void CreateLocalPosOnlyChangesFromTrigger(ZoneChangeList changeList, Triton.Game.Mapping.Entity triggerEntity, Zone sourceZone, int sourcePos, int destinationPos)
        {
            object[] objArray1 = new object[] { changeList, triggerEntity, sourceZone, sourcePos, destinationPos };
            base.method_8("CreateLocalPosOnlyChangesFromTrigger", objArray1);
        }

        public ZoneChange CreateZoneChangeFromCreateGame(Network.HistCreateGame createGame)
        {
            object[] objArray1 = new object[] { createGame };
            return base.method_14<ZoneChange>("CreateZoneChangeFromCreateGame", objArray1);
        }

        public ZoneChange CreateZoneChangeFromFullEntity(Network.HistFullEntity fullEntity)
        {
            object[] objArray1 = new object[] { fullEntity };
            return base.method_14<ZoneChange>("CreateZoneChangeFromFullEntity", objArray1);
        }

        public ZoneChange CreateZoneChangeFromHideEntity(Network.HistHideEntity hideEntity)
        {
            object[] objArray1 = new object[] { hideEntity };
            return base.method_14<ZoneChange>("CreateZoneChangeFromHideEntity", objArray1);
        }

        public ZoneChange CreateZoneChangeFromMetaData(Network.HistMetaData metaData)
        {
            object[] objArray1 = new object[] { metaData };
            return base.method_14<ZoneChange>("CreateZoneChangeFromMetaData", objArray1);
        }

        public ZoneChange CreateZoneChangeFromShowEntity(Network.HistShowEntity showEntity)
        {
            object[] objArray1 = new object[] { showEntity };
            return base.method_14<ZoneChange>("CreateZoneChangeFromShowEntity", objArray1);
        }

        public ZoneChange CreateZoneChangeFromTagChange(Network.HistTagChange tagChange)
        {
            object[] objArray1 = new object[] { tagChange };
            return base.method_14<ZoneChange>("CreateZoneChangeFromTagChange", objArray1);
        }

        public int FindBestInsertionPosition(TempZone tempZone, int leftPos, int rightPos)
        {
            object[] objArray1 = new object[] { tempZone, leftPos, rightPos };
            return base.method_11<int>("FindBestInsertionPosition", objArray1);
        }

        public ZoneChangeList FindLocalChangeListMatchingServerChangeList(ZoneChangeList serverChangeList)
        {
            object[] objArray1 = new object[] { serverChangeList };
            return base.method_14<ZoneChangeList>("FindLocalChangeListMatchingServerChangeList", objArray1);
        }

        public ZoneChange FindNextDstPosChange(ZoneChangeList changeList, int index, Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { changeList, index, entity };
            return base.method_14<ZoneChange>("FindNextDstPosChange", objArray1);
        }

        public ZoneChangeList FindRejectedLocalZoneChange(Triton.Game.Mapping.Entity triggerEntity)
        {
            object[] objArray1 = new object[] { triggerEntity };
            return base.method_14<ZoneChangeList>("FindRejectedLocalZoneChange", objArray1);
        }

        public TempZone FindTempZoneForZone(Zone zone)
        {
            object[] objArray1 = new object[] { zone };
            return base.method_14<TempZone>("FindTempZoneForZone", objArray1);
        }

        public ZoneChangeList FindTriggeredActiveLocalChange(Card card)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { card };
            return base.method_15<ZoneChangeList>("FindTriggeredActiveLocalChange", enumArray1, objArray1);
        }

        public ZoneChangeList FindTriggeredActiveLocalChange(Triton.Game.Mapping.Entity entity)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { entity };
            return base.method_15<ZoneChangeList>("FindTriggeredActiveLocalChange", enumArray1, objArray1);
        }

        public int FindTriggeredActiveLocalChangeIndex(Card card)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { card };
            return base.method_10<int>("FindTriggeredActiveLocalChangeIndex", enumArray1, objArray1);
        }

        public int FindTriggeredActiveLocalChangeIndex(Triton.Game.Mapping.Entity entity)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { entity };
            return base.method_10<int>("FindTriggeredActiveLocalChangeIndex", enumArray1, objArray1);
        }

        public ZoneChangeList FindTriggeredPendingLocalChange(Card card)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { card };
            return base.method_15<ZoneChangeList>("FindTriggeredPendingLocalChange", enumArray1, objArray1);
        }

        public ZoneChangeList FindTriggeredPendingLocalChange(Triton.Game.Mapping.Entity entity)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { entity };
            return base.method_15<ZoneChangeList>("FindTriggeredPendingLocalChange", enumArray1, objArray1);
        }

        public int FindTriggeredPendingLocalChangeIndex(Card card)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { card };
            return base.method_10<int>("FindTriggeredPendingLocalChangeIndex", enumArray1, objArray1);
        }

        public int FindTriggeredPendingLocalChangeIndex(Triton.Game.Mapping.Entity entity)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { entity };
            return base.method_10<int>("FindTriggeredPendingLocalChangeIndex", enumArray1, objArray1);
        }

        public Zone FindZoneForEntity(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_14<Zone>("FindZoneForEntity", objArray1);
        }

        public Zone FindZoneForEntityAndController(Triton.Game.Mapping.Entity entity, int controllerId)
        {
            object[] objArray1 = new object[] { entity, controllerId };
            return base.method_14<Zone>("FindZoneForEntityAndController", objArray1);
        }

        public Zone FindZoneForEntityAndZoneTag(Triton.Game.Mapping.Entity entity, TAG_ZONE zoneTag)
        {
            object[] objArray1 = new object[] { entity, zoneTag };
            return base.method_14<Zone>("FindZoneForEntityAndZoneTag", objArray1);
        }

        public Zone FindZoneForFullEntity(Network.HistFullEntity fullEntity)
        {
            object[] objArray1 = new object[] { fullEntity };
            return base.method_14<Zone>("FindZoneForFullEntity", objArray1);
        }

        public Zone FindZoneForShowEntity(Triton.Game.Mapping.Entity entity, Network.HistShowEntity showEntity)
        {
            object[] objArray1 = new object[] { entity, showEntity };
            return base.method_14<Zone>("FindZoneForShowEntity", objArray1);
        }

        public Zone FindZoneForTags(int controllerId, TAG_ZONE zoneTag, TAG_CARDTYPE cardType)
        {
            object[] objArray1 = new object[] { controllerId, zoneTag, cardType };
            return base.method_14<Zone>("FindZoneForTags", objArray1);
        }

        public List<Zone> FindZonesForTag(TAG_ZONE zoneTag)
        {
            object[] objArray1 = new object[] { zoneTag };
            Class267<Zone> class2 = base.method_14<Class267<Zone>>("FindZonesForTag", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public static ZoneMgr Get()
        {
            return MonoClass.smethod_15<ZoneMgr>(TritonHs.MainAssemblyPath, "", "ZoneMgr", "Get", Array.Empty<object>());
        }

        public int GetNextLocalChangeListId()
        {
            return base.method_11<int>("GetNextLocalChangeListId", Array.Empty<object>());
        }

        public int GetNextServerChangeListId()
        {
            return base.method_11<int>("GetNextServerChangeListId", Array.Empty<object>());
        }

        public List<Zone> GetZones()
        {
            Class267<Zone> class2 = base.method_14<Class267<Zone>>("GetZones", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public bool HasActiveLocalChange()
        {
            return base.method_11<bool>("HasActiveLocalChange", Array.Empty<object>());
        }

        public bool HasActiveServerChange()
        {
            return base.method_11<bool>("HasActiveServerChange", Array.Empty<object>());
        }

        public bool HasLocalChangeExitingZone(Triton.Game.Mapping.Entity entity, Zone zone)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { entity, zone };
            return base.method_10<bool>("HasLocalChangeExitingZone", enumArray1, objArray1);
        }

        public bool HasPendingLocalChange()
        {
            return base.method_11<bool>("HasPendingLocalChange", Array.Empty<object>());
        }

        public bool HasPendingServerChange()
        {
            return base.method_11<bool>("HasPendingServerChange", Array.Empty<object>());
        }

        public bool HasPredictedCards()
        {
            return base.method_11<bool>("HasPredictedCards", Array.Empty<object>());
        }

        public bool HasPredictedPositions()
        {
            return base.method_11<bool>("HasPredictedPositions", Array.Empty<object>());
        }

        public bool HasPredictedSecrets()
        {
            return base.method_11<bool>("HasPredictedSecrets", Array.Empty<object>());
        }

        public bool HasPredictedWeapons()
        {
            return base.method_11<bool>("HasPredictedWeapons", Array.Empty<object>());
        }

        public bool HasTriggeredActiveLocalChange(Card card)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { card };
            return base.method_10<bool>("HasTriggeredActiveLocalChange", enumArray1, objArray1);
        }

        public bool HasTriggeredActiveLocalChange(Triton.Game.Mapping.Entity entity)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { entity };
            return base.method_10<bool>("HasTriggeredActiveLocalChange", enumArray1, objArray1);
        }

        public bool HasTriggeredPendingLocalChange(Card card)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { card };
            return base.method_10<bool>("HasTriggeredPendingLocalChange", enumArray1, objArray1);
        }

        public bool HasTriggeredPendingLocalChange(Triton.Game.Mapping.Entity entity)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { entity };
            return base.method_10<bool>("HasTriggeredPendingLocalChange", enumArray1, objArray1);
        }

        public bool IsChangeInLocalHistory(ZoneChangeList changeList)
        {
            object[] objArray1 = new object[] { changeList };
            return base.method_11<bool>("IsChangeInLocalHistory", objArray1);
        }

        public static bool IsHandledPower(Network.PowerHistory power)
        {
            object[] objArray1 = new object[] { power };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "ZoneMgr", "IsHandledPower", objArray1);
        }

        public bool IsZoneInLocalHistory(Zone zone)
        {
            object[] objArray1 = new object[] { zone };
            return base.method_11<bool>("IsZoneInLocalHistory", objArray1);
        }

        public bool MergeServerChangeList(ZoneChangeList serverChangeList)
        {
            object[] objArray1 = new object[] { serverChangeList };
            return base.method_11<bool>("MergeServerChangeList", objArray1);
        }

        public void OnCurrentPlayerChanged(Player player, object userData)
        {
            object[] objArray1 = new object[] { player, userData };
            base.method_8("OnCurrentPlayerChanged", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public ZoneChangeList OnLocalZoneChangeRejected(Triton.Game.Mapping.Entity triggerEntity)
        {
            object[] objArray1 = new object[] { triggerEntity };
            return base.method_14<ZoneChangeList>("OnLocalZoneChangeRejected", objArray1);
        }

        public void PostProcessServerChangeList(ZoneChangeList serverChangeList)
        {
            object[] objArray1 = new object[] { serverChangeList };
            base.method_8("PostProcessServerChangeList", objArray1);
        }

        public void PredictZoneByApplyingTag(TempZone tempZone, Triton.Game.Mapping.Entity tempEntity, GAME_TAG tag, int val)
        {
            object[] objArray1 = new object[] { tempZone, tempEntity, tag, val };
            base.method_8("PredictZoneByApplyingTag", objArray1);
        }

        public void PredictZoneFromFullEntity(TempZone tempZone, Network.HistFullEntity fullEntity)
        {
            object[] objArray1 = new object[] { tempZone, fullEntity };
            base.method_8("PredictZoneFromFullEntity", objArray1);
        }

        public void PredictZoneFromHideEntity(TempZone tempZone, Network.HistHideEntity hideEntity)
        {
            object[] objArray1 = new object[] { tempZone, hideEntity };
            base.method_8("PredictZoneFromHideEntity", objArray1);
        }

        public void PredictZoneFromPower(TempZone tempZone, Network.PowerHistory power)
        {
            object[] objArray1 = new object[] { tempZone, power };
            base.method_8("PredictZoneFromPower", objArray1);
        }

        public void PredictZoneFromPowerProcessor(TempZone tempZone)
        {
            object[] objArray1 = new object[] { tempZone };
            base.method_8("PredictZoneFromPowerProcessor", objArray1);
        }

        public void PredictZoneFromPowerTaskList(TempZone tempZone, PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { tempZone, taskList };
            base.method_8("PredictZoneFromPowerTaskList", objArray1);
        }

        public void PredictZoneFromShowEntity(TempZone tempZone, Network.HistShowEntity showEntity)
        {
            object[] objArray1 = new object[] { tempZone, showEntity };
            base.method_8("PredictZoneFromShowEntity", objArray1);
        }

        public void PredictZoneFromTagChange(TempZone tempZone, Network.HistTagChange tagChange)
        {
            object[] objArray1 = new object[] { tempZone, tagChange };
            base.method_8("PredictZoneFromTagChange", objArray1);
        }

        public int PredictZonePosition(Zone zone, int pos)
        {
            object[] objArray1 = new object[] { zone, pos };
            return base.method_11<int>("PredictZonePosition", objArray1);
        }

        public void ProcessLocalChangeList(ZoneChangeList changeList)
        {
            object[] objArray1 = new object[] { changeList };
            base.method_8("ProcessLocalChangeList", objArray1);
        }

        public void ProcessOrEnqueueLocalChangeList(ZoneChangeList changeList)
        {
            object[] objArray1 = new object[] { changeList };
            base.method_8("ProcessOrEnqueueLocalChangeList", objArray1);
        }

        public Triton.Game.Mapping.Entity RegisterTempEntity(int id)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { id };
            return base.method_15<Triton.Game.Mapping.Entity>("RegisterTempEntity", enumArray1, objArray1);
        }

        public Triton.Game.Mapping.Entity RegisterTempEntity(Triton.Game.Mapping.Entity entity)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { entity };
            return base.method_15<Triton.Game.Mapping.Entity>("RegisterTempEntity", enumArray1, objArray1);
        }

        public Triton.Game.Mapping.Entity RegisterTempEntity(Network.Entity netEnt)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { netEnt };
            return base.method_15<Triton.Game.Mapping.Entity>("RegisterTempEntity", enumArray1, objArray1);
        }

        public Triton.Game.Mapping.Entity RegisterTempEntity(int id, Triton.Game.Mapping.Entity entity)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4, Class272.Enum20.Class };
            object[] objArray1 = new object[] { id, entity };
            return base.method_15<Triton.Game.Mapping.Entity>("RegisterTempEntity", enumArray1, objArray1);
        }

        public float RemoveNextDeathBlockLayoutDelaySec()
        {
            return base.method_11<float>("RemoveNextDeathBlockLayoutDelaySec", Array.Empty<object>());
        }

        public bool ReplaceRemoteWeaponInServerChangeList(ZoneChangeList serverChangeList)
        {
            object[] objArray1 = new object[] { serverChangeList };
            return base.method_11<bool>("ReplaceRemoteWeaponInServerChangeList", objArray1);
        }

        public void RequestNextDeathBlockLayoutDelaySec(float sec)
        {
            object[] objArray1 = new object[] { sec };
            base.method_8("RequestNextDeathBlockLayoutDelaySec", objArray1);
        }

        public bool ShouldPostProcessServerChangeList(ZoneChangeList changeList)
        {
            object[] objArray1 = new object[] { changeList };
            return base.method_11<bool>("ShouldPostProcessServerChangeList", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void TempApplyZoneChange(ZoneChange change)
        {
            object[] objArray1 = new object[] { change };
            base.method_8("TempApplyZoneChange", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateLocalChangeLists()
        {
            base.method_8("UpdateLocalChangeLists", Array.Empty<object>());
        }

        public void UpdateServerChangeLists()
        {
            base.method_8("UpdateServerChangeLists", Array.Empty<object>());
        }

        public List<ZoneChangeList> m_activeLocalChangeLists
        {
            get
            {
                Class267<ZoneChangeList> class2 = base.method_3<Class267<ZoneChangeList>>("m_activeLocalChangeLists");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public ZoneChangeList m_activeServerChangeList
        {
            get
            {
                return base.method_3<ZoneChangeList>("m_activeServerChangeList");
            }
        }

        public float m_nextDeathBlockLayoutDelaySec
        {
            get
            {
                return base.method_2<float>("m_nextDeathBlockLayoutDelaySec");
            }
        }

        public int m_nextLocalChangeListId
        {
            get
            {
                return base.method_2<int>("m_nextLocalChangeListId");
            }
        }

        public int m_nextServerChangeListId
        {
            get
            {
                return base.method_2<int>("m_nextServerChangeListId");
            }
        }

        public List<ZoneChangeList> m_pendingLocalChangeLists
        {
            get
            {
                Class267<ZoneChangeList> class2 = base.method_3<Class267<ZoneChangeList>>("m_pendingLocalChangeLists");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<Zone> m_zones
        {
            get
            {
                Class267<Zone> class2 = base.method_3<Class267<Zone>>("m_zones");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        [Attribute38("ZoneMgr.TempZone")]
        public class TempZone : MonoClass
        {
            public TempZone(IntPtr address) : this(address, "TempZone")
            {
            }

            public TempZone(IntPtr address, string className) : base(address, className)
            {
            }

            public void AddEntity(Triton.Game.Mapping.Entity entity)
            {
                object[] objArray1 = new object[] { entity };
                base.method_8("AddEntity", objArray1);
            }

            public void AddInitialEntity(Triton.Game.Mapping.Entity entity)
            {
                object[] objArray1 = new object[] { entity };
                base.method_8("AddInitialEntity", objArray1);
            }

            public bool CanAcceptEntity(Triton.Game.Mapping.Entity entity)
            {
                object[] objArray1 = new object[] { entity };
                return base.method_11<bool>("CanAcceptEntity", objArray1);
            }

            public void ClearEntities()
            {
                base.method_8("ClearEntities", Array.Empty<object>());
            }

            public bool ContainsEntity(int entityId)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
                object[] objArray1 = new object[] { entityId };
                return base.method_10<bool>("ContainsEntity", enumArray1, objArray1);
            }

            public bool ContainsEntity(Triton.Game.Mapping.Entity entity)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
                object[] objArray1 = new object[] { entity };
                return base.method_10<bool>("ContainsEntity", enumArray1, objArray1);
            }

            public int FindEntityPos(int entityId)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
                object[] objArray1 = new object[] { entityId };
                return base.method_10<int>("FindEntityPos", enumArray1, objArray1);
            }

            public int FindEntityPos(Triton.Game.Mapping.Entity entity)
            {
                Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
                object[] objArray1 = new object[] { entity };
                return base.method_10<int>("FindEntityPos", enumArray1, objArray1);
            }

            public int FindEntityPosWithReplacements(int entityId)
            {
                object[] objArray1 = new object[] { entityId };
                return base.method_11<int>("FindEntityPosWithReplacements", objArray1);
            }

            public List<Triton.Game.Mapping.Entity> GetEntities()
            {
                Class267<Triton.Game.Mapping.Entity> class2 = base.method_14<Class267<Triton.Game.Mapping.Entity>>("GetEntities", Array.Empty<object>());
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }

            public Triton.Game.Mapping.Entity GetEntityAtIndex(int index)
            {
                object[] objArray1 = new object[] { index };
                return base.method_14<Triton.Game.Mapping.Entity>("GetEntityAtIndex", objArray1);
            }

            public Triton.Game.Mapping.Entity GetEntityAtPos(int pos)
            {
                object[] objArray1 = new object[] { pos };
                return base.method_14<Triton.Game.Mapping.Entity>("GetEntityAtPos", objArray1);
            }

            public int GetEntityCount()
            {
                return base.method_11<int>("GetEntityCount", Array.Empty<object>());
            }

            public int GetLastPos()
            {
                return base.method_11<int>("GetLastPos", Array.Empty<object>());
            }

            public Zone GetZone()
            {
                return base.method_14<Zone>("GetZone", Array.Empty<object>());
            }

            public void InsertEntityAtIndex(int index, Triton.Game.Mapping.Entity entity)
            {
                object[] objArray1 = new object[] { index, entity };
                base.method_8("InsertEntityAtIndex", objArray1);
            }

            public void InsertEntityAtPos(int pos, Triton.Game.Mapping.Entity entity)
            {
                object[] objArray1 = new object[] { pos, entity };
                base.method_8("InsertEntityAtPos", objArray1);
            }

            public bool IsModified()
            {
                return base.method_11<bool>("IsModified", Array.Empty<object>());
            }

            public void PostprocessChanges()
            {
                base.method_8("PostprocessChanges", Array.Empty<object>());
            }

            public void PreprocessChanges()
            {
                base.method_8("PreprocessChanges", Array.Empty<object>());
            }

            public bool RemoveEntity(Triton.Game.Mapping.Entity entity)
            {
                object[] objArray1 = new object[] { entity };
                return base.method_11<bool>("RemoveEntity", objArray1);
            }

            public void SetZone(Zone zone)
            {
                object[] objArray1 = new object[] { zone };
                base.method_8("SetZone", objArray1);
            }

            public void Sort()
            {
                base.method_8("Sort", Array.Empty<object>());
            }

            public int SortComparison(Triton.Game.Mapping.Entity entity1, Triton.Game.Mapping.Entity entity2)
            {
                object[] objArray1 = new object[] { entity1, entity2 };
                return base.method_11<int>("SortComparison", objArray1);
            }

            public string ToString()
            {
                return base.method_13("ToString", Array.Empty<object>());
            }

            public List<Triton.Game.Mapping.Entity> m_entities
            {
                get
                {
                    Class267<Triton.Game.Mapping.Entity> class2 = base.method_3<Class267<Triton.Game.Mapping.Entity>>("m_entities");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public bool m_modified
            {
                get
                {
                    return base.method_2<bool>("m_modified");
                }
            }

            public List<Triton.Game.Mapping.Entity> m_prevEntities
            {
                get
                {
                    Class267<Triton.Game.Mapping.Entity> class2 = base.method_3<Class267<Triton.Game.Mapping.Entity>>("m_prevEntities");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }

            public Zone m_zone
            {
                get
                {
                    return base.method_3<Zone>("m_zone");
                }
            }
        }
    }
}

