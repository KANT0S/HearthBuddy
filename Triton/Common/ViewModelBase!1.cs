namespace Triton.Common
{
    using System;

    public class ViewModelBase<T> : NotificationObject where T: ViewModelBase<T>, new()
    {
        private static readonly T gparam_0;

        static ViewModelBase()
        {
            ViewModelBase<T>.gparam_0 = Activator.CreateInstance<T>();
        }

        public static T Instance
        {
            get
            {
                return ViewModelBase<T>.gparam_0;
            }
        }
    }
}

