namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("UnopenedPack")]
    public class UnopenedPack : PegUIElement
    {
        public UnopenedPack(IntPtr address) : this(address, "UnopenedPack")
        {
        }

        public UnopenedPack(IntPtr address, string className) : base(address, className)
        {
        }

        public UnopenedPack AcquireDraggedPack()
        {
            return base.method_14<UnopenedPack>("AcquireDraggedPack", Array.Empty<object>());
        }

        public void AddBooster()
        {
            base.method_8("AddBooster", Array.Empty<object>());
        }

        public void AddBoosters(int numNewBoosters)
        {
            object[] objArray1 = new object[] { numNewBoosters };
            base.method_8("AddBoosters", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool CanOpenPack()
        {
            return base.method_11<bool>("CanOpenPack", Array.Empty<object>());
        }

        public NetCache.BoosterStack GetBoosterStack()
        {
            return base.method_14<NetCache.BoosterStack>("GetBoosterStack", Array.Empty<object>());
        }

        public UnopenedPack GetCreatorPack()
        {
            return base.method_14<UnopenedPack>("GetCreatorPack", Array.Empty<object>());
        }

        public UnopenedPack GetDraggedPack()
        {
            return base.method_14<UnopenedPack>("GetDraggedPack", Array.Empty<object>());
        }

        public void OnDragStopSpellStateFinished(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnDragStopSpellStateFinished", objArray1);
        }

        public void PlayAlert()
        {
            base.method_8("PlayAlert", Array.Empty<object>());
        }

        public void ReleaseDraggedPack()
        {
            base.method_8("ReleaseDraggedPack", Array.Empty<object>());
        }

        public void RemoveBooster()
        {
            base.method_8("RemoveBooster", Array.Empty<object>());
        }

        public void SetBoosterStack(NetCache.BoosterStack boosterStack)
        {
            object[] objArray1 = new object[] { boosterStack };
            base.method_8("SetBoosterStack", objArray1);
        }

        public void StopAlert()
        {
            base.method_8("StopAlert", Array.Empty<object>());
        }

        public void UpdateState()
        {
            base.method_8("UpdateState", Array.Empty<object>());
        }

        public Spell m_AlertEvent
        {
            get
            {
                return base.method_3<Spell>("m_AlertEvent");
            }
        }

        public NetCache.BoosterStack m_boosterStack
        {
            get
            {
                return base.method_3<NetCache.BoosterStack>("m_boosterStack");
            }
        }

        public UnopenedPack m_creatorPack
        {
            get
            {
                return base.method_3<UnopenedPack>("m_creatorPack");
            }
        }

        public UnopenedPack m_draggedPack
        {
            get
            {
                return base.method_3<UnopenedPack>("m_draggedPack");
            }
        }

        public DragRotatorInfo m_DragRotatorInfo
        {
            get
            {
                return base.method_3<DragRotatorInfo>("m_DragRotatorInfo");
            }
        }

        public Spell m_DragStartEvent
        {
            get
            {
                return base.method_3<Spell>("m_DragStartEvent");
            }
        }

        public Spell m_DragStopEvent
        {
            get
            {
                return base.method_3<Spell>("m_DragStopEvent");
            }
        }

        public GameObject m_LockRibbon
        {
            get
            {
                return base.method_3<GameObject>("m_LockRibbon");
            }
        }

        public UnopenedPackStack m_MultipleStack
        {
            get
            {
                return base.method_3<UnopenedPackStack>("m_MultipleStack");
            }
        }

        public UnopenedPackStack m_SingleStack
        {
            get
            {
                return base.method_3<UnopenedPackStack>("m_SingleStack");
            }
        }
    }
}

