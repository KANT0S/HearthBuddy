namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("TournamentDisplay")]
    public class TournamentDisplay : MonoBehaviour
    {
        public TournamentDisplay(IntPtr address) : this(address, "TournamentDisplay")
        {
        }

        public TournamentDisplay(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DeckPickerTrayLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("DeckPickerTrayLoaded", objArray1);
        }

        public static TournamentDisplay Get()
        {
            return MonoClass.smethod_15<TournamentDisplay>(TritonHs.MainAssemblyPath, "", "TournamentDisplay", "Get", Array.Empty<object>());
        }

        public NetCache.NetCacheMedalInfo GetCurrentMedalInfo()
        {
            return base.method_14<NetCache.NetCacheMedalInfo>("GetCurrentMedalInfo", Array.Empty<object>());
        }

        public int GetRankedWinsForClass(TAG_CLASS heroClass)
        {
            object[] objArray1 = new object[] { heroClass };
            return base.method_11<int>("GetRankedWinsForClass", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void Unload()
        {
            base.method_8("Unload", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateTourneyPage()
        {
            base.method_8("UpdateTourneyPage", Array.Empty<object>());
        }

        public bool m_allInitialized
        {
            get
            {
                return base.method_2<bool>("m_allInitialized");
            }
        }

        public NetCache.NetCacheMedalInfo m_currentMedalInfo
        {
            get
            {
                return base.method_3<NetCache.NetCacheMedalInfo>("m_currentMedalInfo");
            }
        }

        public DeckPickerTrayDisplay m_deckPickerTray
        {
            get
            {
                return base.method_3<DeckPickerTrayDisplay>("m_deckPickerTray");
            }
        }

        public bool m_deckPickerTrayLoaded
        {
            get
            {
                return base.method_2<bool>("m_deckPickerTrayLoaded");
            }
        }

        public TextMesh m_modeName
        {
            get
            {
                return base.method_3<TextMesh>("m_modeName");
            }
        }

        public bool m_netCacheReturned
        {
            get
            {
                return base.method_2<bool>("m_netCacheReturned");
            }
        }
    }
}

