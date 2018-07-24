namespace ns13
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    internal sealed class Attribute7 : Attribute
    {
        [CompilerGenerated]
        private bool bool_0;

        public Attribute7() : this(true)
        {
        }

        public Attribute7(bool required)
        {
            this.Boolean_0 = required;
        }

        public bool Boolean_0
        {
            [CompilerGenerated]
            get
            {
                return this.bool_0;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_0 = value;
            }
        }
    }
}

