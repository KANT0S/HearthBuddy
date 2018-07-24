namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BnetPresenceMgr")]
    public class BnetPresenceMgr : MonoClass
    {
        public BnetPresenceMgr(IntPtr address) : this(address, "BnetPresenceMgr")
        {
        }

        public BnetPresenceMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddChangedPlayer(BnetPlayer player, BnetPlayerChangelist changelist)
        {
            object[] objArray1 = new object[] { player, changelist };
            base.method_8("AddChangedPlayer", objArray1);
        }

        public void CacheMyself(BnetGameAccount gameAccount, BnetPlayer player)
        {
            object[] objArray1 = new object[] { gameAccount, player };
            base.method_8("CacheMyself", objArray1);
        }

        public BnetPlayerChangelist ChangeGameField(BnetGameAccount hsGameAccount, uint fieldId, object val)
        {
            object[] objArray1 = new object[] { hsGameAccount, fieldId, val };
            return base.method_14<BnetPlayerChangelist>("ChangeGameField", objArray1);
        }

        public void FirePlayersChangedEvent(BnetPlayerChangelist changelist)
        {
            object[] objArray1 = new object[] { changelist };
            base.method_8("FirePlayersChangedEvent", objArray1);
        }

        public static BnetPresenceMgr Get()
        {
            return MonoClass.smethod_15<BnetPresenceMgr>(TritonHs.MainAssemblyPath, "", "BnetPresenceMgr", "Get", Array.Empty<object>());
        }

        public BnetPlayer GetMyPlayer()
        {
            return base.method_14<BnetPlayer>("GetMyPlayer", Array.Empty<object>());
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public bool SetGameField(uint fieldId, bool val)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.U4, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { fieldId, val };
            return base.method_10<bool>("SetGameField", enumArray1, objArray1);
        }

        public bool SetGameField(uint fieldId, int val)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.U4, Class272.Enum20.I4 };
            object[] objArray1 = new object[] { fieldId, val };
            return base.method_10<bool>("SetGameField", enumArray1, objArray1);
        }

        public bool SetGameField(uint fieldId, string val)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.U4, Class272.Enum20.String };
            object[] objArray1 = new object[] { fieldId, val };
            return base.method_10<bool>("SetGameField", enumArray1, objArray1);
        }

        public void Shutdown()
        {
            base.method_8("Shutdown", Array.Empty<object>());
        }

        public BnetPlayer m_myPlayer
        {
            get
            {
                return base.method_3<BnetPlayer>("m_myPlayer");
            }
        }
    }
}

