namespace ns20
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Runtime.InteropServices;

    internal class Class179<T, U>
    {
        private readonly IDictionary<T, U> idictionary_0;
        private readonly IDictionary<U, T> idictionary_1;
        private readonly string string_0;
        private readonly string string_1;

        public Class179() : this(EqualityComparer<T>.Default, EqualityComparer<U>.Default)
        {
        }

        public Class179(IEqualityComparer<T> firstEqualityComparer, IEqualityComparer<U> secondEqualityComparer) : this(firstEqualityComparer, secondEqualityComparer, "Duplicate item already exists for '{0}'.", "Duplicate item already exists for '{0}'.")
        {
        }

        public Class179(IEqualityComparer<T> firstEqualityComparer, IEqualityComparer<U> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage)
        {
            this.idictionary_0 = new Dictionary<T, U>(firstEqualityComparer);
            this.idictionary_1 = new Dictionary<U, T>(secondEqualityComparer);
            this.string_0 = duplicateFirstErrorMessage;
            this.string_1 = duplicateSecondErrorMessage;
        }

        public void method_0(T gparam_0, U gparam_1)
        {
            T local;
            U local2;
            if (this.idictionary_0.TryGetValue(gparam_0, out local2) && !local2.Equals(gparam_1))
            {
                throw new ArgumentException(this.string_0.smethod_0(CultureInfo.InvariantCulture, gparam_0));
            }
            if (this.idictionary_1.TryGetValue(gparam_1, out local) && !local.Equals(gparam_0))
            {
                throw new ArgumentException(this.string_1.smethod_0(CultureInfo.InvariantCulture, gparam_1));
            }
            this.idictionary_0.Add(gparam_0, gparam_1);
            this.idictionary_1.Add(gparam_1, gparam_0);
        }

        public bool method_1(T gparam_0, out U gparam_1)
        {
            return this.idictionary_0.TryGetValue(gparam_0, out gparam_1);
        }

        public bool method_2(U gparam_0, out T gparam_1)
        {
            return this.idictionary_1.TryGetValue(gparam_0, out gparam_1);
        }
    }
}

