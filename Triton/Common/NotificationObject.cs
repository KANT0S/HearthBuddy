namespace Triton.Common
{
    using JetBrains.Annotations;
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Windows;

    public class NotificationObject : INotifyPropertyChanged
    {
        [field: CompilerGenerated]
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected void NotifyPropertyChanged<TExp>(Expression<Func<TExp>> expression)
        {
            Class212<TExp> class2 = new Class212<TExp> {
                notificationObject_0 = this,
                string_0 = smethod_0<TExp>(expression)
            };
            if (Application.Current != null)
            {
                Application.Current.Dispatcher.BeginInvoke(new Action(class2.method_0), Array.Empty<object>());
            }
        }

        private static string smethod_0<T>(Expression<Func<T>> expression_0)
        {
            if (expression_0.NodeType != ExpressionType.Lambda)
            {
                throw new ArgumentException("Value must be a lamda expression", "expression");
            }
            if (!(expression_0.Body is MemberExpression))
            {
                throw new ArgumentException("The body of the expression must be a memberref", "expression");
            }
            return ((MemberExpression) expression_0.Body).Member.Name;
        }

        [CompilerGenerated]
        private sealed class Class212<T>
        {
            public NotificationObject notificationObject_0;
            public string string_0;

            internal void method_0()
            {
                PropertyChangedEventHandler handler = this.notificationObject_0.propertyChangedEventHandler_0;
                if (handler != null)
                {
                    handler(this.notificationObject_0, new PropertyChangedEventArgs(this.string_0));
                }
            }
        }
    }
}

