namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("StoreRadioButton")]
    public class StoreRadioButton : FramedRadioButton
    {
        public StoreRadioButton(IntPtr address) : this(address, "StoreRadioButton")
        {
        }

        public StoreRadioButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void ActivateSale(bool active)
        {
            object[] objArray1 = new object[] { active };
            base.method_8("ActivateSale", objArray1);
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Init(FramedRadioButton.FrameType frameType, string text, int buttonID, object userData)
        {
            object[] objArray1 = new object[] { frameType, text, buttonID, userData };
            base.method_8("Init", objArray1);
        }

        public void InitGoldOptionNoGTAPP(NoGTAPPTransactionData noGTAPPTransactionData)
        {
            object[] objArray1 = new object[] { noGTAPPTransactionData };
            base.method_8("InitGoldOptionNoGTAPP", objArray1);
        }

        public void InitMoneyOption(Network.Bundle bundle)
        {
            object[] objArray1 = new object[] { bundle };
            base.method_8("InitMoneyOption", objArray1);
        }

        public GameObject m_bonusFrame
        {
            get
            {
                return base.method_3<GameObject>("m_bonusFrame");
            }
        }

        public UberText m_bonusText
        {
            get
            {
                return base.method_3<UberText>("m_bonusText");
            }
        }

        public UberText m_cost
        {
            get
            {
                return base.method_3<UberText>("m_cost");
            }
        }

        public UberText m_goldButtonText
        {
            get
            {
                return base.method_3<UberText>("m_goldButtonText");
            }
        }

        public UberText m_goldCostText
        {
            get
            {
                return base.method_3<UberText>("m_goldCostText");
            }
        }

        public GameObject m_goldRoot
        {
            get
            {
                return base.method_3<GameObject>("m_goldRoot");
            }
        }

        public GameObject m_realMoneyTextRoot
        {
            get
            {
                return base.method_3<GameObject>("m_realMoneyTextRoot");
            }
        }

        public SaleBanner m_saleBanner
        {
            get
            {
                return base.method_3<SaleBanner>("m_saleBanner");
            }
        }

        public static Color NO_SALE_TEXT_COLOR
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "StoreRadioButton", "NO_SALE_TEXT_COLOR");
            }
        }

        public static Color ON_SALE_TEXT_COLOR
        {
            get
            {
                return MonoClass.smethod_6<Color>(TritonHs.MainAssemblyPath, "", "StoreRadioButton", "ON_SALE_TEXT_COLOR");
            }
        }

        [Attribute38("StoreRadioButton.Data")]
        public class Data : MonoClass
        {
            public Data(IntPtr address) : this(address, "Data")
            {
            }

            public Data(IntPtr address, string className) : base(address, className)
            {
            }

            public Network.Bundle m_bundle
            {
                get
                {
                    return base.method_3<Network.Bundle>("m_bundle");
                }
            }

            public NoGTAPPTransactionData m_noGTAPPTransactionData
            {
                get
                {
                    return base.method_3<NoGTAPPTransactionData>("m_noGTAPPTransactionData");
                }
            }
        }
    }
}

