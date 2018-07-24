namespace Hearthbuddy.Windows
{
    using log4net;
    using ns2;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;
    using Triton.Bot.Settings;
    using Triton.Common;

    public class LoginWindow : Window, IComponentConnector
    {
        [CompilerGenerated]
        private bool bool_0;
        private bool bool_1;
        internal Button button_0;
        internal ComboBox comboBox_0;
        private static readonly ILog ilog_0 = Logger.GetLoggerInstanceForType();
        private MainWindow mainWindow_0;
        internal TextBox textBox_0;

        public LoginWindow()
        {
            this.InitializeComponent();
            this.NeedsToShow = true;
            this.mainWindow_0 = new MainWindow();
            if (CommandLine.Arguments.Exists("loginkey"))
            {
                GlobalSettings.Instance.LoginKey = CommandLine.Arguments.Single("loginkey");
            }
            this.textBox_0.Text = GlobalSettings.Instance.LoginKey;
            Keyboard.Focus(this.button_0);
            if (!string.IsNullOrEmpty(GlobalSettings.Instance.LoginKey) && (GlobalSettings.Instance.AuthLogin || CommandLine.Arguments.Exists("authlogin")))
            {
                this.method_0();
            }
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GlobalSettings.Instance.LoginKey = this.textBox_0.Text.Trim();
                GlobalSettings.Instance.Save();
                if (!string.IsNullOrEmpty(GlobalSettings.Instance.LoginKey))
                {
                    this.method_0();
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString(), "Hearthbuddy", MessageBoxButton.OK, MessageBoxImage.Hand);
                Environment.Exit(0);
            }
        }

        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (!this.bool_1)
            {
                this.bool_1 = true;
                Uri resourceLocator = new Uri("/Hearthbuddy;component/windows/loginwindow.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        private void method_0()
        {
            base.Visibility = Visibility.Hidden;
            if (!CommandLine.Arguments.Exists("noupdate") && !GlobalSettings.Instance.DisableUpdateCheck)
            {
                try
                {
                    Class12.smethod_5();
                }
                catch (Exception exception)
                {
                    ilog_0.Error("An error occured while checking for updates.", exception);
                }
            }
            if (!Class12.smethod_1(GlobalSettings.Instance.AuthRegion, GlobalSettings.Instance.LoginKey))
            {
                MessageBox.Show(string.Format("There was an error authenticating your key with the server. Please try again or use a different key.{0}{0}{1}", Environment.NewLine, Class12.string_0), "Hearthbuddy", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
            else
            {
                Class12.smethod_3();
                Application.Current.MainWindow = this.mainWindow_0;
                this.mainWindow_0.Visibility = Visibility.Visible;
                this.mainWindow_0.Show();
                this.mainWindow_0 = null;
                base.Close();
                this.NeedsToShow = false;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Never)]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.textBox_0 = (TextBox) target;
                    return;

                case 2:
                    this.button_0 = (Button) target;
                    this.button_0.Click += new RoutedEventHandler(this.button_0_Click);
                    return;

                case 3:
                    this.comboBox_0 = (ComboBox) target;
                    return;
            }
            this.bool_1 = true;
        }

        public bool NeedsToShow
        {
            [CompilerGenerated]
            get
            {
                return this.bool_0;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_0 = value;
            }
        }
    }
}

