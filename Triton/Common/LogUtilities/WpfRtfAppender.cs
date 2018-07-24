namespace Triton.Common.LogUtilities
{
    using log4net.Appender;
    using log4net.Core;
    using System;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Media;
    using System.Windows.Threading;

    public class WpfRtfAppender : AppenderSkeleton
    {
        private readonly ConcurrentQueue<LoggingEvent> concurrentQueue_0 = new ConcurrentQueue<LoggingEvent>();
        private DispatcherTimer dispatcherTimer_0;
        private int int_0;
        private Paragraph paragraph_0;
        private readonly RichTextBox richTextBox_0;
        private readonly ScrollViewer scrollViewer_0;
        [CompilerGenerated]
        private SolidColorBrush solidColorBrush_0;
        [CompilerGenerated]
        private SolidColorBrush solidColorBrush_1;
        [CompilerGenerated]
        private SolidColorBrush solidColorBrush_2;
        [CompilerGenerated]
        private SolidColorBrush solidColorBrush_3;

        public WpfRtfAppender(ScrollViewer scrollViewer, RichTextBox rtb)
        {
            this.scrollViewer_0 = scrollViewer;
            this.richTextBox_0 = rtb;
            this.InfoBrush = Brushes.White;
            this.DebugBrush = Brushes.Orange;
            this.ErrorBrush = Brushes.Red;
            this.WarnBrush = Brushes.Yellow;
            this.InfoBrush.Freeze();
            this.DebugBrush.Freeze();
            this.ErrorBrush.Freeze();
            this.WarnBrush.Freeze();
            this.dispatcherTimer_0 = new DispatcherTimer(TimeSpan.FromMilliseconds(100.0), DispatcherPriority.Normal, new EventHandler(this.method_0), rtb.Dispatcher);
            this.dispatcherTimer_0.Start();
        }

        protected override void Append(LoggingEvent loggingEvent)
        {
            this.concurrentQueue_0.Enqueue(loggingEvent);
        }

        public void Clear()
        {
            this.paragraph_0.Inlines.Clear();
            this.int_0 = 0;
        }

        private void method_0(object sender, EventArgs e)
        {
            try
            {
                LoggingEvent event2;
                this.dispatcherTimer_0.Stop();
                SolidColorBrush infoBrush = this.InfoBrush;
                StringBuilder builder = new StringBuilder();
                Action<StringBuilder, SolidColorBrush> action = new Action<StringBuilder, SolidColorBrush>(this.method_1);
                if (this.paragraph_0 == null)
                {
                    this.richTextBox_0.Document.Blocks.Clear();
                    this.paragraph_0 = new Paragraph();
                    this.paragraph_0.Margin = new Thickness(0.0);
                    this.richTextBox_0.Document.Blocks.Add(this.paragraph_0);
                }
                if (this.int_0 >= 0x7d0)
                {
                    this.paragraph_0.Inlines.Clear();
                    this.int_0 = 0;
                }
                while (this.concurrentQueue_0.TryDequeue(out event2))
                {
                    SolidColorBrush debugBrush;
                    event2.Fix = FixFlags.All;
                    string str = base.RenderLoggingEvent(event2);
                    string name = event2.Level.Name;
                    switch (name)
                    {
                        case "DEBUG":
                            debugBrush = this.DebugBrush;
                            break;

                        case "ERROR":
                            debugBrush = this.ErrorBrush;
                            break;

                        default:
                            if (!(name == "WARN"))
                            {
                                debugBrush = this.InfoBrush;
                            }
                            else
                            {
                                debugBrush = this.WarnBrush;
                            }
                            break;
                    }
                    if (!object.Equals(debugBrush, infoBrush))
                    {
                        action(builder, infoBrush);
                        builder.Clear();
                        infoBrush = debugBrush;
                    }
                    builder.AppendLine(str);
                    this.int_0++;
                }
                if (builder.Length != 0)
                {
                    action(builder, infoBrush);
                    this.int_0++;
                }
                if (this.scrollViewer_0.ScrollableHeight.Equals(this.scrollViewer_0.ContentVerticalOffset))
                {
                    this.scrollViewer_0.ScrollToEnd();
                }
            }
            finally
            {
                this.dispatcherTimer_0.Start();
            }
        }

        [CompilerGenerated]
        private void method_1(StringBuilder stringBuilder_0, SolidColorBrush solidColorBrush_4)
        {
            System.Windows.Documents.Run item = new System.Windows.Documents.Run(stringBuilder_0.ToString()) {
                Foreground = solidColorBrush_4
            };
            this.paragraph_0.Inlines.Add(item);
        }

        public SolidColorBrush DebugBrush
        {
            [CompilerGenerated]
            get
            {
                return this.solidColorBrush_1;
            }
            [CompilerGenerated]
            set
            {
                this.solidColorBrush_1 = value;
            }
        }

        public SolidColorBrush ErrorBrush
        {
            [CompilerGenerated]
            get
            {
                return this.solidColorBrush_2;
            }
            [CompilerGenerated]
            set
            {
                this.solidColorBrush_2 = value;
            }
        }

        public SolidColorBrush InfoBrush
        {
            [CompilerGenerated]
            get
            {
                return this.solidColorBrush_0;
            }
            [CompilerGenerated]
            set
            {
                this.solidColorBrush_0 = value;
            }
        }

        public SolidColorBrush WarnBrush
        {
            [CompilerGenerated]
            get
            {
                return this.solidColorBrush_3;
            }
            [CompilerGenerated]
            set
            {
                this.solidColorBrush_3 = value;
            }
        }

        private delegate void Delegate5(LoggingEvent loggingEvent);
    }
}

