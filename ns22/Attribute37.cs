namespace ns22
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Property, Inherited=false, AllowMultiple=false)]
    internal sealed class Attribute37 : Attribute
    {
        [CompilerGenerated]
        private Type type_0;

        public Attribute37(Type overrideWithSubtypesOf)
        {
            this.Type_0 = overrideWithSubtypesOf;
        }

        public Type Type_0
        {
            [CompilerGenerated]
            get
            {
                return this.type_0;
            }
            [CompilerGenerated]
            set
            {
                this.type_0 = value;
            }
        }
    }
}

