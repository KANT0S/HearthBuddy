namespace ns20
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    internal class Class183<T> : IEnumerable<T>, ICollection<T>, IEnumerable, IList, ICollection, Interface15
    {
        private readonly ICollection<T> icollection_0;
        private readonly IList ilist_0;
        private object object_0;

        public Class183(ICollection<T> list)
        {
            Class203.smethod_2(list, "list");
            this.icollection_0 = list;
        }

        public Class183(IList list)
        {
            Class203.smethod_2(list, "list");
            if (list is ICollection<T>)
            {
                this.icollection_0 = (ICollection<T>) list;
            }
            else
            {
                this.ilist_0 = list;
            }
        }

        public virtual void Add(T item)
        {
            if (this.icollection_0 != null)
            {
                this.icollection_0.Add(item);
            }
            else
            {
                this.ilist_0.Add(item);
            }
        }

        public virtual void Clear()
        {
            if (this.icollection_0 != null)
            {
                this.icollection_0.Clear();
            }
            else
            {
                this.ilist_0.Clear();
            }
        }

        public virtual bool Contains(T item)
        {
            if (this.icollection_0 != null)
            {
                return this.icollection_0.Contains(item);
            }
            return this.ilist_0.Contains(item);
        }

        public virtual void CopyTo(T[] array, int arrayIndex)
        {
            if (this.icollection_0 != null)
            {
                this.icollection_0.CopyTo(array, arrayIndex);
            }
            else
            {
                this.ilist_0.CopyTo(array, arrayIndex);
            }
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            if (this.icollection_0 != null)
            {
                return this.icollection_0.GetEnumerator();
            }
            return this.ilist_0.Cast<T>().GetEnumerator();
        }

        public virtual bool Remove(T item)
        {
            bool flag;
            if (this.icollection_0 != null)
            {
                return this.icollection_0.Remove(item);
            }
            if (flag = this.ilist_0.Contains(item))
            {
                this.ilist_0.Remove(item);
            }
            return flag;
        }

        private static void smethod_0(object object_1)
        {
            if (!Class183<T>.smethod_1(object_1))
            {
                throw new ArgumentException("The value '{0}' is not of type '{1}' and cannot be used in this generic collection.".smethod_1(CultureInfo.InvariantCulture, object_1, typeof(T)), "value");
            }
        }

        private static bool smethod_1(object object_1)
        {
            return ((object_1 is T) || ((object_1 == null) && (!typeof(T).smethod_12() || Class194.smethod_10(typeof(T)))));
        }

        void ICollection.CopyTo(Array array, int arrayIndex)
        {
            this.CopyTo((T[]) array, arrayIndex);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            if (this.icollection_0 != null)
            {
                return this.icollection_0.GetEnumerator();
            }
            return this.ilist_0.GetEnumerator();
        }

        int IList.Add(object value)
        {
            Class183<T>.smethod_0(value);
            this.Add((T) value);
            return (this.Count - 1);
        }

        bool IList.Contains(object value)
        {
            return (Class183<T>.smethod_1(value) && this.Contains((T) value));
        }

        int IList.IndexOf(object value)
        {
            if (this.icollection_0 != null)
            {
                throw new InvalidOperationException("Wrapped ICollection<T> does not support IndexOf.");
            }
            if (Class183<T>.smethod_1(value))
            {
                return this.ilist_0.IndexOf((T) value);
            }
            return -1;
        }

        void IList.Insert(int index, object value)
        {
            if (this.icollection_0 != null)
            {
                throw new InvalidOperationException("Wrapped ICollection<T> does not support Insert.");
            }
            Class183<T>.smethod_0(value);
            this.ilist_0.Insert(index, (T) value);
        }

        void IList.Remove(object value)
        {
            if (Class183<T>.smethod_1(value))
            {
                this.Remove((T) value);
            }
        }

        void IList.RemoveAt(int index)
        {
            if (this.icollection_0 != null)
            {
                throw new InvalidOperationException("Wrapped ICollection<T> does not support RemoveAt.");
            }
            this.ilist_0.RemoveAt(index);
        }

        public virtual int Count
        {
            get
            {
                if (this.icollection_0 != null)
                {
                    return this.icollection_0.Count;
                }
                return this.ilist_0.Count;
            }
        }

        public virtual bool IsReadOnly
        {
            get
            {
                if (this.icollection_0 != null)
                {
                    return this.icollection_0.IsReadOnly;
                }
                return this.ilist_0.IsReadOnly;
            }
        }

        public object Object_0
        {
            get
            {
                if (this.icollection_0 != null)
                {
                    return this.icollection_0;
                }
                return this.ilist_0;
            }
        }

        bool ICollection.IsSynchronized
        {
            get
            {
                return false;
            }
        }

        object ICollection.SyncRoot
        {
            get
            {
                if (this.object_0 == null)
                {
                    Interlocked.CompareExchange(ref this.object_0, new object(), null);
                }
                return this.object_0;
            }
        }

        bool IList.IsFixedSize
        {
            get
            {
                if (this.icollection_0 != null)
                {
                    return this.icollection_0.IsReadOnly;
                }
                return this.ilist_0.IsFixedSize;
            }
        }

        object IList.this[int index]
        {
            get
            {
                if (this.icollection_0 != null)
                {
                    throw new InvalidOperationException("Wrapped ICollection<T> does not support indexer.");
                }
                return this.ilist_0[index];
            }
            set
            {
                if (this.icollection_0 != null)
                {
                    throw new InvalidOperationException("Wrapped ICollection<T> does not support indexer.");
                }
                Class183<T>.smethod_0(value);
                this.ilist_0[index] = (T) value;
            }
        }
    }
}

