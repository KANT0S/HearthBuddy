namespace ns16
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal struct Struct27 : IEquatable<Struct27>
    {
        private readonly Type type_0;
        private readonly Type type_1;
        public Struct27(Type resolverType, Type contractType)
        {
            this.type_0 = resolverType;
            this.type_1 = contractType;
        }

        int ValueType.GetHashCode()
        {
            return (this.type_0.GetHashCode() ^ this.type_1.GetHashCode());
        }

        bool ValueType.Equals(object obj)
        {
            return ((obj is Struct27) && this.Equals((Struct27) obj));
        }

        public bool Equals(Struct27 other)
        {
            return ((this.type_0 == other.type_0) && (this.type_1 == other.type_1));
        }
    }
}

