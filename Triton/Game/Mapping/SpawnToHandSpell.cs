namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("SpawnToHandSpell")]
    public class SpawnToHandSpell : SuperSpell
    {
        public SpawnToHandSpell(IntPtr address) : this(address, "SpawnToHandSpell")
        {
        }

        public SpawnToHandSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddTransitionDelays()
        {
            base.method_8("AddTransitionDelays", Array.Empty<object>());
        }

        public Vector3 GetOriginForTarget(int targetIndex)
        {
            object[] objArray1 = new object[] { targetIndex };
            return base.method_11<Vector3>("GetOriginForTarget", objArray1);
        }

        public Card GetTargetCardFromPowerTask(int index, PowerTask task)
        {
            object[] objArray1 = new object[] { index, task };
            return base.method_14<Card>("GetTargetCardFromPowerTask", objArray1);
        }

        public void OnAction(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnAction", objArray1);
        }

        public float m_CardDelay
        {
            get
            {
                return base.method_2<float>("m_CardDelay");
            }
        }

        public float m_CardStaggerMax
        {
            get
            {
                return base.method_2<float>("m_CardStaggerMax");
            }
        }

        public float m_CardStaggerMin
        {
            get
            {
                return base.method_2<float>("m_CardStaggerMin");
            }
        }

        public float m_CardStartScale
        {
            get
            {
                return base.method_2<float>("m_CardStartScale");
            }
        }

        public bool m_RandomizeOrder
        {
            get
            {
                return base.method_2<bool>("m_RandomizeOrder");
            }
        }

        public bool m_Shake
        {
            get
            {
                return base.method_2<bool>("m_Shake");
            }
        }

        public float m_ShakeDelay
        {
            get
            {
                return base.method_2<float>("m_ShakeDelay");
            }
        }

        public ShakeMinionIntensity m_ShakeIntensity
        {
            get
            {
                return base.method_2<ShakeMinionIntensity>("m_ShakeIntensity");
            }
        }

        public Spell m_SpellPrefab
        {
            get
            {
                return base.method_3<Spell>("m_SpellPrefab");
            }
        }
    }
}

