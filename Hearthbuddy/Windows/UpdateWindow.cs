namespace Hearthbuddy.Windows
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Net;
    using System.Threading;
    using System.Timers;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Markup;

    public class UpdateWindow : Window, IComponentConnector
    {
        private bool bool_0;
        internal Button button_0;
        internal Button button_1;
        private int int_0 = 60;
        internal RichTextBox richTextBox_0;
        private readonly string string_0;
        private readonly System.Timers.Timer timer_0 = new System.Timers.Timer(1000.0);

        public UpdateWindow(string filter)
        {
            this.string_0 = filter;
            this.InitializeComponent();
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            this.timer_0.Stop();
            base.DialogResult = true;
            base.Close();
        }

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            base.DialogResult = false;
            base.Close();
        }

        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (!this.bool_0)
            {
                this.bool_0 = true;
                Uri resourceLocator = new Uri("/Hearthbuddy;component/windows/updatewindow.xaml", UriKind.Relative);
                Application.LoadComponent(this, resourceLocator);
            }
        }

        private void method_0(object sender, RoutedEventArgs e)
        {
            string text = new WebClient().DownloadString("http://updates.buddyauth.com/GetNewestChangelog?filter=" + this.string_0);
            this.richTextBox_0.Document.Blocks.Add(new Paragraph(new System.Windows.Documents.Run(text)));
            this.timer_0.Elapsed += new ElapsedEventHandler(this.timer_0_Elapsed);
            this.timer_0.AutoReset = true;
            this.timer_0.Start();
        }

        private void method_1(object sender, MouseEventArgs e)
        {
            this.timer_0.Stop();
            this.button_1.Content = "No";
        }

        [GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never)]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    ((UpdateWindow) target).Loaded += new RoutedEventHandler(this.method_0);
                    ((UpdateWindow) target).MouseMove += new MouseEventHandler(this.method_1);
                    return;

                case 2:
                    this.richTextBox_0 = (RichTextBox) target;
                    return;

                case 3:
                    this.button_0 = (Button) target;
                    this.button_0.Click += new RoutedEventHandler(this.button_0_Click);
                    return;

                case 4:
                    this.button_1 = (Button) target;
                    this.button_1.Click += new RoutedEventHandler(this.button_1_Click);
                    return;
            }
            this.bool_0 = true;
        }

        private void timer_0_Elapsed(object sender, EventArgs e)
        {
            if (base.Dispatcher.Thread != Thread.CurrentThread)
            {
                object[] args = new object[] { sender, e };
                base.Dispatcher.BeginInvoke(new EventHandler(this.timer_0_Elapsed), args);
            }
            else if (this.int_0 == 0)
            {
                this.timer_0.Stop();
                this.button_1_Click(null, null);
            }
            else
            {
                int num = this.int_0;
                this.int_0 = num - 1;
                this.button_1.Content = string.Format("No ({0})", num);
            }
        }
    }
}

