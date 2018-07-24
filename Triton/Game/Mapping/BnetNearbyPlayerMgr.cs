namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BnetNearbyPlayerMgr")]
    public class BnetNearbyPlayerMgr : MonoClass
    {
        public BnetNearbyPlayerMgr(IntPtr address) : this(address, "BnetNearbyPlayerMgr")
        {
        }

        public BnetNearbyPlayerMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void BeginListening()
        {
            base.method_8("BeginListening", Array.Empty<object>());
        }

        public void Broadcast()
        {
            base.method_8("Broadcast", Array.Empty<object>());
        }

        public void CacheMyAccountInfo()
        {
            base.method_8("CacheMyAccountInfo", Array.Empty<object>());
        }

        public bool CheckIntervalAndBroadcast()
        {
            return base.method_11<bool>("CheckIntervalAndBroadcast", Array.Empty<object>());
        }

        public void Clear()
        {
            base.method_8("Clear", Array.Empty<object>());
        }

        public string CreateBroadcastString()
        {
            return base.method_13("CreateBroadcastString", Array.Empty<object>());
        }

        public BnetPlayer FindNearbyFriend(BnetPlayer player)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { player };
            return base.method_15<BnetPlayer>("FindNearbyFriend", enumArray1, objArray1);
        }

        public BnetPlayer FindNearbyPlayer(BnetPlayer player)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { player };
            return base.method_15<BnetPlayer>("FindNearbyPlayer", enumArray1, objArray1);
        }

        public BnetPlayer FindNearbyStranger(BnetPlayer player)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { player };
            return base.method_15<BnetPlayer>("FindNearbyStranger", enumArray1, objArray1);
        }

        public void FireChangeEvent(BnetNearbyPlayerChangelist changelist)
        {
            object[] objArray1 = new object[] { changelist };
            base.method_8("FireChangeEvent", objArray1);
        }

        public static BnetNearbyPlayerMgr Get()
        {
            return MonoClass.smethod_15<BnetNearbyPlayerMgr>(TritonHs.MainAssemblyPath, "", "BnetNearbyPlayerMgr", "Get", Array.Empty<object>());
        }

        public bool GetAvailability()
        {
            return base.method_11<bool>("GetAvailability", Array.Empty<object>());
        }

        public List<BnetPlayer> GetNearbyFriends()
        {
            Class267<BnetPlayer> class2 = base.method_14<Class267<BnetPlayer>>("GetNearbyFriends", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<BnetPlayer> GetNearbyPlayers()
        {
            Class267<BnetPlayer> class2 = base.method_14<Class267<BnetPlayer>>("GetNearbyPlayers", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<BnetPlayer> GetNearbyStrangers()
        {
            Class267<BnetPlayer> class2 = base.method_14<Class267<BnetPlayer>>("GetNearbyStrangers", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void Initialize()
        {
            base.method_8("Initialize", Array.Empty<object>());
        }

        public bool IsEnabled()
        {
            return base.method_11<bool>("IsEnabled", Array.Empty<object>());
        }

        public bool IsNearbyFriend(BnetPlayer player)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { player };
            return base.method_10<bool>("IsNearbyFriend", enumArray1, objArray1);
        }

        public bool IsNearbyPlayer(BnetPlayer player)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { player };
            return base.method_10<bool>("IsNearbyPlayer", enumArray1, objArray1);
        }

        public bool IsNearbyStranger(BnetPlayer player)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { player };
            return base.method_10<bool>("IsNearbyStranger", enumArray1, objArray1);
        }

        public void OnEnabledOptionChanged(Triton.Game.Mapping.Option option, object prevValue, bool existed, object userData)
        {
            object[] objArray1 = new object[] { option, prevValue, existed, userData };
            base.method_8("OnEnabledOptionChanged", objArray1);
        }

        public void OnFriendsChanged(BnetFriendChangelist friendChangelist, object userData)
        {
            object[] objArray1 = new object[] { friendChangelist, userData };
            base.method_8("OnFriendsChanged", objArray1);
        }

        public void OnUdpReceive(IAsyncResult ar)
        {
            object[] objArray1 = new object[] { ar };
            base.method_8("OnUdpReceive", objArray1);
        }

        public void ProcessAddedPlayers(BnetNearbyPlayerChangelist changelist)
        {
            object[] objArray1 = new object[] { changelist };
            base.method_8("ProcessAddedPlayers", objArray1);
        }

        public void ProcessPlayerChanges()
        {
            base.method_8("ProcessPlayerChanges", Array.Empty<object>());
        }

        public void ProcessUpdatedPlayers(BnetNearbyPlayerChangelist changelist)
        {
            object[] objArray1 = new object[] { changelist };
            base.method_8("ProcessUpdatedPlayers", objArray1);
        }

        public void RemoveInactivePlayers(BnetNearbyPlayerChangelist changelist)
        {
            object[] objArray1 = new object[] { changelist };
            base.method_8("RemoveInactivePlayers", objArray1);
        }

        public void SetAvailability(bool av)
        {
            object[] objArray1 = new object[] { av };
            base.method_8("SetAvailability", objArray1);
        }

        public void SetEnabled(bool enabled)
        {
            object[] objArray1 = new object[] { enabled };
            base.method_8("SetEnabled", objArray1);
        }

        public void Shutdown()
        {
            base.method_8("Shutdown", Array.Empty<object>());
        }

        public void StopListening()
        {
            base.method_8("StopListening", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateEnabled()
        {
            base.method_8("UpdateEnabled", Array.Empty<object>());
        }

        public void UpdateNearbyPlayer(NearbyPlayer player, bool available, ulong sessionStartTime)
        {
            object[] objArray1 = new object[] { player, available, sessionStartTime };
            base.method_8("UpdateNearbyPlayer", objArray1);
        }

        public static float INACTIVITY_TIMEOUT
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "BnetNearbyPlayerMgr", "INACTIVITY_TIMEOUT");
            }
        }

        public bool m_availability
        {
            get
            {
                return base.method_2<bool>("m_availability");
            }
        }

        public string m_bnetEnvironment
        {
            get
            {
                return base.method_4("m_bnetEnvironment");
            }
        }

        public string m_bnetVersion
        {
            get
            {
                return base.method_4("m_bnetVersion");
            }
        }

        public bool m_enabled
        {
            get
            {
                return base.method_2<bool>("m_enabled");
            }
        }

        public string m_idString
        {
            get
            {
                return base.method_4("m_idString");
            }
        }

        public float m_lastCallTime
        {
            get
            {
                return base.method_2<float>("m_lastCallTime");
            }
        }

        public bool m_listening
        {
            get
            {
                return base.method_2<bool>("m_listening");
            }
        }

        public object m_mutex
        {
            get
            {
                return base.method_3<object>("m_mutex");
            }
        }

        public ulong m_myGameAccountLo
        {
            get
            {
                return base.method_2<ulong>("m_myGameAccountLo");
            }
        }

        public List<NearbyPlayer> m_nearbyAdds
        {
            get
            {
                Class267<NearbyPlayer> class2 = base.method_3<Class267<NearbyPlayer>>("m_nearbyAdds");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<BnetPlayer> m_nearbyBnetPlayers
        {
            get
            {
                Class267<BnetPlayer> class2 = base.method_3<Class267<BnetPlayer>>("m_nearbyBnetPlayers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<BnetPlayer> m_nearbyFriends
        {
            get
            {
                Class267<BnetPlayer> class2 = base.method_3<Class267<BnetPlayer>>("m_nearbyFriends");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<NearbyPlayer> m_nearbyPlayers
        {
            get
            {
                Class267<NearbyPlayer> class2 = base.method_3<Class267<NearbyPlayer>>("m_nearbyPlayers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<BnetPlayer> m_nearbyStrangers
        {
            get
            {
                Class267<BnetPlayer> class2 = base.method_3<Class267<BnetPlayer>>("m_nearbyStrangers");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public List<NearbyPlayer> m_nearbyUpdates
        {
            get
            {
                Class267<NearbyPlayer> class2 = base.method_3<Class267<NearbyPlayer>>("m_nearbyUpdates");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_port
        {
            get
            {
                return base.method_2<int>("m_port");
            }
        }

        public static int UDP_PORT
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "BnetNearbyPlayerMgr", "UDP_PORT");
            }
        }

        public static float UPDATE_INTERVAL
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "BnetNearbyPlayerMgr", "UPDATE_INTERVAL");
            }
        }

        [Attribute38("BnetNearbyPlayerMgr.NearbyPlayer")]
        public class NearbyPlayer : MonoClass
        {
            public NearbyPlayer(IntPtr address) : this(address, "NearbyPlayer")
            {
            }

            public NearbyPlayer(IntPtr address, string className) : base(address, className)
            {
            }

            public bool Equals(BnetNearbyPlayerMgr.NearbyPlayer other)
            {
                object[] objArray1 = new object[] { other };
                return base.method_11<bool>("Equals", objArray1);
            }

            public BnetGameAccount GetGameAccount()
            {
                return base.method_14<BnetGameAccount>("GetGameAccount", Array.Empty<object>());
            }

            public bool IsFriend()
            {
                return base.method_11<bool>("IsFriend", Array.Empty<object>());
            }

            public bool m_availability
            {
                get
                {
                    return base.method_2<bool>("m_availability");
                }
            }

            public BnetPlayer m_bnetPlayer
            {
                get
                {
                    return base.method_3<BnetPlayer>("m_bnetPlayer");
                }
            }

            public float m_lastReceivedTime
            {
                get
                {
                    return base.method_2<float>("m_lastReceivedTime");
                }
            }

            public ulong m_sessionStartTime
            {
                get
                {
                    return base.method_2<ulong>("m_sessionStartTime");
                }
            }
        }

        [Attribute38("BnetNearbyPlayerMgr.UdpState")]
        public class UdpState : MonoClass
        {
            public UdpState(IntPtr address) : this(address, "UdpState")
            {
            }

            public UdpState(IntPtr address, string className) : base(address, className)
            {
            }
        }
    }
}

