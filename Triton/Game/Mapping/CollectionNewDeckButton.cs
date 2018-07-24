namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("CollectionNewDeckButton")]
    public class CollectionNewDeckButton : PegUIElement
    {
        public CollectionNewDeckButton(IntPtr address) : this(address, "CollectionNewDeckButton")
        {
        }

        public CollectionNewDeckButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public bool IsUsable()
        {
            return base.method_11<bool>("IsUsable", Array.Empty<object>());
        }

        public void OnOut(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOut", objArray1);
        }

        public void OnOver(PegUIElement.InteractionState oldState)
        {
            object[] objArray1 = new object[] { oldState };
            base.method_8("OnOver", objArray1);
        }

        public void PlayAnimation(string animationName)
        {
            Class272.Enum20[] enumArray1 = new Class272.Enum20[] { Class272.Enum20.String };
            object[] objArray1 = new object[] { animationName };
            base.method_9("PlayAnimation", enumArray1, objArray1);
        }

        public void PlayPopDownAnimation()
        {
            base.method_9("PlayPopDownAnimation", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void PlayPopUpAnimation()
        {
            base.method_9("PlayPopUpAnimation", new Class272.Enum20[0], Array.Empty<object>());
        }

        public void SetIsUsable(bool isUsable)
        {
            object[] objArray1 = new object[] { isUsable };
            base.method_8("SetIsUsable", objArray1);
        }

        public static float BUTTON_POP_SPEED
        {
            get
            {
                return MonoClass.smethod_6<float>(TritonHs.MainAssemblyPath, "", "CollectionNewDeckButton", "BUTTON_POP_SPEED");
            }
        }

        public string DECKBOX_POPDOWN_ANIM_NAME
        {
            get
            {
                return base.method_4("DECKBOX_POPDOWN_ANIM_NAME");
            }
        }

        public string DECKBOX_POPUP_ANIM_NAME
        {
            get
            {
                return base.method_4("DECKBOX_POPUP_ANIM_NAME");
            }
        }

        public UberText m_buttonText
        {
            get
            {
                return base.method_3<UberText>("m_buttonText");
            }
        }

        public HighlightState m_highlightState
        {
            get
            {
                return base.method_3<HighlightState>("m_highlightState");
            }
        }

        public bool m_isPoppedUp
        {
            get
            {
                return base.method_2<bool>("m_isPoppedUp");
            }
        }

        public bool m_isUsable
        {
            get
            {
                return base.method_2<bool>("m_isUsable");
            }
        }

        [Attribute38("CollectionNewDeckButton.OnPopAnimationFinishedCallbackData")]
        public class OnPopAnimationFinishedCallbackData : MonoClass
        {
            public OnPopAnimationFinishedCallbackData(IntPtr address) : this(address, "OnPopAnimationFinishedCallbackData")
            {
            }

            public OnPopAnimationFinishedCallbackData(IntPtr address, string className) : base(address, className)
            {
            }

            public string m_animationName
            {
                get
                {
                    return base.method_4("m_animationName");
                }
            }

            public object m_callbackData
            {
                get
                {
                    return base.method_3<object>("m_callbackData");
                }
            }
        }
    }
}

