namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AssetLoader")]
    public class AssetLoader : MonoBehaviour
    {
        public AssetLoader(IntPtr address) : this(address, "AssetLoader")
        {
        }

        public AssetLoader(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AssetFromDownloadablePack(Asset asset)
        {
            object[] objArray1 = new object[] { asset };
            return base.method_11<bool>("AssetFromDownloadablePack", objArray1);
        }

        public static int AvailableExtraAssetBundlesCount()
        {
            return MonoClass.smethod_14<int>(TritonHs.MainAssemblyPath, "", "AssetLoader", "AvailableExtraAssetBundlesCount", Array.Empty<object>());
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CacheAsset(Asset asset, object assetObject)
        {
            object[] objArray1 = new object[] { asset, assetObject };
            base.method_8("CacheAsset", objArray1);
        }

        public string CreateLocalFilePath(string relPath)
        {
            object[] objArray1 = new object[] { relPath };
            return base.method_13("CreateLocalFilePath", objArray1);
        }

        public static bool FileIsInFileListInExtraBundles(string fileName)
        {
            object[] objArray1 = new object[] { fileName };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "AssetLoader", "FileIsInFileListInExtraBundles", objArray1);
        }

        public static AssetLoader Get()
        {
            return MonoClass.smethod_15<AssetLoader>(TritonHs.MainAssemblyPath, "", "AssetLoader", "Get", Array.Empty<object>());
        }

        public GameObject GetPlaceholderCardPrefab()
        {
            return base.method_14<GameObject>("GetPlaceholderCardPrefab", Array.Empty<object>());
        }

        public void InitCardDirectories(string root)
        {
            object[] objArray1 = new object[] { root };
            base.method_8("InitCardDirectories", objArray1);
        }

        public static void InitFileListInExtraBundles()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "AssetLoader", "InitFileListInExtraBundles");
        }

        public bool IsReady()
        {
            return base.method_11<bool>("IsReady", Array.Empty<object>());
        }

        public bool IsWaitingOnObject(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            return base.method_11<bool>("IsWaitingOnObject", objArray1);
        }

        public GameObject LoadActor(string name, bool usePrefabPosition, bool persistent)
        {
            object[] objArray1 = new object[] { name, usePrefabPosition, persistent };
            return base.method_15<GameObject>("LoadActor", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public UnityObject LoadAudioClip(string name, bool persistent)
        {
            object[] objArray1 = new object[] { name, persistent };
            return base.method_14<UnityObject>("LoadAudioClip", objArray1);
        }

        public GameObject LoadBoard(string name, bool usePrefabPosition, bool persistent)
        {
            object[] objArray1 = new object[] { name, usePrefabPosition, persistent };
            return base.method_15<GameObject>("LoadBoard", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public GameObject LoadCardBack(string name, bool usePrefabPosition, bool persistent)
        {
            object[] objArray1 = new object[] { name, usePrefabPosition, persistent };
            return base.method_15<GameObject>("LoadCardBack", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public GameObject LoadCardPrefab(string cardName, bool usePrefabPosition, bool persistent)
        {
            object[] objArray1 = new object[] { cardName, usePrefabPosition, persistent };
            return base.method_15<GameObject>("LoadCardPrefab", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public Texture LoadCardTexture(string name, bool persistent)
        {
            object[] objArray1 = new object[] { name, persistent };
            return base.method_14<Texture>("LoadCardTexture", objArray1);
        }

        public GameObject LoadFontDef(string name, bool usePrefabPosition, bool persistent)
        {
            object[] objArray1 = new object[] { name, usePrefabPosition, persistent };
            return base.method_15<GameObject>("LoadFontDef", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public GameObject LoadGameObject(string name, bool usePrefabPosition, bool persistent)
        {
            object[] objArray1 = new object[] { name, usePrefabPosition, persistent };
            return base.method_15<GameObject>("LoadGameObject", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public GameObject LoadGameObjectImmediately(Asset asset, bool usePrefabPosition)
        {
            object[] objArray1 = new object[] { asset, usePrefabPosition };
            return base.method_14<GameObject>("LoadGameObjectImmediately", objArray1);
        }

        public UnityObject LoadObjectImmediately(Asset asset)
        {
            object[] objArray1 = new object[] { asset };
            return base.method_14<UnityObject>("LoadObjectImmediately", objArray1);
        }

        public Material LoadPremiumMaterial(string name, bool persistent)
        {
            object[] objArray1 = new object[] { name, persistent };
            return base.method_14<Material>("LoadPremiumMaterial", objArray1);
        }

        public GameObject LoadSound(string name, bool usePrefabPosition, bool persistent)
        {
            object[] objArray1 = new object[] { name, usePrefabPosition, persistent };
            return base.method_15<GameObject>("LoadSound", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public void LoadSoundCallback(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("LoadSoundCallback", objArray1);
        }

        public GameObject LoadSpell(string name, bool usePrefabPosition, bool persistent)
        {
            object[] objArray1 = new object[] { name, usePrefabPosition, persistent };
            return base.method_15<GameObject>("LoadSpell", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public Texture LoadTexture(string name, bool persistent)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { name, persistent };
            return base.method_15<Texture>("LoadTexture", enumArray1, objArray1);
        }

        public GameObject LoadUIScreen(string name, bool usePrefabPosition, bool persistent)
        {
            object[] objArray1 = new object[] { name, usePrefabPosition, persistent };
            return base.method_15<GameObject>("LoadUIScreen", new Class272.Enum20[] { Class272.Enum20.String }, objArray1);
        }

        public static void LocalizeSoundPrefab(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AssetLoader", "LocalizeSoundPrefab", objArray1);
        }

        public static void LogMissingAsset(AssetFamily family, string assetname)
        {
            object[] objArray1 = new object[] { family, assetname };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AssetLoader", "LogMissingAsset", objArray1);
        }

        public Vector3 NewGameObjectSpawnPosition(object prefab)
        {
            object[] objArray1 = new object[] { prefab };
            return base.method_11<Vector3>("NewGameObjectSpawnPosition", objArray1);
        }

        public void OnApplicationQuit()
        {
            base.method_8("OnApplicationQuit", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void PreloadBundles()
        {
            base.method_8("PreloadBundles", Array.Empty<object>());
        }

        public void ReloadUpdatableBundles()
        {
            base.method_8("ReloadUpdatableBundles", Array.Empty<object>());
        }

        public void SetReady(bool ready)
        {
            object[] objArray1 = new object[] { ready };
            base.method_8("SetReady", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void UnloadUpdatableBundles()
        {
            base.method_8("UnloadUpdatableBundles", Array.Empty<object>());
        }

        public static bool UseFileListInExtraBundles()
        {
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "AssetLoader", "UseFileListInExtraBundles", Array.Empty<object>());
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public static string fileListInExtraBundlesTxtName_
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AssetLoader", "fileListInExtraBundlesTxtName_");
            }
        }

        public GameObject m_placeholderCardPrefab
        {
            get
            {
                return base.method_3<GameObject>("m_placeholderCardPrefab");
            }
        }

        public bool m_ready
        {
            get
            {
                return base.method_2<bool>("m_ready");
            }
        }

        public List<GameObject> m_waitingOnObjects
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_waitingOnObjects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public string m_workingDir
        {
            get
            {
                return base.method_4("m_workingDir");
            }
        }

        public static List<string> s_cardSetDirectories
        {
            get
            {
                Class245 class2 = MonoClass.smethod_7<Class245>(TritonHs.MainAssemblyPath, "", "AssetLoader", "s_cardSetDirectories");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public static string s_fileInfoCachePath
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AssetLoader", "s_fileInfoCachePath");
            }
        }

        public static float s_timeSpentBruteForcing
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "AssetLoader", "s_timeSpentBruteForcing");
            }
        }

        public Vector3 SPAWN_POS_CAMERA_OFFSET
        {
            get
            {
                return base.method_2<Vector3>("SPAWN_POS_CAMERA_OFFSET");
            }
        }

        [Attribute38("AssetLoader.LoadSoundCallbackData")]
        public class LoadSoundCallbackData : MonoClass
        {
            public LoadSoundCallbackData(IntPtr address) : this(address, "LoadSoundCallbackData")
            {
            }

            public LoadSoundCallbackData(IntPtr address, string className) : base(address, className)
            {
            }

            public object callbackData
            {
                get
                {
                    return base.method_3<object>("callbackData");
                }
            }
        }
    }
}

