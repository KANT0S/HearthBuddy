namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("AdventureMissionDisplayTray")]
    public class AdventureMissionDisplayTray : MonoBehaviour
    {
        public AdventureMissionDisplayTray(IntPtr address) : this(address, "AdventureMissionDisplayTray")
        {
        }

        public AdventureMissionDisplayTray(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void HideCardRewards()
        {
            base.method_8("HideCardRewards", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void OnMissionSelected(ScenarioDbId mission, bool showDetails)
        {
            object[] objArray1 = new object[] { mission, showDetails };
            base.method_8("OnMissionSelected", objArray1);
        }

        public void OnSubsceneChanged(AdventureSubScenes newscene, bool forward)
        {
            object[] objArray1 = new object[] { newscene, forward };
            base.method_8("OnSubsceneChanged", objArray1);
        }

        public void ShowCardRewards()
        {
            base.method_8("ShowCardRewards", Array.Empty<object>());
        }

        public PegUIElement m_rewardsChest
        {
            get
            {
                return base.method_3<PegUIElement>("m_rewardsChest");
            }
        }

        public AdventureRewardsDisplayArea m_rewardsDisplay
        {
            get
            {
                return base.method_3<AdventureRewardsDisplayArea>("m_rewardsDisplay");
            }
        }

        public Transform m_rewardsDisplayBone
        {
            get
            {
                return base.method_3<Transform>("m_rewardsDisplayBone");
            }
        }

        public SlidingTray m_slidingTray
        {
            get
            {
                return base.method_3<SlidingTray>("m_slidingTray");
            }
        }
    }
}

