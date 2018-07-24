namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CollectionDraggableCardVisual")]
    public class CollectionDraggableCardVisual : MonoBehaviour
    {
        public CollectionDraggableCardVisual(IntPtr address) : this(address, "CollectionDraggableCardVisual")
        {
        }

        public CollectionDraggableCardVisual(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool ChangeActor(Actor actor, CollectionManagerDisplay.ViewMode vtype)
        {
            object[] objArray1 = new object[] { actor, vtype };
            return base.method_11<bool>("ChangeActor", objArray1);
        }

        public int GetCardBackId()
        {
            return base.method_11<int>("GetCardBackId", Array.Empty<object>());
        }

        public string GetCardID()
        {
            return base.method_13("GetCardID", Array.Empty<object>());
        }

        public DeckTrayDeckTileVisual GetDeckTileToRemove()
        {
            return base.method_14<DeckTrayDeckTileVisual>("GetDeckTileToRemove", Array.Empty<object>());
        }

        public EntityDef GetEntityDef()
        {
            return base.method_14<EntityDef>("GetEntityDef", Array.Empty<object>());
        }

        public TAG_PREMIUM GetPremium()
        {
            return base.method_11<TAG_PREMIUM>("GetPremium", Array.Empty<object>());
        }

        public CollectionDeckSlot GetSlot()
        {
            return base.method_14<CollectionDeckSlot>("GetSlot", Array.Empty<object>());
        }

        public CollectionManagerDisplay.ViewMode GetVisualType()
        {
            return base.method_11<CollectionManagerDisplay.ViewMode>("GetVisualType", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void InitActor(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            base.method_8("InitActor", objArray1);
        }

        public void InitCardActor()
        {
            base.method_8("InitCardActor", Array.Empty<object>());
        }

        public void InitDeckTileActor()
        {
            base.method_8("InitDeckTileActor", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public void LoadCardBack()
        {
            base.method_8("LoadCardBack", Array.Empty<object>());
        }

        public void LoadDeckTile()
        {
            base.method_8("LoadDeckTile", Array.Empty<object>());
        }

        public void OnCardActorLoaded(string name, Actor actor, object callbackData)
        {
            object[] objArray1 = new object[] { name, actor, callbackData };
            base.method_8("OnCardActorLoaded", objArray1);
        }

        public void OnCardDefLoaded(string cardID, CardDef cardDef, object callbackData)
        {
            object[] objArray1 = new object[] { cardID, cardDef, callbackData };
            base.method_8("OnCardDefLoaded", objArray1);
        }

        public void SetCardBackId(int cardBackId)
        {
            object[] objArray1 = new object[] { cardBackId };
            base.method_8("SetCardBackId", objArray1);
        }

        public void SetSlot(CollectionDeckSlot slot)
        {
            object[] objArray1 = new object[] { slot };
            base.method_8("SetSlot", objArray1);
        }

        public void Show(bool isOverDeck)
        {
            object[] objArray1 = new object[] { isOverDeck };
            base.method_8("Show", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateVisual(bool isOverDeck)
        {
            object[] objArray1 = new object[] { isOverDeck };
            base.method_8("UpdateVisual", objArray1);
        }

        public static Vector3 CARD_ACTOR_LOCAL_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "CollectionDraggableCardVisual", "CARD_ACTOR_LOCAL_SCALE");
            }
        }

        public static Vector3 DECK_TILE_LOCAL_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "CollectionDraggableCardVisual", "DECK_TILE_LOCAL_SCALE");
            }
        }

        public static Vector3 HERO_SKIN_ACTOR_LOCAL_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "CollectionDraggableCardVisual", "HERO_SKIN_ACTOR_LOCAL_SCALE");
            }
        }

        public Actor m_activeActor
        {
            get
            {
                return base.method_3<Actor>("m_activeActor");
            }
        }

        public HandActorCache m_actorCache
        {
            get
            {
                return base.method_3<HandActorCache>("m_actorCache");
            }
        }

        public bool m_actorCacheInit
        {
            get
            {
                return base.method_2<bool>("m_actorCacheInit");
            }
        }

        public Actor m_cardActor
        {
            get
            {
                return base.method_3<Actor>("m_cardActor");
            }
        }

        public string m_cardActorName
        {
            get
            {
                return base.method_4("m_cardActorName");
            }
        }

        public Actor m_cardBackActor
        {
            get
            {
                return base.method_3<Actor>("m_cardBackActor");
            }
        }

        public int m_cardBackId
        {
            get
            {
                return base.method_2<int>("m_cardBackId");
            }
        }

        public CardDef m_cardDef
        {
            get
            {
                return base.method_3<CardDef>("m_cardDef");
            }
        }

        public DragRotatorInfo m_CardDragRotatorInfo
        {
            get
            {
                return base.method_3<DragRotatorInfo>("m_CardDragRotatorInfo");
            }
        }

        public CardBack m_currentCardBack
        {
            get
            {
                return base.method_3<CardBack>("m_currentCardBack");
            }
        }

        public CollectionDeckTileActor m_deckTile
        {
            get
            {
                return base.method_3<CollectionDeckTileActor>("m_deckTile");
            }
        }

        public DeckTrayDeckTileVisual m_deckTileToRemove
        {
            get
            {
                return base.method_3<DeckTrayDeckTileVisual>("m_deckTileToRemove");
            }
        }

        public EntityDef m_entityDef
        {
            get
            {
                return base.method_3<EntityDef>("m_entityDef");
            }
        }

        public TAG_PREMIUM m_premium
        {
            get
            {
                return base.method_2<TAG_PREMIUM>("m_premium");
            }
        }

        public CollectionDeckSlot m_slot
        {
            get
            {
                return base.method_3<CollectionDeckSlot>("m_slot");
            }
        }

        public CollectionManagerDisplay.ViewMode m_visualType
        {
            get
            {
                return base.method_2<CollectionManagerDisplay.ViewMode>("m_visualType");
            }
        }
    }
}

