namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DeckTrayHeroSkinContent")]
    public class DeckTrayHeroSkinContent : DeckTrayContent
    {
        public DeckTrayHeroSkinContent(IntPtr address) : this(address, "DeckTrayHeroSkinContent")
        {
        }

        public DeckTrayHeroSkinContent(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AnimateContentEntranceEnd()
        {
            return base.method_11<bool>("AnimateContentEntranceEnd", Array.Empty<object>());
        }

        public bool AnimateContentEntranceStart()
        {
            return base.method_11<bool>("AnimateContentEntranceStart", Array.Empty<object>());
        }

        public bool AnimateContentExitEnd()
        {
            return base.method_11<bool>("AnimateContentExitEnd", Array.Empty<object>());
        }

        public bool AnimateContentExitStart()
        {
            return base.method_11<bool>("AnimateContentExitStart", Array.Empty<object>());
        }

        public void AnimateInNewHeroSkin(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            base.method_8("AnimateInNewHeroSkin", objArray1);
        }

        public void AnimateNewHeroSkinFinished()
        {
            base.method_8("AnimateNewHeroSkinFinished", Array.Empty<object>());
        }

        public void AnimateNewHeroSkinUpdate(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("AnimateNewHeroSkinUpdate", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void LoadHeroSkinActor()
        {
            base.method_8("LoadHeroSkinActor", Array.Empty<object>());
        }

        public void OnPickEmoteFinished(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnPickEmoteFinished", objArray1);
        }

        public void OnPickEmoteLoaded(CardSoundSpell spell)
        {
            object[] objArray1 = new object[] { spell };
            base.method_8("OnPickEmoteLoaded", objArray1);
        }

        public bool PreAnimateContentEntrance()
        {
            return base.method_11<bool>("PreAnimateContentEntrance", Array.Empty<object>());
        }

        public void SetNewHeroSkin(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            base.method_8("SetNewHeroSkin", objArray1);
        }

        public void ShowSocketFX()
        {
            base.method_8("ShowSocketFX", Array.Empty<object>());
        }

        public void UpdateHeroSkin(EntityDef entityDef, TAG_PREMIUM premium, bool assigning)
        {
            object[] objArray1 = new object[] { entityDef, premium, assigning };
            base.method_9("UpdateHeroSkin", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
        }

        public void UpdateHeroSkin(string cardId, TAG_PREMIUM premium, bool assigning, Actor baseActor)
        {
            object[] objArray1 = new object[] { cardId, premium, assigning, baseActor };
            base.method_9("UpdateHeroSkin", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public void UpdateHeroSkinVisual(EntityDef entityDef, CardDef cardDef, TAG_PREMIUM premium, bool assigning)
        {
            object[] objArray1 = new object[] { entityDef, cardDef, premium, assigning };
            base.method_8("UpdateHeroSkinVisual", objArray1);
        }

        public void UpdateMissingEffect(bool overriden)
        {
            object[] objArray1 = new object[] { overriden };
            base.method_8("UpdateMissingEffect", objArray1);
        }

        public static string ADD_CARD_TO_DECK_SOUND
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "DeckTrayHeroSkinContent", "ADD_CARD_TO_DECK_SOUND");
            }
        }

        public bool m_animating
        {
            get
            {
                return base.method_2<bool>("m_animating");
            }
        }

        public AnimatedHeroSkin m_animData
        {
            get
            {
                return base.method_3<AnimatedHeroSkin>("m_animData");
            }
        }

        public string m_currentHeroCardId
        {
            get
            {
                return base.method_4("m_currentHeroCardId");
            }
        }

        public UberText m_currentHeroSkinName
        {
            get
            {
                return base.method_3<UberText>("m_currentHeroSkinName");
            }
        }

        public GameObject m_heroSkinContainer
        {
            get
            {
                return base.method_3<GameObject>("m_heroSkinContainer");
            }
        }

        public Actor m_heroSkinObject
        {
            get
            {
                return base.method_3<Actor>("m_heroSkinObject");
            }
        }

        public Vector3 m_originalLocalPosition
        {
            get
            {
                return base.method_2<Vector3>("m_originalLocalPosition");
            }
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }

        public Material m_sepiaCardMaterial
        {
            get
            {
                return base.method_3<Material>("m_sepiaCardMaterial");
            }
        }

        public string m_socketSound
        {
            get
            {
                return base.method_4("m_socketSound");
            }
        }

        public Vector3 m_trayHiddenOffset
        {
            get
            {
                return base.method_2<Vector3>("m_trayHiddenOffset");
            }
        }

        public float m_traySlideAnimationTime
        {
            get
            {
                return base.method_2<float>("m_traySlideAnimationTime");
            }
        }

        public iTween.EaseType m_traySlideSlideInAnimation
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_traySlideSlideInAnimation");
            }
        }

        public iTween.EaseType m_traySlideSlideOutAnimation
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_traySlideSlideOutAnimation");
            }
        }

        public bool m_waitingToLoadHeroDef
        {
            get
            {
                return base.method_2<bool>("m_waitingToLoadHeroDef");
            }
        }

        [Attribute38("DeckTrayHeroSkinContent.AnimatedHeroSkin")]
        public class AnimatedHeroSkin : MonoClass
        {
            public AnimatedHeroSkin(IntPtr address) : this(address, "AnimatedHeroSkin")
            {
            }

            public AnimatedHeroSkin(IntPtr address, string className) : base(address, className)
            {
            }

            public Triton.Game.Mapping.Actor Actor
            {
                get
                {
                    return base.method_3<Triton.Game.Mapping.Actor>("Actor");
                }
            }

            public Triton.Game.Mapping.GameObject GameObject
            {
                get
                {
                    return base.method_3<Triton.Game.Mapping.GameObject>("GameObject");
                }
            }

            public Vector3 OriginalPosition
            {
                get
                {
                    return base.method_2<Vector3>("OriginalPosition");
                }
            }

            public Vector3 OriginalScale
            {
                get
                {
                    return base.method_2<Vector3>("OriginalScale");
                }
            }
        }
    }
}

