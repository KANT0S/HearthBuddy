namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("HeroCoin")]
    public class HeroCoin : PegUIElement
    {
        public HeroCoin(IntPtr address) : this(address, "HeroCoin")
        {
        }

        public HeroCoin(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void EnableInput()
        {
            base.method_8("EnableInput", Array.Empty<object>());
        }

        public void FinishIntroScaling()
        {
            base.method_8("FinishIntroScaling", Array.Empty<object>());
        }

        public string GetLessonAssetName()
        {
            return base.method_13("GetLessonAssetName", Array.Empty<object>());
        }

        public int GetMissionId()
        {
            return base.method_11<int>("GetMissionId", Array.Empty<object>());
        }

        public void HideTooltip()
        {
            base.method_8("HideTooltip", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnGameLoaded(SceneMgr.Mode mode, Scene scene, object userData)
        {
            object[] objArray1 = new object[] { mode, scene, userData };
            base.method_8("OnGameLoaded", objArray1);
        }

        public void OnOut(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnOut", objArray1);
        }

        public void OnOver(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnOver", objArray1);
        }

        public void OnPress(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnPress", objArray1);
        }

        public void OnUpdateAlphaVal(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("OnUpdateAlphaVal", objArray1);
        }

        public void SetCoinInfo(Vector2 goldTexture, Vector2 grayTexture, Vector2 crackTexture, int missionID)
        {
            object[] objArray1 = new object[] { goldTexture, grayTexture, crackTexture, missionID };
            base.method_8("SetCoinInfo", objArray1);
        }

        public void SetLessonAssetName(string lessonAssetName)
        {
            object[] objArray1 = new object[] { lessonAssetName };
            base.method_8("SetLessonAssetName", objArray1);
        }

        public void SetProgress(CoinStatus status)
        {
            object[] objArray1 = new object[] { status };
            base.method_8("SetProgress", objArray1);
        }

        public void ShowTooltip()
        {
            base.method_8("ShowTooltip", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void StartNextTutorial()
        {
            base.method_8("StartNextTutorial", Array.Empty<object>());
        }

        public GameObject m_coin
        {
            get
            {
                return base.method_3<GameObject>("m_coin");
            }
        }

        public UberText m_coinLabel
        {
            get
            {
                return base.method_3<UberText>("m_coinLabel");
            }
        }

        public GameObject m_coinX
        {
            get
            {
                return base.method_3<GameObject>("m_coinX");
            }
        }

        public GameObject m_cracks
        {
            get
            {
                return base.method_3<GameObject>("m_cracks");
            }
        }

        public Vector2 m_crackTexture
        {
            get
            {
                return base.method_2<Vector2>("m_crackTexture");
            }
        }

        public CoinStatus m_currentStatus
        {
            get
            {
                return base.method_2<CoinStatus>("m_currentStatus");
            }
        }

        public GameObject m_explosionPrefab
        {
            get
            {
                return base.method_3<GameObject>("m_explosionPrefab");
            }
        }

        public Vector2 m_goldTexture
        {
            get
            {
                return base.method_2<Vector2>("m_goldTexture");
            }
        }

        public Material m_grayMaterial
        {
            get
            {
                return base.method_3<Material>("m_grayMaterial");
            }
        }

        public Vector2 m_grayTexture
        {
            get
            {
                return base.method_2<Vector2>("m_grayTexture");
            }
        }

        public HighlightState m_highlight
        {
            get
            {
                return base.method_3<HighlightState>("m_highlight");
            }
        }

        public bool m_inputEnabled
        {
            get
            {
                return base.method_2<bool>("m_inputEnabled");
            }
        }

        public GameObject m_leftCap
        {
            get
            {
                return base.method_3<GameObject>("m_leftCap");
            }
        }

        public string m_lessonAssetName
        {
            get
            {
                return base.method_4("m_lessonAssetName");
            }
        }

        public Vector2 m_lessonCoords
        {
            get
            {
                return base.method_2<Vector2>("m_lessonCoords");
            }
        }

        public Material m_material
        {
            get
            {
                return base.method_3<Material>("m_material");
            }
        }

        public GameObject m_middle
        {
            get
            {
                return base.method_3<GameObject>("m_middle");
            }
        }

        public int m_missionID
        {
            get
            {
                return base.method_2<int>("m_missionID");
            }
        }

        public bool m_nextTutorialStarted
        {
            get
            {
                return base.method_2<bool>("m_nextTutorialStarted");
            }
        }

        public float m_originalMiddleWidth
        {
            get
            {
                return base.method_2<float>("m_originalMiddleWidth");
            }
        }

        public Vector3 m_originalPosition
        {
            get
            {
                return base.method_2<Vector3>("m_originalPosition");
            }
        }

        public Vector3 m_originalXPosition
        {
            get
            {
                return base.method_2<Vector3>("m_originalXPosition");
            }
        }

        public GameObject m_rightCap
        {
            get
            {
                return base.method_3<GameObject>("m_rightCap");
            }
        }

        public GameObject m_tooltip
        {
            get
            {
                return base.method_3<GameObject>("m_tooltip");
            }
        }

        public UberText m_tooltipText
        {
            get
            {
                return base.method_3<UberText>("m_tooltipText");
            }
        }

        public enum CoinStatus
        {
            ACTIVE,
            DEFEATED,
            UNREVEALED,
            UNREVEALED_TO_ACTIVE,
            ACTIVE_TO_DEFEATED
        }
    }
}

