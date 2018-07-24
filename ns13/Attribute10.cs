namespace ns13
{
    using ns14;
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    internal sealed class Attribute10 : Attribute
    {
        [CompilerGenerated]
        private Enum7 enum7_0;
        [CompilerGenerated]
        private Enum8 enum8_0;

        public Attribute10() : this(Enum7.Default, Enum8.Default)
        {
        }

        public Attribute10(Enum7 useKindFlags) : this(useKindFlags, Enum8.Default)
        {
        }

        public Attribute10(Enum8 targetFlags) : this(Enum7.Default, targetFlags)
        {
        }

        public Attribute10(Enum7 useKindFlags, Enum8 targetFlags)
        {
            this.Enum7_0 = useKindFlags;
            this.Enum8_0 = targetFlags;
        }

        public Enum7 Enum7_0
        {
            [CompilerGenerated]
            get
            {
                return this.enum7_0;
            }
            [CompilerGenerated]
            private set
            {
                this.enum7_0 = value;
            }
        }

        public Enum8 Enum8_0
        {
            [CompilerGenerated]
            get
            {
                return this.enum8_0;
            }
            [CompilerGenerated]
            private set
            {
                this.enum8_0 = value;
            }
        }
    }
}

