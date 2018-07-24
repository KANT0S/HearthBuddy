namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("PageTurn")]
    public class PageTurn : MonoBehaviour
    {
        public PageTurn(IntPtr address) : this(address, "PageTurn")
        {
        }

        public PageTurn(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CreateCamera()
        {
            base.method_8("CreateCamera", Array.Empty<object>());
        }

        public void CreateRenderTexture()
        {
            base.method_8("CreateRenderTexture", Array.Empty<object>());
        }

        public static Vector3 GetWorldScale(Transform transform)
        {
            object[] objArray1 = new object[] { transform };
            return MonoClass.smethod_14<Vector3>(TritonHs.MainAssemblyPath, "", "PageTurn", "GetWorldScale", objArray1);
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public void Render(GameObject page)
        {
            object[] objArray1 = new object[] { page };
            base.method_8("Render", objArray1);
        }

        public void SetupCamera(Camera camera)
        {
            object[] objArray1 = new object[] { camera };
            base.method_8("SetupCamera", objArray1);
        }

        public void SetupMaterial()
        {
            base.method_8("SetupMaterial", Array.Empty<object>());
        }

        public void Show(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("Show", objArray1);
        }

        public void TurnLeft(GameObject flippingPage, GameObject otherPage)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { flippingPage, otherPage };
            base.method_9("TurnLeft", enumArray1, objArray1);
        }

        public void TurnRight(GameObject flippingPage, GameObject otherPage)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class, Class272.Enum20.Class };
            object[] objArray1 = new object[] { flippingPage, otherPage };
            base.method_9("TurnRight", enumArray1, objArray1);
        }

        public string BACK_PAGE_NAME
        {
            get
            {
                return base.method_4("BACK_PAGE_NAME");
            }
        }

        public string FRONT_PAGE_NAME
        {
            get
            {
                return base.method_4("FRONT_PAGE_NAME");
            }
        }

        public GameObject m_BackPageGameObject
        {
            get
            {
                return base.method_3<GameObject>("m_BackPageGameObject");
            }
        }

        public GameObject m_FrontPageGameObject
        {
            get
            {
                return base.method_3<GameObject>("m_FrontPageGameObject");
            }
        }

        public Vector3 m_initialPosition
        {
            get
            {
                return base.method_2<Vector3>("m_initialPosition");
            }
        }

        public GameObject m_MeshGameObject
        {
            get
            {
                return base.method_3<GameObject>("m_MeshGameObject");
            }
        }

        public Camera m_OffscreenPageTurnCamera
        {
            get
            {
                return base.method_3<Camera>("m_OffscreenPageTurnCamera");
            }
        }

        public GameObject m_OffscreenPageTurnCameraGO
        {
            get
            {
                return base.method_3<GameObject>("m_OffscreenPageTurnCameraGO");
            }
        }

        public Camera m_OffscreenPageTurnMaskCamera
        {
            get
            {
                return base.method_3<Camera>("m_OffscreenPageTurnMaskCamera");
            }
        }

        public Bounds m_RenderBounds
        {
            get
            {
                return base.method_2<Bounds>("m_RenderBounds");
            }
        }

        public float m_RenderOffset
        {
            get
            {
                return base.method_2<float>("m_RenderOffset");
            }
        }

        public GameObject m_TheBoxOuterFrame
        {
            get
            {
                return base.method_3<GameObject>("m_TheBoxOuterFrame");
            }
        }

        public float m_TurnLeftSpeed
        {
            get
            {
                return base.method_2<float>("m_TurnLeftSpeed");
            }
        }

        public float m_TurnRightSpeed
        {
            get
            {
                return base.method_2<float>("m_TurnRightSpeed");
            }
        }

        public string PAGE_TURN_LEFT_ANIM
        {
            get
            {
                return base.method_4("PAGE_TURN_LEFT_ANIM");
            }
        }

        public string PAGE_TURN_MAT_ANIM
        {
            get
            {
                return base.method_4("PAGE_TURN_MAT_ANIM");
            }
        }

        public string PAGE_TURN_RIGHT_ANIM
        {
            get
            {
                return base.method_4("PAGE_TURN_RIGHT_ANIM");
            }
        }

        public string WAIT_THEN_COMPLETE_PAGE_TURN_COROUTINE
        {
            get
            {
                return base.method_4("WAIT_THEN_COMPLETE_PAGE_TURN_COROUTINE");
            }
        }

        [Attribute38("PageTurn.PageTurningData")]
        public class PageTurningData : MonoClass
        {
            public PageTurningData(IntPtr address) : this(address, "PageTurningData")
            {
            }

            public PageTurningData(IntPtr address, string className) : base(address, className)
            {
            }

            public object m_callbackData
            {
                get
                {
                    return base.method_3<object>("m_callbackData");
                }
            }

            public float m_secondsToWait
            {
                get
                {
                    return base.method_2<float>("m_secondsToWait");
                }
            }
        }

        [Attribute38("PageTurn.TurnPageData")]
        public class TurnPageData : MonoClass
        {
            public TurnPageData(IntPtr address) : this(address, "TurnPageData")
            {
            }

            public TurnPageData(IntPtr address, string className) : base(address, className)
            {
            }

            public object callbackData
            {
                get
                {
                    return base.method_3<object>("callbackData");
                }
            }

            public GameObject flippingPage
            {
                get
                {
                    return base.method_3<GameObject>("flippingPage");
                }
            }

            public GameObject otherPage
            {
                get
                {
                    return base.method_3<GameObject>("otherPage");
                }
            }
        }
    }
}

