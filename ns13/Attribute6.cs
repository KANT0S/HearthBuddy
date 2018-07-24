namespace ns13
{
    using System;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Method, AllowMultiple=true, Inherited=true)]
    internal sealed class Attribute6 : Attribute
    {
        [CompilerGenerated]
        private bool bool_0;
        [CompilerGenerated]
        private string string_0;

        public Attribute6([Attribute2] string contract) : this(contract, false)
        {
        }

        public Attribute6([Attribute2] string contract, bool forceFullStates)
        {
            this.String_0 = contract;
            this.Boolean_0 = forceFullStates;
        }

        public bool Boolean_0
        {
            [CompilerGenerated]
            get
            {
                return this.bool_0;
            }
            [CompilerGenerated]
            private set
            {
                this.bool_0 = value;
            }
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

