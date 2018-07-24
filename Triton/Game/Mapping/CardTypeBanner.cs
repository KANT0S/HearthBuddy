namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CardTypeBanner")]
    public class CardTypeBanner : MonoBehaviour
    {
        public CardTypeBanner(IntPtr address) : this(address, "CardTypeBanner")
        {
        }

        public CardTypeBanner(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public static CardTypeBanner Get()
        {
            return MonoClass.smethod_15<CardTypeBanner>(TritonHs.MainAssemblyPath, "", "CardTypeBanner", "Get", Array.Empty<object>());
        }

        public CardDef GetCardDef()
        {
            return base.method_14<CardDef>("GetCardDef", Array.Empty<object>());
        }

        public void Hide()
        {
            base.method_9("Hide", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void Hide(Actor actor)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.Class };
            object[] objArray1 = new object[] { actor };
            base.method_9("Hide", enumArray1, objArray1);
        }

        public void HideImpl()
        {
            base.method_8("HideImpl", Array.Empty<object>());
        }

        public bool IsShown()
        {
            return base.method_11<bool>("IsShown", Array.Empty<object>());
        }

        public void OnDestroy()
        {
            base.method_8("OnDestroy", Array.Empty<object>());
        }

        public void Show(Actor a)
        {
            object[] objArray1 = new object[] { a };
            base.method_8("Show", objArray1);
        }

        public void ShowImpl()
        {
            base.method_8("ShowImpl", Array.Empty<object>());
        }

        public void Update()
        {
            base.method_8("Update", Array.Empty<object>());
        }

        public void UpdatePosition()
        {
            base.method_8("UpdatePosition", Array.Empty<object>());
        }

        public Actor m_actor
        {
            get
            {
                return base.method_3<Actor>("m_actor");
            }
        }

        public GameObject m_minionBanner
        {
            get
            {
                return base.method_3<GameObject>("m_minionBanner");
            }
        }

        public GameObject m_root
        {
            get
            {
                return base.method_3<GameObject>("m_root");
            }
        }

        public GameObject m_spellBanner
        {
            get
            {
                return base.method_3<GameObject>("m_spellBanner");
            }
        }

        public UberText m_text
        {
            get
            {
                return base.method_3<UberText>("m_text");
            }
        }

        public GameObject m_weaponBanner
        {
            get
            {
                return base.method_3<GameObject>("m_weaponBanner");
            }
        }

        public Color MINION_COLOR
        {
            get
            {
                return base.method_2<Color>("MINION_COLOR");
            }
        }

        public Color SPELL_COLOR
        {
            get
            {
                return base.method_2<Color>("SPELL_COLOR");
            }
        }

        public Color WEAPON_COLOR
        {
            get
            {
                return base.method_2<Color>("WEAPON_COLOR");
            }
        }
    }
}

