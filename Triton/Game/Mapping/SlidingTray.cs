namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("SlidingTray")]
    public class SlidingTray : MonoBehaviour
    {
        public SlidingTray(IntPtr address) : this(address, "SlidingTray")
        {
        }

        public SlidingTray(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool BackPressed()
        {
            return base.method_11<bool>("BackPressed", Array.Empty<object>());
        }

        public void FadeEffectsIn(float time)
        {
            object[] objArray1 = new object[] { time };
            base.method_8("FadeEffectsIn", objArray1);
        }

        public void FadeEffectsOut(float time)
        {
            object[] objArray1 = new object[] { time };
            base.method_8("FadeEffectsOut", objArray1);
        }

        public void HideTray()
        {
            base.method_8("HideTray", Array.Empty<object>());
        }

        public bool IsTrayInShownPosition()
        {
            return base.method_11<bool>("IsTrayInShownPosition", Array.Empty<object>());
        }

        public void OnClickCatcherPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnClickCatcherPressed", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnFadeFinished()
        {
            base.method_8("OnFadeFinished", Array.Empty<object>());
        }

        public void OnTraySliderAnimFinished()
        {
            base.method_8("OnTraySliderAnimFinished", Array.Empty<object>());
        }

        public void OnTraySliderPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnTraySliderPressed", objArray1);
        }

        public void ShowTray()
        {
            base.method_8("ShowTray", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public void ToggleTraySlider(bool show, Transform target, bool animate)
        {
            object[] objArray1 = new object[] { show, target, animate };
            base.method_8("ToggleTraySlider", objArray1);
        }

        public bool TraySliderIsAnimating()
        {
            return base.method_11<bool>("TraySliderIsAnimating", Array.Empty<object>());
        }

        public bool m_animateBounce
        {
            get
            {
                return base.method_2<bool>("m_animateBounce");
            }
        }

        public bool m_inactivateOnHide
        {
            get
            {
                return base.method_2<bool>("m_inactivateOnHide");
            }
        }

        public PegUIElement m_offClickCatcher
        {
            get
            {
                return base.method_3<PegUIElement>("m_offClickCatcher");
            }
        }

        public bool m_playAudioOnSlide
        {
            get
            {
                return base.method_2<bool>("m_playAudioOnSlide");
            }
        }

        public bool m_startingPositionSet
        {
            get
            {
                return base.method_2<bool>("m_startingPositionSet");
            }
        }

        public Transform m_trayHiddenBone
        {
            get
            {
                return base.method_3<Transform>("m_trayHiddenBone");
            }
        }

        public bool m_trayShown
        {
            get
            {
                return base.method_2<bool>("m_trayShown");
            }
        }

        public Transform m_trayShownBone
        {
            get
            {
                return base.method_3<Transform>("m_trayShownBone");
            }
        }

        public float m_traySlideDuration
        {
            get
            {
                return base.method_2<float>("m_traySlideDuration");
            }
        }

        public bool m_traySliderAnimating
        {
            get
            {
                return base.method_2<bool>("m_traySliderAnimating");
            }
        }

        public PegUIElement m_traySliderButton
        {
            get
            {
                return base.method_3<PegUIElement>("m_traySliderButton");
            }
        }

        public bool m_useNavigationBack
        {
            get
            {
                return base.method_2<bool>("m_useNavigationBack");
            }
        }
    }
}

