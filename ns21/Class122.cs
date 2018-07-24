namespace ns21
{
    using System;
    using System.Collections.ObjectModel;

    internal class Class122 : KeyedCollection<string, Class123>
    {
        string KeyedCollection<string, Class123>.GetKeyForItem(Class123 item)
        {
            return item.String_0;
        }
    }
}

