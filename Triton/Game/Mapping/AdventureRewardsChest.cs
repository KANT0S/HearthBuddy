namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdventureRewardsChest")]
    public class AdventureRewardsChest : MonoBehaviour
    {
        public AdventureRewardsChest(IntPtr address) : this(address, "AdventureRewardsChest")
        {
        }

        public AdventureRewardsChest(IntPtr address, string className) : base(address, className)
        {
        }

        public void BlinkChest()
        {
            base.method_8("BlinkChest", Array.Empty<object>());
        }

        public void BurstCheckmark()
        {
            base.method_8("BurstCheckmark", Array.Empty<object>());
        }

        public void Enable(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("Enable", objArray1);
        }

        public void HideAll()
        {
            base.method_8("HideAll", Array.Empty<object>());
        }

        public void ShowCheckmark()
        {
            base.method_8("ShowCheckmark", Array.Empty<object>());
        }

        public void ShowChest()
        {
            base.method_8("ShowChest", Array.Empty<object>());
        }

        public void SlamInCheckmark()
        {
            base.method_8("SlamInCheckmark", Array.Empty<object>());
        }

        public GameObject m_CheckmarkContainer
        {
            get
            {
                return base.method_3<GameObject>("m_CheckmarkContainer");
            }
        }

        public PegUIElement m_ChestClickArea
        {
            get
            {
                return base.method_3<PegUIElement>("m_ChestClickArea");
            }
        }

        public GameObject m_ChestContainer
        {
            get
            {
                return base.method_3<GameObject>("m_ChestContainer");
            }
        }

        public StateEventTable m_EventTable
        {
            get
            {
                return base.method_3<StateEventTable>("m_EventTable");
            }
        }

        public static string s_EventBlinkChest
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureRewardsChest", "s_EventBlinkChest");
            }
        }

        public static string s_EventBurstCheckmark
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureRewardsChest", "s_EventBurstCheckmark");
            }
        }

        public static string s_EventOpenChest
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureRewardsChest", "s_EventOpenChest");
            }
        }

        public static string s_EventSlamInCheckmark
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureRewardsChest", "s_EventSlamInCheckmark");
            }
        }
    }
}

