namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("ScreenEffectsMgr")]
    public class ScreenEffectsMgr : MonoBehaviour
    {
        public ScreenEffectsMgr(IntPtr address) : this(address, "ScreenEffectsMgr")
        {
        }

        public ScreenEffectsMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void CreateBackPlane(Camera camera)
        {
            object[] objArray1 = new object[] { camera };
            base.method_8("CreateBackPlane", objArray1);
        }

        public static ScreenEffectsMgr Get()
        {
            return MonoClass.smethod_15<ScreenEffectsMgr>(TritonHs.MainAssemblyPath, "", "ScreenEffectsMgr", "Get", Array.Empty<object>());
        }

        public int GetActiveScreenEffectsCount()
        {
            return base.method_11<int>("GetActiveScreenEffectsCount", Array.Empty<object>());
        }

        public void Init()
        {
            base.method_8("Init", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnDisable()
        {
            base.method_8("OnDisable", Array.Empty<object>());
        }

        public void OnEnable()
        {
            base.method_8("OnEnable", Array.Empty<object>());
        }

        public static void RegisterScreenEffect(ScreenEffect effect)
        {
            object[] objArray1 = new object[] { effect };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "ScreenEffectsMgr", "RegisterScreenEffect", objArray1);
        }

        public static void UnRegisterScreenEffect(ScreenEffect effect)
        {
            object[] objArray1 = new object[] { effect };
            MonoClass.smethod_18(TritonHs.MainAssemblyPath, "", "ScreenEffectsMgr", "UnRegisterScreenEffect", objArray1);
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdateCameraTransform()
        {
            base.method_8("UpdateCameraTransform", Array.Empty<object>());
        }

        public static List<ScreenEffect> m_ActiveScreenEffects
        {
            get
            {
                Class267<ScreenEffect> class2 = MonoClass.smethod_7<Class267<ScreenEffect>>(TritonHs.MainAssemblyPath, "", "ScreenEffectsMgr", "m_ActiveScreenEffects");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public Camera m_EffectsObjectsCamera
        {
            get
            {
                return base.method_3<Camera>("m_EffectsObjectsCamera");
            }
        }

        public GameObject m_EffectsObjectsCameraGO
        {
            get
            {
                return base.method_3<GameObject>("m_EffectsObjectsCameraGO");
            }
        }

        public Camera m_MainCamera
        {
            get
            {
                return base.method_3<Camera>("m_MainCamera");
            }
        }

        public ScreenEffectsRender m_ScreenEffectsRender
        {
            get
            {
                return base.method_3<ScreenEffectsRender>("m_ScreenEffectsRender");
            }
        }

        public static ScreenEffectsMgr s_Instance
        {
            get
            {
                return MonoClass.smethod_7<ScreenEffectsMgr>(TritonHs.MainAssemblyPath, "", "ScreenEffectsMgr", "s_Instance");
            }
        }

        public enum EFFECT_TYPE
        {
            Glow,
            Distortion
        }
    }
}

