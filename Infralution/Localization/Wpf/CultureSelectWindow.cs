namespace Infralution.Localization.Wpf
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class CultureSelectWindow : Window, IComponentConnector
    {
        private bool bool_0;
        internal ComboBox comboBox_0;

        public CultureSelectWindow()
        {
            this.InitializeComponent();
            List<CultureInfo> list = new List<CultureInfo> {
                new CultureInfo("de-DE"),
                new CultureInfo("fr-FR"),
                new CultureInfo("ru-RU"),
                new CultureInfo("tr-TR"),
                new CultureInfo("zh-Hans"),
                new CultureInfo("ko"),
                new CultureInfo("en-US"),
                new CultureInfo("es-ES"),
                new CultureInfo("it-IT")
            };
            list.Sort(new Class223());
            this.comboBox_0.ItemsSource = list;
            this.comboBox_0.SelectedItem = CultureManager1.UICulture;
        }

        private void comboBox_0_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CultureManager1.UICulture = this.comboBox_0.SelectedItem as CultureInfo;
        }

        [GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this.bool_0)
            {
                this.bool_0 = true;
                Uri resourceLocator = new Uri("/Hearthbuddy;component/localization/wpf/cultureselectwindow.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        [DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never), GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            if (connectionId == 1)
            {
                this.comboBox_0 = (ComboBox) target;
                this.comboBox_0.SelectionChanged += new SelectionChangedEventHandler(this.comboBox_0_SelectionChanged);
            }
            else
            {
                this.bool_0 = true;
            }
        }

        private class Class223 : Comparer<CultureInfo>
        {
            int Comparer<CultureInfo>.Compare(CultureInfo x, CultureInfo y)
            {
                return x.DisplayName.CompareTo(y.DisplayName);
            }
        }
    }
}

