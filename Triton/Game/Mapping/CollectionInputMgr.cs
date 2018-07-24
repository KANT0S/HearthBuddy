namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CollectionInputMgr")]
    public class CollectionInputMgr : MonoBehaviour
    {
        public CollectionInputMgr(IntPtr address) : this(address, "CollectionInputMgr")
        {
        }

        public CollectionInputMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool CanGrabItem(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            return base.method_11<bool>("CanGrabItem", objArray1);
        }

        public void DropCard(DeckTrayDeckTileVisual deckTileToRemove)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { deckTileToRemove };
            base.method_9("DropCard", enumArray1, objArray1);
        }

        public void DropCard(bool dragCanceled, DeckTrayDeckTileVisual deckTileToRemove)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean, Class272.Enum20.Class };
            object[] objArray1 = new object[] { dragCanceled, deckTileToRemove };
            base.method_9("DropCard", enumArray1, objArray1);
        }

        public static CollectionInputMgr Get()
        {
            return MonoClass.smethod_15<CollectionInputMgr>(TritonHs.MainAssemblyPath, "", "CollectionInputMgr", "Get", Array.Empty<object>());
        }

        public bool GrabCard(CollectionCardVisual cardVisual)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { cardVisual };
            return base.method_10<bool>("GrabCard", enumArray1, objArray1);
        }

        public bool GrabCard(DeckTrayDeckTileVisual deckTileVisual)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { deckTileVisual };
            return base.method_10<bool>("GrabCard", enumArray1, objArray1);
        }

        public bool HandleKeyboardInput()
        {
            return base.method_11<bool>("HandleKeyboardInput", Array.Empty<object>());
        }

        public bool HasHeldCard()
        {
            return base.method_11<bool>("HasHeldCard", Array.Empty<object>());
        }

        public bool IsDraggingScrollbar()
        {
            return base.method_11<bool>("IsDraggingScrollbar", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnMouseOnOrOffScreen(bool onScreen)
        {
            object[] objArray1 = new object[] { onScreen };
            base.method_8("OnMouseOnOrOffScreen", objArray1);
        }

        public void SetScrollbar(UIBScrollable scrollbar)
        {
            object[] objArray1 = new object[] { scrollbar };
            base.method_8("SetScrollbar", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateHeldCard()
        {
            base.method_8("UpdateHeldCard", Array.Empty<object>());
        }

        public bool m_cardsDraggable
        {
            get
            {
                return base.method_2<bool>("m_cardsDraggable");
            }
        }

        public Vector3 m_heldCardScreenSpace
        {
            get
            {
                return base.method_2<Vector3>("m_heldCardScreenSpace");
            }
        }

        public CollectionDraggableCardVisual m_heldCardVisual
        {
            get
            {
                return base.method_3<CollectionDraggableCardVisual>("m_heldCardVisual");
            }
        }

        public bool m_mouseIsOverDeck
        {
            get
            {
                return base.method_2<bool>("m_mouseIsOverDeck");
            }
        }

        public UIBScrollable m_scrollBar
        {
            get
            {
                return base.method_3<UIBScrollable>("m_scrollBar");
            }
        }

        public bool m_showingDeckTile
        {
            get
            {
                return base.method_2<bool>("m_showingDeckTile");
            }
        }

        public Collider TooltipPlane
        {
            get
            {
                return base.method_3<Collider>("TooltipPlane");
            }
        }
    }
}

