namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("AdventureBossCoin")]
    public class AdventureBossCoin : PegUIElement
    {
        public AdventureBossCoin(IntPtr address) : this(address, "AdventureBossCoin")
        {
        }

        public AdventureBossCoin(IntPtr address, string className) : base(address, className)
        {
        }

        public void Enable(bool flag, bool animate)
        {
            object[] objArray1 = new object[] { flag, animate };
            base.method_8("Enable", objArray1);
        }

        public void EnableFancyHighlight(bool enable)
        {
            object[] objArray1 = new object[] { enable };
            base.method_8("EnableFancyHighlight", objArray1);
        }

        public void HighlightOnce()
        {
            base.method_8("HighlightOnce", Array.Empty<object>());
        }

        public void Select(bool selected)
        {
            object[] objArray1 = new object[] { selected };
            base.method_8("Select", objArray1);
        }

        public void SetPortraitMaterial(Material mat)
        {
            object[] objArray1 = new object[] { mat };
            base.method_8("SetPortraitMaterial", objArray1);
        }

        public void ShowCoin(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowCoin", objArray1);
        }

        public void ShowConnector(bool show)
        {
            object[] objArray1 = new object[] { show };
            base.method_8("ShowConnector", objArray1);
        }

        public void ShowNewLookGlow()
        {
            base.method_8("ShowNewLookGlow", Array.Empty<object>());
        }

        public GameObject m_Coin
        {
            get
            {
                return base.method_3<GameObject>("m_Coin");
            }
        }

        public StateEventTable m_CoinStateTable
        {
            get
            {
                return base.method_3<StateEventTable>("m_CoinStateTable");
            }
        }

        public GameObject m_Connector
        {
            get
            {
                return base.method_3<GameObject>("m_Connector");
            }
        }

        public PegUIElement m_DisabledCollider
        {
            get
            {
                return base.method_3<PegUIElement>("m_DisabledCollider");
            }
        }

        public bool m_Enabled
        {
            get
            {
                return base.method_2<bool>("m_Enabled");
            }
        }

        public int m_PortraitMaterialIndex
        {
            get
            {
                return base.method_2<int>("m_PortraitMaterialIndex");
            }
        }

        public MeshRenderer m_PortraitRenderer
        {
            get
            {
                return base.method_3<MeshRenderer>("m_PortraitRenderer");
            }
        }

        public static string s_EventCoinFlip
        {
            get
            {
                return MonoClass.smethod_8(TritonHs.MainAssemblyPath, "", "AdventureBossCoin", "s_EventCoinFlip");
            }
        }
    }
}

