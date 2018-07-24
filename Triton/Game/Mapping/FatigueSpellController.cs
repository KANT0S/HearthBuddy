namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FatigueSpellController")]
    public class FatigueSpellController : SpellController
    {
        public FatigueSpellController(IntPtr address) : this(address, "FatigueSpellController")
        {
        }

        public FatigueSpellController(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AddPowerSourceAndTargets(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("AddPowerSourceAndTargets", objArray1);
        }

        public void DoFinishFatigue()
        {
            base.method_8("DoFinishFatigue", Array.Empty<object>());
        }

        public void OnFatigueActorLoaded(string actorName, GameObject actorObject, object callbackData)
        {
            object[] objArray1 = new object[] { actorName, actorObject, callbackData };
            base.method_8("OnFatigueActorLoaded", objArray1);
        }

        public void OnFatigueDamageFinished(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnFatigueDamageFinished", objArray1);
        }

        public void OnFatigueDeathSpellFinished(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnFatigueDeathSpellFinished", objArray1);
        }

        public void OnProcessTaskList()
        {
            base.method_8("OnProcessTaskList", Array.Empty<object>());
        }

        public static Vector3 FATIGUE_ACTOR_FINAL_LOCAL_ROTATION
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "FatigueSpellController", "FATIGUE_ACTOR_FINAL_LOCAL_ROTATION");
            }
        }

        public static Vector3 FATIGUE_ACTOR_FINAL_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "FatigueSpellController", "FATIGUE_ACTOR_FINAL_SCALE");
            }
        }

        public static Vector3 FATIGUE_ACTOR_INITIAL_LOCAL_ROTATION
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "FatigueSpellController", "FATIGUE_ACTOR_INITIAL_LOCAL_ROTATION");
            }
        }

        public static Vector3 FATIGUE_ACTOR_START_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "FatigueSpellController", "FATIGUE_ACTOR_START_SCALE");
            }
        }

        public static float FATIGUE_DRAW_ANIM_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "FatigueSpellController", "FATIGUE_DRAW_ANIM_TIME");
            }
        }

        public static float FATIGUE_DRAW_SCALE_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "FatigueSpellController", "FATIGUE_DRAW_SCALE_TIME");
            }
        }

        public static float FATIGUE_HOLD_TIME
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "FatigueSpellController", "FATIGUE_HOLD_TIME");
            }
        }

        public Actor m_fatigueActor
        {
            get
            {
                return base.method_3<Actor>("m_fatigueActor");
            }
        }

        public Network.HistTagChange m_fatigueTagChange
        {
            get
            {
                return base.method_3<Network.HistTagChange>("m_fatigueTagChange");
            }
        }
    }
}

