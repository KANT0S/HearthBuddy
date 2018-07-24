namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BigCardEnchantmentPanel")]
    public class BigCardEnchantmentPanel : MonoBehaviour
    {
        public BigCardEnchantmentPanel(IntPtr address) : this(address, "BigCardEnchantmentPanel")
        {
        }

        public BigCardEnchantmentPanel(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public float GetHeight()
        {
            return base.method_11<float>("GetHeight", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_8("Hide", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public void OnCardDefLoaded(string cardId, CardDef cardDef, object callbackData)
        {
            object[] objArray1 = new object[] { cardId, cardDef, callbackData };
            base.method_8("OnCardDefLoaded", objArray1);
        }

        public void ResetScale()
        {
            base.method_8("ResetScale", Array.Empty<object>());
        }

        public void SetEnchantment(Triton.Game.Mapping.Entity enchantment)
        {
            object[] objArray1 = new object[] { enchantment };
            base.method_8("SetEnchantment", objArray1);
        }

        public void Show()
        {
            base.method_8("Show", Array.Empty<object>());
        }

        public void UpdateLayout()
        {
            base.method_8("UpdateLayout", Array.Empty<object>());
        }

        public Actor m_Actor
        {
            get
            {
                return base.method_3<Actor>("m_Actor");
            }
        }

        public GameObject m_Background
        {
            get
            {
                return base.method_3<GameObject>("m_Background");
            }
        }

        public UberText m_BodyText
        {
            get
            {
                return base.method_3<UberText>("m_BodyText");
            }
        }

        public Triton.Game.Mapping.Entity m_enchantment
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Entity>("m_enchantment");
            }
        }

        public UberText m_HeaderText
        {
            get
            {
                return base.method_3<UberText>("m_HeaderText");
            }
        }

        public float m_initialBackgroundHeight
        {
            get
            {
                return base.method_2<float>("m_initialBackgroundHeight");
            }
        }

        public Vector3 m_initialBackgroundScale
        {
            get
            {
                return base.method_2<Vector3>("m_initialBackgroundScale");
            }
        }

        public Vector3 m_initialScale
        {
            get
            {
                return base.method_2<Vector3>("m_initialScale");
            }
        }

        public bool m_shown
        {
            get
            {
                return base.method_2<bool>("m_shown");
            }
        }
    }
}

