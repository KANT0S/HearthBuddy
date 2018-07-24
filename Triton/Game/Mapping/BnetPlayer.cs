namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("BnetPlayer")]
    public class BnetPlayer : MonoClass
    {
        public BnetPlayer(IntPtr address) : this(address, "BnetPlayer")
        {
        }

        public BnetPlayer(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddGameAccount(BnetGameAccount gameAccount)
        {
            object[] objArray1 = new object[] { gameAccount };
            base.method_8("AddGameAccount", objArray1);
        }

        public void CacheSpecialGameAccounts()
        {
            base.method_8("CacheSpecialGameAccounts", Array.Empty<object>());
        }

        public BnetPlayer Clone()
        {
            return base.method_14<BnetPlayer>("Clone", Array.Empty<object>());
        }

        public BnetAccount GetAccount()
        {
            return base.method_14<BnetAccount>("GetAccount", Array.Empty<object>());
        }

        public BnetBattleTag GetBattleTag()
        {
            return base.method_14<BnetBattleTag>("GetBattleTag", Array.Empty<object>());
        }

        public ulong GetBestAwayTimeMicrosec()
        {
            return base.method_11<ulong>("GetBestAwayTimeMicrosec", Array.Empty<object>());
        }

        public BnetGameAccount GetBestGameAccount()
        {
            return base.method_14<BnetGameAccount>("GetBestGameAccount", Array.Empty<object>());
        }

        public ulong GetBestLastOnlineMicrosec()
        {
            return base.method_11<ulong>("GetBestLastOnlineMicrosec", Array.Empty<object>());
        }

        public string GetBestName()
        {
            return base.method_13("GetBestName", Array.Empty<object>());
        }

        public string GetBestRichPresence()
        {
            return base.method_13("GetBestRichPresence", Array.Empty<object>());
        }

        public BnetGameAccount GetFirstGameAccount()
        {
            return base.method_14<BnetGameAccount>("GetFirstGameAccount", Array.Empty<object>());
        }

        public string GetFullName()
        {
            return base.method_13("GetFullName", Array.Empty<object>());
        }

        public BnetGameAccount GetHearthstoneGameAccount()
        {
            return base.method_14<BnetGameAccount>("GetHearthstoneGameAccount", Array.Empty<object>());
        }

        public int GetNumOnlineGameAccounts()
        {
            return base.method_11<int>("GetNumOnlineGameAccounts", Array.Empty<object>());
        }

        public List<BnetGameAccount> GetOnlineGameAccounts()
        {
            Class267<BnetGameAccount> class2 = base.method_14<Class267<BnetGameAccount>>("GetOnlineGameAccounts", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public long GetPersistentGameId()
        {
            return base.method_11<long>("GetPersistentGameId", Array.Empty<object>());
        }

        public bool HasMultipleOnlineGameAccounts()
        {
            return base.method_11<bool>("HasMultipleOnlineGameAccounts", Array.Empty<object>());
        }

        public bool IsAway()
        {
            return base.method_11<bool>("IsAway", Array.Empty<object>());
        }

        public bool IsBusy()
        {
            return base.method_11<bool>("IsBusy", Array.Empty<object>());
        }

        public bool IsDisplayable()
        {
            return base.method_11<bool>("IsDisplayable", Array.Empty<object>());
        }

        public bool IsOnline()
        {
            return base.method_11<bool>("IsOnline", Array.Empty<object>());
        }

        public void OnGameAccountChanged(uint fieldId)
        {
            object[] objArray1 = new object[] { fieldId };
            base.method_8("OnGameAccountChanged", objArray1);
        }

        public void SetAccount(BnetAccount account)
        {
            object[] objArray1 = new object[] { account };
            base.method_8("SetAccount", objArray1);
        }

        public string ToString()
        {
            return base.method_13("ToString", Array.Empty<object>());
        }

        public BnetAccount m_account
        {
            get
            {
                return base.method_3<BnetAccount>("m_account");
            }
        }

        public BnetGameAccount m_bestGameAccount
        {
            get
            {
                return base.method_3<BnetGameAccount>("m_bestGameAccount");
            }
        }

        public BnetGameAccount m_hsGameAccount
        {
            get
            {
                return base.method_3<BnetGameAccount>("m_hsGameAccount");
            }
        }
    }
}

