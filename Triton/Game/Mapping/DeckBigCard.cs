namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeckBigCard")]
    public class DeckBigCard : MonoBehaviour
    {
        public DeckBigCard(IntPtr address) : this(address, "DeckBigCard")
        {
        }

        public DeckBigCard(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ForceHide()
        {
            base.method_8("ForceHide", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_9("Hide", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void Hide(EntityDef entityDef, TAG_PREMIUM premium)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { entityDef, premium };
            base.method_9("Hide", enumArray1, objArray1);
        }

        public void OnActorLoaded(string name, Actor actor, object callbackData)
        {
            object[] objArray1 = new object[] { name, actor, callbackData };
            base.method_8("OnActorLoaded", objArray1);
        }

        public void Show()
        {
            base.method_9("Show", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void Show(EntityDef entityDef, TAG_PREMIUM premium, CardDef cardDef, Vector3 sourcePosition, bool ghosted, float delay)
        {
            object[] objArray1 = new object[] { entityDef, premium, cardDef, sourcePosition, ghosted, delay };
            base.method_9("Show", new Class272.Enum20[] { Class272.Enum20.Class }, objArray1);
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

        public GameObject m_bottomPosition
        {
            get
            {
                return base.method_3<GameObject>("m_bottomPosition");
            }
        }

        public CardDef m_cardDef
        {
            get
            {
                return base.method_3<CardDef>("m_cardDef");
            }
        }

        public EntityDef m_entityDef
        {
            get
            {
                return base.method_3<EntityDef>("m_entityDef");
            }
        }

        public int m_firstShowFrame
        {
            get
            {
                return base.method_2<int>("m_firstShowFrame");
            }
        }

        public Material m_ghostCardMaterial
        {
            get
            {
                return base.method_3<Material>("m_ghostCardMaterial");
            }
        }

        public bool m_ghosted
        {
            get
            {
                return base.method_2<bool>("m_ghosted");
            }
        }

        public Material m_missingCardMaterial
        {
            get
            {
                return base.method_3<Material>("m_missingCardMaterial");
            }
        }

        public TAG_PREMIUM m_premium
        {
            get
            {
                return base.method_2<TAG_PREMIUM>("m_premium");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }

        public Actor m_shownActor
        {
            get
            {
                return base.method_3<Actor>("m_shownActor");
            }
        }

        public GameObject m_topPosition
        {
            get
            {
                return base.method_3<GameObject>("m_topPosition");
            }
        }
    }
}

