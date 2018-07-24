namespace ns13
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Method, AllowMultiple=false, Inherited=true)]
    internal sealed class Attribute5 : Attribute
    {
        [CompilerGenerated]
        private string string_0;

        public Attribute5()
        {
        }

        public Attribute5(string parameterName)
        {
            this.String_0 = parameterName;
        }

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

