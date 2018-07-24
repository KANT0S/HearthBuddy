namespace Hearthbuddy.Controls
{
    using System;
    using System.Collections.ObjectModel;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    [TemplatePart(Name="SplitElement", Type=typeof(UIElement))]
    public class SplitButton : Button
    {
        [CompilerGenerated]
        private bool bool_0;
        private ContextMenu contextMenu_0;
        private DependencyObject dependencyObject_0;
        private ObservableCollection<object> observableCollection_0 = new ObservableCollection<object>();
        private Point point_0;
        private const string string_0 = "SplitElement";
        private UIElement uielement_0;

        public SplitButton()
        {
            base.DefaultStyleKey = typeof(SplitButton);
        }

        private void contextMenu_0_Closed(object sender, RoutedEventArgs e)
        {
            base.LayoutUpdated -= new EventHandler(this.SplitButton_LayoutUpdated);
            base.Focus();
        }

        private void contextMenu_0_Opened(object sender, RoutedEventArgs e)
        {
            this.point_0 = base.TranslatePoint(new Point(0.0, base.ActualHeight), this.contextMenu_0);
            this.method_0();
            base.LayoutUpdated += new EventHandler(this.SplitButton_LayoutUpdated);
        }

        private void method_0()
        {
            Point point = new Point();
            Point point2 = this.point_0;
            this.contextMenu_0.HorizontalOffset = point2.X - point.X;
            this.contextMenu_0.VerticalOffset = point2.Y - point.Y;
            if (FlowDirection.RightToLeft == base.FlowDirection)
            {
                this.contextMenu_0.HorizontalOffset *= -1.0;
            }
        }

        public override void OnApplyTemplate()
        {
            if (this.uielement_0 != null)
            {
                this.uielement_0.MouseEnter -= new MouseEventHandler(this.uielement_0_MouseEnter);
                this.uielement_0.MouseLeave -= new MouseEventHandler(this.uielement_0_MouseLeave);
                this.uielement_0 = null;
            }
            if (this.contextMenu_0 != null)
            {
                this.contextMenu_0.Opened -= new RoutedEventHandler(this.contextMenu_0_Opened);
                this.contextMenu_0.Closed -= new RoutedEventHandler(this.contextMenu_0_Closed);
                this.contextMenu_0 = null;
            }
            if (this.dependencyObject_0 != null)
            {
                base.RemoveLogicalChild(this.dependencyObject_0);
                this.dependencyObject_0 = null;
            }
            base.OnApplyTemplate();
            this.uielement_0 = base.GetTemplateChild("SplitElement") as UIElement;
            if (this.uielement_0 != null)
            {
                this.uielement_0.MouseEnter += new MouseEventHandler(this.uielement_0_MouseEnter);
                this.uielement_0.MouseLeave += new MouseEventHandler(this.uielement_0_MouseLeave);
                this.contextMenu_0 = ContextMenuService.GetContextMenu(this.uielement_0);
                if (this.contextMenu_0 != null)
                {
                    this.contextMenu_0.IsOpen = true;
                    DependencyObject current = this.contextMenu_0;
                    do
                    {
                        this.dependencyObject_0 = current;
                        current = LogicalTreeHelper.GetParent(current);
                    }
                    while (current != null);
                    this.contextMenu_0.IsOpen = false;
                    base.AddLogicalChild(this.dependencyObject_0);
                    this.contextMenu_0.Opened += new RoutedEventHandler(this.contextMenu_0_Opened);
                    this.contextMenu_0.Closed += new RoutedEventHandler(this.contextMenu_0_Closed);
                }
            }
        }

        protected override void OnClick()
        {
            if (this.IsMouseOverSplitElement)
            {
                this.OpenButtonMenu();
            }
            else
            {
                base.OnClick();
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e == null)
            {
                throw new ArgumentNullException("e");
            }
            if ((Key.Down != e.Key) && (Key.Up != e.Key))
            {
                base.OnKeyDown(e);
            }
            else
            {
                base.Dispatcher.BeginInvoke(new Action(this.OpenButtonMenu), Array.Empty<object>());
            }
        }

        protected void OpenButtonMenu()
        {
            if ((0 < this.observableCollection_0.Count) && (this.contextMenu_0 != null))
            {
                this.contextMenu_0.HorizontalOffset = 0.0;
                this.contextMenu_0.VerticalOffset = 0.0;
                this.contextMenu_0.IsOpen = true;
            }
        }

        private void SplitButton_LayoutUpdated(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void uielement_0_MouseEnter(object sender, MouseEventArgs e)
        {
            this.IsMouseOverSplitElement = true;
        }

        private void uielement_0_MouseLeave(object sender, MouseEventArgs e)
        {
            this.IsMouseOverSplitElement = false;
        }

        public Collection<object> ButtonMenuItemsSource
        {
            get
            {
                return this.observableCollection_0;
            }
        }

        protected bool IsMouseOverSplitElement
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

