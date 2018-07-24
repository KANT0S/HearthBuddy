namespace ns0
{
    using System;
    using System.Windows;

    internal static class Class0
    {
        internal static void smethod_0(DependencyObject dependencyObject_0, RoutedEventArgs routedEventArgs_0)
        {
            if (dependencyObject_0 is UIElement)
            {
                (dependencyObject_0 as UIElement).RaiseEvent(routedEventArgs_0);
            }
            else if (dependencyObject_0 is ContentElement)
            {
                (dependencyObject_0 as ContentElement).RaiseEvent(routedEventArgs_0);
            }
        }

        internal static void smethod_1(DependencyObject dependencyObject_0, RoutedEvent routedEvent_0, Delegate delegate_0)
        {
            UIElement element = dependencyObject_0 as UIElement;
            if (element != null)
            {
                element.AddHandler(routedEvent_0, delegate_0);
            }
            else
            {
                ContentElement element2 = dependencyObject_0 as ContentElement;
                if (element2 != null)
                {
                    element2.AddHandler(routedEvent_0, delegate_0);
                }
            }
        }

        internal static void smethod_2(DependencyObject dependencyObject_0, RoutedEvent routedEvent_0, Delegate delegate_0)
        {
            UIElement element = dependencyObject_0 as UIElement;
            if (element != null)
            {
                element.RemoveHandler(routedEvent_0, delegate_0);
            }
            else
            {
                ContentElement element2 = dependencyObject_0 as ContentElement;
                if (element2 != null)
                {
                    element2.RemoveHandler(routedEvent_0, delegate_0);
                }
            }
        }
    }
}

