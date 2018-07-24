namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;

    [Attribute38("DisenchantButton")]
    public class DisenchantButton : CraftingButton
    {
        public DisenchantButton(IntPtr address) : this(address, "DisenchantButton")
        {
        }

        public DisenchantButton(IntPtr address, string className) : base(address, className)
        {
        }

        public void DoDisenchant()
        {
            base.method_8("DoDisenchant", Array.Empty<object>());
        }

        public void EnableButton()
        {
            base.method_8("EnableButton", Array.Empty<object>());
        }

        public List<string> GetPostDisenchantInvalidDeckNames()
        {
            Class268 class2 = base.method_14<Class268>("GetPostDisenchantInvalidDeckNames", Array.Empty<object>());
            if (class2 != null)
            {
                return class2.method_25();
            }
            return null;
        }

        public void OnConfirmDisenchantResponse(AlertPopup.Response response, object userData)
        {
            object[] objArray1 = new object[] { response, userData };
            base.method_8("OnConfirmDisenchantResponse", objArray1);
        }

        public void OnReadyToStartDisenchant()
        {
            base.method_8("OnReadyToStartDisenchant", Array.Empty<object>());
        }

        public void OnRelease()
        {
            base.method_8("OnRelease", Array.Empty<object>());
        }

        public string m_lastwarnedCard
        {
            get
            {
                return base.method_4("m_lastwarnedCard");
            }
        }
    }
}

