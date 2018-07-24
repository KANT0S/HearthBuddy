namespace ns20
{
    using System;
    using System.Collections.ObjectModel;

    internal class Class188<T> : KeyedCollection<string, Class187<T>> where T: struct
    {
        string KeyedCollection<string, Class187<T>>.GetKeyForItem(Class187<T> item)
        {
            return item.Name;
        }
    }
}

