namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BnetGameAccount")]
    public class BnetGameAccount : MonoClass
    {
        public BnetGameAccount(IntPtr address) : this(address, "BnetGameAccount")
        {
        }

        public BnetGameAccount(IntPtr address, string className) : base(address, className)
        {
        }

        public bool CanBeInvitedToGame()
        {
            return base.method_11<bool>("CanBeInvitedToGame", Array.Empty<object>());
        }

        public BnetGameAccount Clone()
        {
            return base.method_14<BnetGameAccount>("Clone", Array.Empty<object>());
        }

        public bool Equals(object obj)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { obj };
            return base.method_10<bool>("Equals", enumArray1, objArray1);
        }

        public string GetArenaRecord()
        {
            return base.method_13("GetArenaRecord", Array.Empty<object>());
        }

        public ulong GetAwayTimeMicrosec()
        {
            return base.method_11<ulong>("GetAwayTimeMicrosec", Array.Empty<object>());
        }

        public BnetBattleTag GetBattleTag()
        {
            return base.method_14<BnetBattleTag>("GetBattleTag", Array.Empty<object>());
        }

        public string GetCardsOpened()
        {
            return base.method_13("GetCardsOpened", Array.Empty<object>());
        }

        public string GetClientEnv()
        {
            return base.method_13("GetClientEnv", Array.Empty<object>());
        }

        public string GetClientVersion()
        {
            return base.method_13("GetClientVersion", Array.Empty<object>());
        }

        public int GetCollectionEvent()
        {
            return base.method_11<int>("GetCollectionEvent", Array.Empty<object>());
        }

        public string GetDebugString()
        {
            return base.method_13("GetDebugString", Array.Empty<object>());
        }

        public int GetDruidLevel()
        {
            return base.method_11<int>("GetDruidLevel", Array.Empty<object>());
        }

        public int GetGainMedal()
        {
            return base.method_11<int>("GetGainMedal", Array.Empty<object>());
        }

        public object GetGameField(uint fieldId)
        {
            object[] objArray1 = new object[] { fieldId };
            return base.method_14<object>("GetGameField", objArray1);
        }

        public bool GetGameFieldBool(uint fieldId)
        {
            object[] objArray1 = new object[] { fieldId };
            return base.method_11<bool>("GetGameFieldBool", objArray1);
        }

        public List<byte> GetGameFieldBytes(uint fieldId)
        {
            object[] objArray1 = new object[] { fieldId };
            Class246<byte> class2 = base.method_14<Class246<byte>>("GetGameFieldBytes", objArray1);
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public int GetGameFieldInt(uint fieldId)
        {
            object[] objArray1 = new object[] { fieldId };
            return base.method_11<int>("GetGameFieldInt", objArray1);
        }

        public string GetGameFieldString(uint fieldId)
        {
            object[] objArray1 = new object[] { fieldId };
            return base.method_13("GetGameFieldString", objArray1);
        }

        public int GetHashCode()
        {
            return base.method_11<int>("GetHashCode", Array.Empty<object>());
        }

        public int GetHunterLevel()
        {
            return base.method_11<int>("GetHunterLevel", Array.Empty<object>());
        }

        public ulong GetLastOnlineMicrosec()
        {
            return base.method_11<ulong>("GetLastOnlineMicrosec", Array.Empty<object>());
        }

        public int GetMageLevel()
        {
            return base.method_11<int>("GetMageLevel", Array.Empty<object>());
        }

        public int GetPaladinLevel()
        {
            return base.method_11<int>("GetPaladinLevel", Array.Empty<object>());
        }

        public int GetPriestLevel()
        {
            return base.method_11<int>("GetPriestLevel", Array.Empty<object>());
        }

        public string GetRichPresence()
        {
            return base.method_13("GetRichPresence", Array.Empty<object>());
        }

        public int GetRogueLevel()
        {
            return base.method_11<int>("GetRogueLevel", Array.Empty<object>());
        }

        public int GetShamanLevel()
        {
            return base.method_11<int>("GetShamanLevel", Array.Empty<object>());
        }

        public int GetTutorialBeaten()
        {
            return base.method_11<int>("GetTutorialBeaten", Array.Empty<object>());
        }

        public int GetWarlockLevel()
        {
            return base.method_11<int>("GetWarlockLevel", Array.Empty<object>());
        }

        public int GetWarriorLevel()
        {
            return base.method_11<int>("GetWarriorLevel", Array.Empty<object>());
        }

        public bool HasGameField(uint fieldId)
        {
            object[] objArray1 = new object[] { fieldId };
            return base.method_11<bool>("HasGameField", objArray1);
        }

        public bool IsAway()
        {
            return base.method_11<bool>("IsAway", Array.Empty<object>());
        }

        public bool IsBusy()
        {
            return base.method_11<bool>("IsBusy", Array.Empty<object>());
        }

        public bool IsOnline()
        {
            return base.method_11<bool>("IsOnline", Array.Empty<object>());
        }

        public bool IsSpectatorSlotAvailable()
        {
            return base.method_11<bool>("IsSpectatorSlotAvailable", Array.Empty<object>());
        }

        public static bool op_Equality(BnetGameAccount a, BnetGameAccount b)
        {
            object[] objArray1 = new object[] { a, b };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "BnetGameAccount", "op_Equality", objArray1);
        }

        public static bool op_Inequality(BnetGameAccount a, BnetGameAccount b)
        {
            object[] objArray1 = new object[] { a, b };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "BnetGameAccount", "op_Inequality", objArray1);
        }

        public bool RemoveGameField(uint fieldId)
        {
            object[] objArray1 = new object[] { fieldId };
            return base.method_11<bool>("RemoveGameField", objArray1);
        }

        public void SetAway(bool away)
        {
            object[] objArray1 = new object[] { away };
            base.method_8("SetAway", objArray1);
        }

        public void SetAwayTimeMicrosec(ulong awayTimeMicrosec)
        {
            object[] objArray1 = new object[] { awayTimeMicrosec };
            base.method_8("SetAwayTimeMicrosec", objArray1);
        }

        public void SetBattleTag(BnetBattleTag battleTag)
        {
            object[] objArray1 = new object[] { battleTag };
            base.method_8("SetBattleTag", objArray1);
        }

        public void SetBusy(bool busy)
        {
            object[] objArray1 = new object[] { busy };
            base.method_8("SetBusy", objArray1);
        }

        public void SetGameField(uint fieldId, object val)
        {
            object[] objArray1 = new object[] { fieldId, val };
            base.method_8("SetGameField", objArray1);
        }

        public void SetLastOnlineMicrosec(ulong microsec)
        {
            object[] objArray1 = new object[] { microsec };
            base.method_8("SetLastOnlineMicrosec", objArray1);
        }

        public void SetOnline(bool online)
        {
            object[] objArray1 = new object[] { online };
            base.method_8("SetOnline", objArray1);
        }

        public void SetRichPresence(string richPresence)
        {
            object[] objArray1 = new object[] { richPresence };
            base.method_8("SetRichPresence", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public bool m_away
        {
            get
            {
                return base.method_2<bool>("m_away");
            }
        }

        public ulong m_awayTimeMicrosec
        {
            get
            {
                return base.method_2<ulong>("m_awayTimeMicrosec");
            }
        }

        public BnetBattleTag m_battleTag
        {
            get
            {
                return base.method_3<BnetBattleTag>("m_battleTag");
            }
        }

        public bool m_busy
        {
            get
            {
                return base.method_2<bool>("m_busy");
            }
        }

        public ulong m_lastOnlineMicrosec
        {
            get
            {
                return base.method_2<ulong>("m_lastOnlineMicrosec");
            }
        }

        public bool m_online
        {
            get
            {
                return base.method_2<bool>("m_online");
            }
        }

        public string m_richPresence
        {
            get
            {
                return base.method_4("m_richPresence");
            }
        }
    }
}

