namespace ns13
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property, Inherited=true)]
    internal sealed class Attribute35 : Attribute
    {
        [CompilerGenerated]
        private string string_0;

        public Attribute35([Attribute2] string name)
        {
            this.Name = name;
        }

        [Attribute2]
        public string Name
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
            [CompilerGenerated]
            private set
            {
                this.string_0 = value;
            }
        }
    }
}

