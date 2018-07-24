namespace Hearthbuddy.Windows
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.IO;
    using System.Net;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Windows;
    using System.Windows.Markup;

    public class DownloadingWindow : Window, IComponentConnector
    {
        private bool bool_0;
        internal DownloadingWindow downloadingWindow_0;
        private readonly string string_0;
        private readonly string string_1;

        public DownloadingWindow(string filter, string exePath)
        {
            this.string_0 = exePath;
            this.string_1 = filter;
            this.InitializeComponent();
        }

        private void downloadingWindow_0_Loaded(object sender, RoutedEventArgs e)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_0));
        }

        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (!this.bool_0)
            {
                this.bool_0 = true;
                Uri resourceLocator = new Uri("/Hearthbuddy;component/windows/downloadingwindow.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        [CompilerGenerated]
        private void method_0(object object_0)
        {
            WebClient client = new WebClient();
            try
            {
                client.DownloadFile("http://updates.buddyauth.com/NewUpdater.exe", this.string_0);
                if (!System.IO.File.Exists(this.string_0))
                {
                    MessageBox.Show("The Buddyupdater could not be executed. Please update manually. The program will now exit.", "Hearthbuddy", MessageBoxButton.OK, MessageBoxImage.Hand);
                    Environment.Exit(0);
                }
                Process.Start(this.string_0, this.string_1 + " \"" + Assembly.GetEntryAssembly().Location + "\"");
                Environment.Exit(0);
            }
            catch (Exception)
            {
                MessageBox.Show("The Buddyupdater could not be executed. Please update manually. The program will now exit.", "Hearthbuddy", MessageBoxButton.OK, MessageBoxImage.Hand);
                Environment.Exit(0);
            }
        }

        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Never)]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            if (connectionId == 1)
            {
                this.downloadingWindow_0 = (DownloadingWindow) target;
                this.downloadingWindow_0.Loaded += new RoutedEventHandler(this.downloadingWindow_0_Loaded);
            }
            else
            {
                this.bool_0 = true;
            }
        }
    }
}

