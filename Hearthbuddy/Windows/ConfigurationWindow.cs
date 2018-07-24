namespace Hearthbuddy.Windows
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Text.RegularExpressions;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;
    using Triton.Bot.Settings;
    using Triton.Common;

    public class ConfigurationWindow : Window, IComponentConnector
    {
        private readonly bool bool_0;
        private bool bool_1;
        internal Button button_0;
        internal ComboBox comboBox_0;

        public ConfigurationWindow()
        {
            this.InitializeComponent();
            if (CommandLine.Arguments.Exists("config"))
            {
                string input = CommandLine.Arguments.Single("config");
                if (new Regex("^[a-zA-Z0-9_]*$").IsMatch(input))
                {
                    Configuration.Instance.Name = input;
                    this.bool_0 = true;
                }
                else
                {
                    Configuration.Instance.Name = "Default";
                }
            }
            else
            {
                Configuration.Instance.Name = "Default";
            }
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            string text = this.comboBox_0.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please select or enter a valid configuration to use.", "Hearthbuddy", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
            else if (!new Regex(@"^[a-zA-Z0-9_\-]*$").IsMatch(text))
            {
                MessageBox.Show("The configuration name is invalid. Please use only alphanumeric, the underscore, or a dash characters (a-z, A-Z, 0-9, _, -).", "Hearthbuddy", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
            else
            {
                this.method_0(text);
            }
        }

        [GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
        public void InitializeComponent()
        {
            if (!this.bool_1)
            {
                this.bool_1 = true;
                Uri resourceLocator = new Uri("/Hearthbuddy;component/windows/configurationwindow.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        private void method_0(string string_0)
        {
            if (!GlobalSettings.Instance.Configurations.Contains(string_0))
            {
                GlobalSettings.Instance.Configurations.Add(string_0);
            }
            GlobalSettings.Instance.LastUsedConfiguration = string_0;
            Configuration.Instance.Name = string_0;
            try
            {
                base.Visibility = Visibility.Hidden;
                LoginWindow window = new LoginWindow();
                for (int i = 0; window.NeedsToShow; i++)
                {
                    Application.Current.MainWindow = window;
                    window.ShowDialog();
                    if ((Application.Current.MainWindow == null) || (i > 5))
                    {
                        if (i > 5)
                        {
                            MessageBox.Show("Hearthbuddy has tried to login too many times. Please wait a short while and try again. Hearthbuddy will now close.", "Hearthbuddy", MessageBoxButton.OK, MessageBoxImage.Hand);
                        }
                        Environment.Exit(0);
                    }
                }
                base.Close();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Hearthbuddy", MessageBoxButton.OK, MessageBoxImage.Hand);
                Environment.Exit(0);
            }
        }

        private void method_1(object sender, RoutedEventArgs e)
        {
            if (this.bool_0)
            {
                this.method_0(Configuration.Instance.Name);
            }
        }

        [GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never)]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    ((ConfigurationWindow) target).Loaded += new RoutedEventHandler(this.method_1);
                    return;

                case 2:
                    this.comboBox_0 = (ComboBox) target;
                    return;

                case 3:
                    this.button_0 = (Button) target;
                    this.button_0.Click += new RoutedEventHandler(this.button_0_Click);
                    return;
            }
            this.bool_1 = true;
        }
    }
}

