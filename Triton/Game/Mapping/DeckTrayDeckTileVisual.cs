namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DeckTrayDeckTileVisual")]
    public class DeckTrayDeckTileVisual : PegUIElement
    {
        public DeckTrayDeckTileVisual(IntPtr address) : this(address, "DeckTrayDeckTileVisual")
        {
        }

        public DeckTrayDeckTileVisual(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public CollectionDeckTileActor GetActor()
        {
            return base.method_14<CollectionDeckTileActor>("GetActor", Array.Empty<object>());
        }

        public Bounds GetBounds()
        {
            return base.method_11<Bounds>("GetBounds", Array.Empty<object>());
        }

        public string GetCardID()
        {
            return base.method_13("GetCardID", Array.Empty<object>());
        }

        public TAG_PREMIUM GetPremium()
        {
            return base.method_11<TAG_PREMIUM>("GetPremium", Array.Empty<object>());
        }

        public CollectionDeckSlot GetSlot()
        {
            return base.method_14<CollectionDeckSlot>("GetSlot", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public bool IsInUse()
        {
            return base.method_11<bool>("IsInUse", Array.Empty<object>());
        }

        public bool IsOwnedSlot()
        {
            return base.method_11<bool>("IsOwnedSlot", Array.Empty<object>());
        }

        public void MarkAsUnused()
        {
            base.method_8("MarkAsUnused", Array.Empty<object>());
        }

        public void MarkAsUsed()
        {
            base.method_8("MarkAsUsed", Array.Empty<object>());
        }

        public void SetHighlight(bool highlight)
        {
            object[] objArray1 = new object[] { highlight };
            base.method_8("SetHighlight", objArray1);
        }

        public void SetInArena(bool inArena)
        {
            object[] objArray1 = new object[] { inArena };
            base.method_8("SetInArena", objArray1);
        }

        public void SetSlot(CollectionDeckSlot s, bool useSliderAnimations)
        {
            object[] objArray1 = new object[] { s, useSliderAnimations };
            base.method_8("SetSlot", objArray1);
        }

        public void SetUpActor()
        {
            base.method_8("SetUpActor", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public Vector3 BOX_COLLIDER_CENTER
        {
            get
            {
                return base.method_2<Vector3>("BOX_COLLIDER_CENTER");
            }
        }

        public Vector3 BOX_COLLIDER_SIZE
        {
            get
            {
                return base.method_2<Vector3>("BOX_COLLIDER_SIZE");
            }
        }

        public static int DEFAULT_PORTRAIT_QUALITY
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "DeckTrayDeckTileVisual", "DEFAULT_PORTRAIT_QUALITY");
            }
        }

        public static GameLayer LAYER
        {
            get
            {
                return MonoClass.smethod_6<GameLayer>(TritonHs.MainAssemblyPath, "", "DeckTrayDeckTileVisual", "LAYER");
            }
        }

        public CollectionDeckTileActor m_actor
        {
            get
            {
                return base.method_3<CollectionDeckTileActor>("m_actor");
            }
        }

        public BoxCollider m_collider
        {
            get
            {
                return base.method_3<BoxCollider>("m_collider");
            }
        }

        public bool m_inArena
        {
            get
            {
                return base.method_2<bool>("m_inArena");
            }
        }

        public bool m_isInUse
        {
            get
            {
                return base.method_2<bool>("m_isInUse");
            }
        }

        public CollectionDeckSlot m_slot
        {
            get
            {
                return base.method_3<CollectionDeckSlot>("m_slot");
            }
        }

        public bool m_useSliderAnimations
        {
            get
            {
                return base.method_2<bool>("m_useSliderAnimations");
            }
        }
    }
}

