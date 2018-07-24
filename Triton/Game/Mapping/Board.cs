namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("Board")]
    public class Board : MonoBehaviour
    {
        public Board(IntPtr address) : this(address, "Board")
        {
        }

        public Board(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CombinedSurface()
        {
            base.method_8("CombinedSurface", Array.Empty<object>());
        }

        public void DimTheLights()
        {
            base.method_9("DimTheLights", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void DimTheLights(float speed)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.R4 };
            object[] objArray1 = new object[] { speed };
            base.method_9("DimTheLights", enumArray1, objArray1);
        }

        public Transform FindBone(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_14<Transform>("FindBone", objArray1);
        }

        public Collider FindCollider(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_14<Collider>("FindCollider", objArray1);
        }

        public static Board Get()
        {
            return MonoClass.smethod_15<Board>(TritonHs.MainAssemblyPath, "", "Board", "Get", Array.Empty<object>());
        }

        public Spell GetFriendlyTraySpell()
        {
            return base.method_14<Spell>("GetFriendlyTraySpell", Array.Empty<object>());
        }

        public GameObject GetMouseClickDustEffectPrefab()
        {
            return base.method_14<GameObject>("GetMouseClickDustEffectPrefab", Array.Empty<object>());
        }

        public Spell GetOpponentTraySpell()
        {
            return base.method_14<Spell>("GetOpponentTraySpell", Array.Empty<object>());
        }

        public void LoadBoardSpecialEvent(BoardSpecialEvents boardSpecialEvent)
        {
            object[] objArray1 = new object[] { boardSpecialEvent };
            base.method_8("LoadBoardSpecialEvent", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnHeroPhoneTrayTextureLoaded(string path, object obj, object callbackData)
        {
            object[] objArray1 = new object[] { path, obj, callbackData };
            base.method_8("OnHeroPhoneTrayTextureLoaded", objArray1);
        }

        public void OnHeroSkinManaGemTextureLoaded(string path, object obj, object callbackData)
        {
            object[] objArray1 = new object[] { path, obj, callbackData };
            base.method_8("OnHeroSkinManaGemTextureLoaded", objArray1);
        }

        public void OnHeroTrayEffectLoaded(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("OnHeroTrayEffectLoaded", objArray1);
        }

        public void OnHeroTrayTextureLoaded(string path, object obj, object callbackData)
        {
            object[] objArray1 = new object[] { path, obj, callbackData };
            base.method_8("OnHeroTrayTextureLoaded", objArray1);
        }

        public void RaiseTheLights()
        {
            base.method_9("RaiseTheLights", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void RaiseTheLights(float speed)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.R4 };
            object[] objArray1 = new object[] { speed };
            base.method_9("RaiseTheLights", enumArray1, objArray1);
        }

        public void RaiseTheLightsQuickly()
        {
            base.method_8("RaiseTheLightsQuickly", Array.Empty<object>());
        }

        public void ResetAmbientColor()
        {
            base.method_8("ResetAmbientColor", Array.Empty<object>());
        }

        public void SetBoardDbId(int id)
        {
            object[] objArray1 = new object[] { id };
            base.method_8("SetBoardDbId", objArray1);
        }

        public void SetMulliganLighting()
        {
            base.method_8("SetMulliganLighting", Array.Empty<object>());
        }

        public void ShowFriendlyHeroTray(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("ShowFriendlyHeroTray", objArray1);
        }

        public void ShowOpponentHeroTray(string name, GameObject go, object callbackData)
        {
            object[] objArray1 = new object[] { name, go, callbackData };
            base.method_8("ShowOpponentHeroTray", objArray1);
        }

        public void SplitSurface()
        {
            base.method_8("SplitSurface", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public static string GOLDEN_HERO_TRAY_FRIENDLY
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Board", "GOLDEN_HERO_TRAY_FRIENDLY");
            }
        }

        public static string GOLDEN_HERO_TRAY_OPPONENT
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "Board", "GOLDEN_HERO_TRAY_OPPONENT");
            }
        }

        public Color m_AmbientColor
        {
            get
            {
                return base.method_2<Color>("m_AmbientColor");
            }
        }

        public int m_boardDbId
        {
            get
            {
                return base.method_2<int>("m_boardDbId");
            }
        }

        public MusicPlaylistType m_BoardMusic
        {
            get
            {
                return base.method_2<MusicPlaylistType>("m_BoardMusic");
            }
        }

        public Transform m_BoneParent
        {
            get
            {
                return base.method_3<Transform>("m_BoneParent");
            }
        }

        public Transform m_ColliderParent
        {
            get
            {
                return base.method_3<Transform>("m_ColliderParent");
            }
        }

        public GameObject m_CombinedPlaySurface
        {
            get
            {
                return base.method_3<GameObject>("m_CombinedPlaySurface");
            }
        }

        public Color m_DeckColor
        {
            get
            {
                return base.method_2<Color>("m_DeckColor");
            }
        }

        public float m_DirectionalLightIntensity
        {
            get
            {
                return base.method_2<float>("m_DirectionalLightIntensity");
            }
        }

        public Color m_EndTurnButtonColor
        {
            get
            {
                return base.method_2<Color>("m_EndTurnButtonColor");
            }
        }

        public GameObject m_FriendlyHeroPhoneTray
        {
            get
            {
                return base.method_3<GameObject>("m_FriendlyHeroPhoneTray");
            }
        }

        public GameObject m_FriendlyHeroTray
        {
            get
            {
                return base.method_3<GameObject>("m_FriendlyHeroTray");
            }
        }

        public Spell m_FriendlyTraySpellEffect
        {
            get
            {
                return base.method_3<Spell>("m_FriendlyTraySpellEffect");
            }
        }

        public Texture m_GemManaPhoneTexture
        {
            get
            {
                return base.method_3<Texture>("m_GemManaPhoneTexture");
            }
        }

        public Color m_GoldenHeroTrayColor
        {
            get
            {
                return base.method_2<Color>("m_GoldenHeroTrayColor");
            }
        }

        public Color m_HistoryTileColor
        {
            get
            {
                return base.method_2<Color>("m_HistoryTileColor");
            }
        }

        public GameObject m_MouseClickDustEffect
        {
            get
            {
                return base.method_3<GameObject>("m_MouseClickDustEffect");
            }
        }

        public GameObject m_OpponentHeroPhoneTray
        {
            get
            {
                return base.method_3<GameObject>("m_OpponentHeroPhoneTray");
            }
        }

        public GameObject m_OpponentHeroTray
        {
            get
            {
                return base.method_3<GameObject>("m_OpponentHeroTray");
            }
        }

        public Spell m_OpponentTraySpellEffect
        {
            get
            {
                return base.method_3<Spell>("m_OpponentTraySpellEffect");
            }
        }

        public bool m_raisedLights
        {
            get
            {
                return base.method_2<bool>("m_raisedLights");
            }
        }

        public Color m_ShadowColor
        {
            get
            {
                return base.method_2<Color>("m_ShadowColor");
            }
        }

        public List<BoardSpecialEvents> m_SpecialEvents
        {
            get
            {
                Class267<BoardSpecialEvents> class2 = base.method_3<Class267<BoardSpecialEvents>>("m_SpecialEvents");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public GameObject m_SplitPlaySurface
        {
            get
            {
                return base.method_3<GameObject>("m_SplitPlaySurface");
            }
        }

        public Color m_TrayTint
        {
            get
            {
                return base.method_2<Color>("m_TrayTint");
            }
        }

        public Color MULLIGAN_AMBIENT_LIGHT_COLOR
        {
            get
            {
                return base.method_2<Color>("MULLIGAN_AMBIENT_LIGHT_COLOR");
            }
        }

        public static float MULLIGAN_LIGHT_INTENSITY
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "Board", "MULLIGAN_LIGHT_INTENSITY");
            }
        }

        [Attribute38("Board.BoardSpecialEvents")]
        public class BoardSpecialEvents : MonoClass
        {
            public BoardSpecialEvents(IntPtr address) : this(address, "BoardSpecialEvents")
            {
            }

            public BoardSpecialEvents(IntPtr address, string className) : base(address, className)
            {
            }

            public Color AmbientColorOverride
            {
                get
                {
                    return base.method_2<Color>("AmbientColorOverride");
                }
            }

            public SpecialEventType EventType
            {
                get
                {
                    return base.method_2<SpecialEventType>("EventType");
                }
            }

            public string Prefab
            {
                get
                {
                    return base.method_4("Prefab");
                }
            }
        }

        [Attribute38("Board.CustomTraySettings")]
        public class CustomTraySettings : MonoClass
        {
            public CustomTraySettings(IntPtr address) : this(address, "CustomTraySettings")
            {
            }

            public CustomTraySettings(IntPtr address, string className) : base(address, className)
            {
            }

            public BoardDdId m_Board
            {
                get
                {
                    return base.method_2<BoardDdId>("m_Board");
                }
            }

            public Color m_Tint
            {
                get
                {
                    return base.method_2<Color>("m_Tint");
                }
            }
        }
    }
}

