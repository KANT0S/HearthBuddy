namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ScenarioDbfRecord")]
    public class ScenarioDbfRecord : DbfRecord
    {
        public ScenarioDbfRecord(IntPtr address) : this(address, "ScenarioDbfRecord")
        {
        }

        public ScenarioDbfRecord(IntPtr address, string className) : base(address, className)
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

        public void SetAdventureId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetAdventureId", objArray1);
        }

        public void SetClientPlayer2HeroCardId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetClientPlayer2HeroCardId", objArray1);
        }

        public void SetCompletedDescription(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetCompletedDescription", objArray1);
        }

        public void SetDeckBuilderId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetDeckBuilderId", objArray1);
        }

        public void SetDeckRulesetId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetDeckRulesetId", objArray1);
        }

        public void SetDescription(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetDescription", objArray1);
        }

        public void SetIsCoop(bool v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetIsCoop", objArray1);
        }

        public void SetIsExpert(bool v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetIsExpert", objArray1);
        }

        public void SetIsTutorial(bool v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetIsTutorial", objArray1);
        }

        public void SetModeId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetModeId", objArray1);
        }

        public void SetName(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetName", objArray1);
        }

        public void SetNoteDesc(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetNoteDesc", objArray1);
        }

        public void SetOpponentName(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetOpponentName", objArray1);
        }

        public void SetPlayer1DeckId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetPlayer1DeckId", objArray1);
        }

        public void SetPlayer1HeroCardId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetPlayer1HeroCardId", objArray1);
        }

        public void SetPlayer2HeroCardId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetPlayer2HeroCardId", objArray1);
        }

        public void SetPlayers(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetPlayers", objArray1);
        }

        public void SetShortName(DbfLocValue v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetShortName", objArray1);
        }

        public void SetSortOrder(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetSortOrder", objArray1);
        }

        public void SetTbTexture(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetTbTexture", objArray1);
        }

        public void SetTbTexturePhone(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetTbTexturePhone", objArray1);
        }

        public void SetTbTexturePhoneOffsetY(float v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetTbTexturePhoneOffsetY", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public void SetWingId(int v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetWingId", objArray1);
        }

        public int AdventureId
        {
            get
            {
                return base.method_11<int>("get_AdventureId", Array.Empty<object>());
            }
        }

        public int ClientPlayer2HeroCardId
        {
            get
            {
                return base.method_11<int>("get_ClientPlayer2HeroCardId", Array.Empty<object>());
            }
        }

        public DbfLocValue CompletedDescription
        {
            get
            {
                return base.method_14<DbfLocValue>("get_CompletedDescription", Array.Empty<object>());
            }
        }

        public int DeckBuilderId
        {
            get
            {
                return base.method_11<int>("get_DeckBuilderId", Array.Empty<object>());
            }
        }

        public int DeckRulesetId
        {
            get
            {
                return base.method_11<int>("get_DeckRulesetId", Array.Empty<object>());
            }
        }

        public DbfLocValue Description
        {
            get
            {
                return base.method_14<DbfLocValue>("get_Description", Array.Empty<object>());
            }
        }

        public bool IsCoop
        {
            get
            {
                return base.method_11<bool>("get_IsCoop", Array.Empty<object>());
            }
        }

        public bool IsExpert
        {
            get
            {
                return base.method_11<bool>("get_IsExpert", Array.Empty<object>());
            }
        }

        public bool IsTutorial
        {
            get
            {
                return base.method_11<bool>("get_IsTutorial", Array.Empty<object>());
            }
        }

        public int m_AdventureId
        {
            get
            {
                return base.method_2<int>("m_AdventureId");
            }
        }

        public int m_ClientPlayer2HeroCardId
        {
            get
            {
                return base.method_2<int>("m_ClientPlayer2HeroCardId");
            }
        }

        public DbfLocValue m_CompletedDescription
        {
            get
            {
                return base.method_3<DbfLocValue>("m_CompletedDescription");
            }
        }

        public int m_DeckBuilderId
        {
            get
            {
                return base.method_2<int>("m_DeckBuilderId");
            }
        }

        public int m_DeckRulesetId
        {
            get
            {
                return base.method_2<int>("m_DeckRulesetId");
            }
        }

        public DbfLocValue m_Description
        {
            get
            {
                return base.method_3<DbfLocValue>("m_Description");
            }
        }

        public bool m_IsCoop
        {
            get
            {
                return base.method_2<bool>("m_IsCoop");
            }
        }

        public bool m_IsExpert
        {
            get
            {
                return base.method_2<bool>("m_IsExpert");
            }
        }

        public bool m_IsTutorial
        {
            get
            {
                return base.method_2<bool>("m_IsTutorial");
            }
        }

        public int m_ModeId
        {
            get
            {
                return base.method_2<int>("m_ModeId");
            }
        }

        public DbfLocValue m_Name
        {
            get
            {
                return base.method_3<DbfLocValue>("m_Name");
            }
        }

        public string m_NoteDesc
        {
            get
            {
                return base.method_4("m_NoteDesc");
            }
        }

        public DbfLocValue m_OpponentName
        {
            get
            {
                return base.method_3<DbfLocValue>("m_OpponentName");
            }
        }

        public int m_Player1DeckId
        {
            get
            {
                return base.method_2<int>("m_Player1DeckId");
            }
        }

        public int m_Player1HeroCardId
        {
            get
            {
                return base.method_2<int>("m_Player1HeroCardId");
            }
        }

        public int m_Player2HeroCardId
        {
            get
            {
                return base.method_2<int>("m_Player2HeroCardId");
            }
        }

        public int m_Players
        {
            get
            {
                return base.method_2<int>("m_Players");
            }
        }

        public DbfLocValue m_ShortName
        {
            get
            {
                return base.method_3<DbfLocValue>("m_ShortName");
            }
        }

        public int m_SortOrder
        {
            get
            {
                return base.method_2<int>("m_SortOrder");
            }
        }

        public string m_TbTexture
        {
            get
            {
                return base.method_4("m_TbTexture");
            }
        }

        public string m_TbTexturePhone
        {
            get
            {
                return base.method_4("m_TbTexturePhone");
            }
        }

        public float m_TbTexturePhoneOffsetY
        {
            get
            {
                return base.method_2<float>("m_TbTexturePhoneOffsetY");
            }
        }

        public int m_WingId
        {
            get
            {
                return base.method_2<int>("m_WingId");
            }
        }

        public int ModeId
        {
            get
            {
                return base.method_11<int>("get_ModeId", Array.Empty<object>());
            }
        }

        public DbfLocValue Name
        {
            get
            {
                return base.method_14<DbfLocValue>("get_Name", Array.Empty<object>());
            }
        }

        public string NoteDesc
        {
            get
            {
                return base.method_13("get_NoteDesc", Array.Empty<object>());
            }
        }

        public DbfLocValue OpponentName
        {
            get
            {
                return base.method_14<DbfLocValue>("get_OpponentName", Array.Empty<object>());
            }
        }

        public int Player1DeckId
        {
            get
            {
                return base.method_11<int>("get_Player1DeckId", Array.Empty<object>());
            }
        }

        public int Player1HeroCardId
        {
            get
            {
                return base.method_11<int>("get_Player1HeroCardId", Array.Empty<object>());
            }
        }

        public int Player2HeroCardId
        {
            get
            {
                return base.method_11<int>("get_Player2HeroCardId", Array.Empty<object>());
            }
        }

        public int Players
        {
            get
            {
                return base.method_11<int>("get_Players", Array.Empty<object>());
            }
        }

        public DbfLocValue ShortName
        {
            get
            {
                return base.method_14<DbfLocValue>("get_ShortName", Array.Empty<object>());
            }
        }

        public int SortOrder
        {
            get
            {
                return base.method_11<int>("get_SortOrder", Array.Empty<object>());
            }
        }

        public string TbTexture
        {
            get
            {
                return base.method_13("get_TbTexture", Array.Empty<object>());
            }
        }

        public string TbTexturePhone
        {
            get
            {
                return base.method_13("get_TbTexturePhone", Array.Empty<object>());
            }
        }

        public float TbTexturePhoneOffsetY
        {
            get
            {
                return base.method_11<float>("get_TbTexturePhoneOffsetY", Array.Empty<object>());
            }
        }

        public int WingId
        {
            get
            {
                return base.method_11<int>("get_WingId", Array.Empty<object>());
            }
        }
    }
}

