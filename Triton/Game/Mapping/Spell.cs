namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("Spell")]
    public class Spell : MonoBehaviour
    {
        public Spell(IntPtr address) : this(address, "Spell")
        {
        }

        public Spell(IntPtr address, string className) : base(address, className)
        {
        }

        public void Activate()
        {
            base.method_8("Activate", Array.Empty<object>());
        }

        public void ActivateObjectContainer(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("ActivateObjectContainer", objArray1);
        }

        public void ActivateState(SpellStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("ActivateState", objArray1);
        }

        public bool AddMultiplePowerTargets()
        {
            return base.method_11<bool>("AddMultiplePowerTargets", Array.Empty<object>());
        }

        public bool AddPowerTargets()
        {
            return base.method_11<bool>("AddPowerTargets", Array.Empty<object>());
        }

        public bool AddSinglePowerTarget()
        {
            return base.method_11<bool>("AddSinglePowerTarget", Array.Empty<object>());
        }

        public bool AddSinglePowerTarget_FromSourceAction(Network.HistActionStart sourceAction)
        {
            object[] objArray1 = new object[] { sourceAction };
            return base.method_11<bool>("AddSinglePowerTarget_FromSourceAction", objArray1);
        }

        public void AddTarget(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            base.method_8("AddTarget", objArray1);
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

        public bool AttachPowerTaskList(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("AttachPowerTaskList", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BlockZones(bool block)
        {
            object[] objArray1 = new object[] { block };
            base.method_8("BlockZones", objArray1);
        }

        public void BuildFsmStateMap()
        {
            base.method_8("BuildFsmStateMap", Array.Empty<object>());
        }

        public void BuildSpellStateMap()
        {
            base.method_8("BuildSpellStateMap", Array.Empty<object>());
        }

        public void CallStateFunction(SpellStateType prevStateType, SpellStateType stateType)
        {
            object[] objArray1 = new object[] { prevStateType, stateType };
            base.method_8("CallStateFunction", objArray1);
        }

        public bool CanAddPowerTargets()
        {
            return base.method_11<bool>("CanAddPowerTargets", Array.Empty<object>());
        }

        public void ChangeFsmState(SpellStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("ChangeFsmState", objArray1);
        }

        public void ChangeFsmStateNow(SpellStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("ChangeFsmStateNow", objArray1);
        }

        public void ChangeState(SpellStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("ChangeState", objArray1);
        }

        public void ChangeStateImpl(SpellStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("ChangeStateImpl", objArray1);
        }

        public bool CompleteMetaDataTasks(int metaDataIndex)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.I4 };
            object[] objArray1 = new object[] { metaDataIndex };
            return base.method_10<bool>("CompleteMetaDataTasks", enumArray1, objArray1);
        }

        public void Deactivate()
        {
            base.method_8("Deactivate", Array.Empty<object>());
        }

        public bool DoesBlockServerEvents()
        {
            return base.method_11<bool>("DoesBlockServerEvents", Array.Empty<object>());
        }

        public void FinishIfNecessary()
        {
            base.method_8("FinishIfNecessary", Array.Empty<object>());
        }

        public void FireFinishedCallbacks()
        {
            base.method_8("FireFinishedCallbacks", Array.Empty<object>());
        }

        public void FireStateFinishedCallbacks(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("FireStateFinishedCallbacks", objArray1);
        }

        public void FireStateStartedCallbacks(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("FireStateStartedCallbacks", objArray1);
        }

        public void ForceDeactivate()
        {
            base.method_8("ForceDeactivate", Array.Empty<object>());
        }

        public SpellStateType GetActiveState()
        {
            return base.method_11<SpellStateType>("GetActiveState", Array.Empty<object>());
        }

        public List<SpellState> GetActiveStateList()
        {
            Class267<SpellState> class2 = base.method_14<Class267<SpellState>>("GetActiveStateList", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public SpellFacing GetFacing()
        {
            return base.method_11<SpellFacing>("GetFacing", Array.Empty<object>());
        }

        public SpellFacingOptions GetFacingOptions()
        {
            return base.method_14<SpellFacingOptions>("GetFacingOptions", Array.Empty<object>());
        }

        public SpellState GetFirstSpellState(SpellStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            return base.method_14<SpellState>("GetFirstSpellState", objArray1);
        }

        public PowerTaskList GetLastHandledTaskList(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_14<PowerTaskList>("GetLastHandledTaskList", objArray1);
        }

        public SpellLocation GetLocation()
        {
            return base.method_11<SpellLocation>("GetLocation", Array.Empty<object>());
        }

        public string GetLocationTransformName()
        {
            return base.method_13("GetLocationTransformName", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetPowerSource()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetPowerSource", Array.Empty<object>());
        }

        public Card GetPowerSourceCard()
        {
            return base.method_14<Card>("GetPowerSourceCard", Array.Empty<object>());
        }

        public Triton.Game.Mapping.Entity GetPowerTarget()
        {
            return base.method_14<Triton.Game.Mapping.Entity>("GetPowerTarget", Array.Empty<object>());
        }

        public Card GetPowerTargetCard()
        {
            return base.method_14<Card>("GetPowerTargetCard", Array.Empty<object>());
        }

        public PowerTaskList GetPowerTaskList()
        {
            return base.method_14<PowerTaskList>("GetPowerTaskList", Array.Empty<object>());
        }

        public GameObject GetSource()
        {
            return base.method_14<GameObject>("GetSource", Array.Empty<object>());
        }

        public Card GetSourceCard()
        {
            return base.method_14<Card>("GetSourceCard", Array.Empty<object>());
        }

        public SpellType GetSpellType()
        {
            return base.method_11<SpellType>("GetSpellType", Array.Empty<object>());
        }

        public string GetStateMethodName(SpellStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            return base.method_13("GetStateMethodName", objArray1);
        }

        public SuperSpell GetSuperSpellParent()
        {
            return base.method_14<SuperSpell>("GetSuperSpellParent", Array.Empty<object>());
        }

        public GameObject GetTarget()
        {
            return base.method_14<GameObject>("GetTarget", Array.Empty<object>());
        }

        public Card GetTargetCard()
        {
            return base.method_14<Card>("GetTargetCard", Array.Empty<object>());
        }

        public Card GetTargetCardFromPowerTask(int index, PowerTask task)
        {
            object[] objArray1 = new object[] { index, task };
            return base.method_14<Card>("GetTargetCardFromPowerTask", objArray1);
        }

        public List<GameObject> GetTargets()
        {
            Class267<GameObject> class2 = base.method_14<Class267<GameObject>>("GetTargets", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public GameObject GetVisualTarget()
        {
            return base.method_14<GameObject>("GetVisualTarget", Array.Empty<object>());
        }

        public Card GetVisualTargetCard()
        {
            return base.method_14<Card>("GetVisualTargetCard", Array.Empty<object>());
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

        public SpellStateType GuessNextStateType()
        {
            return base.method_10<SpellStateType>("GuessNextStateType", new Class272.Enum20[0], Array.Empty<object>());
        }

        public SpellStateType GuessNextStateType(SpellStateType stateType)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { stateType };
            return base.method_10<SpellStateType>("GuessNextStateType", enumArray1, objArray1);
        }

        public bool HasOverriddenStateMethod(SpellStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            return base.method_11<bool>("HasOverriddenStateMethod", objArray1);
        }

        public bool HasStateContent(SpellStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            return base.method_11<bool>("HasStateContent", objArray1);
        }

        public bool HasUsableState(SpellStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            return base.method_11<bool>("HasUsableState", objArray1);
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void HideImpl()
        {
            base.method_8("HideImpl", Array.Empty<object>());
        }

        public bool IsActive()
        {
            return base.method_11<bool>("IsActive", Array.Empty<object>());
        }

        public bool IsFinished()
        {
            return base.method_11<bool>("IsFinished", Array.Empty<object>());
        }

        public bool IsHandlingLastTaskList()
        {
            return base.method_11<bool>("IsHandlingLastTaskList", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public bool IsSource(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return base.method_11<bool>("IsSource", objArray1);
        }

        public bool IsTarget(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return base.method_11<bool>("IsTarget", objArray1);
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

        public void OnAttachPowerTaskList()
        {
            base.method_8("OnAttachPowerTaskList", Array.Empty<object>());
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

        public void OnDeath(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnDeath", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnEnteredNoneState()
        {
            base.method_8("OnEnteredNoneState", Array.Empty<object>());
        }

        public void OnExitedNoneState()
        {
            base.method_8("OnExitedNoneState", Array.Empty<object>());
        }

        public void OnIdle(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnIdle", objArray1);
        }

        public void OnLoad()
        {
            base.method_8("OnLoad", Array.Empty<object>());
        }

        public void OnNone(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnNone", objArray1);
        }

        public void OnSpellFinished()
        {
            base.method_8("OnSpellFinished", Array.Empty<object>());
        }

        public void OnStateFinished()
        {
            base.method_8("OnStateFinished", Array.Empty<object>());
        }

        public void Reactivate()
        {
            base.method_8("Reactivate", Array.Empty<object>());
        }

        public void RemoveAllTargets()
        {
            base.method_8("RemoveAllTargets", Array.Empty<object>());
        }

        public void RemoveAllVisualTargets()
        {
            base.method_8("RemoveAllVisualTargets", Array.Empty<object>());
        }

        public void RemoveSource()
        {
            base.method_8("RemoveSource", Array.Empty<object>());
        }

        public bool RemoveTarget(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return base.method_11<bool>("RemoveTarget", objArray1);
        }

        public bool RemoveVisualTarget(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return base.method_11<bool>("RemoveVisualTarget", objArray1);
        }

        public void SafeActivateState(SpellStateType stateType)
        {
            object[] objArray1 = new object[] { stateType };
            base.method_8("SafeActivateState", objArray1);
        }

        public void SetLocalOrientation(Quaternion orientation)
        {
            object[] objArray1 = new object[] { orientation };
            base.method_8("SetLocalOrientation", objArray1);
        }

        public void SetLocalPosition(Vector3 position)
        {
            object[] objArray1 = new object[] { position };
            base.method_8("SetLocalPosition", objArray1);
        }

        public void SetOrientation(Quaternion orientation)
        {
            object[] objArray1 = new object[] { orientation };
            base.method_8("SetOrientation", objArray1);
        }

        public void SetPosition(Vector3 position)
        {
            object[] objArray1 = new object[] { position };
            base.method_8("SetPosition", objArray1);
        }

        public void SetSource(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            base.method_8("SetSource", objArray1);
        }

        public void SetSpellType(SpellType spellType)
        {
            object[] objArray1 = new object[] { spellType };
            base.method_8("SetSpellType", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void ShowImpl()
        {
            base.method_8("ShowImpl", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateOrientation()
        {
            base.method_8("UpdateOrientation", Array.Empty<object>());
        }

        public void UpdatePosition()
        {
            base.method_8("UpdatePosition", Array.Empty<object>());
        }

        public void UpdateTransform()
        {
            base.method_8("UpdateTransform", Array.Empty<object>());
        }

        public SpellStateType m_activeStateChange
        {
            get
            {
                return base.method_2<SpellStateType>("m_activeStateChange");
            }
        }

        public SpellStateType m_activeStateType
        {
            get
            {
                return base.method_2<SpellStateType>("m_activeStateType");
            }
        }

        public bool m_BlockServerEvents
        {
            get
            {
                return base.method_2<bool>("m_BlockServerEvents");
            }
        }

        public SpellFacing m_Facing
        {
            get
            {
                return base.method_2<SpellFacing>("m_Facing");
            }
        }

        public SpellFacingOptions m_FacingOptions
        {
            get
            {
                return base.method_3<SpellFacingOptions>("m_FacingOptions");
            }
        }

        public bool m_finished
        {
            get
            {
                return base.method_2<bool>("m_finished");
            }
        }

        public bool m_fsmReady
        {
            get
            {
                return base.method_2<bool>("m_fsmReady");
            }
        }

        public bool m_fsmSkippedFirstFrame
        {
            get
            {
                return base.method_2<bool>("m_fsmSkippedFirstFrame");
            }
        }

        public SpellLocation m_Location
        {
            get
            {
                return base.method_2<SpellLocation>("m_Location");
            }
        }

        public string m_LocationTransformName
        {
            get
            {
                return base.method_4("m_LocationTransformName");
            }
        }

        public GameObject m_ObjectContainer
        {
            get
            {
                return base.method_3<GameObject>("m_ObjectContainer");
            }
        }

        public bool m_orientationDirty
        {
            get
            {
                return base.method_2<bool>("m_orientationDirty");
            }
        }

        public bool m_positionDirty
        {
            get
            {
                return base.method_2<bool>("m_positionDirty");
            }
        }

        public bool m_SetParentToLocation
        {
            get
            {
                return base.method_2<bool>("m_SetParentToLocation");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }

        public GameObject m_source
        {
            get
            {
                return base.method_3<GameObject>("m_source");
            }
        }

        public SpellType m_spellType
        {
            get
            {
                return base.method_2<SpellType>("m_spellType");
            }
        }

        public TARGET_RETICLE_TYPE m_TargetReticle
        {
            get
            {
                return base.method_2<TARGET_RETICLE_TYPE>("m_TargetReticle");
            }
        }

        public List<GameObject> m_targets
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_targets");
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

        public float m_ZoneLayoutDelayForDeaths
        {
            get
            {
                return base.method_2<float>("m_ZoneLayoutDelayForDeaths");
            }
        }

        public List<SpellZoneTag> m_ZonesToDisable
        {
            get
            {
                Class266<SpellZoneTag> class2 = base.method_3<Class266<SpellZoneTag>>("m_ZonesToDisable");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

