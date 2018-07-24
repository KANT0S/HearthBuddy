namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("SuperSpell")]
    public class SuperSpell : Spell
    {
        public SuperSpell(IntPtr address) : this(address, "SuperSpell")
        {
        }

        public SuperSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddAllTargetsAsVisualTargets()
        {
            base.method_8("AddAllTargetsAsVisualTargets", Array.Empty<object>());
        }

        public void AddChosenTargetAsVisualTarget()
        {
            base.method_8("AddChosenTargetAsVisualTarget", Array.Empty<object>());
        }

        public bool AddPowerTargets()
        {
            return base.method_11<bool>("AddPowerTargets", Array.Empty<object>());
        }

        public bool AddPrimaryChainTarget()
        {
            return base.method_11<bool>("AddPrimaryChainTarget", Array.Empty<object>());
        }

        public void AddTargetFromMetaData(int metaDataIndex, Card targetCard)
        {
            object[] objArray1 = new object[] { metaDataIndex, targetCard };
            base.method_8("AddTargetFromMetaData", objArray1);
        }

        public void AddVisualTarget(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            base.method_8("AddVisualTarget", objArray1);
        }

        public bool AreEffectsActive()
        {
            return base.method_11<bool>("AreEffectsActive", Array.Empty<object>());
        }

        public bool CheckAndWaitForGameEventsThenDoAction()
        {
            return base.method_11<bool>("CheckAndWaitForGameEventsThenDoAction", Array.Empty<object>());
        }

        public bool CheckAndWaitForStartDelayThenDoAction()
        {
            return base.method_11<bool>("CheckAndWaitForStartDelayThenDoAction", Array.Empty<object>());
        }

        public bool CheckAndWaitForStartPrefabThenDoAction()
        {
            return base.method_11<bool>("CheckAndWaitForStartPrefabThenDoAction", Array.Empty<object>());
        }

        public void CleanUp()
        {
            base.method_8("CleanUp", Array.Empty<object>());
        }

        public Spell CloneSpell(Spell prefab)
        {
            object[] objArray1 = new object[] { prefab };
            return base.method_14<Spell>("CloneSpell", objArray1);
        }

        public SpellAreaEffectInfo DetermineAreaEffectInfo()
        {
            return base.method_14<SpellAreaEffectInfo>("DetermineAreaEffectInfo", Array.Empty<object>());
        }

        public Spell DetermineImpactPrefab(GameObject targetObject)
        {
            object[] objArray1 = new object[] { targetObject };
            return base.method_14<Spell>("DetermineImpactPrefab", objArray1);
        }

        public void DoAction()
        {
            base.method_8("DoAction", Array.Empty<object>());
        }

        public void DoActionAfterGameEvents()
        {
            base.method_8("DoActionAfterGameEvents", Array.Empty<object>());
        }

        public bool DoActionDuringGameEvents()
        {
            return base.method_11<bool>("DoActionDuringGameEvents", Array.Empty<object>());
        }

        public void DoActionNow()
        {
            base.method_8("DoActionNow", Array.Empty<object>());
        }

        public void DoStartSpellAction()
        {
            base.method_8("DoStartSpellAction", Array.Empty<object>());
        }

        public void FinishIfPossible()
        {
            base.method_8("FinishIfPossible", Array.Empty<object>());
        }

        public void FireMissileOnPath(Spell missile, int targetIndex, bool reverse)
        {
            object[] objArray1 = new object[] { missile, targetIndex, reverse };
            base.method_8("FireMissileOnPath", objArray1);
        }

        public void GenerateCreatedCardsTargets()
        {
            base.method_8("GenerateCreatedCardsTargets", Array.Empty<object>());
        }

        public List<Vector3> GenerateMissilePath(Spell missile)
        {
            object[] objArray1 = new object[] { missile };
            Class246<Vector3> class2 = base.method_14<Class246<Vector3>>("GenerateMissilePath", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void GenerateRandomBoardVisualTargets()
        {
            base.method_8("GenerateRandomBoardVisualTargets", Array.Empty<object>());
        }

        public void GenerateRandomPlayZoneVisualTargets(ZonePlay zonePlay)
        {
            object[] objArray1 = new object[] { zonePlay };
            base.method_8("GenerateRandomPlayZoneVisualTargets", objArray1);
        }

        public void GenerateRandomVisualTargets(Bounds bounds)
        {
            object[] objArray1 = new object[] { bounds };
            base.method_8("GenerateRandomVisualTargets", objArray1);
        }

        public void GenerateVisualTarget(Vector3 position, int index, int boxIndex)
        {
            object[] objArray1 = new object[] { position, index, boxIndex };
            base.method_8("GenerateVisualTarget", objArray1);
        }

        public Triton.Game.Mapping.Entity GetEntityFromZoneChangePowerTask(PowerTask task)
        {
            object[] objArray1 = new object[] { task };
            return base.method_14<Triton.Game.Mapping.Entity>("GetEntityFromZoneChangePowerTask", objArray1);
        }

        public int GetMetaDataIndexForTarget(int visualTargetIndex)
        {
            object[] objArray1 = new object[] { visualTargetIndex };
            return base.method_11<int>("GetMetaDataIndexForTarget", objArray1);
        }

        public GameObject GetPrimaryTarget()
        {
            return base.method_14<GameObject>("GetPrimaryTarget", Array.Empty<object>());
        }

        public int GetPrimaryTargetIndex()
        {
            return base.method_11<int>("GetPrimaryTargetIndex", Array.Empty<object>());
        }

        public GameObject GetVisualTarget()
        {
            return base.method_14<GameObject>("GetVisualTarget", Array.Empty<object>());
        }

        public Card GetVisualTargetCard()
        {
            return base.method_14<Card>("GetVisualTargetCard", Array.Empty<object>());
        }

        public int GetVisualTargetCount()
        {
            return base.method_11<int>("GetVisualTargetCount", Array.Empty<object>());
        }

        public List<GameObject> GetVisualTargets()
        {
            Class267<GameObject> class2 = base.method_14<Class267<GameObject>>("GetVisualTargets", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public bool HasAreaEffect()
        {
            return base.method_11<bool>("HasAreaEffect", Array.Empty<object>());
        }

        public bool HasChain()
        {
            return base.method_11<bool>("HasChain", Array.Empty<object>());
        }

        public bool HasFriendlyAreaEffect()
        {
            return base.method_11<bool>("HasFriendlyAreaEffect", Array.Empty<object>());
        }

        public bool HasImpact()
        {
            return base.method_11<bool>("HasImpact", Array.Empty<object>());
        }

        public bool HasMetaDataTargets()
        {
            return base.method_11<bool>("HasMetaDataTargets", Array.Empty<object>());
        }

        public bool HasMissile()
        {
            return base.method_11<bool>("HasMissile", Array.Empty<object>());
        }

        public bool HasOpponentAreaEffect()
        {
            return base.method_11<bool>("HasOpponentAreaEffect", Array.Empty<object>());
        }

        public bool HasStart()
        {
            return base.method_11<bool>("HasStart", Array.Empty<object>());
        }

        public bool IsMakingClones()
        {
            return base.method_11<bool>("IsMakingClones", Array.Empty<object>());
        }

        public bool IsVisualTarget(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return base.method_11<bool>("IsVisualTarget", objArray1);
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public void OnBirth(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnBirth", objArray1);
        }

        public void OnCancel(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnCancel", objArray1);
        }

        public void OnCloneSpellFinished(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnCloneSpellFinished", objArray1);
        }

        public void OnCloneSpellStateStarted(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnCloneSpellStateStarted", objArray1);
        }

        public void OnMetaDataTasksComplete(PowerTaskList taskList, int startIndex, int count, object userData)
        {
            object[] objArray1 = new object[] { taskList, startIndex, count, userData };
            base.method_8("OnMetaDataTasksComplete", objArray1);
        }

        public void OnMissileSpellStateFinished(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnMissileSpellStateFinished", objArray1);
        }

        public void OnReverseMissileTargetReached(Spell missile)
        {
            object[] objArray1 = new object[] { missile };
            base.method_8("OnReverseMissileTargetReached", objArray1);
        }

        public void OnSpellFinished()
        {
            base.method_8("OnSpellFinished", Array.Empty<object>());
        }

        public void OnStartSpellActionFinished(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnStartSpellActionFinished", objArray1);
        }

        public void OnStartSpellBirthStateFinished(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnStartSpellBirthStateFinished", objArray1);
        }

        public void OnStateFinished()
        {
            base.method_8("OnStateFinished", Array.Empty<object>());
        }

        public void RemoveAllVisualTargets()
        {
            base.method_8("RemoveAllVisualTargets", Array.Empty<object>());
        }

        public bool RemoveVisualTarget(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return base.method_11<bool>("RemoveVisualTarget", objArray1);
        }

        public bool ShouldCompleteTasksUntilMetaData(int metaDataIndex)
        {
            object[] objArray1 = new object[] { metaDataIndex };
            return base.method_11<bool>("ShouldCompleteTasksUntilMetaData", objArray1);
        }

        public void SpawnAllImpacts()
        {
            base.method_8("SpawnAllImpacts", Array.Empty<object>());
        }

        public void SpawnAllMissiles()
        {
            base.method_8("SpawnAllMissiles", Array.Empty<object>());
        }

        public void SpawnAreaEffect(SpellAreaEffectInfo info)
        {
            object[] objArray1 = new object[] { info };
            base.method_8("SpawnAreaEffect", objArray1);
        }

        public void SpawnChain()
        {
            base.method_8("SpawnChain", Array.Empty<object>());
        }

        public void SpawnChainMissile()
        {
            base.method_8("SpawnChainMissile", Array.Empty<object>());
        }

        public void SpawnImpact(int targetIndex)
        {
            object[] objArray1 = new object[] { targetIndex };
            base.method_8("SpawnImpact", objArray1);
        }

        public void SpawnMissile(int targetIndex)
        {
            object[] objArray1 = new object[] { targetIndex };
            base.method_8("SpawnMissile", objArray1);
        }

        public void SpawnMissileInSequence()
        {
            base.method_8("SpawnMissileInSequence", Array.Empty<object>());
        }

        public void SpawnStart()
        {
            base.method_8("SpawnStart", Array.Empty<object>());
        }

        public void UpdatePendingStateChangeFlags(SpellStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("UpdatePendingStateChangeFlags", objArray1);
        }

        public void UpdateVisualTargets()
        {
            base.method_8("UpdateVisualTargets", Array.Empty<object>());
        }

        public SpellActionInfo m_ActionInfo
        {
            get
            {
                return base.method_3<SpellActionInfo>("m_ActionInfo");
            }
        }

        public SpellChainInfo m_ChainInfo
        {
            get
            {
                return base.method_3<SpellChainInfo>("m_ChainInfo");
            }
        }

        public int m_currentTargetIndex
        {
            get
            {
                return base.method_2<int>("m_currentTargetIndex");
            }
        }

        public int m_effectsPendingFinish
        {
            get
            {
                return base.method_2<int>("m_effectsPendingFinish");
            }
        }

        public SpellAreaEffectInfo m_FriendlyAreaEffectInfo
        {
            get
            {
                return base.method_3<SpellAreaEffectInfo>("m_FriendlyAreaEffectInfo");
            }
        }

        public SpellImpactInfo m_ImpactInfo
        {
            get
            {
                return base.method_3<SpellImpactInfo>("m_ImpactInfo");
            }
        }

        public bool m_MakeClones
        {
            get
            {
                return base.method_2<bool>("m_MakeClones");
            }
        }

        public SpellMissileInfo m_MissileInfo
        {
            get
            {
                return base.method_3<SpellMissileInfo>("m_MissileInfo");
            }
        }

        public SpellAreaEffectInfo m_OpponentAreaEffectInfo
        {
            get
            {
                return base.method_3<SpellAreaEffectInfo>("m_OpponentAreaEffectInfo");
            }
        }

        public bool m_pendingNoneStateChange
        {
            get
            {
                return base.method_2<bool>("m_pendingNoneStateChange");
            }
        }

        public bool m_pendingSpellFinish
        {
            get
            {
                return base.method_2<bool>("m_pendingSpellFinish");
            }
        }

        public bool m_settingUpAction
        {
            get
            {
                return base.method_2<bool>("m_settingUpAction");
            }
        }

        public SpellStartInfo m_StartInfo
        {
            get
            {
                return base.method_3<SpellStartInfo>("m_StartInfo");
            }
        }

        public Spell m_startSpell
        {
            get
            {
                return base.method_3<Spell>("m_startSpell");
            }
        }

        public SpellTargetInfo m_TargetInfo
        {
            get
            {
                return base.method_3<SpellTargetInfo>("m_TargetInfo");
            }
        }

        public List<GameObject> m_visualTargets
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_visualTargets");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

