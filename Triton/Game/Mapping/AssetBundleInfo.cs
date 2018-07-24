namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AssetBundleInfo")]
    public class AssetBundleInfo : MonoClass
    {
        public AssetBundleInfo(IntPtr address) : this(address, "AssetBundleInfo")
        {
        }

        public AssetBundleInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public static string BundlePathPlatformModifier()
        {
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "AssetBundleInfo", "BundlePathPlatformModifier", Array.Empty<object>());
        }

        public static int NUM_ACTOR_BUNDLES
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AssetBundleInfo", "NUM_ACTOR_BUNDLES");
            }
        }

        public static int NUM_BUNDLES_DEFAULT
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AssetBundleInfo", "NUM_BUNDLES_DEFAULT");
            }
        }

        public static int NUM_CARD_BUNDLES
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AssetBundleInfo", "NUM_CARD_BUNDLES");
            }
        }

        public static int NUM_CARDBACKS_BUNDLES
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AssetBundleInfo", "NUM_CARDBACKS_BUNDLES");
            }
        }

        public static int NUM_CARDTEXTURES_BUNDLES
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AssetBundleInfo", "NUM_CARDTEXTURES_BUNDLES");
            }
        }

        public static int NUM_DOWNLOADABLE_SOUND_LOCALE_BUNDLES
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AssetBundleInfo", "NUM_DOWNLOADABLE_SOUND_LOCALE_BUNDLES");
            }
        }

        public static int NUM_DOWNLOADABLE_SPELL_LOCALE_BUNDLES
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AssetBundleInfo", "NUM_DOWNLOADABLE_SPELL_LOCALE_BUNDLES");
            }
        }

        public static int NUM_GAMEOBJECTS_BUNDLES
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AssetBundleInfo", "NUM_GAMEOBJECTS_BUNDLES");
            }
        }

        public static int NUM_MOVIE_BUNDLES
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AssetBundleInfo", "NUM_MOVIE_BUNDLES");
            }
        }

        public static int NUM_PREMIUMMATERIALS_BUNDLES
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AssetBundleInfo", "NUM_PREMIUMMATERIALS_BUNDLES");
            }
        }

        public static int NUM_SOUND_BUNDLES
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AssetBundleInfo", "NUM_SOUND_BUNDLES");
            }
        }

        public static int NUM_SOUNDPREFAB_BUNDLES
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AssetBundleInfo", "NUM_SOUNDPREFAB_BUNDLES");
            }
        }

        public static int NUM_SPELL_BUNDLES
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AssetBundleInfo", "NUM_SPELL_BUNDLES");
            }
        }

        public static int NumSharedDependencyBundles
        {
            get
            {
                return MonoClass.smethod_6<int>(TritonHs.MainAssemblyPath, "", "AssetBundleInfo", "NumSharedDependencyBundles");
            }
        }

        public static string SharedBundleName
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AssetBundleInfo", "SharedBundleName");
            }
        }

        public static bool UseSharedDependencyBundle
        {
            get
            {
                return MonoClass.smethod_6<bool>(TritonHs.MainAssemblyPath, "", "AssetBundleInfo", "UseSharedDependencyBundle");
            }
        }
    }
}

