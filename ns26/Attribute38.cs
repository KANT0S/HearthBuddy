namespace ns26
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Class, Inherited=false, AllowMultiple=false)]
    internal sealed class Attribute38 : Attribute
    {
        [CompilerGenerated]
        private string string_0;

        public Attribute38(string className)
        {
            this.ClassName = className;
        }

        public string ClassName
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

