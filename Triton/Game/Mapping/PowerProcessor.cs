namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("PowerProcessor")]
    public class PowerProcessor : MonoClass
    {
        public PowerProcessor(IntPtr address) : this(address, "PowerProcessor")
        {
        }

        public PowerProcessor(IntPtr address, string className) : base(address, className)
        {
        }

        public void CancelSpellsForEarlyConcede(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            base.method_8("CancelSpellsForEarlyConcede", objArray1);
        }

        public bool CanEarlyConcede()
        {
            return base.method_11<bool>("CanEarlyConcede", Array.Empty<object>());
        }

        public void Clear()
        {
            base.method_8("Clear", Array.Empty<object>());
        }

        public AttackSpellController CreateAttackSpellController(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_14<AttackSpellController>("CreateAttackSpellController", objArray1);
        }

        public DeathSpellController CreateDeathSpellController(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_14<DeathSpellController>("CreateDeathSpellController", objArray1);
        }

        public FatigueSpellController CreateFatigueSpellController(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_14<FatigueSpellController>("CreateFatigueSpellController", objArray1);
        }

        public JoustSpellController CreateJoustSpellController(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_14<JoustSpellController>("CreateJoustSpellController", objArray1);
        }

        public PowerSpellController CreatePowerSpellController(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_14<PowerSpellController>("CreatePowerSpellController", objArray1);
        }

        public SecretSpellController CreateSecretSpellController(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_14<SecretSpellController>("CreateSecretSpellController", objArray1);
        }

        public TriggerSpellController CreateTriggerSpellController(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_14<TriggerSpellController>("CreateTriggerSpellController", objArray1);
        }

        public void DestroySpellController(SpellController spellController)
        {
            object[] objArray1 = new object[] { spellController };
            base.method_8("DestroySpellController", objArray1);
        }

        public void DoCurrentTaskList()
        {
            base.method_8("DoCurrentTaskList", Array.Empty<object>());
        }

        public bool DoTaskListWithSpellController(GameState state, PowerTaskList taskList, Triton.Game.Mapping.Entity sourceEntity)
        {
            object[] objArray1 = new object[] { state, taskList, sourceEntity };
            return base.method_11<bool>("DoTaskListWithSpellController", objArray1);
        }

        public void EndCurrentTaskList()
        {
            base.method_8("EndCurrentTaskList", Array.Empty<object>());
        }

        public void EnqueueTaskList(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            base.method_8("EnqueueTaskList", objArray1);
        }

        public string FindRevealedCardId(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_13("FindRevealedCardId", objArray1);
        }

        public void ForceEarlyConcedeVisuals()
        {
            base.method_8("ForceEarlyConcedeVisuals", Array.Empty<object>());
        }

        public PowerTaskList GetCurrentTaskList()
        {
            return base.method_14<PowerTaskList>("GetCurrentTaskList", Array.Empty<object>());
        }

        public PowerTaskList GetEarlyConcedeTaskList()
        {
            return base.method_14<PowerTaskList>("GetEarlyConcedeTaskList", Array.Empty<object>());
        }

        public PowerTaskList GetGameOverTaskList()
        {
            return base.method_14<PowerTaskList>("GetGameOverTaskList", Array.Empty<object>());
        }

        public PowerTaskList GetLastTaskList()
        {
            return base.method_14<PowerTaskList>("GetLastTaskList", Array.Empty<object>());
        }

        public PowerTaskList GetLatestUnendedTaskList()
        {
            return base.method_14<PowerTaskList>("GetLatestUnendedTaskList", Array.Empty<object>());
        }

        public int GetNextTaskListId()
        {
            return base.method_11<int>("GetNextTaskListId", Array.Empty<object>());
        }

        public bool HasEarlyConcedeTaskList()
        {
            return base.method_11<bool>("HasEarlyConcedeTaskList", Array.Empty<object>());
        }

        public bool HasGameOverTaskList()
        {
            return base.method_11<bool>("HasGameOverTaskList", Array.Empty<object>());
        }

        public bool HasTaskList(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("HasTaskList", objArray1);
        }

        public bool HasTaskLists()
        {
            return base.method_11<bool>("HasTaskLists", Array.Empty<object>());
        }

        public bool IsBuildingTaskList()
        {
            return base.method_11<bool>("IsBuildingTaskList", Array.Empty<object>());
        }

        public bool IsBusy()
        {
            return base.method_11<bool>("IsBusy", Array.Empty<object>());
        }

        public void NotifyWillProcessTaskList(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            base.method_8("NotifyWillProcessTaskList", objArray1);
        }

        public void OnBigCardFinished()
        {
            base.method_8("OnBigCardFinished", Array.Empty<object>());
        }

        public void OnSpellControllerFinished(SpellController spellController)
        {
            object[] objArray1 = new object[] { spellController };
            base.method_8("OnSpellControllerFinished", objArray1);
        }

        public void OnSpellControllerFinishedTaskList(SpellController spellController)
        {
            object[] objArray1 = new object[] { spellController };
            base.method_8("OnSpellControllerFinishedTaskList", objArray1);
        }

        public void PrepareHistoryForCurrentTaskList()
        {
            base.method_8("PrepareHistoryForCurrentTaskList", Array.Empty<object>());
        }

        public void ProcessPowerQueue()
        {
            base.method_8("ProcessPowerQueue", Array.Empty<object>());
        }

        public bool ShouldShowPlayedBigCard(Triton.Game.Mapping.Entity sourceEntity)
        {
            object[] objArray1 = new object[] { sourceEntity };
            return base.method_11<bool>("ShouldShowPlayedBigCard", objArray1);
        }

        public bool ShouldShowTriggeredBigCard(Triton.Game.Mapping.Entity sourceEntity)
        {
            object[] objArray1 = new object[] { sourceEntity };
            return base.method_11<bool>("ShouldShowTriggeredBigCard", objArray1);
        }

        public void StartCurrentTaskList()
        {
            base.method_8("StartCurrentTaskList", Array.Empty<object>());
        }

        public static string ATTACK_SPELL_CONTROLLER_PREFAB_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "PowerProcessor", "ATTACK_SPELL_CONTROLLER_PREFAB_NAME");
            }
        }

        public static string JOUST_SPELL_CONTROLLER_PREFAB_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "PowerProcessor", "JOUST_SPELL_CONTROLLER_PREFAB_NAME");
            }
        }

        public bool m_buildingTaskList
        {
            get
            {
                return base.method_2<bool>("m_buildingTaskList");
            }
        }

        public PowerTaskList m_busyTaskList
        {
            get
            {
                return base.method_3<PowerTaskList>("m_busyTaskList");
            }
        }

        public PowerTaskList m_currentTaskList
        {
            get
            {
                return base.method_3<PowerTaskList>("m_currentTaskList");
            }
        }

        public PowerTaskList m_earlyConcedeTaskList
        {
            get
            {
                return base.method_3<PowerTaskList>("m_earlyConcedeTaskList");
            }
        }

        public PowerTaskList m_gameOverTaskList
        {
            get
            {
                return base.method_3<PowerTaskList>("m_gameOverTaskList");
            }
        }

        public bool m_handledFirstEarlyConcede
        {
            get
            {
                return base.method_2<bool>("m_handledFirstEarlyConcede");
            }
        }

        public bool m_historyBlocking
        {
            get
            {
                return base.method_2<bool>("m_historyBlocking");
            }
        }

        public PowerTaskList m_historyBlockingTaskList
        {
            get
            {
                return base.method_3<PowerTaskList>("m_historyBlockingTaskList");
            }
        }

        public int m_nextTaskListId
        {
            get
            {
                return base.method_2<int>("m_nextTaskListId");
            }
        }

        public static string SECRET_SPELL_CONTROLLER_PREFAB_NAME
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "PowerProcessor", "SECRET_SPELL_CONTROLLER_PREFAB_NAME");
            }
        }
    }
}

