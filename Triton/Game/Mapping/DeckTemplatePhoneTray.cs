namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DeckTemplatePhoneTray")]
    public class DeckTemplatePhoneTray : MonoBehaviour
    {
        public DeckTemplatePhoneTray(IntPtr address) : this(address, "DeckTemplatePhoneTray")
        {
        }

        public DeckTemplatePhoneTray(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void FlashDeckTemplateHighlight()
        {
            base.method_8("FlashDeckTemplateHighlight", Array.Empty<object>());
        }

        public static DeckTemplatePhoneTray Get()
        {
            return MonoClass.smethod_15<DeckTemplatePhoneTray>(TritonHs.MainAssemblyPath, "", "DeckTemplatePhoneTray", "Get", Array.Empty<object>());
        }

        public DeckTrayCardListContent GetCardsContent()
        {
            return base.method_14<DeckTrayCardListContent>("GetCardsContent", Array.Empty<object>());
        }

        public TooltipZone GetTooltipZone()
        {
            return base.method_14<TooltipZone>("GetTooltipZone", Array.Empty<object>());
        }

        public void HideDeckBigCard(DeckTrayDeckTileVisual cardTile, bool force)
        {
            object[] objArray1 = new object[] { cardTile, force };
            base.method_8("HideDeckBigCard", objArray1);
        }

        public bool MouseIsOver()
        {
            return base.method_11<bool>("MouseIsOver", Array.Empty<object>());
        }

        public void OnCardCountUpdated(int cardCount)
        {
            object[] objArray1 = new object[] { cardCount };
            base.method_8("OnCardCountUpdated", objArray1);
        }

        public void OnCardTileOut(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("OnCardTileOut", objArray1);
        }

        public void OnCardTileOver(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("OnCardTileOver", objArray1);
        }

        public void OnCardTilePress(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("OnCardTilePress", objArray1);
        }

        public void OnCardTileRelease(DeckTrayDeckTileVisual cardTile)
        {
            object[] objArray1 = new object[] { cardTile };
            base.method_8("OnCardTileRelease", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnTouchScrollStarted()
        {
            base.method_8("OnTouchScrollStarted", Array.Empty<object>());
        }

        public void ShowDeckBigCard(DeckTrayDeckTileVisual cardTile, float delay)
        {
            object[] objArray1 = new object[] { cardTile, delay };
            base.method_8("ShowDeckBigCard", objArray1);
        }

        public DeckTrayCardListContent m_cardsContent
        {
            get
            {
                return base.method_3<DeckTrayCardListContent>("m_cardsContent");
            }
        }

        public UberText m_countLabelText
        {
            get
            {
                return base.method_3<UberText>("m_countLabelText");
            }
        }

        public UberText m_countText
        {
            get
            {
                return base.method_3<UberText>("m_countText");
            }
        }

        public DeckBigCard m_deckBigCard
        {
            get
            {
                return base.method_3<DeckBigCard>("m_deckBigCard");
            }
        }

        public TooltipZone m_deckHeaderTooltip
        {
            get
            {
                return base.method_3<TooltipZone>("m_deckHeaderTooltip");
            }
        }

        public GameObject m_headerLabel
        {
            get
            {
                return base.method_3<GameObject>("m_headerLabel");
            }
        }

        public UIBScrollable m_scrollbar
        {
            get
            {
                return base.method_3<UIBScrollable>("m_scrollbar");
            }
        }
    }
}

