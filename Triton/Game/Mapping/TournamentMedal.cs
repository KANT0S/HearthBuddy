namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("TournamentMedal")]
    public class TournamentMedal : PegUIElement
    {
        public TournamentMedal(IntPtr address) : this(address, "TournamentMedal")
        {
        }

        public TournamentMedal(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public TranslatedMedalInfo GetMedal()
        {
            return base.method_14<TranslatedMedalInfo>("GetMedal", Array.Empty<object>());
        }

        public void MedalOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("MedalOut", objArray1);
        }

        public void MedalOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("MedalOver", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnTextureLoaded(string assetName, object asset, object callbackData)
        {
            object[] objArray1 = new object[] { assetName, asset, callbackData };
            base.method_8("OnTextureLoaded", objArray1);
        }

        public void SetMedal(NetCache.NetCacheMedalInfo medal)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { medal };
            base.method_9("SetMedal", enumArray1, objArray1);
        }

        public void SetMedal(MedalInfoTranslator medal, bool showStars)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { medal, showStars };
            base.method_9("SetMedal", enumArray1, objArray1);
        }

        public void SetMedal(NetCache.NetCacheMedalInfo medal, bool showStars)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { medal, showStars };
            base.method_9("SetMedal", enumArray1, objArray1);
        }

        public void UpdateStars(int numEarned, int numTotal)
        {
            object[] objArray1 = new object[] { numEarned, numTotal };
            base.method_8("UpdateStars", objArray1);
        }

        public GameObject m_banner
        {
            get
            {
                return base.method_3<GameObject>("m_banner");
            }
        }

        public List<Transform> m_evenStarBones
        {
            get
            {
                Class267<Transform> class2 = base.method_3<Class267<Transform>>("m_evenStarBones");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_glowPlane
        {
            get
            {
                return base.method_3<GameObject>("m_glowPlane");
            }
        }

        public UberText m_legendIndex
        {
            get
            {
                return base.method_3<UberText>("m_legendIndex");
            }
        }

        public MedalInfoTranslator m_medal
        {
            get
            {
                return base.method_3<MedalInfoTranslator>("m_medal");
            }
        }

        public List<Transform> m_oddStarBones
        {
            get
            {
                Class267<Transform> class2 = base.method_3<Class267<Transform>>("m_oddStarBones");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_rankMedal
        {
            get
            {
                return base.method_3<GameObject>("m_rankMedal");
            }
        }

        public UberText m_rankNumber
        {
            get
            {
                return base.method_3<UberText>("m_rankNumber");
            }
        }

        public Material m_starFilledMaterial
        {
            get
            {
                return base.method_3<Material>("m_starFilledMaterial");
            }
        }

        public GameObject m_starPrefab
        {
            get
            {
                return base.method_3<GameObject>("m_starPrefab");
            }
        }

        public List<GameObject> m_stars
        {
            get
            {
                Class267<GameObject> class2 = base.method_3<Class267<GameObject>>("m_stars");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }
    }
}

