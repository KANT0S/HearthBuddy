namespace Newtonsoft.Json.Serialization
{
    using Newtonsoft.Json;
    using ns20;
    using System;
    using System.Globalization;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;

    public class DefaultSerializationBinder : SerializationBinder
    {
        private readonly Class178<Struct28, Type> class178_0 = new Class178<Struct28, Type>(new Func<Struct28, Type>(DefaultSerializationBinder.smethod_0));
        internal static readonly DefaultSerializationBinder defaultSerializationBinder_0 = new DefaultSerializationBinder();

        public override void BindToName(Type serializedType, out string assemblyName, out string typeName)
        {
            assemblyName = serializedType.Assembly.FullName;
            typeName = serializedType.FullName;
        }

        public override Type BindToType(string assemblyName, string typeName)
        {
            return this.class178_0.method_0(new Struct28(assemblyName, typeName));
        }

        private static Type smethod_0(Struct28 struct28_0)
        {
            string partialName = struct28_0.string_0;
            string typeName = struct28_0.string_1;
            if (partialName == null)
            {
                return Type.GetType(typeName);
            }
            Assembly assembly = Assembly.LoadWithPartialName(partialName);
            if (assembly == null)
            {
                foreach (Assembly assembly2 in AppDomain.CurrentDomain.GetAssemblies())
                {
                    if (assembly2.FullName == partialName)
                    {
                        assembly = assembly2;
                        break;
                    }
                }
            }
            if (assembly == null)
            {
                throw new JsonSerializationException("Could not load assembly '{0}'.".smethod_0(CultureInfo.InvariantCulture, partialName));
            }
            Type type = assembly.GetType(typeName);
            if (type == null)
            {
                throw new JsonSerializationException("Could not find type '{0}' in assembly '{1}'.".smethod_1(CultureInfo.InvariantCulture, typeName, assembly.FullName));
            }
            return type;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct Struct28 : IEquatable<DefaultSerializationBinder.Struct28>
        {
            internal readonly string string_0;
            internal readonly string string_1;
            public Struct28(string assemblyName, string typeName)
            {
                this.string_0 = assemblyName;
                this.string_1 = typeName;
            }

            int ValueType.GetHashCode()
            {
                return (((this.string_0 != null) ? this.string_0.GetHashCode() : 0) ^ ((this.string_1 != null) ? this.string_1.GetHashCode() : 0));
            }

            bool ValueType.Equals(object obj)
            {
                return ((obj is DefaultSerializationBinder.Struct28) && this.Equals((DefaultSerializationBinder.Struct28) obj));
            }

            public bool Equals(DefaultSerializationBinder.Struct28 other)
            {
                return ((this.string_0 == other.string_0) && (this.string_1 == other.string_1));
            }
        }
    }
}

