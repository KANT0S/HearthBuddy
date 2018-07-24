namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game;
    using Triton.Game.Mono;

    [Attribute38("DropdownControl")]
    public class DropdownControl : PegUIElement
    {
        public DropdownControl(IntPtr address) : this(address, "DropdownControl")
        {
        }

        public DropdownControl(IntPtr address, string className) : base(address, className)
        {
        }

        public void addItem(object value)
        {
            object[] objArray1 = new object[] { value };
            base.method_8("addItem", objArray1);
        }

        public void clearItems()
        {
            base.method_8("clearItems", Array.Empty<object>());
        }

        public static string defaultItemTextCallback(object val)
        {
            object[] objArray1 = new object[] { val };
            return MonoClass.smethod_12(TritonHs.MainAssemblyPath, "", "DropdownControl", "defaultItemTextCallback", objArray1);
        }

        public DropdownMenuItem findItem(object value)
        {
            object[] objArray1 = new object[] { value };
            return base.method_14<DropdownMenuItem>("findItem", objArray1);
        }

        public int findItemIndex(object value)
        {
            object[] objArray1 = new object[] { value };
            return base.method_11<int>("findItemIndex", objArray1);
        }

        public object getSelection()
        {
            return base.method_14<object>("getSelection", Array.Empty<object>());
        }

        public void hideMenu()
        {
            base.method_8("hideMenu", Array.Empty<object>());
        }

        public bool isMenuShown()
        {
            return base.method_11<bool>("isMenuShown", Array.Empty<object>());
        }

        public void layoutMenu()
        {
            base.method_8("layoutMenu", Array.Empty<object>());
        }

        public void onUserCancelled()
        {
            base.method_8("onUserCancelled", Array.Empty<object>());
        }

        public void onUserItemClicked(DropdownMenuItem item)
        {
            object[] objArray1 = new object[] { item };
            base.method_8("onUserItemClicked", objArray1);
        }

        public void onUserPressedButton()
        {
            base.method_8("onUserPressedButton", Array.Empty<object>());
        }

        public void onUserPressedSelection(DropdownMenuItem item)
        {
            object[] objArray1 = new object[] { item };
            base.method_8("onUserPressedSelection", objArray1);
        }

        public bool removeItem(object value)
        {
            object[] objArray1 = new object[] { value };
            return base.method_11<bool>("removeItem", objArray1);
        }

        public void setFontWithoutLocalization(FontDef fontDef)
        {
            object[] objArray1 = new object[] { fontDef };
            base.method_8("setFontWithoutLocalization", objArray1);
        }

        public void setSelection(object val)
        {
            object[] objArray1 = new object[] { val };
            base.method_8("setSelection", objArray1);
        }

        public void setSelectionToLastItem()
        {
            base.method_8("setSelectionToLastItem", Array.Empty<object>());
        }

        public void showMenu()
        {
            base.method_8("showMenu", Array.Empty<object>());
        }

        public void Start()
        {
            base.method_8("Start", Array.Empty<object>());
        }

        public UIBButton m_button
        {
            get
            {
                return base.method_3<UIBButton>("m_button");
            }
        }

        public PegUIElement m_cancelCatcher
        {
            get
            {
                return base.method_3<PegUIElement>("m_cancelCatcher");
            }
        }

        public List<DropdownMenuItem> m_items
        {
            get
            {
                Class267<DropdownMenuItem> class2 = base.method_3<Class267<DropdownMenuItem>>("m_items");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public MultiSliceElement m_menu
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_menu");
            }
        }

        public MultiSliceElement m_menuItemContainer
        {
            get
            {
                return base.method_3<MultiSliceElement>("m_menuItemContainer");
            }
        }

        public DropdownMenuItem m_menuItemTemplate
        {
            get
            {
                return base.method_3<DropdownMenuItem>("m_menuItemTemplate");
            }
        }

        public GameObject m_menuMiddle
        {
            get
            {
                return base.method_3<GameObject>("m_menuMiddle");
            }
        }

        public FontDef m_overrideFontNoLocalization
        {
            get
            {
                return base.method_3<FontDef>("m_overrideFontNoLocalization");
            }
        }

        public DropdownMenuItem m_selectedItem
        {
            get
            {
                return base.method_3<DropdownMenuItem>("m_selectedItem");
            }
        }
    }
}

