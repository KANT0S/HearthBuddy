namespace ns20
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;

    internal class Class185<T, U> : IDictionary<T, U>, ICollection<KeyValuePair<T, U>>, IEnumerable<KeyValuePair<T, U>>, IEnumerable, ICollection, IDictionary, Interface16
    {
        [CompilerGenerated]
        private static Func<DictionaryEntry, KeyValuePair<T, U>> func_0;
        private readonly IDictionary idictionary_0;
        private readonly IDictionary<T, U> idictionary_1;
        private object object_0;

        public Class185(IDictionary<T, U> dictionary)
        {
            Class203.smethod_2(dictionary, "dictionary");
            this.idictionary_1 = dictionary;
        }

        public Class185(IDictionary dictionary)
        {
            Class203.smethod_2(dictionary, "dictionary");
            this.idictionary_0 = dictionary;
        }

        public void Add(KeyValuePair<T, U> item)
        {
            if (this.idictionary_0 != null)
            {
                ((IList) this.idictionary_0).Add(item);
            }
            else if (this.idictionary_1 != null)
            {
                this.idictionary_1.Add(item);
            }
        }

        public void Add(T key, U value)
        {
            if (this.idictionary_0 != null)
            {
                this.idictionary_0.Add(key, value);
            }
            else
            {
                if (this.idictionary_1 == null)
                {
                    throw new NotSupportedException();
                }
                this.idictionary_1.Add(key, value);
            }
        }

        public void Clear()
        {
            if (this.idictionary_0 != null)
            {
                this.idictionary_0.Clear();
            }
            else
            {
                this.idictionary_1.Clear();
            }
        }

        public bool Contains(KeyValuePair<T, U> item)
        {
            if (this.idictionary_0 != null)
            {
                return ((IList) this.idictionary_0).Contains(item);
            }
            return this.idictionary_1.Contains(item);
        }

        public bool ContainsKey(T key)
        {
            if (this.idictionary_0 != null)
            {
                return this.idictionary_0.Contains(key);
            }
            return this.idictionary_1.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<T, U>[] array, int arrayIndex)
        {
            if (this.idictionary_0 != null)
            {
                foreach (DictionaryEntry entry in this.idictionary_0)
                {
                    array[arrayIndex++] = new KeyValuePair<T, U>((T) entry.Key, (U) entry.Value);
                }
            }
            else
            {
                this.idictionary_1.CopyTo(array, arrayIndex);
            }
        }

        public IEnumerator<KeyValuePair<T, U>> GetEnumerator()
        {
            if (this.idictionary_0 == null)
            {
                return this.idictionary_1.GetEnumerator();
            }
            if (Class185<T, U>.func_0 == null)
            {
                Class185<T, U>.func_0 = new Func<DictionaryEntry, KeyValuePair<T, U>>(Class185<T, U>.smethod_0);
            }
            return this.idictionary_0.Cast<DictionaryEntry>().Select<DictionaryEntry, KeyValuePair<T, U>>(Class185<T, U>.func_0).GetEnumerator();
        }

        public bool Remove(T key)
        {
            if (this.idictionary_0 == null)
            {
                return this.idictionary_1.Remove(key);
            }
            if (this.idictionary_0.Contains(key))
            {
                this.idictionary_0.Remove(key);
                return true;
            }
            return false;
        }

        public bool Remove(KeyValuePair<T, U> item)
        {
            if (this.idictionary_0 == null)
            {
                return this.idictionary_1.Remove(item);
            }
            if (!this.idictionary_0.Contains(item.Key))
            {
                return true;
            }
            object objA = this.idictionary_0[item.Key];
            if (object.Equals(objA, item.Value))
            {
                this.idictionary_0.Remove(item.Key);
                return true;
            }
            return false;
        }

        public void Remove(object key)
        {
            if (this.idictionary_0 != null)
            {
                this.idictionary_0.Remove(key);
            }
            else
            {
                this.idictionary_1.Remove((T) key);
            }
        }

        [CompilerGenerated]
        private static KeyValuePair<T, U> smethod_0(DictionaryEntry dictionaryEntry_0)
        {
            return new KeyValuePair<T, U>((T) dictionaryEntry_0.Key, (U) dictionaryEntry_0.Value);
        }

        void ICollection.CopyTo(Array array, int index)
        {
            if (this.idictionary_0 != null)
            {
                this.idictionary_0.CopyTo(array, index);
            }
            else
            {
                this.idictionary_1.CopyTo((KeyValuePair<T, U>[]) array, index);
            }
        }

        void IDictionary.Add(object key, object value)
        {
            if (this.idictionary_0 != null)
            {
                this.idictionary_0.Add(key, value);
            }
            else
            {
                this.idictionary_1.Add((T) key, (U) value);
            }
        }

        bool IDictionary.Contains(object key)
        {
            if (this.idictionary_1 != null)
            {
                return this.idictionary_1.ContainsKey((T) key);
            }
            return this.idictionary_0.Contains(key);
        }

        IDictionaryEnumerator IDictionary.GetEnumerator()
        {
            if (this.idictionary_0 != null)
            {
                return this.idictionary_0.GetEnumerator();
            }
            return new Struct31<T, U, T, U>(this.idictionary_1.GetEnumerator());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool TryGetValue(T key, out U value)
        {
            if (this.idictionary_0 == null)
            {
                return this.idictionary_1.TryGetValue(key, out value);
            }
            if (!this.idictionary_0.Contains(key))
            {
                value = default(U);
                return false;
            }
            value = (U) this.idictionary_0[key];
            return true;
        }

        public int Count
        {
            get
            {
                if (this.idictionary_0 != null)
                {
                    return this.idictionary_0.Count;
                }
                return this.idictionary_1.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                if (this.idictionary_0 != null)
                {
                    return this.idictionary_0.IsReadOnly;
                }
                return this.idictionary_1.IsReadOnly;
            }
        }

        public U this[T key]
        {
            get
            {
                if (this.idictionary_0 != null)
                {
                    return (U) this.idictionary_0[key];
                }
                return this.idictionary_1[key];
            }
            set
            {
                if (this.idictionary_0 != null)
                {
                    this.idictionary_0[key] = value;
                }
                else
                {
                    this.idictionary_1[key] = value;
                }
            }
        }

        public ICollection<T> Keys
        {
            get
            {
                if (this.idictionary_0 != null)
                {
                    return this.idictionary_0.Keys.Cast<T>().ToList<T>();
                }
                return this.idictionary_1.Keys;
            }
        }

        public object Object_0
        {
            get
            {
                if (this.idictionary_0 != null)
                {
                    return this.idictionary_0;
                }
                return this.idictionary_1;
            }
        }

        bool ICollection.IsSynchronized
        {
            get
            {
                return ((this.idictionary_0 != null) && this.idictionary_0.IsSynchronized);
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

        bool IDictionary.IsFixedSize
        {
            get
            {
                if (this.idictionary_1 != null)
                {
                    return false;
                }
                return this.idictionary_0.IsFixedSize;
            }
        }

        object IDictionary.this[object key]
        {
            get
            {
                if (this.idictionary_0 != null)
                {
                    return this.idictionary_0[key];
                }
                return this.idictionary_1[(T) key];
            }
            set
            {
                if (this.idictionary_0 != null)
                {
                    this.idictionary_0[key] = value;
                }
                else
                {
                    this.idictionary_1[(T) key] = (U) value;
                }
            }
        }

        ICollection IDictionary.Keys
        {
            get
            {
                if (this.idictionary_1 != null)
                {
                    return this.idictionary_1.Keys.ToList<T>();
                }
                return this.idictionary_0.Keys;
            }
        }

        ICollection IDictionary.Values
        {
            get
            {
                if (this.idictionary_1 != null)
                {
                    return this.idictionary_1.Values.ToList<U>();
                }
                return this.idictionary_0.Values;
            }
        }

        public ICollection<U> Values
        {
            get
            {
                if (this.idictionary_0 != null)
                {
                    return (ICollection<U>) this.idictionary_0.Values.Cast<U>().ToList<U>();
                }
                return this.idictionary_1.Values;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct Struct31<V, W> : IEnumerator, IDictionaryEnumerator
        {
            private readonly IEnumerator<KeyValuePair<V, W>> ienumerator_0;
            public Struct31(IEnumerator<KeyValuePair<V, W>> e)
            {
                Class203.smethod_2(e, "e");
                this.ienumerator_0 = e;
            }

            public DictionaryEntry Entry
            {
                get
                {
                    return (DictionaryEntry) this.Current;
                }
            }
            public object Key
            {
                get
                {
                    return this.Entry.Key;
                }
            }
            public object Value
            {
                get
                {
                    return this.Entry.Value;
                }
            }
            public object Current
            {
                get
                {
                    return new DictionaryEntry(this.ienumerator_0.Current.Key, this.ienumerator_0.Current.Value);
                }
            }
            public bool MoveNext()
            {
                return this.ienumerator_0.MoveNext();
            }

            public void Reset()
            {
                this.ienumerator_0.Reset();
            }
        }
    }
}

