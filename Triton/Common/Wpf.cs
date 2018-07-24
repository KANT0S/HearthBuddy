namespace Triton.Common
{
    using System;
    using System.Collections;
    using System.Runtime.InteropServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Controls.Primitives;
    using System.Windows.Data;

    public static class Wpf
    {
        public static T FindControlByName<T>(DependencyObject root, string name) where T: class
        {
            return (smethod_0(root, name) as T);
        }

        public static bool SetupCheckBoxBinding(DependencyObject xamlRoot, string controlName, string bindingName, BindingMode bindingMode, object bindingSource, IValueConverter converter = null)
        {
            CheckBox box = FindControlByName<CheckBox>(xamlRoot, controlName);
            if (box == null)
            {
                return false;
            }
            Binding binding = new Binding(bindingName) {
                Mode = bindingMode,
                Source = bindingSource,
                Converter = converter
            };
            box.SetBinding(ToggleButton.IsCheckedProperty, binding);
            return true;
        }

        public static bool SetupComboBoxItemsBinding(DependencyObject xamlRoot, string controlName, string bindingName, BindingMode bindingMode, object bindingSource, IValueConverter converter = null)
        {
            ComboBox box = FindControlByName<ComboBox>(xamlRoot, controlName);
            if (box == null)
            {
                return false;
            }
            Binding binding = new Binding(bindingName) {
                Mode = bindingMode,
                Source = bindingSource,
                Converter = converter
            };
            box.SetBinding(ItemsControl.ItemsSourceProperty, binding);
            return true;
        }

        public static bool SetupComboBoxSelectedItemBinding(DependencyObject xamlRoot, string controlName, string bindingName, BindingMode bindingMode, object bindingSource, IValueConverter converter = null)
        {
            ComboBox box = FindControlByName<ComboBox>(xamlRoot, controlName);
            if (box == null)
            {
                return false;
            }
            Binding binding = new Binding(bindingName) {
                Mode = bindingMode,
                Source = bindingSource,
                Converter = converter
            };
            box.SetBinding(Selector.SelectedItemProperty, binding);
            return true;
        }

        public static bool SetupLabelBinding(DependencyObject xamlRoot, string controlName, string bindingName, BindingMode bindingMode, object bindingSource, IValueConverter converter = null)
        {
            Label label = FindControlByName<Label>(xamlRoot, controlName);
            if (label == null)
            {
                return false;
            }
            Binding binding = new Binding(bindingName) {
                Mode = bindingMode,
                Source = bindingSource,
                Converter = converter
            };
            label.SetBinding(ContentControl.ContentProperty, binding);
            return true;
        }

        public static bool SetupListBoxItemsBinding(DependencyObject xamlRoot, string controlName, string bindingName, BindingMode bindingMode, object bindingSource, IValueConverter converter = null)
        {
            ListBox box = FindControlByName<ListBox>(xamlRoot, controlName);
            if (box == null)
            {
                return false;
            }
            Binding binding = new Binding(bindingName) {
                Mode = bindingMode,
                Source = bindingSource,
                Converter = converter
            };
            box.SetBinding(ItemsControl.ItemsSourceProperty, binding);
            return true;
        }

        public static bool SetupListBoxSelectedItemBinding(DependencyObject xamlRoot, string controlName, string bindingName, BindingMode bindingMode, object bindingSource, IValueConverter converter = null)
        {
            ListBox box = FindControlByName<ListBox>(xamlRoot, controlName);
            if (box == null)
            {
                return false;
            }
            Binding binding = new Binding(bindingName) {
                Mode = bindingMode,
                Source = bindingSource,
                Converter = converter
            };
            box.SetBinding(Selector.SelectedItemProperty, binding);
            return true;
        }

        public static bool SetupTextBoxBinding(DependencyObject xamlRoot, string controlName, string bindingName, BindingMode bindingMode, object bindingSource, IValueConverter converter = null)
        {
            TextBox box = FindControlByName<TextBox>(xamlRoot, controlName);
            if (box == null)
            {
                return false;
            }
            Binding binding = new Binding(bindingName) {
                Mode = bindingMode,
                Source = bindingSource,
                Converter = converter
            };
            box.SetBinding(TextBox.TextProperty, binding);
            return true;
        }

        private static DependencyObject smethod_0(DependencyObject dependencyObject_0, string string_0)
        {
            if (dependencyObject_0 == null)
            {
                return null;
            }
            DependencyObject obj2 = LogicalTreeHelper.FindLogicalNode(dependencyObject_0, string_0);
            if (obj2 != null)
            {
                return obj2;
            }
            IEnumerable children = LogicalTreeHelper.GetChildren(dependencyObject_0);
            if (children != null)
            {
                DependencyObject obj3;
                using (IEnumerator enumerator = children.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        obj2 = smethod_0(enumerator.Current as DependencyObject, string_0);
                        if (obj2 != null)
                        {
                            goto Label_0045;
                        }
                    }
                    goto Label_005F;
                Label_0045:
                    obj3 = obj2;
                }
                return obj3;
            }
        Label_005F:
            return null;
        }
    }
}

