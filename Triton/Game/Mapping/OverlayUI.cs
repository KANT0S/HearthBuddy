namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("OverlayUI")]
    public class OverlayUI : MonoBehaviour
    {
        public OverlayUI(IntPtr address) : this(address, "OverlayUI")
        {
        }

        public OverlayUI(IntPtr address, string className) : base(address, className)
        {
        }

        public void AddGameObject(GameObject go, CanvasAnchor anchor, bool destroyOnSceneLoad, CanvasScaleMode scaleMode)
        {
            object[] objArray1 = new object[] { go, anchor, destroyOnSceneLoad, scaleMode };
            base.method_8("AddGameObject", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DestroyOnSceneLoad(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            base.method_8("DestroyOnSceneLoad", objArray1);
        }

        public void DontDestroyOnSceneLoad(GameObject go)
        {
            object[] objArray1 = new object[] { go };
            base.method_8("DontDestroyOnSceneLoad", objArray1);
        }

        public static OverlayUI Get()
        {
            return MonoClass.smethod_15<OverlayUI>(TritonHs.MainAssemblyPath, "", "OverlayUI", "Get", Array.Empty<object>());
        }

        public Vector3 GetRelativePosition(Vector3 worldPosition, Camera camera, Transform bone, float depth)
        {
            object[] objArray1 = new object[] { worldPosition, camera, bone, depth };
            return base.method_11<Vector3>("GetRelativePosition", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnSceneChange(SceneMgr.Mode mode, Scene scene, object userData)
        {
            object[] objArray1 = new object[] { mode, scene, userData };
            base.method_8("OnSceneChange", objArray1);
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public CanvasAnchors m_heightScale
        {
            get
            {
                return base.method_3<CanvasAnchors>("m_heightScale");
            }
        }

        public Camera m_PerspectiveUICamera
        {
            get
            {
                return base.method_3<Camera>("m_PerspectiveUICamera");
            }
        }

        public Camera m_UICamera
        {
            get
            {
                return base.method_3<Camera>("m_UICamera");
            }
        }

        public CanvasAnchors m_widthScale
        {
            get
            {
                return base.method_3<CanvasAnchors>("m_widthScale");
            }
        }
    }
}

