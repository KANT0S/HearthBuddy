namespace ns15
{
    using System;
    using System.Runtime.CompilerServices;

    internal class Class75 : Class73
    {
        [CompilerGenerated]
        private Enum9 enum9_0;

        public Class75(byte[] value, Enum9 binaryType) : base(value, Enum11.Binary)
        {
            this.Enum9_0 = binaryType;
        }

        public Enum9 Enum9_0
        {
            [CompilerGenerated]
            get
            {
                return this.enum9_0;
            }
            [CompilerGenerated]
            set
            {
                this.enum9_0 = value;
            }
        }
    }
}

