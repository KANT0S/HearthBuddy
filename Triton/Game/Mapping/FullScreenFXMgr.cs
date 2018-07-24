namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("FullScreenFXMgr")]
    public class FullScreenFXMgr : MonoBehaviour
    {
        public FullScreenFXMgr(IntPtr address) : this(address, "FullScreenFXMgr")
        {
        }

        public FullScreenFXMgr(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void BeginEffect(string name, string onUpdate, string onComplete, float start, float end, float time, iTween.EaseType easeType)
        {
            object[] objArray1 = new object[] { name, onUpdate, onComplete, start, end, time, easeType };
            base.method_8("BeginEffect", objArray1);
        }

        public void DisableBlur()
        {
            base.method_8("DisableBlur", Array.Empty<object>());
        }

        public static FullScreenFXMgr Get()
        {
            return MonoClass.smethod_15<FullScreenFXMgr>(TritonHs.MainAssemblyPath, "", "FullScreenFXMgr", "Get", Array.Empty<object>());
        }

        public FullScreenEffects GetCurrEffects()
        {
            return base.method_14<FullScreenEffects>("GetCurrEffects", Array.Empty<object>());
        }

        public bool isFullScreenEffectActive()
        {
            return base.method_11<bool>("isFullScreenEffectActive", Array.Empty<object>());
        }

        public void OnBlendToColor(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("OnBlendToColor", objArray1);
        }

        public void OnBlendToColorClear()
        {
            base.method_8("OnBlendToColorClear", Array.Empty<object>());
        }

        public void OnBlendToColorComplete()
        {
            base.method_8("OnBlendToColorComplete", Array.Empty<object>());
        }

        public void OnBlur(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("OnBlur", objArray1);
        }

        public void OnBlurClear()
        {
            base.method_8("OnBlurClear", Array.Empty<object>());
        }

        public void OnBlurComplete()
        {
            base.method_8("OnBlurComplete", Array.Empty<object>());
        }

        public void OnDesat(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("OnDesat", objArray1);
        }

        public void OnDesatClear()
        {
            base.method_8("OnDesatClear", Array.Empty<object>());
        }

        public void OnDesatComplete()
        {
            base.method_8("OnDesatComplete", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnVignette(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("OnVignette", objArray1);
        }

        public void OnVignetteClear()
        {
            base.method_8("OnVignetteClear", Array.Empty<object>());
        }

        public void OnVignetteComplete()
        {
            base.method_8("OnVignetteComplete", Array.Empty<object>());
        }

        public void SetBlurAmount(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("SetBlurAmount", objArray1);
        }

        public void SetBlurBrightness(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("SetBlurBrightness", objArray1);
        }

        public void SetBlurDesaturation(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("SetBlurDesaturation", objArray1);
        }

        public void StartStandardBlurVignette(float time)
        {
            object[] objArray1 = new object[] { time };
            base.method_8("StartStandardBlurVignette", objArray1);
        }

        public void StopAllEffects(float delay)
        {
            object[] objArray1 = new object[] { delay };
            base.method_8("StopAllEffects", objArray1);
        }

        public void WillReset()
        {
            base.method_8("WillReset", Array.Empty<object>());
        }

        public int m_ActiveEffectsCount
        {
            get
            {
                return base.method_2<int>("m_ActiveEffectsCount");
            }
        }

        public FullScreenEffects m_FullScreenEffects
        {
            get
            {
                return base.method_3<FullScreenEffects>("m_FullScreenEffects");
            }
        }

        public int m_StdBlurVignetteCount
        {
            get
            {
                return base.method_2<int>("m_StdBlurVignetteCount");
            }
        }
    }
}

