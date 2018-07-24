namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("SpellMoveToTargetAuto")]
    public class SpellMoveToTargetAuto : Spell
    {
        public SpellMoveToTargetAuto(IntPtr address) : this(address, "SpellMoveToTargetAuto")
        {
        }

        public SpellMoveToTargetAuto(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddPowerTargets()
        {
            return base.method_11<bool>("AddPowerTargets", Array.Empty<object>());
        }

        public void AddTarget(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            base.method_8("AddTarget", objArray1);
        }

        public bool DeterminePath(Player sourcePlayer, Card sourceCard, Card targetCard)
        {
            object[] objArray1 = new object[] { sourcePlayer, sourceCard, targetCard };
            return base.method_11<bool>("DeterminePath", objArray1);
        }

        public void DoActionFallback(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("DoActionFallback", objArray1);
        }

        public void FixupPathNodes(Player sourcePlayer, Card sourceCard, Card targetCard)
        {
            object[] objArray1 = new object[] { sourcePlayer, sourceCard, targetCard };
            base.method_8("FixupPathNodes", objArray1);
        }

        public void MoveCenterPoint()
        {
            base.method_8("MoveCenterPoint", Array.Empty<object>());
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

        public void OnMoveToTargetComplete()
        {
            base.method_8("OnMoveToTargetComplete", Array.Empty<object>());
        }

        public void RemoveAllTargets()
        {
            base.method_8("RemoveAllTargets", Array.Empty<object>());
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

        public void ResetPath()
        {
            base.method_8("ResetPath", Array.Empty<object>());
        }

        public void SetSource(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            base.method_8("SetSource", objArray1);
        }

        public void SetStartPosition()
        {
            base.method_8("SetStartPosition", Array.Empty<object>());
        }

        public void StopWaitingToAct()
        {
            base.method_8("StopWaitingToAct", Array.Empty<object>());
        }

        public float CenterOffsetPercent
        {
            get
            {
                return base.method_2<float>("CenterOffsetPercent");
            }
        }

        public float CenterPointHeightMax
        {
            get
            {
                return base.method_2<float>("CenterPointHeightMax");
            }
        }

        public float CenterPointHeightMin
        {
            get
            {
                return base.method_2<float>("CenterPointHeightMin");
            }
        }

        public bool DebugForceMax
        {
            get
            {
                return base.method_2<bool>("DebugForceMax");
            }
        }

        public float DistanceScaleFactor
        {
            get
            {
                return base.method_2<float>("DistanceScaleFactor");
            }
        }

        public float LeftMax
        {
            get
            {
                return base.method_2<float>("LeftMax");
            }
        }

        public float LeftMin
        {
            get
            {
                return base.method_2<float>("LeftMin");
            }
        }

        public bool m_DisableContainerAfterAction
        {
            get
            {
                return base.method_2<bool>("m_DisableContainerAfterAction");
            }
        }

        public iTween.EaseType m_EaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_EaseType");
            }
        }

        public float m_MovementDurationSec
        {
            get
            {
                return base.method_2<float>("m_MovementDurationSec");
            }
        }

        public bool m_OnlyMoveContainer
        {
            get
            {
                return base.method_2<bool>("m_OnlyMoveContainer");
            }
        }

        public bool m_OrientToPath
        {
            get
            {
                return base.method_2<bool>("m_OrientToPath");
            }
        }

        public List<Vector3> m_pathNodes
        {
            get
            {
                Class246<Vector3> class2 = base.method_3<Class246<Vector3>>("m_pathNodes");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_sourceComputed
        {
            get
            {
                return base.method_2<bool>("m_sourceComputed");
            }
        }

        public bool m_targetComputed
        {
            get
            {
                return base.method_2<bool>("m_targetComputed");
            }
        }

        public bool m_waitingToAct
        {
            get
            {
                return base.method_2<bool>("m_waitingToAct");
            }
        }

        public float RightMax
        {
            get
            {
                return base.method_2<float>("RightMax");
            }
        }

        public float RightMin
        {
            get
            {
                return base.method_2<float>("RightMin");
            }
        }
    }
}

