namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeckTrayContent")]
    public class DeckTrayContent : MonoBehaviour
    {
        public DeckTrayContent(IntPtr address) : this(address, "DeckTrayContent")
        {
        }

        public DeckTrayContent(IntPtr address, string className) : base(address, className)
        {
        }

        public bool AnimateContentEntranceEnd()
        {
            return base.method_11<bool>("AnimateContentEntranceEnd", Array.Empty<object>());
        }

        public bool AnimateContentEntranceStart()
        {
            return base.method_11<bool>("AnimateContentEntranceStart", Array.Empty<object>());
        }

        public bool AnimateContentExitEnd()
        {
            return base.method_11<bool>("AnimateContentExitEnd", Array.Empty<object>());
        }

        public bool AnimateContentExitStart()
        {
            return base.method_11<bool>("AnimateContentExitStart", Array.Empty<object>());
        }

        public void Hide(bool hideAll)
        {
            object[] objArray1 = new object[] { hideAll };
            base.method_8("Hide", objArray1);
        }

        public bool IsContentLoaded()
        {
            return base.method_11<bool>("IsContentLoaded", Array.Empty<object>());
        }

        public bool IsModeActive()
        {
            return base.method_11<bool>("IsModeActive", Array.Empty<object>());
        }

        public bool IsModeTryingOrActive()
        {
            return base.method_11<bool>("IsModeTryingOrActive", Array.Empty<object>());
        }

        public void OnContentLoaded()
        {
            base.method_8("OnContentLoaded", Array.Empty<object>());
        }

        public void OnTaggedDeckChanged(CollectionManager.DeckTag tag, CollectionDeck newDeck, CollectionDeck oldDeck, bool isNewDeck)
        {
            object[] objArray1 = new object[] { tag, newDeck, oldDeck, isNewDeck };
            base.method_8("OnTaggedDeckChanged", objArray1);
        }

        public bool PostAnimateContentEntrance()
        {
            return base.method_11<bool>("PostAnimateContentEntrance", Array.Empty<object>());
        }

        public bool PostAnimateContentExit()
        {
            return base.method_11<bool>("PostAnimateContentExit", Array.Empty<object>());
        }

        public bool PreAnimateContentEntrance()
        {
            return base.method_11<bool>("PreAnimateContentEntrance", Array.Empty<object>());
        }

        public bool PreAnimateContentExit()
        {
            return base.method_11<bool>("PreAnimateContentExit", Array.Empty<object>());
        }

        public void SetModeActive(bool active)
        {
            object[] objArray1 = new object[] { active };
            base.method_8("SetModeActive", objArray1);
        }

        public void SetModeTrying(bool trying)
        {
            object[] objArray1 = new object[] { trying };
            base.method_8("SetModeTrying", objArray1);
        }

        public void Show(bool showAll)
        {
            object[] objArray1 = new object[] { showAll };
            base.method_8("Show", objArray1);
        }

        public bool m_isModeActive
        {
            get
            {
                return base.method_2<bool>("m_isModeActive");
            }
        }

        public bool m_isModeTrying
        {
            get
            {
                return base.method_2<bool>("m_isModeTrying");
            }
        }
    }
}

