namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("PackOpeningDirector")]
    public class PackOpeningDirector : MonoBehaviour
    {
        public PackOpeningDirector(IntPtr address) : this(address, "PackOpeningDirector")
        {
        }

        public PackOpeningDirector(IntPtr address, string className) : base(address, className)
        {
        }

        public void AttachCardsToCarousel()
        {
            base.method_8("AttachCardsToCarousel", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CameraBlurOn()
        {
            base.method_8("CameraBlurOn", Array.Empty<object>());
        }

        public void CarouselItemClicked(CarouselItem item, int index)
        {
            object[] objArray1 = new object[] { item, index };
            base.method_8("CarouselItemClicked", objArray1);
        }

        public void CarouselItemReleased()
        {
            base.method_8("CarouselItemReleased", Array.Empty<object>());
        }

        public void CarouselSettled()
        {
            base.method_8("CarouselSettled", Array.Empty<object>());
        }

        public void CarouselStartedScrolling()
        {
            base.method_8("CarouselStartedScrolling", Array.Empty<object>());
        }

        public void EnableCardInput(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableCardInput", objArray1);
        }

        public bool FinishPackOpen()
        {
            return base.method_11<bool>("FinishPackOpen", Array.Empty<object>());
        }

        public void FireFinishedEvent()
        {
            base.method_8("FireFinishedEvent", Array.Empty<object>());
        }

        public List<PackOpeningCard> GetHiddenCards()
        {
            Class267<PackOpeningCard> class2 = base.method_14<Class267<PackOpeningCard>>("GetHiddenCards", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void HideDoneButton()
        {
            base.method_8("HideDoneButton", Array.Empty<object>());
        }

        public void HideKeywordTooltips()
        {
            base.method_8("HideKeywordTooltips", Array.Empty<object>());
        }

        public void InitializeCards()
        {
            base.method_8("InitializeCards", Array.Empty<object>());
        }

        public void InitializeUI()
        {
            base.method_8("InitializeUI", Array.Empty<object>());
        }

        public bool IsDoneButtonShown()
        {
            return base.method_11<bool>("IsDoneButtonShown", Array.Empty<object>());
        }

        public bool IsPlaying()
        {
            return base.method_11<bool>("IsPlaying", Array.Empty<object>());
        }

        public void OnCardRevealed(object userData)
        {
            object[] objArray1 = new object[] { userData };
            base.method_8("OnCardRevealed", objArray1);
        }

        public void OnDoneButtonHidden(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnDoneButtonHidden", objArray1);
        }

        public void OnDoneButtonLoaded(string name, GameObject actorObject, object userData)
        {
            object[] objArray1 = new object[] { name, actorObject, userData };
            base.method_8("OnDoneButtonLoaded", objArray1);
        }

        public void OnDoneButtonPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnDoneButtonPressed", objArray1);
        }

        public void OnDoneButtonShown(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnDoneButtonShown", objArray1);
        }

        public void OnEffectDone()
        {
            base.method_8("OnEffectDone", Array.Empty<object>());
        }

        public void OnEffectFinished()
        {
            base.method_8("OnEffectFinished", Array.Empty<object>());
        }

        public void OnHiddenCardSpellFinished(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnHiddenCardSpellFinished", objArray1);
        }

        public void OnHiddenCardSpellStateFinished(Spell spell, SpellStateType prevStateType, object userData)
        {
            object[] objArray1 = new object[] { spell, prevStateType, userData };
            base.method_8("OnHiddenCardSpellStateFinished", objArray1);
        }

        public void OnSpellFinished(Spell spell, object userData)
        {
            object[] objArray1 = new object[] { spell, userData };
            base.method_8("OnSpellFinished", objArray1);
        }

        public void Play(int boosterId)
        {
            object[] objArray1 = new object[] { boosterId };
            base.method_8("Play", objArray1);
        }

        public void ShowCompleteAchieve()
        {
            base.method_8("ShowCompleteAchieve", Array.Empty<object>());
        }

        public void ShowDoneButton()
        {
            base.method_8("ShowDoneButton", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public Spell m_activePackFxSpell
        {
            get
            {
                return base.method_3<Spell>("m_activePackFxSpell");
            }
        }

        public GameObject m_CardsInsidePack
        {
            get
            {
                return base.method_3<GameObject>("m_CardsInsidePack");
            }
        }

        public int m_cardsPendingReveal
        {
            get
            {
                return base.method_2<int>("m_cardsPendingReveal");
            }
        }

        public Carousel m_Carousel
        {
            get
            {
                return base.method_3<Carousel>("m_Carousel");
            }
        }

        public int m_centerCardIndex
        {
            get
            {
                return base.method_2<int>("m_centerCardIndex");
            }
        }

        public GameObject m_ClassName
        {
            get
            {
                return base.method_3<GameObject>("m_ClassName");
            }
        }

        public PackOpeningCard m_clickedCard
        {
            get
            {
                return base.method_3<PackOpeningCard>("m_clickedCard");
            }
        }

        public int m_clickedPosition
        {
            get
            {
                return base.method_2<int>("m_clickedPosition");
            }
        }

        public List<Achievement> m_completeAchievesToDisplay
        {
            get
            {
                Class267<Achievement> class2 = base.method_3<Class267<Achievement>>("m_completeAchievesToDisplay");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public NormalButton m_doneButton
        {
            get
            {
                return base.method_3<NormalButton>("m_doneButton");
            }
        }

        public string m_DoneButtonPrefab
        {
            get
            {
                return base.method_4("m_DoneButtonPrefab");
            }
        }

        public bool m_doneButtonShown
        {
            get
            {
                return base.method_2<bool>("m_doneButtonShown");
            }
        }

        public int m_effectsPendingDestroy
        {
            get
            {
                return base.method_2<int>("m_effectsPendingDestroy");
            }
        }

        public int m_effectsPendingFinish
        {
            get
            {
                return base.method_2<int>("m_effectsPendingFinish");
            }
        }

        public PackOpeningCard m_glowingCard
        {
            get
            {
                return base.method_3<PackOpeningCard>("m_glowingCard");
            }
        }

        public PackOpeningCard m_HiddenCard
        {
            get
            {
                return base.method_3<PackOpeningCard>("m_HiddenCard");
            }
        }

        public List<PackOpeningCard> m_hiddenCards
        {
            get
            {
                Class267<PackOpeningCard> class2 = base.method_3<Class267<PackOpeningCard>>("m_hiddenCards");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_loadingDoneButton
        {
            get
            {
                return base.method_2<bool>("m_loadingDoneButton");
            }
        }

        public bool m_playing
        {
            get
            {
                return base.method_2<bool>("m_playing");
            }
        }

        public Vector3 PACK_OPENING_FX_POSITION
        {
            get
            {
                return base.method_2<Vector3>("PACK_OPENING_FX_POSITION");
            }
        }
    }
}

