namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AssetCache")]
    public class AssetCache : MonoClass
    {
        public AssetCache(IntPtr address) : this(address, "AssetCache")
        {
        }

        public AssetCache(IntPtr address, string className) : base(address, className)
        {
        }

        public static void Add(Asset asset, CachedAsset item)
        {
            object[] objArray1 = new object[] { asset, item };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AssetCache", "Add", objArray1);
        }

        public void AddItem(string name, CachedAsset item)
        {
            object[] objArray1 = new object[] { name, item };
            base.method_8("AddItem", objArray1);
        }

        public void AddRequest(string key, CacheRequest request)
        {
            object[] objArray1 = new object[] { key, request };
            base.method_8("AddRequest", objArray1);
        }

        public static void AddRequest(Asset asset, CacheRequest request)
        {
            object[] objArray1 = new object[] { asset, request };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AssetCache", "AddRequest", objArray1);
        }

        public void Clear(bool clearPersistent, bool clearLoading)
        {
            object[] objArray1 = new object[] { clearPersistent, clearLoading };
            base.method_8("Clear", objArray1);
        }

        public static void ClearActor(string name)
        {
            object[] objArray1 = new object[] { name };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AssetCache", "ClearActor", objArray1);
        }

        public static void ClearAllCaches(bool clearPersistent, bool clearLoading)
        {
            object[] objArray1 = new object[] { clearPersistent, clearLoading };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AssetCache", "ClearAllCaches", objArray1);
        }

        public static void ClearAllCachesBetween(long startTimestamp, long endTimestamp)
        {
            object[] objArray1 = new object[] { startTimestamp, endTimestamp };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AssetCache", "ClearAllCachesBetween", objArray1);
        }

        public static void ClearAllCachesFailedRequests()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "AssetCache", "ClearAllCachesFailedRequests");
        }

        public static void ClearAllCachesSince(long sinceTimestamp)
        {
            object[] objArray1 = new object[] { sinceTimestamp };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AssetCache", "ClearAllCachesSince", objArray1);
        }

        public void ClearAllFailedRequests()
        {
            base.method_8("ClearAllFailedRequests", Array.Empty<object>());
        }

        public static void ClearCardPrefab(string name)
        {
            object[] objArray1 = new object[] { name };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AssetCache", "ClearCardPrefab", objArray1);
        }

        public static void ClearGameObject(string name)
        {
            object[] objArray1 = new object[] { name };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AssetCache", "ClearGameObject", objArray1);
        }

        public bool ClearItem(string key)
        {
            object[] objArray1 = new object[] { key };
            return base.method_11<bool>("ClearItem", objArray1);
        }

        public static bool ClearItem(Asset asset)
        {
            object[] objArray1 = new object[] { asset };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "AssetCache", "ClearItem", objArray1);
        }

        public void ClearItemsBetween(long startTimestamp, long endTimestamp)
        {
            object[] objArray1 = new object[] { startTimestamp, endTimestamp };
            base.method_8("ClearItemsBetween", objArray1);
        }

        public static void ClearSound(string name)
        {
            object[] objArray1 = new object[] { name };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AssetCache", "ClearSound", objArray1);
        }

        public static void ClearTexture(string name)
        {
            object[] objArray1 = new object[] { name };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AssetCache", "ClearTexture", objArray1);
        }

        public static CachedAsset Find(Asset asset)
        {
            object[] objArray1 = new object[] { asset };
            return MonoClass.smethod_15<CachedAsset>(TritonHs.MainAssemblyPath, "", "AssetCache", "Find", objArray1);
        }

        public void ForceClear()
        {
            base.method_8("ForceClear", Array.Empty<object>());
        }

        public static void ForceClearAllCaches()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "AssetCache", "ForceClearAllCaches");
        }

        public static long GetCacheClearTime()
        {
            return MonoClass.smethod_14<long>(TritonHs.MainAssemblyPath, "", "AssetCache", "GetCacheClearTime", Array.Empty<object>());
        }

        public CachedAsset GetItem(string key)
        {
            object[] objArray1 = new object[] { key };
            return base.method_14<CachedAsset>("GetItem", objArray1);
        }

        public bool HasItem(string key)
        {
            object[] objArray1 = new object[] { key };
            return base.method_11<bool>("HasItem", objArray1);
        }

        public static bool HasItem(Asset asset)
        {
            object[] objArray1 = new object[] { asset };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "AssetCache", "HasItem", objArray1);
        }

        public bool HasRequest(string key)
        {
            object[] objArray1 = new object[] { key };
            return base.method_11<bool>("HasRequest", objArray1);
        }

        public static bool HasRequest(Asset asset)
        {
            object[] objArray1 = new object[] { asset };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "AssetCache", "HasRequest", objArray1);
        }

        public static void Initialize()
        {
            MonoClass.smethod_17(TritonHs.MainAssemblyPath, "", "AssetCache", "Initialize");
        }

        public static bool IsLoading(string name)
        {
            object[] objArray1 = new object[] { name };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "AssetCache", "IsLoading", objArray1);
        }

        public bool RemoveRequest(string key)
        {
            object[] objArray1 = new object[] { key };
            return base.method_11<bool>("RemoveRequest", objArray1);
        }

        public static bool RemoveRequest(Asset asset)
        {
            object[] objArray1 = new object[] { asset };
            return MonoClass.smethod_14<bool>(TritonHs.MainAssemblyPath, "", "AssetCache", "RemoveRequest", objArray1);
        }

        public static void StartLoading(string name)
        {
            object[] objArray1 = new object[] { name };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AssetCache", "StartLoading", objArray1);
        }

        public static void StopLoading(string name)
        {
            object[] objArray1 = new object[] { name };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "AssetCache", "StopLoading", objArray1);
        }

        public static long s_cacheClearTime
        {
            get
            {
                return MonoClass.smethod_6<long>(TritonHs.MainAssemblyPath, "", "AssetCache", "s_cacheClearTime");
            }
        }

        [Attribute38("AssetCache.CachedAsset")]
        public class CachedAsset : MonoClass
        {
            public CachedAsset(IntPtr address) : this(address, "CachedAsset")
            {
            }

            public CachedAsset(IntPtr address, string className) : base(address, className)
            {
            }

            public Asset GetAsset()
            {
                return base.method_14<Asset>("GetAsset", Array.Empty<object>());
            }

            public UnityObject GetAssetObject()
            {
                return base.method_14<UnityObject>("GetAssetObject", Array.Empty<object>());
            }

            public long GetCreatedTimestamp()
            {
                return base.method_11<long>("GetCreatedTimestamp", Array.Empty<object>());
            }

            public long GetLastRequestTimestamp()
            {
                return base.method_11<long>("GetLastRequestTimestamp", Array.Empty<object>());
            }

            public bool IsPersistent()
            {
                return base.method_11<bool>("IsPersistent", Array.Empty<object>());
            }

            public void SetAsset(Asset asset)
            {
                object[] objArray1 = new object[] { asset };
                base.method_8("SetAsset", objArray1);
            }

            public void SetAssetObject(object asset)
            {
                object[] objArray1 = new object[] { asset };
                base.method_8("SetAssetObject", objArray1);
            }

            public void SetCreatedTimestamp(long timestamp)
            {
                object[] objArray1 = new object[] { timestamp };
                base.method_8("SetCreatedTimestamp", objArray1);
            }

            public void SetLastRequestTimestamp(long timestamp)
            {
                object[] objArray1 = new object[] { timestamp };
                base.method_8("SetLastRequestTimestamp", objArray1);
            }

            public void SetPersistent(bool persistent)
            {
                object[] objArray1 = new object[] { persistent };
                base.method_8("SetPersistent", objArray1);
            }

            public void UnloadAssetObject()
            {
                base.method_8("UnloadAssetObject", Array.Empty<object>());
            }

            public Asset m_asset
            {
                get
                {
                    return base.method_3<Asset>("m_asset");
                }
            }

            public object m_assetObject
            {
                get
                {
                    return base.method_3<object>("m_assetObject");
                }
            }

            public long m_createdTimestamp
            {
                get
                {
                    return base.method_2<long>("m_createdTimestamp");
                }
            }

            public long m_lastRequestTimestamp
            {
                get
                {
                    return base.method_2<long>("m_lastRequestTimestamp");
                }
            }

            public bool m_persistent
            {
                get
                {
                    return base.method_2<bool>("m_persistent");
                }
            }
        }

        [Attribute38("AssetCache.CacheRequest")]
        public class CacheRequest : MonoClass
        {
            public CacheRequest(IntPtr address) : this(address, "CacheRequest")
            {
            }

            public CacheRequest(IntPtr address, string className) : base(address, className)
            {
            }

            public bool DidFail()
            {
                return base.method_11<bool>("DidFail", Array.Empty<object>());
            }

            public bool DidSucceed()
            {
                return base.method_11<bool>("DidSucceed", Array.Empty<object>());
            }

            public long GetCreatedTimestamp()
            {
                return base.method_11<long>("GetCreatedTimestamp", Array.Empty<object>());
            }

            public long GetLastRequestTimestamp()
            {
                return base.method_11<long>("GetLastRequestTimestamp", Array.Empty<object>());
            }

            public int GetRequestCount()
            {
                return base.method_11<int>("GetRequestCount", Array.Empty<object>());
            }

            public bool IsComplete()
            {
                return base.method_11<bool>("IsComplete", Array.Empty<object>());
            }

            public bool IsPersistent()
            {
                return base.method_11<bool>("IsPersistent", Array.Empty<object>());
            }

            public bool IsSuccess()
            {
                return base.method_11<bool>("IsSuccess", Array.Empty<object>());
            }

            public void OnLoadFailed(string name)
            {
                object[] objArray1 = new object[] { name };
                base.method_8("OnLoadFailed", objArray1);
            }

            public void OnLoadSucceeded()
            {
                base.method_8("OnLoadSucceeded", Array.Empty<object>());
            }

            public void SetComplete(bool complete)
            {
                object[] objArray1 = new object[] { complete };
                base.method_8("SetComplete", objArray1);
            }

            public void SetCreatedTimestamp(long timestamp)
            {
                object[] objArray1 = new object[] { timestamp };
                base.method_8("SetCreatedTimestamp", objArray1);
            }

            public void SetLastRequestTimestamp(long timestamp)
            {
                object[] objArray1 = new object[] { timestamp };
                base.method_8("SetLastRequestTimestamp", objArray1);
            }

            public void SetPersistent(bool persistent)
            {
                object[] objArray1 = new object[] { persistent };
                base.method_8("SetPersistent", objArray1);
            }

            public void SetSuccess(bool success)
            {
                object[] objArray1 = new object[] { success };
                base.method_8("SetSuccess", objArray1);
            }

            public bool m_complete
            {
                get
                {
                    return base.method_2<bool>("m_complete");
                }
            }

            public long m_createdTimestamp
            {
                get
                {
                    return base.method_2<long>("m_createdTimestamp");
                }
            }

            public long m_lastRequestTimestamp
            {
                get
                {
                    return base.method_2<long>("m_lastRequestTimestamp");
                }
            }

            public bool m_persistent
            {
                get
                {
                    return base.method_2<bool>("m_persistent");
                }
            }

            public bool m_success
            {
                get
                {
                    return base.method_2<bool>("m_success");
                }
            }
        }

        [Attribute38("AssetCache.GameObjectRequester")]
        public class GameObjectRequester : MonoClass
        {
            public GameObjectRequester(IntPtr address) : this(address, "GameObjectRequester")
            {
            }

            public GameObjectRequester(IntPtr address, string className) : base(address, className)
            {
            }

            public object m_callbackData
            {
                get
                {
                    return base.method_3<object>("m_callbackData");
                }
            }
        }

        [Attribute38("AssetCache.ObjectCacheRequest")]
        public class ObjectCacheRequest : AssetCache.CacheRequest
        {
            public ObjectCacheRequest(IntPtr address) : this(address, "ObjectCacheRequest")
            {
            }

            public ObjectCacheRequest(IntPtr address, string className) : base(address, className)
            {
            }

            public int GetRequestCount()
            {
                return base.method_11<int>("GetRequestCount", Array.Empty<object>());
            }

            public List<AssetCache.ObjectRequester> GetRequesters()
            {
                Class267<AssetCache.ObjectRequester> class2 = base.method_14<Class267<AssetCache.ObjectRequester>>("GetRequesters", Array.Empty<object>());
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }

            public void OnLoadComplete(string name, object asset)
            {
                object[] objArray1 = new object[] { name, asset };
                base.method_8("OnLoadComplete", objArray1);
            }

            public void OnLoadFailed(string name)
            {
                object[] objArray1 = new object[] { name };
                base.method_8("OnLoadFailed", objArray1);
            }

            public List<AssetCache.ObjectRequester> m_requesters
            {
                get
                {
                    Class267<AssetCache.ObjectRequester> class2 = base.method_3<Class267<AssetCache.ObjectRequester>>("m_requesters");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }
        }

        [Attribute38("AssetCache.ObjectRequester")]
        public class ObjectRequester : MonoClass
        {
            public ObjectRequester(IntPtr address) : this(address, "ObjectRequester")
            {
            }

            public ObjectRequester(IntPtr address, string className) : base(address, className)
            {
            }

            public object m_callbackData
            {
                get
                {
                    return base.method_3<object>("m_callbackData");
                }
            }
        }

        [Attribute38("AssetCache.PrefabCacheRequest")]
        public class PrefabCacheRequest : AssetCache.CacheRequest
        {
            public PrefabCacheRequest(IntPtr address) : this(address, "PrefabCacheRequest")
            {
            }

            public PrefabCacheRequest(IntPtr address, string className) : base(address, className)
            {
            }

            public int GetRequestCount()
            {
                return base.method_11<int>("GetRequestCount", Array.Empty<object>());
            }

            public List<AssetCache.GameObjectRequester> GetRequesters()
            {
                Class267<AssetCache.GameObjectRequester> class2 = base.method_14<Class267<AssetCache.GameObjectRequester>>("GetRequesters", Array.Empty<object>());
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }

            public void OnLoadFailed(string name)
            {
                object[] objArray1 = new object[] { name };
                base.method_8("OnLoadFailed", objArray1);
            }

            public List<AssetCache.GameObjectRequester> m_requesters
            {
                get
                {
                    Class267<AssetCache.GameObjectRequester> class2 = base.method_3<Class267<AssetCache.GameObjectRequester>>("m_requesters");
                    if (class2 != null)
                    {
                        return class2.method_25();
                    }
                    return null;
                }
            }
        }
    }
}

