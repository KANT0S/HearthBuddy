namespace ns13
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
    internal sealed class Attribute25 : Attribute
    {
        [CompilerGenerated]
        private string string_0;

        public Attribute25()
        {
        }

        public Attribute25([Attribute2] string anonymousProperty)
        {
            this.String_0 = anonymousProperty;
        }

        [Attribute2]
        public string String_0
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

