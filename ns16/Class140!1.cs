namespace ns16
{
    using ns20;
    using System;

    internal static class Class140<T> where T: Attribute
    {
        private static readonly Class178<object, T> class178_0;

        static Class140()
        {
            Class140<T>.class178_0 = new Class178<object, T>(new Func<object, T>(Class139.smethod_17<T>));
        }

        public static T smethod_0(object object_0)
        {
            return Class140<T>.class178_0.method_0(object_0);
        }
    }
}

