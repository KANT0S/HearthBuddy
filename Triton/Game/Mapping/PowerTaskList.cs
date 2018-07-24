namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("PowerTaskList")]
    public class PowerTaskList : MonoClass
    {
        public PowerTaskList(IntPtr address) : this(address, "PowerTaskList")
        {
        }

        public PowerTaskList(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AreTasksComplete()
        {
            return base.method_11<bool>("AreTasksComplete", Array.Empty<object>());
        }

        public bool AreZoneChangesComplete()
        {
            return base.method_11<bool>("AreZoneChangesComplete", Array.Empty<object>());
        }

        public void BuildAttackData()
        {
            base.method_8("BuildAttackData", Array.Empty<object>());
        }

        public AttackInfo BuildAttackInfo()
        {
            return base.method_14<AttackInfo>("BuildAttackInfo", Array.Empty<object>());
        }

        public PowerTask CreateTask(Network.PowerHistory netPower)
        {
            object[] objArray1 = new object[] { netPower };
            return base.method_14<PowerTask>("CreateTask", objArray1);
        }

        public void DebugDump()
        {
            base.method_9("DebugDump", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void DebugDump(Logger logger)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { logger };
            base.method_9("DebugDump", enumArray1, objArray1);
        }

        public bool DidBlockSpawnHistoryTile()
        {
            return base.method_11<bool>("DidBlockSpawnHistoryTile", Array.Empty<object>());
        }

        public bool DidSpawnHistoryTile()
        {
            return base.method_11<bool>("DidSpawnHistoryTile", Array.Empty<object>());
        }

        public void DoAllTasks()
        {
            base.method_9("DoAllTasks", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void DoEarlyConcedeTasks()
        {
            base.method_8("DoEarlyConcedeTasks", Array.Empty<object>());
        }

        public bool DoesBlockHaveEndAction()
        {
            return base.method_11<bool>("DoesBlockHaveEndAction", Array.Empty<object>());
        }

        public bool DoesBlockHaveMetaDataTasks()
        {
            return base.method_10<bool>("DoesBlockHaveMetaDataTasks", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void DoTasks(int startIndex, int count)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { startIndex, count };
            base.method_9("DoTasks", enumArray1, objArray1);
        }

        public int FindEarlierIncompleteTaskIndex(int taskIndex)
        {
            object[] objArray1 = new object[] { taskIndex };
            return base.method_11<int>("FindEarlierIncompleteTaskIndex", objArray1);
        }

        public Triton.Game.Mapping.Entity GetAttacker()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetAttacker", Array.Empty<object>());
        }

        public AttackInfo GetAttackInfo()
        {
            return base.method_14<AttackInfo>("GetAttackInfo", Array.Empty<object>());
        }

        public AttackType GetAttackType()
        {
            return base.method_11<AttackType>("GetAttackType", Array.Empty<object>());
        }

        public DamageInfo GetDamageInfo(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_14<DamageInfo>("GetDamageInfo", objArray1);
        }

        public Triton.Game.Mapping.Entity GetDefender()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetDefender", Array.Empty<object>());
        }

        public Network.HistActionEnd GetEndAction()
        {
            return base.method_14<Network.HistActionEnd>("GetEndAction", Array.Empty<object>());
        }

        public int GetId()
        {
            return base.method_11<int>("GetId", Array.Empty<object>());
        }

        public PowerTaskList GetLast()
        {
            return base.method_14<PowerTaskList>("GetLast", Array.Empty<object>());
        }

        public PowerTaskList GetNext()
        {
            return base.method_14<PowerTaskList>("GetNext", Array.Empty<object>());
        }

        public PowerTaskList GetOrigin()
        {
            return base.method_14<PowerTaskList>("GetOrigin", Array.Empty<object>());
        }

        public PowerTaskList GetParent()
        {
            return base.method_14<PowerTaskList>("GetParent", Array.Empty<object>());
        }

        public PowerTaskList GetPrevious()
        {
            return base.method_14<PowerTaskList>("GetPrevious", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetProposedDefender()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetProposedDefender", Array.Empty<object>());
        }

        public Network.HistActionStart GetSourceAction()
        {
            return base.method_14<Network.HistActionStart>("GetSourceAction", Array.Empty<object>());
        }

        public CardDef GetSourceActionEffectCardDef()
        {
            return base.method_14<CardDef>("GetSourceActionEffectCardDef", Array.Empty<object>());
        }

        public string GetSourceActionEffectCardId()
        {
            return base.method_13("GetSourceActionEffectCardId", Array.Empty<object>());
        }

        public EntityDef GetSourceActionEffectEntityDef()
        {
            return base.method_14<EntityDef>("GetSourceActionEffectEntityDef", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetSourceEntity()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetSourceEntity", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetTargetEntity()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetTargetEntity", Array.Empty<object>());
        }

        public List<PowerTask> GetTaskList()
        {
            Class267<PowerTask> class2 = base.method_14<Class267<PowerTask>>("GetTaskList", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public bool HasEarlierIncompleteTask(int taskIndex)
        {
            object[] objArray1 = new object[] { taskIndex };
            return base.method_11<bool>("HasEarlierIncompleteTask", objArray1);
        }

        public bool HasFriendlyConcede()
        {
            return base.method_11<bool>("HasFriendlyConcede", Array.Empty<object>());
        }

        public bool HasGameOver()
        {
            return base.method_11<bool>("HasGameOver", Array.Empty<object>());
        }

        public bool HasMetaDataTasks()
        {
            return base.method_10<bool>("HasMetaDataTasks", new Class272.Enum20[0], Array.Empty<object>());
        }

        public bool HasTargetEntity()
        {
            return base.method_11<bool>("HasTargetEntity", Array.Empty<object>());
        }

        public bool HasTasks()
        {
            return base.method_11<bool>("HasTasks", Array.Empty<object>());
        }

        public bool HasTasksOfType(Network.PowerType powType)
        {
            object[] objArray1 = new object[] { powType };
            return base.method_11<bool>("HasTasksOfType", objArray1);
        }

        public bool HasZoneChanges()
        {
            return base.method_11<bool>("HasZoneChanges", Array.Empty<object>());
        }

        public bool IsBlock()
        {
            return base.method_11<bool>("IsBlock", Array.Empty<object>());
        }

        public bool IsBlockUnended()
        {
            return base.method_11<bool>("IsBlockUnended", Array.Empty<object>());
        }

        public bool IsComplete()
        {
            return base.method_11<bool>("IsComplete", Array.Empty<object>());
        }

        public bool IsDescendantOfBlock(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("IsDescendantOfBlock", objArray1);
        }

        public bool IsEarlierInBlockThan(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("IsEarlierInBlockThan", objArray1);
        }

        public bool IsEmpty()
        {
            return base.method_11<bool>("IsEmpty", Array.Empty<object>());
        }

        public bool IsEndOfBlock()
        {
            return base.method_11<bool>("IsEndOfBlock", Array.Empty<object>());
        }

        public bool IsInBlock(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("IsInBlock", objArray1);
        }

        public bool IsLaterInBlockThan(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("IsLaterInBlockThan", objArray1);
        }

        public bool IsOrigin()
        {
            return base.method_11<bool>("IsOrigin", Array.Empty<object>());
        }

        public bool IsSourceActionOrigin()
        {
            return base.method_11<bool>("IsSourceActionOrigin", Array.Empty<object>());
        }

        public bool IsSourceOfBlock()
        {
            return base.method_11<bool>("IsSourceOfBlock", Array.Empty<object>());
        }

        public void NotifyHistoryOfAdditionalTargets()
        {
            base.method_8("NotifyHistoryOfAdditionalTargets", Array.Empty<object>());
        }

        public void OnZoneChangeComplete(ZoneChangeList changeList, object userData)
        {
            object[] objArray1 = new object[] { changeList, userData };
            base.method_8("OnZoneChangeComplete", objArray1);
        }

        public void SetEndAction(Network.HistActionEnd endAction)
        {
            object[] objArray1 = new object[] { endAction };
            base.method_8("SetEndAction", objArray1);
        }

        public void SetId(int id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("SetId", objArray1);
        }

        public void SetParent(PowerTaskList parent)
        {
            object[] objArray1 = new object[] { parent };
            base.method_8("SetParent", objArray1);
        }

        public void SetPrevious(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            base.method_8("SetPrevious", objArray1);
        }

        public void SetSourceAction(Network.HistActionStart startAction)
        {
            object[] objArray1 = new object[] { startAction };
            base.method_8("SetSourceAction", objArray1);
        }

        public void SetSpawnedHistoryTile(bool set)
        {
            object[] objArray1 = new object[] { set };
            base.method_8("SetSpawnedHistoryTile", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public bool WasThePlayedSpellCountered(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("WasThePlayedSpellCountered", objArray1);
        }

        public bool m_attackDataBuilt
        {
            get
            {
                return base.method_2<bool>("m_attackDataBuilt");
            }
        }

        public Triton.Game.Mapping.Entity m_attacker
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Entity>("m_attacker");
            }
        }

        public AttackInfo m_attackInfo
        {
            get
            {
                return base.method_3<AttackInfo>("m_attackInfo");
            }
        }

        public AttackType m_attackType
        {
            get
            {
                return base.method_2<AttackType>("m_attackType");
            }
        }

        public Triton.Game.Mapping.Entity m_defender
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Entity>("m_defender");
            }
        }

        public Network.HistActionEnd m_endAction
        {
            get
            {
                return base.method_3<Network.HistActionEnd>("m_endAction");
            }
        }

        public int m_id
        {
            get
            {
                return base.method_2<int>("m_id");
            }
        }

        public PowerTaskList m_next
        {
            get
            {
                return base.method_3<PowerTaskList>("m_next");
            }
        }

        public PowerTaskList m_parent
        {
            get
            {
                return base.method_3<PowerTaskList>("m_parent");
            }
        }

        public PowerTaskList m_previous
        {
            get
            {
                return base.method_3<PowerTaskList>("m_previous");
            }
        }

        public Triton.Game.Mapping.Entity m_proposedDefender
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Entity>("m_proposedDefender");
            }
        }

        public Network.HistActionStart m_sourceAction
        {
            get
            {
                return base.method_3<Network.HistActionStart>("m_sourceAction");
            }
        }

        public bool m_spawnedHistoryTile
        {
            get
            {
                return base.method_2<bool>("m_spawnedHistoryTile");
            }
        }

        public List<PowerTask> m_tasks
        {
            get
            {
                Class267<PowerTask> class2 = base.method_3<Class267<PowerTask>>("m_tasks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public ZoneChangeList m_zoneChangeList
        {
            get
            {
                return base.method_3<ZoneChangeList>("m_zoneChangeList");
            }
        }

        [Attribute38("PowerTaskList.DamageInfo")]
        public class DamageInfo : MonoClass
        {
            public DamageInfo(IntPtr address) : this(address, "DamageInfo")
            {
            }

            public DamageInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public int m_damage
            {
                get
                {
                    return base.method_2<int>("m_damage");
                }
            }

            public Triton.Game.Mapping.Entity m_entity
            {
                get
                {
                    return base.method_3<Triton.Game.Mapping.Entity>("m_entity");
                }
            }
        }

        [Attribute38("PowerTaskList.ZoneChangeCallbackData")]
        public class ZoneChangeCallbackData : MonoClass
        {
            public ZoneChangeCallbackData(IntPtr address) : this(address, "ZoneChangeCallbackData")
            {
            }

            public ZoneChangeCallbackData(IntPtr address, string className) : base(address, className)
            {
            }

            public int m_count
            {
                get
                {
                    return base.method_2<int>("m_count");
                }
            }

            public int m_startIndex
            {
                get
                {
                    return base.method_2<int>("m_startIndex");
                }
            }

            public object m_taskListUserData
            {
                get
                {
                    return base.method_3<object>("m_taskListUserData");
                }
            }
        }
    }
}

