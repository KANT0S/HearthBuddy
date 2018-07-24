namespace Hearthbuddy.Windows
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;

    public class ProcessSelectorWindow : Window, IComponentConnector
    {
        private bool bool_0;
        internal Button button_0;
        internal ListBox listBox_0;
        [CompilerGenerated]
        private Process process_0;

        public ProcessSelectorWindow(Dictionary<Process, string> availableProcs)
        {
            this.InitializeComponent();
            foreach (KeyValuePair<Process, string> pair in availableProcs)
            {
                ListBoxItem item2 = new ListBoxItem();
                object[] objArray1 = new object[] { pair.Value, " [PID: ", pair.Key.Id, "]" };
                item2.Content = string.Concat(objArray1);
                item2.Tag = pair.Key;
                ListBoxItem newItem = item2;
                this.listBox_0.Items.Add(newItem);
            }
            if (this.listBox_0.Items.Count == 1)
            {
                this.listBox_0.SelectedItem = this.listBox_0.Items[0];
            }
            this.button_0.Focus();
            Keyboard.Focus(this.button_0);
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem selectedItem = this.listBox_0.SelectedItem as ListBoxItem;
            if (selectedItem == null)
            {
                MessageBox.Show("You must select a process from the list first!");
            }
            else
            {
                this.Selected = selectedItem.Tag as Process;
                base.DialogResult = true;
                base.Close();
            }
        }

        [GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this.bool_0)
            {
                this.bool_0 = true;
                Uri resourceLocator = new Uri("/Hearthbuddy;component/windows/processselectorwindow.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            if (connectionId != 1)
            {
                if (connectionId != 2)
                {
                    this.bool_0 = true;
                }
                else
                {
                    this.button_0 = (Button) target;
                    this.button_0.Click += new RoutedEventHandler(this.button_0_Click);
                }
            }
            else
            {
                this.listBox_0 = (ListBox) target;
            }
        }

        public Process Selected
        {
            [CompilerGenerated]
            get
            {
                return this.process_0;
            }
            [CompilerGenerated]
            set
            {
                this.process_0 = value;
            }
        }
    }
}

