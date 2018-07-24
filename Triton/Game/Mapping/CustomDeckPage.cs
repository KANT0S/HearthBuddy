namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CustomDeckPage")]
    public class CustomDeckPage : MonoBehaviour
    {
        public CustomDeckPage(IntPtr address) : this(address, "CustomDeckPage")
        {
        }

        public CustomDeckPage(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AreAllCustomDecksReady()
        {
            return base.method_11<bool>("AreAllCustomDecksReady", Array.Empty<object>());
        }

        public CollectionDeckBoxVisual GetDeckboxWithDeckID(long deckID)
        {
            object[] objArray1 = new object[] { deckID };
            return base.method_14<CollectionDeckBoxVisual>("GetDeckboxWithDeckID", objArray1);
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public void InitCustomDecks()
        {
            base.method_8("InitCustomDecks", Array.Empty<object>());
        }

        public bool PageReady()
        {
            return base.method_11<bool>("PageReady", Array.Empty<object>());
        }

        public void SetTrayTexture(Texture texture)
        {
            object[] objArray1 = new object[] { texture };
            base.method_8("SetTrayTexture", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public List<CollectionDeck> m_collectionDecks
        {
            get
            {
                Class267<CollectionDeck> class2 = base.method_3<Class267<CollectionDeck>>("m_collectionDecks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public float m_customDeckHorizontalSpacing
        {
            get
            {
                return base.method_2<float>("m_customDeckHorizontalSpacing");
            }
        }

        public List<CollectionDeckBoxVisual> m_customDecks
        {
            get
            {
                Class267<CollectionDeckBoxVisual> class2 = base.method_3<Class267<CollectionDeckBoxVisual>>("m_customDecks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Vector3 m_customDeckScale
        {
            get
            {
                return base.method_2<Vector3>("m_customDeckScale");
            }
        }

        public Vector3 m_customDeckStart
        {
            get
            {
                return base.method_2<Vector3>("m_customDeckStart");
            }
        }

        public float m_customDeckVerticalSpacing
        {
            get
            {
                return base.method_2<float>("m_customDeckVerticalSpacing");
            }
        }

        public Texture m_customTrayTexture
        {
            get
            {
                return base.method_3<Texture>("m_customTrayTexture");
            }
        }

        public GameObject m_deckboxCoverPrefab
        {
            get
            {
                return base.method_3<GameObject>("m_deckboxCoverPrefab");
            }
        }

        public CollectionDeckBoxVisual m_deckboxPrefab
        {
            get
            {
                return base.method_3<CollectionDeckBoxVisual>("m_deckboxPrefab");
            }
        }

        public Vector3 m_deckCoverOffset
        {
            get
            {
                return base.method_2<Vector3>("m_deckCoverOffset");
            }
        }

        public List<GameObject> m_deckCovers
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_deckCovers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_numCustomDecks
        {
            get
            {
                return base.method_2<int>("m_numCustomDecks");
            }
        }

        public static int MAX_CUSTOM_DECKS_TO_DISPLAY
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "CustomDeckPage", "MAX_CUSTOM_DECKS_TO_DISPLAY");
            }
        }
    }
}

