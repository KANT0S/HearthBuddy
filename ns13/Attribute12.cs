namespace ns13
{
    using System;
    using System.Runtime.CompilerServices;

    [Attribute11]
    internal sealed class Attribute12 : Attribute
    {
        [CompilerGenerated]
        private string string_0;

        public Attribute12()
        {
        }

        public Attribute12([Attribute2] string comment)
        {
            this.String_0 = comment;
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

