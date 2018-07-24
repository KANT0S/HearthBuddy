namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardDbfRecord")]
    public class CardDbfRecord : DbfRecord
    {
        public CardDbfRecord(IntPtr address) : this(address, "CardDbfRecord")
        {
        }

        public CardDbfRecord(IntPtr address, string className) : base(address, className)
        {
        }

        public object GetVar(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_14<object>("GetVar", objArray1);
        }

        public System.Type GetVarType(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_14<System.Type>("GetVarType", objArray1);
        }

        public void SetCraftingEvent(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetCraftingEvent", objArray1);
        }

        public void SetHeroPowerId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetHeroPowerId", objArray1);
        }

        public void SetIsCollectible(bool v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetIsCollectible", objArray1);
        }

        public void SetLongGuid(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetLongGuid", objArray1);
        }

        public void SetNoteMiniGuid(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetNoteMiniGuid", objArray1);
        }

        public void SetSuggestionWeight(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetSuggestionWeight", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public string CraftingEvent
        {
            get
            {
                return base.method_13("get_CraftingEvent", Array.Empty<object>());
            }
        }

        public int HeroPowerId
        {
            get
            {
                return base.method_11<int>("get_HeroPowerId", Array.Empty<object>());
            }
        }

        public bool IsCollectible
        {
            get
            {
                return base.method_11<bool>("get_IsCollectible", Array.Empty<object>());
            }
        }

        public string LongGuid
        {
            get
            {
                return base.method_13("get_LongGuid", Array.Empty<object>());
            }
        }

        public string m_CraftingEvent
        {
            get
            {
                return base.method_4("m_CraftingEvent");
            }
        }

        public int m_HeroPowerId
        {
            get
            {
                return base.method_2<int>("m_HeroPowerId");
            }
        }

        public bool m_IsCollectible
        {
            get
            {
                return base.method_2<bool>("m_IsCollectible");
            }
        }

        public string m_LongGuid
        {
            get
            {
                return base.method_4("m_LongGuid");
            }
        }

        public string m_NoteMiniGuid
        {
            get
            {
                return base.method_4("m_NoteMiniGuid");
            }
        }

        public int m_SuggestionWeight
        {
            get
            {
                return base.method_2<int>("m_SuggestionWeight");
            }
        }

        public string NoteMiniGuid
        {
            get
            {
                return base.method_13("get_NoteMiniGuid", Array.Empty<object>());
            }
        }

        public int SuggestionWeight
        {
            get
            {
                return base.method_11<int>("get_SuggestionWeight", Array.Empty<object>());
            }
        }
    }
}

