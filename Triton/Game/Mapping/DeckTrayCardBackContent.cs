namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DeckTrayCardBackContent")]
    public class DeckTrayCardBackContent : DeckTrayContent
    {
        public DeckTrayCardBackContent(IntPtr address) : this(address, "DeckTrayCardBackContent")
        {
        }

        public DeckTrayCardBackContent(IntPtr address, string className) : base(address, className)
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

        public void AnimateInNewCardBack(CardBackManager.LoadCardBackData cardBackData, GameObject original)
        {
            object[] objArray1 = new object[] { cardBackData, original };
            base.method_8("AnimateInNewCardBack", objArray1);
        }

        public void AnimateNewCardFinished(AnimatedCardBack cardBack)
        {
            object[] objArray1 = new object[] { cardBack };
            base.method_8("AnimateNewCardFinished", objArray1);
        }

        public void AnimateNewCardUpdate(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("AnimateNewCardUpdate", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool PreAnimateContentEntrance()
        {
            return base.method_11<bool>("PreAnimateContentEntrance", Array.Empty<object>());
        }

        public void SetCardBack(GameObject go, bool overriden, bool assigning)
        {
            object[] objArray1 = new object[] { go, overriden, assigning };
            base.method_8("SetCardBack", objArray1);
        }

        public bool SetNewCardBack(int cardBackId, GameObject original)
        {
            object[] objArray1 = new object[] { cardBackId, original };
            return base.method_11<bool>("SetNewCardBack", objArray1);
        }

        public void UpdateCardBack(int cardBackId, bool assigning, GameObject obj)
        {
            object[] objArray1 = new object[] { cardBackId, assigning, obj };
            base.method_8("UpdateCardBack", objArray1);
        }

        public void UpdateMissingEffect(Actor cardBackActor, bool overriden)
        {
            object[] objArray1 = new object[] { cardBackActor, overriden };
            base.method_8("UpdateMissingEffect", objArray1);
        }

        public static string ADD_CARD_TO_DECK_SOUND
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "DeckTrayCardBackContent", "ADD_CARD_TO_DECK_SOUND");
            }
        }

        public bool m_animating
        {
            get
            {
                return base.method_2<bool>("m_animating");
            }
        }

        public AnimatedCardBack m_animData
        {
            get
            {
                return base.method_3<AnimatedCardBack>("m_animData");
            }
        }

        public GameObject m_cardBackContainer
        {
            get
            {
                return base.method_3<GameObject>("m_cardBackContainer");
            }
        }

        public GameObject m_currentCardBack
        {
            get
            {
                return base.method_3<GameObject>("m_currentCardBack");
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

        public bool m_waitingToLoadCardback
        {
            get
            {
                return base.method_2<bool>("m_waitingToLoadCardback");
            }
        }

        [Attribute38("DeckTrayCardBackContent.AnimatedCardBack")]
        public class AnimatedCardBack : MonoClass
        {
            public AnimatedCardBack(IntPtr address) : this(address, "AnimatedCardBack")
            {
            }

            public AnimatedCardBack(IntPtr address, string className) : base(address, className)
            {
            }

            public int CardBackId
            {
                get
                {
                    return base.method_2<int>("CardBackId");
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

