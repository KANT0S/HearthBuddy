namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SpellController")]
    public class SpellController : MonoBehaviour
    {
        public SpellController(IntPtr address) : this(address, "SpellController")
        {
        }

        public SpellController(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddPowerSourceAndTargets(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("AddPowerSourceAndTargets", objArray1);
        }

        public void AddTarget(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("AddTarget", objArray1);
        }

        public bool AttachPowerTaskList(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("AttachPowerTaskList", objArray1);
        }

        public PowerTaskList DetachPowerTaskList()
        {
            return base.method_14<PowerTaskList>("DetachPowerTaskList", Array.Empty<object>());
        }

        public void DoPowerTaskList()
        {
            base.method_8("DoPowerTaskList", Array.Empty<object>());
        }

        public void FireFinishedCallbacks()
        {
            base.method_8("FireFinishedCallbacks", Array.Empty<object>());
        }

        public void FireFinishedTaskListCallbacks()
        {
            base.method_8("FireFinishedTaskListCallbacks", Array.Empty<object>());
        }

        public void ForceKill()
        {
            base.method_8("ForceKill", Array.Empty<object>());
        }

        public PowerTaskList GetPowerTaskList()
        {
            return base.method_14<PowerTaskList>("GetPowerTaskList", Array.Empty<object>());
        }

        public Card GetSource()
        {
            return base.method_14<Card>("GetSource", Array.Empty<object>());
        }

        public Card GetTarget()
        {
            return base.method_14<Card>("GetTarget", Array.Empty<object>());
        }

        public Card GetTargetCardFromPowerTask(PowerTask task)
        {
            object[] objArray1 = new object[] { task };
            return base.method_14<Card>("GetTargetCardFromPowerTask", objArray1);
        }

        public List<Card> GetTargets()
        {
            Class267<Card> class2 = base.method_14<Class267<Card>>("GetTargets", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public bool HasSourceCard(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("HasSourceCard", objArray1);
        }

        public bool IsCardBusy(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("IsCardBusy", objArray1);
        }

        public bool IsProcessingTaskList()
        {
            return base.method_11<bool>("IsProcessingTaskList", Array.Empty<object>());
        }

        public bool IsSource(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("IsSource", objArray1);
        }

        public bool IsTarget(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_11<bool>("IsTarget", objArray1);
        }

        public void OnFinished()
        {
            base.method_8("OnFinished", Array.Empty<object>());
        }

        public void OnFinishedTaskList()
        {
            base.method_8("OnFinishedTaskList", Array.Empty<object>());
        }

        public void OnProcessTaskList()
        {
            base.method_8("OnProcessTaskList", Array.Empty<object>());
        }

        public void RemoveAllTargets()
        {
            base.method_8("RemoveAllTargets", Array.Empty<object>());
        }

        public void RemoveSource()
        {
            base.method_8("RemoveSource", Array.Empty<object>());
        }

        public void RemoveTarget(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("RemoveTarget", objArray1);
        }

        public void SetPowerTaskList(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            base.method_8("SetPowerTaskList", objArray1);
        }

        public void SetSource(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("SetSource", objArray1);
        }

        public bool WillEntityLoadCard(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("WillEntityLoadCard", objArray1);
        }

        public static float CREATED_EFFECT_FINISH_FUDGE_SEC
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SpellController", "CREATED_EFFECT_FINISH_FUDGE_SEC");
            }
        }

        public bool m_pendingFinish
        {
            get
            {
                return base.method_2<bool>("m_pendingFinish");
            }
        }

        public bool m_processingTaskList
        {
            get
            {
                return base.method_2<bool>("m_processingTaskList");
            }
        }

        public Card m_source
        {
            get
            {
                return base.method_3<Card>("m_source");
            }
        }

        public List<Card> m_targets
        {
            get
            {
                Class267<Card> class2 = base.method_3<Class267<Card>>("m_targets");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public PowerTaskList m_taskList
        {
            get
            {
                return base.method_3<PowerTaskList>("m_taskList");
            }
        }

        public static float MAX_WAIT_FOR_CARD_READY_SEC
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "SpellController", "MAX_WAIT_FOR_CARD_READY_SEC");
            }
        }
    }
}

