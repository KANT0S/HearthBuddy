namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("BigCard")]
    public class BigCard : MonoBehaviour
    {
        public BigCard(IntPtr address) : this(address, "BigCard")
        {
        }

        public BigCard(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public BigCardEnchantmentPanel CreateEnchantmentPanel(int index)
        {
            object[] objArray1 = new object[] { index };
            return base.method_14<BigCardEnchantmentPanel>("CreateEnchantmentPanel", objArray1);
        }

        public void DestroyEnchantmentPanel(BigCardEnchantmentPanel panel)
        {
            object[] objArray1 = new object[] { panel };
            base.method_8("DestroyEnchantmentPanel", objArray1);
        }

        public void DisplayBigCard()
        {
            base.method_8("DisplayBigCard", Array.Empty<object>());
        }

        public void FitInsideScreen()
        {
            base.method_8("FitInsideScreen", Array.Empty<object>());
        }

        public bool FitInsideScreenBottom()
        {
            return base.method_11<bool>("FitInsideScreenBottom", Array.Empty<object>());
        }

        public bool FitInsideScreenTop()
        {
            return base.method_11<bool>("FitInsideScreenTop", Array.Empty<object>());
        }

        public static BigCard Get()
        {
            return MonoClass.smethod_15<BigCard>(TritonHs.MainAssemblyPath, "", "BigCard", "Get", Array.Empty<object>());
        }

        public Card GetCard()
        {
            return base.method_14<Card>("GetCard", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_9("Hide", new Class272.Enum20[0], Array.Empty<object>());
        }

        public bool Hide(Card card)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { card };
            return base.method_10<bool>("Hide", enumArray1, objArray1);
        }

        public void HideBigCard()
        {
            base.method_8("HideBigCard", Array.Empty<object>());
        }

        public void HidePhoneSecret(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            base.method_8("HidePhoneSecret", objArray1);
        }

        public void HideTooltipPhoneSecrets()
        {
            base.method_8("HideTooltipPhoneSecrets", Array.Empty<object>());
        }

        public void LayoutEnchantments(GameObject bone)
        {
            object[] objArray1 = new object[] { bone };
            base.method_8("LayoutEnchantments", objArray1);
        }

        public void LoadAndDisplayBigCard()
        {
            base.method_8("LoadAndDisplayBigCard", Array.Empty<object>());
        }

        public void LoadAndDisplayTooltipPhoneSecrets()
        {
            base.method_8("LoadAndDisplayTooltipPhoneSecrets", Array.Empty<object>());
        }

        public Actor LoadPhoneSecret(Card card)
        {
            object[] objArray1 = new object[] { card };
            return base.method_14<Actor>("LoadPhoneSecret", objArray1);
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void ResetEnchantments()
        {
            base.method_8("ResetEnchantments", Array.Empty<object>());
        }

        public void SetupActor(Card card, Actor actor)
        {
            object[] objArray1 = new object[] { card, actor };
            base.method_8("SetupActor", objArray1);
        }

        public bool ShouldActorUseEntity(Triton.Game.Mapping.Entity entity)
        {
            object[] objArray1 = new object[] { entity };
            return base.method_11<bool>("ShouldActorUseEntity", objArray1);
        }

        public void Show(Card card)
        {
            object[] objArray1 = new object[] { card };
            base.method_8("Show", objArray1);
        }

        public bool ShowBigCardOnRight()
        {
            return base.method_11<bool>("ShowBigCardOnRight", Array.Empty<object>());
        }

        public bool ShowBigCardOnRightMouse()
        {
            return base.method_11<bool>("ShowBigCardOnRightMouse", Array.Empty<object>());
        }

        public bool ShowBigCardOnRightTouch()
        {
            return base.method_11<bool>("ShowBigCardOnRightTouch", Array.Empty<object>());
        }

        public bool ShowKeywordOnRight()
        {
            return base.method_11<bool>("ShowKeywordOnRight", Array.Empty<object>());
        }

        public void ShowPhoneSecretDeath(Actor actor)
        {
            object[] objArray1 = new object[] { actor };
            base.method_8("ShowPhoneSecretDeath", objArray1);
        }

        public void UpdateEnchantments()
        {
            base.method_8("UpdateEnchantments", Array.Empty<object>());
        }

        public static Vector3 INVISIBLE_SCALE
        {
            get
            {
                return MonoClass.smethod_6<Vector3>(TritonHs.MainAssemblyPath, "", "BigCard", "INVISIBLE_SCALE");
            }
        }

        public Actor m_bigCardActor
        {
            get
            {
                return base.method_3<Actor>("m_bigCardActor");
            }
        }

        public Card m_card
        {
            get
            {
                return base.method_3<Card>("m_card");
            }
        }

        public GameObject m_EnchantmentBanner
        {
            get
            {
                return base.method_3<GameObject>("m_EnchantmentBanner");
            }
        }

        public GameObject m_EnchantmentBannerBottom
        {
            get
            {
                return base.method_3<GameObject>("m_EnchantmentBannerBottom");
            }
        }

        public BigCardEnchantmentPanel m_EnchantmentPanelPrefab
        {
            get
            {
                return base.method_3<BigCardEnchantmentPanel>("m_EnchantmentPanelPrefab");
            }
        }

        public Vector3 m_initialBannerBottomScale
        {
            get
            {
                return base.method_2<Vector3>("m_initialBannerBottomScale");
            }
        }

        public float m_initialBannerHeight
        {
            get
            {
                return base.method_2<float>("m_initialBannerHeight");
            }
        }

        public Vector3 m_initialBannerScale
        {
            get
            {
                return base.method_2<Vector3>("m_initialBannerScale");
            }
        }

        public LayoutData m_LayoutData
        {
            get
            {
                return base.method_3<LayoutData>("m_LayoutData");
            }
        }

        public List<Actor> m_phoneSecretActors
        {
            get
            {
                Class267<Actor> class2 = base.method_3<Class267<Actor>>("m_phoneSecretActors");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public int m_RenderQueueEnchantmentBanner
        {
            get
            {
                return base.method_2<int>("m_RenderQueueEnchantmentBanner");
            }
        }

        public int m_RenderQueueEnchantmentPanel
        {
            get
            {
                return base.method_2<int>("m_RenderQueueEnchantmentPanel");
            }
        }

        public SecretLayoutData m_SecretLayoutData
        {
            get
            {
                return base.method_3<SecretLayoutData>("m_SecretLayoutData");
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct KeywordArgs
        {
            public Card card;
            public Actor actor;
            public bool showOnRight;
        }

        [Attribute38("BigCard.LayoutData")]
        public class LayoutData : MonoClass
        {
            public LayoutData(IntPtr address) : this(address, "LayoutData")
            {
            }

            public LayoutData(IntPtr address, string className) : base(address, className)
            {
            }

            public float m_DriftSec
            {
                get
                {
                    return base.method_2<float>("m_DriftSec");
                }
            }

            public float m_ScaleSec
            {
                get
                {
                    return base.method_2<float>("m_ScaleSec");
                }
            }
        }

        [Attribute38("BigCard.SecretLayoutData")]
        public class SecretLayoutData : MonoClass
        {
            public SecretLayoutData(IntPtr address) : this(address, "SecretLayoutData")
            {
            }

            public SecretLayoutData(IntPtr address, string className) : base(address, className)
            {
            }

            public float m_DeathShowAnimTime
            {
                get
                {
                    return base.method_2<float>("m_DeathShowAnimTime");
                }
            }

            public Vector3 m_DriftOffset
            {
                get
                {
                    return base.method_2<Vector3>("m_DriftOffset");
                }
            }

            public float m_DriftSec
            {
                get
                {
                    return base.method_2<float>("m_DriftSec");
                }
            }

            public Vector3 m_HiddenSpacing
            {
                get
                {
                    return base.method_2<Vector3>("m_HiddenSpacing");
                }
            }

            public float m_HideAnimTime
            {
                get
                {
                    return base.method_2<float>("m_HideAnimTime");
                }
            }

            public BigCard.SecretLayoutOffsets m_MaxCardOffsets
            {
                get
                {
                    return base.method_3<BigCard.SecretLayoutOffsets>("m_MaxCardOffsets");
                }
            }

            public int m_MaxCardThreshold
            {
                get
                {
                    return base.method_2<int>("m_MaxCardThreshold");
                }
            }

            public BigCard.SecretLayoutOffsets m_MinCardOffsets
            {
                get
                {
                    return base.method_3<BigCard.SecretLayoutOffsets>("m_MinCardOffsets");
                }
            }

            public int m_MinCardThreshold
            {
                get
                {
                    return base.method_2<int>("m_MinCardThreshold");
                }
            }

            public float m_ShowAnimTime
            {
                get
                {
                    return base.method_2<float>("m_ShowAnimTime");
                }
            }

            public Vector3 m_Spacing
            {
                get
                {
                    return base.method_2<Vector3>("m_Spacing");
                }
            }

            public float m_TimeUntilDeathSpell
            {
                get
                {
                    return base.method_2<float>("m_TimeUntilDeathSpell");
                }
            }
        }

        [Attribute38("BigCard.SecretLayoutOffsets")]
        public class SecretLayoutOffsets : MonoClass
        {
            public SecretLayoutOffsets(IntPtr address) : this(address, "SecretLayoutOffsets")
            {
            }

            public SecretLayoutOffsets(IntPtr address, string className) : base(address, className)
            {
            }

            public Vector3 m_HiddenInitialOffset
            {
                get
                {
                    return base.method_2<Vector3>("m_HiddenInitialOffset");
                }
            }

            public Vector3 m_HiddenOpponentInitialOffset
            {
                get
                {
                    return base.method_2<Vector3>("m_HiddenOpponentInitialOffset");
                }
            }

            public Vector3 m_InitialOffset
            {
                get
                {
                    return base.method_2<Vector3>("m_InitialOffset");
                }
            }

            public Vector3 m_OpponentInitialOffset
            {
                get
                {
                    return base.method_2<Vector3>("m_OpponentInitialOffset");
                }
            }
        }
    }
}

