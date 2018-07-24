namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("ProgressBar")]
    public class ProgressBar : MonoBehaviour
    {
        public ProgressBar(IntPtr address) : this(address, "ProgressBar")
        {
        }

        public ProgressBar(IntPtr address, string className) : base(address, className)
        {
        }

        public void AnimateProgress(float prevVal, float currVal)
        {
            object[] objArray1 = new object[] { prevVal, currVal };
            base.method_8("AnimateProgress", objArray1);
        }

        public void AudioPitch_OnUpdate(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("AudioPitch_OnUpdate", objArray1);
        }

        public void AudioVolume_OnComplete()
        {
            base.method_8("AudioVolume_OnComplete", Array.Empty<object>());
        }

        public void AudioVolume_OnUpdate(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("AudioVolume_OnUpdate", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DecreaseProgress(float currProgress, float prevProgress)
        {
            object[] objArray1 = new object[] { currProgress, prevProgress };
            base.method_8("DecreaseProgress", objArray1);
        }

        public float GetAnimationTime()
        {
            return base.method_11<float>("GetAnimationTime", Array.Empty<object>());
        }

        public void IncreaseProgress(float currProgress, float prevProgress)
        {
            object[] objArray1 = new object[] { currProgress, prevProgress };
            base.method_8("IncreaseProgress", objArray1);
        }

        public void Intensity_OnComplete()
        {
            base.method_8("Intensity_OnComplete", Array.Empty<object>());
        }

        public void Intensity_OnUpdate(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("Intensity_OnUpdate", objArray1);
        }

        public void Progress_OnUpdate(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("Progress_OnUpdate", objArray1);
        }

        public void ScrollSpeed_OnUpdate(float val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("ScrollSpeed_OnUpdate", objArray1);
        }

        public void SetBarTexture(Texture texture)
        {
            object[] objArray1 = new object[] { texture };
            base.method_8("SetBarTexture", objArray1);
        }

        public void SetLabel(string text)
        {
            object[] objArray1 = new object[] { text };
            base.method_8("SetLabel", objArray1);
        }

        public void SetProgressBar(float progress)
        {
            object[] objArray1 = new object[] { progress };
            base.method_8("SetProgressBar", objArray1);
        }

        public float m_animationTime
        {
            get
            {
                return base.method_2<float>("m_animationTime");
            }
        }

        public float m_audioFadeInOut
        {
            get
            {
                return base.method_2<float>("m_audioFadeInOut");
            }
        }

        public float m_barIntensity
        {
            get
            {
                return base.method_2<float>("m_barIntensity");
            }
        }

        public float m_barIntensityIncreaseMax
        {
            get
            {
                return base.method_2<float>("m_barIntensityIncreaseMax");
            }
        }

        public Material m_barMaterial
        {
            get
            {
                return base.method_3<Material>("m_barMaterial");
            }
        }

        public float m_coolDownAnimTime
        {
            get
            {
                return base.method_2<float>("m_coolDownAnimTime");
            }
        }

        public float m_currVal
        {
            get
            {
                return base.method_2<float>("m_currVal");
            }
        }

        public float m_decreaseAnimTime
        {
            get
            {
                return base.method_2<float>("m_decreaseAnimTime");
            }
        }

        public float m_decreasePitchEnd
        {
            get
            {
                return base.method_2<float>("m_decreasePitchEnd");
            }
        }

        public float m_decreasePitchStart
        {
            get
            {
                return base.method_2<float>("m_decreasePitchStart");
            }
        }

        public float m_factor
        {
            get
            {
                return base.method_2<float>("m_factor");
            }
        }

        public float m_increaseAnimTime
        {
            get
            {
                return base.method_2<float>("m_increaseAnimTime");
            }
        }

        public float m_increasePitchEnd
        {
            get
            {
                return base.method_2<float>("m_increasePitchEnd");
            }
        }

        public float m_increasePitchStart
        {
            get
            {
                return base.method_2<float>("m_increasePitchStart");
            }
        }

        public TextMesh m_label
        {
            get
            {
                return base.method_3<TextMesh>("m_label");
            }
        }

        public float m_maxIntensity
        {
            get
            {
                return base.method_2<float>("m_maxIntensity");
            }
        }

        public float m_prevVal
        {
            get
            {
                return base.method_2<float>("m_prevVal");
            }
        }

        public float m_Uadd
        {
            get
            {
                return base.method_2<float>("m_Uadd");
            }
        }

        public UberText m_uberLabel
        {
            get
            {
                return base.method_3<UberText>("m_uberLabel");
            }
        }
    }
}

