namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ManaCrystal")]
    public class ManaCrystal : MonoBehaviour
    {
        public ManaCrystal(IntPtr address) : this(address, "ManaCrystal")
        {
        }

        public ManaCrystal(IntPtr address, string className) : base(address, className)
        {
        }

        public void Destroy()
        {
            base.method_8("Destroy", Array.Empty<object>());
        }

        public string GetTransitionAnimName(State oldState, State newState)
        {
            object[] objArray1 = new object[] { oldState, newState };
            return base.method_13("GetTransitionAnimName", objArray1);
        }

        public bool IsOverloaded()
        {
            return base.method_11<bool>("IsOverloaded", Array.Empty<object>());
        }

        public bool IsOwedForOverload()
        {
            return base.method_11<bool>("IsOwedForOverload", Array.Empty<object>());
        }

        public void MarkAsNotInGame()
        {
            base.method_8("MarkAsNotInGame", Array.Empty<object>());
        }

        public void MarkAsOwedForOverload()
        {
            base.method_9("MarkAsOwedForOverload", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void MarkAsOwedForOverload(bool immediatelyLockForOverload)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { immediatelyLockForOverload };
            base.method_9("MarkAsOwedForOverload", enumArray1, objArray1);
        }

        public void MarkAsTemp()
        {
            base.method_8("MarkAsTemp", Array.Empty<object>());
        }

        public void OnGemDestroyedAnimComplete(Spell spell, SpellStateType spellStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, spellStateType, userData };
            base.method_8("OnGemDestroyedAnimComplete", objArray1);
        }

        public void OnOverloadBirthCompletePayOverload(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnOverloadBirthCompletePayOverload", objArray1);
        }

        public void OnOverloadUnlockedAnimComplete(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnOverloadUnlockedAnimComplete", objArray1);
        }

        public void PayOverload()
        {
            base.method_8("PayOverload", Array.Empty<object>());
        }

        public void PlayCreateAnimation()
        {
            base.method_8("PlayCreateAnimation", Array.Empty<object>());
        }

        public void PlayGemAnimation(string animName, State newVisibleState)
        {
            object[] objArray1 = new object[] { animName, newVisibleState };
            base.method_8("PlayGemAnimation", objArray1);
        }

        public void ReclaimOverload()
        {
            base.method_8("ReclaimOverload", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UnlockOverload()
        {
            base.method_8("UnlockOverload", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public string ANIM_MANA_GEM_BIRTH
        {
            get
            {
                return base.method_4("ANIM_MANA_GEM_BIRTH");
            }
        }

        public string ANIM_PROPOSED_TO_READY
        {
            get
            {
                return base.method_4("ANIM_PROPOSED_TO_READY");
            }
        }

        public string ANIM_PROPOSED_TO_USED
        {
            get
            {
                return base.method_4("ANIM_PROPOSED_TO_USED");
            }
        }

        public string ANIM_READY_TO_PROPOSED
        {
            get
            {
                return base.method_4("ANIM_READY_TO_PROPOSED");
            }
        }

        public string ANIM_READY_TO_USED
        {
            get
            {
                return base.method_4("ANIM_READY_TO_USED");
            }
        }

        public string ANIM_SPAWN_EFFECTS
        {
            get
            {
                return base.method_4("ANIM_SPAWN_EFFECTS");
            }
        }

        public string ANIM_TEMP_MANA_GEM_BIRTH
        {
            get
            {
                return base.method_4("ANIM_TEMP_MANA_GEM_BIRTH");
            }
        }

        public string ANIM_TEMP_PROPOSED_TO_READY
        {
            get
            {
                return base.method_4("ANIM_TEMP_PROPOSED_TO_READY");
            }
        }

        public string ANIM_TEMP_READY_TO_PROPOSED
        {
            get
            {
                return base.method_4("ANIM_TEMP_READY_TO_PROPOSED");
            }
        }

        public string ANIM_TEMP_SPAWN_EFFECTS
        {
            get
            {
                return base.method_4("ANIM_TEMP_SPAWN_EFFECTS");
            }
        }

        public string ANIM_USED_TO_PROPOSED
        {
            get
            {
                return base.method_4("ANIM_USED_TO_PROPOSED");
            }
        }

        public string ANIM_USED_TO_READY
        {
            get
            {
                return base.method_4("ANIM_USED_TO_READY");
            }
        }

        public GameObject gem
        {
            get
            {
                return base.method_3<GameObject>("gem");
            }
        }

        public GameObject gemDestroy
        {
            get
            {
                return base.method_3<GameObject>("gemDestroy");
            }
        }

        public bool m_birthAnimationPlayed
        {
            get
            {
                return base.method_2<bool>("m_birthAnimationPlayed");
            }
        }

        public bool m_isInGame
        {
            get
            {
                return base.method_2<bool>("m_isInGame");
            }
        }

        public bool m_isTemp
        {
            get
            {
                return base.method_2<bool>("m_isTemp");
            }
        }

        public Spell m_overloadOwedSpell
        {
            get
            {
                return base.method_3<Spell>("m_overloadOwedSpell");
            }
        }

        public Spell m_overloadPaidSpell
        {
            get
            {
                return base.method_3<Spell>("m_overloadPaidSpell");
            }
        }

        public bool m_playingAnimation
        {
            get
            {
                return base.method_2<bool>("m_playingAnimation");
            }
        }

        public State m_state
        {
            get
            {
                return base.method_2<State>("m_state");
            }
        }

        public State m_visibleState
        {
            get
            {
                return base.method_2<State>("m_visibleState");
            }
        }

        public GameObject spawnEffects
        {
            get
            {
                return base.method_3<GameObject>("spawnEffects");
            }
        }

        public State state
        {
            get
            {
                return base.method_11<State>("get_state", Array.Empty<object>());
            }
        }

        public GameObject tempGemDestroy
        {
            get
            {
                return base.method_3<GameObject>("tempGemDestroy");
            }
        }

        public GameObject tempSpawnEffects
        {
            get
            {
                return base.method_3<GameObject>("tempSpawnEffects");
            }
        }

        public enum State
        {
            READY,
            USED,
            PROPOSED,
            DESTROYED
        }
    }
}

