namespace ns15
{
    using System;
    using System.Runtime.CompilerServices;

    internal class Class76 : Class70
    {
        [CompilerGenerated]
        private Class74 class74_0;
        [CompilerGenerated]
        private Class74 class74_1;

        public Class76(string pattern, string options)
        {
            this.Class74_0 = new Class74(pattern, false);
            this.Class74_1 = new Class74(options, false);
        }

        public Class74 Class74_0
        {
            [CompilerGenerated]
            get
            {
                return this.class74_0;
            }
            [CompilerGenerated]
            set
            {
                this.class74_0 = value;
            }
        }

        public Class74 Class74_1
        {
            [CompilerGenerated]
            get
            {
                return this.class74_1;
            }
            [CompilerGenerated]
            set
            {
                this.class74_1 = value;
            }
        }

        public override Enum11 Enum11_0
        {
            get
            {
                return Enum11.Regex;
            }
        }
    }
}

