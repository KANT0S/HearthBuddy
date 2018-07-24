namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdventureCompleteReward")]
    public class AdventureCompleteReward : Reward
    {
        public AdventureCompleteReward(IntPtr address) : this(address, "AdventureCompleteReward")
        {
        }

        public AdventureCompleteReward(IntPtr address, string className) : base(address, className)
        {
        }

        public void DestroyThis()
        {
            base.method_8("DestroyThis", Array.Empty<object>());
        }

        public void FadeFullscreenEffectsIn()
        {
            base.method_8("FadeFullscreenEffectsIn", Array.Empty<object>());
        }

        public void FadeFullscreenEffectsOut()
        {
            base.method_8("FadeFullscreenEffectsOut", Array.Empty<object>());
        }

        public void HideReward()
        {
            base.method_8("HideReward", Array.Empty<object>());
        }

        public void InitData()
        {
            base.method_8("InitData", Array.Empty<object>());
        }

        public void OnDataSet(bool updateVisuals)
        {
            object[] objArray1 = new object[] { updateVisuals };
            base.method_8("OnDataSet", objArray1);
        }

        public void ShowReward(bool updateCacheValues)
        {
            object[] objArray1 = new object[] { updateCacheValues };
            base.method_8("ShowReward", objArray1);
        }

        public GameObject m_BannerObject
        {
            get
            {
                return base.method_3<GameObject>("m_BannerObject");
            }
        }

        public UberText m_BannerTextObject
        {
            get
            {
                return base.method_3<UberText>("m_BannerTextObject");
            }
        }

        public StateEventTable m_StateTable
        {
            get
            {
                return base.method_3<StateEventTable>("m_StateTable");
            }
        }

        public static string s_EventHide
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureCompleteReward", "s_EventHide");
            }
        }

        public static string s_EventShowBadlyHurt
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureCompleteReward", "s_EventShowBadlyHurt");
            }
        }

        public static string s_EventShowHurt
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureCompleteReward", "s_EventShowHurt");
            }
        }
    }
}

