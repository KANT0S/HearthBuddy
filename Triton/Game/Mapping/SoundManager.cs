namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("SoundManager")]
    public class SoundManager : MonoBehaviour
    {
        public SoundManager(IntPtr address) : this(address, "SoundManager")
        {
        }

        public SoundManager(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateBeginningDuckState(DuckState state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("AnimateBeginningDuckState", objArray1);
        }

        public void AnimateRestoringDuckState(DuckState state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("AnimateRestoringDuckState", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void ChangeDuckState(DuckState state, DuckMode mode)
        {
            object[] objArray1 = new object[] { state, mode };
            base.method_8("ChangeDuckState", objArray1);
        }

        public void CleanInactiveSources()
        {
            base.method_8("CleanInactiveSources", Array.Empty<object>());
        }

        public SoundPlaybackLimitClipDef FindClipDefInPlaybackDef(string clipName, SoundPlaybackLimitDef def)
        {
            object[] objArray1 = new object[] { clipName, def };
            return base.method_14<SoundPlaybackLimitClipDef>("FindClipDefInPlaybackDef", objArray1);
        }

        public SoundDuckingDef FindDuckingDefForCategory(SoundCategory cat)
        {
            object[] objArray1 = new object[] { cat };
            return base.method_14<SoundDuckingDef>("FindDuckingDefForCategory", objArray1);
        }

        public void GarbageCollectBundles()
        {
            base.method_8("GarbageCollectBundles", Array.Empty<object>());
        }

        public static SoundManager Get()
        {
            return MonoClass.smethod_15<SoundManager>(TritonHs.MainAssemblyPath, "", "SoundManager", "Get", Array.Empty<object>());
        }

        public SoundConfig GetConfig()
        {
            return base.method_14<SoundConfig>("GetConfig", Array.Empty<object>());
        }

        public List<MusicTrack> GetCurrentAmbienceTracks()
        {
            Class267<MusicTrack> class2 = base.method_14<Class267<MusicTrack>>("GetCurrentAmbienceTracks", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public List<MusicTrack> GetCurrentMusicTracks()
        {
            Class267<MusicTrack> class2 = base.method_14<Class267<MusicTrack>>("GetCurrentMusicTracks", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public float GetDuckingVolume(SoundCategory cat)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.ValueType };
            object[] objArray1 = new object[] { cat };
            return base.method_10<float>("GetDuckingVolume", enumArray1, objArray1);
        }

        public uint GetNextDuckStateTweenId()
        {
            return base.method_11<uint>("GetNextDuckStateTweenId", Array.Empty<object>());
        }

        public int GetNextSourceId()
        {
            return base.method_11<int>("GetNextSourceId", Array.Empty<object>());
        }

        public GameObject GetPlaceholderSound()
        {
            return base.method_14<GameObject>("GetPlaceholderSound", Array.Empty<object>());
        }

        public void ImmediatelyKillMusicAndAmbience()
        {
            base.method_8("ImmediatelyKillMusicAndAmbience", Array.Empty<object>());
        }

        public void InitializeOptions()
        {
            base.method_8("InitializeOptions", Array.Empty<object>());
        }

        public bool IsInitialized()
        {
            return base.method_11<bool>("IsInitialized", Array.Empty<object>());
        }

        public bool Load(string soundName)
        {
            object[] objArray1 = new object[] { soundName };
            return base.method_11<bool>("Load", objArray1);
        }

        public void LoadAndPlay(string soundName)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { soundName };
            base.method_9("LoadAndPlay", enumArray1, objArray1);
        }

        public void LoadAndPlay(string soundName, float volume)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.R4 };
            object[] objArray1 = new object[] { soundName, volume };
            base.method_9("LoadAndPlay", enumArray1, objArray1);
        }

        public void LoadAndPlay(string soundName, GameObject parent)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.Class };
            object[] objArray1 = new object[] { soundName, parent };
            base.method_9("LoadAndPlay", enumArray1, objArray1);
        }

        public void LoadAndPlay(string soundName, GameObject parent, float volume)
        {
            object[] objArray1 = new object[] { soundName, parent, volume };
            base.method_9("LoadAndPlay", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public void NukeAmbienceAndStopPlayingCurrentTrack()
        {
            base.method_8("NukeAmbienceAndStopPlayingCurrentTrack", Array.Empty<object>());
        }

        public void NukeMusicAndAmbiencePlaylists()
        {
            base.method_8("NukeMusicAndAmbiencePlaylists", Array.Empty<object>());
        }

        public void NukeMusicAndStopPlayingCurrentTrack()
        {
            base.method_8("NukeMusicAndStopPlayingCurrentTrack", Array.Empty<object>());
        }

        public void NukePlaylistsAndStopPlayingCurrentTracks()
        {
            base.method_8("NukePlaylistsAndStopPlayingCurrentTracks", Array.Empty<object>());
        }

        public void OnAmbienceLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnAmbienceLoaded", objArray1);
        }

        public void OnAppFocusChanged(bool focus, object userData)
        {
            object[] objArray1 = new object[] { focus, userData };
            base.method_8("OnAppFocusChanged", objArray1);
        }

        public void OnBackgroundSoundOptionChanged(Triton.Game.Mapping.Option option, object prevValue, bool existed, object userData)
        {
            object[] objArray1 = new object[] { option, prevValue, existed, userData };
            base.method_8("OnBackgroundSoundOptionChanged", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDuckStateBeginningComplete(DuckState state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("OnDuckStateBeginningComplete", objArray1);
        }

        public void OnDuckStateRestoringComplete(DuckState state)
        {
            object[] objArray1 = new object[] { state };
            base.method_8("OnDuckStateRestoringComplete", objArray1);
        }

        public void OnEnabledOptionChanged(Triton.Game.Mapping.Option option, object prevValue, bool existed, object userData)
        {
            object[] objArray1 = new object[] { option, prevValue, existed, userData };
            base.method_8("OnEnabledOptionChanged", objArray1);
        }

        public void OnLoadAndPlaySoundLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnLoadAndPlaySoundLoaded", objArray1);
        }

        public void OnLoadSoundLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnLoadSoundLoaded", objArray1);
        }

        public void OnMasterEnabledOptionChanged(Triton.Game.Mapping.Option option, object prevValue, bool existed, object userData)
        {
            object[] objArray1 = new object[] { option, prevValue, existed, userData };
            base.method_8("OnMasterEnabledOptionChanged", objArray1);
        }

        public void OnMasterVolumeOptionChanged(Triton.Game.Mapping.Option option, object prevValue, bool existed, object userData)
        {
            object[] objArray1 = new object[] { option, prevValue, existed, userData };
            base.method_8("OnMasterVolumeOptionChanged", objArray1);
        }

        public void OnMusicLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnMusicLoaded", objArray1);
        }

        public void OnSceneLoaded(SceneMgr.Mode mode, Scene scene, object userData)
        {
            object[] objArray1 = new object[] { mode, scene, userData };
            base.method_8("OnSceneLoaded", objArray1);
        }

        public void OnVolumeOptionChanged(Triton.Game.Mapping.Option option, object prevValue, bool existed, object userData)
        {
            object[] objArray1 = new object[] { option, prevValue, existed, userData };
            base.method_8("OnVolumeOptionChanged", objArray1);
        }

        public bool PlayNextAmbience()
        {
            return base.method_11<bool>("PlayNextAmbience", Array.Empty<object>());
        }

        public bool PlayNextMusic()
        {
            return base.method_11<bool>("PlayNextMusic", Array.Empty<object>());
        }

        public void PrintAllCategorySources()
        {
            base.method_8("PrintAllCategorySources", Array.Empty<object>());
        }

        public DuckState RegisterDuckState(object trigger, SoundDuckedCategoryDef duckedCatDef)
        {
            object[] objArray1 = new object[] { trigger, duckedCatDef };
            return base.method_14<DuckState>("RegisterDuckState", objArray1);
        }

        public void SetConfig(SoundConfig config)
        {
            object[] objArray1 = new object[] { config };
            base.method_8("SetConfig", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public bool StartDucking(SoundDucker ducker)
        {
            object[] objArray1 = new object[] { ducker };
            return base.method_11<bool>("StartDucking", objArray1);
        }

        public void StopCurrentAmbienceTrack()
        {
            base.method_8("StopCurrentAmbienceTrack", Array.Empty<object>());
        }

        public void StopCurrentMusicTrack()
        {
            base.method_8("StopCurrentMusicTrack", Array.Empty<object>());
        }

        public void StopDucking(SoundDucker ducker)
        {
            object[] objArray1 = new object[] { ducker };
            base.method_8("StopDucking", objArray1);
        }

        public void UnloadSoundBundle(string name)
        {
            object[] objArray1 = new object[] { name };
            base.method_8("UnloadSoundBundle", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateAllCategoryVolumes()
        {
            base.method_8("UpdateAllCategoryVolumes", Array.Empty<object>());
        }

        public void UpdateAllMutes()
        {
            base.method_8("UpdateAllMutes", Array.Empty<object>());
        }

        public void UpdateAppMute()
        {
            base.method_8("UpdateAppMute", Array.Empty<object>());
        }

        public void UpdateCategoryMute(SoundCategory cat)
        {
            object[] objArray1 = new object[] { cat };
            base.method_8("UpdateCategoryMute", objArray1);
        }

        public void UpdateCategoryVolume(SoundCategory cat)
        {
            object[] objArray1 = new object[] { cat };
            base.method_8("UpdateCategoryVolume", objArray1);
        }

        public void UpdateDuckStates()
        {
            base.method_8("UpdateDuckStates", Array.Empty<object>());
        }

        public void UpdateGeneratedSources()
        {
            base.method_8("UpdateGeneratedSources", Array.Empty<object>());
        }

        public void UpdateMusicAndAmbience()
        {
            base.method_8("UpdateMusicAndAmbience", Array.Empty<object>());
        }

        public void UpdateMusicAndSources()
        {
            base.method_8("UpdateMusicAndSources", Array.Empty<object>());
        }

        public void UpdateSourceBundles()
        {
            base.method_8("UpdateSourceBundles", Array.Empty<object>());
        }

        public void UpdateSourceExtensionMappings()
        {
            base.method_8("UpdateSourceExtensionMappings", Array.Empty<object>());
        }

        public void UpdateSources()
        {
            base.method_8("UpdateSources", Array.Empty<object>());
        }

        public void UpdateSourcesByCategory()
        {
            base.method_8("UpdateSourcesByCategory", Array.Empty<object>());
        }

        public void UpdateSourcesByClipName()
        {
            base.method_8("UpdateSourcesByClipName", Array.Empty<object>());
        }

        public bool m_ambienceIsAboutToPlay
        {
            get
            {
                return base.method_2<bool>("m_ambienceIsAboutToPlay");
            }
        }

        public int m_ambienceTrackIndex
        {
            get
            {
                return base.method_2<int>("m_ambienceTrackIndex");
            }
        }

        public List<MusicTrack> m_ambienceTracks
        {
            get
            {
                Class267<MusicTrack> class2 = base.method_3<Class267<MusicTrack>>("m_ambienceTracks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public SoundConfig m_config
        {
            get
            {
                return base.method_3<SoundConfig>("m_config");
            }
        }

        public List<ExtensionMapping> m_extensionMappings
        {
            get
            {
                Class267<ExtensionMapping> class2 = base.method_3<Class267<ExtensionMapping>>("m_extensionMappings");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public uint m_frame
        {
            get
            {
                return base.method_2<uint>("m_frame");
            }
        }

        public bool m_musicIsAboutToPlay
        {
            get
            {
                return base.method_2<bool>("m_musicIsAboutToPlay");
            }
        }

        public int m_musicTrackIndex
        {
            get
            {
                return base.method_2<int>("m_musicTrackIndex");
            }
        }

        public List<MusicTrack> m_musicTracks
        {
            get
            {
                Class267<MusicTrack> class2 = base.method_3<Class267<MusicTrack>>("m_musicTracks");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_mute
        {
            get
            {
                return base.method_2<bool>("m_mute");
            }
        }

        public uint m_nextDuckStateTweenId
        {
            get
            {
                return base.method_2<uint>("m_nextDuckStateTweenId");
            }
        }

        public int m_nextSourceId
        {
            get
            {
                return base.method_2<int>("m_nextSourceId");
            }
        }

        [Attribute38("SoundManager.BundleInfo")]
        public class BundleInfo : MonoClass
        {
            public BundleInfo(IntPtr address) : this(address, "BundleInfo")
            {
            }

            public BundleInfo(IntPtr address, string className) : base(address, className)
            {
            }

            public bool CanGarbageCollect()
            {
                return base.method_11<bool>("CanGarbageCollect", Array.Empty<object>());
            }

            public void EnableGarbageCollect(bool enable)
            {
                object[] objArray1 = new object[] { enable };
                base.method_8("EnableGarbageCollect", objArray1);
            }

            public string GetName()
            {
                return base.method_13("GetName", Array.Empty<object>());
            }

            public int GetRefCount()
            {
                return base.method_11<int>("GetRefCount", Array.Empty<object>());
            }

            public bool IsGarbageCollectEnabled()
            {
                return base.method_11<bool>("IsGarbageCollectEnabled", Array.Empty<object>());
            }

            public void SetName(string name)
            {
                object[] objArray1 = new object[] { name };
                base.method_8("SetName", objArray1);
            }

            public bool m_garbageCollect
            {
                get
                {
                    return base.method_2<bool>("m_garbageCollect");
                }
            }

            public string m_name
            {
                get
                {
                    return base.method_4("m_name");
                }
            }
        }

        public enum DuckMode
        {
            IDLE,
            BEGINNING,
            HOLD,
            RESTORING
        }

        [Attribute38("SoundManager.DuckState")]
        public class DuckState : MonoClass
        {
            public DuckState(IntPtr address) : this(address, "DuckState")
            {
            }

            public DuckState(IntPtr address, string className) : base(address, className)
            {
            }

            public SoundDuckedCategoryDef GetDuckedDef()
            {
                return base.method_14<SoundDuckedCategoryDef>("GetDuckedDef", Array.Empty<object>());
            }

            public SoundManager.DuckMode GetMode()
            {
                return base.method_11<SoundManager.DuckMode>("GetMode", Array.Empty<object>());
            }

            public object GetTrigger()
            {
                return base.method_14<object>("GetTrigger", Array.Empty<object>());
            }

            public SoundCategory GetTriggerCategory()
            {
                return base.method_11<SoundCategory>("GetTriggerCategory", Array.Empty<object>());
            }

            public string GetTweenName()
            {
                return base.method_13("GetTweenName", Array.Empty<object>());
            }

            public float GetVolume()
            {
                return base.method_11<float>("GetVolume", Array.Empty<object>());
            }

            public bool IsTrigger(object trigger)
            {
                object[] objArray1 = new object[] { trigger };
                return base.method_11<bool>("IsTrigger", objArray1);
            }

            public bool IsTriggerAlive()
            {
                return base.method_11<bool>("IsTriggerAlive", Array.Empty<object>());
            }

            public void SetDuckedDef(SoundDuckedCategoryDef def)
            {
                object[] objArray1 = new object[] { def };
                base.method_8("SetDuckedDef", objArray1);
            }

            public void SetMode(SoundManager.DuckMode mode)
            {
                object[] objArray1 = new object[] { mode };
                base.method_8("SetMode", objArray1);
            }

            public void SetTrigger(object trigger)
            {
                object[] objArray1 = new object[] { trigger };
                base.method_8("SetTrigger", objArray1);
            }

            public void SetTweenName(string name)
            {
                object[] objArray1 = new object[] { name };
                base.method_8("SetTweenName", objArray1);
            }

            public void SetVolume(float volume)
            {
                object[] objArray1 = new object[] { volume };
                base.method_8("SetVolume", objArray1);
            }

            public SoundDuckedCategoryDef m_duckedDef
            {
                get
                {
                    return base.method_3<SoundDuckedCategoryDef>("m_duckedDef");
                }
            }

            public SoundManager.DuckMode m_mode
            {
                get
                {
                    return base.method_2<SoundManager.DuckMode>("m_mode");
                }
            }

            public object m_trigger
            {
                get
                {
                    return base.method_3<object>("m_trigger");
                }
            }

            public SoundCategory m_triggerCategory
            {
                get
                {
                    return base.method_2<SoundCategory>("m_triggerCategory");
                }
            }

            public string m_tweenName
            {
                get
                {
                    return base.method_4("m_tweenName");
                }
            }

            public float m_volume
            {
                get
                {
                    return base.method_2<float>("m_volume");
                }
            }
        }

        [Attribute38("SoundManager.ExtensionMapping")]
        public class ExtensionMapping : MonoClass
        {
            public ExtensionMapping(IntPtr address) : this(address, "ExtensionMapping")
            {
            }

            public ExtensionMapping(IntPtr address, string className) : base(address, className)
            {
            }

            public SoundManager.SourceExtension Extension
            {
                get
                {
                    return base.method_3<SoundManager.SourceExtension>("Extension");
                }
            }
        }

        [Attribute38("SoundManager.SoundLoadContext")]
        public class SoundLoadContext : MonoClass
        {
            public SoundLoadContext(IntPtr address) : this(address, "SoundLoadContext")
            {
            }

            public SoundLoadContext(IntPtr address, string className) : base(address, className)
            {
            }

            public bool m_haveCallback
            {
                get
                {
                    return base.method_2<bool>("m_haveCallback");
                }
            }

            public GameObject m_parent
            {
                get
                {
                    return base.method_3<GameObject>("m_parent");
                }
            }

            public SceneMgr.Mode m_sceneMode
            {
                get
                {
                    return base.method_2<SceneMgr.Mode>("m_sceneMode");
                }
            }

            public object m_userData
            {
                get
                {
                    return base.method_3<object>("m_userData");
                }
            }

            public float m_volume
            {
                get
                {
                    return base.method_2<float>("m_volume");
                }
            }
        }

        [Attribute38("SoundManager.SourceExtension")]
        public class SourceExtension : MonoClass
        {
            public SourceExtension(IntPtr address) : this(address, "SourceExtension")
            {
            }

            public SourceExtension(IntPtr address, string className) : base(address, className)
            {
            }

            public string m_bundleName
            {
                get
                {
                    return base.method_4("m_bundleName");
                }
            }

            public float m_codePitch
            {
                get
                {
                    return base.method_2<float>("m_codePitch");
                }
            }

            public float m_codeVolume
            {
                get
                {
                    return base.method_2<float>("m_codeVolume");
                }
            }

            public float m_defPitch
            {
                get
                {
                    return base.method_2<float>("m_defPitch");
                }
            }

            public float m_defVolume
            {
                get
                {
                    return base.method_2<float>("m_defVolume");
                }
            }

            public bool m_ducking
            {
                get
                {
                    return base.method_2<bool>("m_ducking");
                }
            }

            public int m_id
            {
                get
                {
                    return base.method_2<int>("m_id");
                }
            }

            public bool m_paused
            {
                get
                {
                    return base.method_2<bool>("m_paused");
                }
            }

            public float m_sourcePitch
            {
                get
                {
                    return base.method_2<float>("m_sourcePitch");
                }
            }

            public float m_sourceVolume
            {
                get
                {
                    return base.method_2<float>("m_sourceVolume");
                }
            }
        }
    }
}

