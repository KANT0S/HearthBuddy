namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("UIBPopup")]
    public class UIBPopup : MonoBehaviour
    {
        public UIBPopup(IntPtr address) : this(address, "UIBPopup")
        {
        }

        public UIBPopup(IntPtr address, string className) : base(address, className)
        {
        }

        public void EnableAnimationClickBlocker(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableAnimationClickBlocker", objArray1);
        }

        public void Hide()
        {
            base.method_9("Hide", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void Hide(bool animate)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Boolean };
            object[] objArray1 = new object[] { animate };
            base.method_9("Hide", enumArray1, objArray1);
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public void OnHidden()
        {
            base.method_8("OnHidden", Array.Empty<object>());
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public BoxCollider m_animationClickBlocker
        {
            get
            {
                return base.method_3<BoxCollider>("m_animationClickBlocker");
            }
        }

        public bool m_destroyOnSceneLoad
        {
            get
            {
                return base.method_2<bool>("m_destroyOnSceneLoad");
            }
        }

        public string m_hideAnimationSound
        {
            get
            {
                return base.method_4("m_hideAnimationSound");
            }
        }

        public float m_hideAnimTime
        {
            get
            {
                return base.method_2<float>("m_hideAnimTime");
            }
        }

        public Vector3 m_hidePosition
        {
            get
            {
                return base.method_2<Vector3>("m_hidePosition");
            }
        }

        public bool m_playHideSoundWithNoAnimation
        {
            get
            {
                return base.method_2<bool>("m_playHideSoundWithNoAnimation");
            }
        }

        public bool m_playShowSoundWithNoAnimation
        {
            get
            {
                return base.method_2<bool>("m_playShowSoundWithNoAnimation");
            }
        }

        public CanvasScaleMode m_scaleMode
        {
            get
            {
                return base.method_2<CanvasScaleMode>("m_scaleMode");
            }
        }

        public string m_showAnimationSound
        {
            get
            {
                return base.method_4("m_showAnimationSound");
            }
        }

        public float m_showAnimTime
        {
            get
            {
                return base.method_2<float>("m_showAnimTime");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }

        public Vector3 m_showPosition
        {
            get
            {
                return base.method_2<Vector3>("m_showPosition");
            }
        }

        public Vector3 m_showScale
        {
            get
            {
                return base.method_2<Vector3>("m_showScale");
            }
        }

        public static string s_ShowiTweenAnimationName
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "UIBPopup", "s_ShowiTweenAnimationName");
            }
        }
    }
}

