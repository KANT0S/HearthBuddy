namespace ns13
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
    internal sealed class Attribute26 : Attribute
    {
        [CompilerGenerated]
        private string string_0;

        public Attribute26()
        {
        }

        public Attribute26([Attribute2] string anonymousProperty)
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

