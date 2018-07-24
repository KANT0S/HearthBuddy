namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CollectionCardBack")]
    public class CollectionCardBack : MonoBehaviour
    {
        public CollectionCardBack(IntPtr address) : this(address, "CollectionCardBack")
        {
        }

        public CollectionCardBack(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public int GetCardBackId()
        {
            return base.method_11<int>("GetCardBackId", Array.Empty<object>());
        }

        public int GetSeasonId()
        {
            return base.method_11<int>("GetSeasonId", Array.Empty<object>());
        }

        public void SetCardBackId(int id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("SetCardBackId", objArray1);
        }

        public void SetCardBackName(string name)
        {
            object[] objArray1 = new object[] { name };
            base.method_8("SetCardBackName", objArray1);
        }

        public void SetSeasonId(int seasonId)
        {
            object[] objArray1 = new object[] { seasonId };
            base.method_8("SetSeasonId", objArray1);
        }

        public void ShowFavoriteBanner(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowFavoriteBanner", objArray1);
        }

        public int m_cardBackId
        {
            get
            {
                return base.method_2<int>("m_cardBackId");
            }
        }

        public GameObject m_favoriteBanner
        {
            get
            {
                return base.method_3<GameObject>("m_favoriteBanner");
            }
        }

        public UberText m_name
        {
            get
            {
                return base.method_3<UberText>("m_name");
            }
        }

        public GameObject m_nameFrame
        {
            get
            {
                return base.method_3<GameObject>("m_nameFrame");
            }
        }

        public int m_seasonId
        {
            get
            {
                return base.method_2<int>("m_seasonId");
            }
        }
    }
}

