namespace JetBrains.Annotations
{
    using System;
    using System.Runtime.CompilerServices;

    [BaseTypeRequired(typeof(Attribute)), AttributeUsage(AttributeTargets.Class, AllowMultiple=true, Inherited=true)]
    public sealed class BaseTypeRequiredAttribute : Attribute
    {
        [CompilerGenerated]
        private Type[] type_0;

        public BaseTypeRequiredAttribute(Type baseType)
        {
            this.BaseTypes = new Type[] { baseType };
        }

        public Type[] BaseTypes
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

