namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("StoreQuantityPrompt")]
    public class StoreQuantityPrompt : UIBPopup
    {
        public StoreQuantityPrompt(IntPtr address) : this(address, "StoreQuantityPrompt")
        {
        }

        public StoreQuantityPrompt(IntPtr address, string className) : base(address, className)
        {
        }

        public void Awake()
        {
            base.method_8("Awake", Array.Empty<object>());
        }

        public void Cancel()
        {
            base.method_8("Cancel", Array.Empty<object>());
        }

        public void ClearInput()
        {
            base.method_8("ClearInput", Array.Empty<object>());
        }

        public void FireCancelEvent()
        {
            base.method_8("FireCancelEvent", Array.Empty<object>());
        }

        public void FireOkayEvent(int quantity)
        {
            object[] objArray1 = new object[] { quantity };
            base.method_8("FireOkayEvent", objArray1);
        }

        public void Hide(bool animate)
        {
            object[] objArray1 = new object[] { animate };
            base.method_8("Hide", objArray1);
        }

        public void HideInput()
        {
            base.method_8("HideInput", Array.Empty<object>());
        }

        public void OnCancelPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnCancelPressed", objArray1);
        }

        public void OnInputCanceled(bool userRequested, GameObject requester)
        {
            object[] objArray1 = new object[] { userRequested, requester };
            base.method_8("OnInputCanceled", objArray1);
        }

        public void OnInputComplete(string input)
        {
            object[] objArray1 = new object[] { input };
            base.method_8("OnInputComplete", objArray1);
        }

        public void OnInputUpdated(string input)
        {
            object[] objArray1 = new object[] { input };
            base.method_8("OnInputUpdated", objArray1);
        }

        public void OnSubmitPressed(UIEvent e)
        {
            object[] objArray1 = new object[] { e };
            base.method_8("OnSubmitPressed", objArray1);
        }

        public void ShowInput()
        {
            base.method_8("ShowInput", Array.Empty<object>());
        }

        public void Submit()
        {
            base.method_8("Submit", Array.Empty<object>());
        }

        public UIBButton m_cancelButton
        {
            get
            {
                return base.method_3<UIBButton>("m_cancelButton");
            }
        }

        public int m_currentMaxQuantity
        {
            get
            {
                return base.method_2<int>("m_currentMaxQuantity");
            }
        }

        public UberText m_messageText
        {
            get
            {
                return base.method_3<UberText>("m_messageText");
            }
        }

        public UIBButton m_okayButton
        {
            get
            {
                return base.method_3<UIBButton>("m_okayButton");
            }
        }

        public UberText m_quantityText
        {
            get
            {
                return base.method_3<UberText>("m_quantityText");
            }
        }
    }
}

