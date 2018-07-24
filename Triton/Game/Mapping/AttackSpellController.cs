namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AttackSpellController")]
    public class AttackSpellController : SpellController
    {
        public AttackSpellController(IntPtr address) : this(address, "AttackSpellController")
        {
        }

        public AttackSpellController(IntPtr address, string className) : base(address, className)
        {
        }

        public void ActivateImpactEffects(Card sourceCard, Card targetCard)
        {
            object[] objArray1 = new object[] { sourceCard, targetCard };
            base.method_8("ActivateImpactEffects", objArray1);
        }

        public bool AddPowerSourceAndTargets(PowerTaskList taskList)
        {
            object[] objArray1 = new object[] { taskList };
            return base.method_11<bool>("AddPowerSourceAndTargets", objArray1);
        }

        public bool CanPlayWindfuryReminder(Triton.Game.Mapping.Entity entity, Card card)
        {
            object[] objArray1 = new object[] { entity, card };
            return base.method_11<bool>("CanPlayWindfuryReminder", objArray1);
        }

        public Vector3 ComputeImpactOffset(Card sourceCard, Vector3 impactPos)
        {
            object[] objArray1 = new object[] { sourceCard, impactPos };
            return base.method_11<Vector3>("ComputeImpactOffset", objArray1);
        }

        public Vector3 ComputeImpactPos()
        {
            return base.method_11<Vector3>("ComputeImpactPos", Array.Empty<object>());
        }

        public Spell DetermineImpactSpellPrefab(Card sourceCard)
        {
            object[] objArray1 = new object[] { sourceCard };
            return base.method_14<Spell>("DetermineImpactSpellPrefab", objArray1);
        }

        public void DoTasks(Card sourceCard, Card targetCard)
        {
            object[] objArray1 = new object[] { sourceCard, targetCard };
            base.method_8("DoTasks", objArray1);
        }

        public void FinishEverything()
        {
            base.method_8("FinishEverything", Array.Empty<object>());
        }

        public void LaunchAttack()
        {
            base.method_8("LaunchAttack", Array.Empty<object>());
        }

        public void MoveSourceHeroBack(Card sourceCard)
        {
            object[] objArray1 = new object[] { sourceCard };
            base.method_8("MoveSourceHeroBack", objArray1);
        }

        public void MoveSourceToTarget(Card sourceCard, Triton.Game.Mapping.Entity sourceEntity, Vector3 impactPos)
        {
            object[] objArray1 = new object[] { sourceCard, sourceEntity, impactPos };
            base.method_8("MoveSourceToTarget", objArray1);
        }

        public void MoveTargetToSource(Card targetCard, Triton.Game.Mapping.Entity sourceEntity, Vector3 impactPos)
        {
            object[] objArray1 = new object[] { targetCard, sourceEntity, impactPos };
            base.method_8("MoveTargetToSource", objArray1);
        }

        public void OnHeroMoveBackFinished()
        {
            base.method_8("OnHeroMoveBackFinished", Array.Empty<object>());
        }

        public void OnHeroSourceAttackStateFinished(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnHeroSourceAttackStateFinished", objArray1);
        }

        public void OnImpactSpellStateFinished(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnImpactSpellStateFinished", objArray1);
        }

        public void OnMinionSourceAttackStateFinished(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnMinionSourceAttackStateFinished", objArray1);
        }

        public void OnMoveToTargetFinished()
        {
            base.method_8("OnMoveToTargetFinished", Array.Empty<object>());
        }

        public void OnProcessTaskList()
        {
            base.method_8("OnProcessTaskList", Array.Empty<object>());
        }

        public void OnSourceAttackStateStarted(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnSourceAttackStateStarted", objArray1);
        }

        public void OrientSourceHeroBack(Card sourceCard)
        {
            object[] objArray1 = new object[] { sourceCard };
            base.method_8("OrientSourceHeroBack", objArray1);
        }

        public void OrientSourceHeroToTarget(Card sourceCard)
        {
            object[] objArray1 = new object[] { sourceCard };
            base.method_8("OrientSourceHeroToTarget", objArray1);
        }

        public void PlayWindfuryReminderIfPossible(Triton.Game.Mapping.Entity entity, Card card)
        {
            object[] objArray1 = new object[] { entity, card };
            base.method_8("PlayWindfuryReminderIfPossible", objArray1);
        }

        public AllyAttackDef m_AllyInfo
        {
            get
            {
                return base.method_3<AllyAttackDef>("m_AllyInfo");
            }
        }

        public AttackType m_attackType
        {
            get
            {
                return base.method_2<AttackType>("m_attackType");
            }
        }

        public Spell m_DefaultImpactSpellPrefab
        {
            get
            {
                return base.method_3<Spell>("m_DefaultImpactSpellPrefab");
            }
        }

        public HeroAttackDef m_HeroInfo
        {
            get
            {
                return base.method_3<HeroAttackDef>("m_HeroInfo");
            }
        }

        public List<AttackImpactDef> m_ImpactDefs
        {
            get
            {
                Class267<AttackImpactDef> class2 = base.method_3<Class267<AttackImpactDef>>("m_ImpactDefs");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_ImpactStagingPoint
        {
            get
            {
                return base.method_2<float>("m_ImpactStagingPoint");
            }
        }

        public Spell m_sourceAttackSpell
        {
            get
            {
                return base.method_3<Spell>("m_sourceAttackSpell");
            }
        }

        public Vector3 m_sourceFacing
        {
            get
            {
                return base.method_2<Vector3>("m_sourceFacing");
            }
        }

        public float m_SourceImpactOffset
        {
            get
            {
                return base.method_2<float>("m_SourceImpactOffset");
            }
        }

        public Vector3 m_sourcePos
        {
            get
            {
                return base.method_2<Vector3>("m_sourcePos");
            }
        }

        public Vector3 m_sourceToTarget
        {
            get
            {
                return base.method_2<Vector3>("m_sourceToTarget");
            }
        }

        public static float PROPOSED_ATTACK_IMPACT_POINT_SCALAR
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AttackSpellController", "PROPOSED_ATTACK_IMPACT_POINT_SCALAR");
            }
        }

        public static float WINDFURY_REMINDER_WAIT_SEC
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AttackSpellController", "WINDFURY_REMINDER_WAIT_SEC");
            }
        }
    }
}

