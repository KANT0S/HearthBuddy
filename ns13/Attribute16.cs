namespace ns13
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Parameter)]
    internal sealed class Attribute16 : Attribute15
    {
        [CompilerGenerated]
        private string string_1;

        public Attribute16()
        {
        }

        public Attribute16([Attribute2] string anonymousProperty)
        {
            this.String_1 = anonymousProperty;
        }

        [Attribute2]
        public string String_1
        {
            [CompilerGenerated]
            get
            {
                return this.string_1;
            }
            [CompilerGenerated]
            private set
            {
                this.string_1 = value;
            }
        }
    }
}

