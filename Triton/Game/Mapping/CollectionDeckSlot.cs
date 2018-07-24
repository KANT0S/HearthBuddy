namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("CollectionDeckSlot")]
    public class CollectionDeckSlot : MonoClass
    {
        public CollectionDeckSlot(IntPtr address) : this(address, "CollectionDeckSlot")
        {
        }

        public CollectionDeckSlot(IntPtr address, string className) : base(address, className)
        {
        }

        public void CopyFrom(CollectionDeckSlot otherSlot)
        {
            object[] objArray1 = new object[] { otherSlot };
            base.method_8("CopyFrom", objArray1);
        }

        public long GetUID(DeckType deckType)
        {
            object[] objArray1 = new object[] { deckType };
            return base.method_11<long>("GetUID", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public string CardID
        {
            get
            {
                return base.method_13("get_CardID", Array.Empty<object>());
            }
        }

        public long ClientUID
        {
            get
            {
                return base.method_11<long>("get_ClientUID", Array.Empty<object>());
            }
        }

        public int Count
        {
            get
            {
                return base.method_11<int>("get_Count", Array.Empty<object>());
            }
        }

        public int Index
        {
            get
            {
                return base.method_11<int>("get_Index", Array.Empty<object>());
            }
        }

        public string m_cardId
        {
            get
            {
                return base.method_4("m_cardId");
            }
        }

        public int m_count
        {
            get
            {
                return base.method_2<int>("m_count");
            }
        }

        public int m_index
        {
            get
            {
                return base.method_2<int>("m_index");
            }
        }

        public bool m_owned
        {
            get
            {
                return base.method_2<bool>("m_owned");
            }
        }

        public TAG_PREMIUM m_premium
        {
            get
            {
                return base.method_2<TAG_PREMIUM>("m_premium");
            }
        }

        public bool Owned
        {
            get
            {
                return base.method_11<bool>("get_Owned", Array.Empty<object>());
            }
        }

        public TAG_PREMIUM Premium
        {
            get
            {
                return base.method_11<TAG_PREMIUM>("get_Premium", Array.Empty<object>());
            }
        }

        public long UID
        {
            get
            {
                return base.method_11<long>("get_UID", Array.Empty<object>());
            }
        }
    }
}

