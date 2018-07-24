namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("AdventureRewardsDisplayArea")]
    public class AdventureRewardsDisplayArea : MonoBehaviour
    {
        public AdventureRewardsDisplayArea(IntPtr address) : this(address, "AdventureRewardsDisplayArea")
        {
        }

        public AdventureRewardsDisplayArea(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void DisableFullscreen()
        {
            base.method_8("DisableFullscreen", Array.Empty<object>());
        }

        public void EnableFullscreen(bool disableFullscreen)
        {
            object[] objArray1 = new object[] { disableFullscreen };
            base.method_8("EnableFullscreen", objArray1);
        }

        public void HideCardRewards()
        {
            base.method_8("HideCardRewards", Array.Empty<object>());
        }

        public bool IsShowing()
        {
            return base.method_11<bool>("IsShowing", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public string m_CardPreviewAppearSound
        {
            get
            {
                return base.method_4("m_CardPreviewAppearSound");
            }
        }

        public List<Actor> m_CurrentCardRewards
        {
            get
            {
                Class267<Actor> class2 = base.method_3<Class267<Actor>>("m_CurrentCardRewards");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public bool m_EnableFullscreenMode
        {
            get
            {
                return base.method_2<bool>("m_EnableFullscreenMode");
            }
        }

        public UIBScrollable m_FullscreenDisableScrollBar
        {
            get
            {
                return base.method_3<UIBScrollable>("m_FullscreenDisableScrollBar");
            }
        }

        public bool m_FullscreenEnabled
        {
            get
            {
                return base.method_2<bool>("m_FullscreenEnabled");
            }
        }

        public PegUIElement m_FullscreenModeOffClicker
        {
            get
            {
                return base.method_3<PegUIElement>("m_FullscreenModeOffClicker");
            }
        }

        public GameObject m_RewardsCardArea
        {
            get
            {
                return base.method_3<GameObject>("m_RewardsCardArea");
            }
        }

        public Vector3 m_RewardsCardDriftAmount
        {
            get
            {
                return base.method_2<Vector3>("m_RewardsCardDriftAmount");
            }
        }

        public float m_RewardsCardMouseOffset
        {
            get
            {
                return base.method_2<float>("m_RewardsCardMouseOffset");
            }
        }

        public Vector3 m_RewardsCardOffset
        {
            get
            {
                return base.method_2<Vector3>("m_RewardsCardOffset");
            }
        }

        public Vector3 m_RewardsCardScale
        {
            get
            {
                return base.method_2<Vector3>("m_RewardsCardScale");
            }
        }

        public float m_RewardsCardSpacing
        {
            get
            {
                return base.method_2<float>("m_RewardsCardSpacing");
            }
        }

        public bool m_Showing
        {
            get
            {
                return base.method_2<bool>("m_Showing");
            }
        }
    }
}

