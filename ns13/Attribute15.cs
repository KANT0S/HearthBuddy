namespace ns13
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Parameter)]
    internal class Attribute15 : Attribute
    {
        [CompilerGenerated]
        private string string_0;

        public Attribute15()
        {
        }

        public Attribute15([Attribute15] string basePath)
        {
            this.String_0 = basePath;
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

