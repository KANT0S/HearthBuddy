namespace ns13
{
    using System;
    using System.Runtime.CompilerServices;

    [Attribute9(typeof(Attribute)), AttributeUsage(AttributeTargets.Class, AllowMultiple=true, Inherited=true)]
    internal sealed class Attribute9 : Attribute
    {
        [CompilerGenerated]
        private Type type_0;

        public Attribute9([Attribute2] Type baseType)
        {
            this.Type_0 = baseType;
        }

        [Attribute2]
        public Type Type_0
        {
            [CompilerGenerated]
            get
            {
                return this.type_0;
            }
            [CompilerGenerated]
            private set
            {
                this.type_0 = value;
            }
        }
    }
}

