namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TwistingNetherSpell")]
    public class TwistingNetherSpell : SuperSpell
    {
        public TwistingNetherSpell(IntPtr address) : this(address, "TwistingNetherSpell")
        {
        }

        public TwistingNetherSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public void Begin()
        {
            base.method_8("Begin", Array.Empty<object>());
        }

        public bool CanFinish()
        {
            return base.method_11<bool>("CanFinish", Array.Empty<object>());
        }

        public void CleanUp()
        {
            base.method_8("CleanUp", Array.Empty<object>());
        }

        public void CleanUpVictim(Victim victim)
        {
            object[] objArray1 = new object[] { victim };
            base.method_8("CleanUpVictim", objArray1);
        }

        public void Drain(Victim victim)
        {
            object[] objArray1 = new object[] { victim };
            base.method_8("Drain", objArray1);
        }

        public void Float(Victim victim)
        {
            object[] objArray1 = new object[] { victim };
            base.method_8("Float", objArray1);
        }

        public Card GetTargetCardFromPowerTask(int index, PowerTask task)
        {
            object[] objArray1 = new object[] { index, task };
            return base.method_14<Card>("GetTargetCardFromPowerTask", objArray1);
        }

        public void Lift()
        {
            base.method_8("Lift", Array.Empty<object>());
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public void OnDrainFinished(Victim victim)
        {
            object[] objArray1 = new object[] { victim };
            base.method_8("OnDrainFinished", objArray1);
        }

        public void OnFinishTimeFinished()
        {
            base.method_8("OnFinishTimeFinished", Array.Empty<object>());
        }

        public void OnFloatFinished(Victim victim)
        {
            object[] objArray1 = new object[] { victim };
            base.method_8("OnFloatFinished", objArray1);
        }

        public void OnLiftFinished(Victim victim)
        {
            object[] objArray1 = new object[] { victim };
            base.method_8("OnLiftFinished", objArray1);
        }

        public void Setup()
        {
            base.method_8("Setup", Array.Empty<object>());
        }

        public static Vector3 DEAD_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "TwistingNetherSpell", "DEAD_SCALE");
            }
        }

        public TwistingNetherDrainInfo m_DrainInfo
        {
            get
            {
                return base.method_3<TwistingNetherDrainInfo>("m_DrainInfo");
            }
        }

        public float m_FinishTime
        {
            get
            {
                return base.method_2<float>("m_FinishTime");
            }
        }

        public TwistingNetherFloatInfo m_FloatInfo
        {
            get
            {
                return base.method_3<TwistingNetherFloatInfo>("m_FloatInfo");
            }
        }

        public TwistingNetherLiftInfo m_LiftInfo
        {
            get
            {
                return base.method_3<TwistingNetherLiftInfo>("m_LiftInfo");
            }
        }

        public TwistingNetherSqueezeInfo m_SqueezeInfo
        {
            get
            {
                return base.method_3<TwistingNetherSqueezeInfo>("m_SqueezeInfo");
            }
        }

        public List<Victim> m_victims
        {
            get
            {
                Class267<Victim> class2 = base.method_3<Class267<Victim>>("m_victims");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        [Attribute38("TwistingNetherSpell.Victim")]
        public class Victim : MonoClass
        {
            public Victim(IntPtr address) : this(address, "Victim")
            {
            }

            public Victim(IntPtr address, string className) : base(address, className)
            {
            }

            public Card m_card
            {
                get
                {
                    return base.method_3<Card>("m_card");
                }
            }

            public TwistingNetherSpell.VictimState m_state
            {
                get
                {
                    return base.method_2<TwistingNetherSpell.VictimState>("m_state");
                }
            }
        }

        public enum VictimState
        {
            NONE,
            LIFTING,
            FLOATING,
            DRAINING,
            DEAD
        }
    }
}

