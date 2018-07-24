namespace Hearthbuddy.Windows
{
    using Buddy.Coroutines;
    using GreyMagic;
    using log4net;
    using Microsoft.CSharp;
    using Microsoft.Win32;
    using ns2;
    using ns3;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Controls.Primitives;
    using System.Windows.Data;
    using System.Windows.Forms;
    using System.Windows.Interop;
    using System.Windows.Markup;
    using System.Windows.Threading;
    using Triton.Bot;
    using Triton.Bot.Settings;
    using Triton.Common;
    using Triton.Common.LogUtilities;
    using Triton.Game;
    using Triton.Game.Mapping;

    public class MainWindow : Window, IComponentConnector
    {
        private bool bool_0 = true;
        private bool bool_1;
        internal System.Windows.Controls.Button button_0;
        internal System.Windows.Controls.Button button_1;
        internal System.Windows.Controls.Button button_2;
        internal System.Windows.Controls.Button button_3;
        internal System.Windows.Controls.Button button_4;
        internal System.Windows.Controls.Button button_5;
        internal System.Windows.Controls.Button button_6;
        internal System.Windows.Controls.Button button_7;
        internal System.Windows.Controls.Button button_8;
        internal System.Windows.Controls.Button button_9;
        internal System.Windows.Controls.CheckBox checkBox_0;
        internal System.Windows.Controls.CheckBox checkBox_1;
        internal System.Windows.Controls.CheckBox checkBox_2;
        internal System.Windows.Controls.CheckBox checkBox_3;
        internal System.Windows.Controls.CheckBox checkBox_4;
        internal System.Windows.Controls.CheckBox checkBox_5;
        internal System.Windows.Controls.ComboBox comboBox_0;
        internal System.Windows.Controls.ComboBox comboBox_1;
        internal System.Windows.Controls.ComboBox comboBox_2;
        private DispatcherTimer dispatcherTimer_0;
        private DispatcherTimer dispatcherTimer_1;
        internal Grid grid_0;
        internal Grid grid_1;
        internal GridSplitter gridSplitter_0;
        private static readonly ILog ilog_0 = Triton.Common.LogUtilities.Logger.GetLoggerInstanceForType();
        internal System.Windows.Controls.Label label_0;
        internal System.Windows.Controls.Label label_1;
        internal System.Windows.Controls.ListBox listBox_0;
        private Mutex mutex_0;
        private Process process_0;
        internal System.Windows.Controls.RichTextBox richTextBox_0;
        internal RowDefinition rowDefinition_0;
        internal RowDefinition rowDefinition_1;
        internal RowDefinition rowDefinition_2;
        internal ScrollViewer scrollViewer_0;
        internal ScrollViewer scrollViewer_1;
        internal System.Windows.Controls.Primitives.StatusBar statusBar_0;
        private readonly Stopwatch stopwatch_0 = new Stopwatch();
        internal System.Windows.Controls.TabControl tabControl_0;
        internal System.Windows.Controls.TabControl tabControl_1;
        internal TabItem tabItem_0;
        internal TabItem tabItem_1;
        internal TabItem tabItem_2;
        internal TabItem tabItem_3;
        internal TabItem tabItem_4;
        internal TextBlock textBlock_0;
        internal TextBlock textBlock_1;
        internal TextBlock textBlock_2;
        internal System.Windows.Controls.TextBox textBox_0;
        internal System.Windows.Controls.TextBox textBox_1;
        internal System.Windows.Controls.TextBox textBox_2;
        internal System.Windows.Controls.TextBox textBox_3;
        internal System.Windows.Controls.TextBox textBox_4;

        public MainWindow()
        {
            this.InitializeComponent();
            Triton.Common.LogUtilities.Logger.AddWpfListener(this.scrollViewer_0, this.richTextBox_0);
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            Configuration.Instance.SaveAll();
            this.button_0.IsEnabled = false;
            this.comboBox_1.IsEnabled = false;
            this.comboBox_0.IsEnabled = false;
            this.checkBox_0.IsEnabled = false;
            this.listBox_0.IsEnabled = false;
            try
            {
                this.bool_0 = false;
                if (BotManager.IsRunning)
                {
                    BotManager.Stop();
                }
                else
                {
                    BotManager.Start();
                }
            }
            finally
            {
                this.bool_0 = true;
            }
            this.stopwatch_0.Restart();
        }

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            this.method_15();
            this.method_16(BotManager.CurrentBot);
        }

        private void button_2_Click(object sender, RoutedEventArgs e)
        {
            this.method_15();
            this.method_16(RoutineManager.CurrentRoutine);
        }

        private void button_3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Windows.Clipboard.SetText(Triton.Common.LogUtilities.Logger.FileName);
                ilog_0.DebugFormat("The log filename has been copied to the clipboard: {0}", Triton.Common.LogUtilities.Logger.FileName.Replace(Environment.UserName, "<Username>"));
            }
            catch (Exception exception)
            {
                ilog_0.Error("[Ui] An exception occurred:", exception);
            }
        }

        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), System.IO.Path.GetRandomFileName());
                Directory.CreateDirectory(path);
                System.IO.File.Copy(Triton.Common.LogUtilities.Logger.FileName, System.IO.Path.Combine(path, System.IO.Path.GetFileName(Triton.Common.LogUtilities.Logger.FileName)));
                string destinationArchiveFileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), System.IO.Path.GetRandomFileName().Replace(".", "")) + ".zip";
                ZipFile.CreateFromDirectory(path, destinationArchiveFileName);
                System.Windows.Clipboard.SetText(destinationArchiveFileName);
                ilog_0.DebugFormat("The log file has been zipped and the full filename has been copied to the clipboard: {0}", destinationArchiveFileName.Replace(Environment.UserName, "<Username>"));
            }
            catch (Exception exception)
            {
                ilog_0.Debug("The log file could not be compressed. You will have to manually compress it.", exception);
            }
        }

        private void button_5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Triton.Common.LogUtilities.Logger.Clear();
            }
            catch (Exception exception)
            {
                ilog_0.Error("[Ui] An exception occurred:", exception);
            }
        }

        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            IPlugin plugin = this.IPlugin_0;
            if (plugin != null)
            {
                if (plugin.IsEnabled)
                {
                    this.method_15();
                    this.method_16(plugin);
                }
                else
                {
                    ilog_0.InfoFormat("[PluginSettings_Click] The plugin must be enabled first.", Array.Empty<object>());
                }
            }
        }

        private void button_7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Class33 class2 = new Class33 {
                    string_0 = this.textBox_3.Text
                };
                if (!string.IsNullOrEmpty(class2.string_0))
                {
                    class2.string_1 = this.textBox_1.Text;
                    if (!string.IsNullOrEmpty(class2.string_1))
                    {
                        class2.list_0 = this.textBox_4.Text.Split(new char[] { '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                        Configuration.Instance.SaveAll();
                        ThreadPool.QueueUserWorkItem(new WaitCallback(class2.method_0));
                    }
                }
            }
            catch (Exception exception)
            {
                ilog_0.Error("[Ui] An exception occurred:", exception);
            }
        }

        private void button_8_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Class34 class2 = new Class34 {
                    string_0 = this.textBox_3.Text
                };
                try
                {
                    class2.string_1 = System.IO.File.ReadAllText(this.textBox_2.Text);
                }
                catch (Exception exception)
                {
                    ilog_0.Error(exception);
                    return;
                }
                class2.list_0 = this.textBox_4.Text.Split(new char[] { '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                if (!string.IsNullOrEmpty(class2.string_0) && !string.IsNullOrEmpty(class2.string_1))
                {
                    Configuration.Instance.SaveAll();
                    ThreadPool.QueueUserWorkItem(new WaitCallback(class2.method_0));
                }
            }
            catch (Exception exception2)
            {
                ilog_0.Error("[Ui] An exception occurred:", exception2);
            }
        }

        private void button_9_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
                bool? nullable = dialog.ShowDialog();
                if (nullable.HasValue && nullable.Value)
                {
                    DevSettings.Instance.FileName = dialog.FileName;
                }
            }
            catch (Exception exception)
            {
                ilog_0.Error("[Ui] An exception occurred:", exception);
            }
        }

        private void checkBox_0_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (BotManager.IsRunning)
                {
                    System.Windows.MessageBox.Show("Please Stop the current bot before trying to disable plugins.", "Hearthbuddy", MessageBoxButton.OK, MessageBoxImage.Hand);
                }
                else
                {
                    IPlugin plugin = this.IPlugin_0;
                    if (plugin == null)
                    {
                        System.Windows.MessageBox.Show("Please highlight the plugin you wish to enable or disable first, before clicking the checkbox.", "Hearthbuddy", MessageBoxButton.OK, MessageBoxImage.Hand);
                    }
                    else
                    {
                        using (TritonHs.AcquireFrame())
                        {
                            PluginManager.Enable(plugin);
                        }
                        MainSettings.Instance.EnabledPlugins = PluginManager.EnabledPlugins.Select<IPlugin, string>((Class25.<>9__18_0 ?? (Class25.<>9__18_0 = new Func<IPlugin, string>(Class25.<>9.method_5)))).ToList<string>();
                        Configuration.Instance.SaveAll();
                    }
                }
            }
            catch (Exception exception)
            {
                ilog_0.Error("[Ui] An exception occurred:", exception);
            }
        }

        private void checkBox_0_Unchecked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (BotManager.IsRunning)
                {
                    System.Windows.MessageBox.Show("Please Stop the current bot before trying to enable plugins.", "Hearthbuddy", MessageBoxButton.OK, MessageBoxImage.Hand);
                }
                else
                {
                    IPlugin plugin = this.IPlugin_0;
                    if (plugin == null)
                    {
                        System.Windows.MessageBox.Show("Please highlight the plugin you wish to enable or disable first, before clicking the checkbox.", "Hearthbuddy", MessageBoxButton.OK, MessageBoxImage.Hand);
                    }
                    else
                    {
                        using (TritonHs.AcquireFrame())
                        {
                            PluginManager.Disable(plugin);
                        }
                        MainSettings.Instance.EnabledPlugins = PluginManager.EnabledPlugins.Select<IPlugin, string>((Class25.<>9__17_0 ?? (Class25.<>9__17_0 = new Func<IPlugin, string>(Class25.<>9.method_4)))).ToList<string>();
                        Configuration.Instance.SaveAll();
                    }
                }
            }
            catch (Exception exception)
            {
                ilog_0.Error("[Ui] An exception occurred:", exception);
            }
        }

        private void checkBox_1_Checked(object sender, RoutedEventArgs e)
        {
            this.method_17();
        }

        private void checkBox_1_Unchecked(object sender, RoutedEventArgs e)
        {
            this.method_17();
        }

        private void checkBox_2_Checked(object sender, RoutedEventArgs e)
        {
            this.method_18();
        }

        private void checkBox_2_Unchecked(object sender, RoutedEventArgs e)
        {
            this.method_18();
        }

        private void checkBox_3_Checked(object sender, RoutedEventArgs e)
        {
            this.method_19();
        }

        private void checkBox_3_Unchecked(object sender, RoutedEventArgs e)
        {
            this.method_19();
        }

        private void checkBox_4_Checked(object sender, RoutedEventArgs e)
        {
            this.method_20();
        }

        private void checkBox_4_Unchecked(object sender, RoutedEventArgs e)
        {
            this.method_20();
        }

        private void comboBox_0_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                IBot selectedItem = this.comboBox_0.SelectedItem as IBot;
                BotManager.CurrentBot = selectedItem;
                if (selectedItem != null)
                {
                    MainSettings.Instance.LastBot = selectedItem.Name;
                }
                ilog_0.DebugFormat("Current bot set to {0}.", (selectedItem != null) ? selectedItem.Name : "(null)");
                Configuration.Instance.SaveAll();
                this.method_14();
            }
            catch (Exception exception)
            {
                ilog_0.Error("[Ui] An exception occurred:", exception);
            }
        }

        private void comboBox_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                IRoutine selectedItem = this.comboBox_1.SelectedItem as IRoutine;
                RoutineManager.CurrentRoutine = selectedItem;
                if (selectedItem != null)
                {
                    MainSettings.Instance.LastRoutine = selectedItem.Name;
                }
                ilog_0.DebugFormat("Current routine set to {0}.", (selectedItem != null) ? selectedItem.Name : "(null)");
                Configuration.Instance.SaveAll();
                this.method_14();
            }
            catch (Exception exception)
            {
                ilog_0.Error("[Ui] An exception occurred:", exception);
            }
        }

        private void comboBox_2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TritonHs.IsBotFullyLoaded)
            {
                ilog_0.WarnFormat("[SettingsWindow] Please restart the bot for the changes to take effect.", Array.Empty<object>());
            }
        }

        [GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this.bool_1)
            {
                this.bool_1 = true;
                Uri resourceLocator = new Uri("/Hearthbuddy;component/windows/mainwindow.xaml", UriKind.Relative);
                System.Windows.Application.LoadComponent(this, resourceLocator);
            }
        }

        private void listBox_0_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                IPlugin plugin = this.IPlugin_0;
                if (plugin == null)
                {
                    this.checkBox_0.IsChecked = false;
                    this.checkBox_0.IsEnabled = false;
                    this.button_6.IsEnabled = false;
                }
                else
                {
                    this.textBlock_0.Text = plugin.Author;
                    this.textBlock_1.Text = plugin.Version;
                    this.textBlock_2.Text = plugin.Description;
                    this.checkBox_0.IsEnabled = true;
                    this.checkBox_0.IsChecked = new bool?(plugin.IsEnabled);
                    this.button_6.IsEnabled = true;
                }
            }
            catch (Exception exception)
            {
                ilog_0.Error("[Ui] An exception occurred:", exception);
            }
        }

        private IntPtr method_0(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2, ref bool bool_2)
        {
            if (MainSettings.Instance.AllowExternalAccess)
            {
                if (int_0 == 0x400)
                {
                    bool_2 = true;
                    if (MainSettings.Instance.AccessToken != 0)
                    {
                        return (IntPtr) 1;
                    }
                    ilog_0.InfoFormat("[WndProc] The access token has been assigned.", Array.Empty<object>());
                    MainSettings.Instance.AccessToken = intptr_2.ToInt32();
                    return IntPtr.Zero;
                }
                if (int_0 == 0x401)
                {
                    bool_2 = true;
                    if (BotManager.IsRunning)
                    {
                        return (IntPtr) 2;
                    }
                    if (intptr_2.ToInt32() != MainSettings.Instance.AccessToken)
                    {
                        return (IntPtr) 1;
                    }
                    ilog_0.InfoFormat("[WndProc] An external close request has been processed. Now closing the program.", Array.Empty<object>());
                    base.Dispatcher.Invoke(Class25.<>9__2_0 ?? (Class25.<>9__2_0 = new Action(Class25.<>9.method_0)));
                    return IntPtr.Zero;
                }
                if (int_0 == 0x402)
                {
                    bool_2 = true;
                    if (intptr_1.ToInt32() == 0)
                    {
                        if (!TritonHs.IsBotFullyLoaded)
                        {
                            return IntPtr.Zero;
                        }
                        return (IntPtr) 1;
                    }
                    if (intptr_1.ToInt32() == 1)
                    {
                        if (!BotManager.IsRunning)
                        {
                            return IntPtr.Zero;
                        }
                        return (IntPtr) 1;
                    }
                    if (intptr_1.ToInt32() == 2)
                    {
                        if (!BotManager.ClientFrozen)
                        {
                            return IntPtr.Zero;
                        }
                        return (IntPtr) 1;
                    }
                    if (intptr_1.ToInt32() == 3)
                    {
                        return (IntPtr) TritonHs.Memory.Process.Id;
                    }
                }
            }
            return IntPtr.Zero;
        }

        private void method_1(object sender, RoutedEventArgs e)
        {
            try
            {
                base.Title = "Hearthbuddy[" + Assembly.GetEntryAssembly().GetName().Version + "]";
                System.Windows.Data.Binding binding = new System.Windows.Data.Binding("WindowX") {
                    Source = MainSettings.Instance,
                    Mode = BindingMode.TwoWay
                };
                base.SetBinding(Window.LeftProperty, binding);
                System.Windows.Data.Binding binding2 = new System.Windows.Data.Binding("WindowY") {
                    Source = MainSettings.Instance,
                    Mode = BindingMode.TwoWay
                };
                base.SetBinding(Window.TopProperty, binding2);
                System.Windows.Data.Binding binding3 = new System.Windows.Data.Binding("WindowWidth") {
                    Source = MainSettings.Instance,
                    Mode = BindingMode.TwoWay
                };
                base.SetBinding(FrameworkElement.WidthProperty, binding3);
                System.Windows.Data.Binding binding4 = new System.Windows.Data.Binding("WindowHeight") {
                    Source = MainSettings.Instance,
                    Mode = BindingMode.TwoWay
                };
                base.SetBinding(FrameworkElement.HeightProperty, binding4);
                MainSettings.Instance.LoadRowDefinitions(this.rowDefinition_0, this.rowDefinition_1, this.rowDefinition_2);
                this.method_3();
                this.textBox_0.Text = Triton.Common.LogUtilities.Logger.FileName;
                this.method_17();
                this.method_18();
                this.method_19();
                this.method_20();
            }
            catch (Exception exception)
            {
                ilog_0.Error("[Ui] An exception occurred.", exception);
            }
        }

        private void method_10(IBot ibot_0)
        {
            base.Dispatcher.BeginInvoke(new Action(this.method_33), Array.Empty<object>());
            if (this.bool_0)
            {
                base.Dispatcher.BeginInvoke(new Action(this.method_34), Array.Empty<object>());
            }
        }

        private void method_11(IBot ibot_0)
        {
            base.Dispatcher.BeginInvoke(new Action(this.method_35), Array.Empty<object>());
            if (this.bool_0)
            {
                base.Dispatcher.BeginInvoke(new Action(this.method_36), Array.Empty<object>());
            }
        }

        private void method_12(object sender, CancelEventArgs e)
        {
            try
            {
                if (BotManager.IsRunning)
                {
                    ilog_0.ErrorFormat("Please wait for the current bot to stop before closing the program.", Array.Empty<object>());
                    e.Cancel = true;
                }
                else if (!this.button_0.IsEnabled)
                {
                    if (TritonHs.IsBotFullyLoaded)
                    {
                        ilog_0.ErrorFormat("Please wait for the current bot to stop before closing the program.", Array.Empty<object>());
                        e.Cancel = true;
                    }
                }
                else
                {
                    TritonHs.bool_0 = true;
                }
            }
            catch (Exception exception)
            {
                ilog_0.Error("[Ui] An exception occurred:", exception);
            }
        }

        private void method_13(object sender, EventArgs e)
        {
            Class12.smethod_0();
            MainSettings.Instance.SaveRowDefinitions(this.rowDefinition_0, this.rowDefinition_1, this.rowDefinition_2);
            PluginManager.Deinitialize();
            RoutineManager.Deinitialize();
            BotManager.Deinitialize();
            Configuration.Instance.SaveAll();
            foreach (Window window in System.Windows.Application.Current.Windows)
            {
                if (window.IsVisible)
                {
                    window.Close();
                }
            }
            if (this.mutex_0 != null)
            {
                this.mutex_0.Dispose();
                this.mutex_0 = null;
            }
            if (this.process_0 != null)
            {
                this.process_0.Dispose();
                this.process_0 = null;
            }
        }

        private void method_14()
        {
            foreach (TabItem item2 in (IEnumerable) this.tabControl_1.Items)
            {
                Class32 class2 = new Class32();
                IBot tag = item2.Tag as IBot;
                if (tag != null)
                {
                    item2.Visibility = (this.comboBox_0.SelectedItem == tag) ? Visibility.Visible : Visibility.Collapsed;
                }
                IRoutine routine = item2.Tag as IRoutine;
                if (routine != null)
                {
                    item2.Visibility = (this.comboBox_1.SelectedItem == routine) ? Visibility.Visible : Visibility.Collapsed;
                }
                class2.iplugin_0 = item2.Tag as IPlugin;
                if (class2.iplugin_0 != null)
                {
                    IPlugin plugin = PluginManager.Plugins.First<IPlugin>(new Func<IPlugin, bool>(class2.method_0));
                    item2.Visibility = plugin.IsEnabled ? Visibility.Visible : Visibility.Collapsed;
                }
            }
            TabItem selectedItem = this.tabControl_1.SelectedItem as TabItem;
            if ((selectedItem != null) && (selectedItem.Visibility == Visibility.Collapsed))
            {
                this.tabControl_1.SelectedIndex = 0;
            }
        }

        private void method_15()
        {
            using (IEnumerator enumerator = ((IEnumerable) this.tabControl_0.Items).GetEnumerator())
            {
                TabItem current;
                while (enumerator.MoveNext())
                {
                    current = (TabItem) enumerator.Current;
                    if (current.Header.ToString().Equals("Settings", StringComparison.InvariantCulture))
                    {
                        goto Label_0042;
                    }
                }
                return;
            Label_0042:
                this.tabControl_0.SelectedItem = current;
            }
        }

        private void method_16(object object_0)
        {
            IEnumerator enumerator;
            IAuthored authored = object_0 as IAuthored;
            bool flag = false;
            if ((object_0 is IConfigurable) && (authored != null))
            {
                using (enumerator = ((IEnumerable) this.tabControl_1.Items).GetEnumerator())
                {
                    TabItem current;
                    while (enumerator.MoveNext())
                    {
                        current = (TabItem) enumerator.Current;
                        if (current.Header.ToString().Equals(authored.Name, StringComparison.InvariantCulture))
                        {
                            goto Label_0057;
                        }
                    }
                    goto Label_007B;
                Label_0057:
                    this.tabControl_1.SelectedItem = current;
                    flag = true;
                }
            }
        Label_007B:
            if (!flag)
            {
                using (enumerator = ((IEnumerable) this.tabControl_1.Items).GetEnumerator())
                {
                    TabItem item2;
                    while (enumerator.MoveNext())
                    {
                        item2 = (TabItem) enumerator.Current;
                        if (item2.Header.ToString().Equals("Main", StringComparison.InvariantCulture))
                        {
                            goto Label_00C2;
                        }
                    }
                    return;
                Label_00C2:
                    this.tabControl_1.SelectedItem = item2;
                }
            }
        }

        private void method_17()
        {
            if (this.tabItem_3 != null)
            {
                if (MainSettings.Instance.ShowDevTab)
                {
                    this.tabItem_3.Visibility = Visibility.Visible;
                }
                else
                {
                    this.tabItem_3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void method_18()
        {
            if (this.tabItem_4 != null)
            {
                if (MainSettings.Instance.ShowToolsTab)
                {
                    this.tabItem_4.Visibility = Visibility.Visible;
                }
                else
                {
                    this.tabItem_4.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void method_19()
        {
            if (this.tabItem_1 != null)
            {
                if (MainSettings.Instance.ShowConfigurationTab)
                {
                    this.tabItem_1.Visibility = Visibility.Visible;
                }
                else
                {
                    this.tabItem_1.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void method_2(object object_0)
        {
            IConfigurable configurable = object_0 as IConfigurable;
            IAuthored authored = object_0 as IAuthored;
            if ((configurable != null) && (authored != null))
            {
                System.Windows.Controls.UserControl control = configurable.Control;
                if (control != null)
                {
                    TabItem newItem = new TabItem {
                        Header = authored.Name,
                        Content = control,
                        Tag = object_0
                    };
                    this.tabControl_1.Items.Add(newItem);
                }
            }
        }

        private void method_20()
        {
            if (this.tabItem_2 != null)
            {
                if (MainSettings.Instance.ShowGlobalTab)
                {
                    this.tabItem_2.Visibility = Visibility.Visible;
                }
                else
                {
                    this.tabItem_2.Visibility = Visibility.Collapsed;
                }
            }
        }

        [CompilerGenerated]
        private void method_21(object object_0)
        {
            try
            {
                base.Dispatcher.Invoke(new Action(this.method_22));
                if (this.process_0 == null)
                {
                    base.Dispatcher.BeginInvoke(new Action(this.Close), Array.Empty<object>());
                }
                else
                {
                    string str;
                    if (!TritonHs.smethod_0(this.process_0, new TritonHs.Delegate6(Class12.smethod_4), out str))
                    {
                        ilog_0.ErrorFormat(str, Array.Empty<object>());
                        System.Windows.MessageBox.Show(str, "Error", MessageBoxButton.OK, MessageBoxImage.Hand);
                        base.Dispatcher.BeginInvoke(new Action(this.Close), Array.Empty<object>());
                    }
                    else
                    {
                        int version;
                        int clientChangelist;
                        FrameLock @lock;
                        TritonHs.Memory.ProcessExited += (Class25.<>9__12_2 ?? (Class25.<>9__12_2 = new EventHandler(Class25.<>9.method_1)));
                        TritonHs.Memory.Executor.FrameDropWaitTime = 0x3a98;
                        TritonHs.Memory.Executor.ExecuteWaitTime = 0x3a98;
                        TritonHs.Memory.DisableCache();
                        TritonHs.Memory.ClearCache();
                        using (@lock = TritonHs.AcquireFrame())
                        {
                            version = Triton.Game.Mapping.Version.version;
                            clientChangelist = Triton.Game.Mapping.Version.clientChangelist;
                        }
                        if ((version == 0x2f13L) && (clientChangelist == 0x2da5bL))
                        {
                            ilog_0.InfoFormat("Hearthstone client version ({0}, {1})", version, clientChangelist);
                            new Coroutine(Class25.<>9__12_3 ?? (Class25.<>9__12_3 = new Func<Task>(Class25.<>9.method_2)));
                            Configuration.Instance.AddSettings(MainSettings.Instance);
                            Configuration.Instance.AddSettings(DevSettings.Instance);
                            Configuration.Instance.SaveAll();
                            base.Dispatcher.Invoke(new Action(this.method_23));
                            BotManager.PreStart += new BotManager.BotEvent(this.method_11);
                            BotManager.PostStop += new BotManager.BotEvent(this.method_10);
                            BotManager.Load();
                            base.Dispatcher.Invoke(new Action(this.method_24));
                            this.comboBox_0.Dispatcher.BeginInvoke(new Action(this.method_25), Array.Empty<object>());
                            BotManager.OnBotChanged += new EventHandler<BotChangedEventArgs>(this.method_6);
                            RoutineManager.Load();
                            base.Dispatcher.Invoke(new Action(this.method_26));
                            this.comboBox_1.Dispatcher.BeginInvoke(new Action(this.method_27), Array.Empty<object>());
                            RoutineManager.OnRoutineChanged += new EventHandler<RoutineChangedEventArgs>(this.method_7);
                            PluginManager.Load();
                            foreach (IPlugin plugin in PluginManager.Plugins)
                            {
                                if (MainSettings.Instance.EnabledPlugins.Contains(plugin.Name))
                                {
                                    using (@lock = TritonHs.AcquireFrame())
                                    {
                                        PluginManager.Enable(plugin);
                                    }
                                    Thread.Sleep(20);
                                }
                                else
                                {
                                    using (@lock = TritonHs.AcquireFrame())
                                    {
                                        PluginManager.Disable(plugin);
                                    }
                                    Thread.Sleep(20);
                                }
                            }
                            this.listBox_0.Dispatcher.Invoke<IEnumerable>(new Func<IEnumerable>(this.method_28), DispatcherPriority.Normal);
                            base.Dispatcher.Invoke(new Action(this.method_29));
                            PluginManager.PluginEnabled += new PluginManager.PluginEvent(this.method_5);
                            PluginManager.PluginDisabled += new PluginManager.PluginEvent(this.method_4);
                            ilog_0.InfoFormat("{0}Please read the following guide before using this program:{0}https://www.thebuddyforum.com/hearthbuddy-forum/210230-hearthbuddy-bm-release-thread.html", Environment.NewLine);
                            base.Dispatcher.Invoke(new Action(this.method_30));
                            base.Dispatcher.Invoke(new Action(this.method_31));
                            this.stopwatch_0.Restart();
                            RoutineManager.OnRoutineChanged += new EventHandler<RoutineChangedEventArgs>(this.method_7);
                            BotManager.OnBotChanged += new EventHandler<BotChangedEventArgs>(this.method_6);
                            TritonHs.IsBotFullyLoaded = true;
                            Hotkeys.Register("BotManager.StartStop", Keys.S, ModifierKeys.Shift | ModifierKeys.Alt, Class25.<>9__12_17 ?? (Class25.<>9__12_17 = new Action<Hotkey>(Class25.<>9.method_3)));
                            if (CommandLine.Arguments.Exists("autostart"))
                            {
                                BotManager.Start();
                            }
                        }
                        else
                        {
                            object[] args = new object[] { version, clientChangelist, 0x2f13, 0x2da5b };
                            str = string.Format("This client version ({0}, {1}) is unsupported. Hearthbuddy currently supports client version ({2}, {3}). Please check the forums for more information: https://www.thebuddyforum.com/hearthbuddy-forum/", args);
                            ilog_0.ErrorFormat(str, Array.Empty<object>());
                            System.Windows.MessageBox.Show(str, "Error", MessageBoxButton.OK, MessageBoxImage.Hand);
                            base.Dispatcher.BeginInvoke(new Action(this.Close), Array.Empty<object>());
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                ilog_0.Error("[OnStartup] A top-level exception has been caught.", exception);
            }
        }

        [CompilerGenerated]
        private void method_22()
        {
            if (!Class9.smethod_2(out this.mutex_0, out this.process_0))
            {
                System.Windows.MessageBox.Show(string.Format("Could not attach to a Hearthstone process. Please make sure an available Hearthstone process is running.{0}{0}Hearthbuddy will now close.", Environment.NewLine), "Hearthbuddy", MessageBoxButton.OK, MessageBoxImage.Hand);
                ilog_0.Error("Could not attach to a Hearthstone process. Please make sure an available Hearthstone process is running.");
            }
            else
            {
                this.dispatcherTimer_0 = new DispatcherTimer(TimeSpan.FromSeconds(1.0), DispatcherPriority.Normal, new EventHandler(this.method_9), base.Dispatcher);
                this.dispatcherTimer_0.Start();
            }
        }

        [CompilerGenerated]
        private void method_23()
        {
            this.tabItem_0.DataContext = GlobalSettings.Instance;
        }

        [CompilerGenerated]
        private void method_24()
        {
            foreach (IBot bot in BotManager.Bots)
            {
                this.method_2(bot);
            }
        }

        [CompilerGenerated]
        private void method_25()
        {
            List<IBot> bots = BotManager.Bots;
            this.comboBox_0.ItemsSource = bots;
            if (CommandLine.Arguments.Exists("bot"))
            {
                Class26 class2 = new Class26 {
                    string_0 = CommandLine.Arguments.Single("bot")
                };
                IBot bot = bots.FirstOrDefault<IBot>(new Func<IBot, bool>(class2.method_0));
                if (bot != null)
                {
                    this.comboBox_0.SelectedItem = bot;
                }
            }
            else if (!string.IsNullOrEmpty(MainSettings.Instance.LastBot))
            {
                Class27 class3 = new Class27 {
                    string_0 = MainSettings.Instance.LastBot
                };
                IBot bot2 = bots.FirstOrDefault<IBot>(new Func<IBot, bool>(class3.method_0));
                if (bot2 != null)
                {
                    this.comboBox_0.SelectedItem = bot2;
                }
            }
            if (this.comboBox_0.SelectedItem == null)
            {
                this.comboBox_0.SelectedItem = bots.FirstOrDefault<IBot>();
            }
            this.method_14();
        }

        [CompilerGenerated]
        private void method_26()
        {
            foreach (IRoutine routine in RoutineManager.Routines)
            {
                this.method_2(routine);
            }
        }

        [CompilerGenerated]
        private void method_27()
        {
            List<IRoutine> routines = RoutineManager.Routines;
            this.comboBox_1.ItemsSource = routines;
            if (CommandLine.Arguments.Exists("routine"))
            {
                Class28 class2 = new Class28 {
                    string_0 = CommandLine.Arguments.Single("routine")
                };
                IRoutine routine = routines.FirstOrDefault<IRoutine>(new Func<IRoutine, bool>(class2.method_0));
                if (routine != null)
                {
                    this.comboBox_1.SelectedItem = routine;
                }
            }
            else if (!string.IsNullOrEmpty(MainSettings.Instance.LastRoutine))
            {
                Class29 class3 = new Class29 {
                    string_0 = MainSettings.Instance.LastRoutine
                };
                IRoutine routine2 = routines.FirstOrDefault<IRoutine>(new Func<IRoutine, bool>(class3.method_0));
                if (routine2 != null)
                {
                    this.comboBox_1.SelectedItem = routine2;
                }
            }
            if (this.comboBox_1.SelectedItem == null)
            {
                this.comboBox_1.SelectedItem = routines.FirstOrDefault<IRoutine>();
            }
            this.method_14();
        }

        [CompilerGenerated]
        private IEnumerable method_28()
        {
            return (this.listBox_0.ItemsSource = PluginManager.Plugins);
        }

        [CompilerGenerated]
        private void method_29()
        {
            foreach (IPlugin plugin in PluginManager.Plugins)
            {
                this.method_2(plugin);
            }
            this.method_14();
        }

        private void method_3()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_21));
        }

        [CompilerGenerated]
        private void method_30()
        {
            this.button_0.IsEnabled = true;
            this.comboBox_0.IsEnabled = true;
            this.comboBox_1.IsEnabled = true;
            this.button_1.IsEnabled = true;
            this.button_2.IsEnabled = true;
        }

        [CompilerGenerated]
        private void method_31()
        {
            this.dispatcherTimer_1 = new DispatcherTimer(TimeSpan.FromMilliseconds(1000.0), DispatcherPriority.Normal, new EventHandler(this.method_8), base.Dispatcher);
            this.dispatcherTimer_1.Start();
        }

        [CompilerGenerated]
        private void method_32()
        {
            try
            {
                TritonHs.GuiTick(this);
            }
            catch (Exception exception)
            {
                ilog_0.Debug("[Ui] An exception was caught in BotGuiTimer:", exception);
            }
        }

        [CompilerGenerated]
        private void method_33()
        {
            this.stopwatch_0.Restart();
        }

        [CompilerGenerated]
        private void method_34()
        {
            this.button_0.IsEnabled = false;
            this.comboBox_1.IsEnabled = false;
            this.comboBox_0.IsEnabled = false;
            this.checkBox_0.IsEnabled = false;
            this.listBox_0.IsEnabled = false;
        }

        [CompilerGenerated]
        private void method_35()
        {
            this.stopwatch_0.Restart();
        }

        [CompilerGenerated]
        private void method_36()
        {
            this.button_0.IsEnabled = false;
            this.comboBox_1.IsEnabled = false;
            this.comboBox_0.IsEnabled = false;
            this.checkBox_0.IsEnabled = false;
            this.listBox_0.IsEnabled = false;
        }

        private void method_4(IPlugin iplugin_0)
        {
            base.Dispatcher.BeginInvoke(new Action(this.method_14), Array.Empty<object>());
        }

        private void method_5(IPlugin iplugin_0)
        {
            base.Dispatcher.BeginInvoke(new Action(this.method_14), Array.Empty<object>());
        }

        private void method_6(object sender, BotChangedEventArgs e)
        {
            Class30 class2 = new Class30 {
                mainWindow_0 = this,
                botChangedEventArgs_0 = e
            };
            base.Dispatcher.BeginInvoke(new Action(class2.method_0), Array.Empty<object>());
        }

        private void method_7(object sender, RoutineChangedEventArgs e)
        {
            Class31 class2 = new Class31 {
                mainWindow_0 = this,
                routineChangedEventArgs_0 = e
            };
            base.Dispatcher.BeginInvoke(new Action(class2.method_0), Array.Empty<object>());
        }

        private void method_8(object sender, EventArgs e)
        {
            base.Dispatcher.BeginInvoke(new Action(this.method_32), Array.Empty<object>());
        }

        private void method_9(object sender, EventArgs e)
        {
            if (this.stopwatch_0.IsRunning && (this.stopwatch_0.ElapsedMilliseconds >= 0xbb8L))
            {
                this.button_0.IsEnabled = true;
                bool flag = !BotManager.IsRunning;
                this.comboBox_1.IsEnabled = flag;
                this.comboBox_0.IsEnabled = flag;
                this.listBox_0.IsEnabled = flag;
                this.checkBox_0.IsEnabled = flag;
                this.button_0.Content = !flag ? "Stop" : "Start";
            }
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            try
            {
                base.OnSourceInitialized(e);
                (PresentationSource.FromVisual(this) as HwndSource).AddHook(new HwndSourceHook(this.method_0));
            }
            catch (Exception exception)
            {
                ilog_0.ErrorFormat("[OnSourceInitialized] {0}.", exception);
                throw;
            }
        }

        [AsyncStateMachine(typeof(}z8SxfnuDFFA=$1\.NY\]V~)\]d))]
        private static Task smethod_0()
        {
            Struct3 struct2;
            struct2.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
            struct2.int_0 = -1;
            struct2.asyncTaskMethodBuilder_0.Start<Struct3>(ref struct2);
            return struct2.asyncTaskMethodBuilder_0.Task;
        }

        private static void smethod_1(string string_0, string string_1, IEnumerable<string> ienumerable_0)
        {
            try
            {
                using (CSharpCodeProvider provider = new CSharpCodeProvider())
                {
                    CompilerParameters options = new CompilerParameters {
                        GenerateExecutable = false,
                        GenerateInMemory = true
                    };
                    foreach (string str in ienumerable_0)
                    {
                        options.ReferencedAssemblies.Add(str);
                    }
                    string[] sources = new string[] { string_1 };
                    CompilerResults results = provider.CompileAssemblyFromSource(options, sources);
                    if (results.Errors.Count > 0)
                    {
                        StringBuilder builder = new StringBuilder();
                        foreach (CompilerError error in results.Errors)
                        {
                            builder.AppendFormat(string.Concat(new object[] { "Line number ", error.Line, ", Error Number: ", error.ErrorNumber, ", '", error.ErrorText, ";" }), Array.Empty<object>());
                            builder.AppendLine();
                        }
                        throw new Exception(builder.ToString());
                    }
                    System.Type type = results.CompiledAssembly.GetType(string_0);
                    object obj2 = Activator.CreateInstance(type);
                    object message = type.GetMethod("Execute").Invoke(obj2, new object[0]);
                    if (message != null)
                    {
                        ilog_0.Info(message);
                    }
                }
            }
            catch (Exception exception)
            {
                ilog_0.Error("[Ui] An exception occurred:", exception);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    ((MainWindow) target).Closed += new EventHandler(this.method_13);
                    ((MainWindow) target).Loaded += new RoutedEventHandler(this.method_1);
                    ((MainWindow) target).Closing += new CancelEventHandler(this.method_12);
                    return;

                case 2:
                    this.grid_0 = (Grid) target;
                    return;

                case 3:
                    this.button_0 = (System.Windows.Controls.Button) target;
                    this.button_0.Click += new RoutedEventHandler(this.button_0_Click);
                    return;

                case 4:
                    this.comboBox_0 = (System.Windows.Controls.ComboBox) target;
                    this.comboBox_0.SelectionChanged += new SelectionChangedEventHandler(this.comboBox_0_SelectionChanged);
                    return;

                case 5:
                    this.comboBox_1 = (System.Windows.Controls.ComboBox) target;
                    this.comboBox_1.SelectionChanged += new SelectionChangedEventHandler(this.comboBox_1_SelectionChanged);
                    return;

                case 6:
                    this.button_1 = (System.Windows.Controls.Button) target;
                    this.button_1.Click += new RoutedEventHandler(this.button_1_Click);
                    return;

                case 7:
                    this.button_2 = (System.Windows.Controls.Button) target;
                    this.button_2.Click += new RoutedEventHandler(this.button_2_Click);
                    return;

                case 8:
                    this.grid_1 = (Grid) target;
                    return;

                case 9:
                    this.rowDefinition_0 = (RowDefinition) target;
                    return;

                case 10:
                    this.rowDefinition_1 = (RowDefinition) target;
                    return;

                case 11:
                    this.rowDefinition_2 = (RowDefinition) target;
                    return;

                case 12:
                    this.gridSplitter_0 = (GridSplitter) target;
                    return;

                case 13:
                    this.textBox_0 = (System.Windows.Controls.TextBox) target;
                    return;

                case 14:
                    this.button_3 = (System.Windows.Controls.Button) target;
                    this.button_3.Click += new RoutedEventHandler(this.button_3_Click);
                    return;

                case 15:
                    this.button_4 = (System.Windows.Controls.Button) target;
                    this.button_4.Click += new RoutedEventHandler(this.button_4_Click);
                    return;

                case 0x10:
                    this.button_5 = (System.Windows.Controls.Button) target;
                    this.button_5.Click += new RoutedEventHandler(this.button_5_Click);
                    return;

                case 0x11:
                    this.scrollViewer_0 = (ScrollViewer) target;
                    return;

                case 0x12:
                    this.richTextBox_0 = (System.Windows.Controls.RichTextBox) target;
                    return;

                case 0x13:
                    this.statusBar_0 = (System.Windows.Controls.Primitives.StatusBar) target;
                    return;

                case 20:
                    this.label_0 = (System.Windows.Controls.Label) target;
                    return;

                case 0x15:
                    this.label_1 = (System.Windows.Controls.Label) target;
                    return;

                case 0x16:
                    this.tabControl_0 = (System.Windows.Controls.TabControl) target;
                    return;

                case 0x17:
                    this.listBox_0 = (System.Windows.Controls.ListBox) target;
                    this.listBox_0.SelectionChanged += new SelectionChangedEventHandler(this.listBox_0_SelectionChanged);
                    return;

                case 0x18:
                    this.textBlock_0 = (TextBlock) target;
                    return;

                case 0x19:
                    this.textBlock_1 = (TextBlock) target;
                    return;

                case 0x1a:
                    this.checkBox_0 = (System.Windows.Controls.CheckBox) target;
                    this.checkBox_0.Checked += new RoutedEventHandler(this.checkBox_0_Checked);
                    this.checkBox_0.Unchecked += new RoutedEventHandler(this.checkBox_0_Unchecked);
                    return;

                case 0x1b:
                    this.button_6 = (System.Windows.Controls.Button) target;
                    this.button_6.Click += new RoutedEventHandler(this.button_6_Click);
                    return;

                case 0x1c:
                    this.scrollViewer_1 = (ScrollViewer) target;
                    return;

                case 0x1d:
                    this.textBlock_2 = (TextBlock) target;
                    return;

                case 30:
                    this.tabItem_0 = (TabItem) target;
                    return;

                case 0x1f:
                    this.tabControl_1 = (System.Windows.Controls.TabControl) target;
                    return;

                case 0x20:
                    this.tabItem_1 = (TabItem) target;
                    return;

                case 0x21:
                    this.tabItem_2 = (TabItem) target;
                    return;

                case 0x22:
                    this.comboBox_2 = (System.Windows.Controls.ComboBox) target;
                    this.comboBox_2.SelectionChanged += new SelectionChangedEventHandler(this.comboBox_2_SelectionChanged);
                    return;

                case 0x23:
                    this.checkBox_1 = (System.Windows.Controls.CheckBox) target;
                    this.checkBox_1.Checked += new RoutedEventHandler(this.checkBox_1_Checked);
                    this.checkBox_1.Unchecked += new RoutedEventHandler(this.checkBox_1_Unchecked);
                    return;

                case 0x24:
                    this.checkBox_2 = (System.Windows.Controls.CheckBox) target;
                    this.checkBox_2.Checked += new RoutedEventHandler(this.checkBox_2_Checked);
                    this.checkBox_2.Unchecked += new RoutedEventHandler(this.checkBox_2_Unchecked);
                    return;

                case 0x25:
                    this.checkBox_3 = (System.Windows.Controls.CheckBox) target;
                    this.checkBox_3.Checked += new RoutedEventHandler(this.checkBox_3_Checked);
                    this.checkBox_3.Unchecked += new RoutedEventHandler(this.checkBox_3_Unchecked);
                    return;

                case 0x26:
                    this.checkBox_4 = (System.Windows.Controls.CheckBox) target;
                    this.checkBox_4.Checked += new RoutedEventHandler(this.checkBox_4_Checked);
                    this.checkBox_4.Unchecked += new RoutedEventHandler(this.checkBox_4_Unchecked);
                    return;

                case 0x27:
                    this.checkBox_5 = (System.Windows.Controls.CheckBox) target;
                    return;

                case 40:
                    this.tabItem_3 = (TabItem) target;
                    return;

                case 0x29:
                    this.textBox_1 = (System.Windows.Controls.TextBox) target;
                    return;

                case 0x2a:
                    this.textBox_2 = (System.Windows.Controls.TextBox) target;
                    return;

                case 0x2b:
                    this.textBox_3 = (System.Windows.Controls.TextBox) target;
                    return;

                case 0x2c:
                    this.button_7 = (System.Windows.Controls.Button) target;
                    this.button_7.Click += new RoutedEventHandler(this.button_7_Click);
                    return;

                case 0x2d:
                    this.button_8 = (System.Windows.Controls.Button) target;
                    this.button_8.Click += new RoutedEventHandler(this.button_8_Click);
                    return;

                case 0x2e:
                    this.textBox_4 = (System.Windows.Controls.TextBox) target;
                    return;

                case 0x2f:
                    this.button_9 = (System.Windows.Controls.Button) target;
                    this.button_9.Click += new RoutedEventHandler(this.button_9_Click);
                    return;

                case 0x30:
                    this.tabItem_4 = (TabItem) target;
                    return;
            }
            this.bool_1 = true;
        }

        private IPlugin IPlugin_0
        {
            get
            {
                return (this.listBox_0.SelectedItem as IPlugin);
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class Class25
        {
            public static readonly MainWindow.Class25 <>9 = new MainWindow.Class25();
            public static Action<Hotkey> <>9__12_17;
            public static EventHandler <>9__12_2;
            public static Func<Task> <>9__12_3;
            public static Func<IPlugin, string> <>9__17_0;
            public static Func<IPlugin, string> <>9__18_0;
            public static Action <>9__2_0;

            internal void method_0()
            {
                System.Windows.Application.Current.Shutdown();
            }

            internal void method_1(object sender, EventArgs e)
            {
                MainWindow.ilog_0.Info("[ProcessExited] The game process has closed. Hearthbuddy will now close.");
                Class12.smethod_0();
                Environment.Exit(0);
            }

            internal Task method_2()
            {
                return MainWindow.smethod_0();
            }

            internal void method_3(Hotkey hotkey_0)
            {
                if (BotManager.IsRunning)
                {
                    BotManager.Stop();
                }
                else
                {
                    BotManager.Start();
                }
            }

            internal string method_4(IPlugin iplugin_0)
            {
                return iplugin_0.Name;
            }

            internal string method_5(IPlugin iplugin_0)
            {
                return iplugin_0.Name;
            }
        }

        [CompilerGenerated]
        private sealed class Class26
        {
            public string string_0;

            internal bool method_0(IBot ibot_0)
            {
                return (ibot_0.Name == this.string_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class27
        {
            public string string_0;

            internal bool method_0(IBot ibot_0)
            {
                return (ibot_0.Name == this.string_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class28
        {
            public string string_0;

            internal bool method_0(IRoutine iroutine_0)
            {
                return (iroutine_0.Name == this.string_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class29
        {
            public string string_0;

            internal bool method_0(IRoutine iroutine_0)
            {
                return (iroutine_0.Name == this.string_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class30
        {
            public BotChangedEventArgs botChangedEventArgs_0;
            public MainWindow mainWindow_0;

            internal void method_0()
            {
                this.mainWindow_0.comboBox_0.SelectedItem = this.botChangedEventArgs_0.New;
            }
        }

        [CompilerGenerated]
        private sealed class Class31
        {
            public MainWindow mainWindow_0;
            public RoutineChangedEventArgs routineChangedEventArgs_0;

            internal void method_0()
            {
                this.mainWindow_0.comboBox_1.SelectedItem = this.routineChangedEventArgs_0.New;
            }
        }

        [CompilerGenerated]
        private sealed class Class32
        {
            public IPlugin iplugin_0;

            internal bool method_0(IPlugin iplugin_1)
            {
                return (iplugin_1 == this.iplugin_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class33
        {
            public List<string> list_0;
            public string string_0;
            public string string_1;

            internal void method_0(object object_0)
            {
                MainWindow.smethod_1(this.string_0, this.string_1, this.list_0);
            }
        }

        [CompilerGenerated]
        private sealed class Class34
        {
            public List<string> list_0;
            public string string_0;
            public string string_1;

            internal void method_0(object object_0)
            {
                MainWindow.smethod_1(this.string_0, this.string_1, this.list_0);
            }
        }

        [CompilerGenerated]
        private struct Struct3 : IAsyncStateMachine
        {
            public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;
            public int int_0;

            private void MoveNext()
            {
                try
                {
                }
                catch (Exception exception)
                {
                    this.int_0 = -2;
                    this.asyncTaskMethodBuilder_0.SetException(exception);
                }
                this.int_0 = -2;
                this.asyncTaskMethodBuilder_0.SetResult();
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
                this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
            }
        }
    }
}

